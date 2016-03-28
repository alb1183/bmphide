Imports System.IO
Public Class Form1

    Dim hex_txt As String
    Dim hex_bmp As String
    Dim hex_final As String
    Public Function StringToHex(ByVal StrToHex As String) As String
        Dim strTemp As String
        Dim strReturn As String
        Dim I As Long
        For I = 1 To Len(StrToHex)
            strTemp = Hex(Asc(Mid$(StrToHex, I, 1)))
            If Len(strTemp) = 1 Then strTemp = "0" & strTemp
            strReturn = strReturn & strTemp
        Next I
        StringToHex = strReturn
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            hex_txt = String.Join("", IO.File.ReadAllBytes(OpenFileDialog1.FileName).Select(Function(b) b.ToString("X2")).ToArray()) & "01"
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            hex_bmp = String.Join("", IO.File.ReadAllBytes(OpenFileDialog2.FileName).Select(Function(b) b.ToString("X2")).ToArray())
            If hex_txt.Length / 2 <= (((hex_bmp.Length / 2) - 54) / 6) ^ 2 Then
                Button3.Enabled = True
            Else
                MsgBox("Imagen demasiado pequeña")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.FileName = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog2.FileName)
        SaveFileDialog1.DefaultExt = System.IO.Path.GetExtension(OpenFileDialog2.FileName)
        SaveFileDialog1.Filter = "Archivo " & System.IO.Path.GetExtension(OpenFileDialog2.FileName).Replace(".", "") & "|*." & System.IO.Path.GetExtension(OpenFileDialog2.FileName).Replace(".", "")
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'source hex string

            For k As Integer = 0 To hex_txt.Length / 2 - 1
                Mid(hex_bmp, hex_bmp.Length - (k * k * 6 + 3), 2) = hex_txt.Substring(k * 2, 2)
            Next

            hex_final = hex_bmp
            '
            Dim length As Integer = hex_final.Length
            Dim upperBound As Integer = length \ 2
            If length Mod 2 = 0 Then
                upperBound -= 1
            Else
                hex_final = "0" & hex_final
            End If
            Dim bytes(upperBound) As Byte
            For i As Integer = 0 To upperBound
                bytes(i) = Convert.ToByte(hex_final.Substring(i * 2, 2), 16)
            Next

            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(SaveFileDialog1.FileName, System.IO.FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub


    Dim hex_bmp_des As String
    Dim hex_txt_des As String
    Dim hex_final_des As String
    Function HexToString(ByVal hex As String) As String
        Dim text As New System.Text.StringBuilder(hex.Length \ 2)
        For i As Integer = 0 To hex.Length - 2 Step 2
            text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
        Next
        Return text.ToString
    End Function

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If OpenFileDialog3.ShowDialog() = Windows.Forms.DialogResult.OK Then
            hex_bmp_des = String.Join("", IO.File.ReadAllBytes(OpenFileDialog3.FileName).Select(Function(b) b.ToString("X2")).ToArray())
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If SaveFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'source hex string
            '54 info inicial
            For k As Integer = 0 To (((hex_bmp_des.Length / 2) - 54) / 6) - 1
                'hex_txt_des = hex_txt_des & HexDeEncrip(hex_bmp_des.Substring(hex_bmp_des.Length - (k * 6 + 3), 2))
                Dim cabezal As Integer = hex_bmp_des.Length - (k * k * 6 + 4)
                If hex_bmp_des.Substring(cabezal, 2) = "01" Then
                    Exit For
                Else
                    hex_txt_des = hex_txt_des & hex_bmp_des.Substring(cabezal, 2)
                End If
            Next

            hex_final_des = hex_txt_des
            '
            Dim length As Integer = hex_final_des.Length
            Dim upperBound As Integer = length \ 2
            If length Mod 2 = 0 Then
                upperBound -= 1
            Else
                hex_final_des = "0" & hex_final_des
            End If
            Dim bytes(upperBound) As Byte
            For i As Integer = 0 To upperBound
                bytes(i) = Convert.ToByte(hex_final_des.Substring(i * 2, 2), 16)
            Next

            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(SaveFileDialog2.FileName, System.IO.FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            Button5.Enabled = False
        End If
    End Sub
End Class
