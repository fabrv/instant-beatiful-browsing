<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockHub
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
        Dim ClockStyleData2 As DevComponents.DotNetBar.Controls.ClockStyleData = New DevComponents.DotNetBar.Controls.ClockStyleData()
        Dim ColorData9 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData10 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData11 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData4 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData12 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData13 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData5 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData14 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData6 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData15 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData16 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AnalogClockControl1 = New DevComponents.DotNetBar.Controls.AnalogClockControl()
        Me.Bar_Start = New System.Windows.Forms.Panel()
        Me.MeControlPanel = New System.Windows.Forms.PictureBox()
        Me.ControlPanel = New System.Windows.Forms.PictureBox()
        Me.StartOrb = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar_Start.SuspendLayout()
        CType(Me.MeControlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartOrb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft MHei", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(142, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 128)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "12:00:00 pm"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IBBv3.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(44, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft MHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(98, 57)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(80, 47)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Clock"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AnalogClockControl1
        '
        Me.AnalogClockControl1.BackColor = System.Drawing.Color.Transparent
        Me.AnalogClockControl1.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Style2
        ColorData9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData9.BrushAngle = 90.0!
        ColorData9.BrushSBSScale = 1.0!
        ColorData9.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData9.Color1 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ColorData9.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.BezelColor = ColorData9
        ColorData10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData10.BorderWidth = 0.01!
        ColorData10.BrushSBSScale = 1.0!
        ColorData10.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData10.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ClockStyleData2.CapColor = ColorData10
        ClockStyleData2.CapSize = 0.1!
        ColorData11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData11.BrushAngle = 90.0!
        ColorData11.BrushSBSScale = 1.0!
        ColorData11.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData11.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        ColorData11.Color2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        ClockStyleData2.FaceColor = ColorData11
        ClockStyleData2.GlassAngle = 0
        ColorData12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData12.BorderWidth = 0.01!
        ColorData12.BrushAngle = 90.0!
        ColorData12.BrushSBSScale = 1.0!
        ColorData12.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData12.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData12.Color2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ClockHandStyleData4.HandColor = ColorData12
        ClockHandStyleData4.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3
        ClockHandStyleData4.Length = 0.45!
        ClockHandStyleData4.Width = 0.175!
        ClockStyleData2.HourHandStyle = ClockHandStyleData4
        ColorData13.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData13.BorderWidth = 0.01!
        ColorData13.BrushSBSScale = 1.0!
        ColorData13.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData13.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.LargeTickColor = ColorData13
        ClockStyleData2.LargeTickWidth = 0.01!
        ColorData14.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData14.BorderWidth = 0.01!
        ColorData14.BrushAngle = 90.0!
        ColorData14.BrushSBSScale = 1.0!
        ColorData14.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData14.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData14.Color2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ClockHandStyleData5.HandColor = ColorData14
        ClockHandStyleData5.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3
        ClockHandStyleData5.Length = 0.75!
        ClockHandStyleData5.Width = 0.175!
        ClockStyleData2.MinuteHandStyle = ClockHandStyleData5
        ClockStyleData2.NumberColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.NumberFont = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        ClockHandStyleData6.DrawOverCap = True
        ColorData15.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData15.BorderWidth = 0.01!
        ColorData15.BrushSBSScale = 1.0!
        ColorData15.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData15.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockHandStyleData6.HandColor = ColorData15
        ClockHandStyleData6.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style4
        ClockHandStyleData6.Length = 0.9!
        ClockHandStyleData6.Width = 0.01!
        ClockStyleData2.SecondHandStyle = ClockHandStyleData6
        ColorData16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData16.BorderWidth = 0.01!
        ColorData16.BrushSBSScale = 1.0!
        ColorData16.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData16.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.SmallTickColor = ColorData16
        ClockStyleData2.SmallTickLength = 0.01!
        ClockStyleData2.SmallTickWidth = 0.01!
        ClockStyleData2.Style = DevComponents.DotNetBar.Controls.eClockStyles.Style2
        Me.AnalogClockControl1.ClockStyleData = ClockStyleData2
        Me.AnalogClockControl1.Location = New System.Drawing.Point(44, 286)
        Me.AnalogClockControl1.Name = "AnalogClockControl1"
        Me.AnalogClockControl1.Size = New System.Drawing.Size(100, 100)
        Me.AnalogClockControl1.TabIndex = 10
        Me.AnalogClockControl1.Text = "AnalogClockControl1"
        Me.AnalogClockControl1.Value = New Date(2011, 11, 29, 22, 30, 5, 896)
        '
        'Bar_Start
        '
        Me.Bar_Start.BackColor = System.Drawing.Color.Black
        Me.Bar_Start.Controls.Add(Me.MeControlPanel)
        Me.Bar_Start.Controls.Add(Me.ControlPanel)
        Me.Bar_Start.Controls.Add(Me.StartOrb)
        Me.Bar_Start.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bar_Start.Location = New System.Drawing.Point(0, 0)
        Me.Bar_Start.Name = "Bar_Start"
        Me.Bar_Start.Size = New System.Drawing.Size(10, 464)
        Me.Bar_Start.TabIndex = 12
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
        'ControlPanel
        '
        Me.ControlPanel.BackColor = System.Drawing.Color.Black
        Me.ControlPanel.Image = Global.IBBv3.My.Resources.Resources.settings1
        Me.ControlPanel.Location = New System.Drawing.Point(0, 309)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(50, 50)
        Me.ControlPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ControlPanel.TabIndex = 13
        Me.ControlPanel.TabStop = False
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
        'ClockHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IBBv3.My.Resources.Resources.back_SD
        Me.ClientSize = New System.Drawing.Size(891, 464)
        Me.Controls.Add(Me.Bar_Start)
        Me.Controls.Add(Me.AnalogClockControl1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClockHub"
        Me.Text = "ClockHub"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar_Start.ResumeLayout(False)
        CType(Me.MeControlPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartOrb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AnalogClockControl1 As DevComponents.DotNetBar.Controls.AnalogClockControl
    Friend WithEvents Bar_Start As System.Windows.Forms.Panel
    Friend WithEvents MeControlPanel As System.Windows.Forms.PictureBox
    Friend WithEvents ControlPanel As System.Windows.Forms.PictureBox
    Friend WithEvents StartOrb As System.Windows.Forms.PictureBox
End Class
