<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeScreen
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhoneDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.positionBox = New System.Windows.Forms.TextBox()
        Me.infoBox = New System.Windows.Forms.TextBox()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.addNewButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fNameBox = New System.Windows.Forms.TextBox()
        Me.lNameBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.deptBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.supervisorComboBox = New System.Windows.Forms.ComboBox()
        Me.editButton = New System.Windows.Forms.Button()
        Me.statusComboBox = New System.Windows.Forms.ComboBox()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeCardToolStripMenuItem, Me.PhoneDirectoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TimeCardToolStripMenuItem
        '
        Me.TimeCardToolStripMenuItem.Name = "TimeCardToolStripMenuItem"
        Me.TimeCardToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.TimeCardToolStripMenuItem.Text = "EZ Time Card"
        '
        'PhoneDirectoryToolStripMenuItem
        '
        Me.PhoneDirectoryToolStripMenuItem.Name = "PhoneDirectoryToolStripMenuItem"
        Me.PhoneDirectoryToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.PhoneDirectoryToolStripMenuItem.Text = "Phone Directory"
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(271, 60)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(94, 26)
        Me.searchBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 59)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employment Status"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 59)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employment Start Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 59)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee ID"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 59)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Postition"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 59)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Contact Info"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(382, 436)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 59)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Supervisor"
        '
        'positionBox
        '
        Me.positionBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionBox.Location = New System.Drawing.Point(188, 320)
        Me.positionBox.Name = "positionBox"
        Me.positionBox.Size = New System.Drawing.Size(142, 26)
        Me.positionBox.TabIndex = 5
        '
        'infoBox
        '
        Me.infoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoBox.Location = New System.Drawing.Point(178, 436)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(142, 26)
        Me.infoBox.TabIndex = 7
        '
        'deleteButton
        '
        Me.deleteButton.Enabled = False
        Me.deleteButton.Location = New System.Drawing.Point(128, 498)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(139, 53)
        Me.deleteButton.TabIndex = 9
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'addNewButton
        '
        Me.addNewButton.Location = New System.Drawing.Point(282, 498)
        Me.addNewButton.Name = "addNewButton"
        Me.addNewButton.Size = New System.Drawing.Size(139, 53)
        Me.addNewButton.TabIndex = 10
        Me.addNewButton.Text = "Add New"
        Me.addNewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(282, 580)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(139, 53)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(391, 63)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 12
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'label12
        '
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(18, 179)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(130, 59)
        Me.label12.TabIndex = 3
        Me.label12.Text = "First Name"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(374, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 59)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Last Name"
        '
        'fNameBox
        '
        Me.fNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNameBox.Location = New System.Drawing.Point(188, 180)
        Me.fNameBox.Name = "fNameBox"
        Me.fNameBox.Size = New System.Drawing.Size(142, 26)
        Me.fNameBox.TabIndex = 1
        '
        'lNameBox
        '
        Me.lNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameBox.Location = New System.Drawing.Point(534, 171)
        Me.lNameBox.Name = "lNameBox"
        Me.lNameBox.Size = New System.Drawing.Size(142, 26)
        Me.lNameBox.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(374, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 59)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Department"
        '
        'deptBox
        '
        Me.deptBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deptBox.Location = New System.Drawing.Point(534, 319)
        Me.deptBox.Name = "deptBox"
        Me.deptBox.Size = New System.Drawing.Size(142, 26)
        Me.deptBox.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(534, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'supervisorComboBox
        '
        Me.supervisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supervisorComboBox.FormattingEnabled = True
        Me.supervisorComboBox.Items.AddRange(New Object() {"Sophia Williams", "Samuel Martin", "Emily Thompson", "William Young", "John King", "Zoe Campbell"})
        Me.supervisorComboBox.Location = New System.Drawing.Point(518, 442)
        Me.supervisorComboBox.Name = "supervisorComboBox"
        Me.supervisorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.supervisorComboBox.TabIndex = 8
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(441, 498)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(139, 53)
        Me.editButton.TabIndex = 11
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'statusComboBox
        '
        Me.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusComboBox.FormattingEnabled = True
        Me.statusComboBox.Items.AddRange(New Object() {"Full-Time", "Part-Time", "Retired"})
        Me.statusComboBox.Location = New System.Drawing.Point(188, 251)
        Me.statusComboBox.Name = "statusComboBox"
        Me.statusComboBox.Size = New System.Drawing.Size(142, 28)
        Me.statusComboBox.TabIndex = 3
        '
        'idBox
        '
        Me.idBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idBox.Location = New System.Drawing.Point(188, 122)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(142, 26)
        Me.idBox.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Comp9GroupProject3.My.Resources.Resources.database
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(545, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 122)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'EmployeeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(688, 676)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.statusComboBox)
        Me.Controls.Add(Me.supervisorComboBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.addNewButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.infoBox)
        Me.Controls.Add(Me.deptBox)
        Me.Controls.Add(Me.positionBox)
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.lNameBox)
        Me.Controls.Add(Me.fNameBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "EmployeeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HRS - Employee Screen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhoneDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents positionBox As TextBox
    Friend WithEvents infoBox As TextBox
    Friend WithEvents deleteButton As Button
    Friend WithEvents addNewButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents fNameBox As TextBox
    Friend WithEvents lNameBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents deptBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents supervisorComboBox As ComboBox
    Friend WithEvents editButton As Button
    Friend WithEvents statusComboBox As ComboBox
    Friend WithEvents idBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
