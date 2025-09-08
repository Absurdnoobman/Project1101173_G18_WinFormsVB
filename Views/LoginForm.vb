Public Class LoginForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If String.IsNullOrEmpty(StaffNumberTextBox.Text) Then
            MessageBox.Show("Please Enter Staff Number.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Please Enter Password.")
            Exit Sub
        End If

        Login()
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            If String.IsNullOrEmpty(StaffNumberTextBox.Text) Then
                MessageBox.Show("Please Enter Staff Number.")
                Exit Sub
            End If

            If String.IsNullOrEmpty(PasswordTextBox.Text) Then
                MessageBox.Show("Please Enter Password.")
                Exit Sub
            End If

            Login()

        End If
    End Sub

    Private Sub Login()
        Dim staffNumber As String = StaffNumberTextBox.Text

        If Auth.Attempt(StaffNumberTextBox.Text, PasswordTextBox.Text) Then
            DialogResult = DialogResult.OK
            Dispose()
        Else
            MessageBox.Show(
                text:="Invalid Email and password",
                caption:="Login Failed",
                buttons:=MessageBoxButtons.OK,
                icon:=MessageBoxIcon.Error
            )
        End If
    End Sub

End Class