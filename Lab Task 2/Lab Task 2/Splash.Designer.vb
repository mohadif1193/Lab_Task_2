<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.timerload = New System.Windows.Forms.Timer(Me.components)
        Me.pbloading = New System.Windows.Forms.ProgressBar()
        Me.lblpro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timerload
        '
        Me.timerload.Enabled = True
        Me.timerload.Interval = 50
        '
        'pbloading
        '
        Me.pbloading.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbloading.Location = New System.Drawing.Point(12, 403)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(776, 22)
        Me.pbloading.TabIndex = 0
        '
        'lblpro
        '
        Me.lblpro.AutoSize = True
        Me.lblpro.BackColor = System.Drawing.Color.Transparent
        Me.lblpro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpro.Location = New System.Drawing.Point(12, 375)
        Me.lblpro.Name = "lblpro"
        Me.lblpro.Size = New System.Drawing.Size(93, 25)
        Me.lblpro.TabIndex = 1
        Me.lblpro.Text = "Initiating..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(90, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 81)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Stanley's custom 💕"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(246, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Best of the best"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab_Task_2.My.Resources.Resources.car_bg
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblpro)
        Me.Controls.Add(Me.pbloading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timerload As Timer
    Friend WithEvents pbloading As ProgressBar
    Friend WithEvents lblpro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
