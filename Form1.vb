Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'hide the main form tabControl
        mainTabControl.Appearance = TabAppearance.FlatButtons
        mainTabControl.ItemSize = New Size(0, 1)
        mainTabControl.SizeMode = TabSizeMode.Fixed
    End Sub




    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        Try
            If mainTabControl.SelectedIndex <> 0 Then
                mainTabControl.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_logs_Click(sender As Object, e As EventArgs) Handles btn_logs.Click

    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

    End Sub

    Private Sub btn_Accounts_Click(sender As Object, e As EventArgs) Handles btn_Accounts.Click
        Try
            If mainTabControl.SelectedIndex <> 1 Then
                mainTabControl.SelectedIndex = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_CustomizeShoe_Click(sender As Object, e As EventArgs) Handles btn_CustomizeShoe.Click

    End Sub

    Private Sub btn_Materials_Click(sender As Object, e As EventArgs) Handles btn_Materials.Click

    End Sub

    Private Sub btn_Orders_Click(sender As Object, e As EventArgs) Handles btn_Orders.Click

    End Sub


End Class
