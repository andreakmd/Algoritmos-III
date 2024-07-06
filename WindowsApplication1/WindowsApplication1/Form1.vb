Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Funcion As New Cine(tbxNombre.Text, tbxCedula.Text, tbxPelicula.Text, tbxHora.Text, tbxSala.Text, tbxAsiento.Text)

        MessageBox.Show("Nombre: " & Funcion.nombre & vbCrLf & "Cédula: " & Funcion.cedula & vbCrLf & "Pelicula: " & Funcion.pelicula & vbCrLf & "Hora: " & Funcion.hora & vbCrLf & "Sala: " & Funcion.sala & vbCrLf & "Asiento: " & Funcion.asiento)
    End Sub
End Class