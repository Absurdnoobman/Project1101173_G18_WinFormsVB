Public Class StaffList
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpStaffList.Controls.Clear()

        ' DUMMY DATA For Testing Purposes
        Dim data As New List(Of Staff) From {
            New Staff With {.id = "S666", .firstname = "Moira", .surname = "Samuel"},
            New Staff With {.id = "S969", .firstname = "Ben", .surname = "Dover"},
            New Staff With {.id = "S123", .firstname = "Justin", .surname = "Case"},
            New Staff With {.id = "S555", .firstname = "Ella", .surname = "Vader"},
            New Staff With {.id = "S---", .firstname = "Bill", .surname = "Board"},
            New Staff With {.id = "S---", .firstname = "Walter", .surname = "White"},
            New Staff With {.id = "S---", .firstname = "Joe", .surname = "Mama"}
        }

        For Each staff In data
            Dim card As New StaffCard
            card.SetData(staff)
            flpStaffList.Controls.Add(card)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New CreateNewStaffForm
        f.ShowDialog()
    End Sub
End Class