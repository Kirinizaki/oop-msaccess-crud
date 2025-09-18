Public Class RecordDetailForm
    Private currentRecord As Registration

    Public Sub New()
        InitializeComponents()
    End Sub

    Public Sub New(record As Registration)
        InitializeComponents()
        currentRecord = record
    End Sub

    Private Sub RecordDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If currentRecord IsNot Nothing Then
            PopulateDetails()
        End If

        ' Set form properties
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub PopulateDetails()
        Me.Text = $"Record Details - {currentRecord.FullName}"

        ' Populate labels with record data
        Lbl_FullName.Text = currentRecord.FullName
        Lbl_FirstName.Text = currentRecord.FirstName
        Lbl_LastName.Text = currentRecord.LastName
        Lbl_MiddleName.Text = If(String.IsNullOrEmpty(currentRecord.MiddleName), "N/A", currentRecord.MiddleName)
        Lbl_Suffix.Text = If(String.IsNullOrEmpty(currentRecord.Suffix), "N/A", currentRecord.Suffix)

        Lbl_BirthDate.Text = currentRecord.BirthDate.ToString("MMMM dd, yyyy")
        Lbl_Age.Text = $"{currentRecord.Age} years old"
        Lbl_Gender.Text = If(String.IsNullOrEmpty(currentRecord.Gender), "Not specified", currentRecord.Gender)
        Lbl_CivilStatus.Text = If(String.IsNullOrEmpty(currentRecord.CivilStatus), "Not specified", currentRecord.CivilStatus)
        Lbl_Nationality.Text = currentRecord.Nationality

        Lbl_ContactInfo.Text = currentRecord.ContactInfo
        Lbl_Address.Text = currentRecord.Address
    End Sub

    Private Sub InitializeComponents()
        Me.Panel_Header = New Panel()
        Me.Lbl_FormTitle = New Label()
        Me.TableLayoutPanel1 = New TableLayoutPanel()
        Me.Lbl_FullNameLabel = New Label()
        Me.Lbl_FullName = New Label()
        Me.Lbl_FirstNameLabel = New Label()
        Me.Lbl_FirstName = New Label()
        Me.Lbl_LastNameLabel = New Label()
        Me.Lbl_LastName = New Label()
        Me.Lbl_MiddleNameLabel = New Label()
        Me.Lbl_MiddleName = New Label()
        Me.Lbl_SuffixLabel = New Label()
        Me.Lbl_Suffix = New Label()
        Me.Lbl_BirthDateLabel = New Label()
        Me.Lbl_BirthDate = New Label()
        Me.Lbl_AgeLabel = New Label()
        Me.Lbl_Age = New Label()
        Me.Lbl_GenderLabel = New Label()
        Me.Lbl_Gender = New Label()
        Me.Lbl_CivilStatusLabel = New Label()
        Me.Lbl_CivilStatus = New Label()
        Me.Lbl_NationalityLabel = New Label()
        Me.Lbl_Nationality = New Label()
        Me.Lbl_ContactInfoLabel = New Label()
        Me.Lbl_ContactInfo = New Label()
        Me.Lbl_AddressLabel = New Label()
        Me.Lbl_Address = New Label()
        Me.Btn_Edit = New Button()
        Me.Btn_Close = New Button()
        Me.Panel_Header.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()

        ' Panel_Header
        Me.Panel_Header.Controls.Add(Me.Lbl_FormTitle)
        Me.Panel_Header.Dock = DockStyle.Top
        Me.Panel_Header.Location = New Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New Size(500, 60)
        Me.Panel_Header.TabIndex = 0

        ' Lbl_FormTitle
        Me.Lbl_FormTitle.Dock = DockStyle.Fill
        Me.Lbl_FormTitle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold)
        Me.Lbl_FormTitle.Location = New Point(0, 0)
        Me.Lbl_FormTitle.Name = "Lbl_FormTitle"
        Me.Lbl_FormTitle.Size = New Size(500, 60)
        Me.Lbl_FormTitle.TabIndex = 0
        Me.Lbl_FormTitle.Text = "Record Details"
        Me.Lbl_FormTitle.TextAlign = ContentAlignment.MiddleCenter

        ' TableLayoutPanel1
        Me.TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.0F))
        Me.TableLayoutPanel1.Location = New Point(20, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13

        ' Add all rows with equal height (removed minor status row)
        For i As Integer = 0 To 11
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 35.0F))
        Next
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F)) ' Button row

        Me.TableLayoutPanel1.Size = New Size(460, 470)
        Me.TableLayoutPanel1.TabIndex = 1

        ' Create and add all label pairs (removed minor status)
        CreateLabelPair("Full Name:", "Lbl_FullNameLabel", "Lbl_FullName", 0)
        CreateLabelPair("First Name:", "Lbl_FirstNameLabel", "Lbl_FirstName", 1)
        CreateLabelPair("Last Name:", "Lbl_LastNameLabel", "Lbl_LastName", 2)
        CreateLabelPair("Middle Name:", "Lbl_MiddleNameLabel", "Lbl_MiddleName", 3)
        CreateLabelPair("Suffix:", "Lbl_SuffixLabel", "Lbl_Suffix", 4)
        CreateLabelPair("Birth Date:", "Lbl_BirthDateLabel", "Lbl_BirthDate", 5)
        CreateLabelPair("Age:", "Lbl_AgeLabel", "Lbl_Age", 6)
        CreateLabelPair("Gender:", "Lbl_GenderLabel", "Lbl_Gender", 7)
        CreateLabelPair("Civil Status:", "Lbl_CivilStatusLabel", "Lbl_CivilStatus", 8)
        CreateLabelPair("Nationality:", "Lbl_NationalityLabel", "Lbl_Nationality", 9)
        CreateLabelPair("Contact Info:", "Lbl_ContactInfoLabel", "Lbl_ContactInfo", 10)
        CreateLabelPair("Address:", "Lbl_AddressLabel", "Lbl_Address", 11)

        ' Buttons
        Me.Btn_Edit.Anchor = AnchorStyles.None
        Me.Btn_Edit.Location = New Point(30, 10)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New Size(100, 35)
        Me.Btn_Edit.TabIndex = 0
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Edit, 0, 12)

        Me.Btn_Close.Anchor = AnchorStyles.None
        Me.Btn_Close.Location = New Point(160, 10)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New Size(100, 35)
        Me.Btn_Close.TabIndex = 1
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Close, 1, 12)

        ' Form properties
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(500, 570)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel_Header)
        Me.Name = "RecordDetailForm"
        Me.Text = "Record Details"
        Me.Panel_Header.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Private Sub CreateLabelPair(labelText As String, labelName As String, valueName As String, row As Integer)
        ' Create label for field name
        Dim fieldLabel As New Label()
        fieldLabel.Name = labelName
        fieldLabel.Text = labelText
        fieldLabel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        fieldLabel.Dock = DockStyle.Fill
        fieldLabel.TextAlign = ContentAlignment.MiddleRight
        fieldLabel.Padding = New Padding(0, 0, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(fieldLabel, 0, row)

        ' Create label for field value
        Dim valueLabel As New Label()
        valueLabel.Name = valueName
        valueLabel.Text = ""
        valueLabel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular)
        valueLabel.Dock = DockStyle.Fill
        valueLabel.TextAlign = ContentAlignment.MiddleLeft
        valueLabel.Padding = New Padding(10, 0, 0, 0)
        valueLabel.BorderStyle = BorderStyle.Fixed3D
        Me.TableLayoutPanel1.Controls.Add(valueLabel, 1, row)

        ' Set the label reference for later use
        Select Case valueName
            Case "Lbl_FullName" : Me.Lbl_FullName = valueLabel
            Case "Lbl_FirstName" : Me.Lbl_FirstName = valueLabel
            Case "Lbl_LastName" : Me.Lbl_LastName = valueLabel
            Case "Lbl_MiddleName" : Me.Lbl_MiddleName = valueLabel
            Case "Lbl_Suffix" : Me.Lbl_Suffix = valueLabel
            Case "Lbl_BirthDate" : Me.Lbl_BirthDate = valueLabel
            Case "Lbl_Age" : Me.Lbl_Age = valueLabel
            Case "Lbl_Gender" : Me.Lbl_Gender = valueLabel
            Case "Lbl_CivilStatus" : Me.Lbl_CivilStatus = valueLabel
            Case "Lbl_Nationality" : Me.Lbl_Nationality = valueLabel
            Case "Lbl_ContactInfo" : Me.Lbl_ContactInfo = valueLabel
            Case "Lbl_Address" : Me.Lbl_Address = valueLabel
        End Select
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If currentRecord IsNot Nothing Then
            ' Close this form and open edit form
            Me.DialogResult = DialogResult.OK
            Me.Close()

            ' Open edit form
            Dim editForm As New Add_edit(currentRecord)
            editForm.Show()
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    ' Form controls (will be created dynamically in InitializeComponent)
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Lbl_FormTitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Lbl_FullNameLabel As Label
    Friend WithEvents Lbl_FullName As Label
    Friend WithEvents Lbl_FirstNameLabel As Label
    Friend WithEvents Lbl_FirstName As Label
    Friend WithEvents Lbl_LastNameLabel As Label
    Friend WithEvents Lbl_LastName As Label
    Friend WithEvents Lbl_MiddleNameLabel As Label
    Friend WithEvents Lbl_MiddleName As Label
    Friend WithEvents Lbl_SuffixLabel As Label
    Friend WithEvents Lbl_Suffix As Label
    Friend WithEvents Lbl_BirthDateLabel As Label
    Friend WithEvents Lbl_BirthDate As Label
    Friend WithEvents Lbl_AgeLabel As Label
    Friend WithEvents Lbl_Age As Label
    Friend WithEvents Lbl_GenderLabel As Label
    Friend WithEvents Lbl_Gender As Label
    Friend WithEvents Lbl_CivilStatusLabel As Label
    Friend WithEvents Lbl_CivilStatus As Label
    Friend WithEvents Lbl_NationalityLabel As Label
    Friend WithEvents Lbl_Nationality As Label
    Friend WithEvents Lbl_ContactInfoLabel As Label
    Friend WithEvents Lbl_ContactInfo As Label
    Friend WithEvents Lbl_AddressLabel As Label
    Friend WithEvents Lbl_Address As Label
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Close As Button
End Class