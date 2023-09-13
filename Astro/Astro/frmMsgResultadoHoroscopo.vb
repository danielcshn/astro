Imports System.Drawing.Drawing2D

Public Class frmMsgResultadoHoroscopo

    Public Sub New(ByVal signo As String, ByVal horoscopo As String)
        InitializeComponent()
        lblSigno.Text = StrConv(signo, VbStrConv.ProperCase)
        txtHoroscopo.Text = horoscopo

        Select Case signo
            Case "rata"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "tigre"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "buey"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "conejo"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "dragon"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "caballo"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "serpiente"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "cabra"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "mono"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "perro"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "gallo"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "cerdo"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "aries"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "tauro"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "geminis"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "cancer"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "escorpio"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "libra"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "virgo"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "leo"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "sagitario"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "capricornio"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "acuario"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case "piscis"
                pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
            Case Else
                'pbSigno.Image = ilSignos.Images(signo & "-pro_100.png")
        End Select

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.Indigo, Color.Purple, LinearGradientMode.Vertical)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    Private Sub frmMsgResultadoHoroscopo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class