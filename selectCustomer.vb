Imports MySql.Data.MySqlClient

Public Class selectCustomer
    Dim sqlQuery As String
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable

    Dim conn As MySqlConnection
    Dim mainform As mainForm

    Sub New(form1Conn As MySqlConnection, mf As mainForm)

        ' This call is required by the designer.
        InitializeComponent()
        conn = form1Conn
        mainform = mf
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub selectCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateAccounts()
    End Sub

    Sub populateAccounts()
        Try
            ' For allAccounts ------------------------------------------------------------
            sqlQuery = "SELECT * From accounts"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Accounts.DataSource = dt
                Accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using

        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtb_input_TextChanged(sender As Object, e As EventArgs) Handles txtb_input.TextChanged
        If txtb_input.Text = "" Then
            populateAccounts()
            Return
        End If

        ' Validation: Check if no sort method is selected
        If cbo_sortBy.SelectedItem Is Nothing Then
            MessageBox.Show("No item is selected. Select sort method first")
            txtb_input.Text = ""
            Return
        End If

        Try
            ' Construct the SQL query with a dynamic column and parameterized LIKE conditions
            sqlQuery = $"SELECT * FROM accounts 
                WHERE {cbo_sortBy.SelectedItem.ToString()} LIKE @inputPattern1
                OR {cbo_sortBy.SelectedItem.ToString()} LIKE @inputPattern2
                OR {cbo_sortBy.SelectedItem.ToString()} LIKE @inputPattern3"

            ' Create a new MySQL command with the query and connection
            Using cmd As New MySqlCommand(sqlQuery, sqlConnector.conn)

                ' Add parameters for LIKE patterns with wildcards
                cmd.Parameters.AddWithValue("@inputPattern1", "%" & txtb_input.Text & "%")  ' '%input%'
                cmd.Parameters.AddWithValue("@inputPattern2", txtb_input.Text & "%")        ' 'input%'
                cmd.Parameters.AddWithValue("@inputPattern3", "%" & txtb_input.Text)        ' '%input'

                ' Open the connection if it's closed
                If sqlConnector.conn.State = ConnectionState.Closed Then
                    sqlConnector.conn.Open()
                End If

                ' Execute the query and get the results using ExecuteReader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Fill the DataTable with the data retrieved from the reader
                    Dim dt As New DataTable
                    dt.Load(reader)

                    ' Set the DataSource of the DataGridView
                    Accounts.DataSource = dt
                    Accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                End Using
            End Using

        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Always close the connection after use
            If sqlConnector.conn.State = ConnectionState.Open Then
                sqlConnector.conn.Close()
            End If
        End Try

    End Sub


    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        If Accounts.CurrentRow IsNot Nothing Then
            Dim totalRows As Integer = Accounts.Rows.Count
            Dim selectedRow As Integer = Accounts.CurrentRow.Index + 1
            If Not selectedRow = totalRows Then
                Dim selectedRowID As String = Accounts.CurrentRow.Cells("account_id").Value.ToString()
                Dim selectedRowName As String = Accounts.CurrentRow.Cells("username").Value.ToString()
                mainform.CustomizeShoe_selectCustomer(selectedRowID, selectedRowName)
                Dispose()
            Else
                MessageBox.Show("select a Valid row first!")
            End If

        End If

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dispose()

    End Sub
End Class