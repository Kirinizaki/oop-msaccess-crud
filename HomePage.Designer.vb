<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        DataGridView1 = New DataGridView()
        NewButton = New Button()
        RefreshButton = New Button()
        ViewButton = New DataGridViewButtonColumn()
        EditButton = New DataGridViewButtonColumn()
        DeleteButton = New DataGridViewButtonColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ViewButton, EditButton, DeleteButton})
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(910, 421)
        DataGridView1.TabIndex = 0
        ' 
        ' NewButton
        ' 
        NewButton.Location = New Point(374, 442)
        NewButton.Name = "NewButton"
        NewButton.Size = New Size(220, 57)
        NewButton.TabIndex = 1
        NewButton.Text = "Add New"
        NewButton.UseVisualStyleBackColor = True
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(838, 439)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(84, 38)
        RefreshButton.TabIndex = 2
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
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
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 511)
        Controls.Add(RefreshButton)
        Controls.Add(NewButton)
        Controls.Add(DataGridView1)
        Name = "HomePage"
        Text = "HomePage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NewButton As Button
    Friend WithEvents ViewButton As DataGridViewButtonColumn
    Friend WithEvents EditButton As DataGridViewButtonColumn
    Friend WithEvents DeleteButton As DataGridViewButtonColumn
    Friend WithEvents RefreshButton As Button
End Class
