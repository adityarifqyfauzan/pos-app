Public Class OrderDetailForm

    Private OrderDetailsTable As DataTable
    Public OrderRef As String

    Private Sub InitiateOrderDetail()
        OrderDetailsTable = New DataTable()
        OrderDetailsTable.Columns.Add("Nama Produk", GetType(String))
        OrderDetailsTable.Columns.Add("Harga", GetType(Decimal))
        OrderDetailsTable.Columns.Add("Qty", GetType(Int64))
    End Sub

    Private Sub OrderDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitiateOrderDetail()
        orderDetailDataGrid.DataSource = OrderDetailsTable

        Dim orderRepository As OrderRepository = New OrderRepository()
        Dim orderDetailRepository As OrderDetailRepository = New OrderDetailRepository()
        Dim productRepository As ProductRepository = New ProductRepository()

        Dim order As Order? = orderRepository.FindOrderByRef(OrderRef)
        If Not order.HasValue Then
            MessageBox.Show("Order tidak ditemukan!", "Peringatan!")
            Me.Close()
            Return
        End If

        orderRefLabel.Text = order?.Ref
        orderDateLabel.Text = order?.CreatedAt
        grandTotalTxtBox.Text = Rupiah(order?.TotalAmount)
        paymentTxtBox.Text = Rupiah(order?.PaymentAmount)
        cashbackTxtBox.Text = Rupiah(order?.Cashback)

        Dim orderDetails As List(Of OrderDetail) = orderDetailRepository.FindAll(order?.Ref)
        For Each orderDetail As OrderDetail In orderDetails

            Dim product As Product? = productRepository.FindProductByBarcode(orderDetail.ProductBarcode)
            Dim newOrderDetailRow As DataRow = OrderDetailsTable.NewRow()
            Dim productName = "[DELETED_PRODUCT]"
            If product.HasValue Then
                productName = product?.Name
            End If

            newOrderDetailRow("Nama Produk") = productName
            newOrderDetailRow("Harga") = orderDetail.Price
            newOrderDetailRow("Qty") = orderDetail.Qty
            OrderDetailsTable.Rows.Add(newOrderDetailRow)

        Next

        AdjustDataGridViewHeight(orderDetailDataGrid)
        orderDetailDataGrid.ReadOnly = True
        Dim bottomOfDataGridView As Integer = orderDetailDataGrid.Top + orderDetailDataGrid.Height + 10 ' 10
        GroupBox1.Top = bottomOfDataGridView
        Me.AutoSize = True
        Me.Height = GroupBox1.Bottom + 100

    End Sub



End Class