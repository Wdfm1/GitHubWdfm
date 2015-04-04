<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcharr
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.CowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DCow = New Cattle.DCow()
		Me.Dcalf = New Cattle.Dcalf()
		Me.CalfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CalfTableAdapter = New Cattle.DcalfTableAdapters.calfTableAdapter()
		Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter()
		Me.CaptionPanel.SuspendLayout()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CaptionPanel
		'
		Me.CaptionPanel.Controls.Add(Me.TextBox1)
		Me.CaptionPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.CaptionPanel.Size = New System.Drawing.Size(536, 405)
		'
		'BottomPanel
		'
		Me.BottomPanel.Location = New System.Drawing.Point(0, 207)
		Me.BottomPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.BottomPanel.Size = New System.Drawing.Size(536, 0)
		'
		'LeftPanel
		'
		Me.LeftPanel.Location = New System.Drawing.Point(0, 405)
		Me.LeftPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.LeftPanel.Size = New System.Drawing.Size(135, 0)
		'
		'RightPanel
		'
		Me.RightPanel.Location = New System.Drawing.Point(135, 405)
		Me.RightPanel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.RightPanel.Size = New System.Drawing.Size(401, 0)
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.Silver
		Me.TextBox1.Location = New System.Drawing.Point(0, 0)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(532, 203)
		Me.TextBox1.TabIndex = 2
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
		'Dcalf
		'
		Me.Dcalf.DataSetName = "Dcalf"
		Me.Dcalf.EnforceConstraints = False
		Me.Dcalf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'CalfBindingSource
		'
		Me.CalfBindingSource.DataMember = "calf"
		Me.CalfBindingSource.DataSource = Me.Dcalf
		'
		'CalfTableAdapter
		'
		Me.CalfTableAdapter.ClearBeforeFill = True
		'
		'CowTableAdapter
		'
		Me.CowTableAdapter.ClearBeforeFill = True
		'
		'frmcharr
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.ClientSize = New System.Drawing.Size(536, 207)
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmcharr"
		Me.Text = "Description"
		Me.TopMost = True
		Me.CaptionPanel.ResumeLayout(False)
		Me.CaptionPanel.PerformLayout()
		CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Dcalf As Cattle.Dcalf
    Friend WithEvents CalfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalfTableAdapter As Cattle.DcalfTableAdapters.calfTableAdapter
    Friend WithEvents DCow As Cattle.DCow
    Friend WithEvents CowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CowTableAdapter As Cattle.DCowTableAdapters.CowTableAdapter

End Class
