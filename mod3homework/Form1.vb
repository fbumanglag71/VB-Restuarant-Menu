'' Author: Francisco Bumanglag
'' Project: Restuarnt Menu
'' Assignment: Module 3 Homework
'' Course: Visual Basic, Santa Ana College
'' Class: CMPR105 Derendal Huynh 
'' Date: September 7, 2022


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim WithCheeseBurger As Double = 4.79
        Dim BottledWater As Double = 1.49

        Dim total As Double = WithCheeseBurger + BottledWater

        If CheckBox1.Checked = True And CheckBox3.Checked = True And RadioButton2.Checked = True _
            And RadioButton6.Checked = True Then
            TextBox1.Text = FormatCurrency(total)


        End If

    End Sub
End Class
