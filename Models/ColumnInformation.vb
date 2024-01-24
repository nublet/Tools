Namespace Models

    Public Class ColumnInformation

        Private _IsPrimary As Boolean = False

        Private ReadOnly _ColumnName As String = ""
        Private ReadOnly _ColumnName_Clean As String = ""
        Private ReadOnly _ColumnName_Safe As String = ""
        Private ReadOnly _DataType_CLR As String = ""
        Private ReadOnly _DataType_DB As String = ""
        Private ReadOnly _DefaultValue As String = ""
        Private ReadOnly _IsIdentity As Boolean = False
        Private ReadOnly _Position As Integer = 0

        Public ReadOnly Property ColumnName As String
            Get
                Return _ColumnName
            End Get
        End Property

        Public ReadOnly Property ColumnName_Clean As String
            Get
                Return _ColumnName_Clean
            End Get
        End Property

        Public ReadOnly Property ColumnName_Safe As String
            Get
                Return _ColumnName_Safe
            End Get
        End Property

        Public ReadOnly Property DataType_CLR As String
            Get
                Return _DataType_CLR
            End Get
        End Property

        Public ReadOnly Property DataType_DB As String
            Get
                Return _DataType_DB
            End Get
        End Property

        Public ReadOnly Property DefaultValue As String
            Get
                Return _DefaultValue
            End Get
        End Property

        Public ReadOnly Property IsIdentity As Boolean
            Get
                Return _IsIdentity
            End Get
        End Property

        Public ReadOnly Property IsPrimary As Boolean
            Get
                Return _IsPrimary
            End Get
        End Property

        Public ReadOnly Property Position As Integer
            Get
                Return _Position
            End Get
        End Property

        Public Sub New(columnName As String, dataType_DB As String, dataType_CLR As String, defaultValue As String, isIdentity As Boolean, isPrimary As Boolean, position As Integer)
            _ColumnName = columnName
            _DataType_CLR = dataType_CLR
            _DataType_DB = dataType_DB
            _DefaultValue = defaultValue
            _IsIdentity = isIdentity
            _IsPrimary = isPrimary
            _Position = position

            _ColumnName_Clean = _ColumnName
            _ColumnName_Clean = _ColumnName_Clean.ReplaceInvalidCharacters("_")

            _ColumnName_Safe = GetSafeName(_ColumnName_Clean)
        End Sub

        Public Sub SetPrimary()
            _IsPrimary = True
        End Sub

    End Class

End Namespace