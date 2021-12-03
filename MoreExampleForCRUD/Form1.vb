Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form1
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try


            con = New MySqlConnection()
            con.ConnectionString = "server=127.0.0.1; userid=root; password=12345; database=systemsample"
            cmd.Connection = con
            cmd.CommandText = "SELECT id FROM accounts WHERE username = @user and pass = @pass;"

            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = tbUsername.Text
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                MessageBox.Show("Login Success", "Welcome Back!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim MainForm As New frmMain
                MainForm.Show()
                Me.Close()

            End If




        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString)
        Finally
            cmd.Parameters.Clear()
            dt.Clear()

        End Try



    End Sub



End Class
