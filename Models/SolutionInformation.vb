Namespace Models

    Public Class SolutionInformation

        Private ReadOnly _Filename As String = ""
        Private ReadOnly _Group As String = ""
        Private ReadOnly _Name As String = ""
        Private ReadOnly _RequiresAdmin As Boolean = False

        Public ReadOnly Property Filename As String
            Get
                Return _Filename
            End Get
        End Property

        Public ReadOnly Property Group As String
            Get
                Return _Group
            End Get
        End Property

        Public ReadOnly Property Name As String
            Get
                Return _Name
            End Get
        End Property

        Public ReadOnly Property RequiresAdmin As Boolean
            Get
                Return _RequiresAdmin
            End Get
        End Property

        Public Sub New(filename As String)
            _Filename = filename

            Dim Levels As String = Replace(filename, "D:\Projects\", "",, CompareMethod.Text).Trim()

            _Name = Levels.Substring(Levels.LastIndexOf("\"c) + 1)
            _Name = _Name.Substring(0, _Name.Length - 4)

            Levels = Levels.Substring(0, Levels.LastIndexOf("\"c))

            If Levels.Contains("\"c) Then
                Levels = Levels.Replace("\"c, " > ")
            End If

            _Group = Levels

            Select Case True
                Case _Name.IsEqualTo("Utilities")
                    _RequiresAdmin = True
                Case Else
                    _RequiresAdmin = False
            End Select
        End Sub

    End Class

End Namespace