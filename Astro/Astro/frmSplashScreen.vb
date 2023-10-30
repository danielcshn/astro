Imports System.Drawing.Drawing2D

''' <summary>
''' Formulario de SplashScreen o Pantalla de Inicio.
''' </summary>

Public NotInheritable Class frmSplashScreen

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ' FUENTE
    ' https://fontmeme.com/es/fuente-de-disneyland-park/

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.MediumPurple, Color.Cyan, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub
End Class
