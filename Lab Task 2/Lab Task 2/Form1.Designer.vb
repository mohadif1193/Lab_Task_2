<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.lbUN = New System.Windows.Forms.Label()
        Me.lbPW = New System.Windows.Forms.Label()
        Me.tbUN = New System.Windows.Forms.TextBox()
        Me.tbPW = New System.Windows.Forms.TextBox()
        Me.btLI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbUN
        '
        Me.lbUN.AutoSize = True
        Me.lbUN.BackColor = System.Drawing.Color.Transparent
        Me.lbUN.Font = New System.Drawing.Font("Segoe UI Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbUN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbUN.Location = New System.Drawing.Point(52, 107)
        Me.lbUN.Name = "lbUN"
        Me.lbUN.Size = New System.Drawing.Size(134, 30)
        Me.lbUN.TabIndex = 0
        Me.lbUN.Text = "Username :"
        '
        'lbPW
        '
        Me.lbPW.AutoSize = True
        Me.lbPW.BackColor = System.Drawing.Color.Transparent
        Me.lbPW.Font = New System.Drawing.Font("Segoe UI Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPW.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbPW.Location = New System.Drawing.Point(55, 153)
        Me.lbPW.Name = "lbPW"
        Me.lbPW.Size = New System.Drawing.Size(131, 30)
        Me.lbPW.TabIndex = 1
        Me.lbPW.Text = "Password :"
        '
        'tbUN
        '
        Me.tbUN.Location = New System.Drawing.Point(218, 108)
        Me.tbUN.Name = "tbUN"
        Me.tbUN.Size = New System.Drawing.Size(286, 31)
        Me.tbUN.TabIndex = 2
        '
        'tbPW
        '
        Me.tbPW.Location = New System.Drawing.Point(218, 154)
        Me.tbPW.Name = "tbPW"
        Me.tbPW.Size = New System.Drawing.Size(286, 31)
        Me.tbPW.TabIndex = 3
        '
        'btLI
        '
        Me.btLI.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btLI.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btLI.Location = New System.Drawing.Point(280, 202)
        Me.btLI.Name = "btLI"
        Me.btLI.Size = New System.Drawing.Size(157, 42)
        Me.btLI.TabIndex = 4
        Me.btLI.Text = "Log In"
        Me.btLI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to Stanley's custom 💕"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(561, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btLI)
        Me.Controls.Add(Me.tbPW)
        Me.Controls.Add(Me.tbUN)
        Me.Controls.Add(Me.lbPW)
        Me.Controls.Add(Me.lbUN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUN As Label
    Friend WithEvents lbPW As Label
    Friend WithEvents tbUN As TextBox
    Friend WithEvents tbPW As TextBox
    Friend WithEvents btLI As Button
    Friend WithEvents Label1 As Label
End Class
