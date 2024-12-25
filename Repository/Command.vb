Imports System.Data.OleDb

Module Command
    Public Function DoQuery(query As String, connection As OleDbConnection) As DataTable
        Dim cmd As New OleDbCommand(query, connection)
        Dim adapter As New OleDbDataAdapter(cmd)

        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        Return dataTable
    End Function

    Public Sub DoExec(query As String, connection As OleDbConnection)
        Using cmd As New OleDbCommand(query, connection)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module
