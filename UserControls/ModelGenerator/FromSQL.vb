Imports System.ComponentModel

Namespace UserControls.ModelGenerator

    Public Class FromSQL
        Implements IInterface

        Private _ModelDetails As String = ""

        Private ReadOnly _Databases As New List(Of DatabaseDetail)
        Private ReadOnly _Servers As New List(Of ServerDetail)

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            ServerComboBox.DataSource = Nothing

            Dim Servers As New List(Of ServerDetail) From {
                New ServerDetail("Server 24", "HOME", "HelloPoesboiIt'sBjorn", "192.168.50.246", "poesServices")
            }

            _Servers.Clear()
            _Servers.AddRange(Servers.OrderBy(Function(o) o.Description))

            ServerComboBox.DisplayMember = "Description"
            ServerComboBox.ValueMember = "Name"
            ServerComboBox.DataSource = _Servers
        End Sub

        Private Sub DatabaseComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DatabaseComboBox.SelectedIndexChanged
            Try
                If DatabaseComboBox.SelectedItem Is Nothing Then
                    Return
                End If

                Dim SelectedDatabase = DirectCast(DatabaseComboBox.SelectedItem, DatabaseDetail)
                Dim SelectedServer = DirectCast(ServerComboBox.SelectedItem, ServerDetail)

                Dim DBA As New DBAccess.SQL(SelectedServer.GetConnectionString(SelectedDatabase.Name))

                _ModelDetails = DBA.ConnectionString

                RaiseEvent DatabaseChanged(SelectedDatabase.Name.ReplaceInvalidCharacters("_"))
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub ServerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServerComboBox.SelectedIndexChanged
            Try
                Enabled = False

                DatabaseComboBox.DataSource = Nothing

                If ServerComboBox.SelectedItem Is Nothing Then
                    Return
                End If

                Dim Item = DirectCast(ServerComboBox.SelectedItem, ServerDetail)

                Dim DBA As New DBAccess.SQL(Item.ConnectionString)

                _Databases.Clear()
                _Databases.AddRange(DBA.ExecuteReader(Of DatabaseDetail)("SELECT * FROM master.dbo.sysdatabases").OrderBy(Function(o) o.Name))
            Catch ex As Exception
                ex.ToLog()
            Finally
                DatabaseComboBox.DisplayMember = "Name"
                DatabaseComboBox.ValueMember = "Name"
                DatabaseComboBox.DataSource = _Databases

                Enabled = True
            End Try
        End Sub

