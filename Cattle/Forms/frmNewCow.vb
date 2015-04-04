Public Class frmNewCow
    Public Sub New(ByVal cowid1 As Integer)
        MyBase.New()
        Me.cowsid = cowid1
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    
    Dim tval As Integer
    Dim tvaldirt As Boolean
    Public Property Cowsid() As Integer
        Get
            Return tval
        End Get
        Set(ByVal Value As Integer)
            tval = Value
        End Set
    End Property

    Public Property Dirty() As Boolean
        Get
            Return tvaldirt
        End Get
        Set(ByVal Value As Boolean)
            tvaldirt = Value
        End Set
    End Property
    Private Sub frmNewCow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'for dialog form only fire disposed event so form handler works
        Me.Dispose(True)
    End Sub
    Private Sub frmNewCow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DCow.Cow' table. You can move, or remove it, as needed.
        Me.CowTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
        Me.CowTableAdapter.Fill(Me.DCow.Cow)

        Me.CowTableAdapter.Fill(Me.DCow.Cow)
        Me.NewRec()
    End Sub

   

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cancel()
    End Sub
#Region "Custom Funtions"
    Private Sub NewRec()
        Dim newrow As DataRowView
        newrow = CowBindingSource1.AddNew
        Me.CowBindingSource1.Position = Me.CowBindingSource1.Count
        'Me.txtinsertuser.Text = frmMain.CurUser
        Me.CowBindingSource1.Current("insertuser") = frmMain.CurUser
    End Sub
    Public Overrides Sub Save()
        Me.ValidateChildren()
        If Me.Dirty = False Then
            Me.Validate()

            Me.CowBindingSource1.EndEdit()

            frmMain.RetCowNum = Me.txtCowNum.Text

            Me.CowTableAdapter.Update(Me.DCow)
            Me.Close()
        End If
    End Sub
    Private Sub Cancel()
        Me.Close()
    End Sub
    
#End Region

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.Save()

    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Cancel()

    End Sub


    Private Sub txtCowNum_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCowNum.Validating

        If String.IsNullOrEmpty(Me.txtCowNum.Text) Then
            ErrorProvider1.SetError(Me.txtCowNum, "You must enter a cow number.")
            Me.Dirty = True
            e.Cancel = True
        Else
            ErrorProvider1.SetError(Me.txtCowNum, "")
        End If
    End Sub



    Private Sub cmbOwner_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbOwner.Validating
        If String.IsNullOrEmpty(Me.cmbOwner.Text) Then
            ErrorProvider1.SetError(Me.cmbOwner, "You must choose a owner.")
            Me.Dirty = True
            e.Cancel = True
        Else
            ErrorProvider1.SetError(Me.cmbOwner, "")
        End If
    End Sub

    Private Sub cmbGroup_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbGroup.Validating
        If String.IsNullOrEmpty(Me.cmbGroup.Text) Then
            ErrorProvider1.SetError(Me.cmbGroup, "You must choose a group.")
            Me.Dirty = True
            e.Cancel = True
        Else
            ErrorProvider1.SetError(Me.cmbGroup, "")
        End If
    End Sub

    Private Sub DateTimePicker1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker1.Validating
        If String.IsNullOrEmpty(Me.DateTimePicker1.Value) Then
            ErrorProvider1.SetError(Me.DateTimePicker1, "You must enter a date.")
            Me.Dirty = True
            e.Cancel = True
        Else
            ErrorProvider1.SetError(Me.DateTimePicker1, "")
        End If
    End Sub

   
End Class
