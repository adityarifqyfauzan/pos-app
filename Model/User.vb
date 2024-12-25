Imports System.Security.Cryptography
Imports System.Text

Public Structure User
    Public ID As Int64
    Public Username As String
    Public Password As String

    Public Sub New(username As String, password As String)
        Me.Username = username

        ' hash password menggunakan sha256 
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = SHA256.HashData(bytes)
        Dim stringBuilder As New StringBuilder()
        For Each b As Byte In hash
            stringBuilder.Append(b.ToString("x2"))
        Next

        Me.Password = stringBuilder.ToString()

    End Sub

    Public Function ComparePassword(password As String) As Boolean
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = SHA256.HashData(bytes)
        Dim stringBuilder As New StringBuilder()
        For Each b As Byte In hash
            stringBuilder.Append(b.ToString("x2"))
        Next
        password = stringBuilder.ToString()
        Return password = Me.Password
    End Function

End Structure
