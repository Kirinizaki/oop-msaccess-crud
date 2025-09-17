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
        SuspendLayout()
        ' 
        ' Txt_InputLastName
        ' 
        Txt_InputLastName.Location = New Point(117, 25)
        Txt_InputLastName.Margin = New Padding(2, 2, 2, 2)
        Txt_InputLastName.Name = "Txt_InputLastName"
        Txt_InputLastName.Size = New Size(255, 27)
        Txt_InputLastName.TabIndex = 0
        ' 
        ' Txt_InputFirstName
        ' 
        Txt_InputFirstName.Location = New Point(117, 63)
        Txt_InputFirstName.Margin = New Padding(2, 2, 2, 2)
        Txt_InputFirstName.Name = "Txt_InputFirstName"
        Txt_InputFirstName.Size = New Size(255, 27)
        Txt_InputFirstName.TabIndex = 1
        ' 
        ' Txt_InputMiddleName
        ' 
        Txt_InputMiddleName.Location = New Point(117, 102)
        Txt_InputMiddleName.Margin = New Padding(2, 2, 2, 2)
        Txt_InputMiddleName.Name = "Txt_InputMiddleName"
        Txt_InputMiddleName.Size = New Size(255, 27)
        Txt_InputMiddleName.TabIndex = 2
        ' 
        ' CheckBox_MiddleName
        ' 
        CheckBox_MiddleName.AutoSize = True
        CheckBox_MiddleName.Location = New Point(117, 131)
        CheckBox_MiddleName.Margin = New Padding(2, 2, 2, 2)
        CheckBox_MiddleName.Name = "CheckBox_MiddleName"
        CheckBox_MiddleName.Size = New Size(146, 24)
        CheckBox_MiddleName.TabIndex = 3
        CheckBox_MiddleName.Text = "No Middle Name"
        CheckBox_MiddleName.UseVisualStyleBackColor = True
        ' 
        ' Lbl_LastName
        ' 
        Lbl_LastName.AutoSize = True
        Lbl_LastName.Location = New Point(36, 30)
        Lbl_LastName.Margin = New Padding(2, 0, 2, 0)
        Lbl_LastName.Name = "Lbl_LastName"
        Lbl_LastName.Size = New Size(82, 20)
        Lbl_LastName.TabIndex = 4
        Lbl_LastName.Text = "Last Name:"
        ' 
        ' Lbl_FirstName
        ' 
        Lbl_FirstName.AutoSize = True
        Lbl_FirstName.Location = New Point(34, 68)
        Lbl_FirstName.Margin = New Padding(2, 0, 2, 0)
        Lbl_FirstName.Name = "Lbl_FirstName"
        Lbl_FirstName.Size = New Size(83, 20)
        Lbl_FirstName.TabIndex = 5
        Lbl_FirstName.Text = "First Name:"
        ' 
        ' Lbl_Suffix
        ' 
        Lbl_Suffix.AutoSize = True
        Lbl_Suffix.Location = New Point(67, 172)
        Lbl_Suffix.Margin = New Padding(2, 0, 2, 0)
        Lbl_Suffix.Name = "Lbl_Suffix"
        Lbl_Suffix.Size = New Size(49, 20)
        Lbl_Suffix.TabIndex = 6
        Lbl_Suffix.Text = "Suffix:"
        ' 
        ' Lbl_MiddleName
        ' 
        Lbl_MiddleName.AutoSize = True
        Lbl_MiddleName.Location = New Point(17, 106)
        Lbl_MiddleName.Margin = New Padding(2, 0, 2, 0)
        Lbl_MiddleName.Name = "Lbl_MiddleName"
        Lbl_MiddleName.Size = New Size(103, 20)
        Lbl_MiddleName.TabIndex = 8
        Lbl_MiddleName.Text = "Middle Name:"
        ' 
        ' ComboBox_Suffix
        ' 
        ComboBox_Suffix.FormattingEnabled = True
        ComboBox_Suffix.Location = New Point(117, 170)
        ComboBox_Suffix.Margin = New Padding(2, 2, 2, 2)
        ComboBox_Suffix.Name = "ComboBox_Suffix"
        ComboBox_Suffix.Size = New Size(146, 28)
        ComboBox_Suffix.TabIndex = 9
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(117, 210)
        DateTimePicker.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(241, 27)
        DateTimePicker.TabIndex = 10
        ' 
        ' Lbl_Birthdate
        ' 
        Lbl_Birthdate.AutoSize = True
        Lbl_Birthdate.Location = New Point(42, 214)
        Lbl_Birthdate.Margin = New Padding(2, 0, 2, 0)
        Lbl_Birthdate.Name = "Lbl_Birthdate"
        Lbl_Birthdate.Size = New Size(73, 20)
        Lbl_Birthdate.TabIndex = 11
        Lbl_Birthdate.Text = "Birthdate:"
        ' 
        ' ComboBox_Gender
        ' 
        ComboBox_Gender.FormattingEnabled = True
        ComboBox_Gender.Location = New Point(117, 250)
        ComboBox_Gender.Margin = New Padding(2, 2, 2, 2)
        ComboBox_Gender.Name = "ComboBox_Gender"
        ComboBox_Gender.Size = New Size(146, 28)
        ComboBox_Gender.TabIndex = 12
        ' 
        ' Lbl_Gender
        ' 
        Lbl_Gender.AutoSize = True
        Lbl_Gender.Location = New Point(54, 253)
        Lbl_Gender.Margin = New Padding(2, 0, 2, 0)
        Lbl_Gender.Name = "Lbl_Gender"
        Lbl_Gender.Size = New Size(60, 20)
        Lbl_Gender.TabIndex = 13
        Lbl_Gender.Text = "Gender:"
        ' 
        ' ComboBox_CivilStatus
        ' 
        ComboBox_CivilStatus.FormattingEnabled = True
        ComboBox_CivilStatus.Location = New Point(117, 290)
        ComboBox_CivilStatus.Margin = New Padding(2, 2, 2, 2)
        ComboBox_CivilStatus.Name = "ComboBox_CivilStatus"
        ComboBox_CivilStatus.Size = New Size(146, 28)
        ComboBox_CivilStatus.TabIndex = 15
        ' 
        ' Lbl_CivilStatus
        ' 
        Lbl_CivilStatus.AutoSize = True
        Lbl_CivilStatus.Location = New Point(31, 293)
        Lbl_CivilStatus.Margin = New Padding(2, 0, 2, 0)
        Lbl_CivilStatus.Name = "Lbl_CivilStatus"
        Lbl_CivilStatus.Size = New Size(84, 20)
        Lbl_CivilStatus.TabIndex = 16
        Lbl_CivilStatus.Text = "Civil Status:"
        ' 
        ' Txt_InputNationality
        ' 
        Txt_InputNationality.Location = New Point(117, 332)
        Txt_InputNationality.Margin = New Padding(2, 2, 2, 2)
        Txt_InputNationality.Name = "Txt_InputNationality"
        Txt_InputNationality.Size = New Size(255, 27)
        Txt_InputNationality.TabIndex = 17
        ' 
        ' Lbl_Nationality
        ' 
        Lbl_Nationality.AutoSize = True
        Lbl_Nationality.Location = New Point(31, 334)
        Lbl_Nationality.Margin = New Padding(2, 0, 2, 0)
        Lbl_Nationality.Name = "Lbl_Nationality"
        Lbl_Nationality.Size = New Size(85, 20)
        Lbl_Nationality.TabIndex = 18
        Lbl_Nationality.Text = "Nationality:"
        ' 
        ' Txt_InputContact
        ' 
        Txt_InputContact.Location = New Point(117, 375)
        Txt_InputContact.Margin = New Padding(2, 2, 2, 2)
        Txt_InputContact.Name = "Txt_InputContact"
        Txt_InputContact.Size = New Size(255, 27)
        Txt_InputContact.TabIndex = 19
        ' 
        ' Lbl_Contact
        ' 
        Lbl_Contact.AutoSize = True
        Lbl_Contact.Location = New Point(24, 378)
        Lbl_Contact.Margin = New Padding(2, 0, 2, 0)
        Lbl_Contact.Name = "Lbl_Contact"
        Lbl_Contact.Size = New Size(90, 20)
        Lbl_Contact.TabIndex = 20
        Lbl_Contact.Text = "Contact No.:"
        ' 
        ' Lbl_Address
        ' 
        Lbl_Address.AutoSize = True
        Lbl_Address.Location = New Point(56, 421)
        Lbl_Address.Margin = New Padding(2, 0, 2, 0)
        Lbl_Address.Name = "Lbl_Address"
        Lbl_Address.Size = New Size(56, 20)
        Lbl_Address.TabIndex = 21
        Lbl_Address.Text = "Adress:"
        ' 
        ' Txt_InputAddress
        ' 
        Txt_InputAddress.Location = New Point(117, 418)
        Txt_InputAddress.Margin = New Padding(2, 2, 2, 2)
        Txt_InputAddress.Name = "Txt_InputAddress"
        Txt_InputAddress.Size = New Size(255, 27)
        Txt_InputAddress.TabIndex = 22
        ' 
        ' Add_edit
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(381, 498)
        Controls.Add(Txt_InputAddress)
        Controls.Add(Lbl_Address)
        Controls.Add(Lbl_Contact)
        Controls.Add(Txt_InputContact)
        Controls.Add(Lbl_Nationality)
        Controls.Add(Txt_InputNationality)
        Controls.Add(Lbl_CivilStatus)
        Controls.Add(ComboBox_CivilStatus)
        Controls.Add(Lbl_Gender)
        Controls.Add(ComboBox_Gender)
        Controls.Add(Lbl_Birthdate)
        Controls.Add(DateTimePicker)
        Controls.Add(ComboBox_Suffix)
        Controls.Add(Lbl_MiddleName)
        Controls.Add(Lbl_Suffix)
        Controls.Add(Lbl_FirstName)
        Controls.Add(Lbl_LastName)
        Controls.Add(CheckBox_MiddleName)
        Controls.Add(Txt_InputMiddleName)
        Controls.Add(Txt_InputFirstName)
        Controls.Add(Txt_InputLastName)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Add_edit"
        Text = "Regitration"
        ResumeLayout(False)
        PerformLayout()
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
End Class
