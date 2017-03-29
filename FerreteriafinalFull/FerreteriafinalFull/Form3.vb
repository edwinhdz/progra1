Imports System
Imports System.IO
Imports System.Environment
Public Class Form3
    Public sw As StreamWriter
    Public sr As StreamReader
    Public str As String
    Public fs As FileStream

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If Not Directory.Exists("C:\Programacion1\") Then
                Directory.CreateDirectory("C:\Programacion1\")
            End If
            fs = New FileStream("C:\Programacion1\Datos.txt", FileMode.Append, FileAccess.Write)
            sw = New StreamWriter(fs)
            MsgBox("Abriendo archivo")
            str = txtCodigoProducto.Text & " " & txtNombre.Text & " " & txtCantidad.Text & " " & txtPrecioUnitario.Text & " " & txtPrecioVenta.Text & " " & txtCodProveedor.Text & " " & txtProveedor.Text
            sw.WriteLine(str)
            MsgBox("Datos Guardados")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            MsgBox("Cerrando el archivo")
            If (Not sw Is Nothing) Then sw.Close()
        End Try
        txtCantidad.Clear()
        txtCodigoProducto.Clear()
        txtCodProveedor.Clear()
        txtNombre.Clear()
        txtPrecioUnitario.Clear()
        txtPrecioVenta.Clear()
        txtProveedor.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Crear un flujo desde el fichero doc.txt
            sr = New StreamReader("C:\Programacion1\Datos.txt")
            ' Leer del fichero una línea de texto
            str = sr.ReadLine()
            Do While Not str Is Nothing
                Dim categorias() As String = str.Split(" ")
                If str.Contains(txtBuscar.Text) Then
                    MsgBox(categorias(0) & " " & categorias(1) & " " & " " & categorias(2))
                End If
                str = sr.ReadLine()
            Loop
            sr.Close()
        Catch ex As IOException
            Console.WriteLine("Error: " + ex.Message)
        Finally
            ' Cerrar el fichero
            If (Not sr Is Nothing) Then sr.Close()
        End Try

    End Sub
End Class