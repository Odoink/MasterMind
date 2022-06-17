<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BlueBtn = New System.Windows.Forms.Button()
        Me.RedBtn = New System.Windows.Forms.Button()
        Me.YellowBtn = New System.Windows.Forms.Button()
        Me.OrangeBtn = New System.Windows.Forms.Button()
        Me.GreenBtn = New System.Windows.Forms.Button()
        Me.PurpleBtn = New System.Windows.Forms.Button()
        Me.pnlBox = New System.Windows.Forms.Panel()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.restartBtn = New System.Windows.Forms.Button()
        Me.GuessBtn = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'BlueBtn
        '
        Me.BlueBtn.Location = New System.Drawing.Point(725, 12)
        Me.BlueBtn.Name = "BlueBtn"
        Me.BlueBtn.Size = New System.Drawing.Size(60, 50)
        Me.BlueBtn.TabIndex = 4
        Me.BlueBtn.Text = "Blauw"
        Me.BlueBtn.UseVisualStyleBackColor = True
        '
        'RedBtn
        '
        Me.RedBtn.Location = New System.Drawing.Point(660, 12)
        Me.RedBtn.Name = "RedBtn"
        Me.RedBtn.Size = New System.Drawing.Size(60, 50)
        Me.RedBtn.TabIndex = 5
        Me.RedBtn.Text = "Rood"
        Me.RedBtn.UseVisualStyleBackColor = True
        '
        'YellowBtn
        '
        Me.YellowBtn.Location = New System.Drawing.Point(725, 68)
        Me.YellowBtn.Name = "YellowBtn"
        Me.YellowBtn.Size = New System.Drawing.Size(60, 50)
        Me.YellowBtn.TabIndex = 6
        Me.YellowBtn.Text = "Geel"
        Me.YellowBtn.UseVisualStyleBackColor = True
        '
        'OrangeBtn
        '
        Me.OrangeBtn.Location = New System.Drawing.Point(660, 68)
        Me.OrangeBtn.Name = "OrangeBtn"
        Me.OrangeBtn.Size = New System.Drawing.Size(60, 50)
        Me.OrangeBtn.TabIndex = 7
        Me.OrangeBtn.Text = "Oranje"
        Me.OrangeBtn.UseVisualStyleBackColor = True
        '
        'GreenBtn
        '
        Me.GreenBtn.Location = New System.Drawing.Point(725, 124)
        Me.GreenBtn.Name = "GreenBtn"
        Me.GreenBtn.Size = New System.Drawing.Size(60, 50)
        Me.GreenBtn.TabIndex = 8
        Me.GreenBtn.Text = "Groen"
        Me.GreenBtn.UseVisualStyleBackColor = True
        '
        'PurpleBtn
        '
        Me.PurpleBtn.Location = New System.Drawing.Point(660, 124)
        Me.PurpleBtn.Name = "PurpleBtn"
        Me.PurpleBtn.Size = New System.Drawing.Size(60, 50)
        Me.PurpleBtn.TabIndex = 9
        Me.PurpleBtn.Text = "Paars"
        Me.PurpleBtn.UseVisualStyleBackColor = True
        '
        'pnlBox
        '
        Me.pnlBox.Location = New System.Drawing.Point(12, 51)
        Me.pnlBox.Name = "pnlBox"
        Me.pnlBox.Size = New System.Drawing.Size(642, 717)
        Me.pnlBox.TabIndex = 10
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(660, 179)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(126, 22)
        Me.deleteBtn.TabIndex = 13
        Me.deleteBtn.Text = "Verwijder kleuren"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'restartBtn
        '
        Me.restartBtn.Location = New System.Drawing.Point(659, 348)
        Me.restartBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.restartBtn.Name = "restartBtn"
        Me.restartBtn.Size = New System.Drawing.Size(126, 22)
        Me.restartBtn.TabIndex = 14
        Me.restartBtn.Text = "Opnieuw spelen"
        Me.restartBtn.UseVisualStyleBackColor = True
        Me.restartBtn.Visible = False
        '
        'GuessBtn
        '
        Me.GuessBtn.Location = New System.Drawing.Point(660, 206)
        Me.GuessBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GuessBtn.Name = "GuessBtn"
        Me.GuessBtn.Size = New System.Drawing.Size(126, 22)
        Me.GuessBtn.TabIndex = 15
        Me.GuessBtn.Text = "Raden"
        Me.GuessBtn.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(660, 299)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 44)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Dezelfde kleuren gebruiken (max 2)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 791)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GuessBtn)
        Me.Controls.Add(Me.restartBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.pnlBox)
        Me.Controls.Add(Me.PurpleBtn)
        Me.Controls.Add(Me.GreenBtn)
        Me.Controls.Add(Me.OrangeBtn)
        Me.Controls.Add(Me.YellowBtn)
        Me.Controls.Add(Me.RedBtn)
        Me.Controls.Add(Me.BlueBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlueBtn As Button
    Friend WithEvents RedBtn As Button
    Friend WithEvents YellowBtn As Button
    Friend WithEvents OrangeBtn As Button
    Friend WithEvents GreenBtn As Button
    Friend WithEvents PurpleBtn As Button
    Friend WithEvents pnlBox As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents deleteBtn As Button
    Friend WithEvents restartBtn As Button
    Friend WithEvents GuessBtn As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
