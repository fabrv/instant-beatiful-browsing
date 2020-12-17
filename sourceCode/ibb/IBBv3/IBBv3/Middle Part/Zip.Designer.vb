<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zip
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
        Me.Address_Bar = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.lbl_temp = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Address_Bar.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Address_Bar
        '
        Me.Address_Bar.BackColor = System.Drawing.Color.Silver
        Me.Address_Bar.Controls.Add(Me.TextBox2)
        Me.Address_Bar.Controls.Add(Me.Panel8)
        Me.Address_Bar.Controls.Add(Me.PictureBox4)
        Me.Address_Bar.Controls.Add(Me.PictureBox5)
        Me.Address_Bar.Location = New System.Drawing.Point(62, 27)
        Me.Address_Bar.Name = "Address_Bar"
        Me.Address_Bar.Size = New System.Drawing.Size(258, 36)
        Me.Address_Bar.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Silver
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft MHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Gray
        Me.TextBox2.Location = New System.Drawing.Point(4, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "Enter Zip"
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(4, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(252, 6)
        Me.Panel8.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox4.Location = New System.Drawing.Point(256, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(2, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(4, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.PictureBox6)
        Me.Panel10.Controls.Add(Me.lbl_city)
        Me.Panel10.Controls.Add(Me.lbl_temp)
        Me.Panel10.Controls.Add(Me.lbl_description)
        Me.Panel10.Location = New System.Drawing.Point(94, 108)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(207, 245)
        Me.Panel10.TabIndex = 23
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.IBBv3.My.Resources.Resources.Weather_overcast1
        Me.PictureBox6.Location = New System.Drawing.Point(74, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 21
        Me.PictureBox6.TabStop = False
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.BackColor = System.Drawing.Color.Transparent
        Me.lbl_city.Font = New System.Drawing.Font("Microsoft MHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_city.ForeColor = System.Drawing.Color.White
        Me.lbl_city.Location = New System.Drawing.Point(79, 70)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(36, 21)
        Me.lbl_city.TabIndex = 16
        Me.lbl_city.Text = "City"
        '
        'lbl_temp
        '
        Me.lbl_temp.AutoSize = True
        Me.lbl_temp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_temp.Font = New System.Drawing.Font("Microsoft MHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temp.ForeColor = System.Drawing.Color.White
        Me.lbl_temp.Location = New System.Drawing.Point(79, 121)
        Me.lbl_temp.Name = "lbl_temp"
        Me.lbl_temp.Size = New System.Drawing.Size(48, 21)
        Me.lbl_temp.TabIndex = 17
        Me.lbl_temp.Text = "Temp"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.BackColor = System.Drawing.Color.Transparent
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft MHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.ForeColor = System.Drawing.Color.White
        Me.lbl_description.Location = New System.Drawing.Point(79, 171)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(35, 21)
        Me.lbl_description.TabIndex = 18
        Me.lbl_description.Text = "Fair"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Zip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(387, 402)
        Me.Controls.Add(Me.Address_Bar)
        Me.Controls.Add(Me.Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Zip"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zip"
        Me.Address_Bar.ResumeLayout(False)
        Me.Address_Bar.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Address_Bar As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_temp As System.Windows.Forms.Label
    Friend WithEvents lbl_description As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
