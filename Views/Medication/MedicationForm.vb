Public Class MedicationForm
	Private _patient As Patient
	Private toRemoveMedications As New List(Of Medication)
	Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
		Dim f = PickPharmaceuticalSupply.MultiplePick
		f.ShowDialog()
		If f.DialogResult = DialogResult.Abort OrElse f.DialogResult = DialogResult.Cancel Then Exit Sub

		Dim medicines = f.result

		If medicines.Count = 0 Then Exit Sub

		For Each drug In medicines
			Dim drug_card As New PharmaceuticalSupplyCardWithOption(drug, CardStatus.NewlyAdded)
			MedicationFLP.Controls.Add(drug_card)
		Next

	End Sub

	Private Sub SelectPatientButton_Click(sender As Object, e As EventArgs) Handles SelectPatientButton.Click
		Dim f As New PickPatientDialog
		Dim exit_result = f.ShowDialog
		If exit_result = DialogResult.Abort OrElse exit_result = DialogResult.Cancel Then Exit Sub

		_patient = f.result.First

		ClearAndReset()

		Dim card As New PatientLargeCard(_patient)
		PatientFLP.Controls.Add(card)

		Dim db As New Schema
		Try
			Dim result = db.Query(Of Object)("SELECT * FROM MedicationRecords WHERE patient_num = @p", New With {.p = _patient.patient_number})
			If result.Count = 0 Then Exit Sub

			For Each row In result

				Dim d_result = db.Query(Of Object)("SELECT * FROM PharmaceuticalSupplies WHERE drug_number = @d", New With {.d = row("drug_num")})

				If d_result.Count = 0 Then Throw New Exception("Impossible.")

				Dim d = d_result.First

				Dim supplier = db.Query(Of Supplier, Object)(
					"SELECT * FROM Suppliers WHERE supplier_number = @sn",
					New With {.sn = d("supplier_num")}
				)

				Dim drug As New PharmaceuticalSupply With {
					.drug_number = d("drug_number"),
					.name = d("name"),
					.description = d("description"),
					.dosage = d("dosage"),
					.method = d("method"),
					.quantity = d("quantity"),
					.cost_per_unit = d("cost_per_unit"),
					.reorder_level = d("reorder_level"),
					.supplier = supplier.FirstOrDefault()
				}

				Dim record_card As New PharmaceuticalSupplyCardWithOption(drug, row("start_date"), row("end_date"), row("unit_per_day"), CardStatus.Original)

				AddHandler record_card.RemoveButtonPressed, AddressOf HandleRemove

				MedicationFLP.Controls.Add(record_card)
			Next
		Catch ex As Exception
			MessageBox.Show("Error: SQL" & vbNewLine & If(Debugger.IsAttached, $"{ex.Message} {vbNewLine}{ex.StackTrace}", ""))
			Exit Sub
		End Try

	End Sub

	Private Sub HandleRemove(sender As Object)
		Dim card = DirectCast(sender, PharmaceuticalSupplyCardWithOption)

		toRemoveMedications.Add(New Medication With {
			.drug_num = card.thisDrug.drug_number,
			.patient_num = _patient.patient_number,
			.start_date = card.StartDateTimePicker.Value
		})
	End Sub

	Private Sub ClearAndReset()
		PatientFLP.Controls.Clear()
		MedicationFLP.Controls.Clear()
	End Sub

	Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
		Close()
		Dispose()
	End Sub

	Private Sub PatientFLP_ControlAdded(sender As Object, e As ControlEventArgs) Handles PatientFLP.ControlAdded
		AddButton.Enabled = True
	End Sub

	Private Sub PatientFLP_ControlRemoved(sender As Object, e As ControlEventArgs) Handles PatientFLP.ControlRemoved
		AddButton.Enabled = False
	End Sub

	Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
		If Auth.User.position <> "Charge Nurse" AndAlso Auth.User.position <> "System Administrator" Then
			MessageBox.Show("Can not access due to your position.")
			Exit Sub
		End If

		Dim medication_cards = MedicationFLP.Controls.Cast(Of PharmaceuticalSupplyCardWithOption).ToList
		Dim patient_num = PatientFLP.Controls.Cast(Of PatientLargeCard).First.thisPatient.patient_number

		Dim db As New Schema
		Try
			For Each medication In toRemoveMedications
				If Not db.NonSelectQuery(
					"DELETE FROM MedicationRecords 
					WHERE patient_num = @p AND drug_num = @d AND start_date = @sd",
					New With {.p = medication.patient_num, .d = medication.drug_num, .sd = medication.start_date}
				) Then
					MessageBox.Show("Can not delete a record." & vbNewLine &
									$"patient_num = {medication.patient_num}, drug_Num = {medication.drug_num}, start_date = {medication.start_date}")
				End If
			Next

			For Each card In medication_cards
				card.CheckStatus()
				Select Case card.cardStatus
					Case CardStatus.NewlyAdded
						If Not db.NonSelectQuery(
							"INSERT INTO MedicationRecords VALUES (@p, @d, @s, @e, @upd)",
							New With {.p = patient_num, .d = card.thisDrug.drug_number,
								.s = card.StartDateTimePicker.Value,
								.e = card.FinishDateTimePicker.Value,
								.upd = card.UnitPerDayNumericUpDown.Value
							}
						) Then
							MessageBox.Show($"Error: Can not insert ""{card.thisDrug.name}"" record")
							Continue For
						End If
					Case CardStatus.Edited
						If Not db.NonSelectQuery(
							"UPDATE MedicationRecords SET start_date = @s, end_date = @e, unit_per_day = @upd WHERE patient_num = @p AND drug_num = @d",
							New With {
								.p = patient_num, .d = card.thisDrug.drug_number,
								.s = card.StartDateTimePicker.Value,
								.e = card.FinishDateTimePicker.Value,
								.upd = card.UnitPerDayNumericUpDown.Value
							}
						) Then
							MessageBox.Show($"Error: Can not update ""{card.thisDrug.name}, {card.StartDateTimePicker.Value:g}"" record")
							Continue For
						End If
					Case CardStatus.Original
						Continue For
				End Select
			Next

			MessageBox.Show("Insert And Update Medication Records Sucessfully.")
			Dispose()

		Catch ex As Exception
			If Debugger.IsAttached Then
				MessageBox.Show($"{ex.Message} {vbNewLine}{ex.StackTrace}")
			Else
				MessageBox.Show("Fatal Error!")
			End If
			Exit Sub
		End Try
	End Sub
End Class