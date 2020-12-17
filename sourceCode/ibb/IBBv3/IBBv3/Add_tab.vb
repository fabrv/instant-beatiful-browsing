Public Class Add_tab

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Dim xtab As New Browser
        xtab.MdiParent = Main
        xtab.WindowState = FormWindowState.Maximized
        xtab.Show()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = My.Resources.Add_Tab_Cliked
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = My.Resources.Add_Tab
    End Sub
End Class
