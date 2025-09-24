Imports oop_msaccess_crud.DatabaseHelper

Public Class HomePage
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGrid()
        ConfigureDataGrid()
    End Sub

    Private Sub ConfigureDataGrid()
        ' Configure DataGridView appearance and behavior
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False

            ' Use default system colors
            .EnableHeadersVisualStyles = True
            .ColumnHeadersHeight = 23
            .RowTemplate.Height = 22

            ' Default system selection and cell styles
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25F)
            .DefaultCellStyle.BackColor = SystemColors.Window
            .DefaultCellStyle.ForeColor = SystemColors.ControlText
            .DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
            .DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
        End With
    End Sub

    Private Sub RefreshDataGrid()
        Try
            Dim allRecords = DatabaseHelper.GetAllRecords()

            ' Create a simplified display list with only essential info
            Dim displayList = allRecords.Select(Function(r) New With {
                Key .ID = r.ID,
                Key .FullName = r.FullName,
                Key .Age = r.Age,
                Key .ContactInfo = r.ContactInfo
            }).ToList()

            DataGridView1.DataSource = displayList

            ' Customize column headers and widths
            If DataGridView1.Columns.Count > 0 Then
                DataGridView1.Columns("ID").Visible = False ' Hide ID column
                DataGridView1.Columns("FullName").HeaderText = "Full Name"
                DataGridView1.Columns("Age").HeaderText = "Age"
                DataGridView1.Columns("ContactInfo").HeaderText = "Contact"

                ' Set column widths
                DataGridView1.Columns("FullName").FillWeight = 50
                DataGridView1.Columns("Age").FillWeight = 15
                DataGridView1.Columns("ContactInfo").FillWeight = 35
            End If

            ' Update record count display
            Me.Text = $"Registration System - {allRecords.Count} Records"

        Catch ex As Exception
            MessageBox.Show($"Error refreshing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ShowSelectedRecordDetails()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Show details when single-clicking a row (you can comment this out if you only want double-click)
        If e.RowIndex >= 0 Then
            ShowSelectedRecordDetails()
        End If
    End Sub

    Private Sub ShowSelectedRecordDetails()
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow = DataGridView1.SelectedRows(0)
                Dim id As Integer = CInt(selectedRow.Cells("ID").Value)

                ' Get the full record from database
                Dim record = DatabaseHelper.GetRecordById(id)

                If record IsNot Nothing Then
                    ' Show detailed information form
                    Dim detailForm As New RecordDetailForm(record)
                    detailForm.ShowDialog() ' Use ShowDialog to make it modal
                Else
                    MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show($"Error showing record details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        'Go to Add Form'
        Dim addForm As New Add_edit()
        addForm.Show()
        Me.Hide()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshDataGrid()
        MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Edit button click
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow = DataGridView1.SelectedRows(0)
                Dim id As Integer = CInt(selectedRow.Cells("ID").Value)

                Dim recordToEdit = DatabaseHelper.GetRecordById(id)

                If recordToEdit IsNot Nothing Then
                    Dim editForm As New Add_edit(recordToEdit)
                    editForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a record to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Delete button click
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow = DataGridView1.SelectedRows(0)
                Dim id As Integer = CInt(selectedRow.Cells("ID").Value)
                Dim name As String = selectedRow.Cells("FullName").Value.ToString()

                Dim result = MessageBox.Show($"Are you sure you want to delete the record for {name}?{vbCrLf}{vbCrLf}This action cannot be undone.",
                                           "Confirm Delete",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    If DatabaseHelper.DeleteRecord(id) Then
                        RefreshDataGrid()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a record to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub HomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the application when main form closes
        Application.Exit()
    End Sub

    ' Add keyboard shortcuts
    Private Sub HomePage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                RefreshDataGrid()
            Case Keys.Delete
                If Btn_Delete.Enabled Then Btn_Delete_Click(Nothing, Nothing)
            Case Keys.Enter
                If DataGridView1.SelectedRows.Count > 0 Then
                    ShowSelectedRecordDetails()
                End If
            Case Keys.Insert
                NewButton_Click(Nothing, Nothing)
        End Select
    End Sub

    ' Add search functionality (optional)
    Private Sub SearchRecords(searchTerm As String)
        Try
            Dim searchResults = If(String.IsNullOrWhiteSpace(searchTerm),
                                 DatabaseHelper.GetAllRecords(),
                                 DatabaseHelper.SearchRecords(searchTerm))

            Dim displayList = searchResults.Select(Function(r) New With {
                Key .ID = r.ID,
                Key .FullName = r.FullName,
                Key .Age = r.Age,
                Key .ContactInfo = r.ContactInfo
            }).ToList()

            DataGridView1.DataSource = displayList

            Me.Text = $"Registration System - {searchResults.Count} Records"

        Catch ex As Exception
            MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class