Public Class Form1
    Dim x, y1, y2, y3 As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 1
        If x < 100 Then
            y1 = Int(1 + Rnd() * 3)
            y2 = Int(1 + Rnd() * 3)
            y3 = Int(1 + Rnd() * 3)
        End If
        Select Case y1
            Case 1
                PictureBox1.Image = My.Resources.img1
            Case 2
                PictureBox1.Image = My.Resources.img2
            Case 3
                PictureBox1.Image = My.Resources.img3
        End Select
        Select Case y2
            Case 1
                PictureBox2.Image = My.Resources.img1
            Case 2
                PictureBox2.Image = My.Resources.img2
            Case 3
                PictureBox2.Image = My.Resources.img3
        End Select
        Select Case y3
            Case 1
                PictureBox3.Image = My.Resources.img1
            Case 2
                PictureBox3.Image = My.Resources.img2
            Case 3
                PictureBox3.Image = My.Resources.img3
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        If (y1 = y2) and (y2 = y3) Then
            MsgBox("Selamat! Anda Menang!!!")
        Else
            MsgBox("Yah.. Anda Gagal!!!")
        End If
    End Sub
End Class
