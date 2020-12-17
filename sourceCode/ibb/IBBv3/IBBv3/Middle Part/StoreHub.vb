Public Class StoreHub
    Dim i As Integer
    Dim u As Integer

    Public Sub expand()
        Bar_Start.Width = 50
        u = u + 1
    End Sub

    Public Sub collapse()
        Bar_Start.Width = 10
        u = u - 1
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Select Case i
            Case Is = 0
                Me.Close()
            Case Is = 1
                WebBrowser1.GoBack()
                'PictureBox1.Focus()
        End Select
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox1.DoubleClick
        WebBrowser1.Visible = False
        ItemPanel1.Visible = True
    End Sub

    Private Sub StartOrb_Click(sender As System.Object, e As System.EventArgs) Handles StartOrb.Click
        Select Case u
            Case Is = 0
                expand()
            Case Is = 1
                Me.WindowState = FormWindowState.Minimized
                collapse()
        End Select
    End Sub

    Private Sub Bar_Start_Click(sender As Object, e As System.EventArgs) Handles Bar_Start.Click
        Select Case u
            Case Is = 0
                expand()
            Case Is = 1
                collapse()
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(TextBox1.Text)
            WebBrowser1.Visible = True
            WebBrowser1.Dock = DockStyle.Fill
            ItemPanel1.Visible = False
            i = 1
        End If
    End Sub

    Private Sub StoreHub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        i = 0
        u = 0
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        Adress_Bar.BackColor = Color.White
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        TextBox1.Font = New Font("Microsoft MHei", 11, FontStyle.Regular)
        Select Case WebBrowser1.Visible
            Case Is = True
                TextBox1.Text = WebBrowser1.Url.ToString
            Case Is = False
                TextBox1.Text = ""
        End Select
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        Adress_Bar.BackColor = Color.Silver
        TextBox1.BackColor = Color.Silver
        TextBox1.ForeColor = Color.Gray
        TextBox1.Font = New Font("Microsoft MHei", 11, FontStyle.Italic)
        Select Case WebBrowser1.Visible
            Case Is = True
                TextBox1.Text = WebBrowser1.Url.ToString
            Case Is = False
                TextBox1.Text = "Search"
        End Select

    End Sub
End Class