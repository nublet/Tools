Namespace UserControls.Tabs

    Public Class WoWThingUpload
        Inherits CommonRoutines.UserControls.TabBase

        Private ReadOnly _View As Views.WoWThingUpload = Nothing

        Public Sub New()
            Try
                _OrderButton = 1
                _Text = "WoWThing Upload"

                CreateItems()

                _View = New Views.WoWThingUpload()
            Catch ex As Exception
                ex.ToLog()
            End Try
        End Sub

#Region " TabBase "

        Public Overrides Function GetUserControl() As UserControl
            Return _View
        End Function

        Public Overrides Sub LoadData()
            Views.WoWThingUpload.StartTimer()
        End Sub

#End Region

    End Class

End Namespace