Public Class NHSJobEvaluation
    ''' <summary>
    ''' a Dictionary store a scoring for each factors
    ''' <code>
    ''' Dim level As Integer = 3
    ''' Dim score = NHSJobEvaluation.Evaluations("Analytical skills")(level - 1)  'will return 27
    ''' </code>
    ''' </summary>
    ''' <returns></returns>
    Shared ReadOnly Property Evaluations As New Dictionary(Of String, Integer()) From {
        {"Communication and relationship skills", {5, 12, 21, 32, 45, 60}},
        {"Knowledge, training and experience", {16, 36, 60, 88, 120, 156, 196, 240}},
        {"Analytical skills", {6, 15, 27, 42, 60}},
        {"Planning and organisation skills", {6, 15, 27, 42, 60}},
        {"Physical skills", {6, 15, 27, 42, 60}},
        {"Responsibility – patient/client care", {4, 9, 15, 22, 30, 39, 49, 60}},
        {"Responsibility – policy and service", {5, 12, 21, 32, 45, 60}},
        {"Responsibility – finance and physical", {5, 12, 21, 32, 45, 60}},
        {"Responsibility – staff/HR/leadership/training", {5, 12, 21, 32, 45, 60}},
        {"Responsibility – information resources", {4, 9, 16, 24, 34, 46, 60}},
        {"Responsibility – research and development", {5, 12, 21, 32, 45, 60}},
        {"Freedom to act", {5, 12, 21, 32, 45, 60}},
        {"Physical effort", {3, 7, 12, 18, 25}},
        {"Mental effort", {3, 7, 12, 18, 25}},
        {"Emotional effort", {5, 11, 18, 25}},
        {"Working conditions", {3, 7, 12, 18, 25}}
    }

    Shared Function GetJobBand(score As Integer) As String
        Select Case score
            Case 0 To 160
                Return "Band 1"
            Case 161 To 215
                Return "Band 2"
            Case 216 To 270
                Return "Band 3"
            Case 271 To 325
                Return "Band 4"
            Case 326 To 395
                Return "Band 5"
            Case 396 To 465
                Return "Band 6"
            Case 466 To 539
                Return "Band 7"
            Case 540 To 584
                Return "Band 8a"
            Case 585 To 629
                Return "Band 8b"
            Case 630 To 674
                Return "Band 8c"
            Case 675 To 720
                Return "Band 8d"
            Case 721 To 765
                Return "Band 9"
            Case Else
                Return "Out of Range"
        End Select
    End Function

End Class
