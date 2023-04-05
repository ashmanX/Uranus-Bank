Imports System.Data.SqlClient
Public Class transfer
    Dim con As New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If acno.Text = "" Then
            Select Case MsgBox("Account  Number Cannot Be Empty", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
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
                    MsgBox("Account Does Not Exist.")
                    acno.Text = ""
                    cname.Text = ""
                    balance.Text = ""
                    transid.Text = ""

                End If
                con.Close()
            Catch ex As Exception
                MsgBox("Error has Occurred")
                con.Close()
            End Try
            con.Close()
        End If
    End Sub
    Private Sub transferbtn_Click(sender As Object, e As EventArgs) Handles transferbtn.Click
        customer.Close()


        If acno.Text = "" Or tacno.Text = "" Then
            Select Case MsgBox("Enter account number.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select
        ElseIf acno.Text = tacno.Text Then
            Select Case MsgBox("Transfer to the same account is not possible.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select
        ElseIf transamt.Text = "" Then
            Select Case MsgBox("Please Enter The Amount.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select
        Else
            Try
                If cname.Text = "" Or tcname.Text = "" Or balance.Text = "" Or transamt.Text = "" Or acno.Text = "" Or tacno.Text = "" Then
                    Select Case MsgBox("Please Fill All Details.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                    End Select
                Else
                    con.Open()
                    Try
                        Dim depdouble, balancedouble As Double
                        depdouble = CDbl(transamount.Text)
                        balancedouble = CDbl(balance.Text)
                        If depdouble <= 0 Then
                            Select Case MsgBox("Please Enter A Valid Transfer Amount.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                            End Select
                            transamount.Text = ""
                        ElseIf depdouble > balancedouble Then
                            Select Case MsgBox("Insufficient Balance.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                            End Select
                        Else
                            Dim command As New SqlCommand("UPDATE custtable SET Balance = Balance - '" & transamount.Text & "' WHERE AccountNumber='" & acno.Text & "' AND Name='" & cname.Text & "' ", con)
                            Dim command1 As New SqlCommand("UPDATE custtable SET Balance = Balance + '" & transamount.Text & "' WHERE AccountNumber='" & tacno.Text & "' AND Name='" & tcname.Text & "' ", con)
                            Dim command2 As New SqlCommand("INSERT INTO transfer VALUES ( '" & transid.Text & "' , '" & acno.Text & "' , '" & cname.Text & "' , '" & tacno.Text & "' , '" & tcname.Text & "' , '" & transamount.Text & "' )", con)
                            If command.ExecuteNonQuery() = 1 Then
                                If command1.ExecuteNonQuery() = 1 Then
                                    If command2.ExecuteNonQuery() = 1 Then
                                        Select Case MsgBox("Transfer was successful. Do you want to see updated list?", MsgBoxStyle.YesNo, "🏦 Uranus Bank - Confirm")
                                            Case MsgBoxResult.Yes
                                                customer.Show()
                                        End Select
                                        balance.Text = balance.Text - transamount.Text
                                        transamount.Text = ""
                                    End If
                                Else
                                    Select Case MsgBox("Failed! Database Error Encountered.", MsgBoxStyle.OkOnly, " 🏦 Uranus Bank - Failed")
                                    End Select
                                End If
                            Else
                                Select Case MsgBox("Failed! Database Error Encountered.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Failed")
                                End Select
                                balance.Text = ""
                                transamount.Text = ""
                                acno.Text = ""
                                tacno.Text = ""
                            End If
                            con.Close()
                        End If
                    Catch ex As Exception
                        Select Case MsgBox("Error. Values Entered Are Not Of The Correct Type.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                        End Select
                        con.Close()
                    End Try

                    con.Close()
                End If
            Catch ex As Exception
                Select Case MsgBox("Error. Please Check all Details.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
            End Try
        End If

    End Sub

    Private Sub tsearchbtn_Click(sender As Object, e As EventArgs) Handles tsearchbtn.Click
        If tacno.Text = "" Then
            Select Case MsgBox("Account  Number Cannot Be Empty.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select
        Else
            con.Open()
            Try
                Dim command As New SqlCommand("select * from custtable where accountnumber= '" & tacno.Text & "'", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count() > 0 Then
                    tcname.Text = table.Rows(0)(1).ToString()
                Else
                    Select Case MsgBox("Account Does Not Exist.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                    End Select
                    tacno.Text = ""
                    tcname.Text = ""
                    transid.Text = ""
                End If
                con.Close()
            Catch ex As Exception
                Select Case MsgBox("Error. Values Entered Are Not Of Correct Type.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transfertable.Show()
    End Sub
End Class