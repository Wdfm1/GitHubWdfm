Public Class frmnote
    Public Sub New(ByVal intTheId As String, ByVal strtable As String)
        MyBase.New()
        Me.TheId = intTheId
        Me.curTable = strtable
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Private number As String
    Private strval As String
    Public Property curTable() As String
        Get
            Return strval
        End Get
        Set(ByVal Value As String)
            strval = Value
        End Set
    End Property

    Public Property TheId() As String
        Get
            Return number
        End Get
        Set(ByVal Value As String)
            number = Value
        End Set
    End Property
    Private Sub frmnote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CowTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CalfTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Dim recnum As Integer

        If Me.curTable = "COW" Then
            Me.CowTableAdapter.Fill(Me.DCow.Cow)
            recnum = CowBindingSource.Find("id", Me.TheId)
            If recnum = -1 Then
                MessageBox.Show("Record was not found!")
                Me.Close()
            Else 'table=calf
                Me.CowBindingSource.Position = recnum
            End If
            TextBox1.DataBindings.Add("Text", CowBindingSource, "note", _
                    True, DataSourceUpdateMode.OnPropertyChanged)
        Else
            Me.CalfTableAdapter.Fill(Me.Dcalf.calf)
            recnum = CalfBindingSource.Find("id", Me.TheId)
            If recnum = -1 Then
                MessageBox.Show("Record was not found!")
                Me.Close()
            Else
                Me.CalfBindingSource.Position = recnum
            End If
            TextBox1.DataBindings.Add("Text", CalfBindingSource, "note", _
                                True, DataSourceUpdateMode.OnPropertyChanged)
        End If


    End Sub
End Class
