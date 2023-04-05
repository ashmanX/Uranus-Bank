Imports System.Data.SqlClient

Public Class deposit
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
                    Select Case MsgBox("Account Does Not Exist", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                    End Select
                    acno.Text = ""
                    cname.Text = ""
                    balance.Text = ""
                    transid.Text = ""
                End If
                con.Close()
            Catch ex As Exception
                Select Case MsgBox("Error Encountered!", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
                End Select
                con.Close()
            End Try
        End If
    End Sub

    Private Sub depositbtn_Click(sender As Object, e As EventArgs) Handles depositbtn.Click
        Try
            Dim depdouble, balancedouble As Double
            depdouble = CDbl(depamount.Text)
            balancedouble = CDbl(balance.Text)
            If depdouble <= 0 Or depdouble > balancedouble Then
                Select Case MsgBox("Please Enter Valid Amount.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Alert")
                End Select
                depamount.Text = ""
            Else
                Dim command As New SqlCommand("UPDATE custtable SET Balance = Balance + '" & depamount.Text & "' WHERE AccountNumber='" & acno.Text & "' AND Name='" & cname.Text & "' ", con)
                Dim com1 As New SqlCommand("INSERT INTO deposit VALUES ( '" & transid.Text & "' , '" & acno.Text & "' ,  '" & cname.Text & "', '" & depamount.Text & "')", con)
                con.Open()
                If command.ExecuteNonQuery() = 1 Then
                    If com1.ExecuteNonQuery() = 1 Then
                        Select Case MsgBox("Amount Deposited Successfully.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Success")
                        End Select

                        balance.Text = CDbl(balance.Text) + CDbl(depamount.Text)
                        depamount.Text = ""
                    End If
                Else
                    Select Case MsgBox("Failed. Database Error.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Failed")
                    End Select
                    balance.Text = ""
                    depamount.Text = ""
                    acno.Text = ""
                End If
                con.Close()
            End If
        Catch ex As Exception
            Select Case MsgBox("Please Enter A Valid Deposit Amount.", MsgBoxStyle.OkOnly, "🏦 Uranus Bank - Error")
            End Select
        End Try
    End Sub

    Private Sub tablebtn_Click(sender As Object, e As EventArgs) Handles tablebtn.Click
        deposittable.Show()
    End Sub

    Private Sub deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class