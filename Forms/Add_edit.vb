Imports System.Data.OleDb
Imports System.IO

Public Class Add_edit


    Private Sub Add_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'yung pang clear button'
        Txt_InputLastName.Text = ""
        Txt_InputFirstName.Text = ""
        Txt_InputMiddleName.Text = ""
        CheckBox_MiddleName.Checked = False
        ComboBox_CivilStatus.SelectedIndex = -1
        ComboBox_Suffix.SelectedIndex = -1
        ComboBox_Gender.SelectedIndex = -1
        DateTimePicker.Value = DateTime.Now
        Txt_InputNationality.Text = ""
        Txt_InputContact.Text = ""
        Txt_InputAddress.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class