<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        productDataGrid = New DataGridView()
        Label2 = New Label()
        addProductBtn = New Button()
        CType(productDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' productDataGrid
        ' 
        productDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productDataGrid.Location = New Point(24, 59)
        productDataGrid.Name = "productDataGrid"
        productDataGrid.Size = New Size(593, 313)
        productDataGrid.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(35, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 34)
        Label2.TabIndex = 2
        Label2.Text = "Data Produk"
        ' 
        ' addProductBtn
        ' 
        addProductBtn.BackColor = Color.LightGreen
        addProductBtn.Font = New Font("Poppins ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addProductBtn.ForeColor = Color.DarkGreen
        addProductBtn.Location = New Point(172, 38)
        addProductBtn.Name = "addProductBtn"
        addProductBtn.Size = New Size(33, 32)
        addProductBtn.TabIndex = 21
        addProductBtn.Text = "+"
        addProductBtn.UseVisualStyleBackColor = False
        ' 
        ' ProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(651, 450)
        Controls.Add(addProductBtn)
        Controls.Add(Label2)
        Controls.Add(productDataGrid)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ProductForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kelola Produk"
        CType(productDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents productDataGrid As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents addProductBtn As Button
End Class
