Public Class frmCalfNew
    Public Sub New(ByVal intCowId As Integer, ByVal strcownum As String, ByVal strnextnum As String, ByVal strGroup As String, ByVal strOwner As String)
        MyBase.New()
        Me.CowId = intCowId
        Me.Cownumber = strcownum
        Me.CalfNum = strnextnum
        Me.Group = strGroup
        Me.Ownername = strOwner



        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
#Region "Properties"
    Dim cownum As String
    Dim strnextcalf As String
    Dim cow_id As Integer
    Dim strGroup As String
    Dim strOwnername As String
    Public Property CalfNum() As Integer
        Get
            Return strnextcalf
        End Get
        Set(ByVal Value As Integer)
            strnextcalf = Value
        End Set
    End Property



    Public Property Cownumber() As Integer
        Get
            Return cownum
        End Get
        Set(ByVal Value As Integer)
            cownum = Value
        End Set
    End Property

    'value of cow id passed from main cow form. Used to put proper record in form
    Public Property CowId() As Integer
        Get
            Return cow_id
        End Get
        Set(ByVal Value As Integer)
            cow_id = Value
        End Set
    End Property
    'owners name
    Public Property Ownername() As String
        Get
            Return strOwnername
        End Get
        Set(ByVal Value As String)
            strOwnername = Value
        End Set
    End Property
    'group that cow is in
    Public Property Group() As String
        Get
            Return strGroup
        End Get
        Set(ByVal Value As String)
            strGroup = Value
        End Set
    End Property

#End Region

    Private Sub frmCalfNew_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'for dialog form only fire disposed event so form handler works
        Me.Dispose(True)
    End Sub
    Private Sub frmCalfNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CalfTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CalfTableAdapter.Fill(Me.Dcalf.calf)


        Me.NewRec()
    End Sub


#Region "Custom Functions"
    Sub NewRec()
        Dim newrow As DataRowView
        newrow = CalfBindingSource.AddNew
        Me.lblCownumber.Text = Me.Cownumber.ToString & "-" & Me.CalfNum
        Me.lblOwner.Text = Me.Ownername
        Me.txtcowid.Text = Me.CowId
        Me.lblGroup.Text = Me.Group & " " & Year(Now()).ToString
        'Me.TextBox3.Text = Me.Group & " " & Year(Now()).ToString()
        Me.CalfBindingSource.Position = Me.CalfBindingSource.Count


    End Sub
    Public Overrides Sub Save()
        Dim a As Integer
        Me.Validate()
        Me.CalfBindingSource.EndEdit()
        a = Me.CalfTableAdapter.Update(Dcalf.calf)
        frmMain.CalfUpdated = True
        frmMain.RetCowNum = Me.CowId
        Me.Close()
    End Sub
#End Region





    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Save()
    End Sub

    Private Sub CalfBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalfBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CalfBindingSource.EndEdit()
        Me.CalfTableAdapter.Update(Me.Dcalf.calf)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CalfBindingSource.Current("sex") = "Heifer"
    End Sub
End Class
