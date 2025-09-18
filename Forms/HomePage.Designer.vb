<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        DataGridView1 = New DataGridView()
        Btn_Add = New Button()
        RefreshButton = New Button()
        Btn_Edit = New Button()
        Btn_Delete = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel_Header = New Panel()
        Lbl_Title = New Label()
        Lbl_Subtitle = New Label()
        Panel_DataGrid = New Panel()
        Panel_Footer = New Panel()
        Lbl_RecordCount = New Label()
        Lbl_StatusInfo = New Label()
        Panel_ButtonContainer = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel_Header.SuspendLayout()
        Panel_DataGrid.SuspendLayout()
        Panel_Footer.SuspendLayout()
        Panel_ButtonContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText
        DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        DataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
        DataGridView1.ColumnHeadersHeight = 23
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.DefaultCellStyle.BackColor = SystemColors.Window
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25F)
        DataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText
        DataGridView1.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        DataGridView1.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
        DataGridView1.EnableHeadersVisualStyles = True
        DataGridView1.GridColor = SystemColors.ControlDark
        DataGridView1.Location = New Point(15, 15)
        DataGridView1.Margin = New Padding(15)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 22
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(770, 289)
        DataGridView1.TabIndex = 0
        ' 
        ' Btn_Add
        ' 
        Btn_Add.Dock = DockStyle.Fill
        Btn_Add.Location = New Point(3, 3)
        Btn_Add.Name = "Btn_Add"
        Btn_Add.Size = New Size(186, 44)
        Btn_Add.TabIndex = 1
        Btn_Add.Text = "Add New"
        Btn_Add.UseVisualStyleBackColor = True
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Dock = DockStyle.Fill
        RefreshButton.Location = New Point(579, 3)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(186, 44)
        RefreshButton.TabIndex = 2
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' Btn_Edit
        ' 
        Btn_Edit.Dock = DockStyle.Fill
        Btn_Edit.Location = New Point(195, 3)
        Btn_Edit.Name = "Btn_Edit"
        Btn_Edit.Size = New Size(186, 44)
        Btn_Edit.TabIndex = 3
        Btn_Edit.Text = "Edit"
        Btn_Edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_Delete
        ' 
        Btn_Delete.BackColor = Color.FromArgb(250, 240, 240)
        Btn_Delete.Dock = DockStyle.Fill
        Btn_Delete.FlatAppearance.BorderColor = Color.FromArgb(220, 180, 180)
        Btn_Delete.FlatAppearance.BorderSize = 1
        Btn_Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 200, 200)
        Btn_Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 220, 220)
        Btn_Delete.FlatStyle = FlatStyle.Flat
        Btn_Delete.ForeColor = Color.FromArgb(120, 80, 80)
        Btn_Delete.Location = New Point(387, 3)
        Btn_Delete.Name = "Btn_Delete"
        Btn_Delete.Size = New Size(186, 44)
        Btn_Delete.TabIndex = 4
        Btn_Delete.Text = "Delete"
        Btn_Delete.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.Controls.Add(Btn_Add, 0, 0)
        TableLayoutPanel1.Controls.Add(RefreshButton, 3, 0)
        TableLayoutPanel1.Controls.Add(Btn_Delete, 2, 0)
        TableLayoutPanel1.Controls.Add(Btn_Edit, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(15, 15)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Size = New Size(770, 50)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Controls.Add(Panel_Header, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel_DataGrid, 0, 1)
        TableLayoutPanel2.Controls.Add(Panel_ButtonContainer, 0, 2)
        TableLayoutPanel2.Controls.Add(Panel_Footer, 0, 3)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 80.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 80.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        TableLayoutPanel2.Size = New Size(800, 600)
        TableLayoutPanel2.TabIndex = 6
        ' 
        ' Panel_Header
        ' 
        Panel_Header.BorderStyle = BorderStyle.None
        Panel_Header.Controls.Add(Lbl_Subtitle)
        Panel_Header.Controls.Add(Lbl_Title)
        Panel_Header.Dock = DockStyle.Fill
        Panel_Header.Location = New Point(0, 0)
        Panel_Header.Margin = New Padding(0)
        Panel_Header.Name = "Panel_Header"
        Panel_Header.Padding = New Padding(20, 15, 20, 5)
        Panel_Header.Size = New Size(800, 80)
        Panel_Header.TabIndex = 7
        ' 
        ' Lbl_Title
        ' 
        Lbl_Title.Dock = DockStyle.Top
        Lbl_Title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Lbl_Title.Location = New Point(20, 15)
        Lbl_Title.Name = "Lbl_Title"
        Lbl_Title.Size = New Size(760, 35)
        Lbl_Title.TabIndex = 0
        Lbl_Title.Text = "Registration Management System"
        Lbl_Title.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Lbl_Subtitle
        ' 
        Lbl_Subtitle.Dock = DockStyle.Bottom
        Lbl_Subtitle.Font = New Font("Microsoft Sans Serif", 8.25F)
        Lbl_Subtitle.ForeColor = SystemColors.ControlDarkDark
        Lbl_Subtitle.Location = New Point(20, 50)
        Lbl_Subtitle.Name = "Lbl_Subtitle"
        Lbl_Subtitle.Size = New Size(760, 25)
        Lbl_Subtitle.TabIndex = 1
        Lbl_Subtitle.Text = "Manage and view all registration records"
        Lbl_Subtitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel_DataGrid
        ' 
        Panel_DataGrid.Controls.Add(DataGridView1)
        Panel_DataGrid.Dock = DockStyle.Fill
        Panel_DataGrid.Location = New Point(0, 80)
        Panel_DataGrid.Margin = New Padding(0)
        Panel_DataGrid.Name = "Panel_DataGrid"
        Panel_DataGrid.Size = New Size(800, 400)
        Panel_DataGrid.TabIndex = 8
        ' 
        ' Panel_Footer
        ' 
        Panel_Footer.BorderStyle = BorderStyle.None
        Panel_Footer.Controls.Add(Lbl_StatusInfo)
        Panel_Footer.Controls.Add(Lbl_RecordCount)
        Panel_Footer.Dock = DockStyle.Fill
        Panel_Footer.Location = New Point(0, 560)
        Panel_Footer.Margin = New Padding(0)
        Panel_Footer.Name = "Panel_Footer"
        Panel_Footer.Padding = New Padding(20, 5, 20, 5)
        Panel_Footer.Size = New Size(800, 40)
        Panel_Footer.TabIndex = 9
        ' 
        ' Lbl_RecordCount
        ' 
        Lbl_RecordCount.Dock = DockStyle.Left
        Lbl_RecordCount.Font = New Font("Microsoft Sans Serif", 8.25F)
        Lbl_RecordCount.Location = New Point(20, 5)
        Lbl_RecordCount.Name = "Lbl_RecordCount"
        Lbl_RecordCount.Size = New Size(200, 30)
        Lbl_RecordCount.TabIndex = 0
        Lbl_RecordCount.Text = "Total Records: 0"
        Lbl_RecordCount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Lbl_StatusInfo
        ' 
        Lbl_StatusInfo.Dock = DockStyle.Right
        Lbl_StatusInfo.Font = New Font("Microsoft Sans Serif", 8.25F)
        Lbl_StatusInfo.ForeColor = SystemColors.ControlDarkDark
        Lbl_StatusInfo.Location = New Point(600, 5)
        Lbl_StatusInfo.Name = "Lbl_StatusInfo"
        Lbl_StatusInfo.Size = New Size(180, 30)
        Lbl_StatusInfo.TabIndex = 1
        Lbl_StatusInfo.Text = "Double-click to edit"
        Lbl_StatusInfo.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel_ButtonContainer
        ' 
        Panel_ButtonContainer.Controls.Add(TableLayoutPanel1)
        Panel_ButtonContainer.Dock = DockStyle.Fill
        Panel_ButtonContainer.Location = New Point(0, 480)
        Panel_ButtonContainer.Margin = New Padding(0)
        Panel_ButtonContainer.Name = "Panel_ButtonContainer"
        Panel_ButtonContainer.Padding = New Padding(15)
        Panel_ButtonContainer.Size = New Size(800, 80)
        Panel_ButtonContainer.TabIndex = 10
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 600)
        Controls.Add(TableLayoutPanel2)
        MinimumSize = New Size(816, 639)
        Name = "HomePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration Management System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel_Header.ResumeLayout(False)
        Panel_DataGrid.ResumeLayout(False)
        Panel_Footer.ResumeLayout(False)
        Panel_ButtonContainer.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_Add As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Lbl_Subtitle As Label
    Friend WithEvents Panel_DataGrid As Panel
    Friend WithEvents Panel_Footer As Panel
    Friend WithEvents Lbl_RecordCount As Label
    Friend WithEvents Lbl_StatusInfo As Label
    Friend WithEvents Panel_ButtonContainer As Panel
End Class