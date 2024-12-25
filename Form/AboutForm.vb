Imports System.IO
Imports System.Net

Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imgUrl As String = "https://upload.wikimedia.org/wikipedia/id/b/b7/Logo_Universitas_Siber_Asia.png"

        Try
            ' Buat permintaan HTTP dengan User-Agent
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(imgUrl), HttpWebRequest)
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36"

            ' Dapatkan respons
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using stream As Stream = response.GetResponseStream()
                    ' Muat gambar ke PictureBox
                    PictureBox1.Image = Image.FromStream(stream)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End Using
            End Using
        Catch ex As Exception
            ' Tampilkan pesan error
            MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PictureBox1.Image = Nothing ' Set gambar kosong jika gagal
        End Try
    End Sub


    Private Sub githubBtn_Click(sender As Object, e As EventArgs) Handles githubBtn.Click
        Dim websiteUrl As String = "www.github.com/adityarifqyfauzan"

        If Not websiteUrl.StartsWith("http://") AndAlso Not websiteUrl.StartsWith("https://") Then
            websiteUrl = "https://" & websiteUrl
        End If

        Try
            Dim psi As New ProcessStartInfo() With {
                .FileName = websiteUrl,
                .UseShellExecute = True
            }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show($"Gagal membuka website: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim websiteUrl As String = "www.github.com/adityarifqyfauzan/pos-app"

        If Not websiteUrl.StartsWith("http://") AndAlso Not websiteUrl.StartsWith("https://") Then
            websiteUrl = "https://" & websiteUrl
        End If

        Try
            Dim psi As New ProcessStartInfo() With {
                .FileName = websiteUrl,
                .UseShellExecute = True
            }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show($"Gagal membuka website: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class