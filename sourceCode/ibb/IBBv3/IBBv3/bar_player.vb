Public Class bar_player
    Dim i As Integer = 0
    Dim o As Integer = 0

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Select Case i
            Case Is = 0
                Select Case o
                    Case 0
                        Start.MediaPlayer.URL = Start.OpenFileDialog1.FileName
                        i = 1
                        o = 1
                        PictureBox4.Image = My.Resources.pause
                    Case 1
                        PictureBox4.Image = My.Resources.pause
                        Start.MediaPlayer.Ctlcontrols.play()
                        i = 1
                End Select
            Case 1
                PictureBox4.Image = My.Resources.play
                Start.MediaPlayer.Ctlcontrols.pause()
                i = 0
        End Select

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        Try
            Start.MediaPlayer.Ctlcontrols.previous()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        Try
            Start.MediaPlayer.Ctlcontrols.next()
        Catch ex As Exception

        End Try

    End Sub
End Class
