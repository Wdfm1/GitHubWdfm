Imports MySql.Data.MySqlClient

Public Class frmCalfQuery
	Dim val As String
	Public Property commandtxt() As String
		Get
			Return val
		End Get
		Set(ByVal Value As String)
			val = Value
		End Set
	End Property
	Private Sub RunQuery()
		Dim strgroup As String
		Dim strowner As String
		Dim strsex As String
		Dim strage As String
		Dim ConnectionString As String

		ConnectionString = frmMain.AppConnectionString
		Dim myconnection As MySqlConnection = New MySqlConnection(ConnectionString)
		myconnection.Open()
		If String.IsNullOrEmpty(Me.cmbop1.Text) Or String.IsNullOrEmpty(Me.cmbgroup.Text) Then
			strgroup = "calf_group <> ' '"
		Else
			strgroup = "calf_group " & Me.cmbop1.Text & " '" & Trim(Me.cmbgroup.Text) & "'"
		End If
		If String.IsNullOrEmpty(Me.cmbop2.Text) Or String.IsNullOrEmpty(Me.cmbowner.Text) Then
			strowner = "owner <> ' '"
		Else
			strowner = "owner " & Me.cmbop2.Text & " '" & Trim(Me.cmbowner.Text) & "'"
		End If
		If String.IsNullOrEmpty(Me.cmbop3.Text) Or String.IsNullOrEmpty(Me.cmbsex.Text) Then
			strsex = "sex <> ' '"
		Else
			strsex = "sex " & Me.cmbop3.Text & " '" & Trim(Me.cmbsex.Text) & "'"
		End If

		If String.IsNullOrEmpty(Me.cmbop4.Text) Or String.IsNullOrEmpty(Me.txtage.Text) Then
			strage = "(Select DATEDIFF(curdate(),dob))<> 0"
		Else
			strage = " (Select DATEDIFF(curdate(),dob))" & Me.cmbop4.Text & Me.txtage.Text
		End If
		Dim selectstring As String = "Select calfno,dob ,sex,calf_group,owner ,charr ,note,(select DATEDIFF(curdate(),dob))as Age,id,cowid from calf where " _
			& strgroup & " AND " & "active=1" & " AND " & strowner & " AND " & strsex & " AND " & strage

		Me.commandtxt = selectstring
		Dim cmd As New MySqlCommand(selectstring, myconnection)

		Dim db_reader As MySqlDataReader = _
   cmd.ExecuteReader(CommandBehavior.SingleResult)
		Dim dt As DataTable = New DataTable
		dt.Load(db_reader)
		'must set firt column data source or else the age column is put as first of grid columns
		'fill and width are also set
		Me.CalfDataGridView.Columns.Item(0).DataPropertyName = dt.Columns.Item(0).ColumnName
		Me.CalfDataGridView.Columns.Item(0).HeaderText = "Calf Number"
		Me.CalfDataGridView.Columns.Item(0).Width = 85

		Me.CalfDataGridView.DataSource = dt
		Me.CalfDataGridView.Columns.Item(1).Width = 80
		Me.CalfDataGridView.Columns.Item(2).Width = 60
		Me.CalfDataGridView.Columns.Item(3).Width = 90
		Me.CalfDataGridView.Columns.Item(4).Width = 60
		Me.CalfDataGridView.Columns.Item(7).Width = 35
		Me.CalfDataGridView.Columns.Item(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		Me.CalfDataGridView.Columns.Item(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


		'hide id column
		Me.CalfDataGridView.Columns.Item(8).Visible = False

		myconnection.Close()
		Dim a As Integer = dt.Rows.Count
		Me.lblretrec.Text = a.ToString & " Records Returned"
	End Sub
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

		Me.LeftPanel.Width = Me.Width / 2
		Me.Height = 346

		Me.lblretrec.Visible = False
		Me.btncancel.Visible = True
		Me.btnrun.Visible = True
		Me.btnreset.Visible = False
		Me.btnprint.Visible = False


		Me.CalfDataGridView.Visible = False



	End Sub
	Private Sub CalfDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CalfDataGridView.CellContentClick
		If e.ColumnIndex = 6 Then 'note
			Dim note As frmnote
			Dim intCalfId As String = CalfNoGet()
			note = New frmnote(intCalfId, "CALF")
			note.ShowDialog()
		ElseIf e.ColumnIndex = 5 Then
			Dim charr As frmcharr
			Dim intCalfId As String = CalfNoGet()
			charr = New frmcharr(intCalfId, "CALF")
			charr.ShowDialog()

		End If
	End Sub
	Private Sub btnrun_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrun.Click

		'Me.Height = 545
		Me.LeftPanel.Width = Me.Width
		Me.btncancel.Visible = False
		Me.btnrun.Visible = False
		Me.btnreset.Visible = True
		Me.btnprint.Visible = True
		Me.lblretrec.Visible = True
		Me.CalfDataGridView.Visible = True


		Me.RunQuery()
	End Sub
	Private Sub btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.Click
		Me.Close()
	End Sub
	Private Function CalfNoGet()
		Dim id As Integer
		Dim row As Integer = Me.CalfDataGridView.CurrentRow.Index

		id = Me.CalfDataGridView.Item(8, row).Value()
		Return id.ToString

	End Function
	Private Function GetCowid()
		Dim cowid As Integer
		Dim row As Integer = Me.CalfDataGridView.CurrentRow.Index

		cowid = Me.CalfDataGridView.Item(9, row).Value()
		Return cowid
	End Function
	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
		'Dim calfqueryreport As frmCalfQueryReport



		'Me.Cursor = Cursors.AppStarting
		'calfqueryreport = New frmCalfQueryReport(Me.commandtxt)
		'calfqueryreport.MdiParent = Me.MdiParent
		'calfqueryreport.Show()
		'Me.Cursor = Cursors.Default

	End Sub
	Private Sub frmCalfQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'load combo data
		Dim ConnectionString As String
		ConnectionString = frmMain.AppConnectionString
		Dim myconnection As MySqlConnection = New MySqlConnection(ConnectionString)
		myconnection.Open()
		Dim selectstring As String = "Select distinct calf_group from calf order by calf_group"
		Dim cmd As New MySqlCommand(selectstring, myconnection)

		Dim db_reader As MySqlDataReader = _
   cmd.ExecuteReader(CommandBehavior.SingleResult)
		Dim dt As DataTable = New DataTable
		dt.Load(db_reader)
		myconnection.Close()

		Me.cmbgroup.DataSource = dt
		Me.cmbgroup.DisplayMember = dt.Columns.Item(0).ColumnName

	End Sub

	Private Sub CalfDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CalfDataGridView.RowHeaderMouseDoubleClick
		Dim intCowId As Integer = GetCowid()
		Dim cow1 As frmCow

		cow1 = New frmCow()
		cow1.MdiParent = frmMain
		cow1.Show()
		cow1.FindCowById(intCowId)
	End Sub
End Class
