<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCowQueryReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.CowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCow = New Cattle.dsCow
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.connect1 = New System.Data.Odbc.OdbcConnection
        Me.da1 = New System.Data.Odbc.OdbcDataAdapter
        Me.DCow = New Cattle.DCow
        Me.CowTableAdapter = New Cattle.DCowTableAdapters.CowTableAdapter
        CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DCow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CowBindingSource
        '
        Me.CowBindingSource.DataMember = "cow"
        Me.CowBindingSource.DataSource = Me.DsCow
        '
        'DsCow
        '
        Me.DsCow.DataSetName = "dsCow"
        Me.DsCow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsCow_cow"
        ReportDataSource1.Value = Me.CowBindingSource
        ReportDataSource2.Name = "DCow_Cow"
        ReportDataSource2.Value = Me.CowBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DisplayName = "Cow Query"
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Cattle.CowQuery.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(733, 486)
        Me.ReportViewer1.TabIndex = 1
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.Connection = Me.connect1
        '
        'connect1
        '
        Me.connect1.ConnectionString = "Dsn=MYSQLCHOME;database=farm;option=0;port=0;server=chome;uid=root"
        '
        'da1
        '
        Me.da1.SelectCommand = Me.OdbcSelectCommand1
        '
        'DCow
        '
        Me.DCow.DataSetName = "DCow"
        Me.DCow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CowTableAdapter
        '
        Me.CowTableAdapter.ClearBeforeFill = True
        '
        'frmCowQueryReport
        '
        Me.ClientSize = New System.Drawing.Size(733, 486)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmCowQueryReport"
        Me.Text = "Cow Report"
        CType(Me.CowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DCow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsCow As Cattle.dsCow
    Friend WithEvents CowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents connect1 As System.Data.Odbc.OdbcConnection
    Friend WithEvents da1 As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents DCow As Cattle.DCow
    Friend WithEvents CowTableAdapter As Cattle.DCowTableAdapters.CowTableAdapter

End Class
