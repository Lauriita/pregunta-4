Public Class Form1

    Dim a(5, 5) As Integer
    Dim b(5, 5) As Integer
    Dim cadena As String
    Dim cadena2 As String
    Dim i, j As Integer
    Dim random As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        For i = 0 To 4

            For j = 0 To 4
                a(i, j) = random.Next(0, 9)
                cadena = cadena & " " & a(i, j)

            Next
            cadena = cadena & vbNewLine
        Next

        For i = 0 To 4

            For j = 0 To 4

                b(j, i) = a(j, i)
                cadena2 = cadena2 & " " & b(j, i)
            Next

            cadena2 = cadena2 & vbNewLine
        Next

        TextBox1.Text = cadena
        TextBox2.Text = cadena2

    End Sub
End Class
