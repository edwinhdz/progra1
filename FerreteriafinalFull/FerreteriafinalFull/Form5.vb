
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

        'crea el archivo temporal
        sw = New StreamWriter("c:\Programacion1\temp.txt")
        'lee los datos
        sr = New StreamReader("C:\Programacion1\Datos.txt")

        'Aqui se guarda cada linea
        Dim line As String
        line = sr.ReadLine()
        Do While Not line Is Nothing 'Verifica que la linea NO esté vacia
            Dim categorias() As String = line.Split(" ") 'divide en secciones la cadena

            If categorias(0) = lblProducto.Text Then 'Cambia el valor
                nuevalinea = categorias(0) & " " & categorias(1) & " " & (Val(categorias(2)) + Val(txtCantidad.Text) & " " & categorias(3) & " " & categorias(4) & " " & categorias(5) & " " & categorias(6) & " ")
                sw.WriteLine(nuevalinea)
            Else
                sw.WriteLine(line) 'Escribe la linea que NO sea del codigo
            End If

            line = sr.ReadLine()
        Loop
        'Se cierra la lectura y escritura
        sw.Close()
        sr.Close()

        'aqui se renombrea el archivo temporal
        File.Delete("c:\Programacion1\Datos.txt")
        File.Move("c:\Programacion1\temp.txt", "c:\Programacion1\Datos.txt")
        Form3.leerProductos() 'Carga los productos en el combobox
        Form3.CargarProductos() 'Carga los productos en el dataGridView
    End Sub
End Class