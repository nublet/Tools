Namespace Tools.UserControls.Tabs

    Public Class ModelGenerator
        Inherits CommonRoutines.Controls.TabBase

        Private ReadOnly _View As Views.ModelGenerator = Nothing

        Public Sub New()
            Try
                _OrderButton = 4
                _Text = "Model Generator"

                CreateItems()

                _View = New Views.ModelGenerator()
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