Imports System.Data.SQLite

Namespace App
    ' This service handles any of the interaction with the database
    Public Class Database
        ' The SQLite connection object
        Public Connection As SQLiteConnection

        ' The configuration of the database
        Public config

        Public Sub New(config As Dictionary(Of String, Object))
            ' Set the database URL
            changeDatabase(config("db_path"))
        End Sub

        ' changeDatabase
        ' Change the URL of the database file
        '
        ' String url - the url to change to
        Private Sub changeDatabase(url As String)
            ' Setup connection string
            Dim settings As String = "Data Source=" + url

            ' Use try block as there are likely to be errors when opening the database
            Try
                ' Create connection object
                Connection = New SQLiteConnection(settings)
                Connection.Open()
                Connection.Close()
            Catch ex As Exception
                ' Inform user if there is an error
                MsgBox("There was an error connecting to the database " + ex.Message, vbOKOnly, "Can't open database")
                Application.Exit()
                End
            End Try

        End Sub

        ' getQuery
        ' Run a query on the database
        '
        ' String SQL - The SQL query to run
        '
        ' Returns the query as a DataTable

        Public Function getQuery(SQL As String) As DataTable

            ' Check the database is loaded
            If Connection Is Nothing Then
                Throw New Exception("Database is closed")
            End If

            ' Open the database connection
            Connection.Open()

            ' Create the command
            Dim cmd = New SQLiteCommand
            cmd.Connection = Connection
            cmd.CommandText = SQL

            ' Load the data from the database
            Dim reader As SQLiteDataReader = cmd.ExecuteReader
            Dim table As DataTable = New DataTable()

            ' Load the table
            table.Load(reader)

            ' Close everything
            reader.Close()
            Connection.Close()

            ' Return the query
            Return table

        End Function

        ' getRecord
        ' Get a specific record from a table
        '
        ' String  tableName - The name of the table to query
        ' Integer id        - The id of the record to fetch
        '
        ' Returns a DataRow
        Public Function getRecord(tableName As String, id As Integer) As DataRow

            ' Check the database is loaded
            If Connection Is Nothing Then
                Throw New Exception("Database is closed")
            End If

            ' Open the database connection
            Connection.Open()

            ' Generate the SQL
            Dim SQL As String = "SELECT * FROM " + tableName + " WHERE id = @id"
            Dim cmd As SQLiteCommand = New SQLiteCommand()
            cmd.Connection = Connection
            cmd.CommandText = SQL
            cmd.Parameters.AddWithValue("id", id)

            ' Load the data from the database
            Dim reader As SQLiteDataReader = cmd.ExecuteReader
            Dim table As DataTable = New DataTable()

            ' Load the table
            table.Load(reader)

            ' Close everything
            reader.Close()
            Connection.Close()

            ' Return Nothing if there are no returned rows
            If table.Rows.Count = 0 Then
                Return Nothing
            End If

            ' Return the first record if one is found
            Return table.Rows(0)
        End Function


        ' edit
        ' Will edit a specific record
        '
        ' String                        tableName - The name of the table to edit
        ' Integer                       id        - The id of the record to edit
        ' Dictionary(Of String, Object) data      - the data to amment (Field Name, Field Value)
        Public Sub edit(tableName As String, id As Integer, data As Dictionary(Of String, Object))

            ' Check the database is loaded
            If Connection Is Nothing Then
                Throw New Exception("Database is closed")
            End If

            ' Open the database connection
            Connection.Open()

            Dim SQL As String = ""

            ' Loop through each of the columns
            For Each column In data
                ' Add a comma if not the first
                If Not SQL = "" Then
                    SQL += ", "
                End If

                SQL += column.Key + " = @" + column.Key

            Next

            ' Sort out the rest of the SQL
            SQL = "UPDATE " + tableName + " SET " + SQL + " WHERE id = " + id.ToString

            ' Create the command
            Dim cmd = New SQLiteCommand
            cmd.Connection = Connection
            cmd.CommandText = SQL

            ' Add parameters
            For Each column In data
                cmd.Parameters.AddWithValue(column.Key, column.Value)
            Next

            cmd.ExecuteScalar()

            Connection.Close()
        End Sub

        ' insert
        ' Insert a new record into a table
        '
        ' String                        tableName - The name of the table to insert into
        ' Dictionary(Of String, Object) data      - the data to insert (Field Name, Field Value)
        '
        ' Returns the id of the new record
        Public Function insert(tableName As String, data As Dictionary(Of String, Object)) As Integer
            Dim Cols, Values As String
            Cols = ""
            Values = ""

            ' Generate the column SQL and the Values SQL (As Parameters)
            For Each column In data
                ' If string not empty, add comma
                If Cols <> "" Then
                    Cols += ", "
                End If
                ' If string not empty, add comma
                If Values <> "" Then
                    Values += ", "
                End If
                ' Add the column and value parameter
                Cols += column.Key
                Values += "@" + column.Key
            Next

            ' Check the database is loaded
            If Connection Is Nothing Then
                Throw New Exception("Database is closed")
            End If

            ' Open the database connection
            Connection.Open()

            ' Create the command
            Dim cmd As SQLiteCommand = New SQLiteCommand()
            cmd.CommandText = "INSERT INTO " + tableName + "(" + Cols + ") VALUES (" + Values + ")"
            cmd.Connection = Connection

            ' Add the values by the parameters
            For Each column In data
                cmd.Parameters.AddWithValue(column.Key, column.Value)
            Next

            ' Execute SQL
            cmd.ExecuteScalar()

            ' Fetch the id of the record
            cmd.CommandText = "select last_insert_rowid()"
            Dim id = cmd.ExecuteScalar()
            Connection.Close()

            Return id

        End Function

        ' arrayToString
        ' Convert an array to an SQL array
        '
        ' Object items() - The array to convert
        ' String type    - The type of the values 'string' or ''
        '
        ' Returns the array as an SQL array

        Public Function arrayToString(items() As Object, type As String) As String
            Dim result = "["

            For Each item In items
                ' If not an empty array, add a comma
                If Not result = "[" Then
                    result += ","
                End If
                ' If a string, add item with quotes
                If type = "string" Then
                    result += """" + item + """"
                Else
                    ' if not, add with no quoteds
                    result += item.ToString()
                End If
            Next
            ' Return SQL array
            Return result + "]"
        End Function

        ' delete
        ' Delete a record from the database
        '
        ' String  tableName - The table to delete the record from
        ' Integer id        - The id of the record to delete
        ' String  idKey     - The name of the field name to use as the id field
        Public Function delete(tableName As String, id As Integer, Optional idKey As String = "id")
            ' Check the database is loaded
            If Connection Is Nothing Then
                Throw New Exception("Database is closed")
            End If

            ' Open the database connection
            Connection.Open()

            ' Generate the SQL
            Dim SQL = "DELETE FROM " + tableName + " WHERE " + idKey + " = " + id.ToString()

            ' Execute the command
            Dim cmd = New SQLiteCommand
            cmd.Connection = Connection
            cmd.CommandText = SQL

            cmd.ExecuteScalar()

            Connection.Close()

            Return True

        End Function

    End Class

End Namespace