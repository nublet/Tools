Namespace UserControls.Tabs

    Public Class WoWProfileChecker
        Inherits CommonRoutines.UserControls.TabBase

        Private ReadOnly _View As Views.WoWProfileChecker = Nothing

        Public Sub New()
            Try
                _OrderButton = 2
                _Text = "WoW Profile Checker"

                CreateItems()

                _View = New Views.WoWProfileChecker()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#Region " TabBase "

        Public Overrides Function GetUserControl() As UserControl
            Return _View
        End Function

        Public Overrides Sub LoadData()
            Views.WoWProfileChecker.StartTimer()
        End Sub

#End Region

    End Class

End Namespace