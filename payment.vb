Imports MySql.Data.MySqlClient

Public Class payment

    Dim needToPay As Integer
    Dim mainform As mainForm
    Dim orderID As String
    Sub New(oid As String, amount As Integer, mf As mainForm)

        ' This call is required by the designer.
        InitializeComponent()
        needToPay = amount
        mainform = mf
        orderID = oid
        Amount_To_be_paid.Text = $"Amount to be Paid: {needToPay}"
    End Sub
    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        If IsNumeric(TextBox1.Text) Then
            If Integer.Parse(TextBox1.Text) >= needToPay Then
                MessageBox.Show($"Payment successful{vbCrLf}Change: {Integer.Parse(TextBox1.Text) - needToPay}")
                deleteOrder()
                Dispose()
                mainform.refresh()

            Else
                MessageBox.Show("Payment Amount Insufficient.")
                Return
            End If
        Else
            MessageBox.Show("Invalid amount input, must be numerical.")
            Return
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dispose()

    End Sub

    Sub deleteOrder()
        Try
            ' Define the delete query with a placeholder for the order_id
            Dim sqlQuery As String = $"DELETE FROM orders WHERE order_id = @orderID;"

            Using cmd As New MySqlCommand(sqlQuery, sqlConnector.conn)
                cmd.Parameters.AddWithValue("@orderID", orderID)

                ' Open the connection if it's closed
                If sqlConnector.conn.State = ConnectionState.Closed Then
                    sqlConnector.conn.Open()
                End If

                ' Execute the delete query
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Order Transfered to settled.")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}{vbCrLf}{ex.StackTrace}")
        Finally
            ' Ensure the connection is closed
            If sqlConnector.conn.State = ConnectionState.Open Then
                sqlConnector.conn.Close()
            End If
            ' Call refresh to update the display or perform any necessary actions
            Refresh()
        End Try
    End Sub

End Class