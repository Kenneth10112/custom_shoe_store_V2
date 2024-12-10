Imports MySql.Data.MySqlClient

Public Class addAndUpdateMaterials

    Dim materialID As String
    Dim conn As MySqlConnection
    Dim mainForm As mainForm
    Dim method As String

    Public Sub New(matID As String, mtd As String, form1Conn As MySqlConnection, mf As mainForm)
        InitializeComponent()
        materialID = matID
        conn = form1Conn
        mainForm = mf
        Material_addModify_lbl_matID.Text = materialID
        method = mtd
    End Sub

    Private Sub addAndUpdateMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If method Is "add" Then
            addMaterial()
        ElseIf method Is "update" Then
            updateMaterial()
        End If
    End Sub

    Sub addMaterial()
        ' Validate inputs
        If txtb_name.Text.Trim() = "" Then
            MessageBox.Show("Invalid name, cannot be empty. Try again.")
            Return
        End If

        If cbo_partGroup.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a part group.")
            Return
        End If

        If Not IsAllNumbers(txtb_price.Text) OrElse txtb_price.Text.Trim() = "" OrElse Integer.Parse(txtb_price.Text) <= 0 Then
            MessageBox.Show("Invalid price, must be a positive number. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_stock.Text) OrElse txtb_stock.Text.Trim() = "" OrElse Integer.Parse(txtb_stock.Text) <= 0 Then
            MessageBox.Show("Invalid stock, must be a positive number. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_warning.Text) OrElse txtb_warning.Text.Trim() = "" OrElse Integer.Parse(txtb_warning.Text) <= 0 Then
            MessageBox.Show("Invalid warning amount, must be a positive number. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_critical.Text) OrElse txtb_critical.Text.Trim() = "" OrElse Integer.Parse(txtb_critical.Text) <= 0 Then
            MessageBox.Show("Invalid critical amount, must be a positive number. Try again.")
            Return
        End If

        If Integer.Parse(txtb_critical.Text) > Integer.Parse(txtb_warning.Text) Then
            MessageBox.Show("Invalid critical amount, it must be lower than to the warning amount. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_timesUsed.Text) OrElse txtb_timesUsed.Text.Trim() = "" OrElse Integer.Parse(txtb_timesUsed.Text) < 0 Then
            MessageBox.Show("Invalid usage index, must be a non-negative number. Try again.")
            Return
        End If

        ' Get validated inputs
        Dim name As String = txtb_name.Text.Trim()
        Dim part As String = cbo_partGroup.SelectedItem.ToString()
        Dim price As Integer = Integer.Parse(txtb_price.Text)
        Dim stock As Integer = Integer.Parse(txtb_stock.Text)
        Dim warning As Integer = Integer.Parse(txtb_warning.Text)
        Dim critical As Integer = Integer.Parse(txtb_critical.Text)
        Dim useIndex As Integer = Integer.Parse(txtb_timesUsed.Text)

        Try
            ' Define the insert query with placeholders
            Dim sqlQuery As String = $"INSERT INTO materials (material_name, part_group, price, stock, warning_amount, critical_amount, use_index)
                                   VALUES (@name, @part, @price, @stock, @warning, @critical, @useIndex);"

            ' Create a MySqlCommand
            Using cmd As New MySqlCommand(sqlQuery, conn)
                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@part", part)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@stock", stock)
                cmd.Parameters.AddWithValue("@warning", warning)
                cmd.Parameters.AddWithValue("@critical", critical)
                cmd.Parameters.AddWithValue("@useIndex", useIndex)

                ' Open the connection if closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the insert query
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("New material added successfully.")

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}{vbCrLf}{ex.StackTrace}")
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            mainForm.refresh()
            Dispose()

        End Try
    End Sub


    Sub updateMaterial()
        ' Validate inputs
        If txtb_name.Text.Trim() = "" Then
            MessageBox.Show("Invalid name, cannot be empty. Try again.")
            Return
        End If

        If cbo_partGroup.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a part group.")
            Return
        End If

        If Not IsAllNumbers(txtb_price.Text) OrElse txtb_price.Text.Trim() = "" OrElse Integer.Parse(txtb_price.Text) <= 0 Then
            MessageBox.Show("Invalid price, must be a positive number. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_stock.Text) OrElse txtb_stock.Text.Trim() = "" OrElse Integer.Parse(txtb_stock.Text) <= 0 Then
            MessageBox.Show("Invalid stock, must be a positive number. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_warning.Text) OrElse txtb_warning.Text.Trim() = "" OrElse Integer.Parse(txtb_warning.Text) <= 0 Then
            MessageBox.Show("Invalid warning amount, must be a positive number. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_critical.Text) OrElse txtb_critical.Text.Trim() = "" OrElse Integer.Parse(txtb_critical.Text) <= 0 Then
            MessageBox.Show("Invalid critical amount, must be a positive number. Try again.")
            Return
        End If

        If Integer.Parse(txtb_critical.Text) > Integer.Parse(txtb_warning.Text) Then
            MessageBox.Show("Invalid critical amount, it must be lower than to the warning amount. Try again.")
            Return
        End If

        If Not IsAllNumbers(txtb_timesUsed.Text) OrElse txtb_timesUsed.Text.Trim() = "" OrElse Integer.Parse(txtb_timesUsed.Text) < 0 Then
            MessageBox.Show("Invalid usage index, must be a non-negative number. Try again.")
            Return
        End If

        ' Get validated inputs
        Dim name As String = txtb_name.Text.Trim()
        Dim part As String = cbo_partGroup.SelectedItem.ToString()
        Dim price As Integer = Integer.Parse(txtb_price.Text)
        Dim stock As Integer = Integer.Parse(txtb_stock.Text)
        Dim warning As Integer = Integer.Parse(txtb_warning.Text)
        Dim critical As Integer = Integer.Parse(txtb_critical.Text)
        Dim useIndex As Integer = Integer.Parse(txtb_timesUsed.Text)

        Try
            ' Define the insert query with placeholders
            Dim sqlQuery As String = $"UPDATE materials
                               SET material_name = @name, 
                                   part_group = @part, 
                                   price = @price, 
                                   stock = @stock, 
                                   warning_amount = @warning, 
                                   critical_amount = @critical, 
                                   use_index = @useIndex
                               WHERE material_id = @matID;"

            ' Create a MySqlCommand
            Using cmd As New MySqlCommand(sqlQuery, conn)
                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@part", part)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@stock", stock)
                cmd.Parameters.AddWithValue("@warning", warning)
                cmd.Parameters.AddWithValue("@critical", critical)
                cmd.Parameters.AddWithValue("@useIndex", useIndex)
                cmd.Parameters.AddWithValue("@matID", materialID)

                ' Open the connection if closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the insert query
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Updated Material successfully.")

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}{vbCrLf}{ex.StackTrace}")
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            mainForm.refresh()
            Dispose()

        End Try

    End Sub
    '-------------------------BoilerPlates--------------------------------------------------------
    Public Function IsAllNumbers(input As String) As Boolean
        Return input.All(AddressOf Char.IsDigit)
    End Function


    Dim nameNotCleared As Boolean = True
    Private Sub txtb_name_Click(sender As Object, e As EventArgs) Handles txtb_name.Click
        If nameNotCleared Then
            txtb_name.Text = ""
            nameNotCleared = False
        End If
    End Sub

    Dim priceNotCleared As Boolean = True
    Private Sub txtb_price_Click(sender As Object, e As EventArgs) Handles txtb_price.Click
        If priceNotCleared Then
            txtb_price.Text = ""
            priceNotCleared = False
        End If
    End Sub

    Dim stockNotCleared As Boolean = True
    Private Sub txtb_stock_Click(sender As Object, e As EventArgs) Handles txtb_stock.Click
        If stockNotCleared Then
            txtb_stock.Text = ""
            stockNotCleared = False
        End If
    End Sub

    Dim warningNotCleared As Boolean = True
    Private Sub txtb_warning_Click(sender As Object, e As EventArgs) Handles txtb_warning.Click
        If warningNotCleared Then
            txtb_warning.Text = ""
            warningNotCleared = False
        End If
    End Sub

    Dim criticalNotCleared As Boolean = True
    Private Sub txtb_critical_Click(sender As Object, e As EventArgs) Handles txtb_critical.Click
        If criticalNotCleared Then
            txtb_critical.Text = ""
            criticalNotCleared = False
        End If
    End Sub

    Dim timeUsedNotCleared As Boolean = True
    Private Sub txtb_timesUsed_Click(sender As Object, e As EventArgs) Handles txtb_timesUsed.Click
        If timeUsedNotCleared Then
            txtb_timesUsed.Text = ""
            timeUsedNotCleared = False
        End If
    End Sub


End Class