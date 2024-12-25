Imports System.Linq.Expressions

Public Class POSForm
    Private ProductsTable As DataTable
    Private GrandTotal As Decimal
    Private Payment As Decimal
    Private Cashback As Decimal
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barcodeTxtBox.Focus()
        InitializeProductTable()
        GrandTotal = 0
        Cashback = 0
        Payment = 0

        productsDataGridView.DataSource = ProductsTable
        productsDataGridView.Columns("Barcode").ReadOnly = True
        productsDataGridView.Columns("Nama Produk").ReadOnly = True
        productsDataGridView.Columns("Harga").ReadOnly = True
        productsDataGridView.Columns("Sub Total").ReadOnly = True

        grandTotalTxtBox.Text = Rupiah(GrandTotal)
        cashbackTxtBox.Text = Rupiah(Cashback)
    End Sub

    Private Sub InitializeProductTable()
        ProductsTable = New DataTable()
        ProductsTable.Columns.Add("Barcode", GetType(String))
        ProductsTable.Columns.Add("Nama Produk", GetType(String))
        ProductsTable.Columns.Add("Harga", GetType(Decimal))
        ProductsTable.Columns.Add("Qty", GetType(Integer))
        ProductsTable.Columns.Add("Sub Total", GetType(Decimal))
    End Sub

    Private Sub barcodeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles barcodeTxtBox.KeyPress
        ' hanya izinkan angka
        AllowOnlyNumbers(sender, e)
    End Sub

    Private Sub barcodeTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles barcodeTxtBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim barcode As String = barcodeTxtBox.Text

            Dim productRepository As New ProductRepository()
            Dim product As Product? = productRepository.FindProductByBarcode(barcode)

            If product.HasValue Then
                Dim foundProduct As Product = product
                Dim existingRow = ProductsTable.Rows.Cast(Of DataRow)().FirstOrDefault(Function(r) r("Barcode").ToString() = barcode)
                barcodeTxtBox.Text = ""
                If existingRow IsNot Nothing Then
                    Dim qty = existingRow("Qty")
                    If qty >= foundProduct.Stock Then
                        MessageBox.Show($"Stok tidak cukup! Sisa stok untuk produk {foundProduct.Name} adalah {foundProduct.Stock}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    existingRow("Qty") = CInt(existingRow("Qty")) + 1
                    existingRow("Sub Total") = foundProduct.Price * CDec(existingRow("Qty"))
                    updateGrandTotal()

                Else
                    Dim newDataOrder As DataRow = ProductsTable.NewRow()
                    newDataOrder("Barcode") = foundProduct.Barcode
                    newDataOrder("Nama Produk") = foundProduct.Name
                    newDataOrder("Harga") = foundProduct.Price
                    newDataOrder("Qty") = 1
                    newDataOrder("Sub Total") = foundProduct.Price * CDec(newDataOrder("Qty"))
                    ProductsTable.Rows.Add(newDataOrder)
                    updateGrandTotal()

                End If
            Else
                MessageBox.Show("Produk tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub productsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles productsDataGridView.CellValueChanged
        If e.ColumnIndex = ProductsTable.Columns("Qty").Ordinal Then
            Dim row = productsDataGridView.Rows(e.RowIndex)
            Dim newQty As Integer

            Dim productRepository As New ProductRepository()
            Dim product As Product? = productRepository.FindProductByBarcode(row.Cells("Barcode").Value.ToString())
            Dim foundProduct As Product = product

            If Not Integer.TryParse(row.Cells("Qty").Value.ToString(), newQty) AndAlso newQty > 0 Then
                row.Cells("Qty").Value = 1
                MessageBox.Show("Qty harus berupa angka dan tidak boleh negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If newQty <= 0 Then
                row.Cells("Qty").Value = 1
                MessageBox.Show("Qty tidak boleh nol atau negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If newQty > foundProduct.Stock Then
                row.Cells("Qty").Value = 1
                row.Cells("Sub Total").Value = foundProduct.Price * 1
                MessageBox.Show($"Stok tidak cukup! Sisa stok untuk produk {foundProduct.Name} adalah {foundProduct.Stock}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                updateGrandTotal()
                Return
            End If

            row.Cells("Sub Total").Value = foundProduct.Price * CDec(row.Cells("Qty").Value.ToString())
            updateGrandTotal()
        End If
    End Sub

    Private Sub updateGrandTotal()
        GrandTotal = 0
        For Each row As DataRow In ProductsTable.Rows
            GrandTotal += CDec(row("Qty")) * row("Harga")
        Next

        grandTotalTxtBox.Text = Rupiah(GrandTotal)
        updateCashback(Payment)
    End Sub

    Private Sub tenBtn_Click(sender As Object, e As EventArgs) Handles tenBtn.Click
        paymentTxtBox.Text = "10000"
        Payment = 10000
        updateCashback(Payment)
    End Sub

    Private Sub twentyBtn_Click(sender As Object, e As EventArgs) Handles twentyBtn.Click
        paymentTxtBox.Text = "20000"
        Payment = 20000
        updateCashback(Payment)
    End Sub

    Private Sub fiftyBtn_Click(sender As Object, e As EventArgs) Handles fiftyBtn.Click
        paymentTxtBox.Text = "50000"
        Payment = 50000
        updateCashback(Payment)
    End Sub

    Private Sub hundredBtn_Click(sender As Object, e As EventArgs) Handles hundredBtn.Click
        paymentTxtBox.Text = "100000"
        Payment = 100000
        updateCashback(Payment)
    End Sub

    Private Sub updateCashback(payment As Decimal)
        Cashback = payment - GrandTotal
        cashbackTxtBox.Text = Rupiah(Cashback)
    End Sub

    Private Sub paymentTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles paymentTxtBox.KeyPress
        ' hanya izinkan angka
        AllowOnlyNumbers(sender, e)
    End Sub

    Private Sub paymentTxtBox_TextChanged(sender As Object, e As EventArgs) Handles paymentTxtBox.TextChanged
        Dim inputText As String = paymentTxtBox.Text
        Dim paymentValue As Decimal

        If Decimal.TryParse(inputText, paymentValue) Then
            Payment = paymentValue
            updateCashback(Payment)
        ElseIf String.IsNullOrWhiteSpace(inputText) Then
            Payment = 0
            updateCashback(Payment)
        Else
            MessageBox.Show("Masukkan hanya angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            paymentTxtBox.Text = "0" ' Reset ke 0 atau nilai default
            paymentTxtBox.SelectionStart = paymentTxtBox.Text.Length ' Pindahkan kursor ke akhir
        End If
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Dim result = MessageBox.Show("Apakah ingin mengulang transaksi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            reset()
        End If

    End Sub

    Private Sub reset()
        ProductsTable.Clear()
        Payment = 0
        GrandTotal = 0
        paymentTxtBox.Text = 0
        grandTotalTxtBox.Text = Rupiah(GrandTotal)
        updateCashback(Payment)
    End Sub

    Private Sub hapusItemBtn_Click(sender As Object, e As EventArgs) Handles hapusItemBtn.Click
        If productsDataGridView.SelectedRows.Count > 0 Then

            Dim selectedIndex As Integer = productsDataGridView.SelectedRows(0).Index

            If selectedIndex >= 0 AndAlso selectedIndex < productsDataGridView.Rows.Count Then
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus produk ini dari pesanan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    productsDataGridView.Rows.RemoveAt(selectedIndex)
                    MessageBox.Show("Produk berhasil dihapus.")
                    updateGrandTotal()
                End If
            Else
                MessageBox.Show("Indeks baris tidak valid.")
            End If
        Else
            MessageBox.Show("Pilih produk terlebih dahulu.")
        End If
    End Sub

    Private Sub checkoutBtn_Click(sender As Object, e As EventArgs) Handles checkoutBtn.Click
        Dim result = MessageBox.Show("Apakah ingin checkout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Not ProductsTable.Rows.Count > 0 Then
                MessageBox.Show("Pesanan masih kosong")
                Return
            ElseIf Cashback < 0 Then
                MessageBox.Show("Nominal pembayaran masih belum sesuai")
                Return
            End If

            checkout()

        End If
    End Sub

    Private Sub checkout()
        ' create order data
        Dim order As Order? = New Order(GrandTotal, Payment, Cashback)

        Dim orderRepository As OrderRepository = New OrderRepository()
        Dim orderDetailRepository As OrderDetailRepository = New OrderDetailRepository()
        Dim productRepository As ProductRepository = New ProductRepository()

        ' create order
        If Not orderRepository.Create(order) Then
            Return
        End If

        For Each row As DataRow In ProductsTable.Rows
            Dim orderDetail As OrderDetail = New OrderDetail(orderRef:=order?.Ref, price:=row("Harga"), productBarcode:=row("Barcode"), qty:=row("Qty"))
            If Not orderDetailRepository.Create(orderDetail) Then
                Return
            End If

            Dim product As Product? = productRepository.FindProductByBarcode(row("Barcode"))
            If product.HasValue Then
                Dim foundProduct As Product = product
                foundProduct.Stock -= CInt(row("Qty"))
                If Not productRepository.Update(foundProduct) Then
                    Return
                End If
            End If

        Next

        reset()
        MessageBox.Show("Pemesanan Selesai!")
    End Sub

    Private Sub kelolaProductToolTip_Click(sender As Object, e As EventArgs) Handles kelolaProductToolTip.Click
        Dim productForm As ProductForm = New ProductForm()
        productForm.ShowDialog()

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim reportForm = New ReportForm()
        reportForm.ShowDialog()
    End Sub

    Private Sub aboutToolTip_Click(sender As Object, e As EventArgs) Handles aboutToolTip.Click
        Dim aboutForm = New AboutForm()
        aboutForm.ShowDialog()
    End Sub

End Class