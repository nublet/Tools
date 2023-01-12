Namespace Tools.UserControls.ModelGenerator

    Public Class FromAccess
        Implements IInterface

        Private _ModelDetails As String = ""

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Private Sub DatabaseTextBox_TextChanged(sender As Object, e As EventArgs) Handles DatabaseTextBox.TextChanged
            RaiseEvent DatabaseChanged(IO.Path.GetFileNameWithoutExtension(DatabaseTextBox.Text.Trim()).ReplaceInvalidCharacters("_"))
        End Sub

        Private Sub DatabaseButton_Click(sender As Object, e As EventArgs) Handles DatabaseButton.Click
            DatabaseTextBox.BrowseForFile("Access Databases|*.mdb;*.accdb|All Files|*.*")
        End Sub

#Region " IInterface "

        Public Event DatabaseChanged(databaseName As String) Implements IInterface.DatabaseChanged

        Public Overloads Property Name As String Implements IInterface.Name
            Get
                Return MyBase.Name
            End Get
            Set(value As String)
                MyBase.Name = value
            End Set
        End Property

        Public ReadOnly Property Description As String Implements IInterface.Description
            Get
                Return "From Access"
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
                Dim DBFileName As String = DatabaseTextBox.Text.Trim()

                If DBFileName.IsNotSet() Then
                    Throw New Exception("No Database has been selected.")
                End If

                'Dim CSBuilder As New OleDb.OleDbConnectionStringBuilder With {
                '    .Provider = "Provider=Microsoft.Jet.OLEDB.4.0;",
                '    .DataSource = DBFileName
                '}

                '_ModelDetails = CSBuilder.ToString()

                '_ModelDetails = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}".FormatWith(DBFileName)
                _ModelDetails = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}".FormatWith(DBFileName)

                Using conn As New OleDb.OleDbConnection(_ModelDetails)
                    conn.Open()

                    For Each TableRow As DataRowView In conn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"}).DefaultView
                        Dim TableName As String = CommonRoutines.Type.ToStringDB(TableRow("TABLE_NAME"))

                        Dim TableInfo As New Models.TableInformation("", TableName)

                        Dim PrimaryKeys As New Dictionary(Of String, String)
                        For Each Current As DataRowView In conn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Primary_Keys, New Object() {Nothing, Nothing, TableName}).DefaultView
                            Dim ColumnName As String = CommonRoutines.Type.ToStringDB(Current("COLUMN_NAME"))

                            If ColumnName.IsNotSet() Then
                                Continue For
                            End If

                            PrimaryKeys.Add(ColumnName.ToLower(), ColumnName)
                        Next

                        For Each Current As DataRowView In conn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, TableName, Nothing}).DefaultView
                            Dim ColumnDetail As New ColumnDetail(TableName, Current)

                            If PrimaryKeys.ContainsKey(ColumnDetail.COLUMN_NAME.ToLower()) Then
                                ColumnDetail.IsPrimary = True
                            End If

                            TableInfo.Columns.Add(ColumnDetail.GetColumnInformation())
                        Next

                        Results.Add(TableInfo)
                    Next
                End Using
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return Results
        End Function

#End Region

        Private Class ColumnDetail

            Public Property TABLE_NAME As String = ""
            Public Property COLUMN_NAME As String = ""
            Public Property ORDINAL_POSITION As Integer = -1
            Public Property DATA_TYPE As String = ""
            Public Property IDENTITY As Boolean = False

            Public Property IsPrimary As Boolean = False

            Public Sub New(tableName As String, ByRef dataRowView As DataRowView)
                _TABLE_NAME = tableName
                _COLUMN_NAME = CommonRoutines.Type.ToStringDB(dataRowView("COLUMN_NAME"))
                _ORDINAL_POSITION = CommonRoutines.Type.ToIntegerDB(dataRowView("ORDINAL_POSITION"))
                _DATA_TYPE = CommonRoutines.Type.ToStringDB(dataRowView("DATA_TYPE"))
                _IDENTITY = (CommonRoutines.Type.ToStringDB(dataRowView("COLUMN_FLAGS")) = "90") AndAlso (CommonRoutines.Type.ToStringDB(dataRowView("DATA_TYPE")) = "3")
            End Sub

            Public Function GetColumnInformation() As Models.ColumnInformation
                Dim CLRDataType As String = ""
                Dim DefaultValue As String = ""

                Select Case _DATA_TYPE.ToLower
                    Case "2", "3"
                        CLRDataType = "Integer"
                        DefaultValue = "-1"
                    Case "4"
                        CLRDataType = "Single"
                        DefaultValue = "-1"
                    Case "5"
                        CLRDataType = "Double"
                        DefaultValue = "-1"
                    Case "6", "14", "131", "139"
                        CLRDataType = "Decimal"
                        DefaultValue = "-1"
                    Case "7", "64", "133", "135"
                        CLRDataType = "Date"
                        DefaultValue = "Nothing"
                    Case "8", "129", "130", "200", "201", "202", "203"
                        CLRDataType = "String"
                        DefaultValue = """"""
                    Case "9", "12", "13", "138"
                        CLRDataType = "Object"
                        DefaultValue = "Nothing"
                    Case "10"
                        CLRDataType = "Exception"
                        DefaultValue = "Nothing"
                    Case "11"
                        CLRDataType = "Boolean"
                        DefaultValue = "False"
                    Case "16"
                        CLRDataType = "SByte"
                        DefaultValue = "Nothing"
                    Case "17"
                        CLRDataType = "Byte"
                        DefaultValue = "Nothing"
                    Case "18"
                        CLRDataType = "UInt16"
                        DefaultValue = "0"
                    Case "19", "20"
                        CLRDataType = "UInt32"
                        DefaultValue = "0"
                    Case "21"
                        CLRDataType = "UInt64"
                        DefaultValue = "0"
                    Case "72"
                        CLRDataType = "Guid"
                        DefaultValue = "Nothing"
                    Case "128", "204", "205"
                        CLRDataType = "Byte()"
                        DefaultValue = "{}"
                    Case "134"
                        CLRDataType = "TimeSpan"
                        DefaultValue = "Nothing"
                    Case Else
                        Dim Message As String = "Unhandled Data Type: {0}, Table: {1}, Column: {2}".FormatWith(_DATA_TYPE.ToLower, _TABLE_NAME, _COLUMN_NAME)
                        Message.ToLog()
                End Select

                Return New Models.ColumnInformation(COLUMN_NAME, "", CLRDataType, DefaultValue, IDENTITY, IsPrimary, ORDINAL_POSITION - 1)
            End Function

        End Class

    End Class

End Namespace