Imports System.Drawing.Drawing2D

''' <summary>
''' MsgBox personalizado para mostrar el resultado del Signo Horoscopo Chino.
''' </summary>

Public Class frmMsgSignoChino

    Public Sub New(ByVal pTipo As String)
        InitializeComponent()
        lblSignoChino.Text = StrConv(pTipo, VbStrConv.ProperCase)

        Select Case pTipo
            Case "rata"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "tigre"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "buey"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "conejo"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "dragon"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "caballo"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "serpiente"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "cabra"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "mono"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "perro"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "gallo"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case "cerdo"
                pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
            Case Else
                'pbSignoChino.Image = ilSignosChino.Images(pTipo & "-pro_100.png")
        End Select
    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.DarkRed, Color.Indigo, LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    Private Sub bgPanel_Click(sender As Object, e As EventArgs) Handles bgPanel.Click, pbSignoChino.Click, lblSignoChino.Click, Label1.Click
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