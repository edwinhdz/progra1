﻿Imports System
Imports System.IO
Imports System.Environment
Public Class Form3
    Public sw As StreamWriter
    Public sr As StreamReader
    Public str As String
    Public fs As FileStream
    Public band As Boolean = False

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If txtCodigoProducto.Text <> "" And txtNombre.Text <> "" And txtCantidad.Text <> "" And txtCodProveedor.Text <> "" And txtProveedor.Text <> "" And txtPrecioUnitario.Text <> "" And txtPrecioVenta.Text <> "" Then
                COMPROBARSIEXISTEELPRODUCTO()
                fs = New FileStream("C:\Programacion1\Datos.txt", FileMode.Append, FileAccess.Write)
                sw = New StreamWriter(fs)
                MsgBox("Abriendo archivo")
                str = txtCodigoProducto.Text & " " & txtNombre.Text & " " & txtCantidad.Text & " " & txtCodProveedor.Text & " " & txtProveedor.Text & " " & txtPrecioUnitario.Text & " " & txtPrecioVenta.Text
                sw.WriteLine(str)
                MsgBox("Datos Guardados")
                limpiar()

            Else
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            MsgBox("Cerrando el archivo")
            If (Not sw Is Nothing) Then sw.Close()
        End Try

        leerProductos()
        CargarProductos()

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
        Try
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
                line = sr.ReadLine() 'cambio de linea
            Loop
            'Se cierra la lectura y escritura
            sw.Close()
            sr.Close()

            'aqui se renombra el archivo temporal
            File.Delete("c:\Programacion1\Datos.txt")
            File.Move("c:\Programacion1\temp.txt", "c:\Programacion1\Datos.txt")
            leerProductos() 'Carga los productos en el combobox
            CargarProductos() 'Carga los productos en el dataGridView
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try


    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("C:\Programacion1") Then
            CrearCarpetaArchivo()
        Else
            CargarProductos()
            leerProductos()
            cbxProductos.SelectedIndex = 0
        End If

    End Sub
    Public Sub leerProductos()
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
    Public Sub CargarProductos()

        'Comienza el intento
        Try
            dgvProductos.Rows.Clear()
            ' Crear un flujo desde el fichero doc.txt
            sr = New StreamReader("C:\Programacion1\Datos.txt")
            ' Leer del fichero una línea de texto
            str = sr.ReadLine()
            Do While Not str Is Nothing
                Dim categorias() As String = str.Split(" ")
                dgvProductos.Rows.Add(categorias(0), categorias(1), categorias(2), categorias(3), categorias(4), categorias(5), categorias(6))
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub cbxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProductos.SelectedIndexChanged

    End Sub

    Private Sub COMPROBARSIEXISTEELPRODUCTO()
        sr = New StreamReader("C:\Programacion1\Datos.txt")
        Dim linea As String
        linea = sr.ReadLine
        Do While Not linea Is Nothing
            Dim categorias() As String = linea.Split(" ")
            If categorias(0) = txtCodigoProducto.Text Then
                MsgBox("El producto ya existe", MsgBoxStyle.Exclamation, "Información")
            End If
            linea = sr.ReadLine()
        Loop
        sr.Close()
    End Sub

    Private Sub CrearCarpetaArchivo()
        'Creacion de carpeta y archivo al abrir el form
        If Not Directory.Exists("C:\Programacion1") Then
            Directory.CreateDirectory("C:\Programacion1")
        End If

        If Not File.Exists("C:\Programacion1\Datos.txt") Then
            File.CreateText("C:\Programacion1\Datos.txt")
        End If
    End Sub
    Private Sub limpiar()
        txtCantidad.Clear()
        txtCodigoProducto.Clear()
        txtCodProveedor.Clear()
        txtNombre.Clear()
        txtPrecioUnitario.Clear()
        txtPrecioVenta.Clear()
        txtProveedor.Clear()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Form6.Show()
    End Sub
End Class