Imports System.Drawing.Drawing2D
Imports HtmlAgilityPack

Public Class frmHoroscopo
    Private Sub btnAries_Click(sender As Object, e As EventArgs) Handles btnAries.Click
        TextBox1.Text = verSignoDia("aries")
    End Sub

    Private Sub btnTauro_Click(sender As Object, e As EventArgs) Handles btnTauro.Click
        TextBox1.Text = verSignoDia("tauro")
    End Sub

    Private Sub btnGeminis_Click(sender As Object, e As EventArgs) Handles btnGeminis.Click
        TextBox1.Text = verSignoDia("geminis")
    End Sub

    Private Sub btnCancer_Click(sender As Object, e As EventArgs) Handles btnCancer.Click
        TextBox1.Text = verSignoDia("cancer")
    End Sub

    Private Sub btnEscorpio_Click(sender As Object, e As EventArgs) Handles btnEscorpio.Click
        TextBox1.Text = verSignoDia("escorpio")
    End Sub

    Private Sub btnLibra_Click(sender As Object, e As EventArgs) Handles btnLibra.Click
        TextBox1.Text = verSignoDia("libra")
    End Sub

    Private Sub btnVirgo_Click(sender As Object, e As EventArgs) Handles btnVirgo.Click
        TextBox1.Text = verSignoDia("virgo")
    End Sub

    Private Sub btnLeo_Click(sender As Object, e As EventArgs) Handles btnLeo.Click
        TextBox1.Text = verSignoDia("leo")
    End Sub

    Private Sub btnSagitario_Click(sender As Object, e As EventArgs) Handles btnSagitario.Click
        TextBox1.Text = verSignoDia("sagitario")
    End Sub

    Private Sub btnCapricornio_Click(sender As Object, e As EventArgs) Handles btnCapricornio.Click
        TextBox1.Text = verSignoDia("capricornio")
    End Sub

    Private Sub btnAcuario_Click(sender As Object, e As EventArgs) Handles btnAcuario.Click
        TextBox1.Text = verSignoDia("acuario")
    End Sub

    Private Sub btnPiscis_Click(sender As Object, e As EventArgs) Handles btnPiscis.Click
        TextBox1.Text = verSignoDia("piscis")
    End Sub

    Public Shared Function verSignoDia(ByVal signoactual As String) As String

        ' Horoscopo Diario Fuente:
        ' https://www.lavanguardia.com/horoscopo/signos-zodiaco-cancer/horoscopo-diario

        Dim url As String = "https://www.lavanguardia.com/horoscopo/signos-zodiaco-" + signoactual + "/horoscopo-diario"
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)

        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div/p"
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

        Return resultado
    End Function

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.Cyan, Color.DarkCyan, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub
End Class