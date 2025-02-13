Namespace Models

    Public Class BuildInformation

        Public ReadOnly Property OutputFilename As String
        Public ReadOnly Property ShouldPublish As Boolean
        Public ReadOnly Property SolutionFilename As String
        Public ReadOnly Property UseDotNet As Boolean = False

        Public Sub New(outputFilename As String, shouldPublish As Boolean, solutionFilename As String, useDotNet As Boolean)
            _OutputFilename = outputFilename
            _ShouldPublish = shouldPublish
            _SolutionFilename = solutionFilename
            _UseDotNet = useDotNet
        End Sub

    End Class

End Namespace