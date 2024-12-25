Imports System.Data.OleDb
Imports System.Linq.Expressions

Public Class ProductRepository

    Public Function FindAll() As List(Of Product)
        Dim products As List(Of Product) = New List(Of Product)
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM [products$]"

                Dim dataTable As DataTable = DoQuery(query, connection)

                If dataTable.Rows.Count > 0 Then
                    For Each row As DataRow In dataTable.Rows
                        Dim product As Product = New Product()
                        product.Barcode = row("barcode")
                        product.Name = row("name")
                        product.Price = CDec(row("price"))
                        product.Stock = CInt(row("stock"))
                        products.Add(product)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return products
    End Function

    Public Function FindProductByBarcode(barcode As String) As Product?
        Dim product As Product?

        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query As String = $"SELECT * FROM [products$] WHERE barcode = '{barcode}'"

                Dim dataTable As DataTable = DoQuery(query, connection)

                If dataTable.Rows.Count > 0 Then
                    Dim foundProduct As Product
                    foundProduct.Name = dataTable.Rows(0)("name").ToString()
                    foundProduct.Barcode = dataTable.Rows(0)("barcode").ToString()
                    foundProduct.Price = Convert.ToDecimal(dataTable.Rows(0)("price"))
                    foundProduct.Stock = Convert.ToInt64(dataTable.Rows(0)("stock"))
                    foundProduct.CreatedAt = dataTable.Rows(0)("created_at").ToString()
                    foundProduct.UpdatedAt = dataTable.Rows(0)("updated_at").ToString()
                    product = foundProduct
                End If

            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return product
    End Function

    Public Function Create(product As Product) As Boolean
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim query As String = $"INSERT INTO [products$] (barcode, name, price, stock, created_at, updated_at) VALUES ('{product.Barcode}', '{product.Name}', {product.Price}, {product.Stock}, '{product.CreatedAt}', '{product.UpdatedAt}')"
                DoExec(query, connection)
                Return True
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
        Return True
    End Function

    Public Function Update(product As Product) As Boolean
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim timestamp As DateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                Dim query As String = $"UPDATE [products$] SET name = '{product.Name}', price = {product.Price}, stock = {product.Stock}, updated_at = '{timestamp}' WHERE barcode = '{product.Barcode}'"
                DoExec(query, connection)
                Return True
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
        Return False
    End Function

    Public Sub Delete(product As Product)
        Using connection As OleDbConnection = GetConnection()
            Try
                connection.Open()
                Dim timestamp As DateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                Dim query As String = $"UPDATE [products$] SET deleted_at = '{timestamp}' WHERE barcode = {product.Barcode}"
                DoExec(query, connection)
            Catch ex As Exception
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class
