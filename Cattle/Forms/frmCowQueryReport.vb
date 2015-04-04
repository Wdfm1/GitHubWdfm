Public Class frmCowQueryReport
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

    
    Private Sub Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ConnectionString As String
        ConnectionString = frmMain.AppConnectionString
        ' "Dsn=MYSQLCHOMEFARM;uid=root;pwd=briggitte"
        Me.connect1.ConnectionString = ConnectionString
        Me.da1.SelectCommand.CommandText = Me.commandtxt
        Me.da1.Fill(DsCow, "cow")
        Me.ReportViewer1.RefreshReport()
        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class
