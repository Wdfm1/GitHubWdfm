Public Class frmCalfEdit
    Public Sub New(ByVal intCalfId As String, ByVal cowsid As Integer)
        MyBase.New()
        Me.CalfId = intCalfId
        Me.CowId = cowsid
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Private number As String
    Private strGroup As String
    Private cid As Integer
    Public Property CowId() As Integer
        Get
            Return cid
        End Get
        Set(ByVal Value As Integer)
            cid = Value
        End Set
    End Property
    Public Property CalfId() As String
        Get
            Return number
        End Get
        Set(ByVal Value As String)
            number = Value
        End Set
    End Property

    Private Sub frmCalfEdit_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'for dialog form only fire disposed event so form handler works
        Me.Dispose(True)
    End Sub


    Private Sub frmCalfEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dcalf.calfgroup' table. You can move, or remove it, as needed.

        Me.CalfTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CalfgroupTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CalfgroupTableAdapter.Fill(Me.Dcalf.calfgroup)
        Me.CalfTableAdapter.Fill(Me.Dcalf.calf)

        Dim recnum As Integer
        recnum = CalfBindingSource.Find("id", Me.CalfId)
        If recnum = -1 Then
            MessageBox.Show("Record was not found!")
            Me.Close()
        Else
            Me.CalfBindingSource.Position = recnum
        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Save()


    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Delete()

        Me.Close()

    End Sub
#Region "Custom Functions"

    Public Overrides Sub Save()

        
        Me.Validate()
        Me.CalfBindingSource.EndEdit()
        Try
            Me.CalfTableAdapter.Update(Dcalf.calf)
            frmMain.CalfUpdated = True
            frmMain.RetCowNum = Me.CowId
            Me.Close()
        Catch ex As DBConcurrencyException
            Dim customErrorMessage As String
            customErrorMessage = "Concurrency violation" & vbCrLf
            customErrorMessage += CType(ex.Row.Item(0), String)
            MessageBox.Show(customErrorMessage)
            ' Replace the above code with appropriate business logic
            ' to resolve the concurrency violation.
        End Try
    End Sub
    Private Sub Delete()
        Dim intCurrentRecNum As Integer = Me.CalfBindingSource.Position

        Dcalf.calf.Rows(intCurrentRecNum).Delete()
        Me.Save()
    End Sub
#End Region

   
    

    

    
End Class
