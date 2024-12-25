Public Class ProductForm
    Private ProductsTable As DataTable
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProductData()
    End Sub

    Private Sub loadProductData()
        InitializeProductTable()
        ProductsTable.Clear()
        productDataGrid.DataSource = ProductsTable
        productDataGrid.Columns("Barcode").ReadOnly = True

        Dim productRepo As ProductRepository = New ProductRepository()
        Dim products As List(Of Product) = productRepo.FindAll()

        For Each product As Product In products
            Dim newDataProduct As DataRow = ProductsTable.NewRow()
            newDataProduct("Barcode") = product.Barcode
            newDataProduct("Nama Produk") = product.Name
            newDataProduct("Harga") = product.Price
            newDataProduct("Stock") = product.Stock
            ProductsTable.Rows.Add(newDataProduct)
        Next
    End Sub

    Private Sub InitializeProductTable()
        ProductsTable = New DataTable()
        ProductsTable.Columns.Add("Barcode", GetType(String))
        ProductsTable.Columns.Add("Nama Produk", GetType(String))
        ProductsTable.Columns.Add("Harga", GetType(Decimal))
        ProductsTable.Columns.Add("Stock", GetType(Integer))
    End Sub

    Private Sub productDataGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles productDataGrid.CellValueChanged
        If productDataGrid.Rows.Count > 0 Then
            Dim row = productDataGrid.Rows(e.RowIndex)

            Dim productRepository As New ProductRepository()
            Dim product As Product? = productRepository.FindProductByBarcode(row.Cells("Barcode").Value.ToString())
            Dim foundProduct As Product = product

            Dim stock As Integer
            If Not Integer.TryParse(row.Cells("Stock").Value.ToString(), stock) AndAlso stock > 0 Then
                row.Cells("Stock").Value = foundProduct.Stock
                MessageBox.Show("Stock harus berupa angka dan tidak boleh negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If stock <= 0 Then
                MessageBox.Show("Stock tidak boleh nol atau negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If stock <> foundProduct.Stock Then
                foundProduct.Stock = stock
            End If

            foundProduct.Name = row.Cells("Nama Produk").Value.ToString()

            Dim price As Decimal
            If Not Decimal.TryParse(row.Cells("Harga").Value.ToString(), price) AndAlso price > 0 Then
                MessageBox.Show("Harga harus berupa angka dan tidak boleh negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If price <= 0 Then
                MessageBox.Show("Harga tidak boleh nol atau negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If price <> foundProduct.Price Then
                foundProduct.Price = price
            End If

            If Not productRepository.Update(foundProduct) Then
                Return
            End If

            MessageBox.Show("Berhasil memperbarui produk!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub addProductBtn_Click(sender As Object, e As EventArgs) Handles addProductBtn.Click
        Dim addProductForm As AddProductForm = New AddProductForm()
        addProductForm.ShowDialog()
        loadProductData()
    End Sub

End Class