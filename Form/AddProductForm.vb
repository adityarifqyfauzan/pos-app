Public Class AddProductForm

    Private IsUpdate As Boolean
    Private ExistingProduct As Product
    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        coldStart()

    End Sub

    Private Sub coldStart()
        textBoxesReadOnlyStatus(True)
        allErrLabelsAreInvisible()
        resetAllInput()
        IsUpdate = False

        ExistingProduct = Nothing
        barcodeLabel.Text = "tekan Enter untuk melanjutkan"
        barcodeLabel.ForeColor = Color.SteelBlue

        barcodeTxtBox.Text = ""
        barcodeTxtBox.ReadOnly = False
        barcodeTxtBox.Focus()
    End Sub
    Private Sub resetAllInput()
        barcodeTxtBox.Text = ""
        productNameTxtBox.Text = ""
        priceTxtBox.Text = ""
        stockTxtBox.Text = ""
    End Sub

    Private Sub textBoxesReadOnlyStatus(status As Boolean)
        productNameTxtBox.ReadOnly = status
        priceTxtBox.ReadOnly = status
        stockTxtBox.ReadOnly = status
    End Sub

    Private Sub allErrLabelsAreInvisible()
        productNameErrLabel.Visible = False
        priceErrLabel.Visible = False
        stockErrLabel.Visible = False
    End Sub

    Public Sub AllowOnlyNumbers(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub barcodeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles barcodeTxtBox.KeyPress
        AllowOnlyNumbers(sender, e)
    End Sub

    Private Sub stockTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stockTxtBox.KeyPress
        AllowOnlyNumbers(sender, e)
    End Sub

    Private Sub priceTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles priceTxtBox.KeyPress
        AllowOnlyNumbers(sender, e)
    End Sub

    Private Sub barcodeTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles barcodeTxtBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim barcode As String = barcodeTxtBox.Text
            If String.IsNullOrWhiteSpace(barcode) Then
                MessageBox.Show("Barcode tidak boleh kosong!")
                Return
            End If

            Dim productRepository As New ProductRepository()
            Dim product As Product? = productRepository.FindProductByBarcode(barcode)

            If product.HasValue Then

                Dim doUpdate = MessageBox.Show("Produk sudah tersedia, Apakah Anda ingin memperbarui data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If doUpdate = DialogResult.Yes Then
                    Dim foundProduct As Product = product
                    productNameTxtBox.Text = foundProduct.Name
                    priceTxtBox.Text = foundProduct.Price
                    stockTxtBox.Text = foundProduct.Stock

                    barcodeLabel.Visible = True
                    barcodeLabel.ForeColor = Color.DarkGreen
                    barcodeLabel.Text = "Barcode sudah terdaftar, hanya bisa melakukan edit"
                    submitBtn.Text = "Perbarui Data"
                    IsUpdate = True
                    ExistingProduct = foundProduct
                Else
                    Return
                End If

            End If

            barcodeTxtBox.ReadOnly = True
            textBoxesReadOnlyStatus(False)
        End If
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim isValid As Boolean = True

        isValid = validateInput(productNameErrLabel, productNameTxtBox, "Nama Produk")
        isValid = validateInput(priceErrLabel, priceTxtBox, "Harga")
        isValid = validateInput(stockErrLabel, stockTxtBox, "Stock")

        ' apabila salah satu atau kedua validasi diatas gagal, maka langsung return
        If Not isValid Then
            Return
        End If

        If CDec(priceTxtBox.Text) <= 0 Then
            MessageBox.Show("Harga tidak boleh nol atau negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CInt(stockTxtBox.Text) <= 0 Then
            MessageBox.Show("Stock tidak boleh nol atau negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim productRepository As ProductRepository = New ProductRepository()

        If IsUpdate Then
            ExistingProduct.Name = productNameTxtBox.Text
            ExistingProduct.Price = CDec(priceTxtBox.Text)
            ExistingProduct.Stock = CInt(stockTxtBox.Text)
            If Not productRepository.Update(ExistingProduct) Then
                Return
            End If
            resetAllInput()
            coldStart()
            MessageBox.Show("Berhasil memperbarui data produk!")
            Return
        End If

        Dim newProduct As Product = New Product(barcode:=barcodeTxtBox.Text, name:=productNameTxtBox.Text, price:=CDec(priceTxtBox.Text), stock:=CInt(stockTxtBox.Text))
        If Not productRepository.Create(newProduct) Then
            Return
        End If

        coldStart()
        MessageBox.Show("Berhasil menambahkan data produk!")

    End Sub

    Private Function validateInput(label As Label, textBox As TextBox, fieldName As String) As Boolean
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            label.Text = $"{fieldName} tidak boleh kosong."
            label.Visible = True
            Return False
        End If
        Return True
    End Function

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        coldStart()
    End Sub
End Class