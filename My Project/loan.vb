Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class loan
    Dim con As New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")
    Private Sub loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loanbtn.Visible = False
        paidbtn.Visible = False
        loanbtn.Enabled = False
        paidbtn.Enabled = False
        lname.ReadOnly = True
        lamount.ReadOnly = True
        interest.ReadOnly = True
        duration.ReadOnly = True
        dueamt.ReadOnly = True

    End Sub
    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If loanno.Text = "" Then
            Select Case MsgBox("Please Enter Account Number", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select

        Else

            con.Open()
            Try

                Dim command As New SqlCommand("select * from loans where loannumber= '" & loanno.Text & "'", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    lname.Text = table.Rows(0)(1).ToString()
                    lamount.Text = table.Rows(0)(2).ToString()
                    interest.Text = table.Rows(0)(3).ToString()
                    duration.Text = table.Rows(0)(4).ToString()
                    dueamt.Text = table.Rows(0)(5).ToString()
                    paidbtn.Visible = True
                    paidbtn.Enabled = True
                    loanbtn.Visible = False
                    loanbtn.Enabled = False
                    dueamt.ReadOnly = True
                    dueamt.Visible = True
                    dueamtlabel.Visible = True

                Else
                    Select Case MsgBox("No Loan Found. Do you want to process new loan?", MsgBoxStyle.YesNo, "🏦 Uranus Bank - Confirm")
                        Case MsgBoxResult.Yes
                            lname.Text = ""
                            lamount.Text = ""
                            interest.Text = ""
                            duration.Text = ""
                            dueamt.Visible = False
                            dueamtlabel.Visible = False
                            paidbtn.Visible = False
                            paidbtn.Enabled = False
                            loanbtn.Enabled = True
                            loanbtn.Visible = True
                            lname.ReadOnly = False
                            lamount.ReadOnly = False
                            interest.ReadOnly = False
                            duration.ReadOnly = False
                            dueamt.Visible = False

                        Case MsgBoxResult.No
                            loanno.Text = ""
                            lname.Text = ""
                            lamount.Text = ""
                            interest.Text = ""
                            duration.Text = ""
                            dueamt.Text = ""
                            dueamt.Visible = False
                            dueamtlabel.Visible = False
                            paidbtn.Visible = False
                            paidbtn.Enabled = False
                            loanbtn.Enabled = False
                            loanbtn.Visible = False
                            lname.ReadOnly = True
                            lamount.ReadOnly = True
                            interest.ReadOnly = True
                            duration.ReadOnly = True

                    End Select
                End If
                con.Close()

            Catch ex As Exception
                Select Case MsgBox("Failed. Please Enter Valid Details.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                loanno.Text = ""
                con.Close()
            End Try

        End If
    End Sub

    Private Sub loanbtn_Click(sender As Object, e As EventArgs) Handles loanbtn.Click
        Dim amt, int, dur, due As Double

        If loanno.Text = "" Or lname.Text = "" Or interest.Text = "" Or duration.Text = "" Or lamount.Text = "" Then
            Select Case MsgBox("PLease Fill In All Details", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
            End Select
        Else
            Try
                amt = CDbl(lamount.Text)
                int = CDbl(interest.Text) / 100
                dur = CDbl(duration.Text)
                due = amt * (1 + (int * dur))
                dueamt.Text = due.ToString()
                If amt <= 0 Or int <= 0 Or dur <= 0 Then
                    Select Case MsgBox("Please Enter Valid Values.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                    End Select
                Else
                    con.Open()
                    Try
                        If amt <= 0 Or int <= 0 Or dur <= 0 Then
                            Select Case MsgBox("Please Enter Valid Values.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                            End Select
                        Else
                            Dim al As String
                            al = "🏦 Uranus Bank - Success"
                            Dim com As New SqlCommand("INSERT INTO loans VALUES ( '" & loanno.Text & "','" & lname.Text & "','" & lamount.Text & "','" & interest.Text & "','" & duration.Text & "','" & dueamt.Text & "' )", con)
                            If com.ExecuteNonQuery() = 1 Then
                                MessageBox.Show("Loan Processed Successfully. The Due amount is Rs " & dueamt.Text & ".", al)
                                loanbtn.Visible = False
                                dueamt.Visible = True
                                dueamtlabel.Visible = True
                                paidbtn.Visible = True
                                paidbtn.Enabled = True
                            Else
                                Select Case MsgBox("Failed. Database Error Encountered.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                                End Select
                            End If
                            con.Close()
                        End If
                    Catch ex As Exception
                        Select Case MsgBox("Failed! Please Enter Valid Details.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                        End Select
                        con.Close()

                    End Try
                End If

            Catch ex As Exception
                Select Case MsgBox("Please Enter Valid Details.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                lname.Text = ""
                lamount.Text = ""
                interest.Text = ""
                duration.Text = ""
            End Try
        End If
    End Sub

    Private Sub paidbtn_Click(sender As Object, e As EventArgs) Handles paidbtn.Click
        If loanno.Text = "" Then
            Select Case MsgBox("Please Fill In Loan Number.", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select
        Else
            con.Open()
            Try
                Dim command As New SqlCommand("DELETE FROM loans WHERE loannumber = '" & loanno.Text & "' ", con)
                If command.ExecuteNonQuery = 1 Then
                    Select Case MsgBox("Loan Payment Was Successful. Records Deleted From The Database", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Success")
                    End Select
                    loanbtn.Visible = False
                    paidbtn.Visible = False
                    dueamt.Visible = False
                    dueamtlabel.Visible = False
                    loanbtn.Enabled = False
                    paidbtn.Enabled = False
                    lname.ReadOnly = True
                    lamount.ReadOnly = True
                    interest.ReadOnly = True
                    duration.ReadOnly = True
                    dueamt.ReadOnly = True
                    loanno.Text = ""
                    lname.Text = ""
                    lamount.Text = ""
                    interest.Text = ""
                    duration.Text = ""
                    dueamt.Text = ""
                Else
                    Select Case MsgBox("Failed. Database Error Encountered.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                    End Select
                End If
                con.Close()
            Catch ex As Exception
                Select Case MsgBox("Error! Values Entered Are Not Of The Correct Type", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                con.Close()
            End Try

        End If
    End Sub


End Class