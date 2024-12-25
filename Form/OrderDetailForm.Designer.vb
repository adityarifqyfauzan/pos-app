<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetailForm
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
        orderDetailDataGrid = New DataGridView()
        label1 = New Label()
        paymentLabel = New Label()
        cashbackLabel = New Label()
        orderDateLabel = New Label()
        grandTotalTxtBox = New TextBox()
        grandTotalLabel = New Label()
        GroupBox1 = New GroupBox()
        cashbackTxtBox = New TextBox()
        paymentTxtBox = New TextBox()
        orderRefLabel = New Label()
        CType(orderDetailDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' orderDetailDataGrid
        ' 
        orderDetailDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        orderDetailDataGrid.Location = New Point(25, 115)
        orderDetailDataGrid.Name = "orderDetailDataGrid"
        orderDetailDataGrid.Size = New Size(347, 294)
        orderDetailDataGrid.TabIndex = 100
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(25, 22)
        label1.Name = "label1"
        label1.Size = New Size(63, 22)
        label1.TabIndex = 2
        label1.Text = "Order Ref"
        ' 
        ' paymentLabel
        ' 
        paymentLabel.AutoSize = True
        paymentLabel.Font = New Font("Poppins Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        paymentLabel.Location = New Point(287, 73)
        paymentLabel.Name = "paymentLabel"
        paymentLabel.Size = New Size(54, 23)
        paymentLabel.TabIndex = 5
        paymentLabel.Text = "Bayar"
        ' 
        ' cashbackLabel
        ' 
        cashbackLabel.AutoSize = True
        cashbackLabel.Font = New Font("Poppins Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cashbackLabel.Location = New Point(251, 131)
        cashbackLabel.Name = "cashbackLabel"
        cashbackLabel.Size = New Size(90, 23)
        cashbackLabel.TabIndex = 7
        cashbackLabel.Text = "Kembalian"
        ' 
        ' orderDateLabel
        ' 
        orderDateLabel.AutoSize = True
        orderDateLabel.Location = New Point(26, 74)
        orderDateLabel.Name = "orderDateLabel"
        orderDateLabel.Size = New Size(71, 15)
        orderDateLabel.TabIndex = 9
        orderDateLabel.Text = "{order-date}"
        orderDateLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' grandTotalTxtBox
        ' 
        grandTotalTxtBox.Font = New Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grandTotalTxtBox.Location = New Point(27, 27)
        grandTotalTxtBox.Name = "grandTotalTxtBox"
        grandTotalTxtBox.ReadOnly = True
        grandTotalTxtBox.Size = New Size(314, 43)
        grandTotalTxtBox.TabIndex = 1
        grandTotalTxtBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' grandTotalLabel
        ' 
        grandTotalLabel.AutoSize = True
        grandTotalLabel.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grandTotalLabel.Location = New Point(224, 7)
        grandTotalLabel.Name = "grandTotalLabel"
        grandTotalLabel.Size = New Size(117, 28)
        grandTotalLabel.TabIndex = 3
        grandTotalLabel.Text = "Grand Total"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(cashbackTxtBox)
        GroupBox1.Controls.Add(paymentTxtBox)
        GroupBox1.Controls.Add(grandTotalTxtBox)
        GroupBox1.Controls.Add(cashbackLabel)
        GroupBox1.Controls.Add(paymentLabel)
        GroupBox1.Controls.Add(grandTotalLabel)
        GroupBox1.Location = New Point(25, 417)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(347, 203)
        GroupBox1.TabIndex = 101
        GroupBox1.TabStop = False
        ' 
        ' cashbackTxtBox
        ' 
        cashbackTxtBox.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cashbackTxtBox.Location = New Point(27, 152)
        cashbackTxtBox.Name = "cashbackTxtBox"
        cashbackTxtBox.ReadOnly = True
        cashbackTxtBox.Size = New Size(314, 31)
        cashbackTxtBox.TabIndex = 9
        cashbackTxtBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' paymentTxtBox
        ' 
        paymentTxtBox.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        paymentTxtBox.Location = New Point(27, 95)
        paymentTxtBox.Name = "paymentTxtBox"
        paymentTxtBox.ReadOnly = True
        paymentTxtBox.Size = New Size(314, 31)
        paymentTxtBox.TabIndex = 8
        paymentTxtBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' orderRefLabel
        ' 
        orderRefLabel.AutoSize = True
        orderRefLabel.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        orderRefLabel.Location = New Point(21, 44)
        orderRefLabel.Name = "orderRefLabel"
        orderRefLabel.Size = New Size(102, 28)
        orderRefLabel.TabIndex = 102
        orderRefLabel.Text = "{order-ref}"
        ' 
        ' OrderDetailForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(401, 632)
        Controls.Add(orderRefLabel)
        Controls.Add(orderDateLabel)
        Controls.Add(label1)
        Controls.Add(orderDetailDataGrid)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "OrderDetailForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Detail Transaksi"
        CType(orderDetailDataGrid, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents orderDetailDataGrid As DataGridView
    Friend WithEvents label1 As Label
    Friend WithEvents paymentLabel As Label
    Friend WithEvents cashbackLabel As Label
    Friend WithEvents orderDateLabel As Label
    Friend WithEvents grandTotalTxtBox As TextBox
    Friend WithEvents grandTotalLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cashbackTxtBox As TextBox
    Friend WithEvents paymentTxtBox As TextBox
    Friend WithEvents orderRefLabel As Label
End Class
