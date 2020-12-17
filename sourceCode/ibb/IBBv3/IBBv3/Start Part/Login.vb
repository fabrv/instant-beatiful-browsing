Public Class Login

    Private Sub TextBoxX1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If My.Computer.FileSystem.DirectoryExists(" C:\ACCOUNTS" + LabelX1.Text + "\") Then
                Dim USERREAD As System.IO.StreamReader = New System.IO.StreamReader("C:\ACCOUNTS" + LabelX1.Text + "\" + "USERNAME.TXT")
                Dim userline As String
                Dim PASSREAD As System.IO.StreamReader = New System.IO.StreamReader("C:\ACCOUNTS" + LabelX1.Text + "\" + "PASSWORD.TXT")
                Dim PASSLINE As String
                Do
                    PASSLINE = TextBoxX1.Text
                    userline = USERREAD.ReadLine
                    Console.WriteLine(PASSLINE)
                    Console.WriteLine(userline)
                Loop Until userline Is Nothing
                Start.Show()
                If TextBoxX1.Text = "" Then
                    MsgBox("Please imput both a username and a password to login.", MsgBoxStyle.Critical)
                Else
                    If PASSLINE = PASSREAD.ReadLine() = True Then
                    End If
                End If
            Else
                MsgBox("The Username or Password was incorrect. Please try again.", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        Register.Show()
    End Sub

End Class