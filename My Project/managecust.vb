Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices

Public Class managecust

    Dim con As New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")
    Private Sub managecust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        editbtn.Visible = False
        deletebtn.Visible = False
        addbtn.Visible = False
        balance.ReadOnly = True
    End Sub
    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If acno.Text = "" Then
            MsgBox("Enter Account Number")
        ElseIf acno.Text.Length < 6 Or acno.Text.Length > 6 Then
            Select Case MsgBox("Account Number must be 6 digits", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select
        Else

            con.Open()
            Try

                Dim command As New SqlCommand("select * from custtable where accountnumber= '" & acno.Text & "'", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    cname.Text = table.Rows(0)(1).ToString()
                    balance.Text = table.Rows(0)(2).ToString()
                    age.Text = table.Rows(0)(3).ToString()
                    gender.Text = table.Rows(0)(4).ToString()
                    address.Text = table.Rows(0)(5).ToString()
                    phone.Text = table.Rows(0)(6).ToString()
                    addbtn.Visible = False
                    editbtn.Visible = True
                    deletebtn.Visible = True
                    editbtn.Enabled = False
                Else
                    Select Case MsgBox("Account Doesn't Exist. Do you want to create new account?", MsgBoxStyle.YesNo, "Uranus Bank - Confirm")
                        Case MsgBoxResult.Yes
                            cname.Text = ""
                            balance.Text = ""
                            age.Text = ""
                            gender.Text = ""
                            address.Text = ""
                            phone.Text = ""
                            editbtn.Visible = False
                            deletebtn.Visible = False
                            addbtn.Visible = True
                            balance.ReadOnly = False
                        Case MsgBoxResult.No
                            acno.Text = ""
                            cname.Text = ""
                            balance.Text = ""
                            age.Text = ""
                            gender.Text = ""
                            address.Text = ""
                            phone.Text = ""
                            addbtn.Visible = False
                    End Select



                End If
                con.Close()

            Catch ex As Exception
                MsgBox("Failed. Check the Values Entered.")
                acno.Text = ""
                con.Close()

            End Try

        End If
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If acno.Text = "" Or cname.Text = "" Or balance.Text = "" Or age.Text = "" Or address.Text = "" Or phone.Text = "" Then
            Select Case MsgBox("Please Fill In All Details", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select
        ElseIf acno.Text.Length < 6 Or acno.Text.Length > 6 Then
            Select Case MsgBox("Account Number must be 6 digits", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select
        ElseIf phone.Text.Length < 10 OrElse phone.Text.Length > 10 Then
            Select Case MsgBox("Phone Number must be 10 digits", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")

            End Select
            phone.Undo()
        Else

            con.Open()
            Try
                Dim com As New SqlCommand("INSERT INTO custtable VALUES ( '" & acno.Text & "','" & cname.Text & "','" & balance.Text & "','" & age.Text & "','" & gender.SelectedItem & "','" & address.Text & "','" & phone.Text & "' )", con)
                If com.ExecuteNonQuery() = 1 Then
                    Select Case MsgBox("Account Created Successfully. Do you want to see customers list?", MsgBoxStyle.YesNo, "Uranus Bank - Confirm")
                        Case MsgBoxResult.Yes
                            editbtn.Enabled = False
                            customer.Show()
                    End Select
                    editbtn.Visible = True
                    deletebtn.Visible = True
                    addbtn.Visible = False

                Else
                    MsgBox("Failed.")
                End If
                con.Close()
            Catch ex As Exception
                MsgBox("Check Values Entered")
                con.Close()
            End Try
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If acno.Text.Length < 6 Or acno.Text.Length > 6 Then
            Select Case MsgBox("Account Number must be 6 digits", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select
        Else

            Select Case MsgBox("Are you sure you want to delete", MsgBoxStyle.YesNo, "Uranus Bank - Confirm")

                Case MsgBoxResult.Yes
                    con.Open()

                    Try
                        Dim com As New SqlCommand("DELETE FROM custtable WHERE accountnumber = '" & acno.Text & "' ", con)
                        If com.ExecuteNonQuery() = 1 Then
                            acno.Text = ""
                            cname.Text = ""
                            balance.Text = ""
                            age.Text = ""
                            gender.Text = ""
                            address.Text = ""
                            phone.Text = ""
                            Select Case MsgBox("Account Deleted Successfully. Do you want to see customers list?", MsgBoxStyle.YesNo, "Uranus Bank - Confirm")
                                Case MsgBoxResult.Yes
                                    editbtn.Enabled = False
                                    customer.Show()
                            End Select
                        Else
                            MsgBox("Failed.")
                        End If
                        con.Close()
                    Catch ex As Exception
                        MsgBox("Error Occurred.")
                        con.Close()
                    End Try

            End Select
        End If


    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        If acno.Text = "" Or cname.Text = "" Or balance.Text = "" Or age.Text = "" Or address.Text = "" Or phone.Text = "" Then
            MsgBox("Please fill in all all details")
        ElseIf phone.Text.Length < 10 OrElse phone.Text.Length > 10 Then
            Select Case MsgBox("Phone Number must be 10 digits", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select
            phone.Undo()
        ElseIf acno.Text.Length < 6 Or acno.Text.Length > 6 Then
            Select Case MsgBox("Account Number must be 6 digits", MsgBoxStyle.OkOnly, "Uranus Bank - Alert")
            End Select

        Else

            con.Open()
            Try
                Dim com As New SqlCommand("UPDATE custtable SET name= '" & cname.Text & "', balance = '" & balance.Text & "', age= '" & age.Text & "',gender= '" & gender.SelectedItem & "', address= '" & address.Text & "', phone= '" & phone.Text & "' WHERE accountnumber= '" & acno.Text & "' ", con)
                If com.ExecuteNonQuery() = 1 Then
                    Select Case MsgBox("Details Updated Successfully. Do you want to see customers list?", MsgBoxStyle.YesNo, "Uranus Bank - Confirm")
                        Case MsgBoxResult.Yes
                            customer.Show()
                    End Select
                Else
                    MsgBox("Failed.")
                End If
                con.Close()
            Catch ex As Exception
                MsgBox("Values are not correct. Check Again.")
                con.Close()
            End Try
        End If
    End Sub
    Public Sub AllTextChanged_Click(sender As Object, e As EventArgs) Handles cname.TextChanged, age.TextChanged, address.TextChanged, gender.SelectedIndexChanged, phone.TextChanged
        editbtn.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub managecust_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class