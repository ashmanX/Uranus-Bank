
Imports System.Data.SqlClient

Public Class deposittable
    Dim con As New SqlConnection("Data Source=ASHMAN\ASHMAN;Initial Catalog=Bankmanage;Integrated Security=True")

    Private Sub deposittable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * FROM deposit order by AccountNumber asc", con)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 50
        Next
    End Sub
End Class