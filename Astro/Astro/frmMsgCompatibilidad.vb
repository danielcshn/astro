Imports System.Drawing.Drawing2D

Public Class frmMsgCompatibilidad

    Public Sub New(ByVal horoscopo As String)
        InitializeComponent()

        txtHoroscopo.Text = horoscopo

        PictureBox1.Image = frmCompatibilidad.PictureBox1.Image
        PictureBox2.Image = frmCompatibilidad.PictureBox2.Image
        pbComp.Image = frmCompatibilidad.pbComp.Image

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.Purple, Color.MediumPurple, LinearGradientMode.Vertical)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    Private Sub frmMsgCompatibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crea un objeto GraphicsPath para definir la forma del borde redondeado
        Dim path As New GraphicsPath()

        ' Define un rectángulo que representa el formulario
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        ' Agrega un borde redondeado al objeto GraphicsPath
        path.AddArc(rect.Left, rect.Top, 20, 20, 180, 90)  ' Esquina superior izquierda
        path.AddArc(rect.Right - 20, rect.Top, 20, 20, 270, 90)  ' Esquina superior derecha
        path.AddArc(rect.Right - 20, rect.Bottom - 20, 20, 20, 0, 90)  ' Esquina inferior derecha
        path.AddArc(rect.Left, rect.Bottom - 20, 20, 20, 90, 90)  ' Esquina inferior izquierda

        ' Cierra el borde redondeado
        path.CloseFigure()

        ' Asigna el objeto GraphicsPath a la propiedad Region del formulario
        Me.Region = New Region(path)
    End Sub

    Private Sub lklCopiar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCopiar.LinkClicked

        Clipboard.SetText("Compatibilidad: " & vbCrLf & txtHoroscopo.Text)
        lklCopiar.Text = "COPIADO"
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lklCopiar.Text = "COPIAR"
        Timer1.Stop()
    End Sub
End Class