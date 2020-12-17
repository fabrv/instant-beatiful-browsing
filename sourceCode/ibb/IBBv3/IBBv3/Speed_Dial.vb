Public Class Speed_Dial
    Public Sub closeSD()

        Browser.Browser1.Visible = True
    End Sub

    Private Sub Tile1_Click(sender As System.Object, e As System.EventArgs) Handles Tile1.Click
        Browser.Browser1.Navigate("http://www.google.com")
        closeSD()
    End Sub

    Private Sub tile2_Click(sender As System.Object, e As System.EventArgs) Handles tile2.Click
        Browser.Browser1.Navigate("http://www.nytimes.com")
        closeSD()
    End Sub

    Private Sub tile4_Click(sender As System.Object, e As System.EventArgs) Handles tile4.Click
        Browser.Browser1.Navigate("http://www.armorgames.com")
        closeSD()
    End Sub

    Private Sub tile5_Click(sender As System.Object, e As System.EventArgs) Handles tile5.Click
        Browser.Browser1.Navigate("http://www.twitter.com")
        closeSD()
    End Sub

    Private Sub tile6_Click(sender As System.Object, e As System.EventArgs) Handles tile6.Click
        Browser.Browser1.Navigate("http://www.facebook.com")
        closeSD()
    End Sub

    Private Sub tile7_Click(sender As System.Object, e As System.EventArgs) Handles tile7.Click
        Browser.Browser1.Navigate("http://www.bing.com")
        closeSD()
    End Sub

    Private Sub tile9_Click(sender As System.Object, e As System.EventArgs) Handles tile9.Click
        Browser.Browser1.Navigate("http://www.deviantart.com")
        closeSD()
    End Sub

    Private Sub tile8_Click(sender As System.Object, e As System.EventArgs) Handles tile8.Click, tile4.Click, tile10.Click, tile11.Click, tile12.Click, Styller.Click, Downloads.Click, MetroTile.Click
        MessageBox.Show("Coming Soon")
    End Sub

    Private Sub Store_Click(sender As System.Object, e As System.EventArgs) Handles Store.Click
        Dim xtab As New StoreHub
        xtab.WindowState = FormWindowState.Maximized
        xtab.MdiParent = Main
        xtab.Show()
    End Sub
End Class
