Namespace Tools.Models

    Public Class LuaFile

        Private ReadOnly _Filename As String = ""
        Private ReadOnly _User As String = ""

        Public Property LastModified As Date = Nothing

        Public ReadOnly Property Filename As String
            Get
                Return _Filename
            End Get
        End Property

        Public ReadOnly Property User As String
            Get
                Return _User
            End Get
        End Property

        Public Sub New(filename As String, user As String)
            _Filename = filename
            _User = user
        End Sub

    End Class

End Namespace