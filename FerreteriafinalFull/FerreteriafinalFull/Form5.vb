
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
            If categorias(0) <> cbxProductos.Text Then 'La condicion es que mientras line sea diferente al codigo, se escribe todo, menos donde está el código
                sw.WriteLine(line)
            End If

            line = sr.ReadLine()
        Loop
        'Se cierra la lectura y escritura
        sw.Close()
        sr.Close()

        'aqui se renombrea el archivo temporal
        File.Delete("c:\Programacion1\Datos.txt")
        File.Move("c:\Programacion1\temp.txt", "c:\Programacion1\Datos.txt")
        leerProductos() 'Carga los productos en el combobox
        CargarProductos() 'Carga los productos en el dataGridView
    End Sub
End Class