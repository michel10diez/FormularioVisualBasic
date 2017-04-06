Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(insercionYener(TextId.Text, TextNombre.Text, CDate(dtpFecha.Text), CInt(TextEdad.Text)))
        limpiar()
    End Sub
    Sub limpiar()
        TextId.Clear()
        TextNombre.Clear()
        TextEdad.Clear()
        dtpFecha.Update() 'revisar si se limpia
    End Sub
End Class
