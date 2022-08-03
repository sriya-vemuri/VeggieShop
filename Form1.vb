Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SignUpForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Must enter username and password")
        Else
            conn = New SqlClient.SqlConnection("Data Source=DESKTOP-5GRVG81\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True")
            conn.Open()
            query = "select * from dbo.ShopCust where username = '" & username.Text & "' and password = '" & password.Text & "';"
            cmd = New SqlClient.SqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read = False Then
                MessageBox.Show("Username not found. Please create an account")
            Else
                Items.Show()
            End If
            reader.Close()
        End If
    End Sub
End Class