Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameErrLabel.Visible = False
        passwordErrLabel.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isValid As Boolean = True

        ' validasi username, tidak boleh kosong
        If String.IsNullOrWhiteSpace(usernameTxtBox.Text) Then
            usernameErrLabel.Text = "Username tidak boleh kosong."
            usernameErrLabel.Visible = True
            isValid = False
        End If

        ' validasi password, tidak boleh kosong
        If String.IsNullOrWhiteSpace(passwordTxtBox.Text) Then
            passwordErrLabel.Text = "Password tidak boleh kosong."
            passwordErrLabel.Visible = True
            isValid = False
        End If

        ' apabila salah satu atau kedua validasi diatas gagal, maka langsung return
        If Not isValid Then
            Return
        End If

        Dim username As String = usernameTxtBox.Text
        Dim password As String = passwordTxtBox.Text

        ' instansiasi userRepository untuk mengambil data user berdasarkan username
        Dim userRepository As New UserRepository()
        Dim user As User? = userRepository.GetUserByUsername(username)

        ' cek apakah datanya ada atau tidak
        If user.HasValue Then

            ' jika ada maka lakukan validasi password
            Dim foundUser As User = user.Value
            If foundUser.ComparePassword(password) Then

                ' membuat session
                CurrentUserName = foundUser.Username
                CurrentUserID = foundUser.ID
                IsLoggedIn = True

                MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Menyembunyikan form login
                Me.Hide()

                ' Membuka form Dashboard
                Dim dashboardForm As New POSForm()
                dashboardForm.ShowDialog()

                logout()

            Else
                MessageBox.Show("Password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("User tidak terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub logout()
        Me.Show()
        CurrentUserID = 0
        CurrentUserName = ""
        IsLoggedIn = False

        usernameTxtBox.Text = ""
        passwordTxtBox.Text = ""
    End Sub

End Class
