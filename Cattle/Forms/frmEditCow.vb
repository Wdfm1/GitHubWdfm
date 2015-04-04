Public Class frmEditCow
    Public Sub New(ByVal intCowId As Integer)
        MyBase.New()
        Me.CowId = intCowId

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Private number As Integer

    'value of cow id passed from main cow form. Used to put proper record in form
    Public Property CowId() As Integer
        Get
            Return number
        End Get
        Set(ByVal Value As Integer)
            number = Value
        End Set
    End Property

	Private Sub frmEditCow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'for dialog form only fire disposed event so form handler works
		Me.Dispose(True)
	End Sub

	Private Sub frmNewCow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
		Dim recnum As Integer
		Me.CowTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
		Me.CowTableAdapter.Fill(Me.DCow.Cow)
		recnum = CowBindingSource.Find("id", Me.CowId)
		CowBindingSource.Position = recnum
		Me.txtlastupdateuser.Text = frmMain.CurUser
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		Me.Save()

		Me.Close()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.Cancel()

	End Sub
  
	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Me.Delete()
		Me.Close()

	End Sub


#Region "Custom Funtions"

    Public Overrides Sub Save()

        frmMain.RetCowNum = Me.CowId
        Me.CowBindingSource.EndEdit()

        Try
            Me.CowTableAdapter.Update(DCow)
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
        Dim intCurrentRecNum As Integer = CowBindingSource.Position
        DCow.Cow.Rows(intCurrentRecNum).Delete()
        Me.Save()
    End Sub
    Private Sub Cancel()

        Me.Close()
    End Sub
#End Region
    


   
	
End Class
