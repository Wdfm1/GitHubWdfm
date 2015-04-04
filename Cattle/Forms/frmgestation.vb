Public Class frmgestation
   


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case Me.cmbanimal.Text
            Case "Cow"
                Dim ddod As Date
                Dim ddos As Date
                ddod = DateAdd(DateInterval.Day, 283, CDate(Me.DateTimePicker1.Text))
                Me.lblDod.Text = Format(ddod, "Short Date")
                ddos = DateAdd(DateInterval.Day, -283, CDate(Me.DateTimePicker2.Text))
                Me.lblDos.Text = Format(ddos, "Short Date")

            Case "Horse"
                Dim ddod As Date
                Dim ddos As Date
                ddod = DateAdd(DateInterval.Day, 340, CDate(Me.DateTimePicker1.Text))
                Me.lblDod.Text = Format(ddod, "Short Date")
                ddos = DateAdd(DateInterval.Day, -340, CDate(Me.DateTimePicker2.Text))
                Me.lblDos.Text = Format(ddos, "Short Date")

            Case "Cat"
                Dim ddod As Date
                Dim ddos As Date
                ddod = DateAdd(DateInterval.Day, 63, CDate(Me.DateTimePicker1.Text))
                Me.lblDod.Text = Format(ddod, "Short Date")
                ddos = DateAdd(DateInterval.Day, -63, CDate(Me.DateTimePicker2.Text))
                Me.lblDos.Text = Format(ddos, "Short Date")
            Case "Dog"
                Dim ddod As Date
                Dim ddos As Date
                ddod = DateAdd(DateInterval.Day, 63, CDate(Me.DateTimePicker1.Text))
                Me.lblDod.Text = Format(ddod, "Short Date")
                ddos = DateAdd(DateInterval.Day, -63, CDate(Me.DateTimePicker2.Text))
                Me.lblDos.Text = Format(ddos, "Short Date")
            Case "Hog"
                Dim ddod As Date
                Dim ddos As Date
                ddod = DateAdd(DateInterval.Day, 116, CDate(Me.DateTimePicker1.Text))
                Me.lblDod.Text = Format(ddod, "Short Date")
                ddos = DateAdd(DateInterval.Day, -116, CDate(Me.DateTimePicker2.Text))
                Me.lblDos.Text = Format(ddos, "Short Date")
        End Select

    End Sub
End Class
