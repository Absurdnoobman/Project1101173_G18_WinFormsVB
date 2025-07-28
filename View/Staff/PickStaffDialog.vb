Public Class PickStaffDialog


    Private Sub PickStaffDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffFLP.Controls.Clear()

        Dim dt As New List(Of Staff) From {
            New Staff With {.id = "S990", .firstname = "Mannee", .surname = "jolo in squad"},
            New Staff With {.id = "S490", .firstname = "GG", .surname = "WP"}
        }

        For Each staff In dt
            Dim card As New StaffCardWithCheckBox
            card.SetData(staff)
            StaffFLP.Controls.Add(card)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class