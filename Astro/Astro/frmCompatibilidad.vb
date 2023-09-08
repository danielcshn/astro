Imports System.Drawing.Drawing2D
Imports HtmlAgilityPack

Public Class frmCompatibilidad

    Public pBox1 As String
    Public pBox2 As String

    Private Sub setSigno(signo As String)

        ' Verificar si PictureBox1 y PictureBox2 tienen imágenes
        If PictureBox1.Image IsNot Nothing AndAlso PictureBox2.Image IsNot Nothing Then
            ' Ambos PictureBox tienen imágenes cargadas, puedes manejarlo como desees
            ' Por ejemplo, puedes reemplazar la imagen de PictureBox2 con la nueva imagen, o hacer otra acción.
            PictureBox1.Image = Nothing ' Esto quita la imagen del PictureBox1
            PictureBox2.Image = Nothing ' Esto quita la imagen del PictureBox1
        End If

        ' busca la imagen en el ImageList1
        If ImageList1.Images.ContainsKey(signo) Then

            ' si picturebox1 tiene imagen
            If PictureBox1.Image IsNot Nothing Then
                PictureBox2.Image = ImageList1.Images(signo)
                pBox2 = signo
            Else
                PictureBox1.Image = ImageList1.Images(signo)
                pBox1 = signo
            End If

        End If

    End Sub

    Private Sub lklAries_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAries.LinkClicked
        setSigno("ico-aries.png")
    End Sub

    Private Sub lklCancer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCancer.LinkClicked
        setSigno("ico-cancer.png")
    End Sub

    Private Sub lklTauro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklTauro.LinkClicked
        setSigno("ico-tauro.png")
    End Sub

    Private Sub lklGeminis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklGeminis.LinkClicked
        setSigno("ico-geminis.png")
    End Sub

    Private Sub lklLeo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklLeo.LinkClicked
        setSigno("ico-leo.png")
    End Sub

    Private Sub lklVirgo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklVirgo.LinkClicked
        setSigno("ico-virgo.png")
    End Sub

    Private Sub lklLibra_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklLibra.LinkClicked
        setSigno("ico-libra.png")
    End Sub

    Private Sub lklEscorpio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklEscorpio.LinkClicked
        setSigno("ico-escorpio.png")
    End Sub

    Private Sub lklSagitario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklSagitario.LinkClicked
        setSigno("ico-sagitario.png")
    End Sub

    Private Sub lklCapricornio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCapricornio.LinkClicked
        setSigno("ico-capricornio.png")
    End Sub

    Private Sub lklAcuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAcuario.LinkClicked
        setSigno("ico-acuario.png")
    End Sub

    Private Sub lklPiscis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklPiscis.LinkClicked
        setSigno("ico-piscis.png")
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        MsgBox(verCompatibilidad(pBox1, pBox2))
    End Sub

    Public Shared Function verCompatibilidad(ByVal spbox1 As String, ByVal spbox2 As String) As String

        ' Horoscopo Diario Fuente:
        ' https://www.lavanguardia.com/horoscopo/compatibilidad-signos-zodiaco/

        spbox1 = spbox1.Replace("ico-", "").Replace(".png", "")
        spbox2 = spbox2.Replace("ico-", "").Replace(".png", "")

        Dim url As String = "https://www.lavanguardia.com/horoscopo/compatibilidad-signos-zodiaco/" + spbox1 + "-" + spbox2
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)

        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div[2]"
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

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.MediumPurple, Color.Purple, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub
End Class