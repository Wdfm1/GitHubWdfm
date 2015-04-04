<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnote
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Dcalf = New Cattle.Dcalf
        Me.CalfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalfTableAdapter = New Cattle.DcalfTableAdapters.calfTableAdapter
        Me.DCow = New Cattle.DCow
        Me.CowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter
        Me.CaptionPanel.SuspendLayout()
        CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaptionPanel
        '
        Me.CaptionPanel.Controls.Add(Me.TextBox1)
        Me.CaptionPanel.Size = New System.Drawing.Size(402, 233)
        '
        'BottomPanel
        '
        Me.BottomPanel.Location = New System.Drawing.Point(0, 202)
        Me.BottomPanel.Size = New System.Drawing.Size(402, 0)
        '
        'LeftPanel
        '
        Me.LeftPanel.Location = New System.Drawing.Point(0, 233)
        Me.LeftPanel.Size = New System.Drawing.Size(156, 0)
        '
        'RightPanel
        '
        Me.RightPanel.Location = New System.Drawing.Point(156, 233)
        Me.RightPanel.Size = New System.Drawing.Size(246, 0)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(406, 200)
        Me.TextBox1.TabIndex = 2
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
        'DCow
        '
        Me.DCow.DataSetName = "DCow"
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
        'frmnote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(402, 202)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmnote"
        Me.Text = "Note"
        Me.CaptionPanel.ResumeLayout(False)
        Me.CaptionPanel.PerformLayout()
        CType(Me.Dcalf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
