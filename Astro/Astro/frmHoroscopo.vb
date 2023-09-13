Imports System.Drawing.Drawing2D
Imports HtmlAgilityPack

' ICONOS:
' Pack de iconos: Horoscope | Flat - https://www.flaticon.es/
' Licencia de Flaticon - Gratis para uso personal o comercial con atribución.
' Autor: https://www.flaticon.es/autores/freepik

Public Class frmHoroscopo

    Public signoFinal As String
    Public signoHoroscopo As String

    Private Sub btnAries_Click(sender As Object, e As EventArgs) Handles btnAries.Click
        signoFinal = "aries"
        signoHoroscopo = verSignoDia("aries")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnTauro_Click(sender As Object, e As EventArgs) Handles btnTauro.Click
        signoFinal = "tauro"
        signoHoroscopo = verSignoDia("tauro")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnGeminis_Click(sender As Object, e As EventArgs) Handles btnGeminis.Click
        signoFinal = "geminis"
        signoHoroscopo = verSignoDia("geminis")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCancer_Click(sender As Object, e As EventArgs) Handles btnCancer.Click
        signoFinal = "cancer"
        signoHoroscopo = verSignoDia("cancer")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnEscorpio_Click(sender As Object, e As EventArgs) Handles btnEscorpio.Click
        signoFinal = "escorpio"
        signoHoroscopo = verSignoDia("escorpio")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnLibra_Click(sender As Object, e As EventArgs) Handles btnLibra.Click
        signoFinal = "libra"
        signoHoroscopo = verSignoDia("libra")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnVirgo_Click(sender As Object, e As EventArgs) Handles btnVirgo.Click
        signoFinal = "virgo"
        signoHoroscopo = verSignoDia("virgo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnLeo_Click(sender As Object, e As EventArgs) Handles btnLeo.Click
        signoFinal = "leo"
        signoHoroscopo = verSignoDia("leo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnSagitario_Click(sender As Object, e As EventArgs) Handles btnSagitario.Click
        signoFinal = "sagitario"
        signoHoroscopo = verSignoDia("sagitario")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCapricornio_Click(sender As Object, e As EventArgs) Handles btnCapricornio.Click
        signoFinal = "capricornio"
        signoHoroscopo = verSignoDia("capricornio")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnAcuario_Click(sender As Object, e As EventArgs) Handles btnAcuario.Click
        signoFinal = "acuario"
        signoHoroscopo = verSignoDia("acuario")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnPiscis_Click(sender As Object, e As EventArgs) Handles btnPiscis.Click
        signoFinal = "piscis"
        signoHoroscopo = verSignoDia("piscis")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
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