Public Class Start
    Dim i As Integer
    Dim u As Integer
    Dim O As Integer = 0
    Dim a As Integer = 0
    Dim search_setting As Integer = 0

    Dim tab As New Panel
    Dim tabItem As New DevComponents.DotNetBar.LabelX
    Dim reference As New WebBrowser

    Public Sub expand()
        Bar_Start.Width = 50
        u = u + 1
    End Sub

    Public Sub collapse()
        Bar_Start.Width = 10
        u = u - 1
    End Sub

    Private Sub Start_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.BrowserFavorites Then
            MessageBox.Show("coming soon")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Select Case i
            Case Is = 0
                Me.Close()
            Case Is = 1
                WebBrowser1.GoBack()
                'PictureBox1.Focus()
            Case Is = 2
                PageSlider1.Visible = True
                i = 0
        End Select
    End Sub

    Private Sub MetroTileItem7_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem7.Click
        Gmail.Show()
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

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
        Select search_setting
                Case Is = 0

                    WebBrowser1.Navigate(TextBox1.Text)
                    WebBrowser1.Visible = True
                    WebBrowser1.Dock = DockStyle.Fill
                    PageSlider1.Visible = False
                    i = 1
                    bars_tabs.Controls.Add(tab)

                    tab.Visible = True
                    tab.Dock = DockStyle.Top
                    tab.Height = 150
                    tab.Width = 20
                    tab.BackColor = Color.Transparent


                    tabItem.Dock = DockStyle.Top

                    tabItem.Visible = True
                    'tabItem.Width = 50
                    tabItem.Height = 20
                    tabItem.ForeColor = Color.White
                    tabItem.Font = New Font("Microsoft MHei", 10, FontStyle.Regular)

                    reference.Width = 0
                    reference.Navigate(TextBox1.Text)

                    tab.Controls.Add(tabItem)
                    tabItem.Text = WebBrowser1.DocumentTitle

                    search_setting = 0




                Case Is = 1
                    WebBrowser1.Navigate("https://www.google.com/search?q=" + TextBox1.Text)
                    WebBrowser1.Visible = True
                    WebBrowser1.Dock = DockStyle.Fill
                    PageSlider1.Visible = False
                    i = 1
                    bars_tabs.Controls.Add(tab)

                    tab.Visible = True
                    tab.Dock = DockStyle.Top
                    tab.Height = 150
                    tab.Width = 20
                    tab.BackColor = Color.Transparent


                    tabItem.Dock = DockStyle.Top

                    tabItem.Visible = True
                    'tabItem.Width = 50
                    tabItem.Height = 20
                    tabItem.ForeColor = Color.White
                    tabItem.Font = New Font("Microsoft MHei", 10, FontStyle.Regular)

                    reference.Width = 0
                    reference.Navigate(TextBox1.Text)

                    tab.Controls.Add(tabItem)
                    tabItem.Text = WebBrowser1.DocumentTitle

                    search_setting = 0

                Case Is = 2
                    WebBrowser1.Navigate("http://www.bing.com/search?q=" + TextBox1.Text)
                    WebBrowser1.Visible = True
                    WebBrowser1.Dock = DockStyle.Fill
                    PageSlider1.Visible = False
                    i = 1
                    bars_tabs.Controls.Add(tab)

                    tab.Visible = True
                    tab.Dock = DockStyle.Top
                    tab.Height = 150
                    tab.Width = 20
                    tab.BackColor = Color.Transparent


                    tabItem.Dock = DockStyle.Top

                    tabItem.Visible = True
                    'tabItem.Width = 50
                    tabItem.Height = 20
                    tabItem.ForeColor = Color.White
                    tabItem.Font = New Font("Microsoft MHei", 10, FontStyle.Regular)

                    reference.Width = 0
                    reference.Navigate(TextBox1.Text)

                    tab.Controls.Add(tabItem)
                    tabItem.Text = WebBrowser1.DocumentTitle

                    search_setting = 0

                Case Is = 3
                    WebBrowser1.Navigate("http://www.ask.com/web?q=" + TextBox1.Text)
                    WebBrowser1.Visible = True
                    WebBrowser1.Dock = DockStyle.Fill
                    PageSlider1.Visible = False
                    i = 1
                    bars_tabs.Controls.Add(tab)

                    tab.Visible = True
                    tab.Dock = DockStyle.Top
                    tab.Height = 150
                    tab.Width = 20
                    tab.BackColor = Color.Transparent


                    tabItem.Dock = DockStyle.Top

                    tabItem.Visible = True
                    'tabItem.Width = 50
                    tabItem.Height = 20
                    tabItem.ForeColor = Color.White
                    tabItem.Font = New Font("Microsoft MHei", 10, FontStyle.Regular)

                    reference.Width = 0
                    reference.Navigate(TextBox1.Text)

                    tab.Controls.Add(tabItem)
                    tabItem.Text = WebBrowser1.DocumentTitle

                    search_setting = 0
            End Select
        End If
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

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        tile_clock.TitleText = TimeOfDay
        LabelX4.Text = TimeOfDay
    End Sub

    Private Sub Start_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        i = 0
        u = 0
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox1.DoubleClick
        WebBrowser1.Visible = False
        PageSlider1.Visible = True
        i = 0
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Select Case WebBrowser1.Visible
            Case Is = True
                TextBox1.Text = WebBrowser1.Url.ToString
            Case Is = False
                TextBox1.Text = "Search"
        End Select
    End Sub

    Private Sub MetroTileItem16_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem16.Click
        search_setting = 1
        PageSlider1.Visible = False
        i = 2
    End Sub

    Private Sub Panel8_Click(sender As Object, e As System.EventArgs) Handles Bar_Start.Click
        Select Case u
            Case Is = 0
                expand()
            Case Is = 1
                collapse()
        End Select
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles StartOrb.Click
        Select Case u
            Case Is = 0
                expand()
            Case Is = 1
                Me.WindowState = FormWindowState.Minimized
                collapse()
        End Select
    End Sub

    Private Sub MetroTileItem1_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem1.Click
        StoreHub.Show()
    End Sub

    Private Sub tile12_Click(sender As System.Object, e As System.EventArgs) Handles tile12.Click
        Try
            Shell("C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe")
        Catch ex As Exception
            MessageBox.Show("You do not have Visual Studio install")
        End Try

    End Sub

    Private Sub MetroTileItem2_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem2.Click
        WheaterHub.Show()
    End Sub

    Private Sub MetroTileItem8_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem8.Click
        If Bar_player1.Visible = False Then
            OpenFileDialog1.ShowDialog()
            Bar_player1.Visible = True
        Else
            Bar_player1.Visible = False
        End If
    End Sub

    Private Sub MetroTileItem5_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem5.Click, MetroTileItem3.Click
        MessageBox.Show("Coming Soon")
    End Sub

    Private Sub bars_tabs_Click(sender As Object, e As System.EventArgs) Handles bars_tabs.Click
        Select Case a
            Case 0
                MessageBox.Show("Coming Soon")
                bars_tabs.Width = "100"
                a = 1
            Case 1
                bars_tabs.Width = "10"
                a = 0
        End Select
    End Sub

    Private Sub tile_clock_Click(sender As System.Object, e As System.EventArgs) Handles tile_clock.Click
        ClockHub.Show()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        ClockHub.Show()
    End Sub

    Private Sub MetroTileItem4_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem4.Click, MetroTileItem3.Click
        ControlPanelHub.Show()
    End Sub

    Private Sub MetroTileItem18_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem18.Click
        search_setting = 2
        PageSlider1.Visible = False
        i = 2
    End Sub

    Private Sub MetroTileItem38_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem38.Click
        search_setting = 3
        PageSlider1.Visible = False
        i = 2
    End Sub

    Private Sub MetroTileItem11_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem11.Click
        Main.Show()
    End Sub

    Private Sub MetroTileItem6_Click(sender As System.Object, e As System.EventArgs) Handles MetroTileItem6.Click
        Gmail.Show()
    End Sub
End Class