Public Structure Product
    Public Barcode As String
    Public Name As String
    Public Price As Decimal
    Public Stock As Int64
    Public CreatedAt As String
    Public UpdatedAt As String

    Public Sub New(barcode As String, name As String, price As Decimal, stock As Int64)
        Me.Barcode = barcode
        Me.Name = name
        Me.Price = price
        Me.Stock = stock

        Dim timestamp As DateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Me.CreatedAt = timestamp.ToString()
        Me.UpdatedAt = timestamp.ToString()

    End Sub
     
End Structure
