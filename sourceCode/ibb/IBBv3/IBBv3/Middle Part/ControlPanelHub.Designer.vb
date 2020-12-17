<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanelHub
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.CommandBar = New System.Windows.Forms.Panel()
        Me.Adress_Bar = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.User_name = New DevComponents.DotNetBar.LabelX()
        Me.User_image = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bar_Start = New System.Windows.Forms.Panel()
        Me.MeControlPanel = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.StartOrb = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.PageSlider1 = New DevComponents.DotNetBar.Controls.PageSlider()
        Me.PageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.PageSliderPage2 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.show_keyboard = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CommandBar.SuspendLayout()
        Me.Adress_Bar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.User_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar_Start.SuspendLayout()
        CType(Me.MeControlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartOrb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSlider1.SuspendLayout()
        Me.PageSliderPage1.SuspendLayout()
        Me.PageSliderPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(10, 451)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(885, 20)
        Me.WebBrowser1.TabIndex = 17
        Me.WebBrowser1.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'CommandBar
        '
        Me.CommandBar.BackColor = System.Drawing.Color.Transparent
        Me.CommandBar.Controls.Add(Me.Adress_Bar)
        Me.CommandBar.Controls.Add(Me.Panel7)
        Me.CommandBar.Controls.Add(Me.Panel6)
        Me.CommandBar.Controls.Add(Me.Panel5)
        Me.CommandBar.Controls.Add(Me.Panel4)
        Me.CommandBar.Controls.Add(Me.Panel2)
        Me.CommandBar.Controls.Add(Me.Panel3)
        Me.CommandBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.CommandBar.Location = New System.Drawing.Point(10, 0)
        Me.CommandBar.Name = "CommandBar"
        Me.CommandBar.Size = New System.Drawing.Size(885, 117)
        Me.CommandBar.TabIndex = 16
        '
        'Adress_Bar
        '
        Me.Adress_Bar.BackColor = System.Drawing.Color.Silver
        Me.Adress_Bar.Controls.Add(Me.TextBox1)
        Me.Adress_Bar.Controls.Add(Me.Panel9)
        Me.Adress_Bar.Controls.Add(Me.PictureBox3)
        Me.Adress_Bar.Controls.Add(Me.PictureBox2)
        Me.Adress_Bar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Adress_Bar.Location = New System.Drawing.Point(226, 61)
        Me.Adress_Bar.Name = "Adress_Bar"
        Me.Adress_Bar.Size = New System.Drawing.Size(419, 36)
        Me.Adress_Bar.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft MHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(4, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(413, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Search"
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(4, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(413, 6)
        Me.Panel9.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Location = New System.Drawing.Point(417, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(2, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(226, 97)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(419, 20)
        Me.Panel7.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(645, 61)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(26, 56)
        Me.Panel6.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(200, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(26, 56)
        Me.Panel5.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(200, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(471, 61)
        Me.Panel4.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.User_name)
        Me.Panel2.Controls.Add(Me.User_image)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(671, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 117)
        Me.Panel2.TabIndex = 7
        '
        'User_name
        '
        Me.User_name.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.User_name.BackgroundStyle.Class = ""
        Me.User_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.User_name.Font = New System.Drawing.Font("Microsoft MHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_name.ForeColor = System.Drawing.Color.White
        Me.User_name.Location = New System.Drawing.Point(100, 56)
        Me.User_name.Name = "User_name"
        Me.User_name.Size = New System.Drawing.Size(41, 27)
        Me.User_name.TabIndex = 6
        Me.User_name.Text = "User"
        '
        'User_image
        '
        Me.User_image.BackColor = System.Drawing.Color.Transparent
        Me.User_image.Image = Global.IBBv3.My.Resources.Resources.User_Image
        Me.User_image.Location = New System.Drawing.Point(147, 58)
        Me.User_image.Name = "User_image"
        Me.User_image.Size = New System.Drawing.Size(46, 46)
        Me.User_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.User_image.TabIndex = 4
        Me.User_image.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelX2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 117)
        Me.Panel3.TabIndex = 9
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft MHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(88, 57)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(67, 47)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "I.B.B"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IBBv3.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(34, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Bar_Start
        '
        Me.Bar_Start.BackColor = System.Drawing.Color.Black
        Me.Bar_Start.Controls.Add(Me.MeControlPanel)
        Me.Bar_Start.Controls.Add(Me.PictureBox4)
        Me.Bar_Start.Controls.Add(Me.StartOrb)
        Me.Bar_Start.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bar_Start.Location = New System.Drawing.Point(0, 0)
        Me.Bar_Start.Name = "Bar_Start"
        Me.Bar_Start.Size = New System.Drawing.Size(10, 471)
        Me.Bar_Start.TabIndex = 18
        '
        'MeControlPanel
        '
        Me.MeControlPanel.BackColor = System.Drawing.Color.Black
        Me.MeControlPanel.Image = Global.IBBv3.My.Resources.Resources.heart
        Me.MeControlPanel.Location = New System.Drawing.Point(0, 410)
        Me.MeControlPanel.Name = "MeControlPanel"
        Me.MeControlPanel.Size = New System.Drawing.Size(50, 50)
        Me.MeControlPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MeControlPanel.TabIndex = 14
        Me.MeControlPanel.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Image = Global.IBBv3.My.Resources.Resources.settings1
        Me.PictureBox4.Location = New System.Drawing.Point(0, 309)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'StartOrb
        '
        Me.StartOrb.BackColor = System.Drawing.Color.Black
        Me.StartOrb.Image = Global.IBBv3.My.Resources.Resources.windowsorb
        Me.StartOrb.Location = New System.Drawing.Point(1, 360)
        Me.StartOrb.Name = "StartOrb"
        Me.StartOrb.Size = New System.Drawing.Size(50, 50)
        Me.StartOrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.StartOrb.TabIndex = 12
        Me.StartOrb.TabStop = False
        '
        'Timer1
        '
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft MHei", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(30, 41)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(341, 101)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Rename Me"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft MHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelX3.Location = New System.Drawing.Point(30, 123)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(358, 55)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "Rename your Workspace"
        '
        'PageSlider1
        '
        Me.PageSlider1.AllowDrop = True
        Me.PageSlider1.AnimationTime = 250
        Me.PageSlider1.Controls.Add(Me.PageSliderPage1)
        Me.PageSlider1.Controls.Add(Me.PageSliderPage2)
        Me.PageSlider1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageSlider1.IndicatorVisible = False
        Me.PageSlider1.Location = New System.Drawing.Point(10, 117)
        Me.PageSlider1.Name = "PageSlider1"
        Me.PageSlider1.Orientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.PageSlider1.PageSpacing = 50
        Me.PageSlider1.SelectedPage = Me.PageSliderPage1
        Me.PageSlider1.Size = New System.Drawing.Size(885, 334)
        Me.PageSlider1.TabIndex = 19
        Me.PageSlider1.Text = "PageSlider1"
        '
        'PageSliderPage1
        '
        Me.PageSliderPage1.Controls.Add(Me.LabelX4)
        Me.PageSliderPage1.Controls.Add(Me.LabelX5)
        Me.PageSliderPage1.Controls.Add(Me.LabelX1)
        Me.PageSliderPage1.Controls.Add(Me.LabelX3)
        Me.PageSliderPage1.Location = New System.Drawing.Point(4, 4)
        Me.PageSliderPage1.Name = "PageSliderPage1"
        Me.PageSliderPage1.Size = New System.Drawing.Size(877, 226)
        Me.PageSliderPage1.TabIndex = 3
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft MHei", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.White
        Me.LabelX4.Location = New System.Drawing.Point(30, 184)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(341, 101)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Theme"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft MHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelX5.Location = New System.Drawing.Point(30, 266)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(358, 55)
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Multi"
        '
        'PageSliderPage2
        '
        Me.PageSliderPage2.Controls.Add(Me.show_keyboard)
        Me.PageSliderPage2.Controls.Add(Me.LabelX6)
        Me.PageSliderPage2.Location = New System.Drawing.Point(4, 280)
        Me.PageSliderPage2.Name = "PageSliderPage2"
        Me.PageSliderPage2.Size = New System.Drawing.Size(877, 226)
        Me.PageSliderPage2.TabIndex = 4
        '
        'show_keyboard
        '
        '
        '
        '
        Me.show_keyboard.BackgroundStyle.Class = ""
        Me.show_keyboard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.show_keyboard.BorderColor = System.Drawing.Color.White
        Me.show_keyboard.Location = New System.Drawing.Point(30, 138)
        Me.show_keyboard.Name = "show_keyboard"
        Me.show_keyboard.OffBackColor = System.Drawing.Color.Black
        Me.show_keyboard.OffText = ""
        Me.show_keyboard.OnBackColor = System.Drawing.Color.Teal
        Me.show_keyboard.OnText = ""
        Me.show_keyboard.Size = New System.Drawing.Size(66, 22)
        Me.show_keyboard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.show_keyboard.SwitchBorderColor = System.Drawing.Color.Black
        Me.show_keyboard.SwitchWidth = 11
        Me.show_keyboard.TabIndex = 3
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft MHei", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.White
        Me.LabelX6.Location = New System.Drawing.Point(30, 13)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(341, 101)
        Me.LabelX6.TabIndex = 2
        Me.LabelX6.Text = "KeyBoard"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft MHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coming Soon"
        '
        'ControlPanelHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(895, 471)
        Me.Controls.Add(Me.PageSlider1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.CommandBar)
        Me.Controls.Add(Me.Bar_Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ControlPanelHub"
        Me.ShowInTaskbar = False
        Me.Text = "ControlPanel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CommandBar.ResumeLayout(False)
        Me.Adress_Bar.ResumeLayout(False)
        Me.Adress_Bar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.User_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar_Start.ResumeLayout(False)
        CType(Me.MeControlPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartOrb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSlider1.ResumeLayout(False)
        Me.PageSliderPage1.ResumeLayout(False)
        Me.PageSliderPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents CommandBar As System.Windows.Forms.Panel
    Friend WithEvents Adress_Bar As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents User_image As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bar_Start As System.Windows.Forms.Panel
    Friend WithEvents MeControlPanel As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents StartOrb As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PageSlider1 As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents PageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PageSliderPage2 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents show_keyboard As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents User_name As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
