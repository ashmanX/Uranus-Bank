Imports System.Data.SqlClient
Public Class WIthdraw
    Dim con As New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")
    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click

        If acno.Text = "" Then
            Select Case MsgBox("Account Number Cannot Be Empty.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select
        Else
            con.Open()
            Try
                Dim command As New SqlCommand("select * from custtable where accountnumber= '" & acno.Text & "'", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                Dim randomnumber As New Random()
                adapter.Fill(table)

                If table.Rows.Count() > 0 Then
                    cname.Text = table.Rows(0)(1).ToString()
                    balance.Text = table.Rows(0)(2).ToString()
                    transid.Text = randomnumber.Next(100000, 200000)
                Else
                    Select Case MsgBox("Account Does Not Exist.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Failed")
                    End Select
                    acno.Text = ""
                    cname.Text = ""
                    balance.Text = ""
                    transid.Text = ""
                End If
                con.Close()
            Catch ex As Exception
                Select Case MsgBox("Enter Valid Amount.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                con.Close()
            End Try
        End If
    End Sub

    Public Sub withdrawbtn_Click(sender As Object, e As EventArgs) Handles withdrawbtn.Click

        Try
            Dim withdouble, balancedouble As Double
            withdouble = CDbl(withamount.Text)
            balancedouble = CDbl(balance.Text)
            If acno.Text = "" Or cname.Text = "" Then
                Select Case MsgBox("Please Enter All Details.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select

            ElseIf withdouble <= 0 Then
                Select Case MsgBox("Please Enter Valid Amount.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                withamount.Text = ""
            ElseIf withdouble > balancedouble Then
                Select Case MsgBox("Insufficient Balance.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                withamount.Text = ""
            Else
                Dim command As New SqlCommand("UPDATE custtable SET Balance = Balance - '" & withamount.Text & "' WHERE AccountNumber='" & acno.Text & "' AND Name='" & cname.Text & "' ", con)
                Dim com1 As New SqlCommand("INSERT INTO withdraw VALUES ( '" & transid.Text & "' , '" & acno.Text & "' ,  '" & cname.Text & "', '" & withamount.Text & "')", con)
                con.Open()
                If command.ExecuteNonQuery() = 1 Then
                    If com1.ExecuteNonQuery() = 1 Then
                        Select Case MsgBox("Amount Withdrawn Successfully.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Success")
                        End Select

                        balance.Text = balance.Text - withamount.Text
                        withamount.Text = ""
                    Else
                        MsgBox("Failed")
                    End If

                Else
                    Select Case MsgBox("Failed. Database Error Encountered.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Failed")
                    End Select
                    balance.Text = ""
                    withamount.Text = ""
                    acno.Text = ""

                End If
                con.Close()
            End If
        Catch ex As Exception
            Select Case MsgBox("Invalid Details Entered.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
            End Select
        End Try
    End Sub

    Private Sub tablebtn_Click(sender As Object, e As EventArgs) Handles tablebtn.Click
        withdrawtable.Show()
    End Sub
End Class