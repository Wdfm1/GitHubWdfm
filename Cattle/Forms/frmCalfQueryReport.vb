Public Class frmCalfQueryReport
    Public Sub New(ByVal strSql As String)
        MyBase.New()
        Me.commandtxt = strSql

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Dim val As String
    Public Property commandtxt() As String
        Get
            Return val
        End Get
        Set(ByVal Value As String)
            val = Value
        End Set
    End Property


  

   
    Private Sub frmcalfqueryreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ConnectionString As String
        ConnectionString = frmMain.AppConnectionString
        ' "Dsn=MYSQLCHOMEFARM;uid=root;pwd=briggitte"
        Me.OdbcConnection1.ConnectionString = ConnectionString

        Me.selectcmd.CommandText = Me.commandtxt
        Me.adptcalf.Fill(dsCalf, "calf")
        Me.WindowState = FormWindowState.Maximized
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
