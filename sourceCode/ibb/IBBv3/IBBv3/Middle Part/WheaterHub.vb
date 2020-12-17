
Public Class WheaterHub
    Dim i As Integer
    Dim u As Integer
    Dim o As Integer


    Public Sub expand()
        Bar_Start.Width = 50
        u = u + 1
    End Sub

    Public Sub collapse()
        Bar_Start.Width = 10
        u = u - 1
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Select Case i
            Case Is = 0
                Me.Close()
            Case Is = 1
                WebBrowser1.GoBack()
                'PictureBox1.Focus()
        End Select
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        Adress_Bar.BackColor = Color.Black
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White
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
            WebBrowser1.Navigate(TextBox1.Text)
            WebBrowser1.Visible = True
            WebBrowser1.Dock = DockStyle.Fill
            i = 1
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

    Private Sub WheatherHub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Try
                Dim xx As New WeatherServices.WeatherReturn

                Dim xx1 As New WeatherServices.WeatherSoapClient

            xx = xx1.GetCityWeatherByZIP("91185")


                If xx.Success Then
                    lbl_city.Text = String.Format("{0}, {1}", xx.City, xx.State)
                    lbl_temp.Text = xx.Temperature
                    lbl_description.Text = xx.Description
                Else
                    lbl_city.Text = "N/A"
                    lbl_temp.Text = "N/A"
                    lbl_description.Text = "N/A"
                End If



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        i = 0
        u = 0
        o = 0
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox1.DoubleClick
        WebBrowser1.Visible = False
        i = 0
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

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LabelX4.Text = TimeOfDay
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Close()
        End If
    End Sub

    Private Sub ControlPanel_Click(sender As System.Object, e As System.EventArgs) Handles ControlPanel.Click
        Select Case u
            Case Is = 0
                expand()
            Case Is = 1
                Select Case O
                    Case Is = 0
                        Address_Bar.Visible = True
                        o = 1
                    Case Is = 1
                        Address_Bar.Visible = False
                        o = 0
                End Select
        End Select
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox2.GotFocus
        Address_Bar.BackColor = Color.Black
        TextBox2.BackColor = Color.Black
        TextBox2.ForeColor = Color.White
        TextBox2.Font = New Font("Microsoft MHei", 11, FontStyle.Regular)
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim xx As New WeatherServices.WeatherReturn

                Dim xx1 As New WeatherServices.WeatherSoapClient

                xx = xx1.GetCityWeatherByZIP(TextBox2.Text)


                If xx.Success Then
                    lbl_city.Text = String.Format("{0}, {1}", xx.City, xx.State)
                    lbl_temp.Text = xx.Temperature
                    lbl_description.Text = xx.Description
                Else
                    lbl_city.Text = "N/A"
                    lbl_temp.Text = "N/A"
                    lbl_description.Text = "N/A"
                End If



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus
        Address_Bar.BackColor = Color.Silver
        TextBox2.BackColor = Color.Silver
        TextBox2.ForeColor = Color.Gray
        TextBox2.Font = New Font("Microsoft MHei", 11, FontStyle.Italic)
        TextBox2.Text = "Search"
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class