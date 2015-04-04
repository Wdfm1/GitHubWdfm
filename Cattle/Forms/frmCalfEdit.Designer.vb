<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalfEdit
    Inherits Cattle.BaseForm

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
		Me.components = New System.ComponentModel.Container()
		Dim IdLabel As System.Windows.Forms.Label
		Dim ActiveLabel As System.Windows.Forms.Label
		Me.IdTextBox = New System.Windows.Forms.TextBox()
		Me.CalfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.Dcalf = New Cattle.Dcalf()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.OwnerComboBox = New System.Windows.Forms.ComboBox()
		Me.CalfnoTextBox = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
		Me.Calf_groupComboBox = New System.Windows.Forms.ComboBox()
		Me.CalfgroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.SexComboBox = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblLine = New System.Windows.Forms.Label()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblCharacteristics = New System.Windows.Forms.Label()
		Me.lblNote = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.CalfTableAdapter = New Cattle.DcalfTableAdapters.calfTableAdapter()
		Me.CalfgroupTableAdapter = New Cattle.DcalfTableAdapters.calfgroupTableAdapter()
		IdLabel = New System.Windows.Forms.Label()
		ActiveLabel = New System.Windows.Forms.Label()
		Me.CaptionPanel.SuspendLayout()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CalfgroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Controls.Add(IdLabel)
		Me.CaptionPanel.Controls.Add(Me.IdTextBox)
		Me.CaptionPanel.Controls.Add(Me.Label8)
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
		Me.CaptionPanel.Size = New System.Drawing.Size(1040, 38)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.lblCharacteristics)
		Me.BottomPanel.Controls.Add(Me.lblNote)
		Me.BottomPanel.Controls.Add(Me.TextBox2)
		Me.BottomPanel.Controls.Add(Me.TextBox1)
		Me.BottomPanel.Controls.Add(Me.lblLine)
		Me.BottomPanel.Controls.Add(Me.btnDelete)
		Me.BottomPanel.Controls.Add(Me.btnCancel)
		Me.BottomPanel.Controls.Add(Me.btnSave)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 201)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
		Me.BottomPanel.Size = New System.Drawing.Size(1040, 274)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.DobDateTimePicker)
		Me.LeftPanel.Controls.Add(Me.OwnerComboBox)
		Me.LeftPanel.Controls.Add(Me.CalfnoTextBox)
		Me.LeftPanel.Controls.Add(Me.Label6)
		Me.LeftPanel.Controls.Add(Me.Label4)
		Me.LeftPanel.Controls.Add(Me.Label3)
		Me.LeftPanel.Location = New System.Drawing.Point(0, 38)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
		Me.LeftPanel.Size = New System.Drawing.Size(312, 163)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(ActiveLabel)
		Me.RightPanel.Controls.Add(Me.ActiveCheckBox)
		Me.RightPanel.Controls.Add(Me.Calf_groupComboBox)
		Me.RightPanel.Controls.Add(Me.SexComboBox)
		Me.RightPanel.Controls.Add(Me.Label7)
		Me.RightPanel.Controls.Add(Me.Label5)
		Me.RightPanel.Location = New System.Drawing.Point(312, 38)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
		Me.RightPanel.Size = New System.Drawing.Size(728, 163)
		'
		'IdLabel
		'
		IdLabel.AutoSize = True
		IdLabel.Location = New System.Drawing.Point(35, 6)
		IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		IdLabel.Name = "IdLabel"
		IdLabel.Size = New System.Drawing.Size(23, 17)
		IdLabel.TabIndex = 69
		IdLabel.Text = "Id:"
		IdLabel.Visible = False
		'
		'ActiveLabel
		'
		ActiveLabel.AutoSize = True
		ActiveLabel.Location = New System.Drawing.Point(7, 110)
		ActiveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		ActiveLabel.Name = "ActiveLabel"
		ActiveLabel.Size = New System.Drawing.Size(46, 17)
		ActiveLabel.TabIndex = 71
		ActiveLabel.Text = "Active"
		'
		'IdTextBox
		'
		Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "id", True))
		Me.IdTextBox.Location = New System.Drawing.Point(68, 2)
		Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.IdTextBox.Name = "IdTextBox"
		Me.IdTextBox.Size = New System.Drawing.Size(132, 22)
		Me.IdTextBox.TabIndex = 70
		Me.IdTextBox.Visible = False
		'
		'CalfBindingSource
		'
		Me.CalfBindingSource.DataMember = "calf"
		Me.CalfBindingSource.DataSource = Me.Dcalf
		'
		'Dcalf
		'
		Me.Dcalf.DataSetName = "Dcalf"
		Me.Dcalf.EnforceConstraints = False
		Me.Dcalf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Label8
		'
		Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(450, -4)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(144, 49)
		Me.Label8.TabIndex = 68
		Me.Label8.Text = "Calves"
		'
		'DobDateTimePicker
		'
		Me.DobDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CalfBindingSource, "dob", True))
		Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "dob", True))
		Me.DobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DobDateTimePicker.Location = New System.Drawing.Point(124, 110)
		Me.DobDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DobDateTimePicker.Name = "DobDateTimePicker"
		Me.DobDateTimePicker.Size = New System.Drawing.Size(127, 22)
		Me.DobDateTimePicker.TabIndex = 51
		'
		'OwnerComboBox
		'
		Me.OwnerComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OwnerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "owner", True))
		Me.OwnerComboBox.DisplayMember = "BETTY,RANDY,ROB"
		Me.OwnerComboBox.FormattingEnabled = True
		Me.OwnerComboBox.Items.AddRange(New Object() {"BETTY", "RANDY", "ROB", "DERRICK", "JARRETT"})
		Me.OwnerComboBox.Location = New System.Drawing.Point(123, 60)
		Me.OwnerComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.OwnerComboBox.Name = "OwnerComboBox"
		Me.OwnerComboBox.Size = New System.Drawing.Size(128, 24)
		Me.OwnerComboBox.TabIndex = 50
		'
		'CalfnoTextBox
		'
		Me.CalfnoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CalfnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "calfno", True))
		Me.CalfnoTextBox.Location = New System.Drawing.Point(124, 16)
		Me.CalfnoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CalfnoTextBox.Name = "CalfnoTextBox"
		Me.CalfnoTextBox.Size = New System.Drawing.Size(127, 22)
		Me.CalfnoTextBox.TabIndex = 49
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(65, 110)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(38, 17)
		Me.Label6.TabIndex = 54
		Me.Label6.Text = "DOB"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(55, 60)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.TabIndex = 53
		Me.Label4.Text = "Owner"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(19, 16)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(86, 17)
		Me.Label3.TabIndex = 52
		Me.Label3.Text = "Calf Number"
		'
		'ActiveCheckBox
		'
		Me.ActiveCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CalfBindingSource, "active", True))
		Me.ActiveCheckBox.Location = New System.Drawing.Point(107, 110)
		Me.ActiveCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.ActiveCheckBox.Name = "ActiveCheckBox"
		Me.ActiveCheckBox.Size = New System.Drawing.Size(437, 30)
		Me.ActiveCheckBox.TabIndex = 72
		'
		'Calf_groupComboBox
		'
		Me.Calf_groupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Calf_groupComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "calf_group", True))
		Me.Calf_groupComboBox.DataSource = Me.CalfgroupBindingSource
		Me.Calf_groupComboBox.DisplayMember = "calf_group"
		Me.Calf_groupComboBox.FormattingEnabled = True
		Me.Calf_groupComboBox.Location = New System.Drawing.Point(107, 60)
		Me.Calf_groupComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Calf_groupComboBox.Name = "Calf_groupComboBox"
		Me.Calf_groupComboBox.Size = New System.Drawing.Size(537, 24)
		Me.Calf_groupComboBox.TabIndex = 68
		Me.Calf_groupComboBox.ValueMember = "calf_group"
		'
		'CalfgroupBindingSource
		'
		Me.CalfgroupBindingSource.DataMember = "calfgroup"
		Me.CalfgroupBindingSource.DataSource = Me.Dcalf
		'
		'SexComboBox
		'
		Me.SexComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "sex", True))
		Me.SexComboBox.FormattingEnabled = True
		Me.SexComboBox.Items.AddRange(New Object() {"BULL", "HEIFER"})
		Me.SexComboBox.Location = New System.Drawing.Point(107, 16)
		Me.SexComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.SexComboBox.Name = "SexComboBox"
		Me.SexComboBox.Size = New System.Drawing.Size(537, 24)
		Me.SexComboBox.TabIndex = 67
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(23, 16)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(31, 17)
		Me.Label7.TabIndex = 70
		Me.Label7.Text = "Sex"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 60)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(48, 17)
		Me.Label5.TabIndex = 69
		Me.Label5.Text = "Group"
		'
		'lblLine
		'
		Me.lblLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblLine.BackColor = System.Drawing.Color.Black
		Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblLine.Location = New System.Drawing.Point(0, 186)
		Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblLine.Name = "lblLine"
		Me.lblLine.Size = New System.Drawing.Size(1038, 3)
		Me.lblLine.TabIndex = 64
		Me.lblLine.Text = "Label1"
		'
		'btnDelete
		'
		Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnDelete.Location = New System.Drawing.Point(395, 214)
		Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(100, 28)
		Me.btnDelete.TabIndex = 63
		Me.btnDelete.Text = "Delete"
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.Location = New System.Drawing.Point(512, 214)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(100, 28)
		Me.btnCancel.TabIndex = 62
		Me.btnCancel.Text = "Cancel"
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Location = New System.Drawing.Point(277, 214)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(100, 28)
		Me.btnSave.TabIndex = 61
		Me.btnSave.Text = "Save"
		'
		'lblCharacteristics
		'
		Me.lblCharacteristics.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblCharacteristics.AutoSize = True
		Me.lblCharacteristics.Location = New System.Drawing.Point(3, 103)
		Me.lblCharacteristics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCharacteristics.Name = "lblCharacteristics"
		Me.lblCharacteristics.Size = New System.Drawing.Size(101, 17)
		Me.lblCharacteristics.TabIndex = 70
		Me.lblCharacteristics.Text = "Characterictics"
		'
		'lblNote
		'
		Me.lblNote.AutoSize = True
		Me.lblNote.Location = New System.Drawing.Point(65, 7)
		Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNote.Name = "lblNote"
		Me.lblNote.Size = New System.Drawing.Size(38, 17)
		Me.lblNote.TabIndex = 69
		Me.lblNote.Text = "Note"
		'
		'TextBox2
		'
		Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "charr", True))
		Me.TextBox2.Location = New System.Drawing.Point(123, 79)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox2.Size = New System.Drawing.Size(852, 56)
		Me.TextBox2.TabIndex = 68
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "note", True))
		Me.TextBox1.Location = New System.Drawing.Point(123, 7)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox1.Size = New System.Drawing.Size(852, 56)
		Me.TextBox1.TabIndex = 67
		'
		'CalfTableAdapter
		'
		Me.CalfTableAdapter.ClearBeforeFill = True
		'
		'CalfgroupTableAdapter
		'
		Me.CalfgroupTableAdapter.ClearBeforeFill = True
		'
		'frmCalfEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.ClientSize = New System.Drawing.Size(1040, 475)
		Me.CurrentInstance = "0"
		Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
		Me.MinimizeBox = False
		Me.Name = "frmCalfEdit"
		Me.Text = " Edit Calf"
		Me.TopMost = True
		Me.CaptionPanel.ResumeLayout(False)
		Me.CaptionPanel.PerformLayout()
		Me.BottomPanel.ResumeLayout(False)
		Me.BottomPanel.PerformLayout()
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CalfgroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DobDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OwnerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CalfnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Calf_groupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SexComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCharacteristics As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Dcalf As Cattle.Dcalf
    Friend WithEvents CalfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalfTableAdapter As Cattle.DcalfTableAdapters.calfTableAdapter
    Friend WithEvents CalfgroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalfgroupTableAdapter As Cattle.DcalfTableAdapters.calfgroupTableAdapter

End Class
