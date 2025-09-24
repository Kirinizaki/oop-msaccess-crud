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

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

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
End Class