#Region " IInterface "

        Public Event DatabaseChanged(databaseName As String) Implements IInterface.DatabaseChanged

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> Public Overloads Property Name As String Implements IInterface.Name
            Get
                Return MyBase.Name
            End Get
            Set(value As String)
                MyBase.Name = value
            End Set
        End Property

        Public ReadOnly Property Description As String Implements IInterface.Description
            Get
                Return "From SQL"
            End Get
        End Property

        Public ReadOnly Property UserControl As UserControl Implements IInterface.UserControl
            Get
                Return Me
            End Get
        End Property

        Public ReadOnly Property ModelDetails As String Implements IInterface.ModelDetails
            Get
                Return _ModelDetails
            End Get
        End Property

        Public Sub LoadArea() Implements IInterface.LoadArea
            DockAndBringToFront()
        End Sub

        Public Function GetTables() As IEnumerable(Of Models.TableInformation) Implements IInterface.GetTables
            Dim Results As New List(Of Models.TableInformation)

            Try
                If ServerComboBox.SelectedItem Is Nothing Then
                    Throw New Exception("No Server has been selected.")
                End If

                If DatabaseComboBox.SelectedItem Is Nothing Then
                    Throw New Exception("No Database has been selected.")
                End If

                Dim SelectedDatabase = DirectCast(DatabaseComboBox.SelectedItem, DatabaseDetail)
                Dim SelectedServer = DirectCast(ServerComboBox.SelectedItem, ServerDetail)

                Dim DBA As New DBAccess.SQL(SelectedServer.GetConnectionString(SelectedDatabase.Name))

                Dim ColumnDetails As New List(Of ColumnDetail)
                For Each Current In DBA.ExecuteReader(Of ColumnDetail)($"USE [{SelectedDatabase.Name}]; SELECT *,COLUMNPROPERTY(OBJECT_ID(TABLE_NAME),COLUMN_NAME,'IsIdentity') AS [IsIdentity] FROM information_schema.columns")
                    Current.CheckDataType()

                    If Current.DataType_CLR.IsNotSet() Then
                        Continue For
                    End If

                    If Current.DataType_DB.IsNotSet() Then
                        Continue For
                    End If

                    ColumnDetails.Add(Current)
                Next

                Dim ConstraintDetails As New List(Of ConstraintDetail)
                ConstraintDetails.AddRange(DBA.ExecuteReader(Of ConstraintDetail)($"USE [{SelectedDatabase.Name}]; SELECT KU.TABLE_NAME,KU.COLUMN_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KU ON TC.CONSTRAINT_NAME = KU.CONSTRAINT_NAME WHERE TC.CONSTRAINT_TYPE = 'PRIMARY KEY'"))

                For Each SchemaName In ColumnDetails.Select(Function(o) o.Table_Schema).Distinct().OrderBy(Function(o) o)
                    For Each TableName In ColumnDetails.Where(Function(o) o.Table_Schema.IsEqualTo(SchemaName)).Select(Function(o) o.Table_Name).Distinct().OrderBy(Function(o) o)
                        If TableName.IsEqualTo("sysdiagrams") Then
                            Continue For
                        End If

                        Dim TableInfo As New Models.TableInformation(SchemaName, TableName)

                        For Each ColumnDetail In ColumnDetails.Where(Function(o) o.Table_Name.IsEqualTo(TableName)).OrderBy(Function(o) o.Ordinal_Position)
                            If ConstraintDetails.Where(Function(o) o.Table_Name.IsEqualTo(TableName)).Where(Function(o) o.Column_Name.IsEqualTo(ColumnDetail.Column_Name)).Any() Then
                                TableInfo.Columns.Add(New Models.ColumnInformation(ColumnDetail.Column_Name, ColumnDetail.DataType_DB, ColumnDetail.DataType_CLR, ColumnDetail.DefaultValue, ColumnDetail.IsIdentity.IsEqualTo(1), True, ColumnDetail.Ordinal_Position - 1))
                            Else
                                TableInfo.Columns.Add(New Models.ColumnInformation(ColumnDetail.Column_Name, ColumnDetail.DataType_DB, ColumnDetail.DataType_CLR, ColumnDetail.DefaultValue, ColumnDetail.IsIdentity.IsEqualTo(1), False, ColumnDetail.Ordinal_Position - 1))
                            End If
                        Next

                        Results.Add(TableInfo)
                    Next
                Next
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return Results
        End Function

#End Region

