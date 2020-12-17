<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.Browser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Text_Box1 = New IBBv3.Text_Box()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Add_tab1 = New IBBv3.Add_tab()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Back_Forward1 = New IBBv3.Back_Forward()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WereWorkingToImproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser1
        '
        Me.Browser1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Browser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser1.IsWebBrowserContextMenuEnabled = False
        Me.Browser1.Location = New System.Drawing.Point(0, 37)
        Me.Browser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser1.Name = "Browser1"
        Me.Browser1.Size = New System.Drawing.Size(748, 425)
        Me.Browser1.TabIndex = 1
        Me.Browser1.Url = New System.Uri("https://www.google.com/", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.IBBv3.My.Resources.Resources.background_backandforward
        Me.Panel1.Controls.Add(Me.Text_Box1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Add_tab1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Back_Forward1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 37)
        Me.Panel1.TabIndex = 0
        '
        'Text_Box1
        '
        Me.Text_Box1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Text_Box1.Appearance.Options.UseBackColor = True
        Me.Text_Box1.BackgroundImage = CType(resources.GetObject("Text_Box1.BackgroundImage"), System.Drawing.Image)
        Me.Text_Box1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Text_Box1.Location = New System.Drawing.Point(62, 5)
        Me.Text_Box1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Text_Box1.Name = "Text_Box1"
        Me.Text_Box1.Size = New System.Drawing.Size(646, 24)
        Me.Text_Box1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(708, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 32)
        Me.Panel4.TabIndex = 6
        '
        'Add_tab1
        '
        Me.Add_tab1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Add_tab1.Location = New System.Drawing.Point(713, 5)
        Me.Add_tab1.Name = "Add_tab1"
        Me.Add_tab1.Size = New System.Drawing.Size(30, 32)
        Me.Add_tab1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(62, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(681, 5)
        Me.Panel2.TabIndex = 2
        '
        'Back_Forward1
        '
        Me.Back_Forward1.BackgroundImage = CType(resources.GetObject("Back_Forward1.BackgroundImage"), System.Drawing.Image)
        Me.Back_Forward1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Back_Forward1.Location = New System.Drawing.Point(0, 0)
        Me.Back_Forward1.Name = "Back_Forward1"
        Me.Back_Forward1.Size = New System.Drawing.Size(62, 37)
        Me.Back_Forward1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(743, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 37)
        Me.Panel3.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WereWorkingToImproveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(214, 26)
        '
        'WereWorkingToImproveToolStripMenuItem
        '
        Me.WereWorkingToImproveToolStripMenuItem.Name = "WereWorkingToImproveToolStripMenuItem"
        Me.WereWorkingToImproveToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.WereWorkingToImproveToolStripMenuItem.Text = "We're Working to Improve"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 462)
        Me.Controls.Add(Me.Browser1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Browser"
        Me.Text = "Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Browser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Back_Forward1 As IBBv3.Back_Forward
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Text_Box1 As IBBv3.Text_Box
    Friend WithEvents Add_tab1 As IBBv3.Add_tab
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WereWorkingToImproveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
