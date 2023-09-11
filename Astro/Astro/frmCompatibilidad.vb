Imports System.Drawing.Drawing2D
Imports HtmlAgilityPack

Public Class frmCompatibilidad

    Public pBox1 As String
    Public pBox2 As String

    Private Sub setSigno(signo As String, ByVal botonVer As Button)

        botonVer.Visible = False

        ' Verificar si PictureBox1 y PictureBox2 tienen imágenes
        If PictureBox1.Image IsNot Nothing AndAlso PictureBox2.Image IsNot Nothing Then
            ' Ambos PictureBox tienen imágenes cargadas, puedes manejarlo como desees
            ' Por ejemplo, puedes reemplazar la imagen de PictureBox2 con la nueva imagen, o hacer otra acción.
            PictureBox1.Image = Nothing ' Esto quita la imagen del PictureBox1
            PictureBox2.Image = Nothing ' Esto quita la imagen del PictureBox1
            botonVer.Visible = False ' oculto el boton de compatibilidad
        End If

        ' busca la imagen en el ImageList1
        If ImageList1.Images.ContainsKey(signo) Then

            ' si picturebox1 tiene imagen
            If PictureBox1.Image IsNot Nothing Then
                PictureBox2.Image = ImageList1.Images(signo)
                pBox2 = signo
                botonVer.Visible = True


                Console.WriteLine(pBox1)
                Console.WriteLine(pBox2)

                Console.WriteLine(VerificarCompatibilidad(pBox1, pBox2))

                ' Base: https://www.clara.es/horoscopo/test-signo-pareja-ideal_11763
                pbComp.Image = ImageList2.Images(VerificarCompatibilidad(pBox1, pBox2))
            Else
                PictureBox1.Image = ImageList1.Images(signo)
                pBox1 = signo
                botonVer.Visible = False
            End If

        End If

    End Sub

    Private Sub lklAries_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAries.LinkClicked
        setSigno("aries-pro_256.png", btnVer)
    End Sub

    Private Sub lklCancer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCancer.LinkClicked
        setSigno("cancer-pro_256.png", btnVer)
    End Sub

    Private Sub lklTauro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklTauro.LinkClicked
        setSigno("tauro-pro_256.png", btnVer)
    End Sub

    Private Sub lklGeminis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklGeminis.LinkClicked
        setSigno("geminis-pro_256.png", btnVer)
    End Sub

    Private Sub lklLeo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklLeo.LinkClicked
        setSigno("leo-pro_256.png", btnVer)
    End Sub

    Private Sub lklVirgo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklVirgo.LinkClicked
        setSigno("virgo-pro_256.png", btnVer)
    End Sub

    Private Sub lklLibra_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklLibra.LinkClicked
        setSigno("libra-pro_256.png", btnVer)
    End Sub

    Private Sub lklEscorpio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklEscorpio.LinkClicked
        setSigno("escorpion-pro_256.png", btnVer)
    End Sub

    Private Sub lklSagitario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklSagitario.LinkClicked
        setSigno("sagitario-pro_256.png", btnVer)
    End Sub

    Private Sub lklCapricornio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCapricornio.LinkClicked
        setSigno("capricornio-pro_256.png", btnVer)
    End Sub

    Private Sub lklAcuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAcuario.LinkClicked
        setSigno("acuario-pro_256.png", btnVer)
    End Sub

    Private Sub lklPiscis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklPiscis.LinkClicked
        setSigno("piscis-pro_256.png", btnVer)
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        MsgBox(verCompatibilidad(pBox1, pBox2))
    End Sub

    Public Shared Function verCompatibilidad(ByVal spbox1 As String, ByVal spbox2 As String) As String

        ' Horoscopo Diario Fuente:
        ' https://www.lavanguardia.com/horoscopo/compatibilidad-signos-zodiaco/

        spbox1 = spbox1.Replace("-pro_256", "").Replace(".png", "")
        spbox2 = spbox2.Replace("-pro_256", "").Replace(".png", "")

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



    ' Función para verificar la compatibilidad
    Function VerificarCompatibilidad(signo1 As String, signo2 As String) As String

        signo1 = signo1.Replace("-pro_256.png", "")
        signo2 = signo2.Replace("-pro_256.png", "")

        If CompatibilidadSignos.ContainsKey(signo1) AndAlso CompatibilidadSignos(signo1).ContainsKey(signo2) Then
            Return CompatibilidadSignos(signo1)(signo2)
        Else
            Return "No se encuentra información de compatibilidad."
        End If
    End Function

    ' Definir una lista de compatibilidad de signos
    Private ReadOnly CompatibilidadSignos As New Dictionary(Of String, Dictionary(Of String, String)) From {
        {"aries", New Dictionary(Of String, String) From {
            {"aries", "corazon_64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "x-64.png"},
            {"leo", "corazon_64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "x-64.png"},
            {"escorpion", "neutral-64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "x-64.png"},
            {"acuario", "corazon_64.png"},
            {"piscis", "x-64.png"}
        }},
        {"tauro", New Dictionary(Of String, String) From {
            {"aries", "60%"},
            {"tauro", "100%"},
            {"geminis", "50%"},
            {"cancer", "70%"},
            {"leo", "80%"},
            {"virgo", "90%"},
            {"libra", "40%"},
            {"escorpion", "60%"},
            {"sagitario", "70%"},
            {"capricornio", "80%"},
            {"acuario", "80%"},
            {"piscis", "90%"}
        }},
        {"geminis", New Dictionary(Of String, String) From {
            {"aries", "70%"},
            {"tauro", "50%"},
            {"geminis", "100%"},
            {"cancer", "60%"},
            {"leo", "70%"},
            {"virgo", "80%"},
            {"libra", "90%"},
            {"escorpion", "40%"},
            {"sagitario", "60%"},
            {"capricornio", "70%"},
            {"acuario", "80%"},
            {"piscis", "90%"}
        }},
        {"cancer", New Dictionary(Of String, String) From {
            {"aries", "80%"},
            {"tauro", "70%"},
            {"geminis", "60%"},
            {"cancer", "100%"},
            {"leo", "50%"},
            {"virgo", "60%"},
            {"libra", "70%"},
            {"escorpion", "90%"},
            {"sagitario", "40%"},
            {"capricornio", "60%"},
            {"acuario", "70%"},
            {"piscis", "80%"}
        }},
        {"leo", New Dictionary(Of String, String) From {
            {"aries", "90%"},
            {"tauro", "80%"},
            {"geminis", "70%"},
            {"cancer", "50%"},
            {"leo", "100%"},
            {"virgo", "40%"},
            {"libra", "60%"},
            {"escorpion", "80%"},
            {"sagitario", "90%"},
            {"capricornio", "50%"},
            {"acuario", "70%"},
            {"piscis", "80%"}
        }},
        {"virgo", New Dictionary(Of String, String) From {
            {"aries", "40%"},
            {"tauro", "90%"},
            {"geminis", "80%"},
            {"cancer", "60%"},
            {"leo", "40%"},
            {"virgo", "100%"},
            {"libra", "50%"},
            {"escorpion", "70%"},
            {"sagitario", "80%"},
            {"capricornio", "90%"},
            {"acuario", "60%"},
            {"piscis", "70%"}
        }},
        {"libra", New Dictionary(Of String, String) From {
            {"aries", "60%"},
            {"tauro", "40%"},
            {"geminis", "90%"},
            {"cancer", "70%"},
            {"leo", "60%"},
            {"virgo", "50%"},
            {"libra", "100%"},
            {"escorpion", "40%"},
            {"sagitario", "60%"},
            {"capricornio", "70%"},
            {"acuario", "90%"},
            {"piscis", "80%"}
        }},
        {"escorpio", New Dictionary(Of String, String) From {
            {"aries", "80%"},
            {"tauro", "60%"},
            {"geminis", "40%"},
            {"cancer", "90%"},
            {"leo", "80%"},
            {"virgo", "70%"},
            {"libra", "40%"},
            {"escorpion", "100%"},
            {"sagitario", "50%"},
            {"capricornio", "60%"},
            {"acuario", "70%"},
            {"piscis", "90%"}
        }},
        {"sagitario", New Dictionary(Of String, String) From {
            {"aries", "90%"},
            {"tauro", "70%"},
            {"geminis", "60%"},
            {"cancer", "40%"},
            {"leo", "90%"},
            {"virgo", "80%"},
            {"libra", "60%"},
            {"escorpion", "50%"},
            {"sagitario", "100%"},
            {"capricornio", "40%"},
            {"acuario", "60%"},
            {"piscis", "70%"}
        }},
        {"capricornio", New Dictionary(Of String, String) From {
            {"aries", "50%"},
            {"tauro", "80%"},
            {"geminis", "70%"},
            {"cancer", "60%"},
            {"leo", "50%"},
            {"virgo", "90%"},
            {"libra", "70%"},
            {"escorpion", "60%"},
            {"sagitario", "40%"},
            {"capricornio", "100%"},
            {"acuario", "50%"},
            {"piscis", "60%"}
        }},
        {"acuario", New Dictionary(Of String, String) From {
            {"aries", "70%"},
            {"tauro", "80%"},
            {"geminis", "80%"},
            {"cancer", "70%"},
            {"leo", "70%"},
            {"virgo", "60%"},
            {"libra", "90%"},
            {"escorpion", "70%"},
            {"sagitario", "60%"},
            {"capricornio", "50%"},
            {"acuario", "100%"},
            {"piscis", "50%"}
        }},
        {"piscis", New Dictionary(Of String, String) From {
            {"aries", "80%"},
            {"tauro", "90%"},
            {"geminis", "90%"},
            {"cancer", "80%"},
            {"leo", "80%"},
            {"virgo", "70%"},
            {"libra", "80%"},
            {"escorpion", "90%"},
            {"sagitario", "70%"},
            {"capricornio", "60%"},
            {"acuario", "50%"},
            {"piscis", "100%"}
        }}
    }

End Class