Imports MySql.Data.MySqlClient

Public Class frmNcalfQuery


	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Dim a As Integer = Me.cmbgroup.Text.IndexOf(" ")
		Dim cowgroup As String = Me.cmbgroup.Text.Substring(0, a).ToString
		Dim ConnectionString As String

		Dim selectstring As String = "SELECT distinct cow_number,calf_group,owner_,id from cow where calf_group='" & cowgroup & "' and active=1 and id NOT in(select cowid from calf where calf_group='" & Me.cmbgroup.Text & "'and active=1)"
		ConnectionString = frmMain.AppConnectionString
		Dim myconnection As MySqlConnection = New MySqlConnection(ConnectionString)
		myconnection.Open()
		Dim cmd As New MySqlCommand(selectstring, myconnection)

		Dim db_reader As MySqlDataReader = _
   cmd.ExecuteReader(CommandBehavior.SingleResult)
		Dim dt As DataTable = New DataTable
		dt.Load(db_reader)
		Me.DataGridView1.DataSource = dt
		Dim b As Integer = dt.Rows.Count
		Me.lblnumrecs.Text = "Records Returned:" & b.ToString
		myconnection.Close()
	End Sub

	Private Sub frmNcalfQuery_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Dim ConnectionString As String

		Dim selectstring As String = "SELECT distinct rtrim(calf_group) from calf order by calf_group"
		ConnectionString = frmMain.AppConnectionString
		'"Dsn=MYSQLCHOME;FARM;uid=root;pwd=briggitte"

		Dim myconnection As MySqlConnection = New MySqlConnection(ConnectionString)

		myconnection.Open()
		Dim cmd As New MySqlCommand(selectstring, myconnection)

		Dim db_reader As MySqlDataReader = _
   cmd.ExecuteReader(CommandBehavior.SingleResult)
		Dim dt As DataTable = New DataTable
		dt.Load(db_reader)
		Me.cmbgroup.DataSource = dt
		Me.cmbgroup.DisplayMember = dt.Columns(0).ColumnName
		Me.cmbgroup.ValueMember = dt.Columns(0).ColumnName
		myconnection.Close()
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Dim a As Integer = Me.cmbgroup.Text.IndexOf(" ")
		Dim cowgroup As String = Me.cmbgroup.Text.Substring(0, a).ToString
		Dim ConnectionString As String

		Dim selectstring As String = "SELECT distinct cow_number,owner_,id from cow where calf_group='' and active=1 and id NOT in(select cowid from calf where calf_group='" & Me.cmbgroup.Text & "')"
		ConnectionString = frmMain.AppConnectionString
			Dim myconnection As MySqlConnection = New MySqlConnection(ConnectionString)

		myconnection.Open()
		Dim cmd As New MySqlCommand(selectstring, myconnection)

		Dim db_reader As MySqlDataReader = _
   cmd.ExecuteReader(CommandBehavior.SingleResult)
		Dim dt As DataTable = New DataTable
		dt.Load(db_reader)
		Me.DataGridView1.DataSource = dt
		Me.lblnumrecs.Text = ""
		myconnection.Close()
	End Sub
End Class
