Namespace UserControls.Tabs

    Public Class EventViewer
        Inherits PoesShared.UserControls.TabBase

        Private ReadOnly _View As Views.EventViewer = Nothing

        Public Sub New()
            Try
                _OrderButton = 5
                _Text = "Event Viewer"

                CreateItems()

                _View = New Views.EventViewer()
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