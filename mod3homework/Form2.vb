Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cost As Double

        If TextBox1.Text < 6 Then
            cost = 0.75 * Val(TextBox1.Text)

        ElseIf TextBox1.Text >= 12 Then
            cost = 0.6 * Val(TextBox1.Text)
        End If

        'where formatting occures
        TextBox2.Text = FormatCurrency(cost)

    End Sub
End Class