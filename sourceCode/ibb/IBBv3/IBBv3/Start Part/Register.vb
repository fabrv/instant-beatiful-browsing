Public Class Register

    Private Sub TextBoxX1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fill out the details properly.", MsgBoxStyle.Critical)
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please fill out the details properly.", MsgBoxStyle.Critical)
        Else : MkDir("C:\ACCOUNTS" + TextBox1.Text)
            Dim username As New System.IO.StreamWriter("C:\ACCOUNTS" + TextBox1.Text + "\" + "username.txt")
            username.Write(TextBox1.Text)
            username.Close()
            Dim password As New System.IO.StreamWriter("C:\ACCOUNTS" + TextBox1.Text + "\" + "password.txt")
            password.Write(TextBox2.Text)
            password.Close()
            MsgBox("The account has been created properly and is now ready for login.", MsgBoxStyle.Information, "FoolScap OS 3.0")
        End If
        Login.Show()
        Me.Close()
    End Sub
End Class