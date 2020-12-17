Public Class Main

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim xtab As New Browser
        xtab.MdiParent = Me
        xtab.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.Text = "IBB - " + XtraTabbedMdiManager1.SelectedPage.Text
    End Sub
End Class
