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

End Class
