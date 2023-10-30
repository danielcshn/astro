Imports System.Drawing.Drawing2D

' ICONOS:
' Pack de iconos: Horoscope | Flat - https://www.flaticon.es/
' Licencia de Flaticon - Gratis para uso personal o comercial con atribución.
' Autor: https://www.flaticon.es/autores/freepik

''' <summary>
''' Formulario de Horoscopo de Signos del Zodiaco.
''' </summary>

Public Class frmHoroscopo

    Public signoFinal As String
    Public signoHoroscopo As String

    Private Sub btnAries_Click(sender As Object, e As EventArgs) Handles btnAries.Click
        signoFinal = "aries"
        signoHoroscopo = Acciones.verSignoDia("aries")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnTauro_Click(sender As Object, e As EventArgs) Handles btnTauro.Click
        signoFinal = "tauro"
        signoHoroscopo = Acciones.verSignoDia("tauro")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnGeminis_Click(sender As Object, e As EventArgs) Handles btnGeminis.Click
        signoFinal = "geminis"
        signoHoroscopo = Acciones.verSignoDia("geminis")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCancer_Click(sender As Object, e As EventArgs) Handles btnCancer.Click
        signoFinal = "cancer"
        signoHoroscopo = Acciones.verSignoDia("cancer")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnEscorpio_Click(sender As Object, e As EventArgs) Handles btnEscorpio.Click
        signoFinal = "escorpio"
        signoHoroscopo = Acciones.verSignoDia("escorpio")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnLibra_Click(sender As Object, e As EventArgs) Handles btnLibra.Click
        signoFinal = "libra"
        signoHoroscopo = Acciones.verSignoDia("libra")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnVirgo_Click(sender As Object, e As EventArgs) Handles btnVirgo.Click
        signoFinal = "virgo"
        signoHoroscopo = Acciones.verSignoDia("virgo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnLeo_Click(sender As Object, e As EventArgs) Handles btnLeo.Click
        signoFinal = "leo"
        signoHoroscopo = Acciones.verSignoDia("leo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnSagitario_Click(sender As Object, e As EventArgs) Handles btnSagitario.Click
        signoFinal = "sagitario"
        signoHoroscopo = Acciones.verSignoDia("sagitario")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCapricornio_Click(sender As Object, e As EventArgs) Handles btnCapricornio.Click
        signoFinal = "capricornio"
        signoHoroscopo = Acciones.verSignoDia("capricornio")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnAcuario_Click(sender As Object, e As EventArgs) Handles btnAcuario.Click
        signoFinal = "acuario"
        signoHoroscopo = Acciones.verSignoDia("acuario")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnPiscis_Click(sender As Object, e As EventArgs) Handles btnPiscis.Click
        signoFinal = "piscis"
        signoHoroscopo = Acciones.verSignoDia("piscis")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.DarkCyan, Color.Cyan, LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    ' Consideraciones
    ' **Trabajar con fechas de manera tal que el usuario pueda ingresar su fecha de nacimiento y el sistema le indicará cual es su signo.

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fechaSeleccionada As DateTime = DateTimePicker1.Value
        Dim signo As String = Acciones.ObtenerSignoZodiaco(fechaSeleccionada)
        'MessageBox.Show("El signo del zodiaco es: " & signo)

        Dim m As frmMsgSignoHoroscopo = New frmMsgSignoHoroscopo(signo)
        Dim dg As DialogResult = m.ShowDialog()

    End Sub

End Class