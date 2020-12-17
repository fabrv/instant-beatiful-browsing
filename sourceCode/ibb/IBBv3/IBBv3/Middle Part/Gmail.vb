Public Class Gmail

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = WebBrowser1.DocumentTitle
    End Sub
End Class