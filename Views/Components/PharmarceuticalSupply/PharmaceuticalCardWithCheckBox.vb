Public Class PharmaceuticalCardWithCheckBox
	Public isSelected As Boolean = False

	Sub New(drug As PharmaceuticalSupply)
		' This call is required by the designer.
		InitializeComponent()

		DrugNumberLabel.Text = drug.drug_number
		NameLabel.Text = drug.name

		DescriptionLabel.Text = $"Desciption: ""{drug.description}"""
		MethodLabel.Text = $"Method: {drug.method}"
		DosageLabel.Text = $"Dosage: {drug.dosage:0.##} mg/mL"

	End Sub

	Private Sub SelectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SelectCheckBox.CheckedChanged
		isSelected = SelectCheckBox.Checked
	End Sub
End Class
