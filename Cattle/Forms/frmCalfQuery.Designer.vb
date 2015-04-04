<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalfQuery
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cmbop4 = New System.Windows.Forms.ComboBox()
		Me.cmbop1 = New System.Windows.Forms.ComboBox()
		Me.cmbop3 = New System.Windows.Forms.ComboBox()
		Me.cmbop2 = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbgroup = New System.Windows.Forms.ComboBox()
		Me.txtage = New System.Windows.Forms.TextBox()
		Me.cmbowner = New System.Windows.Forms.ComboBox()
		Me.cmbsex = New System.Windows.Forms.ComboBox()
		Me.btnprint = New System.Windows.Forms.Button()
		Me.btnreset = New System.Windows.Forms.Button()
		Me.btnrun = New System.Windows.Forms.Button()
		Me.btncancel = New System.Windows.Forms.Button()
		Me.lblretrec = New System.Windows.Forms.Label()
		Me.CalfDataGridView = New System.Windows.Forms.DataGridView()
		Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.Column66 = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.CalfDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(727, 12)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.btncancel)
		Me.BottomPanel.Controls.Add(Me.btnrun)
		Me.BottomPanel.Controls.Add(Me.lblretrec)
		Me.BottomPanel.Controls.Add(Me.btnprint)
		Me.BottomPanel.Controls.Add(Me.btnreset)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 275)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(727, 66)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.CalfDataGridView)
		Me.LeftPanel.Controls.Add(Me.Label2)
		Me.LeftPanel.Controls.Add(Me.cmbop4)
		Me.LeftPanel.Controls.Add(Me.cmbop1)
		Me.LeftPanel.Controls.Add(Me.cmbop3)
		Me.LeftPanel.Controls.Add(Me.cmbop2)
		Me.LeftPanel.Controls.Add(Me.Label5)
		Me.LeftPanel.Controls.Add(Me.Label4)
		Me.LeftPanel.Controls.Add(Me.Label3)
		Me.LeftPanel.Location = New System.Drawing.Point(0, 12)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(388, 263)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(Me.cmbgroup)
		Me.RightPanel.Controls.Add(Me.txtage)
		Me.RightPanel.Controls.Add(Me.cmbowner)
		Me.RightPanel.Controls.Add(Me.cmbsex)
		Me.RightPanel.Location = New System.Drawing.Point(388, 12)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(339, 263)
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(156, 21)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(48, 17)
		Me.Label2.TabIndex = 44
		Me.Label2.Text = "Group"
		'
		'cmbop4
		'
		Me.cmbop4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbop4.FormattingEnabled = True
		Me.cmbop4.Items.AddRange(New Object() {"", "=", ">=", "<=", "<>"})
		Me.cmbop4.Location = New System.Drawing.Point(244, 165)
		Me.cmbop4.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbop4.Name = "cmbop4"
		Me.cmbop4.Size = New System.Drawing.Size(120, 24)
		Me.cmbop4.TabIndex = 43
		'
		'cmbop1
		'
		Me.cmbop1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbop1.FormattingEnabled = True
		Me.cmbop1.Items.AddRange(New Object() {"", "=", "<>"})
		Me.cmbop1.Location = New System.Drawing.Point(244, 21)
		Me.cmbop1.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbop1.Name = "cmbop1"
		Me.cmbop1.Size = New System.Drawing.Size(120, 24)
		Me.cmbop1.TabIndex = 40
		'
		'cmbop3
		'
		Me.cmbop3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbop3.FormattingEnabled = True
		Me.cmbop3.Items.AddRange(New Object() {"", "=", "<>"})
		Me.cmbop3.Location = New System.Drawing.Point(244, 118)
		Me.cmbop3.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbop3.Name = "cmbop3"
		Me.cmbop3.Size = New System.Drawing.Size(120, 24)
		Me.cmbop3.TabIndex = 42
		'
		'cmbop2
		'
		Me.cmbop2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbop2.FormattingEnabled = True
		Me.cmbop2.Items.AddRange(New Object() {"", "=", "<>"})
		Me.cmbop2.Location = New System.Drawing.Point(244, 71)
		Me.cmbop2.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbop2.Name = "cmbop2"
		Me.cmbop2.Size = New System.Drawing.Size(120, 24)
		Me.cmbop2.TabIndex = 41
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(171, 118)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(31, 17)
		Me.Label5.TabIndex = 47
		Me.Label5.Text = "Sex"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(169, 165)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(33, 17)
		Me.Label4.TabIndex = 46
		Me.Label4.Text = "Age"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(153, 71)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.TabIndex = 45
		Me.Label3.Text = "Owner"
		'
		'cmbgroup
		'
		Me.cmbgroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbgroup.BackColor = System.Drawing.SystemColors.Window
		Me.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbgroup.ForeColor = System.Drawing.SystemColors.InfoText
		Me.cmbgroup.FormattingEnabled = True
		Me.cmbgroup.Location = New System.Drawing.Point(23, 21)
		Me.cmbgroup.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbgroup.Name = "cmbgroup"
		Me.cmbgroup.Size = New System.Drawing.Size(142, 24)
		Me.cmbgroup.TabIndex = 8
		'
		'txtage
		'
		Me.txtage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtage.Location = New System.Drawing.Point(24, 165)
		Me.txtage.Margin = New System.Windows.Forms.Padding(4)
		Me.txtage.Name = "txtage"
		Me.txtage.Size = New System.Drawing.Size(69, 22)
		Me.txtage.TabIndex = 11
		'
		'cmbowner
		'
		Me.cmbowner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbowner.FormattingEnabled = True
		Me.cmbowner.Items.AddRange(New Object() {"", "BETTY", "DERRICK", "JARRETT", "RANDY", "ROB"})
		Me.cmbowner.Location = New System.Drawing.Point(23, 71)
		Me.cmbowner.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbowner.Name = "cmbowner"
		Me.cmbowner.Size = New System.Drawing.Size(142, 24)
		Me.cmbowner.TabIndex = 9
		'
		'cmbsex
		'
		Me.cmbsex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbsex.FormattingEnabled = True
		Me.cmbsex.Items.AddRange(New Object() {"", "BULL", "HEIFER"})
		Me.cmbsex.Location = New System.Drawing.Point(24, 118)
		Me.cmbsex.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbsex.Name = "cmbsex"
		Me.cmbsex.Size = New System.Drawing.Size(142, 24)
		Me.cmbsex.TabIndex = 10
		'
		'btnprint
		'
		Me.btnprint.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnprint.Location = New System.Drawing.Point(388, 21)
		Me.btnprint.Margin = New System.Windows.Forms.Padding(4)
		Me.btnprint.Name = "btnprint"
		Me.btnprint.Size = New System.Drawing.Size(92, 34)
		Me.btnprint.TabIndex = 3
		Me.btnprint.Text = "Print"
		Me.btnprint.UseVisualStyleBackColor = True
		Me.btnprint.Visible = False
		'
		'btnreset
		'
		Me.btnreset.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnreset.Location = New System.Drawing.Point(241, 21)
		Me.btnreset.Margin = New System.Windows.Forms.Padding(4)
		Me.btnreset.Name = "btnreset"
		Me.btnreset.Size = New System.Drawing.Size(92, 34)
		Me.btnreset.TabIndex = 2
		Me.btnreset.Text = "Reset"
		Me.btnreset.UseVisualStyleBackColor = True
		Me.btnreset.Visible = False
		'
		'btnrun
		'
		Me.btnrun.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnrun.Location = New System.Drawing.Point(241, 21)
		Me.btnrun.Margin = New System.Windows.Forms.Padding(4)
		Me.btnrun.Name = "btnrun"
		Me.btnrun.Size = New System.Drawing.Size(92, 34)
		Me.btnrun.TabIndex = 50
		Me.btnrun.Text = "Run Query"
		Me.btnrun.UseVisualStyleBackColor = True
		'
		'btncancel
		'
		Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btncancel.Location = New System.Drawing.Point(389, 21)
		Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
		Me.btncancel.Name = "btncancel"
		Me.btncancel.Size = New System.Drawing.Size(92, 34)
		Me.btncancel.TabIndex = 52
		Me.btncancel.Text = "Cancel"
		Me.btncancel.UseVisualStyleBackColor = True
		'
		'lblretrec
		'
		Me.lblretrec.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblretrec.AutoSize = True
		Me.lblretrec.Location = New System.Drawing.Point(337, 0)
		Me.lblretrec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblretrec.Name = "lblretrec"
		Me.lblretrec.Size = New System.Drawing.Size(51, 17)
		Me.lblretrec.TabIndex = 52
		Me.lblretrec.Text = "Label6"
		Me.lblretrec.Visible = False
		'
		'CalfDataGridView
		'
		Me.CalfDataGridView.AllowUserToAddRows = False
		Me.CalfDataGridView.AllowUserToDeleteRows = False
		Me.CalfDataGridView.AllowUserToOrderColumns = True
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
		Me.CalfDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.CalfDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CalfDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.CalfDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column66, Me.age, Me.Column9})
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.CalfDataGridView.DefaultCellStyle = DataGridViewCellStyle3
		Me.CalfDataGridView.Location = New System.Drawing.Point(0, 0)
		Me.CalfDataGridView.Margin = New System.Windows.Forms.Padding(4)
		Me.CalfDataGridView.Name = "CalfDataGridView"
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CalfDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.CalfDataGridView.RowHeadersWidth = 23
		Me.CalfDataGridView.Size = New System.Drawing.Size(364, 263)
		Me.CalfDataGridView.TabIndex = 48
		Me.CalfDataGridView.Visible = False
		'
		'Column0
		'
		Me.Column0.DataPropertyName = "calfno"
		Me.Column0.HeaderText = "Calf Number"
		Me.Column0.Name = "Column0"
		'
		'Column1
		'
		Me.Column1.DataPropertyName = "dob"
		Me.Column1.HeaderText = "DOB"
		Me.Column1.Name = "Column1"
		'
		'Column2
		'
		Me.Column2.DataPropertyName = "sex"
		Me.Column2.HeaderText = "Sex"
		Me.Column2.Name = "Column2"
		'
		'Column3
		'
		Me.Column3.DataPropertyName = "calf_group"
		Me.Column3.HeaderText = "Group"
		Me.Column3.Name = "Column3"
		'
		'Column4
		'
		Me.Column4.DataPropertyName = "owner"
		Me.Column4.HeaderText = "Owner"
		Me.Column4.Name = "Column4"
		'
		'Column5
		'
		Me.Column5.DataPropertyName = "charr"
		Me.Column5.HeaderText = "Desc"
		Me.Column5.Name = "Column5"
		Me.Column5.Text = "Desc"
		Me.Column5.UseColumnTextForButtonValue = True
		'
		'Column66
		'
		Me.Column66.DataPropertyName = "note"
		Me.Column66.HeaderText = "Note"
		Me.Column66.Name = "Column66"
		Me.Column66.Text = "Note"
		Me.Column66.UseColumnTextForButtonValue = True
		'
		'age
		'
		Me.age.DataPropertyName = "age"
		Me.age.FillWeight = 0.3212816!
		Me.age.HeaderText = "Age"
		Me.age.Name = "age"
		Me.age.Width = 35
		'
		'Column9
		'
		Me.Column9.DataPropertyName = "cowid"
		Me.Column9.HeaderText = "cowid"
		Me.Column9.Name = "Column9"
		Me.Column9.Visible = False
		'
		'frmCalfQuery
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.BottomPanelFloat = True
		Me.ClientSize = New System.Drawing.Size(727, 341)
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.MinimumSize = New System.Drawing.Size(731, 372)
		Me.Name = "frmCalfQuery"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Calf Query"
		Me.BottomPanel.ResumeLayout(False)
		Me.BottomPanel.PerformLayout()
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.CalfDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbop4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbop1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbop3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbop2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents cmbgroup As System.Windows.Forms.ComboBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents cmbowner As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsex As System.Windows.Forms.ComboBox
    Friend WithEvents btnrun As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblretrec As System.Windows.Forms.Label
    Friend WithEvents CalfDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Column0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column66 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
