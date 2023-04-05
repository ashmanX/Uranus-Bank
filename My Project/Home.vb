
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Home
    Private Sub withdrawbtn_Click(sender As Object, e As EventArgs) Handles withdrawbtn.Click

        WIthdraw.Show()

    End Sub

    Private Sub depositbtn_Click(sender As Object, e As EventArgs) Handles depositbtn.Click

        deposit.Show()

    End Sub

    Private Sub transferbtn_Click(sender As Object, e As EventArgs) Handles transferbtn.Click

        transfer.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        deposit.Close()
        WIthdraw.Close()
        transfer.Close()
        customer.Hide()
        loan.Close()
        login.Show()
        loantable.Close()
        managecust.Close()
        withdrawtable.Close()
        deposittable.Close()
        transfertable.Close()
    End Sub

    Private Sub customerbtn_Click(sender As Object, e As EventArgs) Handles customerbtn.Click
        customer.Show()
    End Sub



    Private Sub loanbtn_Click(sender As Object, e As EventArgs) Handles loanbtn.Click
        loantable.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.FlatAppearance.BorderSize = 0
    End Sub
End Class