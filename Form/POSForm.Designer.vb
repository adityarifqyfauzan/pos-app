<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSForm
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
        barcodeTxtBox = New TextBox()
        Label1 = New Label()
        productsDataGridView = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        grandTotalTxtBox = New TextBox()
        paymentTxtBox = New TextBox()
        Label6 = New Label()
        cashbackTxtBox = New TextBox()
        Label5 = New Label()
        checkoutBtn = New Button()
        resetBtn = New Button()
        tenBtn = New Button()
        twentyBtn = New Button()
        fiftyBtn = New Button()
        hundredBtn = New Button()
        hapusItemBtn = New Button()
        ToolStrip1 = New ToolStrip()
        kelolaProductToolTip = New ToolStripLabel()
        ToolStripLabel1 = New ToolStripLabel()
        aboutToolTip = New ToolStripLabel()
        CType(productsDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' barcodeTxtBox
        ' 
        barcodeTxtBox.Font = New Font("Poppins Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        barcodeTxtBox.Location = New Point(37, 69)
        barcodeTxtBox.Name = "barcodeTxtBox"
        barcodeTxtBox.Size = New Size(645, 79)
        barcodeTxtBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(48, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 34)
        Label1.TabIndex = 1
        Label1.Text = "Scan Barcode"
        ' 
        ' productsDataGridView
        ' 
        productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productsDataGridView.Location = New Point(37, 178)
        productsDataGridView.Name = "productsDataGridView"
        productsDataGridView.Size = New Size(645, 308)
        productsDataGridView.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(48, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 34)
        Label2.TabIndex = 3
        Label2.Text = "List Pesanan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(581, 504)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 4
        Label3.Text = "Grand Total"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(457, 452)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 84)
        Label4.TabIndex = 5
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' grandTotalTxtBox
        ' 
        grandTotalTxtBox.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grandTotalTxtBox.Location = New Point(37, 527)
        grandTotalTxtBox.Name = "grandTotalTxtBox"
        grandTotalTxtBox.ReadOnly = True
        grandTotalTxtBox.Size = New Size(645, 79)
        grandTotalTxtBox.TabIndex = 6
        grandTotalTxtBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' paymentTxtBox
        ' 
        paymentTxtBox.Font = New Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        paymentTxtBox.Location = New Point(713, 83)
        paymentTxtBox.Name = "paymentTxtBox"
        paymentTxtBox.Size = New Size(245, 48)
        paymentTxtBox.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(710, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 28)
        Label6.TabIndex = 9
        Label6.Text = "Bayar"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cashbackTxtBox
        ' 
        cashbackTxtBox.Font = New Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cashbackTxtBox.Location = New Point(713, 261)
        cashbackTxtBox.Name = "cashbackTxtBox"
        cashbackTxtBox.ReadOnly = True
        cashbackTxtBox.Size = New Size(245, 48)
        cashbackTxtBox.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(713, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 28)
        Label5.TabIndex = 11
        Label5.Text = "Kembalian"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' checkoutBtn
        ' 
        checkoutBtn.BackColor = Color.ForestGreen
        checkoutBtn.Font = New Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkoutBtn.ForeColor = SystemColors.ButtonHighlight
        checkoutBtn.Location = New Point(713, 326)
        checkoutBtn.Name = "checkoutBtn"
        checkoutBtn.Size = New Size(245, 50)
        checkoutBtn.TabIndex = 6
        checkoutBtn.Text = "Checkout"
        checkoutBtn.UseVisualStyleBackColor = False
        ' 
        ' resetBtn
        ' 
        resetBtn.BackColor = Color.Gray
        resetBtn.Font = New Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resetBtn.ForeColor = SystemColors.ButtonHighlight
        resetBtn.Location = New Point(713, 382)
        resetBtn.Name = "resetBtn"
        resetBtn.Size = New Size(245, 50)
        resetBtn.TabIndex = 7
        resetBtn.Text = "Reset Pesanan"
        resetBtn.UseVisualStyleBackColor = False
        ' 
        ' tenBtn
        ' 
        tenBtn.Location = New Point(713, 137)
        tenBtn.Name = "tenBtn"
        tenBtn.Size = New Size(117, 37)
        tenBtn.TabIndex = 2
        tenBtn.Text = "10.000"
        tenBtn.UseVisualStyleBackColor = True
        ' 
        ' twentyBtn
        ' 
        twentyBtn.Location = New Point(841, 137)
        twentyBtn.Name = "twentyBtn"
        twentyBtn.Size = New Size(117, 37)
        twentyBtn.TabIndex = 3
        twentyBtn.Text = "20.000"
        twentyBtn.UseVisualStyleBackColor = True
        ' 
        ' fiftyBtn
        ' 
        fiftyBtn.Location = New Point(713, 181)
        fiftyBtn.Name = "fiftyBtn"
        fiftyBtn.Size = New Size(117, 37)
        fiftyBtn.TabIndex = 4
        fiftyBtn.Text = "50.000"
        fiftyBtn.UseVisualStyleBackColor = True
        ' 
        ' hundredBtn
        ' 
        hundredBtn.Location = New Point(841, 181)
        hundredBtn.Name = "hundredBtn"
        hundredBtn.Size = New Size(117, 37)
        hundredBtn.TabIndex = 5
        hundredBtn.Text = "100.000"
        hundredBtn.UseVisualStyleBackColor = True
        ' 
        ' hapusItemBtn
        ' 
        hapusItemBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        hapusItemBtn.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hapusItemBtn.ForeColor = Color.Firebrick
        hapusItemBtn.Location = New Point(48, 470)
        hapusItemBtn.Name = "hapusItemBtn"
        hapusItemBtn.Size = New Size(116, 32)
        hapusItemBtn.TabIndex = 18
        hapusItemBtn.Text = "Hapus Item"
        hapusItemBtn.UseVisualStyleBackColor = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {kelolaProductToolTip, ToolStripLabel1, aboutToolTip})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(994, 26)
        ToolStrip1.TabIndex = 19
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' kelolaProductToolTip
        ' 
        kelolaProductToolTip.Font = New Font("Poppins", 9.75F)
        kelolaProductToolTip.Name = "kelolaProductToolTip"
        kelolaProductToolTip.Size = New Size(97, 23)
        kelolaProductToolTip.Text = "Kelola Produk"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Font = New Font("Poppins", 9.75F)
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(129, 23)
        ToolStripLabel1.Text = "Laporan Transaksi"
        ' 
        ' aboutToolTip
        ' 
        aboutToolTip.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        aboutToolTip.Name = "aboutToolTip"
        aboutToolTip.Size = New Size(64, 23)
        aboutToolTip.Text = "Tentang"
        ' 
        ' POSForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(994, 626)
        Controls.Add(ToolStrip1)
        Controls.Add(hapusItemBtn)
        Controls.Add(hundredBtn)
        Controls.Add(fiftyBtn)
        Controls.Add(twentyBtn)
        Controls.Add(tenBtn)
        Controls.Add(resetBtn)
        Controls.Add(checkoutBtn)
        Controls.Add(Label5)
        Controls.Add(cashbackTxtBox)
        Controls.Add(Label6)
        Controls.Add(paymentTxtBox)
        Controls.Add(grandTotalTxtBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(productsDataGridView)
        Controls.Add(Label1)
        Controls.Add(barcodeTxtBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "POSForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Point of Sales"
        CType(productsDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents barcodeTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents productsDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grandTotalTxtBox As TextBox
    Friend WithEvents paymentTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cashbackTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents checkoutBtn As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents tenBtn As Button
    Friend WithEvents twentyBtn As Button
    Friend WithEvents fiftyBtn As Button
    Friend WithEvents hundredBtn As Button
    Friend WithEvents hapusItemBtn As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents kelolaProductToolTip As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents aboutToolTip As ToolStripLabel
End Class
