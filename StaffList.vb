Public Class StaffList
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpStaffList.Controls.Clear()

        ' DUMMY DATA
        Dim data As New List(Of (firstname As String, surname As String)) From {
            ("Robert", "Smith"),
            ("Jane", "Doe"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover"),
            ("Ben", "Dover")
        }

        For Each staff In data
            Dim card As New StaffCard
            card.SetData(staff.firstname, staff.surname)
            flpStaffList.Controls.Add(card)
        Next
    End Sub
End Class