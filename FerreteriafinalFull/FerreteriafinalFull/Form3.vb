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
            fs = New FileStream("C:\Programacion1\Datos.txt", FileMode.Append, FileAccess.Write)
            sw = New StreamWriter(fs)
            MsgBox("Abriendo archivo")
            str = txtCodigoProducto.Text & " " & txtNombre.Text & " " & txtCantidad.Text & " " & txtPrecioUnitario.Text & " "
            sw.WriteLine(str)
            MsgBox("Datos Guardados")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            MsgBox("Cerrando el archivo")
            If (Not sw Is Nothing) Then sw.Close()
        End Try
    End Sub
End Class