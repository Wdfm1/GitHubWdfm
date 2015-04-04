Public Class frmCow
    Dim tupdated As Boolean = False
    Dim icid As Integer
    Dim curid As Integer
    Dim Icowid As Integer
   
    Public Property CurrentCowid() As Integer
        Get
            Return curid
        End Get
        Set(ByVal Value As Integer)
            curid = Value
        End Set
    End Property
    Public Property UpdateCalfNumber() As Boolean
        Get
            Return tupdated
        End Get
        Set(ByVal Value As Boolean)
            tupdated = Value
        End Set
    End Property
    Public Property ReturnedCowNum() As Integer
        Get
            Return icid
        End Get
        Set(ByVal Value As Integer)
            icid = Value
        End Set
    End Property

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim a As String = frmMain.AppConnectionString
		Me.CowTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CalfTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CalfTableAdapter.Fill(Me.DCow.calf)
        Me.CowTableAdapter.Fill(Me.DCow.Cow)
        Me.ToolTip1.SetToolTip(btncowactive, "Filter active/inactive")
    End Sub
    Private Sub SeekToolStripTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Seek the first product whose name starts with the text in SeekToolStripTextBox.
        Me.clrfilter.Image = Cattle.My.Resources.Resources.FILTER
        Dim seekValue As String = CType(sender, ToolStripTextBox).Text.TrimStart()

        If String.IsNullOrEmpty(seekValue) = False Then
            CowBindingSource.Filter = "cow_number ='" + seekValue + "'"
        Else
            CowBindingSource.RemoveFilter()
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.EditCalf()
    End Sub
    Private Sub btnNewRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.NewCalf()
    End Sub

    Private Sub frmCow_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Forms.Decrease(Me.Name)
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ncow.Click
        Me.NewCow()
    End Sub
    Private Sub edtcow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtcow.Click
        Me.EditCow()
    End Sub
    Private Sub btnNewRec_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.NewCalf()
    End Sub
    Private Sub edtcalf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtcalf.Click
        Me.EditCalf()
    End Sub
    Private Sub ncalf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ncalf.Click
        Me.NewCalf()
    End Sub
    Private Sub FindCowById(ByVal icowid As Integer)
        Dim a As Integer
        a = CowBindingSource.Find("id", Icowid)

        If a >= 0 Then
            CowBindingSource.Position = a
            ' txtFind.Text = ""
        Else
            MessageBox.Show("Record not found!", "Record", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If IsNumeric(txtTsFindcow.Text) Then
            FindCow(txtTsFindcow.Text)
        Else
            MessageBox.Show("You must enter a number to search for. Do not use characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtTsFindcow.Focus()
        End If
    End Sub
    Private Sub txtTsFindcow_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTsFindcow.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.ToolStripButton1_Click_1(Me, e)
        End If
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrfilter.Click
        If Me.clrfilter.Checked = True Then 'button has been changed by the time this code executes
            'We are turning filter on here.
            Me.clrfilter.Image = Cattle.My.Resources.Resources.filteroff
            Me.clrfilter.ToolTipText = "Turn filter off."
            Select Case TSComboBox1.Text
                Case "SPRING"
                    CowBindingSource.Filter = "calf_group ='SPRING'"
                Case "FALL"
                    CowBindingSource.Filter = "calf_group ='FALL'"
                Case "OTHER"
                    CowBindingSource.Filter = "calf_group ='OTHER'"

                Case "BETTY"
                    CowBindingSource.Filter = "owner_ ='BETTY'"
                Case "BETTY/SPRING"
                    CowBindingSource.Filter = "owner_='BETTY' and calf_group ='SPRING'"
                Case "BETTY/FALL"
                    CowBindingSource.Filter = "owner_='BETTY' and calf_group ='FALL'"
                Case "RANDY"
                    CowBindingSource.Filter = "owner_ ='RANDY'"
                Case "RANDY/SPRING"
                    CowBindingSource.Filter = "owner_='RANDY' and calf_group ='SPRING'"
                Case "RANDY/FALL"
                    CowBindingSource.Filter = "owner_='RANDY' and calf_group ='FALL'"
                Case "ROB"
                    CowBindingSource.Filter = "owner_ ='ROB'"
                Case "ROB/SPRING"
                    CowBindingSource.Filter = "owner_='ROB' and calf_group ='SPRING'"
                Case "ROB/FALL"
                    CowBindingSource.Filter = "owner_='ROB' and calf_group ='FALL'"
            End Select
        Else
            'Button is now reversed
            'we are turning filter off
            Me.clrfilter.Image = Cattle.My.Resources.Resources.FILTER
            Me.clrfilter.ToolTipText = "Turn filter on."
            CowBindingSource.RemoveFilter()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 5 Then 'note
            Dim note As frmnote
            Dim intCalfId As String = CalfNoGet()
            note = New frmnote(intCalfId, "CALF")
            note.ShowDialog()
        ElseIf e.ColumnIndex = 4 Then
            Dim charr As frmcharr
            Dim intCalfId As String = CalfNoGet()
            charr = New frmcharr(intCalfId, "CALF")
            charr.ShowDialog()

        End If

    End Sub
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactive.Click
Select Case Me.btnactive.Text
    Case "Active"
        Me.btnactive.Text = "Inactive"
        Me.CalfTableAdapter.Fill(Me.DCow.calf)
Me.DataGridView1.DefaultCellStyle.BackColor = Color.LightGray
    Case "Inactive"
        Me.btnactive.Text = "Active"
    Me.CalfTableAdapter.FillByInactivecalf(Me.DCow.calf)
Me.DataGridView1.DefaultCellStyle.BackColor = Color.Gold
End Select
End Sub
#Region "CutomFunctions and Procedures"

    Private Sub DeleteCow()
        Dim intCurrentRecNum As Integer = Me.CowBindingSource.Position
        DCow.Cow.Rows(intCurrentRecNum).Delete()
        Try
            Me.CowTableAdapter.Update(DCow.Cow)
            Me.CalfTableAdapter.Fill(Me.DCow.calf)
            Me.CowTableAdapter.Fill(Me.DCow.Cow)
            Me.CowBindingSource.Position = intCurrentRecNum
        Catch ex As Exception
            MessageBox.Show("There was an error saving record. The record was not saved.", "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub DeleteCalf()
        Me.EditCalf()
    End Sub
    Private Sub EditCalf()
        ' Try
        Dim CalfEdit As frmCalfEdit
        Dim intCalfId As String = CalfNoGet()
        Dim intCowId As Integer = GetCowId()
        Dim rownum As Integer
        CalfEdit = New frmCalfEdit(intCalfId, intCowId)
        'CalfEdit.MdiParent = Me.MdiParent
        frmMain.WindowState = FormWindowState.Maximized
        CalfEdit.ShowDialog()
        If frmMain.CalfUpdated = True Then

            frmMain.CalfUpdated = False

            Me.CalfTableAdapter.Fill(Me.DCow.calf)
            Me.CowTableAdapter.Fill(Me.DCow.Cow)
            CowBindingSource.Sort = "cow_number"
            rownum = CowBindingSource.Find("id", frmMain.RetCowNum)
            Me.CowBindingSource.Position = rownum
            frmMain.RetCowNum = Nothing
        End If
    End Sub
    Private Sub NewCalf()
        Dim NewCalf As frmCalfNew
        Dim IntCowId As Integer = GetCowId()
        Dim strGroup As String = Trim(GetCowGroup())
        Dim strOwner As String = Trim(GetOwnerName())
        Dim strCowNum As String = GetCowNo()
        Dim strcalfnum As String = GetNextCalfNum()
        Dim a As Integer
        NewCalf = New frmCalfNew(IntCowId, strCowNum, strcalfnum, strGroup, strOwner)
        'NewCalf.MdiParent = Me.MdiParent
        frmMain.WindowState = FormWindowState.Maximized
        NewCalf.ShowDialog()
        'new calf form sets prop to true or false
        If frmMain.CalfUpdated = True Then
            Me.txtcalfnum.Text = CType(Me.txtcalfnum.Text, Integer) + 1 'increments if calf added else it stay same
            Me.txtcalfnum.Focus() 'sets the value of calfnum
            Me.txtCowNote.Focus() 'part of setting value of calfnum
            'make new calfnum permenent
            Me.Validate()
            Me.CowBindingSource.EndEdit()
            a = CowTableAdapter.Update(DCow)

            frmMain.CalfUpdated = False

            Me.CalfTableAdapter.Fill(Me.DCow.calf)
            Me.CowTableAdapter.Fill(Me.DCow.Cow)
            CowBindingSource.Sort = "cow_number"
            a = CowBindingSource.Find("id", frmMain.RetCowNum)
            Me.BindingContext(CowBindingSource).Position = a
            frmMain.RetCowNum = Nothing

        End If

    End Sub
    Private Sub EditCow()
        Dim a As Integer
        Dim CowEdit As frmEditCow
        Dim intCowId As Integer = GetCowId()
        CowEdit = New frmEditCow(intCowId)
        frmMain.WindowState = FormWindowState.Maximized
        CowEdit.ShowDialog()

        Me.CowTableAdapter.Fill(Me.DCow.Cow)
        Me.CalfTableAdapter.Fill(Me.DCow.calf)

        CowBindingSource.Sort = "cow_number"
        a = CowBindingSource.Find("id", frmMain.RetCowNum)
        Me.BindingContext(CowBindingSource).Position = a
        frmMain.RetCowNum = Nothing
    End Sub
    Private Sub NewCow()
        Dim a As Integer
        Dim IntCowId As Integer = GetCowId()
        Dim NewCow As frmNewCow
        NewCow = New frmNewCow(IntCowId)
        frmMain.WindowState = FormWindowState.Maximized
        NewCow.ShowDialog()

        Me.CalfTableAdapter.Fill(Me.DCow.calf)
        Me.CowTableAdapter.Fill(Me.DCow.Cow)
        CowBindingSource.Sort = "cow_number"
        a = CowBindingSource.Find("cow_number", frmMain.RetCowNum)
        Me.BindingContext(CowBindingSource).Position = a
        frmMain.RetCowNum = Nothing

    End Sub
    Private Function GetCowId() As Integer
        Dim a As Integer
        a = Me.CowBindingSource.Current("id")
        Return a
    End Function
    Private Function GetCowGroup() As String
        Dim a As String
          a = Me.CowBindingSource.Current("calf_group")
        Return a
    End Function
    Private Function CalfNoGet() As String
        Dim a As Integer = Me.CowcalfBindingSource1.Current("id")
        Return a
    End Function
    Private Function GetCowNo() As String
        Return CStr(Me.CowBindingSource.Current("cow_number"))
    End Function
    Private Function GetNextCalfNum() As String


        Return Me.CowBindingSource.Current("calfnum")

    End Function
    Private Function GetOwnerName() As String

        Return Me.CowBindingSource.Current("owner_")

    End Function
    Public Sub FindCow(ByVal cownum As String)
        Dim a As Integer

        CowBindingSource.Sort = "cow_number"

        a = CowBindingSource.Find("cow_number", cownum)

        If a >= 0 Then
            CowBindingSource.Position = a
            ' txtFind.Text = ""
        Else
            MessageBox.Show("Record not found!", "Record", MessageBoxButtons.OK)
        End If
    End Sub
    Public Sub FindCowById(ByVal cowid As String)
        Dim a As Integer

        CowBindingSource.Sort = "id"
        'a = dvCow.Find(cownum)
        a = CowBindingSource.Find("id", cowid)

        If a >= 0 Then
            Me.BindingContext(CowBindingSource).Position = a
            ' txtFind.Text = ""
        Else
            MessageBox.Show("Record not found!", "Record", MessageBoxButtons.OK)
        End If
    End Sub

#End Region
#Region "navigation"

   
    
#End Region

Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncowactive.Click
Select Case Me.btncowactive.Text
Case "::"
Me.btncowactive.Text = "||"
Me.CowTableAdapter.FillByInactive(Me.DCow.Cow)
Case "||"
Me.btncowactive.Text = "::"
Me.CowTableAdapter.Fill(Me.DCow.Cow)
End Select
End Sub

   

   
	Private Sub BottomPanel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles BottomPanel.Paint

	End Sub
End Class
