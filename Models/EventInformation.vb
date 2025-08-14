Imports Humanizer

Namespace Models

    Public Class EventInformation

        Public ReadOnly Property Description As String
        Public ReadOnly Property EventLevel As String
        Public ReadOnly Property EventSource As String
        Public ReadOnly Property EventDate As Date

        Public Sub New(ByRef template As Eventing.Reader.EventRecord)
            _Description = template.FormatDescription()
            _EventLevel = template.LevelDisplayName
            _EventSource = template.ProviderName

            If template.TimeCreated.HasValue Then
                _EventDate = template.TimeCreated.Value
            End If
        End Sub

    End Class

End Namespace