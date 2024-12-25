Imports System.Data.OleDb
Module DatabaseConnection

    Public Function GetConnectionString(filePath As String) As String
        Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties=""Excel 12.0 Xml;HDR=YES;"""
    End Function

    Public Function GetConnection() As OleDbConnection
        Dim filepath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.xlsx")
        Dim connectionString As String = GetConnectionString(filepath)
        Return New OleDbConnection(connectionString)
    End Function

End Module
