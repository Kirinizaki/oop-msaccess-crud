<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        ComboBox_Nationality = New ComboBox()
        Lbl_Nationality = New Label()
        Txt_InputContact = New TextBox()
        Lbl_Contact = New Label()
        Lbl_Address = New Label()
        Txt_InputAddress = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Btn_Save = New Button()
        Btn_Cancel = New Button()
        Btn_Clear = New Button()
        Lbl_CountryCode = New Label()
        Panel_Header = New Panel()
        Lbl_FormTitle = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel_Header.SuspendLayout()
        SuspendLayout()
        ' 
        ' Txt_InputLastName
        ' 
        Txt_InputLastName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputLastName, 2)
        Txt_InputLastName.Font = New Font("Segoe UI", 9F)
        Txt_InputLastName.Location = New Point(140, 14)
        Txt_InputLastName.Margin = New Padding(3, 4, 3, 4)
        Txt_InputLastName.Name = "Txt_InputLastName"
        Txt_InputLastName.Size = New Size(331, 27)
        Txt_InputLastName.TabIndex = 0
        ' 
        ' Txt_InputFirstName
        ' 
        Txt_InputFirstName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputFirstName, 2)
        Txt_InputFirstName.Font = New Font("Segoe UI", 9F)
        Txt_InputFirstName.Location = New Point(140, 70)
        Txt_InputFirstName.Margin = New Padding(3, 4, 3, 4)
        Txt_InputFirstName.Name = "Txt_InputFirstName"
        Txt_InputFirstName.Size = New Size(331, 27)
        Txt_InputFirstName.TabIndex = 1
        ' 
        ' Txt_InputMiddleName
        ' 
        Txt_InputMiddleName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputMiddleName, 2)
        Txt_InputMiddleName.Font = New Font("Segoe UI", 9F)
        Txt_InputMiddleName.Location = New Point(140, 126)
        Txt_InputMiddleName.Margin = New Padding(3, 4, 3, 4)
        Txt_InputMiddleName.Name = "Txt_InputMiddleName"
        Txt_InputMiddleName.Size = New Size(331, 27)
        Txt_InputMiddleName.TabIndex = 2
        ' 
        ' CheckBox_MiddleName
        ' 
        CheckBox_MiddleName.AutoSize = True
        CheckBox_MiddleName.CheckAlign = ContentAlignment.TopLeft
        TableLayoutPanel1.SetColumnSpan(CheckBox_MiddleName, 2)
        CheckBox_MiddleName.Dock = DockStyle.Fill
        CheckBox_MiddleName.Font = New Font("Segoe UI", 9F)
        CheckBox_MiddleName.ForeColor = Color.Black
        CheckBox_MiddleName.Location = New Point(140, 172)
        CheckBox_MiddleName.Margin = New Padding(3, 4, 3, 4)
        CheckBox_MiddleName.Name = "CheckBox_MiddleName"
        CheckBox_MiddleName.Size = New Size(331, 48)
        CheckBox_MiddleName.TabIndex = 3
        CheckBox_MiddleName.Text = "No Middle Name"
        CheckBox_MiddleName.TextAlign = ContentAlignment.TopLeft
        CheckBox_MiddleName.UseVisualStyleBackColor = True
        ' 
        ' Lbl_LastName
        ' 
        Lbl_LastName.AutoSize = True
        Lbl_LastName.Dock = DockStyle.Fill
        Lbl_LastName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_LastName.ForeColor = Color.Black
        Lbl_LastName.Location = New Point(3, 0)
        Lbl_LastName.Name = "Lbl_LastName"
        Lbl_LastName.Size = New Size(131, 56)
        Lbl_LastName.TabIndex = 4
        Lbl_LastName.Text = "Last Name: *"
        Lbl_LastName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_FirstName
        ' 
        Lbl_FirstName.AutoSize = True
        Lbl_FirstName.Dock = DockStyle.Fill
        Lbl_FirstName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_FirstName.ForeColor = Color.Black
        Lbl_FirstName.Location = New Point(3, 56)
        Lbl_FirstName.Name = "Lbl_FirstName"
        Lbl_FirstName.Size = New Size(131, 56)
        Lbl_FirstName.TabIndex = 5
        Lbl_FirstName.Text = "First Name: *"
        Lbl_FirstName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_Suffix
        ' 
        Lbl_Suffix.AutoSize = True
        Lbl_Suffix.Dock = DockStyle.Fill
        Lbl_Suffix.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Suffix.ForeColor = Color.Black
        Lbl_Suffix.Location = New Point(3, 224)
        Lbl_Suffix.Name = "Lbl_Suffix"
        Lbl_Suffix.Size = New Size(131, 36)
        Lbl_Suffix.TabIndex = 6
        Lbl_Suffix.Text = "Suffix:"
        Lbl_Suffix.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_MiddleName
        ' 
        Lbl_MiddleName.AutoSize = True
        Lbl_MiddleName.Dock = DockStyle.Fill
        Lbl_MiddleName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_MiddleName.ForeColor = Color.Black
        Lbl_MiddleName.Location = New Point(3, 112)
        Lbl_MiddleName.Name = "Lbl_MiddleName"
        Lbl_MiddleName.Size = New Size(131, 56)
        Lbl_MiddleName.TabIndex = 8
        Lbl_MiddleName.Text = "Middle Name:"
        Lbl_MiddleName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Suffix
        ' 
        ComboBox_Suffix.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_Suffix, 2)
        ComboBox_Suffix.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Suffix.Font = New Font("Segoe UI", 9F)
        ComboBox_Suffix.FormattingEnabled = True
        ComboBox_Suffix.Location = New Point(140, 228)
        ComboBox_Suffix.Margin = New Padding(3, 4, 3, 4)
        ComboBox_Suffix.Name = "ComboBox_Suffix"
        ComboBox_Suffix.Size = New Size(331, 28)
        ComboBox_Suffix.TabIndex = 9
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(DateTimePicker, 2)
        DateTimePicker.Font = New Font("Segoe UI", 9F)
        DateTimePicker.Location = New Point(140, 274)
        DateTimePicker.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(331, 27)
        DateTimePicker.TabIndex = 10
        ' 
        ' Lbl_Birthdate
        ' 
        Lbl_Birthdate.AutoSize = True
        Lbl_Birthdate.Dock = DockStyle.Fill
        Lbl_Birthdate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Birthdate.ForeColor = Color.Black
        Lbl_Birthdate.Location = New Point(3, 260)
        Lbl_Birthdate.Name = "Lbl_Birthdate"
        Lbl_Birthdate.Size = New Size(131, 56)
        Lbl_Birthdate.TabIndex = 11
        Lbl_Birthdate.Text = "Birthdate: *"
        Lbl_Birthdate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Gender
        ' 
        ComboBox_Gender.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_Gender, 2)
        ComboBox_Gender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Gender.Font = New Font("Segoe UI", 9F)
        ComboBox_Gender.FormattingEnabled = True
        ComboBox_Gender.Location = New Point(140, 330)
        ComboBox_Gender.Margin = New Padding(3, 4, 3, 4)
        ComboBox_Gender.Name = "ComboBox_Gender"
        ComboBox_Gender.Size = New Size(331, 28)
        ComboBox_Gender.TabIndex = 12
        ' 
        ' Lbl_Gender
        ' 
        Lbl_Gender.AutoSize = True
        Lbl_Gender.Dock = DockStyle.Fill
        Lbl_Gender.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Gender.ForeColor = Color.Black
        Lbl_Gender.Location = New Point(3, 316)
        Lbl_Gender.Name = "Lbl_Gender"
        Lbl_Gender.Size = New Size(131, 56)
        Lbl_Gender.TabIndex = 13
        Lbl_Gender.Text = "Gender:"
        Lbl_Gender.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_CivilStatus
        ' 
        ComboBox_CivilStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_CivilStatus, 2)
        ComboBox_CivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_CivilStatus.Font = New Font("Segoe UI", 9F)
        ComboBox_CivilStatus.FormattingEnabled = True
        ComboBox_CivilStatus.Location = New Point(140, 376)
        ComboBox_CivilStatus.Margin = New Padding(3, 4, 3, 4)
        ComboBox_CivilStatus.Name = "ComboBox_CivilStatus"
        ComboBox_CivilStatus.Size = New Size(331, 28)
        ComboBox_CivilStatus.TabIndex = 15
        ' 
        ' Lbl_CivilStatus
        ' 
        Lbl_CivilStatus.AutoSize = True
        Lbl_CivilStatus.Dock = DockStyle.Fill
        Lbl_CivilStatus.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_CivilStatus.ForeColor = Color.Black
        Lbl_CivilStatus.Location = New Point(3, 372)
        Lbl_CivilStatus.Name = "Lbl_CivilStatus"
        Lbl_CivilStatus.Size = New Size(131, 36)
        Lbl_CivilStatus.TabIndex = 16
        Lbl_CivilStatus.Text = "Civil Status:"
        Lbl_CivilStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Nationality
        ' 
        ComboBox_Nationality.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_Nationality, 2)
        ComboBox_Nationality.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Nationality.Font = New Font("Segoe UI", 9F)
        ComboBox_Nationality.FormattingEnabled = True
        ComboBox_Nationality.Location = New Point(140, 422)
        ComboBox_Nationality.Margin = New Padding(3, 4, 3, 4)
        ComboBox_Nationality.Name = "ComboBox_Nationality"
        ComboBox_Nationality.Size = New Size(331, 28)
        ComboBox_Nationality.TabIndex = 17
        ' 
        ' Lbl_Nationality
        ' 
        Lbl_Nationality.AutoSize = True
        Lbl_Nationality.Dock = DockStyle.Fill
        Lbl_Nationality.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Nationality.ForeColor = Color.Black
        Lbl_Nationality.Location = New Point(3, 408)
        Lbl_Nationality.Name = "Lbl_Nationality"
        Lbl_Nationality.Size = New Size(131, 56)
        Lbl_Nationality.TabIndex = 18
        Lbl_Nationality.Text = "Nationality: *"
        Lbl_Nationality.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputContact
        ' 
        Txt_InputContact.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Txt_InputContact.Font = New Font("Segoe UI", 9F)
        Txt_InputContact.Location = New Point(318, 478)
        Txt_InputContact.Margin = New Padding(3, 4, 3, 4)
        Txt_InputContact.Name = "Txt_InputContact"
        Txt_InputContact.Size = New Size(153, 27)
        Txt_InputContact.TabIndex = 19
        ' 
        ' Lbl_Contact
        ' 
        Lbl_Contact.AutoSize = True
        Lbl_Contact.Dock = DockStyle.Fill
        Lbl_Contact.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Contact.ForeColor = Color.Black
        Lbl_Contact.Location = New Point(3, 464)
        Lbl_Contact.Name = "Lbl_Contact"
        Lbl_Contact.Size = New Size(131, 56)
        Lbl_Contact.TabIndex = 20
        Lbl_Contact.Text = "Contact No.: *"
        Lbl_Contact.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_Address
        ' 
        Lbl_Address.AutoSize = True
        Lbl_Address.Dock = DockStyle.Fill
        Lbl_Address.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Address.ForeColor = Color.Black
        Lbl_Address.Location = New Point(3, 520)
        Lbl_Address.Name = "Lbl_Address"
        Lbl_Address.Size = New Size(131, 107)
        Lbl_Address.TabIndex = 21
        Lbl_Address.Text = "Address: *"
        Lbl_Address.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputAddress
        ' 
        Txt_InputAddress.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputAddress, 2)
        Txt_InputAddress.Font = New Font("Segoe UI", 9F)
        Txt_InputAddress.Location = New Point(140, 526)
        Txt_InputAddress.Margin = New Padding(3, 4, 3, 4)
        Txt_InputAddress.Multiline = True
        Txt_InputAddress.Name = "Txt_InputAddress"
        Txt_InputAddress.Size = New Size(331, 95)
        Txt_InputAddress.TabIndex = 22
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.9621887F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 37.6508446F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3869667F))
        TableLayoutPanel1.Controls.Add(Lbl_LastName, 0, 0)
        TableLayoutPanel1.Controls.Add(Btn_Save, 2, 12)
        TableLayoutPanel1.Controls.Add(Lbl_FirstName, 0, 1)
        TableLayoutPanel1.Controls.Add(Lbl_MiddleName, 0, 2)
        TableLayoutPanel1.Controls.Add(Btn_Cancel, 0, 12)
        TableLayoutPanel1.Controls.Add(Txt_InputMiddleName, 1, 2)
        TableLayoutPanel1.Controls.Add(Lbl_Address, 0, 11)
        TableLayoutPanel1.Controls.Add(Txt_InputAddress, 1, 11)
        TableLayoutPanel1.Controls.Add(Lbl_Suffix, 0, 4)
        TableLayoutPanel1.Controls.Add(Lbl_Contact, 0, 10)
        TableLayoutPanel1.Controls.Add(ComboBox_Suffix, 1, 4)
        TableLayoutPanel1.Controls.Add(Txt_InputContact, 2, 10)
        TableLayoutPanel1.Controls.Add(Lbl_Birthdate, 0, 5)
        TableLayoutPanel1.Controls.Add(Lbl_Nationality, 0, 9)
        TableLayoutPanel1.Controls.Add(DateTimePicker, 1, 5)
        TableLayoutPanel1.Controls.Add(ComboBox_Nationality, 1, 9)
        TableLayoutPanel1.Controls.Add(Lbl_Gender, 0, 6)
        TableLayoutPanel1.Controls.Add(Lbl_CivilStatus, 0, 8)
        TableLayoutPanel1.Controls.Add(ComboBox_Gender, 1, 6)
        TableLayoutPanel1.Controls.Add(ComboBox_CivilStatus, 1, 8)
        TableLayoutPanel1.Controls.Add(Txt_InputFirstName, 1, 1)
        TableLayoutPanel1.Controls.Add(Txt_InputLastName, 1, 0)
        TableLayoutPanel1.Controls.Add(CheckBox_MiddleName, 1, 3)
        TableLayoutPanel1.Controls.Add(Btn_Clear, 1, 12)
        TableLayoutPanel1.Controls.Add(Lbl_CountryCode, 1, 10)
        TableLayoutPanel1.Location = New Point(23, 85)
        TableLayoutPanel1.Margin = New Padding(5, 5, 5, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 13
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.6056347F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.154929F))
        TableLayoutPanel1.Size = New Size(474, 684)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Btn_Save
        ' 
        Btn_Save.Anchor = AnchorStyles.None
        Btn_Save.BackColor = Color.White
        Btn_Save.FlatStyle = FlatStyle.Flat
        Btn_Save.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Save.ForeColor = Color.Black
        Btn_Save.Location = New Point(346, 634)
        Btn_Save.Margin = New Padding(3, 4, 3, 4)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(97, 43)
        Btn_Save.TabIndex = 25
        Btn_Save.Text = "Save"
        Btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Btn_Cancel
        ' 
        Btn_Cancel.Anchor = AnchorStyles.None
        Btn_Cancel.BackColor = Color.White
        Btn_Cancel.FlatStyle = FlatStyle.Flat
        Btn_Cancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Cancel.ForeColor = Color.Black
        Btn_Cancel.Location = New Point(20, 634)
        Btn_Cancel.Margin = New Padding(3, 4, 3, 4)
        Btn_Cancel.Name = "Btn_Cancel"
        Btn_Cancel.Size = New Size(97, 43)
        Btn_Cancel.TabIndex = 23
        Btn_Cancel.Text = "Cancel"
        Btn_Cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_Clear
        ' 
        Btn_Clear.Anchor = AnchorStyles.None
        Btn_Clear.BackColor = Color.White
        Btn_Clear.FlatStyle = FlatStyle.Flat
        Btn_Clear.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Clear.ForeColor = Color.Black
        Btn_Clear.Location = New Point(177, 634)
        Btn_Clear.Margin = New Padding(3, 4, 3, 4)
        Btn_Clear.Name = "Btn_Clear"
        Btn_Clear.Size = New Size(97, 43)
        Btn_Clear.TabIndex = 24
        Btn_Clear.Text = "Clear"
        Btn_Clear.UseVisualStyleBackColor = True
        ' 
        ' Lbl_CountryCode
        ' 
        Lbl_CountryCode.AutoSize = True
        Lbl_CountryCode.BackColor = Color.White
        Lbl_CountryCode.BorderStyle = BorderStyle.FixedSingle
        Lbl_CountryCode.Dock = DockStyle.Fill
        Lbl_CountryCode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Lbl_CountryCode.ForeColor = Color.Black
        Lbl_CountryCode.Location = New Point(140, 468)
        Lbl_CountryCode.Margin = New Padding(3, 4, 3, 4)
        Lbl_CountryCode.Name = "Lbl_CountryCode"
        Lbl_CountryCode.Padding = New Padding(6, 7, 6, 7)
        Lbl_CountryCode.Size = New Size(172, 48)
        Lbl_CountryCode.TabIndex = 26
        Lbl_CountryCode.Text = "+63"
        Lbl_CountryCode.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel_Header
        ' 
        Panel_Header.BackColor = Color.White
        Panel_Header.Controls.Add(Lbl_FormTitle)
        Panel_Header.Dock = DockStyle.Top
        Panel_Header.Location = New Point(0, 0)
        Panel_Header.Margin = New Padding(3, 4, 3, 4)
        Panel_Header.Name = "Panel_Header"
        Panel_Header.Size = New Size(520, 80)
        Panel_Header.TabIndex = 27
        ' 
        ' Lbl_FormTitle
        ' 
        Lbl_FormTitle.Dock = DockStyle.Fill
        Lbl_FormTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_FormTitle.ForeColor = Color.Black
        Lbl_FormTitle.Location = New Point(0, 0)
        Lbl_FormTitle.Name = "Lbl_FormTitle"
        Lbl_FormTitle.Size = New Size(520, 80)
        Lbl_FormTitle.TabIndex = 0
        Lbl_FormTitle.Text = "Registration Form"
        Lbl_FormTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Add_edit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(520, 787)
        Controls.Add(Panel_Header)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Add_edit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel_Header.ResumeLayout(False)
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
    Friend WithEvents ComboBox_Nationality As ComboBox
    Friend WithEvents Lbl_Nationality As Label
    Friend WithEvents Txt_InputContact As TextBox
    Friend WithEvents Lbl_Contact As Label
    Friend WithEvents Lbl_Address As Label
    Friend WithEvents Txt_InputAddress As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Lbl_CountryCode As Label
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Lbl_FormTitle As Label

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class