<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCow
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
		Me.components = New System.ComponentModel.Container()
		Dim InactivedaLabel As System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DCow = New Cattle.DCow()
		Me.InactivedaDateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.cmbGroup = New System.Windows.Forms.ComboBox()
		Me.cmbOwner = New System.Windows.Forms.ComboBox()
		Me.lblGroup = New System.Windows.Forms.Label()
		Me.lblOwner = New System.Windows.Forms.Label()
		Me.lblCowNum = New System.Windows.Forms.Label()
		Me.txtCowNum = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Age = New System.Windows.Forms.Label()
		Me.lblNote = New System.Windows.Forms.Label()
		Me.txtNote = New System.Windows.Forms.TextBox()
		Me.lblCharacterictics = New System.Windows.Forms.Label()
		Me.txtCharacterictics = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblLine = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.txtlastupdateuser = New System.Windows.Forms.TextBox()
		Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter()
		InactivedaLabel = New System.Windows.Forms.Label()
		Me.CaptionPanel.SuspendLayout()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Controls.Add(Me.txtlastupdateuser)
		Me.CaptionPanel.Controls.Add(Me.lblTitle)
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(977, 68)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.btnCancel)
		Me.BottomPanel.Controls.Add(Me.btnSave)
		Me.BottomPanel.Controls.Add(Me.lblLine)
		Me.BottomPanel.Controls.Add(Me.Button2)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 375)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(977, 59)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.CheckBox1)
		Me.LeftPanel.Controls.Add(Me.InactivedaDateTimePicker)
		Me.LeftPanel.Controls.Add(Me.cmbGroup)
		Me.LeftPanel.Controls.Add(Me.cmbOwner)
		Me.LeftPanel.Controls.Add(Me.lblGroup)
		Me.LeftPanel.Controls.Add(Me.lblOwner)
		Me.LeftPanel.Controls.Add(Me.lblCowNum)
		Me.LeftPanel.Controls.Add(Me.txtCowNum)
		Me.LeftPanel.Controls.Add(InactivedaLabel)
		Me.LeftPanel.Controls.Add(Me.Label1)
		Me.LeftPanel.Controls.Add(Me.DateTimePicker1)
		Me.LeftPanel.Location = New System.Drawing.Point(0, 68)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(439, 307)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(Me.CheckBox2)
		Me.RightPanel.Controls.Add(Me.TextBox1)
		Me.RightPanel.Controls.Add(Me.Age)
		Me.RightPanel.Controls.Add(Me.lblNote)
		Me.RightPanel.Controls.Add(Me.txtNote)
		Me.RightPanel.Controls.Add(Me.lblCharacterictics)
		Me.RightPanel.Controls.Add(Me.txtCharacterictics)
		Me.RightPanel.Location = New System.Drawing.Point(439, 68)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(538, 307)
		'
		'InactivedaLabel
		'
		InactivedaLabel.AutoSize = True
		InactivedaLabel.Location = New System.Drawing.Point(41, 171)
		InactivedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		InactivedaLabel.Name = "InactivedaLabel"
		InactivedaLabel.Size = New System.Drawing.Size(90, 17)
		InactivedaLabel.TabIndex = 78
		InactivedaLabel.Text = "Inactive Date"
		'
		'lblTitle
		'
		Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Location = New System.Drawing.Point(423, 9)
		Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(128, 49)
		Me.lblTitle.TabIndex = 49
		Me.lblTitle.Text = "Cow"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CowBindingSource, "tobesold", True))
		Me.CheckBox1.Location = New System.Drawing.Point(176, 220)
		Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
		Me.CheckBox1.TabIndex = 73
		Me.CheckBox1.Text = "To Be Sold"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CowBindingSource
		'
		Me.CowBindingSource.DataMember = "Cow"
		Me.CowBindingSource.DataSource = Me.DCow
		'
		'DCow
		'
		Me.DCow.DataSetName = "DCow"
		Me.DCow.EnforceConstraints = False
		Me.DCow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'InactivedaDateTimePicker
		'
		Me.InactivedaDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.InactivedaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "inactiveda", True))
		Me.InactivedaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CowBindingSource, "inactiveda", True))
		Me.InactivedaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.InactivedaDateTimePicker.Location = New System.Drawing.Point(176, 171)
		Me.InactivedaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
		Me.InactivedaDateTimePicker.Name = "InactivedaDateTimePicker"
		Me.InactivedaDateTimePicker.Size = New System.Drawing.Size(248, 22)
		Me.InactivedaDateTimePicker.TabIndex = 72
		'
		'cmbGroup
		'
		Me.cmbGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbGroup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "calf_group", True))
		Me.cmbGroup.Items.AddRange(New Object() {"FALL", "SPRING", "OTHER"})
		Me.cmbGroup.Location = New System.Drawing.Point(176, 92)
		Me.cmbGroup.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbGroup.Name = "cmbGroup"
		Me.cmbGroup.Size = New System.Drawing.Size(248, 24)
		Me.cmbGroup.TabIndex = 70
		'
		'cmbOwner
		'
		Me.cmbOwner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "owner_", True))
		Me.cmbOwner.Items.AddRange(New Object() {"BETTY", "RANDY", "ROB", "DERRICK", "JARRETT"})
		Me.cmbOwner.Location = New System.Drawing.Point(176, 49)
		Me.cmbOwner.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbOwner.Name = "cmbOwner"
		Me.cmbOwner.Size = New System.Drawing.Size(248, 24)
		Me.cmbOwner.TabIndex = 69
		'
		'lblGroup
		'
		Me.lblGroup.AutoSize = True
		Me.lblGroup.Location = New System.Drawing.Point(91, 92)
		Me.lblGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGroup.Name = "lblGroup"
		Me.lblGroup.Size = New System.Drawing.Size(48, 17)
		Me.lblGroup.TabIndex = 76
		Me.lblGroup.Text = "Group"
		'
		'lblOwner
		'
		Me.lblOwner.AutoSize = True
		Me.lblOwner.Location = New System.Drawing.Point(88, 49)
		Me.lblOwner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblOwner.Name = "lblOwner"
		Me.lblOwner.Size = New System.Drawing.Size(49, 17)
		Me.lblOwner.TabIndex = 75
		Me.lblOwner.Text = "Owner"
		'
		'lblCowNum
		'
		Me.lblCowNum.AutoSize = True
		Me.lblCowNum.Location = New System.Drawing.Point(45, 11)
		Me.lblCowNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCowNum.Name = "lblCowNum"
		Me.lblCowNum.Size = New System.Drawing.Size(88, 17)
		Me.lblCowNum.TabIndex = 74
		Me.lblCowNum.Text = "Cow Number"
		'
		'txtCowNum
		'
		Me.txtCowNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCowNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCowNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "cow_number", True))
		Me.txtCowNum.Location = New System.Drawing.Point(176, 11)
		Me.txtCowNum.Margin = New System.Windows.Forms.Padding(4)
		Me.txtCowNum.Name = "txtCowNum"
		Me.txtCowNum.Size = New System.Drawing.Size(248, 22)
		Me.txtCowNum.TabIndex = 68
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 128)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(125, 17)
		Me.Label1.TabIndex = 77
		Me.Label1.Text = "Date of Ownership"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CowBindingSource, "dateofownership", True))
		Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "dateofownership", True))
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(176, 128)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(248, 22)
		Me.DateTimePicker1.TabIndex = 71
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CowBindingSource, "active", True))
		Me.CheckBox2.Location = New System.Drawing.Point(132, 223)
		Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(68, 21)
		Me.CheckBox2.TabIndex = 67
		Me.CheckBox2.Text = "Active"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "age", True))
		Me.TextBox1.Location = New System.Drawing.Point(132, 175)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(314, 22)
		Me.TextBox1.TabIndex = 66
		'
		'Age
		'
		Me.Age.AutoSize = True
		Me.Age.Location = New System.Drawing.Point(69, 175)
		Me.Age.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Age.Name = "Age"
		Me.Age.Size = New System.Drawing.Size(33, 17)
		Me.Age.TabIndex = 70
		Me.Age.Text = "Age"
		'
		'lblNote
		'
		Me.lblNote.AutoSize = True
		Me.lblNote.Location = New System.Drawing.Point(57, 98)
		Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNote.Name = "lblNote"
		Me.lblNote.Size = New System.Drawing.Size(45, 17)
		Me.lblNote.TabIndex = 69
		Me.lblNote.Text = "Notes"
		'
		'txtNote
		'
		Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "note", True))
		Me.txtNote.Location = New System.Drawing.Point(132, 98)
		Me.txtNote.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNote.Multiline = True
		Me.txtNote.Name = "txtNote"
		Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtNote.Size = New System.Drawing.Size(390, 68)
		Me.txtNote.TabIndex = 65
		'
		'lblCharacterictics
		'
		Me.lblCharacterictics.AutoSize = True
		Me.lblCharacterictics.Location = New System.Drawing.Point(3, 14)
		Me.lblCharacterictics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCharacterictics.Name = "lblCharacterictics"
		Me.lblCharacterictics.Size = New System.Drawing.Size(101, 17)
		Me.lblCharacterictics.TabIndex = 68
		Me.lblCharacterictics.Text = "Characteristics"
		'
		'txtCharacterictics
		'
		Me.txtCharacterictics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCharacterictics.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCharacterictics.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "cha", True))
		Me.txtCharacterictics.Location = New System.Drawing.Point(132, 10)
		Me.txtCharacterictics.Margin = New System.Windows.Forms.Padding(4)
		Me.txtCharacterictics.Multiline = True
		Me.txtCharacterictics.Name = "txtCharacterictics"
		Me.txtCharacterictics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtCharacterictics.Size = New System.Drawing.Size(390, 68)
		Me.txtCharacterictics.TabIndex = 64
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnCancel.Location = New System.Drawing.Point(566, 16)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(100, 28)
		Me.btnCancel.TabIndex = 52
		Me.btnCancel.Text = "Cancel"
		'
		'btnSave
		'
		Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnSave.Location = New System.Drawing.Point(310, 16)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(100, 28)
		Me.btnSave.TabIndex = 50
		Me.btnSave.Text = "Save"
		'
		'lblLine
		'
		Me.lblLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblLine.BackColor = System.Drawing.Color.Black
		Me.lblLine.Location = New System.Drawing.Point(-164, 2)
		Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblLine.Name = "lblLine"
		Me.lblLine.Size = New System.Drawing.Size(1304, 2)
		Me.lblLine.TabIndex = 53
		'
		'Button2
		'
		Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Button2.Location = New System.Drawing.Point(438, 16)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(100, 28)
		Me.Button2.TabIndex = 51
		Me.Button2.Text = "Delete"
		'
		'txtlastupdateuser
		'
		Me.txtlastupdateuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "lastupdateuser", True))
		Me.txtlastupdateuser.Location = New System.Drawing.Point(809, 16)
		Me.txtlastupdateuser.Margin = New System.Windows.Forms.Padding(4)
		Me.txtlastupdateuser.Name = "txtlastupdateuser"
		Me.txtlastupdateuser.Size = New System.Drawing.Size(132, 22)
		Me.txtlastupdateuser.TabIndex = 50
		'
		'CowTableAdapter
		'
		Me.CowTableAdapter.ClearBeforeFill = True
		'
		'frmEditCow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.ClientSize = New System.Drawing.Size(977, 434)
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.MinimizeBox = False
		Me.Name = "frmEditCow"
		Me.Text = "Edit Cow"
		Me.TopMost = True
		Me.CaptionPanel.ResumeLayout(False)
		Me.CaptionPanel.PerformLayout()
		Me.BottomPanel.ResumeLayout(False)
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents InactivedaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOwner As System.Windows.Forms.ComboBox
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblCowNum As System.Windows.Forms.Label
    Friend WithEvents txtCowNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Age As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblCharacterictics As System.Windows.Forms.Label
    Friend WithEvents txtCharacterictics As System.Windows.Forms.TextBox
    Friend WithEvents DCow As Cattle.DCow
    Friend WithEvents CowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CowTableAdapter As Cattle.DCowTableAdapters.CowTableAdapter
    Friend WithEvents txtlastupdateuser As System.Windows.Forms.TextBox

End Class
