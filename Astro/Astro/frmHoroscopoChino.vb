Public Class frmHoroscopoChino
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        MsgBox(calcularSignoChino(txtAnno.Text))
    End Sub

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
End Class