Namespace UserControls.Views

    Public Class ModelGenerator

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                _Interfaces.Clear()
                _Interfaces.AddRange(Aprotec.TypeHelper.GetInstances(Of UserControls.ModelGenerator.IInterface).OrderBy(Function(o) o.Description))

                For Each Current As UserControls.ModelGenerator.IInterface In _Interfaces
                    MainPanel.Controls.Add(Current.UserControl)

                    AddHandler Current.DatabaseChanged, AddressOf Database_Changed
                Next

                GeneratorComboBox.DisplayMember = "Description"
                GeneratorComboBox.ValueMember = "Name"
                GeneratorComboBox.DataSource = _Interfaces

                OutputDirectoryTextBox.Text = "D:\Projects\Models"
            Catch ex As Exception
                ex.ToLog(True)
            End Try
        End Sub

        Private Sub Database_Changed(databaseName As String)
            If databaseName.IsSet() Then
                NamespaceTextBox.Text = "Models.{0}".FormatWith(databaseName)
            Else
                NamespaceTextBox.Text = "Models"
            End If
        End Sub

        Private Sub OpenOutputButton_Click(sender As Object, e As EventArgs) Handles OpenOutputButton.Click
            Try
                Dim OutputDirectory As String = OutputDirectoryTextBox.Text.Trim()

                If OutputDirectory.IsNotSet() OrElse Not IO.Directory.Exists(OutputDirectory) Then
                    Return
                End If

                Process.Start(OutputDirectory)
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub OutputDirectoryButton_Click(sender As Object, e As EventArgs) Handles OutputDirectoryButton.Click
            OutputDirectoryTextBox.BrowseForFolder("Output Folder")
        End Sub

        Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
            Try
                Enabled = False

                If GeneratorComboBox.SelectedItem Is Nothing Then
                    Return
                End If

                Dim SelectedItem = DirectCast(GeneratorComboBox.SelectedItem, UserControls.ModelGenerator.IInterface)

                MainListResults.ClearResults()
                MainListResults.AddMessage("Generating Models from Database using: {0}".FormatWith(SelectedItem.Description))

                Dim OutputDirectory As String = OutputDirectoryTextBox.Text.Trim()

                If OutputDirectory.IsNotSet() OrElse Not IO.Directory.Exists(OutputDirectory) Then
                    Throw New Exception("Invalid Model Directory has been selected.")
                End If

                If Not OutputDirectory.EndsWith("\"c) Then
                    OutputDirectory.Append("\")
                End If

                For Each Current As String In IO.Directory.GetFiles(OutputDirectory, "*", IO.SearchOption.AllDirectories).ToList()
                    Try
                        IO.File.Delete(Current)
                    Catch exInner As Exception
                        exInner.ToLog(True)
                    End Try
                Next

                For Each Current As String In IO.Directory.GetDirectories(OutputDirectory, "*", IO.SearchOption.AllDirectories).ToList()
                    Try
                        IO.Directory.Delete(Current)
                    Catch exInner As Exception
                        exInner.ToLog(True)
                    End Try
                Next

                MainListResults.AddMessage("   Generation Details: {0}".FormatWith(SelectedItem.ModelDetails))
                MainListResults.AddMessage("")

                Dim TableInformations As New List(Of Models.TableInformation)

                MainListResults.AddMessage("Getting Tables...")
                TableInformations.AddRange(SelectedItem.GetTables())

                MainListResults.AddMessage("Tables Found: {0}".FormatWith(TableInformations.Count))
                MainListResults.AddMessage("")

                Dim NamespaceString As String = NamespaceTextBox.Text.Trim()
                If NamespaceString.IsSet() Then
                    NamespaceString = "NameSpace {0}".FormatWith(NamespaceString)
                Else
                    NamespaceString = "NameSpace Models"
                End If

                Dim TablesWithNoPrimary As New List(Of String)

                For Each TI As Models.TableInformation In TableInformations.OrderBy(Function(o) o.SchemaName).ThenBy(Function(o) o.TableName)
                    Dim FileName As String = "{0}{1}.vb".FormatWith(OutputDirectory, TI.ModelName)

                    MainListResults.AddMessage("Generating Model for...")
                    MainListResults.AddMessage("   Table: {0}.{1}".FormatWith(TI.SchemaName, TI.TableName))
                    MainListResults.AddMessage("   Model: {0}".FormatWith(TI.ModelName))
                    MainListResults.AddMessage("   Columns: {0}".FormatWith(TI.Columns.Count))
                    MainListResults.AddMessage("   Primary Columns: {0}".FormatWith(TI.PrimaryColumns.Count))

                    If TI.PrimaryColumns.Count <= 0 Then
                        TablesWithNoPrimary.Add(TI.TableName)

                        TI.Columns.OrderBy(Function(o) o.Position).First().SetPrimary()
                    End If

                    Dim StringBuilder_Fields As New Text.StringBuilder()
                    Dim StringBuilder_Properties As New Text.StringBuilder()

                    For Each Current As Models.ColumnInformation In TI.Columns.OrderBy(Function(o) o.ColumnName_Clean)
                        StringBuilder_Fields.AppendLine("        Private _{0} As {1} = {2} ' Column {3}".FormatWith(Current.ColumnName_Clean, Current.DataType_CLR, Current.DefaultValue, Current.Position))

                        StringBuilder_Properties.AppendLine("        <Runtime.Serialization.DataMember> Public Property {0} As {1}".FormatWith(Current.ColumnName_Safe, Current.DataType_CLR))
                        StringBuilder_Properties.AppendLine("            Get")
                        StringBuilder_Properties.AppendLine("                Return _{0}".FormatWith(Current.ColumnName_Clean))
                        StringBuilder_Properties.AppendLine("            End Get")
                        StringBuilder_Properties.AppendLine("            Set(value As {0})".FormatWith(Current.DataType_CLR))
                        StringBuilder_Properties.AppendLine("                SetProperty(_{0},value,""{0}"")".FormatWith(Current.ColumnName_Clean))
                        StringBuilder_Properties.AppendLine("            End Set")
                        StringBuilder_Properties.AppendLine("        End Property")
                        StringBuilder_Properties.AppendLine()
                    Next

                    Dim StringBuilder_GetDataTable As New Text.StringBuilder()
                    Dim StringBuilder_GetParameters As New Text.StringBuilder()
                    Dim StringBuilder_PopulateDataRow As New Text.StringBuilder()
                    Dim IsFirst As Boolean = True

                    For Each CI As Models.ColumnInformation In TI.Columns.OrderBy(Function(o) o.Position)
                        If IsFirst Then
                            IsFirst = False
                        Else
                            StringBuilder_GetParameters.AppendLine(",")
                        End If

                        StringBuilder_GetDataTable.AppendLine("            DT.Columns.Add(""{0}"")".FormatWith(CI.ColumnName))
                        StringBuilder_GetParameters.Append("                {{""{0}"", _{0}}}".FormatWith(CI.ColumnName_Clean))
                        StringBuilder_PopulateDataRow.AppendLine("            dataRow.Item({0}) = Aprotec.DBAccess.GetDBParameter(_{1})".FormatWith(CI.Position, CI.ColumnName_Clean))
                    Next
                    StringBuilder_GetParameters.AppendLine()

                    Dim AllFields As String = String.Join(",", TI.Columns.OrderBy(Function(o) o.Position).Select(Function(o) "[{0}]".FormatWith(o.ColumnName)))
                    Dim CreateTemp As String = String.Join(",", TI.Columns.OrderBy(Function(o) o.Position).Select(Function(o) "[{0}] {1} NULL".FormatWith(o.ColumnName, o.DataType_DB)))
                    Dim InsertFields As String = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) "[{0}]".FormatWith(o.ColumnName)))
                    Dim InsertOutput As String = String.Join(",", TI.Columns.Where(Function(o) (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) "[{0}]".FormatWith(o.ColumnName)))
                    Dim InsertValues As String = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) "@{0}".FormatWith(o.ColumnName_Clean)))
                    Dim InsertValuesMerge As String = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) "[Source].[{0}]".FormatWith(o.ColumnName)))
                    Dim UpdateColumns As String = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsPrimary OrElse o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) "[{0}]=@{1}".FormatWith(o.ColumnName, o.ColumnName_Clean)))
                    Dim UpdateColumnsMerge As String = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsPrimary OrElse o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) "[Target].[{0}]=[Source].[{0}]".FormatWith(o.ColumnName)))
                    Dim WherePrimary As String = String.Join(" AND ", TI.Columns.Where(Function(o) o.IsPrimary).OrderBy(Function(o) o.Position).Select(Function(o) "([{0}]=@{1})".FormatWith(o.ColumnName, o.ColumnName_Clean)))
                    Dim WhereMerge As String = String.Join(" AND ", TI.Columns.Where(Function(o) o.IsPrimary).OrderBy(Function(o) o.Position).Select(Function(o) "[Target].[{0}]=[Source].[{0}]".FormatWith(o.ColumnName)))

                    Dim ModelStringBuilder As New Text.StringBuilder()

                    ModelStringBuilder.AppendLine(NamespaceString)
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("    <Runtime.Serialization.DataContract> Partial Public Class {0}".FormatWith(TI.SafeModelName))
                    ModelStringBuilder.AppendLine("        Inherits Aprotec.Models.GenericChanged")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("#Region "" Properties """)
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.Append(StringBuilder_Fields)
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.Append(StringBuilder_Properties)
                    ModelStringBuilder.AppendLine("#End Region")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("        Public Function GetParameters() As IDictionary(Of String, Object)")
                    ModelStringBuilder.AppendLine("            Return New Dictionary(Of String, Object) From {")
                    ModelStringBuilder.Append(StringBuilder_GetParameters)
                    ModelStringBuilder.AppendLine("            }")
                    ModelStringBuilder.AppendLine("        End Function")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("        Public Sub PopulateDataRow(dataRow As DataRow)")
                    ModelStringBuilder.Append(StringBuilder_PopulateDataRow)
                    ModelStringBuilder.AppendLine("        End Sub")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("#Region "" Shared """)
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("        Public Const QueryCountAll = ""SELECT COUNT(*) FROM [{0}]""".FormatWith(TI.TableName))
                    ModelStringBuilder.AppendLine("        Public Const QueryCountSingle = ""SELECT COUNT(*) FROM [{0}] WHERE ({1})""".FormatWith(TI.TableName, WherePrimary))
                    ModelStringBuilder.AppendLine("        Public Const QueryCreateTemp = ""CREATE TABLE #{0} ({1})""".FormatWith(TI.TableName, CreateTemp))
                    ModelStringBuilder.AppendLine("        Public Const QueryDelete = ""DELETE FROM [{0}] WHERE ({1})""".FormatWith(TI.TableName, WherePrimary))
                    ModelStringBuilder.AppendLine("        Public Const QueryDropTemp = ""DROP TABLE #{0}""".FormatWith(TI.TableName))
                    If InsertOutput.IsSet() Then
                        ModelStringBuilder.AppendLine("        Public Const QueryInsert = ""INSERT INTO [{0}] ({1}) OUTPUT Inserted.{2} VALUES ({3})""".FormatWith(TI.TableName, InsertFields, InsertOutput, InsertValues))
                    Else
                        ModelStringBuilder.AppendLine("        Public Const QueryInsert = ""INSERT INTO [{0}] ({1}) VALUES ({2})""".FormatWith(TI.TableName, InsertFields, InsertValues))
                    End If
                    If UpdateColumnsMerge.IsSet() Then
                        ModelStringBuilder.AppendLine("        Public Const QueryMerge = ""MERGE INTO [{0}] As [Target] USING #{0} As [Source] ON {1} WHEN MATCHED THEN UPDATE SET {2} WHEN NOT MATCHED THEN INSERT ({3}) VALUES ({4});""".FormatWith(TI.TableName, WhereMerge, UpdateColumnsMerge, InsertFields, InsertValuesMerge))
                    Else
                        ModelStringBuilder.AppendLine("        Public Const QueryMerge = ""MERGE INTO [{0}] As [Target] USING #{0} As [Source] ON {1} WHEN NOT MATCHED THEN INSERT ({3}) VALUES ({4});""".FormatWith(TI.TableName, WhereMerge, UpdateColumnsMerge, InsertFields, InsertValuesMerge))
                    End If
                    ModelStringBuilder.AppendLine("        Public Const QuerySelectAll = ""SELECT {0} FROM [{1}]""".FormatWith(AllFields, TI.TableName))
                    ModelStringBuilder.AppendLine("        Public Const QueryUpdate = ""UPDATE [{0}] SET {1} WHERE ({2})""".FormatWith(TI.TableName, UpdateColumns, WherePrimary))

                    ModelStringBuilder.AppendLine("        Public Const QueryModelName = ""{0}""".FormatWith(TI.ModelName))
                    ModelStringBuilder.AppendLine("        Public Const QueryTableName = ""{0}""".FormatWith(TI.TableName))
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("        Public Shared Function GetDataTable() As DataTable")
                    ModelStringBuilder.AppendLine("            Dim DT As New DataTable()")
                    ModelStringBuilder.Append(StringBuilder_GetDataTable)
                    ModelStringBuilder.AppendLine("            Return DT")
                    ModelStringBuilder.AppendLine("        End Function")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("#End Region")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("    End Class")
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine("End Namespace")

                    MainListResults.AddMessage("Model File Created: {0}".FormatWith(FileName))
                    Using sw As New IO.StreamWriter(FileName, False)
                        sw.WriteLine(ModelStringBuilder.ToString())
                        sw.WriteLine("")
                    End Using

                    MainListResults.AddMessage("")
                Next

                MainListResults.AddMessage("Tables with no Primary Key:")
                For Each TableName As String In TablesWithNoPrimary
                    MainListResults.AddMessage("   {0}".FormatWith(TableName))
                Next
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage("Error: {0}".FormatWith(ex.Message))
            Finally
                MainListResults.AddMessage("Generation Complete...")
                Enabled = True
            End Try
        End Sub

        Private Sub GeneratorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GeneratorComboBox.OnSelectedIndexChanged
            If GeneratorComboBox.SelectedItem Is Nothing Then
                Return
            End If

            Dim SelectedItem As UserControls.ModelGenerator.IInterface = DirectCast(GeneratorComboBox.SelectedItem, UserControls.ModelGenerator.IInterface)

            SelectedItem.LoadArea()
        End Sub

        Public Sub StartTimer()

        End Sub

#Region " Shared "

        Private Shared ReadOnly _Interfaces As New List(Of UserControls.ModelGenerator.IInterface)

#End Region

    End Class

End Namespace