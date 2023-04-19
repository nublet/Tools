﻿Namespace Tools

    Public Module Main

        Public Sub Main(args As String())
            Try
                If CommonRoutines.SingleInstanceApplication.NotifyExistingInstance(String.Join(CommonRoutines.ParameterSplit, args), WindowCaption) Then
                    Application.Exit()
                    Return
                End If
            Catch ex As Exception
            End Try

            Try
                AddHandler Application.ThreadException, AddressOf CommonRoutines.Errors.Application_ThreadException
                AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CommonRoutines.Errors.CurrentDomain_UnhandledException

                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

                CommonRoutines.Initialise("\\192.168.50.35\Projects\_Errors\{0} - {1}_{2}.txt".FormatWith(My.Application.Info.ProductName, CommonRoutines.GetComputerName(), CommonRoutines.GetUsername()), False, "", False)

                CommonRoutines.Settings.Icon = My.Resources.App

                CommonRoutines.Settings.DebugLogging = False
                CommonRoutines.Settings.DebugLoggingDBAccess = False

                'CommonRoutines.Errors.Handlers.Clear()
                'CommonRoutines.Errors.Handlers.Add(New CommonRoutines.Errors.LogErrorDetailHandler(AddressOf LogError))

                CommonRoutines.Performance.Handlers.Clear()

                CommonRoutines.SingleInstanceApplication.Initialize(WindowCaption, New CommonRoutines.SingleInstanceApplication.NewInstanceMessageHandler(AddressOf SIA_NewInstanceMessage))

                Application.Run(New UserForms.Main())
            Catch ex As Exception
                ex.ToLog()

                Application.Exit()
            End Try
        End Sub

        Private Sub SIA_NewInstanceMessage(sender As Object, message As Object)
            UserForms.Main.BringForward()
        End Sub

    End Module

End Namespace