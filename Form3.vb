Public Class Items
    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlClient.SqlConnection("Data Source=DESKTOP-5GRVG81\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True")
        conn.Open()
        query = "select * from dbo.Combos;"
        cmd = New SqlClient.SqlCommand(query, conn)
        adapter.SelectCommand = cmd
        adapter.Fill(dbDataSet)
        bsource.DataSource = dbDataSet
        DataGridView1.DataSource = bsource
    End Sub
End Class