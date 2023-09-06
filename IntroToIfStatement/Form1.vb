Public Class Form1
    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click


        Dim Country As String
        Country = txtCountry.Text

        If Country.ToUpper = "FRANCE " Then

            MessageBox.Show("Bonjou")

        ElseIf Country.ToUpper = "SOUTH AFRICA" Then

            MessageBox.Show("Mollo")

        ElseIf Country.ToUpper = "AUSTRALIA " Then

            MessageBox.Show("G'day mate")

        ElseIf Country.ToUpper = "SPAIN" Then

            MessageBox.Show("Ola")

        Else
            MessageBox.Show("Hello How are you")




        End If


    End Sub
End Class
