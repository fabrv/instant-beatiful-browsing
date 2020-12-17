Public Class Browser

    Private Sub Browser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Browser1.DocumentCompleted
        Me.Text = Browser1.DocumentTitle
    End Sub

End Class