Imports System.Text.RegularExpressions
Imports HtmlAgilityPack

''' <summary>
''' Clase principal con todas las acciones del programa.
''' </summary>

Public Class Acciones

    ''' <summary>
    ''' Realiza un Web scraping para obtener el horoscopo del signo del zodiaco ingresado.
    ''' </summary>
    ''' <param name="signoactual">El nombre del signo a buscar.</param>
    ''' <returns>El horoscopo correspondiente al signo ingresado.</returns>

    Public Shared Function verSignoDia(ByVal signoactual As String) As String

        ' Horoscopo Diario Fuente:
        ' https://www.lavanguardia.com/horoscopo/signos-zodiaco-cancer/horoscopo-diario

        Dim url As String = "https://www.lavanguardia.com/horoscopo/signos-zodiaco-" + signoactual + "/horoscopo-diario"
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)

        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div/p"
        Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes(xpathExpression)

        If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
            For Each node As HtmlNode In nodes
                ' Debug:
                'Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            ' Debug:
            'Console.WriteLine("No se encontro el Horoscopo")
            resultado = "No se encontro el Horoscopo"
        End If

        If resultado.Length >= 4 Then
            resultado = resultado.Substring(4)
        Else
            resultado = String.Empty
        End If

        Return resultado
    End Function

    ''' <summary>
    ''' Realiza una verificacion con la fecha ingresada y devuelve el signo correspondiente a dicha fecha.
    ''' </summary>
    ''' <param name="fecha">Fecha en formato dd/mm/aaaa.</param>
    ''' <returns>El signo del zodiaco correspondiente a la fecha.</returns>

    Public Shared Function ObtenerSignoZodiaco(fecha As DateTime) As String
        Dim mes As Integer = fecha.Month
        Dim dia As Integer = fecha.Day
        Dim signo As String = ""

        Select Case mes
            Case 1
                If dia <= 19 Then
                    signo = "Capricornio"
                Else
                    signo = "Acuario"
                End If
            Case 2
                If dia <= 18 Then
                    signo = "Acuario"
                Else
                    signo = "Piscis"
                End If
            Case 3
                If dia <= 20 Then
                    signo = "Piscis"
                Else
                    signo = "Aries"
                End If
            Case 4
                If dia <= 19 Then
                    signo = "Aries"
                Else
                    signo = "Tauro"
                End If
            Case 5
                If dia <= 20 Then
                    signo = "Tauro"
                Else
                    signo = "Géminis"
                End If
            Case 6
                If dia <= 20 Then
                    signo = "Géminis"
                Else
                    signo = "Cáncer"
                End If
            Case 7
                If dia <= 22 Then
                    signo = "Cáncer"
                Else
                    signo = "Leo"
                End If
            Case 8
                If dia <= 22 Then
                    signo = "Leo"
                Else
                    signo = "Virgo"
                End If
            Case 9
                If dia <= 22 Then
                    signo = "Virgo"
                Else
                    signo = "Libra"
                End If
            Case 10
                If dia <= 22 Then
                    signo = "Libra"
                Else
                    signo = "Escorpio"
                End If
            Case 11
                If dia <= 21 Then
                    signo = "Escorpio"
                Else
                    signo = "Sagitario"
                End If
            Case 12
                If dia <= 21 Then
                    signo = "Sagitario"
                Else
                    signo = "Capricornio"
                End If
        End Select

        Return signo
    End Function

    ''' <summary>
    ''' Realiza una verificacion de rango de años en la entrada de un TextBox. Entre 1900 y año actual.
    ''' </summary>
    ''' <param name="txtBox">Valor ingresado en TextBox.</param>
    ''' <returns>Si el contenido cumple con el rango de años indicado.</returns>

    Public Shared Function validaEntradaTextBox(ByVal txtBox As TextBox) As Boolean

        Dim annoInicial As Integer = 1900 ' Año inicial del rango
        Dim annoActual As DateTime = DateTime.Now
        Dim annoFinal As Integer = annoActual.Year   ' Año final del rango

        Dim valido As Boolean = False

        ' Verifica que el TextBox no esta vacio o es nulo:
        If Not String.IsNullOrEmpty(txtBox.Text) Then
            ' Regex para validar cuatro dígitos
            Dim regex As New Regex("^\d{4}$")

            ' Verifica si el texto coincide con la expresión regular
            If regex.IsMatch(txtBox.Text) Then
                ' El TextBox contiene 4 números

                ' Convertimos el contenido del TextBox a un valor numérico (año)
                Dim año As Integer
                If Integer.TryParse(txtBox.Text, año) Then
                    ' Verificamos si el año está dentro del rango especificado
                    If año >= annoInicial AndAlso año <= annoFinal Then
                        valido = True ' El TextBox contiene 4 números y está en el rango de años
                    End If
                End If
            End If
        End If

        Return valido ' El TextBox no cumple con los criterios

    End Function

    ''' <summary>
    ''' Realiza una verificacion segun calculo matematico y devuelve el signo del horoscopo chino que corresponde.
    ''' </summary>
    ''' <param name="anno">String en formato de año: yyyy.</param>
    ''' <returns>El signo del zodiaco correspondiente al año ingresado.</returns>
    ''' 
    Public Shared Function calcularSignoChino(ByVal anno As String) As String

        Dim year As Integer = Integer.Parse(anno)
        Dim zodiac As String = ""

        If anno.Length = 4 Then

            Select Case (year - 4) Mod 12
                Case 0
                    zodiac = "rata"
                Case 1
                    zodiac = "buey"
                Case 2
                    zodiac = "tigre"
                Case 3
                    zodiac = "conejo"
                Case 4
                    zodiac = "dragon"
                Case 5
                    zodiac = "serpiente"
                Case 6
                    zodiac = "caballo"
                Case 7
                    zodiac = "cabra"
                Case 8
                    zodiac = "mono"
                Case 9
                    zodiac = "gallo"
                Case 10
                    zodiac = "perro"
                Case 11
                    zodiac = "cerdo"
            End Select

        End If

        Return zodiac
    End Function

    ''' <summary>
    ''' Realiza un Web scraping para obtener el horoscopo chino del signo ingresado.
    ''' </summary>
    ''' <param name="signoactual">El nombre del signo a buscar.</param>
    ''' <returns>El horoscopo correspondiente al signo ingresado.</returns>

    Public Shared Function verSignoChino(ByVal signoactual As String) As String

        ' Horoscopo Chino La Vanguardia Fuente:
        ' https://www.lavanguardia.com/horoscopo/horoscopo-chino/signo-mono

        ' 
        Dim url As String = "https://www.lavanguardia.com/horoscopo/horoscopo-chino/signo-" + signoactual
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)
        ' Se parsea la web con el xpath del elemento requerido
        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div"
        Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes(xpathExpression)
        ' Se recorren los nodos principales y se toma el primer nodo referido al elemento del xpath
        If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
            For Each node As HtmlNode In nodes
                ' Debug:
                'Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            ' Debug:
            'Console.WriteLine("No se encontro el Horoscopo")
            resultado = "No se encontro el Horoscopo"
        End If

        ' Se realizan operaciones para limpiar la salida.
        If resultado.Length >= 4 Then
            resultado = resultado.Substring(4)
        Else
            resultado = String.Empty
        End If

        resultado = resultado.Replace("            <p>", "") _
        .Replace("         ", "") _
        .Replace("</p>", "") _
        .Replace("<p>", "")

        Return resultado
    End Function

    ''' <summary>
    ''' Realiza un Web scraping para obtener la compatibilidad de los dos signos ingresados.
    ''' </summary>
    ''' <param name="spbox1">El nombre del primer signo.</param>
    ''' <param name="spbox2">El nombre del segundo signo.</param>
    ''' <returns>La compatibilidad entre ambos signos.</returns>

    Public Shared Function verCompatibilidad(ByVal spbox1 As String, ByVal spbox2 As String) As String

        ' Horoscopo Diario Fuente:
        ' https://www.lavanguardia.com/horoscopo/compatibilidad-signos-zodiaco/

        spbox1 = spbox1.Replace("-pro_256", "").Replace(".png", "")
        spbox2 = spbox2.Replace("-pro_256", "").Replace(".png", "")

        Dim url As String = "https://www.lavanguardia.com/horoscopo/compatibilidad-signos-zodiaco/" + spbox1 + "-" + spbox2
        Dim resultado As String = ""

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(url)

        Dim xpathExpression As String = "//*[@id='main']/div/section[1]/div/div/div[2]"
        Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes(xpathExpression)

        If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
            For Each node As HtmlNode In nodes
                ' Debug:
                ' Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            ' Debug:
            ' Console.WriteLine("No matching nodes found.")
            resultado = "No se encontraron resultados!"
        End If

        If resultado.Length >= 4 Then
            resultado = resultado.Substring(4)
        Else
            resultado = String.Empty
        End If

        resultado = resultado.Replace("            <p>", "") _
        .Replace("         ", "") _
        .Replace("</p>", "") _
        .Replace("<p>", "")

        Return resultado
    End Function

    ''' <summary>
    ''' Verifica la compatibilidad entre signos, devuelve corazon, neutral o x segun corresponda.
    ''' </summary>
    ''' <param name="signo1">El nombre del primer signo.</param>
    ''' <param name="signo2">El nombre del segundo signo.</param>
    ''' <returns>La compatibilidad entre ambos signos.</returns>

    Public Shared Function VerificarCompatibilidad(signo1 As String, signo2 As String) As String

        signo1 = signo1.Replace("-pro_256.png", "")
        signo2 = signo2.Replace("-pro_256.png", "")

        If CompatibilidadSignos.ContainsKey(signo1) AndAlso CompatibilidadSignos(signo1).ContainsKey(signo2) Then
            Return CompatibilidadSignos(signo1)(signo2)
        Else
            Return "No se encuentra información de compatibilidad."
        End If
    End Function

    ''' <summary>
    ''' Diccionario / Lista de compatibilidad entre signos del zodiaco. Fuente: https://www.clara.es/medio/2022/07/29/compatibilidad-signos_3ca30f03_1200x1200.jpg
    ''' </summary>

    Private Shared ReadOnly CompatibilidadSignos As New Dictionary(Of String, Dictionary(Of String, String)) From {
        {"aries", New Dictionary(Of String, String) From {
            {"aries", "corazon_64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "x-64.png"},
            {"leo", "corazon_64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "x-64.png"},
            {"escorpio", "neutral-64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "x-64.png"},
            {"acuario", "corazon_64.png"},
            {"piscis", "x-64.png"}
        }},
        {"tauro", New Dictionary(Of String, String) From {
            {"aries", "corazon_64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "corazon_64.png"},
            {"leo", "x-64.png"},
            {"virgo", "corazon_64.png"},
            {"libra", "neutral-64.png"},
            {"escorpio", "neutral-64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "corazon_64.png"},
            {"acuario", "x-64.png"},
            {"piscis", "corazon_64.png"}
        }},
        {"geminis", New Dictionary(Of String, String) From {
            {"aries", "neutral-64.png"},
            {"tauro", "neutral-64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "neutral-64.png"},
            {"leo", "x-64.png"},
            {"virgo", "x-64.png"},
            {"libra", "corazon_64.png"},
            {"escorpio", "neutral-64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "x-64.png"},
            {"acuario", "corazon_64.png"},
            {"piscis", "x-64.png"}
        }},
        {"cancer", New Dictionary(Of String, String) From {
            {"aries", "x-64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "corazon_64.png"},
            {"leo", "neutral-64.png"},
            {"virgo", "corazon_64.png"},
            {"libra", "x-64.png"},
            {"escorpio", "corazon_64.png"},
            {"sagitario", "x-64.png"},
            {"capricornio", "neutral-64.png"},
            {"acuario", "x-64.png"},
            {"piscis", "corazon_64.png"}
        }},
        {"leo", New Dictionary(Of String, String) From {
            {"aries", "corazon_64.png"},
            {"tauro", "x-64.png"},
            {"geminis", "x-64.png"},
            {"cancer", "neutral-64.png"},
            {"leo", "neutral-64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "corazon_64.png"},
            {"escorpio", "x-64.png"},
            {"sagitario", "corazon_64.png"},
            {"capricornio", "neutral-64.png"},
            {"acuario", "corazon_64.png"},
            {"piscis", "neutral-64.png"}
        }},
        {"virgo", New Dictionary(Of String, String) From {
            {"aries", "neutral-64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "x-64.png"},
            {"cancer", "corazon_64.png"},
            {"leo", "neutral-64.png"},
            {"virgo", "corazon_64.png"},
            {"libra", "x-64.png"},
            {"escorpio", "neutral-64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "corazon_64.png"},
            {"acuario", "neutral-64.png"},
            {"piscis", "neutral-64.png"}
        }},
        {"libra", New Dictionary(Of String, String) From {
            {"aries", "x-64.png"},
            {"tauro", "neutral-64.png"},
            {"geminis", "corazon_64.png"},
            {"cancer", "x-64.png"},
            {"leo", "corazon_64.png"},
            {"virgo", "x-64.png"},
            {"libra", "corazon_64.png"},
            {"escorpio", "neutral-64.png"},
            {"sagitario", "corazon_64.png"},
            {"capricornio", "x-64.png"},
            {"acuario", "neutral-64.png"},
            {"piscis", "neutral-64.png"}
        }},
        {"escorpio", New Dictionary(Of String, String) From {
            {"aries", "neutral-64.png"},
            {"tauro", "neutral-64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "corazon_64.png"},
            {"leo", "x-64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "neutral-64.png"},
            {"escorpio", "corazon_64.png"},
            {"sagitario", "x-64.png"},
            {"capricornio", "corazon_64.png"},
            {"acuario", "x-64.png"},
            {"piscis", "corazon_64.png"}
        }},
        {"sagitario", New Dictionary(Of String, String) From {
            {"aries", "neutral-64.png"},
            {"tauro", "neutral-64.png"},
            {"geminis", "neutral-64.png"},
            {"cancer", "x-64.png"},
            {"leo", "corazon_64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "corazon_64.png"},
            {"escorpio", "x-64.png"},
            {"sagitario", "corazon_64.png"},
            {"capricornio", "neutral-64.png"},
            {"acuario", "corazon_64.png"},
            {"piscis", "neutral-64.png"}
        }},
        {"capricornio", New Dictionary(Of String, String) From {
            {"aries", "x-64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "x-64.png"},
            {"cancer", "neutral-64.png"},
            {"leo", "neutral-64.png"},
            {"virgo", "corazon_64.png"},
            {"libra", "x-64.png"},
            {"escorpio", "corazon_64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "corazon_64.png"},
            {"acuario", "neutral-64.png"},
            {"piscis", "neutral-64.png"}
        }},
        {"acuario", New Dictionary(Of String, String) From {
            {"aries", "corazon_64.png"},
            {"tauro", "x-64.png"},
            {"geminis", "corazon_64.png"},
            {"cancer", "x-64.png"},
            {"leo", "corazon_64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "neutral-64.png"},
            {"escorpio", "x-64.png"},
            {"sagitario", "corazon_64.png"},
            {"capricornio", "neutral-64.png"},
            {"acuario", "corazon_64.png"},
            {"piscis", "x-64.png"}
        }},
        {"piscis", New Dictionary(Of String, String) From {
            {"aries", "x-64.png"},
            {"tauro", "corazon_64.png"},
            {"geminis", "x-64.png"},
            {"cancer", "corazon_64.png"},
            {"leo", "neutral-64.png"},
            {"virgo", "neutral-64.png"},
            {"libra", "neutral-64.png"},
            {"escorpio", "corazon_64.png"},
            {"sagitario", "neutral-64.png"},
            {"capricornio", "neutral-64.png"},
            {"acuario", "x-64.png"},
            {"piscis", "corazon_64.png"}
        }}
    }

    ''' <summary>
    ''' Convierte el mes ingresado en String en su numero correspondiente.
    ''' </summary>
    ''' <param name="mes">Nombre del mes.</param>
    ''' <returns>El numero del mes.</returns>

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

    ''' <summary>
    ''' Realiza un Web scraping para obtener la prediccion semanal segun el numero ingresado.
    ''' </summary>
    ''' <param name="numero">El numero a buscar.</param>
    ''' <returns>La prediccion semanal del numero ingresado.</returns>

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
                ' Debug:
                'Console.WriteLine(node.InnerHtml) ' Print the inner HTML of the selected node
                resultado = nodes(0).InnerHtml
            Next
        Else
            ' Debug:
            'Console.WriteLine("No matching nodes found.")
            resultado = "No se pudo definir la Numerología de la Semana"
        End If

        If resultado.Length >= 4 Then
            resultado = resultado.Substring(4)
        Else
            resultado = String.Empty
        End If

        Return resultado
    End Function

End Class
