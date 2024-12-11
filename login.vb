Public Class login

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If uname.Text = "ADMIN123" And pass.Text = "ADMINPASS" Then
            Dim mainF As New mainForm(Me)
            mainF.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Credentials Try again")
        End If
    End Sub
End Class