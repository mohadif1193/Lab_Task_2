<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbClean = New System.Windows.Forms.Label()
        Me.lbYN = New System.Windows.Forms.Label()
        Me.lbIns = New System.Windows.Forms.Label()
        Me.lbCheck = New System.Windows.Forms.Label()
        Me.lbES = New System.Windows.Forms.Label()
        Me.lbParts = New System.Windows.Forms.Label()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbCP = New System.Windows.Forms.Label()
        Me.lbCM = New System.Windows.Forms.Label()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetails
        '
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.Label1)
        Me.pnlDetails.Controls.Add(Me.lbClean)
        Me.pnlDetails.Controls.Add(Me.lbYN)
        Me.pnlDetails.Controls.Add(Me.lbIns)
        Me.pnlDetails.Controls.Add(Me.lbCheck)
        Me.pnlDetails.Controls.Add(Me.lbES)
        Me.pnlDetails.Controls.Add(Me.lbParts)
        Me.pnlDetails.Controls.Add(Me.lbModel)
        Me.pnlDetails.Controls.Add(Me.lbCP)
        Me.pnlDetails.Controls.Add(Me.lbCM)
        Me.pnlDetails.Location = New System.Drawing.Point(12, 12)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(430, 186)
        Me.pnlDetails.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(264, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = ","
        '
        'lbClean
        '
        Me.lbClean.AutoSize = True
        Me.lbClean.BackColor = System.Drawing.Color.LightGray
        Me.lbClean.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbClean.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbClean.Location = New System.Drawing.Point(288, 93)
        Me.lbClean.Name = "lbClean"
        Me.lbClean.Size = New System.Drawing.Size(17, 25)
        Me.lbClean.TabIndex = 26
        Me.lbClean.Text = " "
        '
        'lbYN
        '
        Me.lbYN.AutoSize = True
        Me.lbYN.BackColor = System.Drawing.Color.LightGray
        Me.lbYN.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbYN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbYN.Location = New System.Drawing.Point(151, 132)
        Me.lbYN.Name = "lbYN"
        Me.lbYN.Size = New System.Drawing.Size(17, 25)
        Me.lbYN.TabIndex = 26
        Me.lbYN.Text = " "
        '
        'lbIns
        '
        Me.lbIns.AutoSize = True
        Me.lbIns.BackColor = System.Drawing.Color.LightGray
        Me.lbIns.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbIns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIns.Location = New System.Drawing.Point(9, 132)
        Me.lbIns.Name = "lbIns"
        Me.lbIns.Size = New System.Drawing.Size(125, 25)
        Me.lbIns.TabIndex = 22
        Me.lbIns.Text = "Installation :"
        '
        'lbCheck
        '
        Me.lbCheck.AutoSize = True
        Me.lbCheck.BackColor = System.Drawing.Color.LightGray
        Me.lbCheck.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCheck.Location = New System.Drawing.Point(151, 93)
        Me.lbCheck.Name = "lbCheck"
        Me.lbCheck.Size = New System.Drawing.Size(17, 25)
        Me.lbCheck.TabIndex = 25
        Me.lbCheck.Text = " "
        '
        'lbES
        '
        Me.lbES.AutoSize = True
        Me.lbES.BackColor = System.Drawing.Color.LightGray
        Me.lbES.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbES.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbES.Location = New System.Drawing.Point(3, 93)
        Me.lbES.Name = "lbES"
        Me.lbES.Size = New System.Drawing.Size(131, 25)
        Me.lbES.TabIndex = 21
        Me.lbES.Text = "Xtra Service :"
        '
        'lbParts
        '
        Me.lbParts.AutoSize = True
        Me.lbParts.BackColor = System.Drawing.Color.LightGray
        Me.lbParts.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbParts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbParts.Location = New System.Drawing.Point(151, 56)
        Me.lbParts.Name = "lbParts"
        Me.lbParts.Size = New System.Drawing.Size(17, 25)
        Me.lbParts.TabIndex = 24
        Me.lbParts.Text = " "
        '
        'lbModel
        '
        Me.lbModel.AutoSize = True
        Me.lbModel.BackColor = System.Drawing.Color.LightGray
        Me.lbModel.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbModel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbModel.Location = New System.Drawing.Point(151, 17)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(17, 25)
        Me.lbModel.TabIndex = 23
        Me.lbModel.Text = " "
        '
        'lbCP
        '
        Me.lbCP.AutoSize = True
        Me.lbCP.BackColor = System.Drawing.Color.LightGray
        Me.lbCP.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbCP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCP.Location = New System.Drawing.Point(30, 56)
        Me.lbCP.Name = "lbCP"
        Me.lbCP.Size = New System.Drawing.Size(104, 25)
        Me.lbCP.TabIndex = 20
        Me.lbCP.Text = "Car Parts :"
        '
        'lbCM
        '
        Me.lbCM.AutoSize = True
        Me.lbCM.BackColor = System.Drawing.Color.LightGray
        Me.lbCM.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbCM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCM.Location = New System.Drawing.Point(20, 17)
        Me.lbCM.Name = "lbCM"
        Me.lbCM.Size = New System.Drawing.Size(114, 25)
        Me.lbCM.TabIndex = 19
        Me.lbCM.Text = "Car Model :"
        '
        'btSubmit
        '
        Me.btSubmit.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btSubmit.Location = New System.Drawing.Point(470, 12)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(112, 34)
        Me.btSubmit.TabIndex = 16
        Me.btSubmit.Text = "Confirm"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(470, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.Lab_Task_2.My.Resources.Resources.TEASER05
        Me.ClientSize = New System.Drawing.Size(607, 208)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btSubmit)
        Me.Controls.Add(Me.pnlDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lbES As Label
    Friend WithEvents lbCP As Label
    Friend WithEvents lbCM As Label
    Friend WithEvents lbIns As Label
    Friend WithEvents lbClean As Label
    Friend WithEvents lbYN As Label
    Friend WithEvents lbCheck As Label
    Friend WithEvents lbParts As Label
    Friend WithEvents lbModel As Label
    Friend WithEvents btSubmit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
