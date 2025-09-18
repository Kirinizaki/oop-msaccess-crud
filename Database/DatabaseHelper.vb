Imports System.Data.OleDb
Imports System.IO

Public Class DatabaseHelper
    ' 🔹 Build path to DB relative to project
    Private Shared dbPath As String = Path.Combine(Application.StartupPath, "..\..\..\data\registration.accdb")
    Private Shared con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";")
    Private Shared cmd As OleDbCommand

    ' === ADD RECORD ===
    Public Shared Function AddRecord(lastName As String, firstName As String,
                                     gender As String, nationality As String,
                                     contactNo As String, address As String,
                                     Optional middleName As String = "",
                                     Optional suffix As String = "",
                                     Optional birthDate As Date = #1/1/1900#,
                                     Optional civilStatus As String = "") As Integer

        Dim newID As Integer = -1
        Try
            con.Open()

            Dim sql As String = "INSERT INTO Registration 
            ([LastName], [FirstName], [MiddleName], [Suffix], [BirthDate], 
             [Gender], [CivilStatus], [Nationality], [ContactNo], [Address]) 
            VALUES (@LastName, @FirstName, @MiddleName, @Suffix, @BirthDate, 
                    @Gender, @CivilStatus, @Nationality, @ContactNo, @Address)"

            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@LastName", lastName)
            cmd.Parameters.AddWithValue("@FirstName", firstName)
            cmd.Parameters.AddWithValue("@MiddleName", middleName)
            cmd.Parameters.AddWithValue("@Suffix", suffix)
            cmd.Parameters.AddWithValue("@BirthDate", birthDate)
            cmd.Parameters.AddWithValue("@Gender", gender)
            cmd.Parameters.AddWithValue("@CivilStatus", civilStatus)
            cmd.Parameters.AddWithValue("@Nationality", nationality)
            cmd.Parameters.AddWithValue("@ContactNo", contactNo)
            cmd.Parameters.AddWithValue("@Address", address)

            cmd.ExecuteNonQuery()

            ' Get last inserted ID
            cmd = New OleDbCommand("SELECT @@IDENTITY", con)
            newID = Convert.ToInt32(cmd.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show("Add Error: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return newID
    End Function

    ' === DELETE RECORDS ===
    Public Shared Function DeleteRecordByID(id As Integer) As Boolean
        Try
            con.Open()
            Dim sql As String = "DELETE FROM Registration WHERE [ID] = @ID"
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@ID", id)

            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MessageBox.Show("Delete Error (ByID): " & ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Shared Function DeleteRecordByName(lastName As String, firstName As String) As Boolean
        Try
            con.Open()
            Dim sql As String = "DELETE FROM Registration WHERE [LastName] = @LastName AND [FirstName] = @FirstName"
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@LastName", lastName)
            cmd.Parameters.AddWithValue("@FirstName", firstName)

            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MessageBox.Show("Delete Error (ByName): " & ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
End Class
