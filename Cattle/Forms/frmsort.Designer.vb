<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsort
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
		Me.AllCommand = New System.Data.Odbc.OdbcCommand()
		Me.FallCommand = New System.Data.Odbc.OdbcCommand()
		Me.SpringCommand = New System.Data.Odbc.OdbcCommand()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lstNotFound = New System.Windows.Forms.ListBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lstFound = New System.Windows.Forms.ListBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.DCow = New Cattle.DCow()
		Me.CowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter()
		Me.CaptionPanel.SuspendLayout()
		Me.BottomPanel.SuspendLayout()
		Me.LeftPanel.SuspendLayout()
		Me.RightPanel.SuspendLayout()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Controls.Add(Me.Label6)
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(597, 68)
		'
		'BottomPanel
		'
		Me.BottomPanel.Controls.Add(Me.Label5)
		Me.BottomPanel.Controls.Add(Me.Button7)
		Me.BottomPanel.Controls.Add(Me.Button6)
		Me.BottomPanel.Controls.Add(Me.Button5)
		Me.BottomPanel.Location = New System.Drawing.Point(0, 317)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(597, 81)
		'
		'LeftPanel
		'
		Me.LeftPanel.Controls.Add(Me.Button4)
		Me.LeftPanel.Controls.Add(Me.Button3)
		Me.LeftPanel.Controls.Add(Me.Button2)
		Me.LeftPanel.Controls.Add(Me.Button1)
		Me.LeftPanel.Controls.Add(Me.lstNotFound)
		Me.LeftPanel.Controls.Add(Me.Label3)
		Me.LeftPanel.Controls.Add(Me.Label1)
		Me.LeftPanel.Location = New System.Drawing.Point(0, 68)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(321, 249)
		'
		'RightPanel
		'
		Me.RightPanel.Controls.Add(Me.Label4)
		Me.RightPanel.Controls.Add(Me.Label2)
		Me.RightPanel.Controls.Add(Me.lstFound)
		Me.RightPanel.Location = New System.Drawing.Point(321, 68)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(276, 249)
		'
		'AllCommand
		'
		Me.AllCommand.CommandText = "SELECT     cow_number, active, calf_group" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         cow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (active = " & _
		  "1)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY cow_number"
		'
		'FallCommand
		'
		Me.FallCommand.CommandText = "SELECT     cow_number, calf_group, active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         cow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (calf_grou" & _
		  "p = 'FALL') AND (active = 1)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY cow_number"
		'
		'SpringCommand
		'
		Me.SpringCommand.CommandText = "SELECT     calf_group, cow_number, active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         cow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (active = " & _
		  "1) AND (calf_group = 'SPRING')" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY cow_number"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(172, 12)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(180, 44)
		Me.Label6.TabIndex = 30
		Me.Label6.Text = "Cow Sort"
		'
		'lstNotFound
		'
		Me.lstNotFound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstNotFound.FormattingEnabled = True
		Me.lstNotFound.ItemHeight = 16
		Me.lstNotFound.Location = New System.Drawing.Point(16, 62)
		Me.lstNotFound.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lstNotFound.Name = "lstNotFound"
		Me.lstNotFound.Size = New System.Drawing.Size(156, 84)
		Me.lstNotFound.TabIndex = 27
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(48, 25)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(74, 17)
		Me.Label3.TabIndex = 33
		Me.Label3.Text = "Not Found"
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(48, 197)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(103, 17)
		Me.Label1.TabIndex = 32
		Me.Label1.Text = "0 Cow Records"
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(93, 25)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(52, 17)
		Me.Label4.TabIndex = 30
		Me.Label4.Text = " Found"
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(93, 194)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(103, 17)
		Me.Label2.TabIndex = 29
		Me.Label2.Text = "0 Cow Records"
		'
		'lstFound
		'
		Me.lstFound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstFound.FormattingEnabled = True
		Me.lstFound.ItemHeight = 16
		Me.lstFound.Location = New System.Drawing.Point(23, 62)
		Me.lstFound.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lstFound.Name = "lstFound"
		Me.lstFound.Size = New System.Drawing.Size(221, 84)
		Me.lstFound.TabIndex = 28
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(247, 6)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(109, 17)
		Me.Label5.TabIndex = 32
		Me.Label5.Text = "Total Records:0"
		'
		'Button7
		'
		Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Button7.Location = New System.Drawing.Point(248, 42)
		Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(100, 28)
		Me.Button7.TabIndex = 30
		Me.Button7.Text = "Fall"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Button6.Location = New System.Drawing.Point(356, 42)
		Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(100, 28)
		Me.Button6.TabIndex = 31
		Me.Button6.Text = "All"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Button5.Location = New System.Drawing.Point(140, 42)
		Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(100, 28)
		Me.Button5.TabIndex = 29
		Me.Button5.Text = "Spring"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button4.Location = New System.Drawing.Point(197, 159)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(71, 28)
		Me.Button4.TabIndex = 37
		Me.Button4.Text = "<<"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button3.Location = New System.Drawing.Point(197, 65)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(71, 28)
		Me.Button3.TabIndex = 35
		Me.Button3.Text = ">>"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button2.Location = New System.Drawing.Point(197, 123)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(71, 28)
		Me.Button2.TabIndex = 36
		Me.Button2.Text = "<"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button1.Location = New System.Drawing.Point(197, 29)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(71, 28)
		Me.Button1.TabIndex = 34
		Me.Button1.Text = ">"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'DCow
		'
		Me.DCow.DataSetName = "DCow"
		Me.DCow.EnforceConstraints = False
		Me.DCow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'CowBindingSource
		'
		Me.CowBindingSource.DataMember = "Cow"
		Me.CowBindingSource.DataSource = Me.DCow
		'
		'CowTableAdapter
		'
		Me.CowTableAdapter.ClearBeforeFill = True
		'
		'frmsort
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.BottomPanelFloat = True
		Me.ClientSize = New System.Drawing.Size(597, 398)
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.Name = "frmsort"
		Me.Text = "Cow Sort"
		Me.CaptionPanel.ResumeLayout(False)
		Me.CaptionPanel.PerformLayout()
		Me.BottomPanel.ResumeLayout(False)
		Me.BottomPanel.PerformLayout()
		Me.LeftPanel.ResumeLayout(False)
		Me.LeftPanel.PerformLayout()
		Me.RightPanel.ResumeLayout(False)
		Me.RightPanel.PerformLayout()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents lstNotFound As System.Windows.Forms.ListBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents lstFound As System.Windows.Forms.ListBox
	Friend WithEvents AllCommand As System.Data.Odbc.OdbcCommand
	Friend WithEvents FallCommand As System.Data.Odbc.OdbcCommand
	Friend WithEvents SpringCommand As System.Data.Odbc.OdbcCommand
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Button7 As System.Windows.Forms.Button
	Friend WithEvents Button6 As System.Windows.Forms.Button
	Friend WithEvents Button5 As System.Windows.Forms.Button
	Friend WithEvents Button4 As System.Windows.Forms.Button
	Friend WithEvents Button3 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents DCow As Cattle.DCow
	Friend WithEvents CowBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents CowTableAdapter As Cattle.DCowTableAdapters.CowTableAdapter

End Class
