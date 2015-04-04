<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNcalfQuery
    Inherits Cattle.FarmForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
Me.Label1 = New System.Windows.Forms.Label
Me.cmbgroup = New System.Windows.Forms.ComboBox
Me.Label3 = New System.Windows.Forms.Label
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Button1 = New System.Windows.Forms.Button
Me.Button2 = New System.Windows.Forms.Button
Me.lblnumrecs = New System.Windows.Forms.Label
Me.CaptionPanel.SuspendLayout()
Me.BottomPanel.SuspendLayout()
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'CaptionPanel
'
Me.CaptionPanel.Controls.Add(Me.lblnumrecs)
Me.CaptionPanel.Controls.Add(Me.Button2)
Me.CaptionPanel.Controls.Add(Me.Button1)
Me.CaptionPanel.Controls.Add(Me.Label3)
Me.CaptionPanel.Controls.Add(Me.cmbgroup)
Me.CaptionPanel.Controls.Add(Me.Label1)
Me.CaptionPanel.Size = New System.Drawing.Size(631, 106)
'
'BottomPanel
'
Me.BottomPanel.Controls.Add(Me.DataGridView1)
Me.BottomPanel.Location = New System.Drawing.Point(0, 124)
Me.BottomPanel.Size = New System.Drawing.Size(631, 220)
'
'LeftPanel
'
Me.LeftPanel.Location = New System.Drawing.Point(0, 106)
Me.LeftPanel.Size = New System.Drawing.Size(236, 18)
'
'RightPanel
'
Me.RightPanel.Location = New System.Drawing.Point(236, 106)
Me.RightPanel.Size = New System.Drawing.Size(395, 18)
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(23, 53)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(80, 13)
Me.Label1.TabIndex = 0
Me.Label1.Text = "Group equal to:"
'
'cmbgroup
'
Me.cmbgroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
Me.cmbgroup.FormattingEnabled = True
Me.cmbgroup.Location = New System.Drawing.Point(109, 53)
Me.cmbgroup.MaxLength = 12
Me.cmbgroup.Name = "cmbgroup"
Me.cmbgroup.Size = New System.Drawing.Size(397, 21)
Me.cmbgroup.TabIndex = 2
'
'Label3
'
Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.Label3.AutoSize = True
Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label3.Location = New System.Drawing.Point(107, 14)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(133, 29)
Me.Label3.TabIndex = 4
Me.Label3.Text = "No Calves"
'
'DataGridView1
'
DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
Me.DataGridView1.BackgroundColor = System.Drawing.Color.Tan
DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
DataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue
DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3})
Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(631, 220)
Me.DataGridView1.TabIndex = 0
'
'Column1
'
Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
Me.Column1.DataPropertyName = "cow_number"
Me.Column1.FillWeight = 189.6907!
Me.Column1.HeaderText = "Cow Number"
Me.Column1.Name = "Column1"
Me.Column1.ReadOnly = True
Me.Column1.Width = 93
'
'Column4
'
Me.Column4.DataPropertyName = "calf_group"
Me.Column4.HeaderText = "Group"
Me.Column4.Name = "Column4"
Me.Column4.ReadOnly = True
Me.Column4.Width = 225
'
'Column2
'
Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
Me.Column2.DataPropertyName = "owner_"
Me.Column2.FillWeight = 10.30928!
Me.Column2.HeaderText = "Owner"
Me.Column2.Name = "Column2"
Me.Column2.ReadOnly = True
'
'Column3
'
Me.Column3.DataPropertyName = "id"
Me.Column3.HeaderText = "id"
Me.Column3.Name = "Column3"
Me.Column3.Visible = False
'
'Button1
'
Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.Button1.Location = New System.Drawing.Point(533, 53)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(75, 23)
Me.Button1.TabIndex = 1
Me.Button1.Text = "Run Query"
Me.Button1.UseVisualStyleBackColor = True
'
'Button2
'
Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.Button2.Location = New System.Drawing.Point(533, 82)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(75, 23)
Me.Button2.TabIndex = 5
Me.Button2.Text = "Clear"
Me.Button2.UseVisualStyleBackColor = True
'
'lblnumrecs
'
Me.lblnumrecs.AutoSize = True
Me.lblnumrecs.Location = New System.Drawing.Point(32, 89)
Me.lblnumrecs.Name = "lblnumrecs"
Me.lblnumrecs.Size = New System.Drawing.Size(0, 13)
Me.lblnumrecs.TabIndex = 6
'
'frmNcalfQuery
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.ClientSize = New System.Drawing.Size(631, 344)
Me.Name = "frmNcalfQuery"
Me.CaptionPanel.ResumeLayout(False)
Me.CaptionPanel.PerformLayout()
Me.BottomPanel.ResumeLayout(False)
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblnumrecs As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
