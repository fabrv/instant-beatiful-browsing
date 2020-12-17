Public Class Text_Box

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles Refresh1.Click
        Browser.Browser1.Refresh()
    End Sub

    Private Sub refresh_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Refresh1.MouseDown
        Refresh1.Image = My.Resources.Refresh_selected
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles Refresh1.MouseEnter
        Refresh1.Image = My.Resources.Refresh_hover
    End Sub

    Private Sub refresh_MouseLeave(sender As Object, e As System.EventArgs) Handles Refresh1.MouseLeave
        Refresh1.Image = My.Resources.Refresh
    End Sub

    Private Sub refresh_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Refresh1.MouseUp
        Refresh1.Image = My.Resources.Refresh
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown


        If e.KeyCode = Keys.Enter Then
            Browser.Browser1.Navigate(TextBox1.Text)
            Browser.Browser1.Visible = True
        End If


    End Sub

    Private Sub document_completed_Tick(sender As System.Object, e As System.EventArgs) Handles document_completed.Tick
        If TextBox1.Focused = False Then
            Try
                TextBox1.Text = Browser.Browser1.Url.ToString
            Catch ex As Exception
                'nada
            End Try

        End If
        
    End Sub

End Class
