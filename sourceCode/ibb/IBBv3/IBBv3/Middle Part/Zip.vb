Public Class Zip

    Private Sub TextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox2.GotFocus
        Address_Bar.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox2.ForeColor = Color.Black
        TextBox2.Font = New Font("Microsoft MHei", 11, FontStyle.Regular)
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus
        Address_Bar.BackColor = Color.Silver
        TextBox2.BackColor = Color.Silver
        TextBox2.ForeColor = Color.Gray
        TextBox2.Font = New Font("Microsoft MHei", 11, FontStyle.Italic)
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
End Class