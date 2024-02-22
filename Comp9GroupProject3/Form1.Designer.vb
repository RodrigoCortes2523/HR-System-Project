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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EZTimeCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhoneDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.messageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1074, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeScreenToolStripMenuItem, Me.EZTimeCardToolStripMenuItem, Me.PhoneDirectoryToolStripMenuItem, Me.TimeCardToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EmployeeScreenToolStripMenuItem
        '
        Me.EmployeeScreenToolStripMenuItem.Name = "EmployeeScreenToolStripMenuItem"
        Me.EmployeeScreenToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.EmployeeScreenToolStripMenuItem.Text = "Employee Screen"
        '
        'EZTimeCardToolStripMenuItem
        '
        Me.EZTimeCardToolStripMenuItem.Name = "EZTimeCardToolStripMenuItem"
        Me.EZTimeCardToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.EZTimeCardToolStripMenuItem.Text = "EZ Time Card"
        '
        'PhoneDirectoryToolStripMenuItem
        '
        Me.PhoneDirectoryToolStripMenuItem.Name = "PhoneDirectoryToolStripMenuItem"
        Me.PhoneDirectoryToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.PhoneDirectoryToolStripMenuItem.Text = "Phone Directory"
        '
        'TimeCardToolStripMenuItem
        '
        Me.TimeCardToolStripMenuItem.Name = "TimeCardToolStripMenuItem"
        Me.TimeCardToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.TimeCardToolStripMenuItem.Text = "Time Card (Beta)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(913, 635)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version: 0.0.1a"
        '
        'messageLabel
        '
        Me.messageLabel.BackColor = System.Drawing.Color.Transparent
        Me.messageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageLabel.Location = New System.Drawing.Point(301, 563)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(385, 58)
        Me.messageLabel.TabIndex = 1
        Me.messageLabel.Text = "Remember to keep all employee data updated. The system relies on accurate informa" &
    "tion to function optimally."
        '
        'messageTimer
        '
        Me.messageTimer.Interval = 5000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Comp9GroupProject3.My.Resources.Resources.database
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(859, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 119)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Comp9GroupProject3.My.Resources.Resources.mag
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(859, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 119)
        Me.Button2.TabIndex = 2
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Comp9GroupProject3.My.Resources.Resources.timeCard
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(859, 282)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 119)
        Me.Button3.TabIndex = 2
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Comp9GroupProject3.My.Resources.Resources.ApplicationBackground1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 684)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HRS - Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhoneDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EZTimeCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents messageLabel As Label
    Friend WithEvents messageTimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
