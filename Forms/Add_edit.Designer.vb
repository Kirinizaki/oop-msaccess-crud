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
        Txt_InputLastName.Location = New Point(122, 11)
        Txt_InputLastName.Margin = New Padding(2)
        Txt_InputLastName.Name = "Txt_InputLastName"
        Txt_InputLastName.Size = New Size(232, 21)
        Txt_InputLastName.TabIndex = 0
        ' 
        ' Txt_InputFirstName
        ' 
        Txt_InputFirstName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputFirstName, 2)
        Txt_InputFirstName.Location = New Point(122, 54)
        Txt_InputFirstName.Margin = New Padding(2)
        Txt_InputFirstName.Name = "Txt_InputFirstName"
        Txt_InputFirstName.Size = New Size(232, 21)
        Txt_InputFirstName.TabIndex = 1
        ' 
        ' Txt_InputMiddleName
        ' 
        Txt_InputMiddleName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputMiddleName, 2)
        Txt_InputMiddleName.Location = New Point(122, 97)
        Txt_InputMiddleName.Margin = New Padding(2)
        Txt_InputMiddleName.Name = "Txt_InputMiddleName"
        Txt_InputMiddleName.Size = New Size(232, 21)
        Txt_InputMiddleName.TabIndex = 2
        ' 
        ' CheckBox_MiddleName
        ' 
        CheckBox_MiddleName.AutoSize = True
        CheckBox_MiddleName.CheckAlign = ContentAlignment.TopLeft
        TableLayoutPanel1.SetColumnSpan(CheckBox_MiddleName, 2)
        CheckBox_MiddleName.Dock = DockStyle.Fill
        CheckBox_MiddleName.Location = New Point(122, 131)
        CheckBox_MiddleName.Margin = New Padding(2)
        CheckBox_MiddleName.Name = "CheckBox_MiddleName"
        CheckBox_MiddleName.Size = New Size(311, 39)
        CheckBox_MiddleName.TabIndex = 3
        CheckBox_MiddleName.Text = "No Middle Name"
        CheckBox_MiddleName.TextAlign = ContentAlignment.TopLeft
        CheckBox_MiddleName.UseVisualStyleBackColor = True
        ' 
        ' Lbl_LastName
        ' 
        Lbl_LastName.AutoSize = True
        Lbl_LastName.Dock = DockStyle.Fill
        Lbl_LastName.Location = New Point(2, 0)
        Lbl_LastName.Margin = New Padding(2, 0, 2, 0)
        Lbl_LastName.Name = "Lbl_LastName"
        Lbl_LastName.Size = New Size(116, 43)
        Lbl_LastName.TabIndex = 4
        Lbl_LastName.Text = "Last Name: *"
        Lbl_LastName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_FirstName
        ' 
        Lbl_FirstName.AutoSize = True
        Lbl_FirstName.Dock = DockStyle.Fill
        Lbl_FirstName.Location = New Point(2, 43)
        Lbl_FirstName.Margin = New Padding(2, 0, 2, 0)
        Lbl_FirstName.Name = "Lbl_FirstName"
        Lbl_FirstName.Size = New Size(116, 43)
        Lbl_FirstName.TabIndex = 5
        Lbl_FirstName.Text = "First Name: *"
        Lbl_FirstName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_Suffix
        ' 
        Lbl_Suffix.AutoSize = True
        Lbl_Suffix.Dock = DockStyle.Fill
        Lbl_Suffix.Location = New Point(2, 172)
        Lbl_Suffix.Margin = New Padding(2, 0, 2, 0)
        Lbl_Suffix.Name = "Lbl_Suffix"
        Lbl_Suffix.Size = New Size(116, 27)
        Lbl_Suffix.TabIndex = 6
        Lbl_Suffix.Text = "Suffix:"
        Lbl_Suffix.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_MiddleName
        ' 
        Lbl_MiddleName.AutoSize = True
        Lbl_MiddleName.Dock = DockStyle.Fill
        Lbl_MiddleName.Location = New Point(2, 86)
        Lbl_MiddleName.Margin = New Padding(2, 0, 2, 0)
        Lbl_MiddleName.Name = "Lbl_MiddleName"
        Lbl_MiddleName.Size = New Size(116, 43)
        Lbl_MiddleName.TabIndex = 8
        Lbl_MiddleName.Text = "Middle Name:"
        Lbl_MiddleName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Suffix
        ' 
        ComboBox_Suffix.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_Suffix, 2)
        ComboBox_Suffix.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Suffix.Font = New Font("Segoe UI", 9.0F)
        ComboBox_Suffix.FormattingEnabled = True
        ComboBox_Suffix.Location = New Point(122, 174)
        ComboBox_Suffix.Margin = New Padding(2)
        ComboBox_Suffix.Name = "ComboBox_Suffix"
        ComboBox_Suffix.Size = New Size(232, 23)
        ComboBox_Suffix.TabIndex = 9
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(DateTimePicker, 2)
        DateTimePicker.Location = New Point(122, 210)
        DateTimePicker.Margin = New Padding(2)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(232, 21)
        DateTimePicker.TabIndex = 10
        ' 
        ' Lbl_Birthdate
        ' 
        Lbl_Birthdate.AutoSize = True
        Lbl_Birthdate.Dock = DockStyle.Fill
        Lbl_Birthdate.Location = New Point(2, 199)
        Lbl_Birthdate.Margin = New Padding(2, 0, 2, 0)
        Lbl_Birthdate.Name = "Lbl_Birthdate"
        Lbl_Birthdate.Size = New Size(116, 43)
        Lbl_Birthdate.TabIndex = 11
        Lbl_Birthdate.Text = "Birthdate: *"
        Lbl_Birthdate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Gender
        ' 
        ComboBox_Gender.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_Gender, 2)
        ComboBox_Gender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Gender.Font = New Font("Segoe UI", 9.0F)
        ComboBox_Gender.FormattingEnabled = True
        ComboBox_Gender.Location = New Point(122, 252)
        ComboBox_Gender.Margin = New Padding(2)
        ComboBox_Gender.Name = "ComboBox_Gender"
        ComboBox_Gender.Size = New Size(232, 23)
        ComboBox_Gender.TabIndex = 12
        ' 
        ' Lbl_Gender
        ' 
        Lbl_Gender.AutoSize = True
        Lbl_Gender.Dock = DockStyle.Fill
        Lbl_Gender.Location = New Point(2, 242)
        Lbl_Gender.Margin = New Padding(2, 0, 2, 0)
        Lbl_Gender.Name = "Lbl_Gender"
        Lbl_Gender.Size = New Size(116, 43)
        Lbl_Gender.TabIndex = 13
        Lbl_Gender.Text = "Gender:"
        Lbl_Gender.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_CivilStatus
        ' 
        ComboBox_CivilStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(ComboBox_CivilStatus, 2)
        ComboBox_CivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_CivilStatus.Font = New Font("Segoe UI", 9.0F)
        ComboBox_CivilStatus.FormattingEnabled = True
        ComboBox_CivilStatus.Location = New Point(122, 287)
        ComboBox_CivilStatus.Margin = New Padding(2)
        ComboBox_CivilStatus.Name = "ComboBox_CivilStatus"
        ComboBox_CivilStatus.Size = New Size(232, 23)
        ComboBox_CivilStatus.TabIndex = 15
        ' 
        ' Lbl_CivilStatus
        ' 
        Lbl_CivilStatus.AutoSize = True
        Lbl_CivilStatus.Dock = DockStyle.Fill
        Lbl_CivilStatus.Location = New Point(2, 285)
        Lbl_CivilStatus.Margin = New Padding(2, 0, 2, 0)
        Lbl_CivilStatus.Name = "Lbl_CivilStatus"
        Lbl_CivilStatus.Size = New Size(116, 27)
        Lbl_CivilStatus.TabIndex = 16
        Lbl_CivilStatus.Text = "Civil Status:"
        Lbl_CivilStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Nationality
        ' 
        Txt_InputNationality.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputNationality, 2)
        Txt_InputNationality.Location = New Point(122, 323)
        Txt_InputNationality.Margin = New Padding(2)
        Txt_InputNationality.Name = "Txt_InputNationality"
        Txt_InputNationality.Size = New Size(232, 21)
        Txt_InputNationality.TabIndex = 17
        ' 
        ' Lbl_Nationality
        ' 
        Lbl_Nationality.AutoSize = True
        Lbl_Nationality.Dock = DockStyle.Fill
        Lbl_Nationality.Location = New Point(2, 312)
        Lbl_Nationality.Margin = New Padding(2, 0, 2, 0)
        Lbl_Nationality.Name = "Lbl_Nationality"
        Lbl_Nationality.Size = New Size(116, 43)
        Lbl_Nationality.TabIndex = 18
        Lbl_Nationality.Text = "Nationality: *"
        Lbl_Nationality.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputContact
        ' 
        Txt_InputContact.Anchor = AnchorStyles.Left
        TableLayoutPanel1.SetColumnSpan(Txt_InputContact, 2)
        Txt_InputContact.Location = New Point(122, 366)
        Txt_InputContact.Margin = New Padding(2)
        Txt_InputContact.Name = "Txt_InputContact"
        Txt_InputContact.Size = New Size(232, 21)
        Txt_InputContact.TabIndex = 19
        ' 
        ' Lbl_Contact
        ' 
        Lbl_Contact.AutoSize = True
        Lbl_Contact.Dock = DockStyle.Fill
        Lbl_Contact.Location = New Point(2, 355)
        Lbl_Contact.Margin = New Padding(2, 0, 2, 0)
        Lbl_Contact.Name = "Lbl_Contact"
        Lbl_Contact.Size = New Size(116, 43)
        Lbl_Contact.TabIndex = 20
        Lbl_Contact.Text = "Contact No.: *"
        Lbl_Contact.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Lbl_Address
        ' 
        Lbl_Address.AutoSize = True
        Lbl_Address.Dock = DockStyle.Fill
        Lbl_Address.Location = New Point(2, 398)
        Lbl_Address.Margin = New Padding(2, 0, 2, 0)
        Lbl_Address.Name = "Lbl_Address"
        Lbl_Address.Size = New Size(116, 43)
        Lbl_Address.TabIndex = 21
        Lbl_Address.Text = "Address: *"
        Lbl_Address.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txt_InputAddress
        ' 
        Txt_InputAddress.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(Txt_InputAddress, 2)
        Txt_InputAddress.Location = New Point(122, 409)
        Txt_InputAddress.Margin = New Padding(2)
        Txt_InputAddress.Name = "Txt_InputAddress"
        Txt_InputAddress.Size = New Size(232, 21)
        Txt_InputAddress.TabIndex = 22
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.6366673F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.03F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 18.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 18.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 18.0F))
        TableLayoutPanel1.Controls.Add(Lbl_LastName, 0, 0)
        TableLayoutPanel1.Controls.Add(Button3, 2, 12)
        TableLayoutPanel1.Controls.Add(Lbl_FirstName, 0, 1)
        TableLayoutPanel1.Controls.Add(Lbl_MiddleName, 0, 2)
        TableLayoutPanel1.Controls.Add(Button1, 0, 12)
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
        TableLayoutPanel1.Controls.Add(Button2, 1, 12)
        TableLayoutPanel1.Location = New Point(0, -2)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.Size = New Size(435, 488)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.Location = New Point(316, 449)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 30)
        Button3.TabIndex = 25
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Location = New Point(12, 449)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 30)
        Button1.TabIndex = 23
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Location = New Point(148, 449)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 30)
        Button2.TabIndex = 24
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Add_edit
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 487)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(2)
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

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
