Public Class Back_Forward

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Back_n_Forward.BackgroundImage = My.Resources.back_forward_selected_b
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Back_n_Forward.BackgroundImage = My.Resources.back_forward
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        Back_n_Forward.BackgroundImage = My.Resources.back_forward_selected_f
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        Back_n_Forward.BackgroundImage = My.Resources.back_forward
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Browser.Browser1.GoBack()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Browser.Browser1.GoForward()
    End Sub
End Class
