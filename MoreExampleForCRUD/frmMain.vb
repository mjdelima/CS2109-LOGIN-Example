Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Returning to Login Page", "Exiting", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim login As Form1 = New Form1
        login.Show()
        Me.Close()

    End Sub
End Class