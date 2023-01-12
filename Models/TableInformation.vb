Namespace Tools.Models

    Public Class TableInformation

        Private _Columns As New List(Of ColumnInformation)
        Private _ModelName As String = ""
        Private _SafeModelName As String = ""
        Private _SchemaName As String = ""
        Private _TableName As String = ""

        Public ReadOnly Property Columns As List(Of ColumnInformation)
            Get
                Return _Columns
            End Get
        End Property

        Public ReadOnly Property ModelName As String
            Get
                Return _ModelName
            End Get
        End Property

        Public ReadOnly Property PrimaryColumns As List(Of ColumnInformation)
            Get
                Return _Columns.Where(Function(o) o.IsPrimary).ToList()
            End Get
        End Property

        Public ReadOnly Property SafeModelName As String
            Get
                Return _SafeModelName
            End Get
        End Property

        Public ReadOnly Property SchemaName As String
            Get
                Return _SchemaName
            End Get
        End Property

        Public ReadOnly Property TableName As String
            Get
                Return _TableName
            End Get
        End Property

        Public Sub New(schemaName As String, tableName As String)
            _SchemaName = schemaName
            _TableName = tableName
            _ModelName = tableName

            If Not _ModelName.ToLower.EndsWith("alias") Then
                If _ModelName.IsPlural() Then
                    _ModelName = _ModelName.Singularize()
                End If
            End If
            _ModelName = _ModelName.ReplaceInvalidCharacters("_")

            Select Case _ModelName.ToLower
                Case "step", "error", "delegate", "option"
                    _SafeModelName = "[{0}]".FormatWith(_ModelName)
                Case Else
                    _SafeModelName = _ModelName
            End Select

            _Columns.Clear()
        End Sub

    End Class

End Namespace