Public Structure OrderDetail
    Public OrderRef As String
    Public ProductBarcode As String
    Public Price As Decimal
    Public Qty As Int64
    Public CreatedAt As String
    Public UpdatedAt As String

    Public Sub New(orderRef As String, productBarcode As String, price As Decimal, qty As Int64)
        Me.OrderRef = orderRef
        Me.Price = price
        Me.ProductBarcode = productBarcode
        Me.Qty = qty

        Dim timestamp As DateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Me.CreatedAt = timestamp.ToString()
        Me.UpdatedAt = timestamp.ToString()
    End Sub

End Structure
