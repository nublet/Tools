Namespace UserControls.Views

    Public Class WoWThingUpload

        Private Const _APIKey As String = "8F5CA58145D3C1858C927690D3B55571"
        Private Const _Host As String = "https://wowthing.org/"

        Private ReadOnly _Client As Net.Http.HttpClient = Nothing
        Private ReadOnly _Files As New List(Of Models.LuaFile)
        Private ReadOnly _SerializerSettings As Newtonsoft.Json.JsonSerializerSettings = Nothing
        Private ReadOnly _Timer As Timers.Timer = Nothing

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Try
                ' "E:\GoogleDrive\BackUps\Nix\WoW\POESBOI2\SavedVariables\WoWthing_Collector.lua"
                _Files.Add(New Models.LuaFile("D:\Games\Activision\World of Warcraft\_retail_\WTF\Account\POESBOI\SavedVariables\WoWthing_Collector.lua", "Bjorn"))
                _Files.Add(New Models.LuaFile("\\Study21R1\World of Warcraft\_retail_\WTF\Account\POESBOI2\SavedVariables\WoWthing_Collector.lua", "Nix"))

                _Client = New Net.Http.HttpClient With {
                    .BaseAddress = New Uri(_Host),
                    .Timeout = New TimeSpan(0, 0, 20)
                }

                _Client.DefaultRequestHeaders.Add("User-Agent", "WoWthing Sync")

                _Timer = New Timers.Timer(5 * 60 * 1000)
                AddHandler _Timer.Elapsed, AddressOf Timer_Elapsed
                _Timer.Start()

                _SerializerSettings = New Newtonsoft.Json.JsonSerializerSettings() With {
                    .ContractResolver = New Newtonsoft.Json.Serialization.DefaultContractResolver() With {.NamingStrategy = New Newtonsoft.Json.Serialization.CamelCaseNamingStrategy()}
                }
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Async Function DoCheck() As Task
            Try
                For Each Current As Models.LuaFile In _Files
                    If Not Current.Filename.FileExists() Then
                        Continue For
                    End If

                    Dim LastWriteUTC As Date = IO.File.GetLastWriteTimeUtc(Current.Filename)

                    If LastWriteUTC > Current.LastModified Then
                        MainListResults.AddMessage("Uploading {0}...{1}                {2}".FormatWith(Current.User, Environment.NewLine, Current.Filename))

                        Dim NewItem As New Models.ApiUpload(_APIKey, Current.Filename)
                        Dim JSONString As String = Newtonsoft.Json.JsonConvert.SerializeObject(NewItem, _SerializerSettings)
                        Dim Content As New CompressedContent(New Net.Http.StringContent(JSONString, System.Text.Encoding.UTF8, "application/json"))

                        Dim Response As Net.Http.HttpResponseMessage = Await _Client.PostAsync("/api/upload/", Content)

                        If Response.IsSuccessStatusCode Then
                            MainListResults.AddMessage("   Upload successful.")
                        Else
                            MainListResults.AddMessage("   Upload failed: {0}".FormatWith(Response.Content.ReadAsStringAsync().Result))
                        End If
                    End If

                    Current.LastModified = LastWriteUTC
                Next
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Function

        Public Shared Sub StartTimer()

        End Sub

#Region " Events "

        Private Async Sub Timer_Elapsed(sender As Object, e As Timers.ElapsedEventArgs)
            _Timer.Stop()

            Await DoCheck()

            _Timer.Start()
        End Sub

#End Region

    End Class

End Namespace