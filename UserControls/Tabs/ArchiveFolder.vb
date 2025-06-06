﻿Namespace UserControls.Tabs

    Public Class ArchiveFolder
        Inherits PoesShared.UserControls.TabBase

        Private ReadOnly _View As Views.ArchiveFolder = Nothing

        Public Sub New()
            Try
                _OrderButton = 4
                _Text = "Archive Folder"

                CreateItems()

                _View = New Views.ArchiveFolder()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#Region " TabBase "

        Public Overrides Function GetUserControl() As UserControl
            Return _View
        End Function

        Public Overrides Sub LoadData()
            _View.StartTimer()
        End Sub

#End Region

    End Class

End Namespace