<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Txt_InputLastName = New TextBox()
        Txt_InputFirstName = New TextBox()
        Txt_InputMiddleName = New TextBox()
        CheckBox_MiddleName = New CheckBox()
        Lbl_LastName = New Label()
        Lbl_FirstName = New Label()
        Lbl_Suffix = New Label()
        Lbl_MiddleName = New Label()
        ComboBox_Suffix = New ComboBox()
        DateTimePicker = New DateTimePicker()
        Lbl_Birthdate = New Label()
        ComboBox_Gender = New ComboBox()
        Lbl_Gender = New Label()
        ComboBox_CivilStatus = New ComboBox()
        Lbl_CivilStatus = New Label()
        Txt_InputNationality = New TextBox()
        Lbl_Nationality = New Label()
        Txt_InputContact = New TextBox()
        Lbl_Contact = New Label()
        Lbl_Address = New Label()
        Txt_InputAddress = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        SaveButton = New Button()
        CancelButton = New Button()
        ClearButton = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Txt_InputLastName
        ' 
        Txt_InputLastName.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputLastName, 2)
        Txt_InputLastName.Location = New Point(174, 21)
        Txt_InputLastName.Name = "Txt_InputLastName"
        Txt_InputLastName.Size = New Size(330, 31)
        Txt_InputLastName.TabIndex = 0
        ' 
        ' Txt_InputFirstName
        ' 
        Txt_InputFirstName.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputFirstName, 2)
        Txt_InputFirstName.Location = New Point(174, 94)
        Txt_InputFirstName.Name = "Txt_InputFirstName"
        Txt_InputFirstName.Size = New Size(330, 31)
        Txt_InputFirstName.TabIndex = 1
        ' 
        ' Txt_InputMiddleName
        ' 
        Txt_InputMiddleName.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputMiddleName, 2)
        Txt_InputMiddleName.Location = New Point(174, 167)
        Txt_InputMiddleName.Name = "Txt_InputMiddleName"
        Txt_InputMiddleName.Size = New Size(330, 31)
        Txt_InputMiddleName.TabIndex = 2
        ' 
        ' CheckBox_MiddleName
        ' 
        CheckBox_MiddleName.AutoSize = True
        CheckBox_MiddleName.CheckAlign = ContentAlignment.TopLeft
        TableLayoutPanel1.SetColumnSpan(CheckBox_MiddleName, 2)
        CheckBox_MiddleName.Dock = DockStyle.Fill
        CheckBox_MiddleName.Location = New Point(174, 222)
        CheckBox_MiddleName.Name = "CheckBox_MiddleName"
        CheckBox_MiddleName.Size = New Size(444, 67)
        CheckBox_MiddleName.TabIndex = 3
        CheckBox_MiddleName.Text = "No Middle Name"
        CheckBox_MiddleName.TextAlign = ContentAlignment.TopLeft
        CheckBox_MiddleName.UseVisualStyleBackColor = True
        ' 
        ' Lbl_LastName
        ' 
        Lbl_LastName.AutoSize = True
        Lbl_LastName.Dock = DockStyle.Fill
        Lbl_LastName.Location = New Point(3, 0)
        Lbl_LastName.Name = "Lbl_LastName"
        Lbl_LastName.Size = New Size(165, 73)
        Lbl_LastName.TabIndex = 4
        Lbl_LastName.Text = "Last Name:"
        Lbl_LastName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_FirstName
        ' 
        Lbl_FirstName.AutoSize = True
        Lbl_FirstName.Dock = DockStyle.Fill
        Lbl_FirstName.Location = New Point(3, 73)
        Lbl_FirstName.Name = "Lbl_FirstName"
        Lbl_FirstName.Size = New Size(165, 73)
        Lbl_FirstName.TabIndex = 5
        Lbl_FirstName.Text = "First Name:"
        Lbl_FirstName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_Suffix
        ' 
        Lbl_Suffix.AutoSize = True
        Lbl_Suffix.Dock = DockStyle.Fill
        Lbl_Suffix.Location = New Point(3, 292)
        Lbl_Suffix.Name = "Lbl_Suffix"
        Lbl_Suffix.Size = New Size(165, 39)
        Lbl_Suffix.TabIndex = 6
        Lbl_Suffix.Text = "Suffix:"
        Lbl_Suffix.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_MiddleName
        ' 
        Lbl_MiddleName.AutoSize = True
        Lbl_MiddleName.Dock = DockStyle.Fill
        Lbl_MiddleName.Location = New Point(3, 146)
        Lbl_MiddleName.Name = "Lbl_MiddleName"
        Lbl_MiddleName.Size = New Size(165, 73)
        Lbl_MiddleName.TabIndex = 8
        Lbl_MiddleName.Text = "Middle Name:"
        Lbl_MiddleName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Suffix
        ' 
        ComboBox_Suffix.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(ComboBox_Suffix, 2)
        ComboBox_Suffix.FormattingEnabled = True
        ComboBox_Suffix.Location = New Point(174, 295)
        ComboBox_Suffix.Name = "ComboBox_Suffix"
        ComboBox_Suffix.Size = New Size(330, 33)
        ComboBox_Suffix.TabIndex = 9
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(DateTimePicker, 2)
        DateTimePicker.Location = New Point(174, 352)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(330, 31)
        DateTimePicker.TabIndex = 10
        ' 
        ' Lbl_Birthdate
        ' 
        Lbl_Birthdate.AutoSize = True
        Lbl_Birthdate.Dock = DockStyle.Fill
        Lbl_Birthdate.Location = New Point(3, 331)
        Lbl_Birthdate.Name = "Lbl_Birthdate"
        Lbl_Birthdate.Size = New Size(165, 73)
        Lbl_Birthdate.TabIndex = 11
        Lbl_Birthdate.Text = "Birthdate:"
        Lbl_Birthdate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Gender
        ' 
        ComboBox_Gender.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(ComboBox_Gender, 2)
        ComboBox_Gender.FormattingEnabled = True
        ComboBox_Gender.Location = New Point(174, 424)
        ComboBox_Gender.Name = "ComboBox_Gender"
        ComboBox_Gender.Size = New Size(330, 33)
        ComboBox_Gender.TabIndex = 12
        ' 
        ' Lbl_Gender
        ' 
        Lbl_Gender.AutoSize = True
        Lbl_Gender.Dock = DockStyle.Fill
        Lbl_Gender.Location = New Point(3, 404)
        Lbl_Gender.Name = "Lbl_Gender"
        Lbl_Gender.Size = New Size(165, 73)
        Lbl_Gender.TabIndex = 13
        Lbl_Gender.Text = "Gender:"
        Lbl_Gender.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_CivilStatus
        ' 
        ComboBox_CivilStatus.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(ComboBox_CivilStatus, 2)
        ComboBox_CivilStatus.FormattingEnabled = True
        ComboBox_CivilStatus.Location = New Point(174, 480)
        ComboBox_CivilStatus.Name = "ComboBox_CivilStatus"
        ComboBox_CivilStatus.Size = New Size(330, 33)
        ComboBox_CivilStatus.TabIndex = 15
        ' 
        ' Lbl_CivilStatus
        ' 
        Lbl_CivilStatus.AutoSize = True
        Lbl_CivilStatus.Dock = DockStyle.Fill
        Lbl_CivilStatus.Location = New Point(3, 477)
        Lbl_CivilStatus.Name = "Lbl_CivilStatus"
        Lbl_CivilStatus.Size = New Size(165, 39)
        Lbl_CivilStatus.TabIndex = 16
        Lbl_CivilStatus.Text = "Civil Status:"
        Lbl_CivilStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputNationality
        ' 
        Txt_InputNationality.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputNationality, 2)
        Txt_InputNationality.Location = New Point(174, 537)
        Txt_InputNationality.Name = "Txt_InputNationality"
        Txt_InputNationality.Size = New Size(330, 31)
        Txt_InputNationality.TabIndex = 17
        ' 
        ' Lbl_Nationality
        ' 
        Lbl_Nationality.AutoSize = True
        Lbl_Nationality.Dock = DockStyle.Fill
        Lbl_Nationality.Location = New Point(3, 516)
        Lbl_Nationality.Name = "Lbl_Nationality"
        Lbl_Nationality.Size = New Size(165, 73)
        Lbl_Nationality.TabIndex = 18
        Lbl_Nationality.Text = "Nationality:"
        Lbl_Nationality.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputContact
        ' 
        Txt_InputContact.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputContact, 2)
        Txt_InputContact.Location = New Point(174, 610)
        Txt_InputContact.Name = "Txt_InputContact"
        Txt_InputContact.Size = New Size(330, 31)
        Txt_InputContact.TabIndex = 19
        ' 
        ' Lbl_Contact
        ' 
        Lbl_Contact.AutoSize = True
        Lbl_Contact.Dock = DockStyle.Fill
        Lbl_Contact.Location = New Point(3, 589)
        Lbl_Contact.Name = "Lbl_Contact"
        Lbl_Contact.Size = New Size(165, 73)
        Lbl_Contact.TabIndex = 20
        Lbl_Contact.Text = "Contact No.:"
        Lbl_Contact.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_Address
        ' 
        Lbl_Address.AutoSize = True
        Lbl_Address.Dock = DockStyle.Fill
        Lbl_Address.Location = New Point(3, 662)
        Lbl_Address.Name = "Lbl_Address"
        Lbl_Address.Size = New Size(165, 73)
        Lbl_Address.TabIndex = 21
        Lbl_Address.Text = "Adress:"
        Lbl_Address.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputAddress
        ' 
        Txt_InputAddress.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputAddress, 2)
        Txt_InputAddress.Location = New Point(174, 683)
        Txt_InputAddress.Name = "Txt_InputAddress"
        Txt_InputAddress.Size = New Size(330, 31)
        Txt_InputAddress.TabIndex = 22
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.6366673F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.03F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.Controls.Add(Lbl_LastName, 0, 0)
        TableLayoutPanel1.Controls.Add(SaveButton, 2, 12)
        TableLayoutPanel1.Controls.Add(Lbl_FirstName, 0, 1)
        TableLayoutPanel1.Controls.Add(Lbl_MiddleName, 0, 2)
        TableLayoutPanel1.Controls.Add(CancelButton, 0, 12)
        TableLayoutPanel1.Controls.Add(Txt_InputMiddleName, 1, 2)
        TableLayoutPanel1.Controls.Add(Lbl_Address, 0, 11)
        TableLayoutPanel1.Controls.Add(Txt_InputAddress, 1, 11)
        TableLayoutPanel1.Controls.Add(Lbl_Suffix, 0, 4)
        TableLayoutPanel1.Controls.Add(Lbl_Contact, 0, 10)
        TableLayoutPanel1.Controls.Add(ComboBox_Suffix, 1, 4)
        TableLayoutPanel1.Controls.Add(Txt_InputContact, 1, 10)
        TableLayoutPanel1.Controls.Add(Lbl_Birthdate, 0, 5)
        TableLayoutPanel1.Controls.Add(Lbl_Nationality, 0, 9)
        TableLayoutPanel1.Controls.Add(DateTimePicker, 1, 5)
        TableLayoutPanel1.Controls.Add(Txt_InputNationality, 1, 9)
        TableLayoutPanel1.Controls.Add(Lbl_Gender, 0, 6)
        TableLayoutPanel1.Controls.Add(Lbl_CivilStatus, 0, 8)
        TableLayoutPanel1.Controls.Add(ComboBox_Gender, 1, 6)
        TableLayoutPanel1.Controls.Add(ComboBox_CivilStatus, 1, 8)
        TableLayoutPanel1.Controls.Add(Txt_InputFirstName, 1, 1)
        TableLayoutPanel1.Controls.Add(Txt_InputLastName, 1, 0)
        TableLayoutPanel1.Controls.Add(CheckBox_MiddleName, 1, 3)
        TableLayoutPanel1.Controls.Add(ClearButton, 1, 12)
        TableLayoutPanel1.Location = New Point(0, -3)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 13
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(621, 813)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' SaveButton
        ' 
        SaveButton.Anchor = AnchorStyles.None
        SaveButton.Location = New Point(452, 749)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(130, 50)
        SaveButton.TabIndex = 25
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Anchor = AnchorStyles.None
        CancelButton.Location = New Point(17, 749)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(136, 50)
        CancelButton.TabIndex = 23
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Anchor = AnchorStyles.None
        ClearButton.Location = New Point(212, 749)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(160, 50)
        ClearButton.TabIndex = 24
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' Add_edit
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 812)
        Controls.Add(TableLayoutPanel1)
        Name = "Add_edit"
        Text = "Regitration"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Txt_InputLastName As TextBox
    Friend WithEvents Txt_InputFirstName As TextBox
    Friend WithEvents Txt_InputMiddleName As TextBox
    Friend WithEvents CheckBox_MiddleName As CheckBox
    Friend WithEvents Lbl_LastName As Label
    Friend WithEvents Lbl_FirstName As Label
    Friend WithEvents Lbl_Suffix As Label
    Friend WithEvents Lbl_MiddleName As Label
    Friend WithEvents ComboBox_Suffix As ComboBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Lbl_Birthdate As Label
    Friend WithEvents ComboBox_Gender As ComboBox
    Friend WithEvents Lbl_Gender As Label
    Friend WithEvents ComboBox_CivilStatus As ComboBox
    Friend WithEvents Lbl_CivilStatus As Label
    Friend WithEvents Txt_InputNationality As TextBox
    Friend WithEvents Lbl_Nationality As Label
    Friend WithEvents Txt_InputContact As TextBox
    Friend WithEvents Lbl_Contact As Label
    Friend WithEvents Lbl_Address As Label
    Friend WithEvents Txt_InputAddress As TextBox

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ClearButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
End Class
