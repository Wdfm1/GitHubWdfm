<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCow
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.CowBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.DCow = New Cattle.DCow()
		Me.Age = New System.Windows.Forms.Label()
		Me.lblGroup = New System.Windows.Forms.Label()
		Me.lblOwner = New System.Windows.Forms.Label()
		Me.lblCowNum = New System.Windows.Forms.Label()
		Me.txtNote = New System.Windows.Forms.TextBox()
		Me.lblNote = New System.Windows.Forms.Label()
		Me.lblCharacterictics = New System.Windows.Forms.Label()
		Me.txtCharacterictics = New System.Windows.Forms.TextBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblLine = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.cmbGroup = New System.Windows.Forms.ComboBox()
		Me.cmbOwner = New System.Windows.Forms.ComboBox()
		Me.txtCowNum = New System.Windows.Forms.TextBox()
		Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.CaptionPanel.SuspendLayout()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.CowBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Controls.Add(Me.lblTitle)
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(980, 70)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.lblLine)
		Me.BottomPanel.Controls.Add(Me.btnCancel)
		Me.BottomPanel.Controls.Add(Me.btnSave)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 301)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(980, 84)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.DateTimePicker1)
		Me.LeftPanel.Controls.Add(Me.cmbGroup)
		Me.LeftPanel.Controls.Add(Me.cmbOwner)
		Me.LeftPanel.Controls.Add(Me.txtCowNum)
		Me.LeftPanel.Controls.Add(Me.Label1)
		Me.LeftPanel.Controls.Add(Me.TextBox1)
		Me.LeftPanel.Controls.Add(Me.Age)
		Me.LeftPanel.Controls.Add(Me.lblGroup)
		Me.LeftPanel.Controls.Add(Me.lblOwner)
		Me.LeftPanel.Controls.Add(Me.lblCowNum)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(408, 231)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(Me.txtNote)
		Me.RightPanel.Controls.Add(Me.lblNote)
		Me.RightPanel.Controls.Add(Me.lblCharacterictics)
		Me.RightPanel.Controls.Add(Me.txtCharacterictics)
		Me.RightPanel.Location = New System.Drawing.Point(408, 70)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(572, 231)
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(19, 123)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(125, 17)
		Me.Label1.TabIndex = 45
		Me.Label1.Text = "Date of Ownership"
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource1, "age", True))
		Me.TextBox1.Location = New System.Drawing.Point(151, 155)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(63, 22)
		Me.TextBox1.TabIndex = 40
		'
		'CowBindingSource1
		'
		Me.CowBindingSource1.DataMember = "Cow"
		Me.CowBindingSource1.DataSource = Me.DCow
		'
		'DCow
		'
		Me.DCow.DataSetName = "DCow"
		Me.DCow.EnforceConstraints = False
		Me.DCow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Age
		'
		Me.Age.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Age.AutoSize = True
		Me.Age.Location = New System.Drawing.Point(108, 155)
		Me.Age.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Age.Name = "Age"
		Me.Age.Size = New System.Drawing.Size(33, 17)
		Me.Age.TabIndex = 44
		Me.Age.Text = "Age"
		'
		'lblGroup
		'
		Me.lblGroup.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblGroup.AutoSize = True
		Me.lblGroup.Location = New System.Drawing.Point(97, 88)
		Me.lblGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGroup.Name = "lblGroup"
		Me.lblGroup.Size = New System.Drawing.Size(48, 17)
		Me.lblGroup.TabIndex = 43
		Me.lblGroup.Text = "Group"
		'
		'lblOwner
		'
		Me.lblOwner.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblOwner.AutoSize = True
		Me.lblOwner.Location = New System.Drawing.Point(95, 45)
		Me.lblOwner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblOwner.Name = "lblOwner"
		Me.lblOwner.Size = New System.Drawing.Size(49, 17)
		Me.lblOwner.TabIndex = 42
		Me.lblOwner.Text = "Owner"
		'
		'lblCowNum
		'
		Me.lblCowNum.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblCowNum.AutoSize = True
		Me.lblCowNum.Location = New System.Drawing.Point(52, 6)
		Me.lblCowNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCowNum.Name = "lblCowNum"
		Me.lblCowNum.Size = New System.Drawing.Size(88, 17)
		Me.lblCowNum.TabIndex = 41
		Me.lblCowNum.Text = "Cow Number"
		'
		'txtNote
		'
		Me.txtNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource1, "note", True))
		Me.txtNote.Location = New System.Drawing.Point(139, 103)
		Me.txtNote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtNote.Multiline = True
		Me.txtNote.Name = "txtNote"
		Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtNote.Size = New System.Drawing.Size(309, 68)
		Me.txtNote.TabIndex = 25
		'
		'lblNote
		'
		Me.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblNote.AutoSize = True
		Me.lblNote.Location = New System.Drawing.Point(64, 100)
		Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNote.Name = "lblNote"
		Me.lblNote.Size = New System.Drawing.Size(45, 17)
		Me.lblNote.TabIndex = 27
		Me.lblNote.Text = "Notes"
		'
		'lblCharacterictics
		'
		Me.lblCharacterictics.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblCharacterictics.AutoSize = True
		Me.lblCharacterictics.Location = New System.Drawing.Point(0, 11)
		Me.lblCharacterictics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCharacterictics.Name = "lblCharacterictics"
		Me.lblCharacterictics.Size = New System.Drawing.Size(101, 17)
		Me.lblCharacterictics.TabIndex = 26
		Me.lblCharacterictics.Text = "Characteristics"
		'
		'txtCharacterictics
		'
		Me.txtCharacterictics.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCharacterictics.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource1, "cha", True))
		Me.txtCharacterictics.Location = New System.Drawing.Point(139, 15)
		Me.txtCharacterictics.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtCharacterictics.Multiline = True
		Me.txtCharacterictics.Name = "txtCharacterictics"
		Me.txtCharacterictics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtCharacterictics.Size = New System.Drawing.Size(309, 68)
		Me.txtCharacterictics.TabIndex = 24
		'
		'lblTitle
		'
		Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Location = New System.Drawing.Point(372, 1)
		Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(317, 49)
		Me.lblTitle.TabIndex = 29
		Me.lblTitle.Text = "Cow"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLine
		'
		Me.lblLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblLine.BackColor = System.Drawing.Color.Black
		Me.lblLine.Location = New System.Drawing.Point(-164, 4)
		Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblLine.Name = "lblLine"
		Me.lblLine.Size = New System.Drawing.Size(1307, 2)
		Me.lblLine.TabIndex = 33
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnCancel.Location = New System.Drawing.Point(519, 41)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(72, 28)
		Me.btnCancel.TabIndex = 32
		Me.btnCancel.Text = "Cancel"
		'
		'btnSave
		'
		Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnSave.Location = New System.Drawing.Point(389, 41)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(72, 28)
		Me.btnSave.TabIndex = 31
		Me.btnSave.Text = "Save"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource1, "dateofownership", True))
		Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CowBindingSource1, "dateofownership", True))
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(151, 125)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(216, 22)
		Me.DateTimePicker1.TabIndex = 49
		Me.DateTimePicker1.Value = New Date(2009, 3, 8, 0, 0, 0, 0)
		'
		'cmbGroup
		'
		Me.cmbGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbGroup.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CowBindingSource1, "calf_group", True))
		Me.cmbGroup.Items.AddRange(New Object() {"FALL", "SPRING"})
		Me.cmbGroup.Location = New System.Drawing.Point(151, 89)
		Me.cmbGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cmbGroup.Name = "cmbGroup"
		Me.cmbGroup.Size = New System.Drawing.Size(216, 24)
		Me.cmbGroup.TabIndex = 48
		'
		'cmbOwner
		'
		Me.cmbOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbOwner.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CowBindingSource1, "owner_", True))
		Me.cmbOwner.Items.AddRange(New Object() {"BETTY", "DERRICK", "RANDY", "ROB", "JARRETT"})
		Me.cmbOwner.Location = New System.Drawing.Point(151, 46)
		Me.cmbOwner.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cmbOwner.Name = "cmbOwner"
		Me.cmbOwner.Size = New System.Drawing.Size(216, 24)
		Me.cmbOwner.TabIndex = 47
		'
		'txtCowNum
		'
		Me.txtCowNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCowNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCowNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource1, "cow_number", True))
		Me.txtCowNum.Location = New System.Drawing.Point(151, 8)
		Me.txtCowNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtCowNum.Name = "txtCowNum"
		Me.txtCowNum.Size = New System.Drawing.Size(216, 22)
		Me.txtCowNum.TabIndex = 46
		'
		'CowTableAdapter
		'
		Me.CowTableAdapter.ClearBeforeFill = True
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'frmNewCow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.ClientSize = New System.Drawing.Size(980, 385)
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.MinimizeBox = False
		Me.Name = "frmNewCow"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "New Cow Record"
		Me.TopMost = True
		Me.CaptionPanel.ResumeLayout(False)
		Me.BottomPanel.ResumeLayout(False)
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.CowBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Age As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblCowNum As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblCharacterictics As System.Windows.Forms.Label
    Friend WithEvents txtCharacterictics As System.Windows.Forms.TextBox
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOwner As System.Windows.Forms.ComboBox
    Friend WithEvents txtCowNum As System.Windows.Forms.TextBox
    Friend WithEvents DCow As Cattle.DCow
    Friend WithEvents CowBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CowTableAdapter As Cattle.DCowTableAdapters.CowTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
