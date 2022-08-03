Public Class SignUpForm

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "" Or password.Text = "" Or HouseNo.Text = "" Or StreetName.Text = "" Or Pincode.Text = "" Then
            MessageBox.Show("Please fill all details")
        Else
            conn = New SqlClient.SqlConnection("Data Source=DESKTOP-5GRVG81\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True")
            conn.Open()
            query = "select * from dbo.ShopCust where username = '" & username.Text & "';"
            cmd = New SqlClient.SqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read = False Then
                query = "insert into dbo.ShopCust values('" & username.Text & "','" & password.Text & "','" & HouseNo.Text & "','" & StreetName.Text & "','" & Pincode.Text & "');"
                cmd = New SqlClient.SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.Read = True Then
                    Items.Show()
                End If
            Else
                reader.Close()
                MessageBox.Show("Username already exists please change to another.")
            End If
            reader.Close()
        End If
    End Sub
End Class