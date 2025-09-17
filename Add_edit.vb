Imports System.Data.OleDb

Public Class Add_edit
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/;")

    Private Sub Add_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            MessageBox.Show("Connected to Access!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class