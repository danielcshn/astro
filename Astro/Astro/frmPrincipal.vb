Imports System.Drawing.Drawing2D

''' <summary>
''' Formulario Principal.
''' </summary>

Public Class frmPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmHoroscopo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmCompatibilidad.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmHoroscopoChino.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmNumerologia.Show()
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.Cyan, Color.MediumPurple, LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    '    Consideraciones
    '    **Consultar al usuario si desea realizar otra consulta antes de abandonar la aplicación.

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Deseas realizar otra consulta antes de abandonar la aplicación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True ' Evita que la aplicación se cierre
        Else
            ' Si el usuario elige "Sí", puedes realizar acciones adicionales o simplemente permitir que la aplicación continúe
        End If
    End Sub
End Class
