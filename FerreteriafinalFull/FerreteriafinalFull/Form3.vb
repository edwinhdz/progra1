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
        leerProductos()
        CargarProductos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dgvProductos.Rows.Clear()
            ' Crear un flujo desde el fichero doc.txt
            sr = New StreamReader("C:\Programacion1\Datos.txt")
            ' Leer del fichero una línea de texto
            str = sr.ReadLine()
            Do While Not str Is Nothing
                Dim categorias() As String = str.Split(" ")
                If categorias(0) = txtBuscar.Text Then
                    dgvProductos.Rows.Add(categorias(0), categorias(1), categorias(2), categorias(3), categorias(4))
                    'MsgBox(categorias(0) & " " & categorias(1) & " " & " " & categorias(2))
                End If
                str = sr.ReadLine()
            Loop
            sr.Close()
        Catch ex As IOException
            MsgBox("Error: " + ex.Message)
        Finally
            ' Cerrar el fichero
            If (Not sr Is Nothing) Then sr.Close()
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click



        Using fileWrite As New StreamWriter("c:\Programacion1\temp.txt")
            Using fielRead As New StreamReader("C:\Programacion1\Datos.txt")
                Dim line As [String]

                While (InlineAssignHelper(line, fielRead.ReadLine())) IsNot Nothing
                    Dim datos As String() = line.Split(New Char() {","c})
                    If datos(0) <> txtBuscar.Text Then
                        fileWrite.WriteLine(line)

                    End If
                End While
            End Using
        End Using

        'aqui se renombrea el archivo temporal
        File.Delete("c:\Programacion1\Datos.txt")
        File.Move("c:\Programacion1\temp.txt", "c:\Programacion1\Datos.txt")
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerProductos()
        CargarProductos()
    End Sub
    Private Sub leerProductos()
        'AÑADE AL COMBOBOX LOS CODIGOS DE LOS PRODUCTOS
        Try
            cbxProductos.Items.Clear()
            sr = New StreamReader("C:\Programacion1\Datos.txt")
            ' Leer del fichero una línea de texto
            str = sr.ReadLine()
            Do While Not str Is Nothing
                Dim categorias() As String = str.Split(" ")
                cbxProductos.Items.Add(categorias(0))
                str = sr.ReadLine()
            Loop
            sr.Close()
        Catch ex As IOException
            MsgBox("Error: " + ex.Message)
        Finally
            ' Cerrar el fichero
            If (Not sr Is Nothing) Then sr.Close()
        End Try
    End Sub
    Private Sub CargarProductos()
        Try
            dgvProductos.Rows.Clear()
            ' Crear un flujo desde el fichero doc.txt
            sr = New StreamReader("C:\Programacion1\Datos.txt")
            ' Leer del fichero una línea de texto
            str = sr.ReadLine()
            Do While Not str Is Nothing
                Dim categorias() As String = str.Split(" ")
                dgvProductos.Rows.Add(categorias(0), categorias(1), categorias(2), categorias(3), categorias(4))
                'MsgBox(categorias(0) & " " & categorias(1) & " " & " " & categorias(2))
                str = sr.ReadLine()
            Loop
            sr.Close()
        Catch ex As IOException
            MsgBox("Error: " + ex.Message)
        Finally
            ' Cerrar el fichero
            If (Not sr Is Nothing) Then sr.Close()
        End Try

    End Sub
End Class