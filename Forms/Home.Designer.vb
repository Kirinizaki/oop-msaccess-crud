<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        NewButton = New Button()
        DataGridView1 = New DataGridView()
        ViewButton = New DataGridViewButtonColumn()
        EditButton = New DataGridViewButtonColumn()
        DeleteButton = New DataGridViewButtonColumn()
        RefreshButton = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NewButton
        ' 
        NewButton.Location = New Point(306, 449)
        NewButton.Margin = New Padding(4, 5, 4, 5)
        NewButton.Name = "NewButton"
        NewButton.Size = New Size(140, 60)
        NewButton.TabIndex = 0
        NewButton.Text = "Add New"
        NewButton.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ViewButton, EditButton, DeleteButton})
        DataGridView1.Location = New Point(12, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(676, 408)
        DataGridView1.TabIndex = 2
        ' 
        ' ViewButton
        ' 
        ViewButton.HeaderText = "View"
        ViewButton.MinimumWidth = 8
        ViewButton.Name = "ViewButton"
        ViewButton.Width = 150
        ' 
        ' EditButton
        ' 
        EditButton.HeaderText = "Edit"
        EditButton.MinimumWidth = 8
        EditButton.Name = "EditButton"
        EditButton.Width = 150
        ' 
        ' DeleteButton
        ' 
        DeleteButton.HeaderText = "Delete"
        DeleteButton.MinimumWidth = 8
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Width = 150
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(576, 438)
        RefreshButton.Margin = New Padding(4, 5, 4, 5)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(112, 33)
        RefreshButton.TabIndex = 3
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 523)
        Controls.Add(RefreshButton)
        Controls.Add(DataGridView1)
        Controls.Add(NewButton)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Home"
        Text = "Home"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents NewButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents ViewButton As DataGridViewButtonColumn
    Friend WithEvents EditButton As DataGridViewButtonColumn
    Friend WithEvents DeleteButton As DataGridViewButtonColumn

End Class
