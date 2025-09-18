Imports System.Data.OleDb
Imports System.IO
Imports oop_msaccess_crud.DatabaseHelper

Public Class Add_edit
    Private isEditMode As Boolean = False
    Private currentRecord As Registration = Nothing

    ' Dictionary to store country codes
    Private countryCodesDict As New Dictionary(Of String, String) From {
        {"Philippines", "+63"},
        {"United States", "+1"},
        {"Canada", "+1"},
        {"United Kingdom", "+44"},
        {"Australia", "+61"},
        {"Japan", "+81"},
        {"South Korea", "+82"},
        {"China", "+86"},
        {"India", "+91"},
        {"Singapore", "+65"},
        {"Malaysia", "+60"},
        {"Thailand", "+66"},
        {"Indonesia", "+62"},
        {"Vietnam", "+84"},
        {"Germany", "+49"},
        {"France", "+33"},
        {"Italy", "+39"},
        {"Spain", "+34"},
        {"Netherlands", "+31"},
        {"Belgium", "+32"},
        {"Switzerland", "+41"},
        {"Austria", "+43"},
        {"Sweden", "+46"},
        {"Norway", "+47"},
        {"Denmark", "+45"},
        {"Finland", "+358"},
        {"Russia", "+7"},
        {"Brazil", "+55"},
        {"Argentina", "+54"},
        {"Chile", "+56"},
        {"Colombia", "+57"},
        {"Peru", "+51"},
        {"Mexico", "+52"},
        {"South Africa", "+27"},
        {"Egypt", "+20"},
        {"Nigeria", "+234"},
        {"Kenya", "+254"},
        {"Morocco", "+212"},
        {"UAE", "+971"},
        {"Saudi Arabia", "+966"},
        {"Israel", "+972"},
        {"Turkey", "+90"},
        {"Iran", "+98"},
        {"Pakistan", "+92"},
        {"Bangladesh", "+880"},
        {"Sri Lanka", "+94"},
        {"Nepal", "+977"},
        {"Myanmar", "+95"},
        {"Cambodia", "+855"},
        {"Laos", "+856"},
        {"Brunei", "+673"}
    }

    ' Constructor for adding new records
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor for editing existing records
    Public Sub New(recordToEdit As Registration)
        InitializeComponent()
        isEditMode = True
        currentRecord = recordToEdit
    End Sub

    Private Sub Add_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form styling
        Me.BackColor = Color.White

        'Populate comboboxes'
        ComboBox_Suffix.Items.Clear()
        ComboBox_Suffix.Items.Add("-- Select --")  ' Placeholder option
        ComboBox_Suffix.Items.Add("Jr.")
        ComboBox_Suffix.Items.Add("Sr.")
        ComboBox_Suffix.Items.Add("III")
        ComboBox_Suffix.Items.Add("IV")
        ComboBox_Suffix.Items.Add("V")

        ComboBox_Gender.Items.Clear()
        ComboBox_Gender.Items.Add("-- Select --")  ' Placeholder option
        ComboBox_Gender.Items.Add("Male")
        ComboBox_Gender.Items.Add("Female")
        ComboBox_Gender.Items.Add("Non-binary")
        ComboBox_Gender.Items.Add("Prefer not to say")

        ComboBox_CivilStatus.Items.Clear()
        ComboBox_CivilStatus.Items.Add("-- Select --")  ' Placeholder option
        ComboBox_CivilStatus.Items.Add("Single")
        ComboBox_CivilStatus.Items.Add("Married")
        ComboBox_CivilStatus.Items.Add("Divorced")
        ComboBox_CivilStatus.Items.Add("Widowed")
        ComboBox_CivilStatus.Items.Add("Separated")
        ComboBox_CivilStatus.Items.Add("Annulled")

        ' Populate nationality dropdown with countries
        ComboBox_Nationality.Items.Clear()
        ComboBox_Nationality.Items.Add("-- Select Country --")
        For Each country In countryCodesDict.Keys.OrderBy(Function(x) x)
            ComboBox_Nationality.Items.Add(country)
        Next

        'Make the Dropdownlist not be able to take in texts'
        ComboBox_Suffix.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Gender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_CivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Nationality.DropDownStyle = ComboBoxStyle.DropDownList

        ' Set default selections
        ComboBox_Suffix.SelectedIndex = 0  ' -- Select --
        ComboBox_Gender.SelectedIndex = 0  ' -- Select --
        ComboBox_CivilStatus.SelectedIndex = 0  ' -- Select --
        ComboBox_Nationality.SelectedIndex = 0  ' -- Select Country --

        ' Set default country code
        Lbl_CountryCode.Text = "+63"

        ' If in edit mode, populate the form with existing data
        If isEditMode AndAlso currentRecord IsNot Nothing Then
            PopulateForm()
            Lbl_FormTitle.Text = "Edit Registration"
            Me.Text = "Edit Registration"
        Else
            Lbl_FormTitle.Text = "Add New Registration"
            Me.Text = "Add New Registration"
        End If

        ' Add styling to text boxes
        StyleTextBoxes()
    End Sub

    Private Sub StyleTextBoxes()
        ' Style all text boxes
        For Each ctrl As Control In TableLayoutPanel1.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctrl, TextBox)
                txt.BackColor = Color.White
                txt.BorderStyle = BorderStyle.FixedSingle
                txt.Font = New Font("Segoe UI", 9.0F)
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
                cmb.BackColor = Color.White
                cmb.Font = New Font("Segoe UI", 9.0F)
                cmb.FlatStyle = FlatStyle.Flat
            End If
        Next
    End Sub

    Private Sub ComboBox_Nationality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Nationality.SelectedIndexChanged
        ' Update country code when nationality changes
        If ComboBox_Nationality.SelectedIndex > 0 Then
            Dim selectedCountry As String = ComboBox_Nationality.SelectedItem.ToString()
            If countryCodesDict.ContainsKey(selectedCountry) Then
                Lbl_CountryCode.Text = countryCodesDict(selectedCountry)
            Else
                Lbl_CountryCode.Text = "+1" ' Default
            End If
        Else
            Lbl_CountryCode.Text = "+63" ' Default to Philippines
        End If
    End Sub

    Private Sub PopulateForm()
        Try
            Txt_InputFirstName.Text = currentRecord.FirstName
            Txt_InputLastName.Text = currentRecord.LastName
            Txt_InputMiddleName.Text = currentRecord.MiddleName
            CheckBox_MiddleName.Checked = currentRecord.HasMiddleName
            DateTimePicker.Value = currentRecord.BirthDate
            Txt_InputContact.Text = currentRecord.ContactInfo
            Txt_InputAddress.Text = currentRecord.Address

            ' Set nationality and update country code
            Dim nationalityToFind As String = currentRecord.Nationality
            Dim nationalityIndex = ComboBox_Nationality.FindStringExact(nationalityToFind)
            If nationalityIndex >= 0 Then
                ComboBox_Nationality.SelectedIndex = nationalityIndex
            Else
                ComboBox_Nationality.SelectedIndex = 0 ' Default to -- Select Country --
            End If

            ' Set ComboBox selections
            If Not String.IsNullOrEmpty(currentRecord.Suffix) Then
                Dim suffixIndex = ComboBox_Suffix.FindStringExact(currentRecord.Suffix)
                If suffixIndex >= 0 Then ComboBox_Suffix.SelectedIndex = suffixIndex
            End If

            If Not String.IsNullOrEmpty(currentRecord.Gender) Then
                Dim genderIndex = ComboBox_Gender.FindStringExact(currentRecord.Gender)
                If genderIndex >= 0 Then ComboBox_Gender.SelectedIndex = genderIndex
            End If

            If Not String.IsNullOrEmpty(currentRecord.CivilStatus) Then
                Dim civilStatusIndex = ComboBox_CivilStatus.FindStringExact(currentRecord.CivilStatus)
                If civilStatusIndex >= 0 Then ComboBox_CivilStatus.SelectedIndex = civilStatusIndex
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading record data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            ' Validate required fields with improved error messages
            If String.IsNullOrWhiteSpace(Txt_InputFirstName.Text) Then
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Txt_InputFirstName.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(Txt_InputLastName.Text) Then
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Txt_InputLastName.Focus()
                Return
            End If

            If ComboBox_Nationality.SelectedIndex <= 0 Then
                MessageBox.Show("Please select a nationality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ComboBox_Nationality.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(Txt_InputContact.Text) Then
                MessageBox.Show("Contact information is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Txt_InputContact.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(Txt_InputAddress.Text) Then
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Txt_InputAddress.Focus()
                Return
            End If

            ' Validate contact number format - Fixed validation
            Dim contactText As String = Txt_InputContact.Text.Trim()
            If Not IsContactNumberValid(contactText) OrElse contactText.Length < 10 Then
                MessageBox.Show("Please enter a valid contact number (numbers only, at least 10 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Txt_InputContact.Focus()
                Return
            End If

            ' Create or update registration object
            Dim registration As Registration

            If isEditMode Then
                registration = currentRecord
                registration.ID = currentRecord.ID
            Else
                registration = New Registration()
            End If

            ' Set properties
            registration.FirstName = Txt_InputFirstName.Text.Trim()
            registration.LastName = Txt_InputLastName.Text.Trim()

            If Not CheckBox_MiddleName.Checked AndAlso Not String.IsNullOrWhiteSpace(Txt_InputMiddleName.Text) Then
                registration.MiddleName = Txt_InputMiddleName.Text.Trim()
            Else
                registration.MiddleName = String.Empty
            End If

            registration.Suffix = If(ComboBox_Suffix.SelectedIndex > 0, ComboBox_Suffix.SelectedItem.ToString(), String.Empty)
            registration.Gender = If(ComboBox_Gender.SelectedIndex > 0, ComboBox_Gender.SelectedItem.ToString(), String.Empty)
            registration.CivilStatus = If(ComboBox_CivilStatus.SelectedIndex > 0, ComboBox_CivilStatus.SelectedItem.ToString(), String.Empty)
            registration.BirthDate = DateTimePicker.Value.Date
            registration.Nationality = ComboBox_Nationality.SelectedItem.ToString()

            ' Store full contact with country code
            registration.ContactInfo = Lbl_CountryCode.Text & "-" & Txt_InputContact.Text.Trim()
            registration.Address = Txt_InputAddress.Text.Trim()

            ' Save to database
            Dim success As Boolean = False
            If isEditMode Then
                success = DatabaseHelper.UpdateRecord(registration)
                If success Then
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim newId As Integer = DatabaseHelper.AddRecord(registration)
                success = newId > 0
                If success Then
                    MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            If success Then
                ' Return to main form
                Dim home As New HomePage()
                home.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error saving record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        'Clear all form fields with confirmation'
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Txt_InputLastName.Text = ""
            Txt_InputFirstName.Text = ""
            Txt_InputMiddleName.Text = ""
            CheckBox_MiddleName.Checked = False
            ComboBox_CivilStatus.SelectedIndex = 0  ' -- Select --
            ComboBox_Suffix.SelectedIndex = 0  ' -- Select --
            ComboBox_Gender.SelectedIndex = 0  ' -- Select --
            ComboBox_Nationality.SelectedIndex = 0  ' -- Select Country --
            DateTimePicker.Value = DateTime.Now
            Txt_InputContact.Text = ""
            Txt_InputAddress.Text = ""
            Lbl_CountryCode.Text = "+63"  ' Reset to default

            ' Focus on first field
            Txt_InputFirstName.Focus()
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        ' Ask for confirmation before closing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim home As New HomePage()
            home.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox_MiddleName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_MiddleName.CheckedChanged
        ' Enable/disable middle name text box based on checkbox
        Txt_InputMiddleName.Enabled = Not CheckBox_MiddleName.Checked
        If CheckBox_MiddleName.Checked Then
            Txt_InputMiddleName.Text = ""
            Txt_InputMiddleName.BackColor = Color.LightGray
        Else
            Txt_InputMiddleName.BackColor = Color.White
        End If
    End Sub

    ' Helper function to validate if contact number contains only digits
    Private Function IsContactNumberValid(contactNumber As String) As Boolean
        If String.IsNullOrWhiteSpace(contactNumber) Then
            Return False
        End If

        For Each c As Char In contactNumber
            If Not Char.IsDigit(c) Then
                Return False
            End If
        Next

        Return True
    End Function

    ' Add validation for numeric input on contact field
    Private Sub Txt_InputContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_InputContact.KeyPress
        ' Allow only numbers, backspace, and delete
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    ' Add character limits and formatting
    Private Sub Txt_InputContact_TextChanged(sender As Object, e As EventArgs) Handles Txt_InputContact.TextChanged
        ' Limit contact number to 15 digits (international standard)
        If Txt_InputContact.Text.Length > 15 Then
            Txt_InputContact.Text = Txt_InputContact.Text.Substring(0, 15)
            Txt_InputContact.SelectionStart = Txt_InputContact.Text.Length
        End If
    End Sub

    ' Prevent special characters in name fields
    Private Sub NameField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_InputFirstName.KeyPress, Txt_InputLastName.KeyPress, Txt_InputMiddleName.KeyPress
        ' Allow letters, spaces, apostrophes, hyphens, and backspace
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = "'"c OrElse e.KeyChar = "-"c OrElse e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

End Class