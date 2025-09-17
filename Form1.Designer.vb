<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration_System
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        ViewColumn = New DataGridViewButtonColumn()
        EditColumn = New DataGridViewButtonColumn()
        DeleteColumn = New DataGridViewButtonColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ViewColumn, EditColumn, DeleteColumn})
        DataGridView1.Location = New Point(12, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(912, 451)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(386, 519)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 56)
        Button1.TabIndex = 1
        Button1.Text = "Add New "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(812, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 2
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ViewColumn
        ' 
        ViewColumn.HeaderText = "View"
        ViewColumn.MinimumWidth = 8
        ViewColumn.Name = "ViewColumn"
        ViewColumn.Width = 150
        ' 
        ' EditColumn
        ' 
        EditColumn.HeaderText = "Edit"
        EditColumn.MinimumWidth = 8
        EditColumn.Name = "EditColumn"
        EditColumn.Width = 150
        ' 
        ' DeleteColumn
        ' 
        DeleteColumn.HeaderText = "Delete"
        DeleteColumn.MinimumWidth = 8
        DeleteColumn.Name = "DeleteColumn"
        DeleteColumn.Width = 150
        ' 
        ' Registration_System
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(936, 587)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "Registration_System"
        Text = "Registration System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ViewColumn As DataGridViewButtonColumn
    Friend WithEvents EditColumn As DataGridViewButtonColumn
    Friend WithEvents DeleteColumn As DataGridViewButtonColumn

End Class
