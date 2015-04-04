Imports MySql.Data.MySqlClient

Public Class frmCowQuery
	Dim val As String
	Public Property commandtxt() As String
		Get
			Return val
		End Get
		Set(ByVal Value As String)
			val = Value
		End Set
	End Property

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
		Me.RunQ()
	End Sub
	Private Sub RunQ()
		Dim ConnectionString As String

		ConnectionString = frmMain.AppConnectionString
		'"Dsn=MYSQLCHOMEFARM;uid=root;pwd=briggitte"

		Dim myconnection As MySqlConnection = New MySqlConnection(ConnectionString)
		myconnection.Open()
		Dim str1 As String
		Dim str2 As String
		Me.LeftPanel.Width = Me.Width
		If Me.Height < 300 Then
			Me.Height = 301
		End If
		Me.DataGridView1.Visible = True
		Me.btnExit.Visible = False
		Me.btnRun.Visible = False
		Me.btnReset.Visible = True
		Me.btnPrint.Visible = True
		Me.lblrecret.Visible = True

		If String.IsNullOrEmpty(Me.cmbgroup.Text) Then
			str1 = "calf_group<>' '"
		Else
			str1 = "calf_group='" & Me.cmbgroup.Text & "'"
		End If
		If String.IsNullOrEmpty(Me.cmbowner.Text) Then
			str2 = "owner_<>' '"
		Else
			str2 = "owner_='" & Me.cmbowner.Text & "'"
		End If
		Dim selectstring As String = "Select cow_number,calf_group,owner_,cha,note,id from cow where " _
		 & str1 & "AND " & str2 & "AND active=1 order by cow_number"
		Me.commandtxt = selectstring


		Dim cmd As New MySqlCommand(selectstring, myconnection)

		Dim db_reader As MySqlDataReader = _
   cmd.ExecuteReader(CommandBehavior.SingleResult)
		Dim dt As DataTable = New DataTable
		dt.Load(db_reader)
		Me.DataGridView1.DataSource = dt
		Me.DataGridView1.Columns.Item(5).Visible = False


		myconnection.Close()
		Dim a As Integer = dt.Rows.Count

		Me.lblrecret.Text = a.ToString & " Records Returned"
		Me.lblrecret.Visible = True	'keep down here because of rendering

	End Sub

	Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click


		Me.Height = 200	'standard height
		Me.Width = 650
		Me.LeftPanel.Width = Me.Width / 2
		Me.DataGridView1.Visible = False
		Me.btnExit.Visible = True
		Me.btnRun.Visible = True
		Me.btnReset.Visible = False
		Me.btnPrint.Visible = False
		Me.lblrecret.Visible = False

	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

		'Dim cowqueryreport As frmCowQueryReport

		'Me.Cursor = Cursors.AppStarting
		'cowqueryreport = New frmCowQueryReport(Me.commandtxt)
		'cowqueryreport.MdiParent = Me.MdiParent
		'cowqueryreport.Show()
		'Me.Cursor = Cursors.Default

	End Sub

	Private Function GetCowId()
		Dim id As Integer
		Dim row As Integer = Me.DataGridView1.CurrentRow.Index

		id = Me.DataGridView1.Item(5, row).Value()
		Return id.ToString
	End Function



	Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
		Select Case e.ColumnIndex
			Case 4 'note
				Dim note As frmnote
				Dim intCowId As String = GetCowId()
				note = New frmnote(intCowId, "COW")
				note.ShowDialog()
			Case 3 'char
				Dim charr As frmcharr
				Dim intCowId As String = GetCowId()
				charr = New frmcharr(intCowId, "COW")
				charr.ShowDialog()

		End Select
	End Sub

	Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
		'open cow form
		Dim cow1 As frmCow
		Dim intCowId As String = GetCowId()
		cow1 = New frmCow()
		cow1.MdiParent = frmMain
		cow1.Show()
		cow1.FindCowById(intCowId)

	End Sub
End Class
