<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Text_Box
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.imge_location = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextContainer = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Refresh1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.document_completed = New System.Windows.Forms.Timer(Me.components)
        Me.TextContainer.SuspendLayout()
        CType(Me.Refresh1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imge_location
        '
        Me.imge_location.BackgroundImage = Global.IBBv3.My.Resources.Resources.Textbox
        Me.imge_location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imge_location.Dock = System.Windows.Forms.DockStyle.Left
        Me.imge_location.Location = New System.Drawing.Point(0, 0)
        Me.imge_location.Name = "imge_location"
        Me.imge_location.Size = New System.Drawing.Size(30, 24)
        Me.imge_location.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(30, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 5)
        Me.Panel2.TabIndex = 2
        '
        'TextContainer
        '
        Me.TextContainer.Controls.Add(Me.TextBox1)
        Me.TextContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextContainer.Location = New System.Drawing.Point(30, 8)
        Me.TextContainer.Name = "TextContainer"
        Me.TextContainer.Size = New System.Drawing.Size(239, 13)
        Me.TextContainer.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 14)
        Me.TextBox1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(30, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 3)
        Me.Panel1.TabIndex = 5
        '
        'Refresh1
        '
        Me.Refresh1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Refresh1.Image = Global.IBBv3.My.Resources.Resources.Refresh
        Me.Refresh1.Location = New System.Drawing.Point(269, 0)
        Me.Refresh1.Name = "Refresh1"
        Me.Refresh1.Size = New System.Drawing.Size(23, 24)
        Me.Refresh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Refresh1.TabIndex = 6
        Me.Refresh1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(30, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 3)
        Me.Panel3.TabIndex = 7
        '
        'document_completed
        '
        Me.document_completed.Enabled = True
        Me.document_completed.Interval = 10
        '
        'Text_Box
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IBBv3.My.Resources.Resources.Textbox_center
        Me.Controls.Add(Me.TextContainer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Refresh1)
        Me.Controls.Add(Me.imge_location)
        Me.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Name = "Text_Box"
        Me.Size = New System.Drawing.Size(292, 24)
        Me.TextContainer.ResumeLayout(False)
        Me.TextContainer.PerformLayout()
        CType(Me.Refresh1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents refresh As System.Windows.Forms.PictureBox
    Friend WithEvents imge_location As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextContainer As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Refresh1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents document_completed As System.Windows.Forms.Timer

End Class
