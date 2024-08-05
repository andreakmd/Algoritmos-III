Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim connection As New OleDbConnection
    Dim command As New OleDbCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ANDREA\Documents\BaseEmpresa\employee.mdb"
            connection.Open()
            MsgBox("Conexión exitosa", vbInformation, "Conexión segura")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos: " & ex.Message, vbCritical, "Sin conexión")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim query As String = "INSERT INTO employee(nombres, apellidos, cedula, telefono, direccion) VALUES (@nombres, @apellidos, @cedula, @telefono, @direccion)"

            command = New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@nombres", TextBox1.Text)
            command.Parameters.AddWithValue("@apellidos", TextBox2.Text)
            command.Parameters.AddWithValue("@cedula", TextBox3.Text)
            command.Parameters.AddWithValue("@telefono", TextBox4.Text)
            command.Parameters.AddWithValue("@direccion", TextBox5.Text)
            command.ExecuteNonQuery()
            MsgBox("Registro guardado", vbInformation, "Registro almacenado")
        Catch ex As Exception
            MsgBox("Error al guardar: " & ex.Message, vbCritical, "No se guardó")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
    End Sub
End Class
