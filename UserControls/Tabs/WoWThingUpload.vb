Namespace Tools.UserControls.Tabs

    Public Class WoWThingUpload
        Inherits TabBase

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

        Protected Friend Overrides Function GetUserControl() As UserControl
            Return _View
        End Function

        Protected Friend Overrides Sub LoadData()
            _View.StartTimer()
        End Sub

#End Region

    End Class

End Namespace