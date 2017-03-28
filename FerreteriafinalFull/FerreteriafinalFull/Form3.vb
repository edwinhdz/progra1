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
End Class