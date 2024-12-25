<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        submitBtn = New Button()
        productNameErrLabel = New Label()
        barcodeLabel = New Label()
        productNameTxtBox = New TextBox()
        barcodeTxtBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        priceErrLabel = New Label()
        priceTxtBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        stockErrLabel = New Label()
        stockTxtBox = New TextBox()
        Label8 = New Label()
        resetBtn = New Button()
        SuspendLayout()
        ' 
        ' submitBtn
        ' 
        submitBtn.BackColor = Color.LightGreen
        submitBtn.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        submitBtn.ForeColor = Color.DarkGreen
        submitBtn.Location = New Point(15, 429)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(289, 46)
        submitBtn.TabIndex = 4
        submitBtn.Text = "Buat Produk"
        submitBtn.UseVisualStyleBackColor = False
        ' 
        ' productNameErrLabel
        ' 
        productNameErrLabel.AutoSize = True
        productNameErrLabel.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        productNameErrLabel.ForeColor = Color.IndianRed
        productNameErrLabel.Location = New Point(15, 185)
        productNameErrLabel.Name = "productNameErrLabel"
        productNameErrLabel.Size = New Size(89, 19)
        productNameErrLabel.TabIndex = 14
        productNameErrLabel.Text = "error message"
        ' 
        ' barcodeLabel
        ' 
        barcodeLabel.AutoSize = True
        barcodeLabel.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        barcodeLabel.ForeColor = Color.SteelBlue
        barcodeLabel.Location = New Point(15, 104)
        barcodeLabel.Name = "barcodeLabel"
        barcodeLabel.Size = New Size(177, 19)
        barcodeLabel.TabIndex = 13
        barcodeLabel.Text = "tekan Enter untuk melanjutkan"
        ' 
        ' productNameTxtBox
        ' 
        productNameTxtBox.Font = New Font("Poppins", 12F)
        productNameTxtBox.Location = New Point(15, 151)
        productNameTxtBox.Name = "productNameTxtBox"
        productNameTxtBox.Size = New Size(289, 31)
        productNameTxtBox.TabIndex = 1
        ' 
        ' barcodeTxtBox
        ' 
        barcodeTxtBox.Font = New Font("Poppins", 12F)
        barcodeTxtBox.Location = New Point(15, 70)
        barcodeTxtBox.Name = "barcodeTxtBox"
        barcodeTxtBox.Size = New Size(289, 31)
        barcodeTxtBox.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9.75F)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(15, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 23)
        Label3.TabIndex = 10
        Label3.Text = "Nama Produk"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9.75F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(15, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 23)
        Label1.TabIndex = 8
        Label1.Text = "Barcode"
        ' 
        ' priceErrLabel
        ' 
        priceErrLabel.AutoSize = True
        priceErrLabel.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        priceErrLabel.ForeColor = Color.IndianRed
        priceErrLabel.Location = New Point(15, 270)
        priceErrLabel.Name = "priceErrLabel"
        priceErrLabel.Size = New Size(89, 19)
        priceErrLabel.TabIndex = 19
        priceErrLabel.Text = "error message"
        ' 
        ' priceTxtBox
        ' 
        priceTxtBox.Font = New Font("Poppins", 12F)
        priceTxtBox.Location = New Point(15, 236)
        priceTxtBox.Name = "priceTxtBox"
        priceTxtBox.Size = New Size(289, 31)
        priceTxtBox.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 9.75F)
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(15, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 23)
        Label5.TabIndex = 17
        Label5.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 16
        ' 
        ' stockErrLabel
        ' 
        stockErrLabel.AutoSize = True
        stockErrLabel.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stockErrLabel.ForeColor = Color.IndianRed
        stockErrLabel.Location = New Point(15, 355)
        stockErrLabel.Name = "stockErrLabel"
        stockErrLabel.Size = New Size(89, 19)
        stockErrLabel.TabIndex = 22
        stockErrLabel.Text = "error message"
        ' 
        ' stockTxtBox
        ' 
        stockTxtBox.Font = New Font("Poppins", 12F)
        stockTxtBox.Location = New Point(15, 321)
        stockTxtBox.Name = "stockTxtBox"
        stockTxtBox.Size = New Size(289, 31)
        stockTxtBox.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 9.75F)
        Label8.ForeColor = SystemColors.ControlDarkDark
        Label8.Location = New Point(15, 298)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 23)
        Label8.TabIndex = 20
        Label8.Text = "Stock"
        ' 
        ' resetBtn
        ' 
        resetBtn.BackColor = Color.Silver
        resetBtn.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resetBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        resetBtn.Location = New Point(15, 481)
        resetBtn.Name = "resetBtn"
        resetBtn.Size = New Size(289, 46)
        resetBtn.TabIndex = 5
        resetBtn.Text = "Reset Form"
        resetBtn.UseVisualStyleBackColor = False
        ' 
        ' AddProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 544)
        Controls.Add(resetBtn)
        Controls.Add(stockErrLabel)
        Controls.Add(stockTxtBox)
        Controls.Add(Label8)
        Controls.Add(priceErrLabel)
        Controls.Add(priceTxtBox)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(submitBtn)
        Controls.Add(productNameErrLabel)
        Controls.Add(barcodeLabel)
        Controls.Add(productNameTxtBox)
        Controls.Add(barcodeTxtBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddProductForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah Produk Baru"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents submitBtn As Button
    Friend WithEvents productNameErrLabel As Label
    Friend WithEvents barcodeLabel As Label
    Friend WithEvents productNameTxtBox As TextBox
    Friend WithEvents barcodeTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents priceErrLabel As Label
    Friend WithEvents priceTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents stockErrLabel As Label
    Friend WithEvents stockTxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents resetBtn As Button
End Class
