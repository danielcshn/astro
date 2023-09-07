Imports HtmlAgilityPack

Public Class frmHoroscopo
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = verSignoDia("aries")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = verSignoDia("tauro")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = verSignoDia("geminis")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = verSignoDia("cancer")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = verSignoDia("escorpio")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = verSignoDia("libra")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = verSignoDia("virgo")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = verSignoDia("leo")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = verSignoDia("sagitario")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = verSignoDia("capricornio")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = verSignoDia("acuario")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
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
End Class