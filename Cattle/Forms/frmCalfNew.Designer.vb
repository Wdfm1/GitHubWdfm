<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalfNew
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
        Me.components = New System.ComponentModel.Container
        Dim SexLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalfNew))
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblCharacteristics = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.CalfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dcalf = New Cattle.Dcalf
        Me.lblLine = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblOwner = New System.Windows.Forms.Label
        Me.lblCownumber = New System.Windows.Forms.Label
        Me.txtdate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblGroup = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcowid = New System.Windows.Forms.TextBox
        Me.lblNote = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CalfBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CalfBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CalfTableAdapter = New Cattle.DcalfTableAdapters.calfTableAdapter
        Me.SexComboBox = New System.Windows.Forms.ComboBox
        SexLabel1 = New System.Windows.Forms.Label
        Me.CaptionPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalfBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalfBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CaptionPanel
        '
        Me.CaptionPanel.Controls.Add(Me.txtcowid)
        Me.CaptionPanel.Controls.Add(Me.Label8)
        Me.CaptionPanel.Size = New System.Drawing.Size(633, 39)
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.lblNote)
        Me.BottomPanel.Controls.Add(Me.TextBox1)
        Me.BottomPanel.Controls.Add(Me.btnSave)
        Me.BottomPanel.Controls.Add(Me.lblCharacteristics)
        Me.BottomPanel.Controls.Add(Me.TextBox2)
        Me.BottomPanel.Controls.Add(Me.lblLine)
        Me.BottomPanel.Controls.Add(Me.btnCancel)
        Me.BottomPanel.Location = New System.Drawing.Point(0, 192)
        Me.BottomPanel.Size = New System.Drawing.Size(633, 188)
        '
        'LeftPanel
        '
        Me.LeftPanel.Controls.Add(Me.lblOwner)
        Me.LeftPanel.Controls.Add(Me.lblCownumber)
        Me.LeftPanel.Controls.Add(Me.txtdate)
        Me.LeftPanel.Controls.Add(Me.Label6)
        Me.LeftPanel.Controls.Add(Me.Label4)
        Me.LeftPanel.Controls.Add(Me.Label3)
        Me.LeftPanel.Location = New System.Drawing.Point(0, 39)
        Me.LeftPanel.Size = New System.Drawing.Size(217, 153)
        '
        'RightPanel
        '
        Me.RightPanel.Controls.Add(SexLabel1)
        Me.RightPanel.Controls.Add(Me.SexComboBox)
        Me.RightPanel.Controls.Add(Me.lblGroup)
        Me.RightPanel.Controls.Add(Me.Label5)
        Me.RightPanel.Location = New System.Drawing.Point(217, 39)
        Me.RightPanel.Size = New System.Drawing.Size(416, 153)
        '
        'SexLabel1
        '
        SexLabel1.AutoSize = True
        SexLabel1.Location = New System.Drawing.Point(36, 18)
        SexLabel1.Name = "SexLabel1"
        SexLabel1.Size = New System.Drawing.Size(25, 13)
        SexLabel1.TabIndex = 72
        SexLabel1.Text = "Sex"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(250, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 40)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Calves"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(227, 127)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Save"
        '
        'lblCharacteristics
        '
        Me.lblCharacteristics.AutoSize = True
        Me.lblCharacteristics.Location = New System.Drawing.Point(3, 14)
        Me.lblCharacteristics.Name = "lblCharacteristics"
        Me.lblCharacteristics.Size = New System.Drawing.Size(77, 13)
        Me.lblCharacteristics.TabIndex = 83
        Me.lblCharacteristics.Text = "Characterictics"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "charr", True))
        Me.TextBox2.Location = New System.Drawing.Point(103, 15)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(466, 40)
        Me.TextBox2.TabIndex = 78
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
        'lblLine
        '
        Me.lblLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine.BackColor = System.Drawing.Color.Black
        Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLine.Location = New System.Drawing.Point(0, 115)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(634, 3)
        Me.lblLine.TabIndex = 81
        Me.lblLine.Text = "Label1"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(331, 127)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancel"
        '
        'lblOwner
        '
        Me.lblOwner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "owner", True))
        Me.lblOwner.Location = New System.Drawing.Point(104, 54)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(89, 21)
        Me.lblOwner.TabIndex = 68
        '
        'lblCownumber
        '
        Me.lblCownumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCownumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCownumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "calfno", True))
        Me.lblCownumber.Location = New System.Drawing.Point(104, 14)
        Me.lblCownumber.Name = "lblCownumber"
        Me.lblCownumber.Size = New System.Drawing.Size(86, 21)
        Me.lblCownumber.TabIndex = 67
        '
        'txtdate
        '
        Me.txtdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "dob", True))
        Me.txtdate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CalfBindingSource, "dob", True))
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(103, 86)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(90, 20)
        Me.txtdate.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "DOB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Owner"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Calf Number"
        '
        'lblGroup
        '
        Me.lblGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGroup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "calf_group", True))
        Me.lblGroup.Location = New System.Drawing.Point(101, 54)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(254, 21)
        Me.lblGroup.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Group"
        '
        'txtcowid
        '
        Me.txtcowid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtcowid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcowid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "cowid", True))
        Me.txtcowid.Location = New System.Drawing.Point(12, 12)
        Me.txtcowid.Name = "txtcowid"
        Me.txtcowid.Size = New System.Drawing.Size(0, 13)
        Me.txtcowid.TabIndex = 82
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(50, 66)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(30, 13)
        Me.lblNote.TabIndex = 85
        Me.lblNote.Text = "Note"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "note", True))
        Me.TextBox1.Location = New System.Drawing.Point(103, 66)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(466, 40)
        Me.TextBox1.TabIndex = 84
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CalfBindingNavigatorSaveItem
        '
        Me.CalfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CalfBindingNavigatorSaveItem.Image = CType(resources.GetObject("CalfBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CalfBindingNavigatorSaveItem.Name = "CalfBindingNavigatorSaveItem"
        Me.CalfBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CalfBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CalfBindingNavigator
        '
        Me.CalfBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CalfBindingNavigator.BindingSource = Me.CalfBindingSource
        Me.CalfBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CalfBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CalfBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CalfBindingNavigatorSaveItem})
        Me.CalfBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CalfBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CalfBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CalfBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CalfBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CalfBindingNavigator.Name = "CalfBindingNavigator"
        Me.CalfBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CalfBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.CalfBindingNavigator.TabIndex = 4
        Me.CalfBindingNavigator.Text = "BindingNavigator1"
        Me.CalfBindingNavigator.Visible = False
        '
        'CalfTableAdapter
        '
        Me.CalfTableAdapter.ClearBeforeFill = True
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalfBindingSource, "sex", True))
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"BULL", "HEIFER"})
        Me.SexComboBox.Location = New System.Drawing.Point(101, 18)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(254, 21)
        Me.SexComboBox.TabIndex = 73
        '
        'frmCalfNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 380)
        Me.Controls.Add(Me.CalfBindingNavigator)
        Me.MinimizeBox = False
        Me.Name = "frmCalfNew"
        Me.Text = "New Calf Record"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.CalfBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.CaptionPanel, 0)
        Me.Controls.SetChildIndex(Me.BottomPanel, 0)
        Me.Controls.SetChildIndex(Me.LeftPanel, 0)
        Me.Controls.SetChildIndex(Me.RightPanel, 0)
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
        CType(Me.CalfBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CalfBindingNavigator.ResumeLayout(False)
        Me.CalfBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblCharacteristics As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblCownumber As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

    Friend WithEvents txtcowid As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CalfBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CalfBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Dcalf As Cattle.Dcalf
    Friend WithEvents CalfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalfTableAdapter As Cattle.DcalfTableAdapters.calfTableAdapter
    Friend WithEvents SexComboBox As System.Windows.Forms.ComboBox

End Class
