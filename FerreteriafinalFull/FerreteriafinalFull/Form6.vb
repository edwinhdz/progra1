Imports System.IO
Public Class Form6
    Public sw As StreamWriter
    Public sr As StreamReader
    Public str As String
    Public fs As FileStream
    Public band As Boolean = False
    Dim nuevalinea As String
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se carga la información en el label y textbox de este formulario
        sr = New StreamReader("C:\Programacion1\Datos.txt")
        Dim linea As String
        linea = sr.ReadLine
        Do While Not linea Is Nothing
            Dim categorias() As String = linea.Split(" ")
            If categorias(0) = Form3.cbxProductos.Text Then
                lblCodigoProducto.Text = categorias(0)
                txtNombre.Text = categorias(1)
                txtCantidad.Text = categorias(2)
                txtCodProveedor.Text = categorias(3)
                txtProveedor.Text = categorias(4)
                txtPrecioUnitario.Text = categorias(5)
                txtPrecioVenta.Text = categorias(6)
            End If
            linea = sr.ReadLine()
        Loop
        sr.Close()
    End Sub

    Private Sub txtGuardar_Click(sender As Object, e As EventArgs) Handles txtGuardar.Click

        'crea el archivo temporal
        sw = New StreamWriter("c:\Programacion1\temp.txt")
        'lee los datos
        sr = New StreamReader("C:\Programacion1\Datos.txt")

        'Aqui se guarda cada linea
        Dim line As String
        line = sr.ReadLine()
        Do While Not line Is Nothing 'Verifica que la linea NO esté vacia
            Dim categorias() As String = line.Split(" ") 'divide en secciones la cadena
            If categorias(0) = lblCodigoProducto.Text Then 'Cambia el valor de la linea donde está el código
                nuevalinea = lblCodigoProducto.Text & " " & txtNombre.Text & " " & txtCantidad.Text & " " & txtCodProveedor.Text & " " & txtProveedor.Text & " " & txtPrecioUnitario.Text & " " & txtPrecioVenta.Text
                sw.WriteLine(nuevalinea)
            Else
                sw.WriteLine(line) 'Escribe la linea que NO sea del codigo
            End If
            line = sr.ReadLine() 'Cambia la línea 
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