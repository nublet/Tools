Namespace Tools

    Public Module _Shared

        Private _DBAccessApr2kWork As CommonRoutines.Data.IDBAccess = Nothing

        Public ReadOnly Property DBAccessApr2kWork As CommonRoutines.Data.IDBAccess
            Get
                Return _DBAccessApr2kWork
            End Get
        End Property

        Public Sub Initialise()
            _DBAccessApr2kWork = New CommonRoutines.Data.OleDb.DBAccess("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.10.131\www2\Support\App_Data\apr2kwork.mdb")
        End Sub

    End Module

End Namespace