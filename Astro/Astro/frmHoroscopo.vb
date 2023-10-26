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
                ' Debug:
                'Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            ' Debug:
            'Console.WriteLine("No se encontro el Horoscopo")
            resultado = "No se encontro el Horoscopo"
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
        Dim gradientBrush As New LinearGradientBrush(rect, Color.DarkCyan, Color.Cyan, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    ' Consideraciones
    ' **Trabajar con fechas de manera tal que el usuario pueda ingresar su fecha de nacimiento y el sistema le indicará cual es su signo.

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fechaSeleccionada As DateTime = DateTimePicker1.Value
        Dim signo As String = ObtenerSignoZodiaco(fechaSeleccionada)
        'MessageBox.Show("El signo del zodiaco es: " & signo)

        Dim m As frmMsgSignoHoroscopo = New frmMsgSignoHoroscopo(signo)
        Dim dg As DialogResult = m.ShowDialog()

    End Sub

    Function ObtenerSignoZodiaco(fecha As DateTime) As String
        Dim mes As Integer = fecha.Month
        Dim dia As Integer = fecha.Day
        Dim signo As String = ""

        Select Case mes
            Case 1
                If dia <= 19 Then
                    signo = "Capricornio"
                Else
                    signo = "Acuario"
                End If
            Case 2
                If dia <= 18 Then
                    signo = "Acuario"
                Else
                    signo = "Piscis"
                End If
            Case 3
                If dia <= 20 Then
                    signo = "Piscis"
                Else
                    signo = "Aries"
                End If
            Case 4
                If dia <= 19 Then
                    signo = "Aries"
                Else
                    signo = "Tauro"
                End If
            Case 5
                If dia <= 20 Then
                    signo = "Tauro"
                Else
                    signo = "Géminis"
                End If
            Case 6
                If dia <= 20 Then
                    signo = "Géminis"
                Else
                    signo = "Cáncer"
                End If
            Case 7
                If dia <= 22 Then
                    signo = "Cáncer"
                Else
                    signo = "Leo"
                End If
            Case 8
                If dia <= 22 Then
                    signo = "Leo"
                Else
                    signo = "Virgo"
                End If
            Case 9
                If dia <= 22 Then
                    signo = "Virgo"
                Else
                    signo = "Libra"
                End If
            Case 10
                If dia <= 22 Then
                    signo = "Libra"
                Else
                    signo = "Escorpio"
                End If
            Case 11
                If dia <= 21 Then
                    signo = "Escorpio"
                Else
                    signo = "Sagitario"
                End If
            Case 12
                If dia <= 21 Then
                    signo = "Sagitario"
                Else
                    signo = "Capricornio"
                End If
        End Select

        Return signo
    End Function
End Class