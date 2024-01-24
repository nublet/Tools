Namespace UserControls.ModelGenerator

    Public Interface IInterface

        Event DatabaseChanged(databaseName As String)

        Property Name As String

        ReadOnly Property Description As String
        ReadOnly Property UserControl As UserControl
        ReadOnly Property ModelDetails As String

        Function GetTables() As IEnumerable(Of Models.TableInformation)

        Sub LoadArea()

    End Interface

End Namespace