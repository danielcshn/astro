Imports System.Drawing.Drawing2D
Imports HtmlAgilityPack

Public Class frmNumerologia

    ' Referencia como sacar numero
    ' https://www.clarin.com/internacional/-saber-mision-vida-numerologia-_0_uB4yBKSXxr.html

    Private Sub frmNumerologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        ' Calculo numero
        Dim numeroStr As String
        numeroStr = ComboBox1.Text & mesNumero(ComboBox2.Text).ToString & ComboBox3.Text
        'MsgBox(numeroStr)

        Dim input As String = numeroStr
        Dim resultado As Integer = 0

        ' Itera a través de cada carácter en el string
        For Each c As Char In input
            If Char.IsDigit(c) Then
                ' Convierte el carácter en un número y suma al resultado
                resultado += Integer.Parse(c.ToString())
            Else
                Console.WriteLine("El string contiene caracteres no numéricos.")
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

        Console.WriteLine("El resultado final es: " & resultado)
        lblNumeroFinal.Text = resultado


        txtPrediccion.Text = "Cargado Predicción Semanal..."
        txtPrediccion.Text = verPrediccionSemanal(resultado)

    End Sub

    Public Shared Function mesNumero(ByVal mes As String) As Integer

        Dim numeroMes As Integer

        Select Case mes.ToLower() ' Convertir a minúsculas para hacerlo insensible a mayúsculas/minúsculas.
            Case "enero"
                numeroMes = 1
            Case "febrero"
                numeroMes = 2
            Case "marzo"
                numeroMes = 3
            Case "abril"
                numeroMes = 4
            Case "mayo"
                numeroMes = 5
            Case "junio"
                numeroMes = 6
            Case "julio"
                numeroMes = 7
            Case "agosto"
                numeroMes = 8
            Case "septiembre"
                numeroMes = 9
            Case "octubre"
                numeroMes = 10
            Case "noviembre"
                numeroMes = 11
            Case "diciembre"
                numeroMes = 12
            Case Else
                ' Manejar el caso en que el mes ingresado no coincide con ningún nombre de mes válido.
                numeroMes = -1 ' Puedes usar otro valor como -1 o mostrar un mensaje de error.
        End Select

        Return numeroMes
    End Function

    Public Shared Function verPrediccionSemanal(ByVal numero As String) As String

        ' Predicción Semanal Fuente:
        ' https://www.lavanguardia.com/horoscopo/numerologia-1

        Dim url As String = "https://www.lavanguardia.com/horoscopo/numerologia-" + numero
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)

        Dim xpathExpression As String = "//*[@id='main']/div/section[2]/div/div/ul/li[" + numero + "]/div/p"
        Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes(xpathExpression)

        If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
            For Each node As HtmlNode In nodes
                Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            Console.WriteLine("No matching nodes found.")
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
        Dim gradientBrush As New LinearGradientBrush(rect, Color.BlueViolet, Color.CadetBlue, LinearGradientMode.ForwardDiagonal)

        ' Fill the PictureBox with the gradient background.
        e.Graphics.FillRectangle(gradientBrush, rect)
    End Sub
End Class