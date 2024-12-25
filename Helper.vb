Module Helper

    Public Function Rupiah(amount As Decimal) As String
        Return String.Format(New Globalization.CultureInfo("id-ID"), "Rp {0:N0}", amount)
    End Function

    Public Function GenerateRandomString(length As Integer) As String
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim random As New Random()
        Dim result As New Text.StringBuilder()

        For i As Integer = 1 To length
            Dim index As Integer = random.Next(0, characters.Length)
            result.Append(characters(index))
        Next

        Return result.ToString()
    End Function

    Public Sub AllowOnlyNumbers(sender As Object, e As KeyPressEventArgs)
        ' izinkan hanya angka dan kontrol (seperti Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub AdjustDataGridViewHeight(dataGridView As DataGridView)
        Dim rowHeight As Integer = dataGridView.RowTemplate.Height
        Dim headerHeight As Integer = dataGridView.ColumnHeadersHeight
        Dim totalRows As Integer = dataGridView.Rows.Count

        dataGridView.Height = headerHeight + (rowHeight * totalRows)
    End Sub

End Module
