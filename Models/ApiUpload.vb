Namespace Models

    Public Class ApiUpload

        Public Property ApiKey As String = ""
        Public Property LuaFile As String = ""

        Public Sub New()

        End Sub

        Public Sub New(apiKey As String, fileName As String)
            Me.ApiKey = apiKey
            Me.LuaFile = IO.File.ReadAllText(fileName, System.Text.Encoding.UTF8)
        End Sub

    End Class

End Namespace