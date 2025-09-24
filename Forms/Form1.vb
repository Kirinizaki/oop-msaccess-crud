Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList

        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.Items.Add("Owned")
        ComboBox4.Items.Add("Rented")
        ComboBox4.Items.Add("Temporary Housing")
        ComboBox4.Items.Add("Others")

        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.Items.Add("Citizen")
        ComboBox5.Items.Add("Permanent Resident")
        ComboBox5.Items.Add("Temporary Resident")
        ComboBox5.Items.Add("Refugee")
        ComboBox5.Items.Add("Others")
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLastNametext.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs)
        ' Create OpenFileDialog
        Dim ofd As New OpenFileDialog

        ' Allow only image file types
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ofd.Title = "Select an Image"


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblMotherText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblEmailText_Click(sender As Object, e As EventArgs) Handles lblEmailText.Click

    End Sub


    Private Sub lblHeightText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub lblGenderText_Click(sender As Object, e As EventArgs) Handles lblGenderText.Click
        ' Your code here (or leave empty if you don't need to do anything)
    End Sub
    Private Sub lblBirthdayText_Click(sender As Object, e As EventArgs) Handles lblBirthdayText.Click
        ' You can leave this empty or add code if needed
    End Sub

    Private Sub lblAgeText_Click(sender As Object, e As EventArgs) Handles lblAgeText.Click
        ' Leave empty or add code if you want something to happen when the label is clicked
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub lblMobileText_Click(sender As Object, e As EventArgs) Handles lblMobileText.Click
        ' Add code here if you want something to happen when the label is clicked
    End Sub

    Private Sub TableLayoutPanel10_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel10.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub lblCivilStatusText_Click(sender As Object, e As EventArgs) Handles lblCivilStatusText.Click
        ' You can add code here if you want the label to respond to clicks
    End Sub

End Class
