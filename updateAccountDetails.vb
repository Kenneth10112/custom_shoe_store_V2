Imports MySql.Data.MySqlClient
Public Class updateAccountDetails

    Dim accountID As String
    Dim conn As MySqlConnection
    Dim mainForm As mainForm

    Public Sub New(accID As String, form1Conn As MySqlConnection, mf As mainForm)
        InitializeComponent()
        accountID = accID
        conn = form1Conn
        mainForm = mf
        Account_modify_lbl_accID.Text = accountID
    End Sub

    Private Sub updateAccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Update the accounts table based on account_id
        If Not isValidUsername(txtb_newName.Text) Then
            MessageBox.Show("Username Already Exist! try again")
            Return
        End If

        If cbo_newRole.SelectedItem Is Nothing Then
            MessageBox.Show("Select a role first! try again")
            Return
        End If

        If txtb_newAddress Is "" Then
            MessageBox.Show("Address is empty! try again")
            Return
        End If

        If Not isValidPhoneNumber(txtb_newNumber.Text) Then
            MessageBox.Show($"Phone Number is invalid!{vbCrLf}(Only accepts ph phoneNumber){vbCrLf}try again")
            Return
        End If

        If Not isValidEmail(txtb_newEmail.Text) Then
            MessageBox.Show("Email is invalid! try again")
            Return
        End If

        If txtb_newPass.Text Is "" Then
            MessageBox.Show("password is empty! try again")
            Return
        End If

        Dim newUsername As String = txtb_newName.Text
        Dim newAccountType As String = cbo_newRole.SelectedItem.ToString()
        Dim newAddress As String = txtb_newAddress.Text
        Dim newContactNumber As String = txtb_newNumber.Text
        Dim newEmail As String = txtb_newEmail.Text
        Dim newPassword As String = txtb_newPass.Text


        Try
            ' Define the update query with placeholders
            Dim sqlQuery As String = $"UPDATE accounts
                                       SET 
                                          username = @username,
                                          pass = @password,
                                          account_type = @accountType,
                                          address = @address,
                                          contact_number = @contactNumber,
                                          email = @Email
                                      WHERE account_id = @AccID;"

            ' Create a MySqlCommand
            Using cmd As New MySqlCommand(sqlQuery, conn)
                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", newUsername)
                cmd.Parameters.AddWithValue("@password", newPassword)
                cmd.Parameters.AddWithValue("@accountType", newAccountType)
                cmd.Parameters.AddWithValue("@address", newAddress)
                cmd.Parameters.AddWithValue("@contactNumber", newContactNumber)
                cmd.Parameters.AddWithValue("@Email", newEmail)
                cmd.Parameters.AddWithValue("@AccID", accountID)


                ' Open the connection
                conn.Open()

                ' Execute the update query
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
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
    Public Function isValidUsername(username As String) As Boolean
        ' Declare a variable to store the query result
        Dim usernameExists As Boolean = False

        ' Define the SQL query to check if the username exists
        Dim sqlQuery As String = "SELECT COUNT(*) FROM accounts WHERE username = @username"

        ' Use a Try-Catch block to handle any potential exceptions
        Try
            ' Open the database connection
            Using sqlCommand As New MySqlCommand(sqlQuery, sqlConnector.conn)
                ' Add the parameter to prevent SQL injection
                sqlCommand.Parameters.AddWithValue("@username", username)

                ' Open the connection if it is not already open
                If sqlConnector.conn.State = ConnectionState.Closed Then
                    sqlConnector.conn.Open()
                End If

                ' Execute the query and check if the username exists
                Dim result As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar())
                usernameExists = (result > 0)
            End Using
        Catch ex As Exception
            ' Handle exceptions (optional: log the error or show a message)
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Close the connection
            If sqlConnector.conn.State = ConnectionState.Open Then
                sqlConnector.conn.Close()
            End If
        End Try

        ' Return False if the username exists, otherwise True
        Return Not usernameExists
    End Function

    Public Function isValidPhoneNumber(phoneNumber As String) As Boolean
        ' Define the pattern for a valid Philippine phone number
        Dim pattern As String = "^(09\d{9}|(\+639)\d{9})$"

        ' Use Regex to check if the phone number matches the pattern
        Dim regex As New System.Text.RegularExpressions.Regex(pattern)
        Return regex.IsMatch(phoneNumber)
    End Function

    Public Function isValidEmail(email As String) As Boolean
        ' Define a regular expression for a valid Gmail email format
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@gmail\.com$"
        Dim regex As New System.Text.RegularExpressions.Regex(emailPattern)

        ' Check if the email matches the pattern
        If regex.IsMatch(email) Then
            Return True ' Email is valid and a Gmail account
        Else
            Return False ' Email is invalid or not a Gmail account
        End If
    End Function


    Dim nameNotCleared As Boolean = True
    Private Sub txtb_newName_Click(sender As Object, e As EventArgs) Handles txtb_newName.Click
        If nameNotCleared Then
            txtb_newName.Text = ""
            nameNotCleared = False
        End If
    End Sub

    Dim passNotCleared As Boolean = True
    Private Sub txtb_newPass_Click(sender As Object, e As EventArgs) Handles txtb_newPass.Click
        If passNotCleared Then
            txtb_newPass.Text = ""
            passNotCleared = False
        End If
    End Sub

    Dim numberNotCleared As Boolean = True
    Private Sub txtb_newNumber_Click(sender As Object, e As EventArgs) Handles txtb_newNumber.Click
        If numberNotCleared Then
            txtb_newNumber.Text = ""
            numberNotCleared = False
        End If
    End Sub

    Dim emailNotCleared As Boolean = True
    Private Sub txtb_newEmail_Click(sender As Object, e As EventArgs) Handles txtb_newEmail.Click
        If emailNotCleared Then
            txtb_newEmail.Text = ""
            emailNotCleared = False
        End If
    End Sub

    Dim addressNotCleared As Boolean = True
    Private Sub txtb_newAddress_Click(sender As Object, e As EventArgs) Handles txtb_newAddress.Click
        If addressNotCleared Then
            txtb_newAddress.Text = ""
            addressNotCleared = False
        End If
    End Sub


End Class