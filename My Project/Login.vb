Imports System.Data
Imports System.Data.SqlClient

Public Class login
    Private Sub loginb_Click(sender As Object, e As EventArgs) Handles loginb.Click
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim alerts As String
        alerts = "🏦 Uranus Bank - Error"
        If (userid.Text = "") Then
            MessageBox.Show("Enter the username", alerts)

        ElseIf (pass.Text = "") Then
            MessageBox.Show("Enter the password", alerts)

        Else
            Try
                con = New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("select * from usertable where userid='" & userid.Text & "' and password='" & pass.Text & "'")
                cmd.Connection = con
                rdr = cmd.ExecuteReader()
                If (rdr.Read()) Then
                    Me.Hide()
                    Home.Show()

                    pass.Text = ""
                Else
                    MessageBox.Show("Enter Correct Credentials.", alerts)
                    userid.Text = ""
                    pass.Text = ""
                End If

            Catch ex As Exception

                MessageBox.Show("Oh Snap! Errors Found. The reasons could be one or all:" & Environment.NewLine & "> User ID contains non-numeric value" & Environment.NewLine & "> Server is Not Active" & Environment.NewLine & "> Connections Were Not Configured Correctly", alerts)
                userid.Text = ""
                pass.Text = ""

            End Try

        End If

    End Sub


End Class