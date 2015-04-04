Imports Microsoft.Reporting
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _

Partial Class frmCalfQueryReport
	Inherits System.Windows.Forms.Form

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
		Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
		Me.adptcalf = New System.Data.Odbc.OdbcDataAdapter
		Me.OdbcDeleteCommand1 = New System.Data.Odbc.OdbcCommand
		Me.OdbcInsertCommand1 = New System.Data.Odbc.OdbcCommand
		Me.selectcmd = New System.Data.Odbc.OdbcCommand
		Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
		Me.OdbcUpdateCommand1 = New System.Data.Odbc.OdbcCommand
		Me.dsCalf = New Cattle.dsCalf
		Me.calfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
		CType(Me.dsCalf, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.calfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'adptcalf
		'
		Me.adptcalf.DeleteCommand = Me.OdbcDeleteCommand1
		Me.adptcalf.InsertCommand = Me.OdbcInsertCommand1
		Me.adptcalf.SelectCommand = Me.selectcmd
		Me.adptcalf.UpdateCommand = Me.OdbcUpdateCommand1
		'
		'selectcmd
		'
		Me.selectcmd.Connection = Me.OdbcConnection1
		'
		'dsCalf
		'
		Me.dsCalf.DataSetName = "dsCalf"
		Me.dsCalf.EnforceConstraints = False
		Me.dsCalf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'calfBindingSource
		'
		Me.calfBindingSource.DataMember = "calf"
		Me.calfBindingSource.DataSource = Me.dsCalf
		'
		'ReportViewer1
		'
		Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		ReportDataSource2.Name = "dsCalf_calf"
		ReportDataSource2.Value = Me.calfBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Cattle.CalfQuery.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.Size = New System.Drawing.Size(703, 361)
		Me.ReportViewer1.TabIndex = 1
		'
		'frmCalfQueryReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(703, 361)

		Me.Controls.Add(Me.ReportViewer1)
		Me.Name = "frmCalfQueryReport"
		Me.Text = "Calf Query Report"
		CType(Me.dsCalf, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.calfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents adptcalf As System.Data.Odbc.OdbcDataAdapter
	Friend WithEvents OdbcDeleteCommand1 As System.Data.Odbc.OdbcCommand
	Friend WithEvents OdbcInsertCommand1 As System.Data.Odbc.OdbcCommand
	Friend WithEvents selectcmd As System.Data.Odbc.OdbcCommand
	Friend WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
	Friend WithEvents OdbcUpdateCommand1 As System.Data.Odbc.OdbcCommand
	Friend WithEvents dsCalf As Cattle.dsCalf
	Friend WithEvents calfBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

End Class
