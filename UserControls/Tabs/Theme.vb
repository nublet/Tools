Namespace UserControls.Tabs

    Public Class Theme
        Inherits PoesShared.UserControls.TabBase

        Private ReadOnly _View As PoesShared.UserControls.UIThemeEditor = Nothing

        Public Sub New()
            Try
                _OrderButton = 99
                _Text = "Options - Theme"

                CreateItems()

                _View = New PoesShared.UserControls.UIThemeEditor("Bjorn", New UITheme.ValueChangedEventHandler(AddressOf UITheme_ValueChanged))
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub UITheme_ValueChanged()
            UITheme.UpdateTheme()
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