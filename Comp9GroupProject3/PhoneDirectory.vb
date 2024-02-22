Imports System.Data.OleDb
Public Class PhoneDirectory
    Dim SQLStatement As String = ""
    Dim connectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;" & "Data Source =C:\Users\Rod\Desktop\EmployeeDB.accdb"
    Dim dbConnection As New OleDbConnection(connectionString)

    Private Sub PhoneDirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLStatement = "SELECT firstName, lastName FROM Employee WHERE position2 = 'Supervisor'"

        Dim dtDirectory As New DataTable
        Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.Fill(dtDirectory)
        End Using

        ' Populate the supervisorComboBox with the first and last names of supervisors
        For Each row As DataRow In dtDirectory.Rows
            Dim firstName As String = row("firstName").ToString()
            Dim lastName As String = row("lastName").ToString()
            Dim supervisor As String = firstName & " " & lastName
            supervisorComboBox.Items.Add(supervisor)
        Next

        ' Populate the departmentComboBox with different departments
        SQLStatement = "SELECT DISTINCT Department FROM Employee"

        Dim dtDepartments As New DataTable
        Using dbDataAdapter2 As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter2.Fill(dtDepartments)
        End Using

        For Each row As DataRow In dtDepartments.Rows
            Dim department As String = row("Department").ToString()
            departmentComboBox.Items.Add(department)
        Next
    End Sub
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim name As String = searchTextBox.Text.Trim()

        ' Check if the name is provided
        If Not String.IsNullOrEmpty(name) Then
            SQLStatement = "SELECT firstName, lastName, Department, position2, extension " &
                "FROM Employee " &
                "WHERE firstName LIKE @name OR lastName LIKE @name"

            Dim dtDirectory As New DataTable
            Dim dbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" & name & "%")
            dbDataAdapter.Fill(dtDirectory)

            DataGridView1.DataSource = dtDirectory
            DataGridView1.Columns("position2").HeaderText = "Title"
            DataGridView1.Columns("extension").HeaderText = "Extension"
            DataGridView1.Columns("firstName").HeaderText = "First Name"
            DataGridView1.Columns("lastName").HeaderText = "Last Name"

            departmentComboBox.SelectedIndex = -1
            supervisorComboBox.SelectedIndex = -1
        Else
            ' Display a message that the name is not provided
            MessageBox.Show("Please enter a name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub supervisorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supervisorComboBox.SelectedIndexChanged
        If supervisorComboBox.SelectedItem IsNot Nothing Then
            ' Clear any existing data in the DataGridView
            DataGridView1.DataSource = Nothing

            ' Get the selected supervisor
            Dim selectedSupervisor As String = supervisorComboBox.SelectedItem.ToString()

            ' Get the department of the selected supervisor
            Dim selectedDepartment As String = ""

            ' Construct the SQL query to fetch the department of the selected supervisor
            Dim supervisorSQL As String = "SELECT Department FROM Employee WHERE firstName + ' ' + lastName = @selectedSupervisor"

            Using supervisorDataAdapter As New OleDbDataAdapter(supervisorSQL, connectionString)
                supervisorDataAdapter.SelectCommand.Parameters.AddWithValue("@selectedSupervisor", selectedSupervisor)
                Dim supervisorDataTable As New DataTable
                supervisorDataAdapter.Fill(supervisorDataTable)

                If supervisorDataTable.Rows.Count > 0 Then
                    selectedDepartment = supervisorDataTable.Rows(0)("Department").ToString()
                End If
            End Using

            ' Construct the SQL query to fetch employees in the selected department
            Dim employeesSQL As String = "SELECT firstName, lastName, Department, position2, Extension " &
            "FROM Employee " &
            "WHERE Department = @selectedDepartment"

            Dim dtEmployees As New DataTable
            Using dbDataAdapter As New OleDbDataAdapter(employeesSQL, connectionString)
                dbDataAdapter.SelectCommand.Parameters.AddWithValue("@selectedDepartment", selectedDepartment)
                dbDataAdapter.Fill(dtEmployees)
            End Using

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = dtEmployees
            DataGridView1.Columns("position2").HeaderText = "Title"
            DataGridView1.Columns("firstName").HeaderText = "First Name"
            DataGridView1.Columns("lastName").HeaderText = "Last Name"

            'clear search text box and department combo box
            searchTextBox.Text = ""
            departmentComboBox.SelectedIndex = -1
        End If
    End Sub
    Private Sub departmentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departmentComboBox.SelectedIndexChanged
        ' Check if there is a selected item
        If departmentComboBox.SelectedItem IsNot Nothing Then
            ' Clear any existing data in the DataGridView
            DataGridView1.DataSource = Nothing

            ' Get the selected department
            Dim selectedDepartment As String = departmentComboBox.SelectedItem.ToString()

            ' Construct the SQL query to fetch employees in the selected department
            SQLStatement = "SELECT firstName, lastName, Department, position2, Extension " &
            "FROM Employee " &
            "WHERE Department = @selectedDepartment"

            Dim dtEmployees As New DataTable
            Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
                dbDataAdapter.SelectCommand.Parameters.AddWithValue("@selectedDepartment", selectedDepartment)
                dbDataAdapter.Fill(dtEmployees)
            End Using

            DataGridView1.DataSource = dtEmployees
            DataGridView1.Columns("position2").HeaderText = "Title"
            DataGridView1.Columns("firstName").HeaderText = "First Name"
            DataGridView1.Columns("lastName").HeaderText = "Last Name"
            DataGridView1.Columns("lastName").HeaderText = "Last Name"

            searchTextBox.Text = ""
        End If
    End Sub
    Private Function IsEmpIDValid(empID As String) As Boolean
        ' Check if the empID exists in the database
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            SQLStatement = "SELECT COUNT(*) FROM Employee WHERE empID = @empID"
            Using command As New OleDbCommand(SQLStatement, connection)
                command.Parameters.AddWithValue("@empID", empID)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub EmployeeScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeScreenToolStripMenuItem.Click
        EmployeeScreen.Show()
    End Sub
    Private Sub TimeCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeCardToolStripMenuItem.Click
        TimeCard.Show()
    End Sub
End Class