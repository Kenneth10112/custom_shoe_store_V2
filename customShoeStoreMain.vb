Imports MySql.Data.MySqlClient
Imports sqlConnector

Public Class mainForm
    Dim sqlQuery As String
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable


    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'hide the main form tabControl
        mainTabControl.Appearance = TabAppearance.FlatButtons
        mainTabControl.ItemSize = New Size(0, 1)
        mainTabControl.SizeMode = TabSizeMode.Fixed

        sqlConnector.DbConnect()
        refresh()
    End Sub

    Sub populateDashboardOrders()
        Try
            ' For notStarted ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'not_started';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Orders_notStarted.DataSource = dt
                Dashboard_Orders_notStarted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Dashboard_Orders_notStarted.Rows.Count - 1
                Dashboard_Orders_lbl_notStarted.Text = $"Not Started: {totalRows}"


            End Using

            ' For inProgress ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'in_progress';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Orders_inProgress.DataSource = dt
                Dashboard_Orders_inProgress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Dashboard_Orders_inProgress.Rows.Count - 1
                Dashboard_Orders_lbl_inProgress.Text = $"In progress: {totalRows}"


            End Using

            ' For notStarted ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'finished';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Orders_finished.DataSource = dt
                Dashboard_Orders_finished.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Dashboard_Orders_finished.Rows.Count - 1
                Dashboard_Orders_lbl_finished.Text = $"Finished: {totalRows}"

            End Using

            ' For notStarted ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'outgoing';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Orders_outgoing.DataSource = dt
                Dashboard_Orders_outgoing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Dashboard_Orders_outgoing.Rows.Count - 1
                Dashboard_Orders_lbl_outgoing.Text = $"Outgoing: {totalRows}"

            End Using
        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub populateDashboardStocks()

        Try
            ' For critical ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT material_id, material_name, stock, warning_amount, critical_amount
                    FROM Materials
                    WHERE stock <= critical_amount;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Stocks_critical.DataSource = dt
                Dashboard_Stocks_critical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using
            ' For warning ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT material_id, material_name, stock, warning_amount, critical_amount
                    FROM Materials
                    WHERE stock <= warning_amount;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Stocks_warning.DataSource = dt
                Dashboard_Stocks_warning.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using
            ' For normal ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT material_id, material_name, stock, warning_amount, critical_amount
                    FROM Materials
                    WHERE stock > warning_amount;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Dashboard_Stocks_normal.DataSource = dt
                Dashboard_Stocks_normal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using
        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub populateDashboardSales()
        Try
            ' For sold amount ------------------------------------------------------------

            ' Define the SQL query to fetch the sold shoe amount
            sqlQuery = "SELECT sold_shoe_amount FROM sales"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Assuming there's only one row, get the first (and only) cell value
                    Dim soldAmount As Integer = Convert.ToInt32(dt.Rows(0)("sold_shoe_amount"))

                    Dashboard_Sales_soldProductCount.Text = soldAmount.ToString()
                End If
            End Using

            ' For sold amount ------------------------------------------------------------
            sqlQuery = "SELECT sale_total_amount FROM sales"
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Assuming there's only one row, get the first (and only) cell value
                    Dim soldAmount As Integer = Convert.ToInt32(dt.Rows(0)("sale_total_amount"))

                    Dashboard_Sales_totalSales.Text = soldAmount.ToString()
                End If
            End Using
        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub populateAccounts()
        Try
            ' For allAccounts ------------------------------------------------------------
            sqlQuery = "SELECT account_id, username, account_type
                        From accounts"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Accounts_allAccounts.DataSource = dt
                Accounts_allAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using

            ' For allAccounts ------------------------------------------------------------
            sqlQuery = "SELECT account_id, username, account_type
                        From accounts"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Accounts_allAccounts.DataSource = dt
                Accounts_allAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using

        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub populateAccounts_subParams(accountID As String)
        ' For accounts sub params ------------------------------------------------------------

        ' Define the SQL query to fetch the sold shoe amount
        sqlQuery = $"SELECT * FROM accounts WHERE account_id = {accountID}"

        ' Create a new data adapter with the query and connection
        Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Check if there are rows returned
            If dt.Rows.Count > 0 Then
                ' Get the first row
                Dim row As DataRow = dt.Rows(0)

                ' Retrieve data from all the specified columns
                Dim accountIDValue As String = row("account_id").ToString()
                Dim username As String = row("username").ToString()
                Dim password As String = row("pass").ToString()
                Dim accountType As String = row("account_type").ToString()
                Dim creationDate As String = row("creation_date").ToString()
                Dim address As String = row("address").ToString()
                Dim contactNumber As String = row("contact_number").ToString()
                Dim email As String = row("email").ToString()


                Account_lbl_accID.Text = accountIDValue
                Account_lbl_name.Text = username
                Account_lbl_pass.Text = password
                Account_lbl_role.Text = accountType
                Account_lbl_creationDate.Text = creationDate
                Account_lbl_address.Text = address
                Account_lbl_contactNum.Text = contactNumber
                Account_lbl_email.Text = email
            End If
        End Using
    End Sub

    Sub populateAccounts_subOrders(accountID As String)
        ' For allOrders ------------------------------------------------------------
        sqlQuery = $"SELECT *
                    FROM Orders
                    WHERE customer = {accountID};"

        ' Create a new data adapter with the query and connection
        Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Accounts_allOrders.DataSource = dt
            Accounts_allOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

            Dim totalRows As Integer = dt.Rows.Count
            Account_lbl_ordersCount.Text = totalRows

        End Using
    End Sub

    Sub populateOrders()
        Try
            ' For allOrders ------------------------------------------------------------
            sqlQuery = "SELECT * FROM orders"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Orders_allOrders.DataSource = dt
                Orders_allOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using


            ' For notStarted ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'not_started';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Orders_notStarted.DataSource = dt
                Orders_notStarted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


            End Using

            ' For inProgress ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'in_progress';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Orders_inProgress.DataSource = dt
                Orders_inProgress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


            End Using

            ' For notStarted ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'finished';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Orders_finished.DataSource = dt
                Orders_finished.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


            End Using

            ' For notStarted ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT o.order_id, a.username AS customer_name
                        FROM Orders o
                        JOIN Accounts a ON o.customer = a.account_id
                        WHERE o.process_status = 'outgoing';"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Orders_outgoing.DataSource = dt
                Orders_outgoing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


            End Using
        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub populateOrders_subParams(orderID As String)
        ' For accounts sub params ------------------------------------------------------------

        ' Define the SQL query to fetch the sold shoe amount
        sqlQuery = $"SELECT * FROM orders WHERE order_id = {orderID}"

        ' Create a new data adapter with the query and connection
        Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Check if there are rows returned
            If dt.Rows.Count > 0 Then
                ' Get the first row
                Dim row As DataRow = dt.Rows(0)

                ' Retrieve data from all the specified columns
                Dim orderIDValue As String = row("order_id").ToString()
                Dim customer As String = row("customer").ToString()
                Dim orderDetail As String = row("order_detail").ToString()
                Dim claimMethod As String = row("claim_method").ToString()
                Dim dueDate As String = row("due_date").ToString()
                Dim totalAmount As String = row("total_amount").ToString()
                Dim paymentStatus As String = row("payment_status").ToString()
                Dim processStatus As String = row("process_status").ToString()

                Orders_lbl_orderID.Text = $"Order ID: {orderIDValue}"
                Orders_lbl_customer.Text = $"Order Customer: {customer}"
                Orders_lbl_orderDetail.Text = $"Order Detail: {orderDetail}"
                Orders_lbl_claimMethod.Text = $"Order Claim Method: {claimMethod}"
                Orders_lbl_dueDate.Text = $"Order Due Date: {dueDate}"
                Orders_lbl_totalAmount.Text = $"Order Total Amount: {totalAmount}"
                Orders_lbl_paymentStatus.Text = $"Order payment status: {paymentStatus}"
                Orders_lbl_processStatus.Text = $"Order process status: {processStatus}"
            End If
        End Using
    End Sub

    Sub populateMaterials()
        Try
            ' For allMaterial ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT * FROM Materials;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Materials_allMaterials.DataSource = dt
                Materials_allMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using


            ' For critical ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT material_id, material_name, stock, warning_amount, critical_amount
                    FROM Materials
                    WHERE stock <= critical_amount;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Materials_critical.DataSource = dt
                Materials_critical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Materials_critical.Rows.Count - 1
                Material_lbl_criticalAmount.Text = $"{totalRows}"
            End Using
            ' For warning ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT material_id, material_name, stock, warning_amount, critical_amount
                    FROM Materials
                    WHERE stock <= warning_amount;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Materials_warning.DataSource = dt
                Materials_warning.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Materials_warning.Rows.Count - 1
                Material_lbl_warningAmount.Text = $"{totalRows}"
            End Using
            ' For normal ------------------------------------------------------------
            ' Define the SQL query to fetch data
            sqlQuery = "SELECT material_id, material_name, stock, warning_amount, critical_amount
                    FROM Materials
                    WHERE stock > warning_amount;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)
                Materials_normal.DataSource = dt
                Materials_normal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Dim totalRows As Integer = Materials_normal.Rows.Count - 1
                Material_lbl_normalAmount.Text = $"{totalRows}"
            End Using
        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub populateMaterialsStatistics()
        Try
            ' For Highest useIndex ------------------------------------------------------------
            ' Define the SQL query to fetch data 
            sqlQuery = "SELECT material_name 
                        FROM Materials
                        WHERE use_index = (SELECT MAX(use_index) FROM Materials);"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Get the first row
                    Dim row As DataRow = dt.Rows(0)

                    ' Retrieve data from all the specified columns
                    Dim highestUseIndex As String = row("material_name").ToString()

                    Material_lbl_mostUsed.Text = $"Most Used Material: {highestUseIndex}"
                End If
            End Using

            ' For lowest useIndex ------------------------------------------------------------
            ' Define the SQL query to fetch data 
            sqlQuery = "SELECT material_name 
                        FROM Materials
                        WHERE use_index = (SELECT MIN(use_index) FROM Materials);"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Get the first row
                    Dim row As DataRow = dt.Rows(0)

                    ' Retrieve data from all the specified columns
                    Dim lowestUseIndex As String = row("material_name").ToString()

                    Material_lbl_leastUsed.Text = $"Least Used Material: {lowestUseIndex}"
                End If
            End Using

            ' For Highest Price ------------------------------------------------------------
            ' Define the SQL query to fetch data 
            sqlQuery = "SELECT material_name 
                        FROM Materials
                        WHERE price = (SELECT MAX(price) FROM Materials);"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Get the first row
                    Dim row As DataRow = dt.Rows(0)

                    ' Retrieve data from all the specified columns
                    Dim highestPrice As String = row("material_name").ToString()

                    Material_lbl_highestPrice.Text = $"Most Expensive Material: {highestPrice}"
                End If
            End Using

            ' For Lowest Price ------------------------------------------------------------
            ' Define the SQL query to fetch data 
            sqlQuery = "SELECT material_name 
                        FROM Materials
                        WHERE price = (SELECT MIN(price) FROM Materials);"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Get the first row
                    Dim row As DataRow = dt.Rows(0)

                    ' Retrieve data from all the specified columns
                    Dim lowestPrice As String = row("material_name").ToString()

                    Material_lbl_lowestPrice.Text = $"Cheapest Material: {lowestPrice}"
                End If
            End Using

            ' For average Price ------------------------------------------------------------
            ' Define the SQL query to fetch data 
            sqlQuery = "SELECT AVG(price) AS average_price 
                        FROM Materials;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Get the first row
                    Dim row As DataRow = dt.Rows(0)

                    ' Retrieve data from all the specified columns
                    Dim avePrice As String = row("average_price").ToString()

                    Material_lbl_aveMatPrice.Text = $"Average Material price: {avePrice}"
                End If
            End Using


        Catch ex As Exception
            ' Show the error message in a message box
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Material_btn_addMaterial_Click(sender As Object, e As EventArgs) Handles Material_btn_addMaterial.Click
        Try
            ' For getting the latest MatID
            Dim latestMatID As Integer
            ' Define the SQL query to fetch the highest material ID
            sqlQuery = $"SELECT MAX(material_id) AS highest_material_id FROM materials;"

            ' Create a new data adapter with the query and connection
            Using da As New MySqlDataAdapter(sqlQuery, sqlConnector.conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Check if there are rows returned
                If dt.Rows.Count > 0 Then
                    ' Get the first row
                    Dim row As DataRow = dt.Rows(0)

                    ' Retrieve data from all the specified columns
                    Dim matIDValue As String = row("highest_material_id").ToString()

                    If Not String.IsNullOrEmpty(matIDValue) Then
                        latestMatID = Integer.Parse(matIDValue) + 1
                    Else
                        latestMatID = 1 ' Default if no rows exist
                    End If
                Else
                    latestMatID = 1 ' Default if table is empty
                End If
            End Using

            Dim addMaterial As New addAndUpdateMaterials(latestMatID, "add", sqlConnector.conn, Me)
            addMaterial.Show()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try


    End Sub

    Private Sub Material_btn_updateMaterial_Click(sender As Object, e As EventArgs) Handles Material_btn_updateMaterial.Click
        Dim materialID As String = Materials_allMaterials.CurrentRow.Cells("material_id").Value.ToString()

        Dim addMaterial As New addAndUpdateMaterials(materialID, "update", sqlConnector.conn, Me)
        addMaterial.Show()
    End Sub

    Private Sub Material_btn_deleteMaterial_Click(sender As Object, e As EventArgs) Handles Material_btn_deleteMaterial.Click
        Dim materialID As String = Materials_allMaterials.CurrentRow.Cells("material_id").Value.ToString()
        Dim materialName As String = Materials_allMaterials.CurrentRow.Cells("material_name").Value.ToString()


        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete{vbCrLf}MaterialID: {materialID} Material Name: {materialName}",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo)
        If Not confirmResult = DialogResult.Yes Then
            Return
        End If

        Try
            ' Define the delete query with a placeholder for the Material ID
            Dim sqlQuery As String = $"DELETE FROM materials WHERE material_id = @materialID;"

            Using cmd As New MySqlCommand(sqlQuery, sqlConnector.conn)
                cmd.Parameters.AddWithValue("@materialID", materialID)
                If sqlConnector.conn.State = ConnectionState.Closed Then
                    sqlConnector.conn.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Material deleted successfully.")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}{vbCrLf}{ex.StackTrace}")
        Finally
            ' Ensure the connection is closed
            If sqlConnector.conn.State = ConnectionState.Open Then
                sqlConnector.conn.Close()
            End If
            refresh()
        End Try
    End Sub
    Public Sub refresh()
        populateDashboardOrders()
        populateDashboardStocks()
        populateDashboardSales()
        populateAccounts()
        populateOrders()
        populateMaterials()
        populateMaterialsStatistics()
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
        Try
            If mainTabControl.SelectedIndex <> 2 Then
                mainTabControl.SelectedIndex = 2
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_Materials_Click(sender As Object, e As EventArgs) Handles btn_Materials.Click
        Try
            If mainTabControl.SelectedIndex <> 3 Then
                mainTabControl.SelectedIndex = 3
            End If
        Catch ex As Exception

        End Try
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




    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim login As New login()
            login.Show()

        Catch ex As Exception
            MessageBox.Show("An error occurred while opening Form2: " & ex.Message)

        End Try
    End Sub

    Private Sub Accounts_allAccounts_Click(sender As Object, e As EventArgs) Handles Accounts_allAccounts.Click
        If Accounts_allAccounts.CurrentRow IsNot Nothing Then
            ' Get the account_id from the selected row
            Dim accountID As String = Accounts_allAccounts.CurrentRow.Cells("account_id").Value.ToString()

            ' Display or use the account_id
            Dim totalRows As Integer = Accounts_allAccounts.Rows.Count
            Dim selectedRow As Integer = Accounts_allAccounts.CurrentRow.Index + 1
            If Not selectedRow = totalRows Then
                populateAccounts_subParams(accountID)
                populateAccounts_subOrders(accountID)
                Accounts_btn_editDetails.Visible = True
            Else
                Accounts_btn_editDetails.Visible = False
            End If

        End If
    End Sub

    Private Sub Accounts_btn_editDetails_Click(sender As Object, e As EventArgs) Handles Accounts_btn_editDetails.Click
        Dim editDetailsForm As New updateAccountDetails(Account_lbl_accID.Text, sqlConnector.conn, Me)
        editDetailsForm.Show()
    End Sub



    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh()
    End Sub

    Private Sub Orders_allOrders_Click(sender As Object, e As EventArgs) Handles Orders_allOrders.Click
        If Orders_allOrders.CurrentRow IsNot Nothing Then
            ' Get the account_id from the selected row
            Dim orderID As String = Orders_allOrders.CurrentRow.Cells("order_id").Value.ToString()

            ' Display or use the account_id
            Dim totalRows As Integer = Orders_allOrders.Rows.Count
            Dim selectedRow As Integer = Orders_allOrders.CurrentRow.Index + 1
            If Not selectedRow = totalRows Then
                populateOrders_subParams(orderID)
            End If

        End If
    End Sub

    Private Sub Orders_to_inProgress_Click(sender As Object, e As EventArgs) Handles Orders_to_inProgress.Click
        changeOrderProcessStatus(Orders_notStarted, "in_progress")
    End Sub

    Private Sub Orders_to_finished_Click(sender As Object, e As EventArgs) Handles Orders_to_finished.Click
        changeOrderProcessStatus(Orders_inProgress, "finished")
    End Sub

    Private Sub Orders_finish_to_outgoing_Click(sender As Object, e As EventArgs) Handles Orders_finish_to_outgoing.Click
        changeOrderProcessStatus(Orders_finished, "outgoing")
    End Sub

    Private Sub Orders_finish_to_settled_Click(sender As Object, e As EventArgs) Handles Orders_finish_to_settled.Click
    End Sub

    Private Sub Orders_outgoing_to_settled_Click(sender As Object, e As EventArgs) Handles Orders_outgoing_to_settled.Click

    End Sub

    Sub changeOrderProcessStatus(fromTable As DataGridView, toProcStat As String)
        Dim orderID As String = fromTable.CurrentRow.Cells("order_id").Value.ToString()

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to change{vbCrLf}orderID:{orderID}'s process status to {toProcStat}",
                                                        "Confirm transfer",
                                                        MessageBoxButtons.YesNo)
        If Not confirmResult = DialogResult.Yes Then
            Return
        End If

        Try
            Dim sqlQuery As String = $"UPDATE orders
                                       SET process_status = @processStatus
                                       WHERE order_id = @orderID;"

            ' Create a MySqlCommand
            Using cmd As New MySqlCommand(sqlQuery, sqlConnector.conn)
                cmd.Parameters.AddWithValue("@processStatus", toProcStat)
                cmd.Parameters.AddWithValue("@orderID", orderID)

                If sqlConnector.conn.State = ConnectionState.Closed Then
                    sqlConnector.conn.Open()
                End If

                ' Execute the insert query
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}{vbCrLf}{ex.StackTrace}")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            refresh()


        End Try
    End Sub
End Class
