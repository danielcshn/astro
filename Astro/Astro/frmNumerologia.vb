Imports System.Drawing.Drawing2D

''' <summary>
''' Formulario de Numerologia.
''' </summary>

Public Class frmNumerologia

    ' Referencia como sacar numero
    ' https://www.clarin.com/internacional/-saber-mision-vida-numerologia-_0_uB4yBKSXxr.html

    Private Sub frmNumerologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Inicial
        ' 586; 244
        Me.Width = 586
        Me.Height = 244

        ' Calcula la nueva posición para centrar el formulario en la pantalla.
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Dim newLeft As Integer = (screenWidth - Me.Width) \ 2
        Dim newTop As Integer = (screenHeight - Me.Height) \ 2

        ' Establece la nueva posición del formulario.
        Me.Location = New Point(newLeft, newTop)

        ' cargo los dias
        For dia As Integer = 1 To 31
            ComboBox1.Items.Add(dia.ToString())
        Next

        ' cargo los meses
        Dim meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        ComboBox2.Items.AddRange(meses)

        ' cargo los años
        For anno As Integer = 2010 To 1954 Step -1
            ComboBox3.Items.Add(anno.ToString())
        Next

        ' pongo el index en el primer item (0)
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lblNumeroFinal.Text = "?"

        ' Calculo numero
        Dim numeroStr As String
        numeroStr = ComboBox1.Text & Acciones.mesNumero(ComboBox2.Text).ToString & ComboBox3.Text
        'MsgBox(numeroStr)

        Dim input As String = numeroStr
        Dim resultado As Integer = 0

        ' Itera a través de cada carácter en el string
        For Each c As Char In input
            If Char.IsDigit(c) Then
                ' Convierte el carácter en un número y suma al resultado
                resultado += Integer.Parse(c.ToString())
            Else
                ' Debug:
                'Console.WriteLine("El string contiene caracteres no numéricos.")
                Exit Sub
            End If
        Next

        ' Repite el proceso hasta obtener un solo dígito
        While resultado >= 10
            Dim nuevoResultado As Integer = 0
            While resultado > 0
                nuevoResultado += resultado Mod 10
                resultado = resultado \ 10
            End While
            resultado = nuevoResultado
        End While

        ' Debug:
        'Console.WriteLine("El resultado final es: " & resultado)
        lblNumeroFinal.Text = resultado


        txtPrediccion.Text = "Cargado Predicción Semanal..."
        txtPrediccion.Text = Acciones.verPrediccionSemanal(resultado)

        ' Final
        ' 586; 547
        Me.Width = 586
        Me.Height = 547

        ' Calcula la nueva posición para centrar el formulario en la pantalla.
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Dim newLeft As Integer = (screenWidth - Me.Width) \ 2
        Dim newTop As Integer = (screenHeight - Me.Height) \ 2

        ' Establece la nueva posición del formulario.
        Me.Location = New Point(newLeft, newTop)

    End Sub

    Private Sub bgPanel_Paint(sender As Object, e As PaintEventArgs) Handles bgPanel.Paint
        Dim rect As New Rectangle(0, 0, bgPanel.Width, bgPanel.Height)
        Dim gradientBrush As New LinearGradientBrush(rect, Color.BlueViolet, Color.CadetBlue, LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub

    Private Sub lklCopiar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCopiar.LinkClicked
        Clipboard.SetText("Tu número es el: " & lblNumeroFinal.Text & vbCrLf & txtPrediccion.Text)
        lklCopiar.Text = "COPIADO"
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lklCopiar.Text = "COPIAR"
        Timer1.Stop()
    End Sub
End Class