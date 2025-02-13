Public Module _Shared

    Public Const WindowCaption As String = "SIA_Tools"

    Private ReadOnly _Keywords As New List(Of String) From {
            "Alias".ToLower(),
            "Date".ToLower(),
            "Default".ToLower(),
            "Delegate".ToLower(),
            "Error".ToLower(),
            "Event".ToLower(),
            "Next".ToLower(),
            "Operator".ToLower(),
            "Option".ToLower(),
            "Step".ToLower()
        }

    Friend Function GetSafeName(itemName As String) As String
        If _Keywords.Contains(itemName.ToLower()) Then
            Return $"[{itemName}]"
        End If

        Return itemName
    End Function

End Module
