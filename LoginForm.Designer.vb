<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        usernameTxtBox = New TextBox()
        passwordTxtBox = New TextBox()
        usernameErrLabel = New Label()
        passwordErrLabel = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9.75F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(56, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 23)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9.75F)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(56, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 23)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' usernameTxtBox
        ' 
        usernameTxtBox.Font = New Font("Poppins", 12F)
        usernameTxtBox.Location = New Point(56, 151)
        usernameTxtBox.Name = "usernameTxtBox"
        usernameTxtBox.Size = New Size(289, 31)
        usernameTxtBox.TabIndex = 3
        ' 
        ' passwordTxtBox
        ' 
        passwordTxtBox.Font = New Font("Poppins", 12F)
        passwordTxtBox.Location = New Point(56, 241)
        passwordTxtBox.Name = "passwordTxtBox"
        passwordTxtBox.PasswordChar = "*"c
        passwordTxtBox.Size = New Size(289, 31)
        passwordTxtBox.TabIndex = 4
        ' 
        ' usernameErrLabel
        ' 
        usernameErrLabel.AutoSize = True
        usernameErrLabel.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameErrLabel.ForeColor = Color.IndianRed
        usernameErrLabel.Location = New Point(56, 185)
        usernameErrLabel.Name = "usernameErrLabel"
        usernameErrLabel.Size = New Size(89, 19)
        usernameErrLabel.TabIndex = 5
        usernameErrLabel.Text = "error message"
        ' 
        ' passwordErrLabel
        ' 
        passwordErrLabel.AutoSize = True
        passwordErrLabel.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordErrLabel.ForeColor = Color.IndianRed
        passwordErrLabel.Location = New Point(56, 275)
        passwordErrLabel.Name = "passwordErrLabel"
        passwordErrLabel.Size = New Size(89, 19)
        passwordErrLabel.TabIndex = 6
        passwordErrLabel.Text = "error message"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OliveDrab
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(56, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(289, 46)
        Button1.TabIndex = 7
        Button1.Text = "Masuk"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins ExtraBold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(107, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 65)
        Label4.TabIndex = 8
        Label4.Text = "POS APP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(116, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 22)
        Label5.TabIndex = 9
        Label5.Text = "Aditya Rifqy Fauzan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(56, 362)
        Label6.Name = "Label6"
        Label6.Size = New Size(223, 19)
        Label6.TabIndex = 10
        Label6.Text = "username: admin | password: admin123"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(402, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(passwordErrLabel)
        Controls.Add(usernameErrLabel)
        Controls.Add(passwordTxtBox)
        Controls.Add(usernameTxtBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTxtBox As TextBox
    Friend WithEvents passwordTxtBox As TextBox
    Friend WithEvents usernameErrLabel As Label
    Friend WithEvents passwordErrLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
