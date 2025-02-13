Namespace UserControls.Views

    Public Class ModelGenerator

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                _Interfaces.Clear()
                _Interfaces.AddRange(TypeHelper.GetInstances(Of UserControls.ModelGenerator.IInterface).OrderBy(Function(o) o.Description))

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
                NamespaceTextBox.Text = $"Models.{databaseName}"
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
                MainListResults.AddMessage($"Generating Models from Database using: {SelectedItem.Description}")

                Dim OutputDirectory = OutputDirectoryTextBox.Text.Trim()

                If OutputDirectory.IsNotSet() OrElse Not IO.Directory.Exists(OutputDirectory) Then
                    Throw New Exception("Invalid Model Directory has been selected.")
                End If

                If Not OutputDirectory.EndsWith("\"c) Then
                    OutputDirectory = $"{OutputDirectory}\"
                End If

                For Each Current In IO.Directory.GetFiles(OutputDirectory, "*", IO.SearchOption.AllDirectories).ToList()
                    Try
                        IO.File.Delete(Current)
                    Catch exInner As Exception
                        exInner.ToLog(True)
                    End Try
                Next

                For Each Current In IO.Directory.GetDirectories(OutputDirectory, "*", IO.SearchOption.AllDirectories).ToList()
                    Try
                        IO.Directory.Delete(Current)
                    Catch exInner As Exception
                        exInner.ToLog(True)
                    End Try
                Next

                MainListResults.AddMessage($"   Generation Details: {SelectedItem.ModelDetails}")
                MainListResults.AddMessage(String.Empty)

                Dim TableInformations As New List(Of Models.TableInformation)

                MainListResults.AddMessage("Getting Tables...")
                TableInformations.AddRange(SelectedItem.GetTables())

                MainListResults.AddMessage($"Tables Found: {TableInformations.Count}")
                MainListResults.AddMessage(String.Empty)

                Dim NamespaceString = NamespaceTextBox.Text.Trim()
                If NamespaceString.IsSet() Then
                    NamespaceString = $"NameSpace {NamespaceString}"
                Else
                    NamespaceString = "NameSpace Models"
                End If

                Dim TablesWithNoPrimary As New List(Of String)

                For Each TI In TableInformations.OrderBy(Function(o) o.SchemaName).ThenBy(Function(o) o.TableName)
                    Dim FileName = $"{OutputDirectory}{TI.ModelName}.vb"

                    MainListResults.AddMessage("Generating Model for...")
                    MainListResults.AddMessage($"   Table: {TI.SchemaName}.{TI.TableName}")
                    MainListResults.AddMessage($"   Model: {TI.ModelName}")
                    MainListResults.AddMessage($"   Columns: {TI.Columns.Count}")
                    MainListResults.AddMessage($"   Primary Columns: {TI.PrimaryColumns.Count}")

                    If TI.PrimaryColumns.Count <= 0 Then
                        TablesWithNoPrimary.Add(TI.TableName)

                        TI.Columns.OrderBy(Function(o) o.Position).First().SetPrimary()
                    End If

                    Dim StringBuilder_Fields As New Text.StringBuilder()
                    Dim StringBuilder_Properties As New Text.StringBuilder()

                    For Each Current As Models.ColumnInformation In TI.Columns.OrderBy(Function(o) o.ColumnName_Clean)
                        StringBuilder_Fields.AppendLine($"        Private _{Current.ColumnName_Clean} As {Current.DataType_CLR} = {Current.DefaultValue} ' Column { Current.Position}")

                        StringBuilder_Properties.AppendLine($"        <Runtime.Serialization.DataMember> Public Property {Current.ColumnName_Safe} As {Current.DataType_CLR}")
                        StringBuilder_Properties.AppendLine("            Get")
                        StringBuilder_Properties.AppendLine($"                Return _{Current.ColumnName_Clean}")
                        StringBuilder_Properties.AppendLine("            End Get")
                        StringBuilder_Properties.AppendLine($"            Set(value As {Current.DataType_CLR})")
                        StringBuilder_Properties.AppendLine($"                SetProperty(_{Current.ColumnName_Clean},value,""{Current.ColumnName_Clean}"")")
                        StringBuilder_Properties.AppendLine("            End Set")
                        StringBuilder_Properties.AppendLine("        End Property")
                        StringBuilder_Properties.AppendLine()
                    Next

                    Dim StringBuilder_GetDataTable As New Text.StringBuilder()
                    Dim StringBuilder_GetParameters As New Text.StringBuilder()
                    Dim StringBuilder_PopulateDataRow As New Text.StringBuilder()
                    Dim IsFirst As Boolean = True

                    For Each CI In TI.Columns.OrderBy(Function(o) o.Position)
                        If IsFirst Then
                            IsFirst = False
                        Else
                            StringBuilder_GetParameters.AppendLine(",")
                        End If

                        StringBuilder_GetDataTable.AppendLine($"            DT.Columns.Add(""{CI.ColumnName}"")")
                        StringBuilder_GetParameters.Append($"                {{""{CI.ColumnName_Clean}"", _{CI.ColumnName_Clean}}}")
                        StringBuilder_PopulateDataRow.AppendLine($"            dataRow.Item({CI.Position}) = PoesShared.DBAccess.GetDBParameter(_{CI.ColumnName_Clean})")
                    Next
                    StringBuilder_GetParameters.AppendLine()

                    Dim AllFields = String.Join(",", TI.Columns.OrderBy(Function(o) o.Position).Select(Function(o) $"[{o.ColumnName}]"))
                    Dim CreateTemp = String.Join(",", TI.Columns.OrderBy(Function(o) o.Position).Select(Function(o) $"[{o.ColumnName}] {o.DataType_DB} NULL"))
                    Dim InsertFields = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) $"[{o.ColumnName}]"))
                    Dim InsertOutput = String.Join(",", TI.Columns.Where(Function(o) (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) $"[{o.ColumnName}]"))
                    Dim InsertValues = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) $"@{o.ColumnName_Clean}"))
                    Dim InsertValuesMerge = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) $"[Source].[{o.ColumnName}]"))
                    Dim UpdateColumns = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsPrimary OrElse o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) $"[{o.ColumnName}]=@{o.ColumnName_Clean}"))
                    Dim UpdateColumnsMerge = String.Join(",", TI.Columns.Where(Function(o) Not (o.IsPrimary OrElse o.IsIdentity)).OrderBy(Function(o) o.Position).Select(Function(o) $"[Target].[{o.ColumnName}]=[Source].[{o.ColumnName}]"))
                    Dim WherePrimary = String.Join(" AND ", TI.Columns.Where(Function(o) o.IsPrimary).OrderBy(Function(o) o.Position).Select(Function(o) $"([{o.ColumnName}]=@{o.ColumnName_Clean})"))
                    Dim WhereMerge = String.Join(" AND ", TI.Columns.Where(Function(o) o.IsPrimary).OrderBy(Function(o) o.Position).Select(Function(o) $"[Target].[{o.ColumnName}]=[Source].[{o.ColumnName}]"))

                    Dim ModelStringBuilder As New Text.StringBuilder()

                    ModelStringBuilder.AppendLine(NamespaceString)
                    ModelStringBuilder.AppendLine()
                    ModelStringBuilder.AppendLine($"    <Runtime.Serialization.DataContract> Partial Public Class {TI.SafeModelName}")
                    ModelStringBuilder.AppendLine("        Inherits PoesShared.Models.GenericChanged")
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
                    ModelStringBuilder.AppendLine($"        Public Const QueryCountAll = ""SELECT COUNT(*) FROM [{TI.TableName}]""")
                    ModelStringBuilder.AppendLine($"        Public Const QueryCountSingle = ""SELECT COUNT(*) FROM [{TI.TableName}] WHERE ({WherePrimary})""")
                    ModelStringBuilder.AppendLine($"        Public Const QueryCreateTemp = ""CREATE TABLE #{TI.TableName} ({CreateTemp})""")
                    ModelStringBuilder.AppendLine($"        Public Const QueryDelete = ""DELETE FROM [{TI.TableName}] WHERE ({WherePrimary})""")
                    ModelStringBuilder.AppendLine($"        Public Const QueryDropTemp = ""DROP TABLE #{TI.TableName}""")
                    If InsertOutput.IsSet() Then
                        ModelStringBuilder.AppendLine($"        Public Const QueryInsert = ""INSERT INTO [{TI.TableName}] ({InsertFields}) OUTPUT Inserted.{InsertOutput} VALUES ({InsertValues})""")
                    Else
                        ModelStringBuilder.AppendLine($"        Public Const QueryInsert = ""INSERT INTO [{TI.TableName}] ({InsertFields}) VALUES ({InsertValues})""")
                    End If
                    If UpdateColumnsMerge.IsSet() Then
                        ModelStringBuilder.AppendLine($"        Public Const QueryMerge = ""MERGE INTO [{TI.TableName}] As [Target] USING #{TI.TableName} As [Source] ON {WhereMerge} WHEN MATCHED THEN UPDATE SET {UpdateColumnsMerge} WHEN NOT MATCHED THEN INSERT ({InsertFields}) VALUES ({InsertValuesMerge});""")
                    Else
                        ModelStringBuilder.AppendLine($"        Public Const QueryMerge = ""MERGE INTO [{TI.TableName}] As [Target] USING #{TI.TableName} As [Source] ON {WhereMerge} WHEN NOT MATCHED THEN INSERT ({InsertFields}) VALUES ({InsertValuesMerge});""")
                    End If
                    ModelStringBuilder.AppendLine($"        Public Const QuerySelectAll = ""SELECT {AllFields} FROM [{TI.TableName}]""")
                    ModelStringBuilder.AppendLine($"        Public Const QueryUpdate = ""UPDATE [{TI.TableName}] SET {UpdateColumns} WHERE ({WherePrimary})""")

                    ModelStringBuilder.AppendLine($"        Public Const QueryModelName = ""{TI.ModelName}""")
                    ModelStringBuilder.AppendLine($"        Public Const QueryTableName = ""{TI.TableName}""")
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

                    MainListResults.AddMessage($"Model File Created: {FileName}")
                    Using sw As New IO.StreamWriter(FileName, False)
                        sw.WriteLine(ModelStringBuilder.ToString())
                    End Using

                    MainListResults.AddMessage(String.Empty)
                Next

                MainListResults.AddMessage("Tables with no Primary Key:")
                For Each TableName In TablesWithNoPrimary
                    MainListResults.AddMessage($"   {TableName}")
                Next
            Catch ex As Exception
                ex.ToLog()
                MainListResults.AddMessage($"Error: {ex.Message}")
            Finally
                MainListResults.AddMessage("Generation Complete...")
                Enabled = True
            End Try
        End Sub

        Private Sub GeneratorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GeneratorComboBox.SelectedIndexChanged
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