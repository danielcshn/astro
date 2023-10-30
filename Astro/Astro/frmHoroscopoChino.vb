Imports System.Drawing.Drawing2D

' ICONOS:
' Pack de iconos: Chinese zodiac flat 1 of 1 | Flat - https://www.flaticon.es/
' Licencia de Flaticon - Gratis para uso personal o comercial con atribución.
' Autor: https://www.flaticon.es/autores/freepik

''' <summary>
''' Formulario de Horoscopo Chino.
''' </summary>

Public Class frmHoroscopoChino

    Public signoFinal As String
    Public signoHoroscopo As String

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If Acciones.validaEntradaTextBox(txtAnno) Then
            'MsgBox(calcularSignoChino(txtAnno.Text))
            Dim signoFinal As String = Acciones.calcularSignoChino(txtAnno.Text)
            Dim m As frmMsgSignoChino = New frmMsgSignoChino(signoFinal)
            Dim dg As DialogResult = m.ShowDialog()
        Else
            MessageBox.Show("Debe ingresar un año valido, compuesto por 4 digitos y entre " & 1900 & "-" & DateTime.Now.Year.ToString, "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnMono_Click(sender As Object, e As EventArgs) Handles btnMono.Click
        signoFinal = "mono"
        signoHoroscopo = Acciones.verSignoChino("mono")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnRata_Click(sender As Object, e As EventArgs) Handles btnRata.Click
        signoFinal = "rata"
        signoHoroscopo = Acciones.verSignoChino("rata")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnTigre_Click(sender As Object, e As EventArgs) Handles btnTigre.Click
        signoFinal = "tigre"
        signoHoroscopo = Acciones.verSignoChino("tigre")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnBuey_Click(sender As Object, e As EventArgs) Handles btnBuey.Click
        signoFinal = "buey"
        signoHoroscopo = Acciones.verSignoChino("buey")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnConejo_Click(sender As Object, e As EventArgs) Handles btnConejo.Click
        signoFinal = "conejo"
        signoHoroscopo = Acciones.verSignoChino("conejo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnDragon_Click(sender As Object, e As EventArgs) Handles btnDragon.Click
        signoFinal = "dragon"
        signoHoroscopo = Acciones.verSignoChino("dragon")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCaballo_Click(sender As Object, e As EventArgs) Handles btnCaballo.Click
        signoFinal = "caballo"
        signoHoroscopo = Acciones.verSignoChino("caballo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnSerpiente_Click(sender As Object, e As EventArgs) Handles btnSerpiente.Click
        signoFinal = "serpiente"
        signoHoroscopo = Acciones.verSignoChino("serpiente")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCabra_Click(sender As Object, e As EventArgs) Handles btnCabra.Click
        signoFinal = "cabra"
        signoHoroscopo = Acciones.verSignoChino("cabra")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnPerro_Click(sender As Object, e As EventArgs) Handles btnPerro.Click
        signoFinal = "perro"
        signoHoroscopo = Acciones.verSignoChino("perro")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnGallo_Click(sender As Object, e As EventArgs) Handles btnGallo.Click
        signoFinal = "gallo"
        signoHoroscopo = Acciones.verSignoChino("gallo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub btnCerdo_Click(sender As Object, e As EventArgs) Handles btnCerdo.Click
        signoFinal = "cerdo"
        signoHoroscopo = Acciones.verSignoChino("cerdo")
        Dim m As frmMsgResultadoHoroscopo = New frmMsgResultadoHoroscopo(signoFinal, signoHoroscopo)
        Dim dg As DialogResult = m.ShowDialog()
    End Sub

    Private Sub txtAnno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnno.KeyPress
        ' Verificar si la tecla presionada es un dígito numérico o una tecla de control
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un dígito numérico ni una tecla de control, deshabilitar la entrada
            e.Handled = True
        End If
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Crea un LinearGradientBrush para el fondo degradado.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.HotPink, Color.Purple, LinearGradientMode.ForwardDiagonal)

        ' Llene el PictureBox con el fondo degradado.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub
End Class