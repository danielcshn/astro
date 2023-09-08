Imports System.Drawing.Drawing2D
Imports HtmlAgilityPack

Public Class frmHoroscopoChino
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        MsgBox(calcularSignoChino(txtAnno.Text))
    End Sub

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

        ' Horoscopo Diario Fuente:
        ' https://www.lavanguardia.com/horoscopo/horoscopo-chino/signo-mono

        Dim url As String = "https://www.lavanguardia.com/horoscopo/horoscopo-chino/signo-" + signoactual
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)

        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div"
        Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes(xpathExpression)

        If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
            For Each node As HtmlNode In nodes
                Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            Console.WriteLine("No matching nodes found.")
        End If

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