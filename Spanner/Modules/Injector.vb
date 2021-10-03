Imports System.IO

Namespace App

    Public Class Injector

        Public config

        Public Sub New()
            ' Set the default configuration
            config = New Dictionary(Of String, Object) From {
                {"db_path", "database.db"}
            }

            ' Check if there is a database in the default location
            If Not File.Exists(config("db_path")) Then
                ' If not, get the user to select a database
                MsgBox("Database not found. Please find the database file")

                ' Setup File Dialog
                Dim dlg As OpenFileDialog = New OpenFileDialog

                dlg.Filter = "Database (*.db)|*.db|All Files (*.*)|*.*"

                ' Open dialog to select file
                If dlg.ShowDialog() = DialogResult.OK Then
                    ' If OK selected, open file
                    config("db_path") = dlg.FileName
                Else
                    ' If not, close
                    Application.Exit()
                    End
                End If
            End If

            ' Create a session instance
            Session = New App.Session(Authentication)

        End Sub

        ' All of the other application services

        ReadOnly Property ACL() As App.AccessControlLayer
            Get
                Return New App.AccessControlLayer(DB, Membership)
            End Get
        End Property

        ReadOnly Property Authentication() As App.Authentication
            Get
                Return New App.Authentication(DB, Hasher)
            End Get
        End Property

        ReadOnly Property DB() As App.Database
            Get
                Return New App.Database(config)
            End Get
        End Property

        ReadOnly Property Forms() As App.Forms
            Get
                Return New App.Forms(Session)
            End Get
        End Property

        ReadOnly Property Hasher() As BCrypt.Net.BCrypt
            Get
                Return New BCrypt.Net.BCrypt()
            End Get
        End Property

        ReadOnly Property Membership() As App.Membership
            Get
                Return New App.Membership(DB)
            End Get
        End Property

        ReadOnly Property Payments() As App.Payments
            Get
                Return New App.Payments(DB)
            End Get
        End Property

        ReadOnly Property Results() As App.Results
            Get
                Return New App.Results(DB)
            End Get
        End Property

        Public Session As App.Session

    End Class

End Namespace