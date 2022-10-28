Namespace Tools.UserControls.Tabs

    Public Class ArchiveFolder
        Inherits TabBase

        Private ReadOnly _View As Views.ArchiveFolder = Nothing

        Public Sub New()
            Try
                _OrderButton = 3
                _Text = "Archive Folder"

                CreateItems()

                _View = New Views.ArchiveFolder()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#Region " TabBase "

        Protected Friend Overrides Function GetUserControl() As UserControl
            Return _View
        End Function

        Protected Friend Overrides Sub LoadData()
            _View.StartTimer()
        End Sub

#End Region

    End Class

End Namespace