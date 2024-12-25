Public Class ReportForm

    Private OrdersTable As DataTable
    Private Profit As Decimal
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeOrderTable()
        Dim orderRepository As OrderRepository = New OrderRepository()
        Dim orders As List(Of Order) = orderRepository.FindAll()
        Profit = 0
        profitDataGrid.DataSource = OrdersTable
        If orders.Count > 0 Then
            For Each order As Order In orders
                Profit += order.TotalAmount
                Dim newDataOrder As DataRow = OrdersTable.NewRow()
                newDataOrder("Order Reference") = order.Ref
                newDataOrder("Total Pembelian") = order.TotalAmount
                newDataOrder("Bayar") = order.PaymentAmount
                newDataOrder("Kembalian") = order.Cashback
                newDataOrder("Tanggal Transaksi") = order.CreatedAt
                OrdersTable.Rows.Add(newDataOrder)
            Next
        End If

        OrdersTable.DefaultView.Sort = "Tanggal Transaksi DESC"
        profitDataGrid.DataSource = OrdersTable.DefaultView.ToTable()
        profitDataGrid.ReadOnly = True

        profitTxtBox.Text = Rupiah(Profit)

    End Sub

    Private Sub InitializeOrderTable()
        OrdersTable = New DataTable()
        OrdersTable.Columns.Add("Order Reference", GetType(String))
        OrdersTable.Columns.Add("Total Pembelian", GetType(Decimal))
        OrdersTable.Columns.Add("Bayar", GetType(Decimal))
        OrdersTable.Columns.Add("Kembalian", GetType(Decimal))
        OrdersTable.Columns.Add("Tanggal Transaksi", GetType(String))
    End Sub

    Private Sub detailTransactionBtn_Click(sender As Object, e As EventArgs) Handles detailTransactionBtn.Click
        If profitDataGrid.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = profitDataGrid.SelectedRows(0).Index

            If selectedIndex >= 0 AndAlso selectedIndex < profitDataGrid.Rows.Count Then
                Dim orderDetailForm As OrderDetailForm = New OrderDetailForm()
                Dim row = profitDataGrid.Rows(selectedIndex)
                orderDetailForm.OrderRef = row.Cells("Order Reference").Value.ToString()
                orderDetailForm.ShowDialog()
            Else
                MessageBox.Show("Indeks baris tidak valid.")
            End If
        Else
            MessageBox.Show("Pilih order terlebih dahulu.")
        End If

    End Sub
End Class