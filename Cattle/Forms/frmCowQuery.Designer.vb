<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCowQuery
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
		Dim lblGroup As System.Windows.Forms.Label
		Dim Label1 As System.Windows.Forms.Label
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.cmbgroup = New System.Windows.Forms.ComboBox()
		Me.cmbowner = New System.Windows.Forms.ComboBox()
		Me.btnRun = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.lblrecret = New System.Windows.Forms.Label()
		lblGroup = New System.Windows.Forms.Label()
		Label1 = New System.Windows.Forms.Label()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(988, 12)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.lblrecret)
		Me.BottomPanel.Controls.Add(Me.btnPrint)
		Me.BottomPanel.Controls.Add(Me.btnReset)
		Me.BottomPanel.Controls.Add(Me.btnRun)
		Me.BottomPanel.Controls.Add(Me.btnExit)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 175)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(988, 82)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.DataGridView1)
		Me.LeftPanel.Controls.Add(Me.cmbgroup)
		Me.LeftPanel.Controls.Add(lblGroup)
		Me.LeftPanel.Location = New System.Drawing.Point(0, 12)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(468, 163)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(Label1)
		Me.RightPanel.Controls.Add(Me.cmbowner)
		Me.RightPanel.Location = New System.Drawing.Point(468, 12)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(520, 163)
		'
		'lblGroup
		'
		lblGroup.AutoSize = True
		lblGroup.Location = New System.Drawing.Point(13, 36)
		lblGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		lblGroup.Name = "lblGroup"
		lblGroup.Size = New System.Drawing.Size(113, 17)
		lblGroup.TabIndex = 109
		lblGroup.Text = "Group Equal To:"
		'
		'Label1
		'
		Label1.AutoSize = True
		Label1.Location = New System.Drawing.Point(11, 36)
		Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Label1.Name = "Label1"
		Label1.Size = New System.Drawing.Size(114, 17)
		Label1.TabIndex = 112
		Label1.Text = "Owner Equal To:"
		'
		'cmbgroup
		'
		Me.cmbgroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbgroup.FormattingEnabled = True
		Me.cmbgroup.Items.AddRange(New Object() {"", "FALL", "SPRING", "OTHER"})
		Me.cmbgroup.Location = New System.Drawing.Point(136, 36)
		Me.cmbgroup.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbgroup.Name = "cmbgroup"
		Me.cmbgroup.Size = New System.Drawing.Size(279, 24)
		Me.cmbgroup.TabIndex = 108
		'
		'cmbowner
		'
		Me.cmbowner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbowner.FormattingEnabled = True
		Me.cmbowner.Items.AddRange(New Object() {"", "BETTY", "DERRICK", "JARRETT", "RANDY", "ROB"})
		Me.cmbowner.Location = New System.Drawing.Point(163, 36)
		Me.cmbowner.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbowner.Name = "cmbowner"
		Me.cmbowner.Size = New System.Drawing.Size(325, 24)
		Me.cmbowner.TabIndex = 111
		'
		'btnRun
		'
		Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnRun.Location = New System.Drawing.Point(373, 42)
		Me.btnRun.Margin = New System.Windows.Forms.Padding(4)
		Me.btnRun.Name = "btnRun"
		Me.btnRun.Size = New System.Drawing.Size(112, 30)
		Me.btnRun.TabIndex = 6
		Me.btnRun.Text = "Run Query"
		Me.btnRun.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnExit.Location = New System.Drawing.Point(503, 42)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(112, 30)
		Me.btnExit.TabIndex = 7
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToOrderColumns = True
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
		Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.DataGridView1.RowHeadersWidth = 21
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
		Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
		Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(429, 165)
		Me.DataGridView1.TabIndex = 118
		Me.DataGridView1.Visible = False
		'
		'Column1
		'
		Me.Column1.DataPropertyName = "cow_number"
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
		Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
		Me.Column1.HeaderText = "Cow Number"
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		'
		'Column2
		'
		Me.Column2.DataPropertyName = "calf_group"
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
		Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
		Me.Column2.HeaderText = "Group"
		Me.Column2.Name = "Column2"
		Me.Column2.ReadOnly = True
		'
		'Column3
		'
		Me.Column3.DataPropertyName = "owner_"
		Me.Column3.HeaderText = "Owner"
		Me.Column3.Name = "Column3"
		Me.Column3.ReadOnly = True
		'
		'Column4
		'
		Me.Column4.DataPropertyName = "cha"
		Me.Column4.HeaderText = "Desc."
		Me.Column4.Name = "Column4"
		Me.Column4.ReadOnly = True
		'
		'Column5
		'
		Me.Column5.DataPropertyName = "note"
		Me.Column5.HeaderText = "Note"
		Me.Column5.Name = "Column5"
		Me.Column5.ReadOnly = True
		'
		'btnPrint
		'
		Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnPrint.Location = New System.Drawing.Point(503, 42)
		Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(112, 30)
		Me.btnPrint.TabIndex = 9
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		Me.btnPrint.Visible = False
		'
		'btnReset
		'
		Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnReset.Location = New System.Drawing.Point(373, 42)
		Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(112, 30)
		Me.btnReset.TabIndex = 8
		Me.btnReset.Text = "Reset Query"
		Me.btnReset.UseVisualStyleBackColor = True
		Me.btnReset.Visible = False
		'
		'lblrecret
		'
		Me.lblrecret.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblrecret.AutoSize = True
		Me.lblrecret.Location = New System.Drawing.Point(411, 4)
		Me.lblrecret.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblrecret.Name = "lblrecret"
		Me.lblrecret.Size = New System.Drawing.Size(136, 17)
		Me.lblrecret.TabIndex = 117
		Me.lblrecret.Text = "0 Records Returned"
		Me.lblrecret.Visible = False
		'
		'frmCowQuery
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.BottomPanelFloat = True
		Me.ClientSize = New System.Drawing.Size(988, 257)
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.MinimumSize = New System.Drawing.Size(18, 302)
		Me.Name = "frmCowQuery"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cow Query"
		Me.BottomPanel.ResumeLayout(False)
		Me.BottomPanel.PerformLayout()
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents cmbgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbowner As System.Windows.Forms.ComboBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblrecret As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
