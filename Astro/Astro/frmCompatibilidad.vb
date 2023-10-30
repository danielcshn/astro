Imports System.Drawing.Drawing2D

''' <summary>
''' Formulario de Compatibilidad entre Signos del Zodiaco.
''' </summary>

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

                ' Debug:
                ' Console.WriteLine(pBox1)
                ' Console.WriteLine(pBox2)

                ' Console.WriteLine(VerificarCompatibilidad(pBox1, pBox2))

                ' Base: https://www.clara.es/horoscopo/test-signo-pareja-ideal_11763
                pbComp.Image = ImageList2.Images(Acciones.VerificarCompatibilidad(pBox1, pBox2))
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
        setSigno("escorpio-pro_256.png", btnVer)
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

        Dim compatibilidadFinal As String
        compatibilidadFinal = Acciones.verCompatibilidad(pBox1, pBox2)
        Dim m As frmMsgCompatibilidad = New frmMsgCompatibilidad(compatibilidadFinal)
        Dim dg As DialogResult = m.ShowDialog()

    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.MediumPurple, Color.Purple, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

End Class