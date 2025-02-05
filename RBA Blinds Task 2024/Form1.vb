' 6/02/25
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim subtotal As Decimal
        Dim quantity As Integer
        Dim height As Decimal
        Dim width As Decimal
        Dim price As Decimal
        Dim oldsubtotal As Decimal




        Select Case True
            Case radNatural.Checked
                price = 180
            Case radWhite.Checked
                price = 185.5
            Case radMatte.Checked
                price = 203
            Case radGloss.Checked
                price = 210
        End Select

        height = CDec(txtHeight.Text)
        width = CDec(txtWidth.Text)
        quantity = CDec(numQuantity.Text)

        subtotal = ((height * width) * price) * quantity
        oldsubtotal = ((height * width) * price) * quantity

        TXTsubtotal.Text = FormatCurrency(subtotal)
        TXTgst.Text = FormatCurrency(subtotal * 0.1)
        TXTtotal.Text = FormatCurrency(subtotal * 1.1)

        If quantity = 1 Then
            subtotal = subtotal
            TXTdiscount.Text = 0
        ElseIf quantity = 2 Then
            subtotal = subtotal * 0.95
            TXTdiscount.Text = FormatCurrency(oldsubtotal - subtotal)
        ElseIf quantity = 3 Then
            subtotal = subtotal * 0.9
            TXTdiscount.Text = FormatCurrency(oldsubtotal - subtotal)
        ElseIf quantity = 4 Then
            subtotal = subtotal * 0.85
            TXTdiscount.Text = FormatCurrency(oldsubtotal - subtotal)
        ElseIf quantity >= 5 Then
            subtotal = subtotal * 0.8
            TXTdiscount.Text = FormatCurrency(oldsubtotal - subtotal)
        End If

    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        End
    End Sub

    Private Sub BTNclear_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        txtWidth.Text = ""
        txtHeight.Text = ""
        TXTdiscount.Text = ""
        TXTsubtotal.Text = ""
        TXTgst.Text = ""
        TXTtotal.Text = ""
        radGloss.Checked = False
        radMatte.Checked = False
        radNatural.Checked = False
        radWhite.Checked = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTdiscount.ReadOnly = True
        TXTgst.ReadOnly = True
        TXTsubtotal.ReadOnly = True
        TXTtotal.ReadOnly = True
    End Sub
End Class
