
Public Class LoginForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim staffNumber As String = StaffNumberTextBox.Text

        If Auth.Attempt(StaffNumberTextBox.Text, PasswordTextBox.Text) Then
            DialogResult = DialogResult.OK
            Dispose()
        Else
            Dim dialogResult = MessageBox.Show(
                text:="Invalid Email and password",
                caption:="Login Failed",
                buttons:=MessageBoxButtons.OK,
                icon:=MessageBoxIcon.Error
            )
        End If
    End Sub
End Class