Public Class frmsort
    Private Sub frmsort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CowTableAdapter.Connection.ConnectionString = frmMain.AppConnectionString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.lstNotFound.SelectedIndex <> -1 Then
            Me.Move1itemFound()
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Get spring cows
        Me.CowTableAdapter.FillBySpring(Me.DCow.Cow)
        Me.LoadListBox()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.MoveAllItemsFound()

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Get all cow records
        Me.CowTableAdapter.Fill(Me.DCow.Cow)
        Me.LoadListBox()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.lstFound.SelectedIndex <> -1 Then
            Me.Move1ItemNotFound()
        End If

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.MoveAllItemsNotFound()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.CowTableAdapter.FillByFall(Me.DCow.Cow)
        Me.LoadListBox()
    End Sub
#Region "Custom Funcions"
    Private Sub LoadListBox()
        Me.lstNotFound.Items.Clear()
        Me.lstFound.Items.Clear()
        Me.Label2.Text = "0 Cow Records"
        Dim numofrows As Integer = Me.CowBindingSource.Count
        Dim Thevalue As String

        Dim i As Integer
        Me.CowBindingSource.Position = 0
        For i = 1 To numofrows
            Thevalue = Trim(Me.CowBindingSource.Current("cow_number")) & "        " & Trim(Me.CowBindingSource.Current("calf_group"))
            Me.lstNotFound.Items.Add(Thevalue)
            Me.BindingContext(CowBindingSource).Position += 1
        Next
        Me.Label5.Text = "Total Records:" & Me.lstNotFound.Items.Count.ToString
        Me.Label1.Text = Me.lstNotFound.Items.Count.ToString & " Cow Records"
    End Sub
    Private Sub Move1itemFound()
        Dim selrec As Integer = Me.lstNotFound.SelectedIndex()
        Me.lstFound.Items.Add(Me.lstNotFound.Items.Item(Me.lstNotFound.SelectedIndex))
        Me.lstNotFound.Items.Remove(Me.lstNotFound.SelectedItem)

        Me.Label1.Text = Me.lstNotFound.Items.Count.ToString & " Cow Records"
        Me.Label2.Text = Me.lstFound.Items.Count.ToString & " Cow Records"
        Try
            If Me.lstNotFound.Items.Count <> 0 And selrec < Me.lstNotFound.Items.Count Then
                Me.lstNotFound.SelectedIndex = selrec
            Else
                Me.lstNotFound.SelectedIndex = selrec - 1
            End If
        Catch ex As Exception
            'list empty do nothing
        End Try
    End Sub
    Private Sub MoveAllItemsFound()
        Dim numitems As Integer = Me.lstNotFound.Items.Count - 1
        Dim i As Integer
        For i = 0 To numitems
            Me.lstFound.Items.Add(Me.lstNotFound.Items.Item(i))
        Next
        Me.lstNotFound.Items.Clear()
        Me.Label1.Text = Me.lstNotFound.Items.Count.ToString & " Cow Records"
        Me.Label2.Text = Me.lstFound.Items.Count.ToString & " Cow Records"



    End Sub
    Private Sub MoveAllItemsNotFound()
        Dim numitems As Integer = Me.lstFound.Items.Count - 1
        Dim i As Integer
        For i = 0 To numitems
            Me.lstNotFound.Items.Add(Me.lstFound.Items.Item(i))
        Next
        Me.lstFound.Items.Clear()
        Me.Label1.Text = Me.lstNotFound.Items.Count.ToString & " Cow Records"
        Me.Label2.Text = Me.lstFound.Items.Count.ToString & " Cow Records"
    End Sub
    Private Sub Move1ItemNotFound()
        Dim selrec As Integer = Me.lstFound.SelectedIndex()
        Me.lstNotFound.Items.Add(Me.lstFound.Items.Item(Me.lstFound.SelectedIndex))
        Me.lstFound.Items.Remove(Me.lstFound.SelectedItem)

        Me.Label1.Text = Me.lstNotFound.Items.Count.ToString & " Cow Records"
        Me.Label2.Text = Me.lstFound.Items.Count.ToString & " Cow Records"
        Try
            If Me.lstFound.Items.Count <> 0 And selrec < Me.lstFound.Items.Count Then
                Me.lstFound.SelectedIndex = selrec
            Else
                Me.lstFound.SelectedIndex = selrec - 1
            End If
        Catch ex As Exception
            'list empty do nothing
        End Try
    End Sub
#End Region


End Class
