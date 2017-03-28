Imports System
Imports System.IO
Imports System.Environment

Module EscribirCars
    Public Sub Main()
        Dim sw As StreamWriter
        Dim str As String

        Try
            ' Crear un flujo hacia el fichero doc.txt
            sw = New StreamWriter("doc.txt")

            Console.WriteLine(
              "Escriba las líneas de texto a almacenar en el fichero." _
              + NewLine + "Finalice cada línea pulsando la tecla " _
              + "<Entrar>." + NewLine + "Para finalizar pulse sólo " _
              + "la tecla <Entrar>." + NewLine)
            ' Leer una línea de la entrada estándar
            str = Console.ReadLine()
            While (str.Length <> 0)
                ' Escribir la línea leída en el fichero
                sw.WriteLine(str)
                ' Leer la línea siguiente
                str = Console.ReadLine()
            End While
        Catch e As IOException
            Console.WriteLine("Error: " + e.Message)
        Finally
            If (Not sw Is Nothing) Then sw.Close()
        End Try
    End Sub
End Module
