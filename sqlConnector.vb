Imports MySql.Data.MySqlClient
Module sqlConnector
    Public conn As New MySqlConnection
    Public Sub DbConnect()

        Dim dbName As String = "customshoestore_oop"
        Dim username As String = "root"
        Dim passwword As String = "password"
        Dim server As String = "127.0.0.1"

        If Not conn Is Nothing Then
            conn.Close()
            conn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & passwword & ";database=" & dbName & ""

            Try
                conn.Open()
                MsgBox("Da blu tot is a naw cunnictid suksispully")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Module