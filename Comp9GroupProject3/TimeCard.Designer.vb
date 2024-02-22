<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimeCard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhoneDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.weekLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.unlockButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.testButton = New System.Windows.Forms.Button()
        Me.testLabel = New System.Windows.Forms.Label()
        Me.monINTime = New System.Windows.Forms.DateTimePicker()
        Me.monOutTime = New System.Windows.Forms.DateTimePicker()
        Me.tueINTime = New System.Windows.Forms.DateTimePicker()
        Me.tueOutTime = New System.Windows.Forms.DateTimePicker()
        Me.wedINTime = New System.Windows.Forms.DateTimePicker()
        Me.wedOutTime = New System.Windows.Forms.DateTimePicker()
        Me.thuInTime = New System.Windows.Forms.DateTimePicker()
        Me.thuOutTime = New System.Windows.Forms.DateTimePicker()
        Me.friInTime = New System.Windows.Forms.DateTimePicker()
        Me.friOutTime = New System.Windows.Forms.DateTimePicker()
        Me.satInTime = New System.Windows.Forms.DateTimePicker()
        Me.satOutTime = New System.Windows.Forms.DateTimePicker()
        Me.sunInTime = New System.Windows.Forms.DateTimePicker()
        Me.sunOutTime = New System.Windows.Forms.DateTimePicker()
        Me.monTotalLabel = New System.Windows.Forms.Label()
        Me.tueTotalLabel = New System.Windows.Forms.Label()
        Me.wedTotalLabel = New System.Windows.Forms.Label()
        Me.thuTotalLabel = New System.Windows.Forms.Label()
        Me.friTotalLabel = New System.Windows.Forms.Label()
        Me.satTotalLabel = New System.Windows.Forms.Label()
        Me.sunTotalLabel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeScreenToolStripMenuItem, Me.TimeCardToolStripMenuItem, Me.PhoneDirectoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EmployeeScreenToolStripMenuItem
        '
        Me.EmployeeScreenToolStripMenuItem.Name = "EmployeeScreenToolStripMenuItem"
        Me.EmployeeScreenToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EmployeeScreenToolStripMenuItem.Text = "Employee Screen"
        '
        'TimeCardToolStripMenuItem
        '
        Me.TimeCardToolStripMenuItem.Name = "TimeCardToolStripMenuItem"
        Me.TimeCardToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TimeCardToolStripMenuItem.Text = "Time Card"
        '
        'PhoneDirectoryToolStripMenuItem
        '
        Me.PhoneDirectoryToolStripMenuItem.Name = "PhoneDirectoryToolStripMenuItem"
        Me.PhoneDirectoryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PhoneDirectoryToolStripMenuItem.Text = "Phone Directory"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(665, 79)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(15, 13)
        Me.idLabel.TabIndex = 9
        Me.idLabel.Text = "id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(597, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(665, 51)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(33, 13)
        Me.nameLabel.TabIndex = 11
        Me.nameLabel.Text = "name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(597, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Employee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Calendar Year:"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(162, 51)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(51, 35)
        Me.nextButton.TabIndex = 15
        Me.nextButton.Text = ">"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(41, 51)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(51, 35)
        Me.previousButton.TabIndex = 14
        Me.previousButton.Text = "<"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Week"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "2023"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Hours Worked"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(338, 115)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.searchTextBox.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "EmployeeID:"
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(458, 113)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 20
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(744, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'weekLabel
        '
        Me.weekLabel.AutoSize = True
        Me.weekLabel.Location = New System.Drawing.Point(139, 62)
        Me.weekLabel.Name = "weekLabel"
        Me.weekLabel.Size = New System.Drawing.Size(13, 13)
        Me.weekLabel.TabIndex = 13
        Me.weekLabel.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Clock In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Clock Out"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 510)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Day"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(142, 350)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Monday"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(238, 350)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Tuesday"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(334, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 20)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Wednesday"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(451, 350)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Thursday"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(560, 350)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Friday"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(641, 350)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 20)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Saturday"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(751, 350)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 20)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Sunday"
        '
        'unlockButton
        '
        Me.unlockButton.Enabled = False
        Me.unlockButton.Location = New System.Drawing.Point(260, 640)
        Me.unlockButton.Name = "unlockButton"
        Me.unlockButton.Size = New System.Drawing.Size(108, 54)
        Me.unlockButton.TabIndex = 25
        Me.unlockButton.Text = "Unlock"
        Me.unlockButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(380, 640)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(108, 54)
        Me.saveButton.TabIndex = 25
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(500, 640)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(108, 54)
        Me.submitButton.TabIndex = 25
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 674)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(31, 708)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker2.TabIndex = 27
        '
        'testButton
        '
        Me.testButton.Location = New System.Drawing.Point(41, 640)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(75, 23)
        Me.testButton.TabIndex = 28
        Me.testButton.Text = "Button4"
        Me.testButton.UseVisualStyleBackColor = True
        '
        'testLabel
        '
        Me.testLabel.AutoSize = True
        Me.testLabel.Location = New System.Drawing.Point(47, 743)
        Me.testLabel.Name = "testLabel"
        Me.testLabel.Size = New System.Drawing.Size(45, 13)
        Me.testLabel.TabIndex = 29
        Me.testLabel.Text = "Label26"
        '
        'monINTime
        '
        Me.monINTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.monINTime.Location = New System.Drawing.Point(129, 402)
        Me.monINTime.Name = "monINTime"
        Me.monINTime.ShowUpDown = True
        Me.monINTime.Size = New System.Drawing.Size(89, 20)
        Me.monINTime.TabIndex = 26
        '
        'monOutTime
        '
        Me.monOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.monOutTime.Location = New System.Drawing.Point(129, 453)
        Me.monOutTime.Name = "monOutTime"
        Me.monOutTime.ShowUpDown = True
        Me.monOutTime.Size = New System.Drawing.Size(89, 20)
        Me.monOutTime.TabIndex = 27
        '
        'tueINTime
        '
        Me.tueINTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tueINTime.Location = New System.Drawing.Point(235, 402)
        Me.tueINTime.Name = "tueINTime"
        Me.tueINTime.ShowUpDown = True
        Me.tueINTime.Size = New System.Drawing.Size(89, 20)
        Me.tueINTime.TabIndex = 26
        '
        'tueOutTime
        '
        Me.tueOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tueOutTime.Location = New System.Drawing.Point(235, 453)
        Me.tueOutTime.Name = "tueOutTime"
        Me.tueOutTime.ShowUpDown = True
        Me.tueOutTime.Size = New System.Drawing.Size(89, 20)
        Me.tueOutTime.TabIndex = 27
        '
        'wedINTime
        '
        Me.wedINTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.wedINTime.Location = New System.Drawing.Point(338, 402)
        Me.wedINTime.Name = "wedINTime"
        Me.wedINTime.ShowUpDown = True
        Me.wedINTime.Size = New System.Drawing.Size(89, 20)
        Me.wedINTime.TabIndex = 26
        '
        'wedOutTime
        '
        Me.wedOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.wedOutTime.Location = New System.Drawing.Point(338, 453)
        Me.wedOutTime.Name = "wedOutTime"
        Me.wedOutTime.ShowUpDown = True
        Me.wedOutTime.Size = New System.Drawing.Size(89, 20)
        Me.wedOutTime.TabIndex = 27
        '
        'thuInTime
        '
        Me.thuInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.thuInTime.Location = New System.Drawing.Point(444, 401)
        Me.thuInTime.Name = "thuInTime"
        Me.thuInTime.ShowUpDown = True
        Me.thuInTime.Size = New System.Drawing.Size(89, 20)
        Me.thuInTime.TabIndex = 26
        '
        'thuOutTime
        '
        Me.thuOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.thuOutTime.Location = New System.Drawing.Point(444, 452)
        Me.thuOutTime.Name = "thuOutTime"
        Me.thuOutTime.ShowUpDown = True
        Me.thuOutTime.Size = New System.Drawing.Size(89, 20)
        Me.thuOutTime.TabIndex = 27
        '
        'friInTime
        '
        Me.friInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.friInTime.Location = New System.Drawing.Point(550, 402)
        Me.friInTime.Name = "friInTime"
        Me.friInTime.ShowUpDown = True
        Me.friInTime.Size = New System.Drawing.Size(89, 20)
        Me.friInTime.TabIndex = 26
        '
        'friOutTime
        '
        Me.friOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.friOutTime.Location = New System.Drawing.Point(550, 453)
        Me.friOutTime.Name = "friOutTime"
        Me.friOutTime.ShowUpDown = True
        Me.friOutTime.Size = New System.Drawing.Size(89, 20)
        Me.friOutTime.TabIndex = 27
        '
        'satInTime
        '
        Me.satInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.satInTime.Location = New System.Drawing.Point(645, 401)
        Me.satInTime.Name = "satInTime"
        Me.satInTime.ShowUpDown = True
        Me.satInTime.Size = New System.Drawing.Size(89, 20)
        Me.satInTime.TabIndex = 26
        '
        'satOutTime
        '
        Me.satOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.satOutTime.Location = New System.Drawing.Point(645, 452)
        Me.satOutTime.Name = "satOutTime"
        Me.satOutTime.ShowUpDown = True
        Me.satOutTime.Size = New System.Drawing.Size(89, 20)
        Me.satOutTime.TabIndex = 27
        '
        'sunInTime
        '
        Me.sunInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.sunInTime.Location = New System.Drawing.Point(743, 402)
        Me.sunInTime.Name = "sunInTime"
        Me.sunInTime.ShowUpDown = True
        Me.sunInTime.Size = New System.Drawing.Size(89, 20)
        Me.sunInTime.TabIndex = 26
        '
        'sunOutTime
        '
        Me.sunOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.sunOutTime.Location = New System.Drawing.Point(743, 453)
        Me.sunOutTime.Name = "sunOutTime"
        Me.sunOutTime.ShowUpDown = True
        Me.sunOutTime.Size = New System.Drawing.Size(89, 20)
        Me.sunOutTime.TabIndex = 27
        '
        'monTotalLabel
        '
        Me.monTotalLabel.AutoSize = True
        Me.monTotalLabel.Location = New System.Drawing.Point(143, 515)
        Me.monTotalLabel.Name = "monTotalLabel"
        Me.monTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.monTotalLabel.TabIndex = 29
        Me.monTotalLabel.Text = "0.00"
        '
        'tueTotalLabel
        '
        Me.tueTotalLabel.AutoSize = True
        Me.tueTotalLabel.Location = New System.Drawing.Point(257, 515)
        Me.tueTotalLabel.Name = "tueTotalLabel"
        Me.tueTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.tueTotalLabel.TabIndex = 29
        Me.tueTotalLabel.Text = "0.00"
        '
        'wedTotalLabel
        '
        Me.wedTotalLabel.AutoSize = True
        Me.wedTotalLabel.Location = New System.Drawing.Point(359, 515)
        Me.wedTotalLabel.Name = "wedTotalLabel"
        Me.wedTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.wedTotalLabel.TabIndex = 29
        Me.wedTotalLabel.Text = "0.00"
        '
        'thuTotalLabel
        '
        Me.thuTotalLabel.AutoSize = True
        Me.thuTotalLabel.Location = New System.Drawing.Point(455, 515)
        Me.thuTotalLabel.Name = "thuTotalLabel"
        Me.thuTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.thuTotalLabel.TabIndex = 29
        Me.thuTotalLabel.Text = "0.00"
        '
        'friTotalLabel
        '
        Me.friTotalLabel.AutoSize = True
        Me.friTotalLabel.Location = New System.Drawing.Point(561, 515)
        Me.friTotalLabel.Name = "friTotalLabel"
        Me.friTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.friTotalLabel.TabIndex = 29
        Me.friTotalLabel.Text = "0.00"
        '
        'satTotalLabel
        '
        Me.satTotalLabel.AutoSize = True
        Me.satTotalLabel.Location = New System.Drawing.Point(665, 517)
        Me.satTotalLabel.Name = "satTotalLabel"
        Me.satTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.satTotalLabel.TabIndex = 29
        Me.satTotalLabel.Text = "0.00"
        '
        'sunTotalLabel
        '
        Me.sunTotalLabel.AutoSize = True
        Me.sunTotalLabel.Location = New System.Drawing.Point(752, 517)
        Me.sunTotalLabel.Name = "sunTotalLabel"
        Me.sunTotalLabel.Size = New System.Drawing.Size(28, 13)
        Me.sunTotalLabel.TabIndex = 29
        Me.sunTotalLabel.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(620, 578)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Total Hours"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(751, 578)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(40, 20)
        Me.totalLabel.TabIndex = 30
        Me.totalLabel.Text = "0.00"
        '
        'TimeCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 769)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.sunTotalLabel)
        Me.Controls.Add(Me.satTotalLabel)
        Me.Controls.Add(Me.friTotalLabel)
        Me.Controls.Add(Me.thuTotalLabel)
        Me.Controls.Add(Me.wedTotalLabel)
        Me.Controls.Add(Me.tueTotalLabel)
        Me.Controls.Add(Me.monTotalLabel)
        Me.Controls.Add(Me.testLabel)
        Me.Controls.Add(Me.testButton)
        Me.Controls.Add(Me.sunOutTime)
        Me.Controls.Add(Me.satOutTime)
        Me.Controls.Add(Me.friOutTime)
        Me.Controls.Add(Me.thuOutTime)
        Me.Controls.Add(Me.wedOutTime)
        Me.Controls.Add(Me.tueOutTime)
        Me.Controls.Add(Me.monOutTime)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.sunInTime)
        Me.Controls.Add(Me.satInTime)
        Me.Controls.Add(Me.friInTime)
        Me.Controls.Add(Me.thuInTime)
        Me.Controls.Add(Me.wedINTime)
        Me.Controls.Add(Me.tueINTime)
        Me.Controls.Add(Me.monINTime)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.unlockButton)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.weekLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "TimeCard"
        Me.Text = "TimeCard(Beta)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhoneDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents idLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nextButton As Button
    Friend WithEvents previousButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents weekLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents unlockButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents testButton As Button
    Friend WithEvents testLabel As Label
    Friend WithEvents monINTime As DateTimePicker
    Friend WithEvents monOutTime As DateTimePicker
    Friend WithEvents tueINTime As DateTimePicker
    Friend WithEvents tueOutTime As DateTimePicker
    Friend WithEvents wedINTime As DateTimePicker
    Friend WithEvents wedOutTime As DateTimePicker
    Friend WithEvents thuInTime As DateTimePicker
    Friend WithEvents thuOutTime As DateTimePicker
    Friend WithEvents friInTime As DateTimePicker
    Friend WithEvents friOutTime As DateTimePicker
    Friend WithEvents satInTime As DateTimePicker
    Friend WithEvents satOutTime As DateTimePicker
    Friend WithEvents sunInTime As DateTimePicker
    Friend WithEvents sunOutTime As DateTimePicker
    Friend WithEvents monTotalLabel As Label
    Friend WithEvents tueTotalLabel As Label
    Friend WithEvents wedTotalLabel As Label
    Friend WithEvents thuTotalLabel As Label
    Friend WithEvents friTotalLabel As Label
    Friend WithEvents satTotalLabel As Label
    Friend WithEvents sunTotalLabel As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents totalLabel As Label
End Class
