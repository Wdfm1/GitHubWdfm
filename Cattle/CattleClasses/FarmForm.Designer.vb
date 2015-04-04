<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarmForm
    Inherits Cattle.BaseForm

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
        Me.SuspendLayout()
        '
        'CaptionPanel
        '
        Me.CaptionPanel.Size = New System.Drawing.Size(497, 57)
        '
        'BottomPanel
        '
        Me.BottomPanel.Location = New System.Drawing.Point(0, 246)
        Me.BottomPanel.Size = New System.Drawing.Size(497, 86)
        '
        'LeftPanel
        '
        Me.LeftPanel.Location = New System.Drawing.Point(0, 57)
        Me.LeftPanel.Size = New System.Drawing.Size(236, 189)
        '
        'RightPanel
        '
        Me.RightPanel.Location = New System.Drawing.Point(236, 57)
        Me.RightPanel.Size = New System.Drawing.Size(261, 189)
        '
        'FarmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(497, 332)
        Me.CurrentInstance = "0"
        Me.Name = "FarmForm"
        Me.Text = "No Calves"
        Me.ResumeLayout(False)

    End Sub

End Class
