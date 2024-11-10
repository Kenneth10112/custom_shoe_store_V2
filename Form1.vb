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
        Try
            If mainTabControl.SelectedIndex <> 4 Then
                mainTabControl.SelectedIndex = 4
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_logs_Click(sender As Object, e As EventArgs) Handles btn_logs.Click
        Try
            If mainTabControl.SelectedIndex <> 5 Then
                mainTabControl.SelectedIndex = 5
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Try
            Dim login As New login()
            login.Show()

        Catch ex As Exception
            MessageBox.Show("An error occurred while opening Form2: " & ex.Message)

        End Try

    End Sub

    Private Sub cbox_modify_accountDetails_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_modify_accountDetails.CheckedChanged
        If cbox_modify_accountDetails.Checked Then
            panel_modifying_account_elements.Visible = True
        Else
            panel_modifying_account_elements.Visible = False
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
