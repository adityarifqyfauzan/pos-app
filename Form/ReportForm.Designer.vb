<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        profitDataGrid = New DataGridView()
        profitTxtBox = New TextBox()
        Label3 = New Label()
        detailTransactionBtn = New Button()
        CType(profitDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' profitDataGrid
        ' 
        profitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        profitDataGrid.Location = New Point(43, 51)
        profitDataGrid.Name = "profitDataGrid"
        profitDataGrid.Size = New Size(601, 263)
        profitDataGrid.TabIndex = 0
        ' 
        ' profitTxtBox
        ' 
        profitTxtBox.Font = New Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        profitTxtBox.Location = New Point(43, 348)
        profitTxtBox.Name = "profitTxtBox"
        profitTxtBox.ReadOnly = True
        profitTxtBox.Size = New Size(601, 79)
        profitTxtBox.TabIndex = 8
        profitTxtBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(484, 326)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 28)
        Label3.TabIndex = 7
        Label3.Text = "Total Keuntungan"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' detailTransactionBtn
        ' 
        detailTransactionBtn.BackColor = Color.CornflowerBlue
        detailTransactionBtn.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        detailTransactionBtn.ForeColor = Color.MidnightBlue
        detailTransactionBtn.Location = New Point(43, 310)
        detailTransactionBtn.Name = "detailTransactionBtn"
        detailTransactionBtn.Size = New Size(134, 32)
        detailTransactionBtn.TabIndex = 0
        detailTransactionBtn.Text = "Detail Transaksi"
        detailTransactionBtn.UseVisualStyleBackColor = False
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 464)
        Controls.Add(detailTransactionBtn)
        Controls.Add(Label3)
        Controls.Add(profitDataGrid)
        Controls.Add(profitTxtBox)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ReportForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laporan Transaksi"
        CType(profitDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents profitDataGrid As DataGridView
    Friend WithEvents profitTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents detailTransactionBtn As Button
End Class
