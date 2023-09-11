Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports HtmlAgilityPack

' ICONOS:
' Pack de iconos: Chinese zodiac flat 1 of 1 | Flat - https://www.flaticon.es/
' Licencia de Flaticon - Gratis para uso personal o comercial con atribución.
' Autor: https://www.flaticon.es/autores/freepik

Public Class frmHoroscopoChino
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If validaEntradaTextBox(txtAnno) Then
            MsgBox(calcularSignoChino(txtAnno.Text))
        Else
            MessageBox.Show("El TextBox no cumple con los criterios.")
        End If

    End Sub

    Function validaEntradaTextBox(ByVal txtBox As TextBox) As Boolean

        Dim annoInicial As Integer = 1900 ' Año inicial del rango
        Dim annoActual As DateTime = DateTime.Now
        Dim annoFinal As Integer = annoActual.Year   ' Año final del rango

        Dim valido As Boolean = False

        ' Verifica que el TextBox no esta vacio o es nulo:
        If Not String.IsNullOrEmpty(txtBox.Text) Then
            ' Regex para validar cuatro dígitos
            Dim regex As New Regex("^\d{4}$")

            ' Verifica si el texto coincide con la expresión regular
            If regex.IsMatch(txtBox.Text) Then
                ' El TextBox contiene 4 números

                ' Convertimos el contenido del TextBox a un valor numérico (año)
                Dim año As Integer
                If Integer.TryParse(txtBox.Text, año) Then
                    ' Verificamos si el año está dentro del rango especificado
                    If año >= annoInicial AndAlso año <= annoFinal Then
                        valido = True ' El TextBox contiene 4 números y está en el rango de años
                    End If
                End If
            End If
        End If

        Return valido ' El TextBox no cumple con los criterios

    End Function

    Public Shared Function calcularSignoChino(ByVal anno As String) As String

        Dim year As Integer = Integer.Parse(anno)
        Dim zodiac As String = ""

        If anno.Length = 4 Then

            Select Case (year - 4) Mod 12
                Case 0
                    zodiac = "rata"
                Case 1
                    zodiac = "buey"
                Case 2
                    zodiac = "tigre"
                Case 3
                    zodiac = "conejo"
                Case 4
                    zodiac = "dragon"
                Case 5
                    zodiac = "serpiente"
                Case 6
                    zodiac = "caballo"
                Case 7
                    zodiac = "cabra"
                Case 8
                    zodiac = "mono"
                Case 9
                    zodiac = "gallo"
                Case 10
                    zodiac = "perro"
                Case 11
                    zodiac = "cerdo"
            End Select

        End If

        Return zodiac
    End Function

    Private Sub btnMono_Click(sender As Object, e As EventArgs) Handles btnMono.Click
        TextBox1.Text = verSignoChino("mono")
    End Sub

    Private Sub btnRata_Click(sender As Object, e As EventArgs) Handles btnRata.Click
        TextBox1.Text = verSignoChino("rata")
    End Sub

    Private Sub btnTigre_Click(sender As Object, e As EventArgs) Handles btnTigre.Click
        TextBox1.Text = verSignoChino("tigre")
    End Sub

    Private Sub btnBuey_Click(sender As Object, e As EventArgs) Handles btnBuey.Click
        TextBox1.Text = verSignoChino("buey")
    End Sub

    Private Sub btnConejo_Click(sender As Object, e As EventArgs) Handles btnConejo.Click
        TextBox1.Text = verSignoChino("conejo")
    End Sub

    Private Sub btnDragon_Click(sender As Object, e As EventArgs) Handles btnDragon.Click
        TextBox1.Text = verSignoChino("dragon")
    End Sub

    Private Sub btnCaballo_Click(sender As Object, e As EventArgs) Handles btnCaballo.Click
        TextBox1.Text = verSignoChino("caballo")
    End Sub

    Private Sub btnSerpiente_Click(sender As Object, e As EventArgs) Handles btnSerpiente.Click
        TextBox1.Text = verSignoChino("serpiente")
    End Sub

    Private Sub btnCabra_Click(sender As Object, e As EventArgs) Handles btnCabra.Click
        TextBox1.Text = verSignoChino("cabra")
    End Sub

    Private Sub btnPerro_Click(sender As Object, e As EventArgs) Handles btnPerro.Click
        TextBox1.Text = verSignoChino("perro")
    End Sub

    Private Sub btnGallo_Click(sender As Object, e As EventArgs) Handles btnGallo.Click
        TextBox1.Text = verSignoChino("gallo")
    End Sub

    Private Sub btnCerdo_Click(sender As Object, e As EventArgs) Handles btnCerdo.Click
        TextBox1.Text = verSignoChino("cerdo")
    End Sub

    Public Shared Function verSignoChino(ByVal signoactual As String) As String

        ' Horoscopo Chino La Vanguardia Fuente:
        ' https://www.lavanguardia.com/horoscopo/horoscopo-chino/signo-mono

        ' 
        Dim url As String = "https://www.lavanguardia.com/horoscopo/horoscopo-chino/signo-" + signoactual
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)
        ' Se parsea la web con el xpath del elemento requerido
        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div"
        Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes(xpathExpression)
        ' Se recorren los nodos principales y se toma el primer nodo referido al elemento del xpath
        If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
            For Each node As HtmlNode In nodes
                Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            Console.WriteLine("No se encontro el Horoscopo")
        End If

        ' Se realizan operaciones para limpiar la salida.
        If resultado.Length >= 4 Then
            resultado = resultado.Substring(4)
        Else
            resultado = String.Empty
        End If

        resultado = resultado.Replace("            <p>", "") _
        .Replace("         ", "") _
        .Replace("</p>", "") _
        .Replace("<p>", "")

        Return resultado
    End Function

    Private Sub txtAnno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnno.KeyPress
        ' Verificar si la tecla presionada es un dígito numérico o una tecla de control
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un dígito numérico ni una tecla de control, deshabilitar la entrada
            e.Handled = True
        End If
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.HotPink, Color.Purple, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub
End Class