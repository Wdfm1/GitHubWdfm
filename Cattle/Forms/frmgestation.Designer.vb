<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgestation
    Inherits Cattle.FarmForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbanimal = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDos = New System.Windows.Forms.Label
        Me.lblDod = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.CaptionPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CaptionPanel
        '
        Me.CaptionPanel.Controls.Add(Me.Label6)
        Me.CaptionPanel.Controls.Add(Me.cmbanimal)
        Me.CaptionPanel.Controls.Add(Me.Label1)
        Me.CaptionPanel.Size = New System.Drawing.Size(489, 87)
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.Panel1)
        Me.BottomPanel.Location = New System.Drawing.Point(0, 204)
        Me.BottomPanel.Size = New System.Drawing.Size(489, 91)
        '
        'LeftPanel
        '
        Me.LeftPanel.Controls.Add(Me.DateTimePicker2)
        Me.LeftPanel.Controls.Add(Me.DateTimePicker1)
        Me.LeftPanel.Controls.Add(Me.Label3)
        Me.LeftPanel.Controls.Add(Me.Label2)
        Me.LeftPanel.Location = New System.Drawing.Point(0, 87)
        Me.LeftPanel.Size = New System.Drawing.Size(236, 117)
        '
        'RightPanel
        '
        Me.RightPanel.Controls.Add(Me.lblDos)
        Me.RightPanel.Controls.Add(Me.lblDod)
        Me.RightPanel.Controls.Add(Me.Label5)
        Me.RightPanel.Controls.Add(Me.Label4)
        Me.RightPanel.Location = New System.Drawing.Point(236, 87)
        Me.RightPanel.Size = New System.Drawing.Size(253, 117)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 35)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Gestation"
        '
        'cmbanimal
        '
        Me.cmbanimal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbanimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbanimal.FormattingEnabled = True
        Me.cmbanimal.Items.AddRange(New Object() {"Cow", "Horse", "Cat", "Dog", "Hog"})
        Me.cmbanimal.Location = New System.Drawing.Point(240, 57)
        Me.cmbanimal.Name = "cmbanimal"
        Me.cmbanimal.Size = New System.Drawing.Size(92, 21)
        Me.cmbanimal.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Animal"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(109, 68)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker2.TabIndex = 35
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Date of Delivery"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Date of Service"
        '
        'lblDos
        '
        Me.lblDos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDos.BackColor = System.Drawing.SystemColors.Window
        Me.lblDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDos.Location = New System.Drawing.Point(152, 68)
        Me.lblDos.Name = "lblDos"
        Me.lblDos.Size = New System.Drawing.Size(65, 20)
        Me.lblDos.TabIndex = 38
        '
        'lblDod
        '
        Me.lblDod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDod.BackColor = System.Drawing.SystemColors.Window
        Me.lblDod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDod.Location = New System.Drawing.Point(152, 28)
        Me.lblDod.Name = "lblDod"
        Me.lblDod.Size = New System.Drawing.Size(65, 20)
        Me.lblDod.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Date of Service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Date of Delivery"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(192, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 49)
        Me.Panel1.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(20, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmgestation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(489, 295)
        Me.Name = "frmgestation"
        Me.Text = "Gestation Table"
        Me.CaptionPanel.ResumeLayout(False)
        Me.CaptionPanel.PerformLayout()
        Me.BottomPanel.ResumeLayout(False)
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        Me.RightPanel.ResumeLayout(False)
        Me.RightPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbanimal As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDos As System.Windows.Forms.Label
    Friend WithEvents lblDod As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
