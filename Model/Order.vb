Public Structure Order
    Public Ref As String
    Public TotalAmount As Decimal
    Public PaymentAmount As Decimal
    Public Cashback As Decimal
    Public CreatedAt As String
    Public UpdatedAt As String

    Public Sub New(totalAmount As Decimal, paymentAmount As Decimal, cashback As Decimal)
        Me.Ref = GenerateRandomString(20)
        Me.TotalAmount = totalAmount
        Me.PaymentAmount = paymentAmount
        Me.Cashback = cashback

        Dim timestamp As DateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Me.CreatedAt = timestamp.ToString()
        Me.UpdatedAt = timestamp.ToString()

    End Sub
End Structure
