Imports System.Data.SqlClient
Public Class loantable
    Dim con As New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")

    Private Sub loantable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * FROM loans", con)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 50
        Next
    End Sub

    Private Sub loanbtn_Click(sender As Object, e As EventArgs) Handles loanbtn.Click
        Me.Close()
        loan.Show()
    End Sub
End Class