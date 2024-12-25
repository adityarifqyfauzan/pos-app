Imports System.Data.OleDb

Public Class OrderRepository

    Public Function FindAll() As List(Of Order)
        Dim orders As List(Of Order) = New List(Of Order)
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query = "SELECT * FROM [orders$]"
                Dim dataTable = DoQuery(query, connection)

                If dataTable.Rows.Count > 0 Then
                    For Each row As DataRow In dataTable.Rows
                        Dim order As Order = New Order()
                        order.Ref = row("ref")
                        order.TotalAmount = CDec(row("total_amount"))
                        order.PaymentAmount = CDec(row("payment_amount"))
                        order.Cashback = CDec(row("cashback"))
                        order.CreatedAt = row("created_at").ToString()
                        order.UpdatedAt = row("updated_at").ToString()
                        orders.Add(order)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return orders
    End Function

    Public Function Create(order As Order) As Boolean
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query As String = $"INSERT INTO [orders$] (ref, total_amount, payment_amount, cashback, created_at, updated_at) VALUES ('{order.Ref}', '{order.TotalAmount}', {order.PaymentAmount}, {order.Cashback}, '{order.CreatedAt}', '{order.UpdatedAt}')"
                DoExec(query, connection)
                Return True
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function FindOrderByRef(ref As String) As Order?
        Dim order As Order?
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()

                Dim query As String = $"SELECT * FROM [orders$] WHERE ref = '{ref}'"
                Dim dataTable As DataTable = DoQuery(query, connection)

                If dataTable.Rows.Count > 0 Then
                    Dim foundOrder As Order
                    foundOrder.Ref = dataTable.Rows(0)("ref").ToString()
                    foundOrder.TotalAmount = Convert.ToDecimal(dataTable.Rows(0)("total_amount"))
                    foundOrder.PaymentAmount = Convert.ToDecimal(dataTable.Rows(0)("payment_amount"))
                    foundOrder.Cashback = Convert.ToDecimal(dataTable.Rows(0)("cashback"))
                    foundOrder.CreatedAt = dataTable.Rows(0)("created_at").ToString()
                    foundOrder.UpdatedAt = dataTable.Rows(0)("updated_at").ToString()
                    order = foundOrder
                End If
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return order
    End Function

End Class
