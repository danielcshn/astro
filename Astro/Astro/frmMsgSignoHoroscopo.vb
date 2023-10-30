Imports System.Drawing.Drawing2D

''' <summary>
''' MsgBox personalizado para mostrar el resultado del Signo Horoscopo del Zodiaco.
''' </summary>

Public Class frmMsgSignoHoroscopo

    Public Sub New(ByVal pTipo As String)
        InitializeComponent()
        lblSignoChino.Text = StrConv(pTipo, VbStrConv.ProperCase)

        Select Case pTipo
            Case "Aries"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("aries-pro_100.png")
            Case "Tauro"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("tauro-pro_100.png")
            Case "Géminis"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("geminis-pro_100.png")
            Case "Cáncer"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("cancer-pro_100.png")
            Case "Leo"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("leon-pro_100.png")
            Case "Virgo"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("virgo-pro_100.png")
            Case "Libra"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("libra-pro_100.png")
            Case "Escorpio"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("escorpion-pro_100.png")
            Case "Sagitario"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("sagitario-pro_100.png")
            Case "Capricornio"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("capricornio-pro_100.png")
            Case "Acuario"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("acuario-pro_100.png")
            Case "Piscis"
                pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("piscis-pro_100.png")
            Case Else
                'pbSignoHoroscopo.Image = ilSignosHoroscopo.Images("name-pro_100.png")
        End Select
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        ' Create a LinearGradientBrush for the gradient background.
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.DarkCyan, Color.DarkCyan, LinearGradientMode.Vertical)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    Private Sub bgPanel_Click(sender As Object, e As EventArgs) Handles bgPanel.Click, pbSignoHoroscopo.Click, lblSignoChino.Click, Label1.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub frmMsgSignoChino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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