Imports System.Data.OleDb

Public Class UserRepository
    Public Function GetUserByUsername(username As String) As User?
        Dim user As User?

        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query As String = $"SELECT * FROM [users$] WHERE username = '{username}'"

                Dim dataTable As DataTable = DoQuery(query, connection)

                If dataTable.Rows.Count > 0 Then
                    Dim foundUser As User
                    foundUser.ID = Convert.ToInt64(dataTable.Rows(0)("id"))
                    foundUser.Username = dataTable.Rows(0)("username").ToString()
                    foundUser.Password = dataTable.Rows(0)("password").ToString()
                    user = foundUser
                End If
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return user
    End Function

End Class
