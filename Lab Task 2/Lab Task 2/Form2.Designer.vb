<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.lbCM = New System.Windows.Forms.Label()
        Me.tbCM = New System.Windows.Forms.TextBox()
        Me.lbCP = New System.Windows.Forms.Label()
        Me.cbCP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.checkboxCheck = New System.Windows.Forms.CheckBox()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.checkboxClean = New System.Windows.Forms.CheckBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.gbYN = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbYN.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCM
        '
        Me.lbCM.AutoSize = True
        Me.lbCM.BackColor = System.Drawing.Color.LightGray
        Me.lbCM.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbCM.ForeColor = System.Drawing.Color.Blue
        Me.lbCM.Location = New System.Drawing.Point(29, 19)
        Me.lbCM.Name = "lbCM"
        Me.lbCM.Size = New System.Drawing.Size(113, 25)
        Me.lbCM.TabIndex = 0
        Me.lbCM.Text = "Car model :"
        '
        'tbCM
        '
        Me.tbCM.Location = New System.Drawing.Point(212, 92)
        Me.tbCM.Name = "tbCM"
        Me.tbCM.Size = New System.Drawing.Size(223, 31)
        Me.tbCM.TabIndex = 1
        '
        'lbCP
        '
        Me.lbCP.AutoSize = True
        Me.lbCP.BackColor = System.Drawing.Color.LightGray
        Me.lbCP.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbCP.ForeColor = System.Drawing.Color.Blue
        Me.lbCP.Location = New System.Drawing.Point(38, 57)
        Me.lbCP.Name = "lbCP"
        Me.lbCP.Size = New System.Drawing.Size(104, 25)
        Me.lbCP.TabIndex = 2
        Me.lbCP.Text = "Car parts :"
        '
        'cbCP
        '
        Me.cbCP.FormattingEnabled = True
        Me.cbCP.Items.AddRange(New Object() {"Steering", "Gear Lever", "Gas Pedal", "Engine", "Tire", "Spark Plug", "Suspension", "Disk Brake", "Oil Filter", "Battery", "Clutch", "Wiper", "Side Mirror", "Rearview Mirror", "Sun VIsor", "Grill", "Gearshift", "Exhaust Pipe", "Bumper", "Car Hood", "Tail Light ", "Boonet", "Horn", "Fender", "Windshield"})
        Me.cbCP.Location = New System.Drawing.Point(212, 130)
        Me.cbCP.Name = "cbCP"
        Me.cbCP.Size = New System.Drawing.Size(223, 33)
        Me.cbCP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(85, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 64)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "We have various customizations " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for your car 😏"
        '
        'btSubmit
        '
        Me.btSubmit.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btSubmit.Location = New System.Drawing.Point(297, 214)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(112, 34)
        Me.btSubmit.TabIndex = 15
        Me.btSubmit.Text = "Submit"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'checkboxCheck
        '
        Me.checkboxCheck.AutoSize = True
        Me.checkboxCheck.BackColor = System.Drawing.Color.LightGray
        Me.checkboxCheck.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.checkboxCheck.Location = New System.Drawing.Point(212, 169)
        Me.checkboxCheck.Name = "checkboxCheck"
        Me.checkboxCheck.Size = New System.Drawing.Size(120, 29)
        Me.checkboxCheck.TabIndex = 16
        Me.checkboxCheck.Text = "Check-up"
        Me.checkboxCheck.UseVisualStyleBackColor = False
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbYes.Location = New System.Drawing.Point(18, 5)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(68, 29)
        Me.rbYes.TabIndex = 17
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Xtra Service :"
        '
        'checkboxClean
        '
        Me.checkboxClean.AutoSize = True
        Me.checkboxClean.BackColor = System.Drawing.Color.LightGray
        Me.checkboxClean.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.checkboxClean.Location = New System.Drawing.Point(212, 204)
        Me.checkboxClean.Name = "checkboxClean"
        Me.checkboxClean.Size = New System.Drawing.Size(184, 29)
        Me.checkboxClean.TabIndex = 19
        Me.checkboxClean.Text = "Cleaning Service"
        Me.checkboxClean.UseVisualStyleBackColor = False
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbNo.Location = New System.Drawing.Point(98, 5)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(63, 29)
        Me.rbNo.TabIndex = 21
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'gbYN
        '
        Me.gbYN.BackColor = System.Drawing.Color.LightGray
        Me.gbYN.Controls.Add(Me.rbYes)
        Me.gbYN.Controls.Add(Me.rbNo)
        Me.gbYN.Location = New System.Drawing.Point(212, 239)
        Me.gbYN.Name = "gbYN"
        Me.gbYN.Size = New System.Drawing.Size(176, 38)
        Me.gbYN.TabIndex = 22
        Me.gbYN.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(17, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Installation :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btSubmit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbCP)
        Me.Panel1.Controls.Add(Me.lbCM)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(64, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 263)
        Me.Panel1.TabIndex = 24
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.Lab_Task_2.My.Resources.Resources.shutterstock_1038654664_removebg_preview
        Me.ClientSize = New System.Drawing.Size(554, 336)
        Me.Controls.Add(Me.gbYN)
        Me.Controls.Add(Me.checkboxClean)
        Me.Controls.Add(Me.checkboxCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCP)
        Me.Controls.Add(Me.tbCM)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        Me.gbYN.ResumeLayout(False)
        Me.gbYN.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCM As Label
    Friend WithEvents tbCM As TextBox
    Friend WithEvents lbCP As Label
    Friend WithEvents cbCP As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btSubmit As Button
    Friend WithEvents checkboxCheck As CheckBox
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents checkboxClean As CheckBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents gbYN As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
