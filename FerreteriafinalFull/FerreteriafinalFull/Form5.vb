
Imports System
Imports System.IO
Imports System.Environment
Public Class Form5
    Public sw As StreamWriter
    Public sr As StreamReader
    Public str As String
    Public fs As FileStream
    Dim nuevalinea As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProducto.Text = Form3.cbxProductos.Text
    End Sub

    Private Sub btnAumentar_Click(sender As Object, e As EventArgs) Handles btnAumentar.Click
        Try

            sr = New StreamReader("C:\Programacion1\Datos.txt")
            'Busca el SKU
            'Escribe la nueva linea (registro)
            str = sr.ReadLine()
            Do While Not str Is Nothing
                Dim categorias() As String = str.Split(" ")
                If categorias(0) = lblProducto.Text Then
                    categorias(2) = Val(categorias(2)) + Val(txtCantidad.Text)
                    nuevalinea = categorias(0) & " " & categorias(1) & " " & categorias(2) & " " & categorias(3) & " " & categorias(4) & " " & categorias(5) & " " & categorias(6) & " "
                End If
                str = sr.ReadLine()
            Loop
            sr.Close()
            'str = txtCodigoProducto.Text

            'Escribe la nueva linea del registro
            fs = New FileStream("C:\Programacion1\Datos.txt", FileMode.Append, FileAccess.Write)
            sw = New StreamWriter(fs)


        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            MsgBox("Cerrando el archivo")
            If (Not sw Is Nothing) Then sw.Close()
        End Try
    End Sub
End Class