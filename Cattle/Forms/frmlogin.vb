Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmlogin

	' TODO: Insert code to perform custom authentication using the provided username and password 
	' (See  ).  
	' The custom principal can then be attached to the current thread's principal as follows: 
	'     My.User.CurrentPrincipal = CustomPrincipal
	' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
	' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
	' such as the username, display name, etc.
	Dim ncount As Integer = 0
	Public Property NumTry() As Integer
		Get
			Return ncount
		End Get
		Set(ByVal Value As Integer)
			ncount = Value
		End Set
	End Property
	Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
		
		Dim conn As MySqlConnection = New MySqlConnection
		Dim cPassword As String = Me.txtPassword.Text
		Dim cUser As String = Me.txtUser.Text
		Dim cServer As String = Me.cmbServer.Text
		conn.ConnectionString = "server=" & cServer & ";User Id=" & cUser & ";Password=" & cPassword & ";database=farm;Persist Security Info=True"
		frmMain.AppConnectionString = conn.ConnectionString
		frmMain.CurServer = cServer
		frmMain.CurUser = cUser

		frmMain.Text = "Farm Records On " & cServer & "\User:" & cUser

		Try
			conn.Open()


			Me.Panel1.Visible = False
			Me.lblSuccess.Visible = True
			Me.Timer1.Enabled = True

			conn.Close()

		Catch ex As Exception
			MessageBox.Show("Your password is invalid!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Me.NumTry = Me.NumTry + 1
			If NumTry = 3 Then
				MessageBox.Show("You do not know the password. Contact your system administrator.", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Application.Exit()
			Else

				Exit Sub

			End If
		Finally
			conn.Dispose()
		End Try

	End Sub

	Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
		Application.Exit()
	End Sub


	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

		Me.Close()
		frmMain.Show()


	End Sub



	Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
		If e.KeyChar = Chr(13) Then
			Me.OK_Click_1(Me, e)
		End If
	End Sub
End Class
