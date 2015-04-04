<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCow
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
		Dim IdLabel As System.Windows.Forms.Label
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCow))
		Me.lblOwner = New System.Windows.Forms.Label()
		Me.lblGroup = New System.Windows.Forms.Label()
		Me.lblCowNumber = New System.Windows.Forms.Label()
		Me.txtCowNote = New System.Windows.Forms.TextBox()
		Me.CowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DCow = New Cattle.DCow()
		Me.txtCowCharateristics = New System.Windows.Forms.TextBox()
		Me.lblCowNote = New System.Windows.Forms.Label()
		Me.lblCowCharacterstics = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Owner1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.CalfgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.calfid = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CowcalfBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.CowBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.txtTsFindcow = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ncow = New System.Windows.Forms.ToolStripButton()
		Me.edtcow = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ncalf = New System.Windows.Forms.ToolStripButton()
		Me.edtcalf = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.TSComboBox1 = New System.Windows.Forms.ToolStripComboBox()
		Me.clrfilter = New System.Windows.Forms.ToolStripButton()
		Me.txtcalfnum = New System.Windows.Forms.TextBox()
		Me.txtid = New System.Windows.Forms.TextBox()
		Me.lblCow = New System.Windows.Forms.Label()
		Me.lblHeadingCalves = New System.Windows.Forms.Label()
		Me.lblOwnerData = New System.Windows.Forms.Label()
		Me.lblGroupData = New System.Windows.Forms.Label()
		Me.lblCowData = New System.Windows.Forms.Label()
		Me.CalfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnactive = New System.Windows.Forms.Button()
		Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter()
		Me.CalfTableAdapter = New Cattle.DCowTableAdapters.calfTableAdapter()
		Me.btncowactive = New System.Windows.Forms.Button()
		Me.CalfgroupTableAdapter1 = New Cattle.DcalfTableAdapters.calfgroupTableAdapter()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		IdLabel = New System.Windows.Forms.Label()
		Me.CaptionPanel.SuspendLayout()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CowcalfBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CowBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.CowBindingNavigator.SuspendLayout()
		CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Controls.Add(Me.txtcalfnum)
		Me.CaptionPanel.Controls.Add(Me.txtid)
		Me.CaptionPanel.Controls.Add(IdLabel)
		Me.CaptionPanel.Controls.Add(Me.lblCow)
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(1005, 79)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.btnactive)
		Me.BottomPanel.Controls.Add(Me.lblHeadingCalves)
		Me.BottomPanel.Controls.Add(Me.CowBindingNavigator)
		Me.BottomPanel.Controls.Add(Me.DataGridView1)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 287)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(1005, 385)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.btncowactive)
		Me.LeftPanel.Controls.Add(Me.lblOwnerData)
		Me.LeftPanel.Controls.Add(Me.lblGroupData)
		Me.LeftPanel.Controls.Add(Me.lblCowData)
		Me.LeftPanel.Controls.Add(Me.lblOwner)
		Me.LeftPanel.Controls.Add(Me.lblGroup)
		Me.LeftPanel.Controls.Add(Me.lblCowNumber)
		Me.LeftPanel.Location = New System.Drawing.Point(0, 79)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(417, 208)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(Me.txtCowCharateristics)
		Me.RightPanel.Controls.Add(Me.txtCowNote)
		Me.RightPanel.Controls.Add(Me.lblCowNote)
		Me.RightPanel.Controls.Add(Me.lblCowCharacterstics)
		Me.RightPanel.Location = New System.Drawing.Point(417, 79)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(588, 208)
		'
		'IdLabel
		'
		IdLabel.AutoSize = True
		IdLabel.Location = New System.Drawing.Point(4, 17)
		IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		IdLabel.Name = "IdLabel"
		IdLabel.Size = New System.Drawing.Size(23, 17)
		IdLabel.TabIndex = 114
		IdLabel.Text = "id:"
		IdLabel.Visible = False
		'
		'lblOwner
		'
		Me.lblOwner.AutoSize = True
		Me.lblOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOwner.Location = New System.Drawing.Point(81, 144)
		Me.lblOwner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblOwner.Name = "lblOwner"
		Me.lblOwner.Size = New System.Drawing.Size(52, 18)
		Me.lblOwner.TabIndex = 117
		Me.lblOwner.Text = "Owner"
		'
		'lblGroup
		'
		Me.lblGroup.AutoSize = True
		Me.lblGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGroup.Location = New System.Drawing.Point(84, 82)
		Me.lblGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGroup.Name = "lblGroup"
		Me.lblGroup.Size = New System.Drawing.Size(50, 18)
		Me.lblGroup.TabIndex = 116
		Me.lblGroup.Text = "Group"
		'
		'lblCowNumber
		'
		Me.lblCowNumber.AutoSize = True
		Me.lblCowNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCowNumber.Location = New System.Drawing.Point(33, 23)
		Me.lblCowNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCowNumber.Name = "lblCowNumber"
		Me.lblCowNumber.Size = New System.Drawing.Size(96, 18)
		Me.lblCowNumber.TabIndex = 115
		Me.lblCowNumber.Text = "Cow Number"
		'
		'txtCowNote
		'
		Me.txtCowNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCowNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCowNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "note", True))
		Me.txtCowNote.Location = New System.Drawing.Point(147, 22)
		Me.txtCowNote.Margin = New System.Windows.Forms.Padding(4)
		Me.txtCowNote.Multiline = True
		Me.txtCowNote.Name = "txtCowNote"
		Me.txtCowNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtCowNote.Size = New System.Drawing.Size(409, 58)
		Me.txtCowNote.TabIndex = 115
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
		'txtCowCharateristics
		'
		Me.txtCowCharateristics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCowCharateristics.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCowCharateristics.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "cha", True))
		Me.txtCowCharateristics.Location = New System.Drawing.Point(147, 123)
		Me.txtCowCharateristics.Margin = New System.Windows.Forms.Padding(4)
		Me.txtCowCharateristics.Multiline = True
		Me.txtCowCharateristics.Name = "txtCowCharateristics"
		Me.txtCowCharateristics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtCowCharateristics.Size = New System.Drawing.Size(409, 58)
		Me.txtCowCharateristics.TabIndex = 114
		'
		'lblCowNote
		'
		Me.lblCowNote.AutoSize = True
		Me.lblCowNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCowNote.Location = New System.Drawing.Point(77, 22)
		Me.lblCowNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCowNote.Name = "lblCowNote"
		Me.lblCowNote.Size = New System.Drawing.Size(40, 18)
		Me.lblCowNote.TabIndex = 117
		Me.lblCowNote.Text = "Note"
		'
		'lblCowCharacterstics
		'
		Me.lblCowCharacterstics.AutoSize = True
		Me.lblCowCharacterstics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCowCharacterstics.Location = New System.Drawing.Point(5, 123)
		Me.lblCowCharacterstics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCowCharacterstics.Name = "lblCowCharacterstics"
		Me.lblCowCharacterstics.Size = New System.Drawing.Size(107, 18)
		Me.lblCowCharacterstics.TabIndex = 116
		Me.lblCowCharacterstics.Text = "Characteristics"
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToOrderColumns = True
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
		Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Owner1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column2, Me.Column3, Me.CalfgroupDataGridViewTextBoxColumn, Me.calfid})
		Me.DataGridView1.DataSource = Me.CowcalfBindingSource1
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
		Me.DataGridView1.Location = New System.Drawing.Point(63, 75)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.DataGridView1.RowHeadersWidth = 21
		Me.DataGridView1.Size = New System.Drawing.Size(889, 229)
		Me.DataGridView1.TabIndex = 104
		'
		'Column1
		'
		Me.Column1.DataPropertyName = "calfno"
		Me.Column1.DividerWidth = 1
		Me.Column1.HeaderText = "Calf Number"
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Column1.Width = 125
		'
		'Owner1
		'
		Me.Owner1.DataPropertyName = "owner"
		Me.Owner1.HeaderText = "Owner"
		Me.Owner1.Name = "Owner1"
		Me.Owner1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "dob"
		Me.DataGridViewTextBoxColumn1.HeaderText = "DOB"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "sex"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Sex"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'Column2
		'
		Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
		Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
		Me.Column2.HeaderText = "Desc."
		Me.Column2.Name = "Column2"
		Me.Column2.ReadOnly = True
		Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.Column2.Text = "Characteristics"
		Me.Column2.UseColumnTextForButtonValue = True
		'
		'Column3
		'
		Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
		Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
		Me.Column3.HeaderText = "Note"
		Me.Column3.Name = "Column3"
		Me.Column3.ReadOnly = True
		Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.Column3.Text = "Note"
		Me.Column3.ToolTipText = "Notes"
		Me.Column3.UseColumnTextForButtonValue = True
		'
		'CalfgroupDataGridViewTextBoxColumn
		'
		Me.CalfgroupDataGridViewTextBoxColumn.DataPropertyName = "calf_group"
		Me.CalfgroupDataGridViewTextBoxColumn.HeaderText = "calf_group"
		Me.CalfgroupDataGridViewTextBoxColumn.Name = "CalfgroupDataGridViewTextBoxColumn"
		Me.CalfgroupDataGridViewTextBoxColumn.ReadOnly = True
		Me.CalfgroupDataGridViewTextBoxColumn.Visible = False
		'
		'calfid
		'
		Me.calfid.DataPropertyName = "id"
		Me.calfid.HeaderText = "id"
		Me.calfid.Name = "calfid"
		Me.calfid.ReadOnly = True
		Me.calfid.Visible = False
		'
		'CowcalfBindingSource1
		'
		Me.CowcalfBindingSource1.DataMember = "Cow_calf"
		Me.CowcalfBindingSource1.DataSource = Me.CowBindingSource
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList1.Images.SetKeyName(0, "")
		Me.ImageList1.Images.SetKeyName(1, "")
		Me.ImageList1.Images.SetKeyName(2, "")
		Me.ImageList1.Images.SetKeyName(3, "")
		Me.ImageList1.Images.SetKeyName(4, "")
		Me.ImageList1.Images.SetKeyName(5, "")
		Me.ImageList1.Images.SetKeyName(6, "")
		'
		'CowBindingNavigator
		'
		Me.CowBindingNavigator.AddNewItem = Nothing
		Me.CowBindingNavigator.BindingSource = Me.CowBindingSource
		Me.CowBindingNavigator.CountItem = Me.BindingNavigatorCountItem
		Me.CowBindingNavigator.DeleteItem = Nothing
		Me.CowBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.CowBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.txtTsFindcow, Me.ToolStripSeparator1, Me.ncow, Me.edtcow, Me.ToolStripSeparator2, Me.ncalf, Me.edtcalf, Me.ToolStripButton6, Me.ToolStripLabel1, Me.TSComboBox1, Me.clrfilter})
		Me.CowBindingNavigator.Location = New System.Drawing.Point(0, 357)
		Me.CowBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.CowBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.CowBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.CowBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.CowBindingNavigator.Name = "CowBindingNavigator"
		Me.CowBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		Me.CowBindingNavigator.Size = New System.Drawing.Size(1005, 28)
		Me.CowBindingNavigator.TabIndex = 105
		Me.CowBindingNavigator.Text = "BindingNavigator1"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 25)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 25)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 25)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 28)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 28)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 25)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 25)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 6.0!)
		Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
		Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(53, 25)
		Me.ToolStripButton1.Text = "Find Cow"
		'
		'txtTsFindcow
		'
		Me.txtTsFindcow.AcceptsReturn = True
		Me.txtTsFindcow.BackColor = System.Drawing.Color.Silver
		Me.txtTsFindcow.Name = "txtTsFindcow"
		Me.txtTsFindcow.Size = New System.Drawing.Size(52, 28)
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
		'
		'ncow
		'
		Me.ncow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ncow.Image = CType(resources.GetObject("ncow.Image"), System.Drawing.Image)
		Me.ncow.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ncow.Name = "ncow"
		Me.ncow.Size = New System.Drawing.Size(23, 25)
		Me.ncow.Text = "NEWCOW"
		'
		'edtcow
		'
		Me.edtcow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.edtcow.Image = CType(resources.GetObject("edtcow.Image"), System.Drawing.Image)
		Me.edtcow.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.edtcow.Name = "edtcow"
		Me.edtcow.Size = New System.Drawing.Size(23, 25)
		Me.edtcow.Text = "Edit Cow"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
		'
		'ncalf
		'
		Me.ncalf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ncalf.Image = CType(resources.GetObject("ncalf.Image"), System.Drawing.Image)
		Me.ncalf.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ncalf.Name = "ncalf"
		Me.ncalf.Size = New System.Drawing.Size(23, 25)
		Me.ncalf.Text = "New Calf"
		'
		'edtcalf
		'
		Me.edtcalf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.edtcalf.Image = CType(resources.GetObject("edtcalf.Image"), System.Drawing.Image)
		Me.edtcalf.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.edtcalf.Name = "edtcalf"
		Me.edtcalf.Size = New System.Drawing.Size(23, 25)
		Me.edtcalf.Text = "Edit Calf"
		'
		'ToolStripButton6
		'
		Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
		Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton6.Name = "ToolStripButton6"
		Me.ToolStripButton6.Size = New System.Drawing.Size(23, 25)
		Me.ToolStripButton6.Text = "ToolStripButton6"
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 25)
		Me.ToolStripLabel1.Text = "Cow Filter"
		'
		'TSComboBox1
		'
		Me.TSComboBox1.BackColor = System.Drawing.Color.Silver
		Me.TSComboBox1.Items.AddRange(New Object() {"", "SPRING", "FALL", "OTHER", "BETTY", "BETTY/SPRING", "BETTY/FALL", "RANDY", "RANDY/SPRING", "RANDY/FALL", "ROB", "ROB/SPRING", "ROB/FALL"})
		Me.TSComboBox1.Name = "TSComboBox1"
		Me.TSComboBox1.Size = New System.Drawing.Size(160, 28)
		'
		'clrfilter
		'
		Me.clrfilter.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.clrfilter.CheckOnClick = True
		Me.clrfilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.clrfilter.Image = Global.Cattle.My.Resources.Resources.FILTER
		Me.clrfilter.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.clrfilter.Name = "clrfilter"
		Me.clrfilter.Size = New System.Drawing.Size(23, 25)
		Me.clrfilter.Text = "Clear Filter"
		'
		'txtcalfnum
		'
		Me.txtcalfnum.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtcalfnum.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtcalfnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "calfnum", True))
		Me.txtcalfnum.Location = New System.Drawing.Point(163, 22)
		Me.txtcalfnum.Margin = New System.Windows.Forms.Padding(4)
		Me.txtcalfnum.Name = "txtcalfnum"
		Me.txtcalfnum.Size = New System.Drawing.Size(0, 15)
		Me.txtcalfnum.TabIndex = 116
		'
		'txtid
		'
		Me.txtid.Location = New System.Drawing.Point(36, 14)
		Me.txtid.Margin = New System.Windows.Forms.Padding(4)
		Me.txtid.Name = "txtid"
		Me.txtid.Size = New System.Drawing.Size(0, 22)
		Me.txtid.TabIndex = 115
		'
		'lblCow
		'
		Me.lblCow.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblCow.AutoSize = True
		Me.lblCow.BackColor = System.Drawing.SystemColors.Control
		Me.lblCow.Font = New System.Drawing.Font("Arial", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
					  Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCow.Location = New System.Drawing.Point(263, 14)
		Me.lblCow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCow.Name = "lblCow"
		Me.lblCow.Size = New System.Drawing.Size(533, 54)
		Me.lblCow.TabIndex = 113
		Me.lblCow.Text = "Woodall Farm Records"
		Me.lblCow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblHeadingCalves
		'
		Me.lblHeadingCalves.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblHeadingCalves.Font = New System.Drawing.Font("Arial Black", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
					  Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeadingCalves.Location = New System.Drawing.Point(381, 20)
		Me.lblHeadingCalves.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHeadingCalves.Name = "lblHeadingCalves"
		Me.lblHeadingCalves.Size = New System.Drawing.Size(345, 46)
		Me.lblHeadingCalves.TabIndex = 106
		Me.lblHeadingCalves.Text = "Calves"
		Me.lblHeadingCalves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblOwnerData
		'
		Me.lblOwnerData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblOwnerData.BackColor = System.Drawing.SystemColors.Window
		Me.lblOwnerData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblOwnerData.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "owner_", True))
		Me.lblOwnerData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOwnerData.Location = New System.Drawing.Point(163, 144)
		Me.lblOwnerData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblOwnerData.Name = "lblOwnerData"
		Me.lblOwnerData.Size = New System.Drawing.Size(137, 28)
		Me.lblOwnerData.TabIndex = 165
		Me.lblOwnerData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblGroupData
		'
		Me.lblGroupData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblGroupData.BackColor = System.Drawing.SystemColors.Window
		Me.lblGroupData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGroupData.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "calf_group", True))
		Me.lblGroupData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGroupData.Location = New System.Drawing.Point(163, 82)
		Me.lblGroupData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGroupData.Name = "lblGroupData"
		Me.lblGroupData.Size = New System.Drawing.Size(137, 28)
		Me.lblGroupData.TabIndex = 164
		Me.lblGroupData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblCowData
		'
		Me.lblCowData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblCowData.BackColor = System.Drawing.SystemColors.Window
		Me.lblCowData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCowData.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CowBindingSource, "cow_number", True))
		Me.lblCowData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCowData.Location = New System.Drawing.Point(163, 23)
		Me.lblCowData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCowData.Name = "lblCowData"
		Me.lblCowData.Size = New System.Drawing.Size(137, 28)
		Me.lblCowData.TabIndex = 163
		Me.lblCowData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnactive
		'
		Me.btnactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnactive.Location = New System.Drawing.Point(63, 41)
		Me.btnactive.Margin = New System.Windows.Forms.Padding(4)
		Me.btnactive.Name = "btnactive"
		Me.btnactive.Size = New System.Drawing.Size(73, 27)
		Me.btnactive.TabIndex = 107
		Me.btnactive.Text = "Inactive"
		Me.btnactive.UseVisualStyleBackColor = True
		'
		'CowTableAdapter
		'
		Me.CowTableAdapter.ClearBeforeFill = True
		'
		'CalfTableAdapter
		'
		Me.CalfTableAdapter.ClearBeforeFill = True
		'
		'btncowactive
		'
		Me.btncowactive.Location = New System.Drawing.Point(5, 25)
		Me.btncowactive.Margin = New System.Windows.Forms.Padding(4)
		Me.btncowactive.Name = "btncowactive"
		Me.btncowactive.Size = New System.Drawing.Size(31, 27)
		Me.btncowactive.TabIndex = 117
		Me.btncowactive.Text = "::"
		Me.btncowactive.UseVisualStyleBackColor = True
		'
		'CalfgroupTableAdapter1
		'
		Me.CalfgroupTableAdapter1.ClearBeforeFill = True
		'
		'ToolTip1
		'
		Me.ToolTip1.IsBalloon = True
		'
		'frmCow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(1005, 672)
		Me.CurrentInstance = ""
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.MaxNumForms = 3
		Me.Name = "frmCow"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cow"
		Me.CaptionPanel.ResumeLayout(False)
		Me.CaptionPanel.PerformLayout()
		Me.BottomPanel.ResumeLayout(False)
		Me.BottomPanel.PerformLayout()
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CowcalfBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CowBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.CowBindingNavigator.ResumeLayout(False)
		Me.CowBindingNavigator.PerformLayout()
		CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents lblCowNumber As System.Windows.Forms.Label
    Friend WithEvents txtCowNote As System.Windows.Forms.TextBox
    Friend WithEvents txtCowCharateristics As System.Windows.Forms.TextBox
    Friend WithEvents lblCowNote As System.Windows.Forms.Label
    Friend WithEvents lblCowCharacterstics As System.Windows.Forms.Label
    Friend WithEvents CowBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTsFindcow As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ncow As System.Windows.Forms.ToolStripButton
    Friend WithEvents edtcow As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ncalf As System.Windows.Forms.ToolStripButton
    Friend WithEvents edtcalf As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents clrfilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtcalfnum As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lblCow As System.Windows.Forms.Label
    Friend WithEvents lblHeadingCalves As System.Windows.Forms.Label
    Friend WithEvents lblOwnerData As System.Windows.Forms.Label
    Friend WithEvents lblGroupData As System.Windows.Forms.Label
    Friend WithEvents lblCowData As System.Windows.Forms.Label
    Friend WithEvents DCow As Cattle.DCow
    Friend WithEvents CowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CowTableAdapter As Cattle.DCowTableAdapters.CowTableAdapter
    Friend WithEvents CalfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalfTableAdapter As Cattle.DCowTableAdapters.calfTableAdapter
    Friend WithEvents CowcalfBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Owner1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CalfgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calfid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnactive As System.Windows.Forms.Button
    Friend WithEvents btncowactive As System.Windows.Forms.Button
    Friend WithEvents CalfgroupTableAdapter1 As Cattle.DcalfTableAdapters.calfgroupTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
