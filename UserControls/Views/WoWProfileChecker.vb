Namespace Tools.UserControls.Views

    Public Class WoWProfileChecker

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub AddMessage(message As String)
            MainListResults.AddMessage("[{0}] - {1}".FormatWith(CommonRoutines.GetCurrentDate().GetSQLString("HH:mm:ss"), message))
        End Sub

        Private Sub CheckProfiles(accountFolder As String, isBjorn As Boolean, templateFolder As String)
            Try
                Dim FileContents As String = ""

                AddMessage("   Checking Profile Names...")
                For Each Current As String In IO.Directory.GetFiles("{0}SavedVariables\".FormatWith(accountFolder), "*.lua", IO.SearchOption.TopDirectoryOnly).OrderBy(Function(o) o)
                    CheckProfileNames(Current, isBjorn)
                Next

                AddMessage("   Checking Template Files...")
                For Each TemplateFile As String In IO.Directory.GetFiles(templateFolder, "*.*", IO.SearchOption.TopDirectoryOnly)
                    Dim FileName As String = TemplateFile.Substring(TemplateFile.LastIndexOf("\"c) + 1)

                    AddMessage("      Checking Files: {0}...".FormatWith(FileName))
                    Dim FileNames As New List(Of String)

                    For Each RealmFolder As String In IO.Directory.GetDirectories(accountFolder, "*.*", IO.SearchOption.TopDirectoryOnly)
                        Dim RealmName As String = RealmFolder.Substring(RealmFolder.LastIndexOf("\"c) + 1)

                        If RealmName.IsEqualTo("SavedVariables") Then
                            Continue For
                        End If

                        For Each CharacterFolder As String In IO.Directory.GetDirectories(RealmFolder, "*.*", IO.SearchOption.TopDirectoryOnly)
                            Dim AccountFile As String = "{0}\{1}".FormatWith(CharacterFolder, FileName)

                            If AccountFile.FileExists() Then
                                Try
                                    AddMessage("         Deleting: {0}...".FormatWith(AccountFile))

                                    IO.File.Delete(AccountFile)
                                Catch exInner As Exception
                                    exInner.ToLog()
                                End Try
                            End If

                            FileNames.Add(AccountFile)
                        Next
                    Next

                    If FileNames.Count > 0 Then
                        Threading.Thread.Sleep(1000)

                        FileContents = IO.File.ReadAllText(TemplateFile)

                        For Each AccountFile As String In FileNames
                            AddMessage("         Creating: {0}...".FormatWith(AccountFile))

                            Using writer As New IO.StreamWriter(AccountFile, False)
                                writer.WriteLine(FileContents)
                            End Using
                        Next
                    End If
                Next
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Public Sub StartTimer()

        End Sub

#Region " Events "

        Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
            MainListResults.ClearResults()
        End Sub

        Private Sub MainBackgroundWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles MainBackgroundWorker.DoWork
            Try
                Dim AccountFolderBjorn As String = "D:\Games\Activision\World of Warcraft\_retail_\WTF\Account\POESBOI\"
                Dim TemplateFolderBjorn As String = "E:\GoogleDrive\BackUps\Bjorn\WoW\Template\"

                Dim AccountFolderNix As String = "\\Study21R1\World of Warcraft\_retail_\WTF\Account\POESBOI2\"
                Dim TemplateFolderNix As String = "E:\GoogleDrive\BackUps\Nix\WoW\Template\"

                AddMessage("Checking Profiles - Bjorn...")
                CheckProfiles(AccountFolderBjorn, True, TemplateFolderBjorn)

                AddMessage("Checking Profiles - Nix...")
                CheckProfiles(AccountFolderNix, False, TemplateFolderNix)
            Catch ex As Exception
                ex.ToLog()
            End Try

            AddMessage("Complete.")
        End Sub

        Private Sub MainBackgroundWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles MainBackgroundWorker.RunWorkerCompleted
            Enabled = True
        End Sub

        Private Sub ProcessButton_Click(sender As Object, e As EventArgs) Handles ProcessButton.Click
            Enabled = False

            MainBackgroundWorker.RunWorkerAsync()
        End Sub

#End Region

#Region " Names "

        Private Function GetProfileName_Bjorn(filename As String, keyName As String) As String
            Try
                Select Case keyName
                    Case "elvui_elvdb"
                        Return "Poesboi"
                    Case "elvui_elvprivatedb"
                        Return "Poesboi"
                End Select

                Return GetProfileName_Shared(filename, keyName)
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return "Default"
        End Function

        Private Function GetProfileName_Nix(fileName As String, keyName As String) As String
            Try
                Select Case keyName
                    Case "elvui_elvdb"
                        Return "Nix"
                    Case "elvui_elvprivatedb"
                        Return "Nix"
                End Select

                Return GetProfileName_Shared(fileName, keyName)
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return "Default"
        End Function

        Private Function GetProfileName_Shared(fileName As String, keyName As String) As String
            Try
                Select Case keyName
                    Case "mogit_mogitwishlist"
                        Return "Default"

                    Case "actionbarprofiles_actionbarprofilesdbv3"
                        Return "Poesboi"
                    Case "adibags_adibagsdb"
                        Return "Poesboi"
                    Case "addonskins_addonskinsdb"
                        Return "Poesboi"
                    Case "altoholic_altoholicdb"
                        Return "Poesboi"
                    Case "announcerare_announceraredb"
                        Return "Poesboi"
                    Case "askmrrobot_askmrrobotdb4"
                        Return "Poesboi"
                    Case "astralkeys_astralminimap"
                        Return "Poesboi"
                    Case "auctionlite_auctionlitedb"
                        Return "Poesboi"
                    Case "auditor3_auditor2db"
                        Return "Poesboi"
                    Case "azeritetooltip_azeritetooltipdb"
                        Return "Poesboi"
                    Case "battlegroundenemies_battlegroundenemiesdb"
                        Return "Poesboi"
                    Case "bestinslotredux_bestinslotdb"
                        Return "Poesboi"
                    Case "bigwigs_bigwigs3db"
                        Return "Poesboi"
                    Case "bigwigs_recordkills_rkdatabase"
                        Return "Poesboi"
                    Case "bonusrollfilter_brf_data"
                        Return "Poesboi"
                    Case "broker_auditor_brokerauditordb"
                        Return "Poesboi"
                    Case "canimogit_canimogitdatabase"
                        Return "Poesboi"
                    Case "capping_cappingsettings"
                        Return "Poesboi"
                    Case "corruptiontooltips_corruptiontooltipsdb"
                        Return "Poesboi"
                    Case "crossrealmassist_crossrealmassistdb"
                        Return "Poesboi"
                    Case "datastore_datastoredb"
                        Return "Poesboi"
                    Case "datastore_achievements_datastore_achievementsdb"
                        Return "Poesboi"
                    Case "datastore_agenda_datastore_agendadb"
                        Return "Poesboi"
                    Case "datastore_auctions_datastore_auctionsdb"
                        Return "Poesboi"
                    Case "datastore_characters_datastore_charactersdb"
                        Return "Poesboi"
                    Case "datastore_containers_datastore_containersdb"
                        Return "Poesboi"
                    Case "datastore_crafts_datastore_craftsdb"
                        Return "Poesboi"
                    Case "datastore_crafts_datastore_craftsrefdb"
                        Return "Poesboi"
                    Case "datastore_covenants_datastore_covenantsdb"
                        Return "Poesboi"
                    Case "datastore_currencies_datastore_currenciesdb"
                        Return "Poesboi"
                    Case "datastore_garrisons_datastore_garrisonsdb"
                        Return "Poesboi"
                    Case "datastore_inventory_datastore_inventorydb"
                        Return "Poesboi"
                    Case "datastore_keystones_datastore_keystonesdb"
                        Return "Poesboi"
                    Case "datastore_keystones_datastore_keystonesrefdb"
                        Return "Poesboi"
                    Case "datastore_mails_datastore_mailsdb"
                        Return "Poesboi"
                    Case "datastore_pets_datastore_petsdb"
                        Return "Poesboi"
                    Case "datastore_quests_datastore_questsdb"
                        Return "Poesboi"
                    Case "datastore_rares_datastore_raresdb"
                        Return "Poesboi"
                    Case "datastore_reputations_datastore_reputationsdb"
                        Return "Poesboi"
                    Case "datastore_spells_datastore_spellsdb"
                        Return "Poesboi"
                    Case "datastore_stats_datastore_statsdb"
                        Return "Poesboi"
                    Case "datastore_talents_datastore_talentsdb"
                        Return "Poesboi"
                    Case "datastore_talents_datastore_talentsrefdb"
                        Return "Poesboi"
                    Case "epgp_lootmaster_epgplootmaster"
                        Return "Poesboi"
                    Case "gathermate2_gathermate2db"
                        Return "Poesboi"
                    Case "gladiatorlossa2_gladiatorlossadb"
                        Return "Poesboi"
                    Case "handynotes_handynotesdb"
                        Return "Poesboi"
                    Case "handynotes_handynotes_handynotesdb"
                        Return "Poesboi"
                    Case "handynotes_arathi_handynotesarathidb"
                        Return "Poesboi"
                    Case "handynotes_argus_handynotesargusdb", "handynotes_argus_handynotes_argusdb"
                        Return "Poesboi"
                    Case "handynotes_battleforazerothtreasures_handynotes_battleforazerothtreasuresdb", "handynotes_battleforazeroth_handynotes_battleforazerothdb"
                        Return "Poesboi"
                    Case "handynotes_brokenshore_handynotes_brokenshoredb"
                        Return "Poesboi"
                    Case "handynotes_draenortreasures_draenortreasuresdb"
                        Return "Poesboi"
                    Case "handynotes_dungeonlocations_handynotes_dungeonlocationsdb"
                        Return "Poesboi"
                    Case "handynotes_hallowsend_handynotes_hallowsenddb"
                        Return "Poesboi"
                    Case "handynotes_legioninstanceworldquests_handynotes_legioninstanceworldquestsdb"
                        Return "Poesboi"
                    Case "handynotes_legionrarestreasures_legionrarestreasuresdb"
                        Return "Poesboi"
                    Case "handynotes_legiontreasures_handynotes_legiontreasuresdb"
                        Return "Poesboi"
                    Case "handynotes_longforgottenhippogryph_handynotes_longforgottenhippogryphdb"
                        Return "Poesboi"
                    Case "handynotes_lunarfestival_handynotes_lunarfestivaldb"
                        Return "Poesboi"
                    Case "handynotes_mailboxes_handynotes_mailboxesdb"
                        Return "Poesboi"
                    Case "handynotes_shadowlands_handynotes_shadowlandsdb"
                        Return "Poesboi"
                    Case "handynotes_summerfestival_handynotes_summerfestivaldb"
                        Return "Poesboi"
                    Case "handynotes_suramartelemancy_handynotes_suramartelemancydb"
                        Return "Poesboi"
                    Case "handynotes_visionsofnzoth_handynotes_visionsofnzothdb"
                        Return "Poesboi"
                    Case "handynotes_warfrontrares_handynotesarathidb"
                        Return "Poesboi"
                    Case "hekili_hekilidb"
                        Return "Poesboi"
                    Case "iskarassist_iskarassistdb"
                        Return "Poesboi"
                    Case "iskarassist_radatabase"
                        Return "Poesboi"
                    Case "loggerhead_loggerheaddb"
                        Return "Poesboi"
                    Case "macrotoolkit_macrotoolkitdb"
                        Return "Poesboi"
                    Case "methoddungeontools_methoddungeontoolsdb"
                        Return "Poesboi"
                    Case "mogit_mogitdb"
                        Return "Poesboi"
                    Case "mountfarmhelper_mountfarmhelperdb"
                        Return "Poesboi"
                    Case "mouseoveractionbars_mouseoveractionbarsdb"
                        Return "Poesboi"
                    Case "mythicdungeontools_mythicdungeontoolsdb"
                        Return "Poesboi"
                    Case "nameplatesct_nameplatesctdb"
                        Return "Poesboi"
                    Case "nop_newopenablesprofile"
                        Return "Poesboi"
                    Case "npcscan_npcscandb"
                        Return "Poesboi"
                    Case "omnicd_omnicddb"
                        Return "Poesboi"
                    Case "paste_pastedb"
                        Return "Poesboi"
                    Case "personalloottrader_pltraderdb"
                        Return "Poesboi"
                    Case "petbattleteams_petbattleteamsdb"
                        Return "Poesboi"
                    Case "petjournalenhanced_petjournalenhanceddb"
                        Return "Poesboi"
                    Case "plater_platerdb"
                        Return "Poesboi"
                    Case "postal_postal3db"
                        Return "Poesboi"
                    Case "pvptimer_ptdb"
                        Return "Poesboi"
                    Case "quickquest_quickquestdb2"
                        Return "Poesboi"
                    Case "rarescanner_rarescannerdb"
                        Return "Poesboi"
                    Case "rarity_raritydb"
                        Return "Poesboi"
                    Case "relicinspector_relicinspectordb"
                        Return "Poesboi"
                    Case "routes_routesdb"
                        Return "Poesboi"
                    Case "silverdragon_silverdragon3db"
                        Return "Poesboi"
                    Case "simulationcraft_simulationcraftdb"
                        Return "Poesboi"
                    Case "sptimers_sptimersdb"
                        Return "Poesboi"
                    Case "tdbattlepetscript_td_db_battlepetscript_global"
                        Return "Poesboi"
                    Case "tldrmissions_tldrmissionsprofiles"
                        Return "Poesboi"
                    Case "tomtom_tomtomdb"
                        Return "Poesboi"
                    Case "tomtom_tomtomwaypointsm"
                        Return "Poesboi"
                    Case "toyboxq_toyboxqdb"
                        Return "Poesboi"
                    Case "ultrasquirt_ultrasquirtsettingsdb"
                        Return "Poesboi"
                    Case "vanaskos_vanaskosdb"
                        Return "Poesboi"
                    Case "worldbosstimers_worldbosstimersdb"
                        Return "Poesboi"
                    Case "worldquesttracker_wqtrackerdb"
                        Return "Poesboi"
                    Case "wowgatheringnodes_wowgatheringnodesconfig"
                        Return "Poesboi"
                    Case "xentitargetsdr_xentitargetsdb"
                        Return "Poesboi"
                    Case "_npcscan__npcscanprofiles"
                        Return "Poesboi"

                    Case Else
                        System_String_1.ToLog("frmMain->GetProfileName_Shared, new Key found: {0}, Filename: {1}".FormatWith(keyName, fileName), True)
                End Select
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return "Default"
        End Function

        Private Function GetProfileName(fileName As String, isBjorn As Boolean, keyName As String) As String
            Try
                If isBjorn Then
                    Return GetProfileName_Bjorn(fileName, keyName)
                Else
                    Return GetProfileName_Nix(fileName, keyName)
                End If
            Catch ex As Exception
                ex.ToLog()
            End Try

            Return "Default"
        End Function

        Private Sub CheckProfileNames(fileName As String, isBjorn As Boolean)
            Try
                Dim AddonName As String = IO.Path.GetFileNameWithoutExtension(fileName)
                Dim HasChanged As Boolean = False
                Dim InProfileKeys As Boolean = False
                Dim LastTable As String = ""
                Dim ProfileName As String = ""
                Dim StringBuilder As New Text.StringBuilder()

                AddMessage("         Checking AddOn: {0}...".FormatWith(AddonName))
                For Each CurrentLine As String In IO.File.ReadLines(fileName)
                    If CurrentLine.IsNotSet() Then
                        StringBuilder.AppendLine(CurrentLine)
                        Continue For
                    End If

                    If CurrentLine.EndsWith("] = {") Then
                        If CurrentLine.Trim().Replace("[", "").Replace("""", "").StartsWith("profileKeys]") Then
                            InProfileKeys = True

                            Dim KeyName As String = "{0}_{1}".FormatWith(AddonName, LastTable).ToLower()

                            ProfileName = GetProfileName(fileName, isBjorn, KeyName)
                        End If
                    ElseIf CurrentLine.EndsWith(" = {") Then
                        LastTable = CurrentLine.ToLower().Substring(0, CurrentLine.Length - 4).Trim()
                    ElseIf CurrentLine.EndsWith("},") OrElse CurrentLine.EndsWith("}") Then
                        InProfileKeys = False
                    End If

                    If InProfileKeys AndAlso Not CurrentLine.Contains(" {") Then
                        If CurrentLine.Contains(" = ") Then
                            Dim IndexPosition As Integer = CurrentLine.IndexOf(" = ")

                            Dim Key As String = CurrentLine.Substring(0, IndexPosition)
                            Dim Value As String = CurrentLine.Substring(IndexPosition + 4)
                            Value = Value.Substring(0, Value.Length - 2)

                            If Value.IsEqualTo(ProfileName) OrElse ProfileName.IsEqualTo("Default") Then
                            Else
                                HasChanged = True
                                CurrentLine = "{0} = ""{1}"",".FormatWith(Key, ProfileName)
                            End If
                        End If
                    End If

                    StringBuilder.AppendLine(CurrentLine)
                Next

                If HasChanged Then
                    IO.File.WriteAllText(fileName, StringBuilder.ToString())
                    AddMessage("            Updated.")
                End If
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#End Region

    End Class

End Namespace