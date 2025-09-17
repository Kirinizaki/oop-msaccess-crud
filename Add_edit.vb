Imports System.Data.OleDb
Imports System.IO

Public Class Add_edit
    Dim con As OleDbConnection
    Private Sub Add_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\data\registration.accdb")

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";")
        Try
            con.Open()
            MessageBox.Show("Connected to Access!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class