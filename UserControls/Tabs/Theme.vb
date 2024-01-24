Namespace UserControls.Tabs

    Public Class Theme
        Inherits CommonRoutines.UserControls.TabBase

        Private ReadOnly _View As CommonRoutines.UITheme.Editor = Nothing

        Public Sub New()
            Try
                _OrderButton = 99
                _Text = "Options - Theme"

                CreateItems()

                _View = New CommonRoutines.UITheme.Editor(New CommonRoutines.UITheme.ThemeValueChangedEventHandler(AddressOf ThemeValue_Changed))
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

        Private Sub ThemeValue_Changed()
            UserForms.Main.UpdateTheme()
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