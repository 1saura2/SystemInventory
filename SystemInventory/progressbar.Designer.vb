<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progressbar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.percentageLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Guna2TaskBarProgress2 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Guna2TaskBarProgress3 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Guna2TaskBarProgress4 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.MyProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.MyProgressBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(102, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory System"
        '
        'percentageLbl
        '
        Me.percentageLbl.AutoSize = True
        Me.percentageLbl.BackColor = System.Drawing.Color.Transparent
        Me.percentageLbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.percentageLbl.ForeColor = System.Drawing.Color.White
        Me.percentageLbl.Location = New System.Drawing.Point(51, 53)
        Me.percentageLbl.Name = "percentageLbl"
        Me.percentageLbl.Size = New System.Drawing.Size(28, 25)
        Me.percentageLbl.TabIndex = 2
        Me.percentageLbl.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(128, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "server Monks"
        '
        'Timer1
        '
        '
        'Guna2TaskBarProgress1
        '
        Me.Guna2TaskBarProgress1.TargetForm = Nothing
        '
        'Guna2TaskBarProgress2
        '
        Me.Guna2TaskBarProgress2.TargetForm = Nothing
        '
        'Guna2TaskBarProgress3
        '
        Me.Guna2TaskBarProgress3.TargetForm = Nothing
        '
        'Guna2TaskBarProgress4
        '
        Me.Guna2TaskBarProgress4.TargetForm = Nothing
        '
        'MyProgressBar
        '
        Me.MyProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.MyProgressBar.Controls.Add(Me.percentageLbl)
        Me.MyProgressBar.FillColor = System.Drawing.Color.Transparent
        Me.MyProgressBar.FillThickness = 14
        Me.MyProgressBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MyProgressBar.ForeColor = System.Drawing.Color.DarkViolet
        Me.MyProgressBar.Location = New System.Drawing.Point(102, 49)
        Me.MyProgressBar.Minimum = 0
        Me.MyProgressBar.Name = "MyProgressBar"
        Me.MyProgressBar.ProgressColor = System.Drawing.Color.White
        Me.MyProgressBar.ProgressColor2 = System.Drawing.Color.White
        Me.MyProgressBar.ProgressThickness = 8
        Me.MyProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.MyProgressBar.Size = New System.Drawing.Size(130, 130)
        Me.MyProgressBar.TabIndex = 5
        Me.MyProgressBar.Text = "Guna2CircleProgressBar1"
        '
        'progressbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(331, 234)
        Me.Controls.Add(Me.MyProgressBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "progressbar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "progressbar"
        Me.MyProgressBar.ResumeLayout(False)
        Me.MyProgressBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents percentageLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2TaskBarProgress2 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2TaskBarProgress3 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2TaskBarProgress4 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents MyProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
