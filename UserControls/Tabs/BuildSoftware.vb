Namespace UserControls.Tabs

    Public Class BuildSoftware
        Inherits PoesShared.UserControls.TabBase

        Private ReadOnly _View As Views.BuildSoftware = Nothing

        Public Sub New()
            Try
                _OrderButton = 2
                _Text = "Build Software"

                CreateItems()

                _View = New Views.BuildSoftware()
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