#Region " Classes "

        Private Class ColumnDetail

            Private _DataType_DB As String = ""
            Private _DataType_CLR As String = ""
            Private _DefaultValue As String = ""

            Public Property Table_Catalog As String = ""
            Public Property Table_Schema As String = ""
            Public Property Table_Name As String = ""
            Public Property Column_Name As String = ""
            Public Property Ordinal_Position As Integer = -1
            Public Property Column_Default As String = ""
            Public Property Is_Nullable As String = ""
            Public Property Data_Type As String = ""
            Public Property Character_Maximum_Length As Integer = -1
            Public Property Character_Octet_Length As Integer = -1
            Public Property Numeric_Precision As Integer = -1
            Public Property Numeric_Precision_Radix As Integer = -1
            Public Property Numeric_Scale As Integer = -1
            Public Property DateTime_Precision As Integer = -1
            Public Property Character_Set_Catalog As String = ""
            Public Property Character_Set_Schema As String = ""
            Public Property Character_Set_Name As String = ""
            Public Property Collation_Catalog As String = ""
            Public Property Collation_Schema As String = ""
            Public Property Collation_Name As String = ""
            Public Property Domain_Catalog As String = ""
            Public Property Domain_Schema As String = ""
            Public Property Domain_Name As String = ""
            Public Property IsIdentity As Integer = -1

            Public ReadOnly Property DataType_DB As String
                Get
                    Return _DataType_DB
                End Get
            End Property

            Public ReadOnly Property DataType_CLR As String
                Get
                    Return _DataType_CLR
                End Get
            End Property

            Public ReadOnly Property DefaultValue As String
                Get
                    Return _DefaultValue
                End Get
            End Property

            Public Sub CheckDataType()
                If _DataType_DB.IsSet() Then
                    Return
                End If

                Select Case Data_Type.ToLower()
                    Case "int"
                        _DataType_CLR = "Integer"
                        _DataType_DB = "[int]"
                        _DefaultValue = "-1"
                    Case "bigint"
                        _DataType_CLR = "Long"
                        _DataType_DB = "[bigint]"
                        _DefaultValue = "-1"
                    Case "smallint"
                        _DataType_CLR = "Integer"
                        _DataType_DB = "[smallint]"
                        _DefaultValue = "-1"
                    Case "nvarchar", "varchar", "nchar"
                        _DataType_CLR = "String"
                        If Character_Maximum_Length < 0 Then
                            _DataType_DB = $"[{Data_Type}](MAX)"
                        Else
                            _DataType_DB = $"[{Data_Type}]({Character_Maximum_Length})"
                        End If
                        _DefaultValue = """"""
                    Case "bit"
                        _DataType_CLR = "Boolean"
                        _DataType_DB = "[bit]"
                        _DefaultValue = "False"
                    Case "datetime"
                        _DataType_CLR = "Date"
                        _DataType_DB = "[datetime]"
                        _DefaultValue = "Nothing"
                    Case "real"
                        _DataType_CLR = "Double"
                        _DataType_DB = "[real]"
                        _DefaultValue = "-1"
                    Case "float"
                        _DataType_CLR = "Double"
                        _DataType_DB = "[float]"
                        _DefaultValue = "-1"
                    Case "image"
                        _DataType_CLR = "Byte()"
                        _DataType_DB = "[image]"
                        _DefaultValue = "{}"
                    Case "text"
                        _DataType_CLR = "String"
                        _DataType_DB = "[text]"
                        _DefaultValue = """"""
                    Case "varbinary"
                        _DataType_CLR = "Byte()"
                        If Character_Maximum_Length < 0 Then
                            _DataType_DB = $"[{Data_Type}](MAX)"
                        Else
                            _DataType_DB = $"[{Data_Type}]({Character_Maximum_Length})"
                        End If
                        _DefaultValue = "{}"
                    Case "decimal"
                        _DataType_CLR = "Double"
                        If Numeric_Precision > 0 Then
                            _DataType_DB = $"[{Data_Type}]({Numeric_Precision},{Numeric_Scale})"
                        Else
                            _DataType_DB = $"[{Data_Type}]"
                        End If
                        _DefaultValue = "0.0!"

                    Case "timestamp"
                        If Column_Name.IsEqualTo("RowVersion") Then
                            _DataType_CLR = ""
                            _DataType_DB = ""
                            _DefaultValue = ""
                        Else
                            System_String.ToLog($"Unhandled Data Type: {_Data_Type}, Table: {_Table_Name}, Column: {_Column_Name}")
                        End If
                    Case Else
                        System_String.ToLog($"Unhandled Data Type: {_Data_Type}, Table: {_Table_Name}, Column: {_Column_Name}")
                End Select
            End Sub

        End Class

        Private Class ConstraintDetail

            Public Property Table_Name As String = ""
            Public Property Column_Name As String = ""

        End Class

        Private Class DatabaseDetail

            Public Property Name As String = ""
            Public Property DBID As Integer = -1
            Public Property SID As String = ""
            Public Property Mode As Integer = -1
            Public Property Status As String = ""
            Public Property Status2 As String = ""
            Public Property CRDate As Date = Nothing
            Public Property Reserved As Date = Nothing
            Public Property Category As String = ""
            Public Property CMPTLevel As String = ""
            Public Property FileName As String = ""
            Public Property Version As String = ""

        End Class

        Private Class ServerDetail

            Private ReadOnly _ConnectionString As String = ""
            Private ReadOnly _Description As String = ""
            Private ReadOnly _Password As String = ""
            Private ReadOnly _ServerName As String = ""
            Private ReadOnly _UserName As String = ""

            Public ReadOnly Property ConnectionString As String
                Get
                    Return _ConnectionString
                End Get
            End Property

            Public ReadOnly Property Description As String
                Get
                    Return _Description
                End Get
            End Property

            Public Sub New(description As String, instanceName As String, password As String, serverName As String, userName As String)
                _Password = password
                _ServerName = $"{serverName}\{instanceName}"
                _UserName = userName

                _ConnectionString = GetConnectionString("master")
                _Description = description
            End Sub

            Public Function GetConnectionString(databaseName As String) As String
                Return DBAccess.GetSQLConnectionString(databaseName, _ServerName, _UserName, _Password)
            End Function

        End Class

#End Region

    End Class

End Namespace