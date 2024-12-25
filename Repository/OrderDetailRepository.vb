Imports System.Data.OleDb

Public Class OrderDetailRepository

    Public Function FindAll(orderRef As String) As List(Of OrderDetail)
        Dim orderDetails As List(Of OrderDetail) = New List(Of OrderDetail)
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query = $"SELECT * FROM [order_details$] WHERE order_ref = '{orderRef}'"
                Dim dataTable = DoQuery(query, connection)

                If dataTable.Rows.Count > 0 Then
                    For Each row As DataRow In dataTable.Rows
                        Dim orderDetail As OrderDetail = New OrderDetail()
                        orderDetail.OrderRef = row("order_ref")
                        orderDetail.Price = CDec(row("price"))
                        orderDetail.ProductBarcode = row("product_barcode")
                        orderDetail.Qty = CInt(row("qty"))
                        orderDetails.Add(orderDetail)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return orderDetails
    End Function

    Public Function Create(orderDetail As OrderDetail) As Boolean
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query As String = $"INSERT INTO [order_details$] (order_ref, product_barcode, price, qty, created_at, updated_at) VALUES ('{orderDetail.OrderRef}', '{orderDetail.ProductBarcode}', {orderDetail.Price}, {orderDetail.Qty}, '{orderDetail.CreatedAt}', '{orderDetail.UpdatedAt}')"
                DoExec(query, connection)
                Return True
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
        Return True
    End Function

End Class
