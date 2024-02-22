Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EZTimeCard
    Dim SQLStatement As String = ""
    Dim connectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;" & "Data Source =C:\Users\Rod\Desktop\EmployeeDB.accdb"
    Dim dbConnection As New OleDbConnection(connectionString)

    Dim currentDate As Date
    Dim currentWeek As Integer
    Dim empID As String

    Dim timeCardDataTable As New DataTable()
    Private Sub TimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nextButton.Enabled = True

        ' Get the current date
        currentDate = Date.Today

        ' Query the payrollWeek table to find the corresponding week
        SQLStatement = "SELECT Week, FromDate, ToDate FROM payrollWeek WHERE @currentDate >= FromDate AND @currentDate <= ToDate"

        Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@currentDate", currentDate)

            Dim weekDataTable As New DataTable
            dbDataAdapter.Fill(weekDataTable)

            If weekDataTable.Rows.Count > 0 Then
                ' Retrieve the week, fromDate, and toDate values from the DataTable
                Dim currentWeek As String = weekDataTable.Rows(0)("Week").ToString()
                Dim fromDate As Date = CDate(weekDataTable.Rows(0)("FromDate"))
                Dim toDate As Date = CDate(weekDataTable.Rows(0)("ToDate"))

                ' Format the fromDate and toDate as strings
                Dim fromDateStr As String = fromDate.ToString("MMMM d, yyyy")
                Dim toDateStr As String = toDate.ToString("MMMM d, yyyy")

                ' Update the currentWeekLabel text
                weekLabel.Text = $"Current Week: {currentWeek} ({fromDateStr} - {toDateStr})"
                Label1.Text = currentWeek
            Else
                ' Handle the case when the current date does not fall within any payroll week
                MessageBox.Show("No corresponding payroll week found for the current date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

        currentWeek = Integer.Parse(Label1.Text)
    End Sub
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click

        'Dim empID As String = searchTextBox.Text.Trim()
        empID = searchTextBox.Text.Trim()

        ' Check if the empID is provided
        If Not String.IsNullOrEmpty(empID) Then

            ' Check if there are existing entries for the specified empID and current week
            Dim existingEntries As Boolean = CheckExistingEntries(empID, currentWeek)

            If existingEntries Then
                ' Display the existing entries in the DataGridView
                DisplayExistingEntries(empID, currentWeek)
            Else
                ' Ask the user if they want to create a new entry
                Dim result As DialogResult = MessageBox.Show("No entries found for the specified employee and current week. Do you want to create a new entry with all values set to 0?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Create a new entry with all values set to 0
                    CreateNewEntry(empID, currentWeek)
                End If
            End If
        Else
            ' Display a message that the empID is not provided
            MessageBox.Show("Please enter an employee ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dbConnection.Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' Get the current week number from Label1
        currentWeek = Integer.Parse(Label1.Text)

        ' Increment the current week number to get the next week
        Dim nextWeek As Integer = currentWeek + 1

        currentWeek += 1

        DataGridView1.DataSource = Nothing
        searchButton_Click(sender, e)

        ' Query the payrollWeek table to find the corresponding next week
        SQLStatement = "SELECT Week, FromDate, ToDate FROM payrollWeek WHERE Week = @nextWeek"

        Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@nextWeek", nextWeek)

            Dim weekDataTable As New DataTable
            dbDataAdapter.Fill(weekDataTable)

            If weekDataTable.Rows.Count > 0 Then
                ' Retrieve the week, fromDate, and toDate values from the DataTable
                Dim nextWeekStr As String = weekDataTable.Rows(0)("Week").ToString()
                Dim fromDate As Date = CDate(weekDataTable.Rows(0)("FromDate"))
                Dim toDate As Date = CDate(weekDataTable.Rows(0)("ToDate"))

                ' Format the fromDate and toDate as strings
                Dim fromDateStr As String = fromDate.ToString("MMMM d, yyyy")
                Dim toDateStr As String = toDate.ToString("MMMM d, yyyy")

                ' Update the weekLabel and Label1 with the next week information
                weekLabel.Text = $"Week: {nextWeekStr} ({fromDateStr} - {toDateStr})"
                Label1.Text = nextWeekStr
                previousButton.Enabled = True
            Else
                ' Handle the case when no corresponding next week is found
                MessageBox.Show("No next week found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        ' Get the current week number from Label1
        currentWeek = Integer.Parse(Label1.Text)

        ' Decrement the current week number to get the previous week
        Dim previousWeek As Integer = currentWeek - 1

        currentWeek -= 1

        DataGridView1.DataSource = Nothing
        searchButton_Click(sender, e)

        ' Query the payrollWeek table to find the corresponding previous week
        SQLStatement = "SELECT Week, FromDate, ToDate FROM payrollWeek WHERE Week = @previousWeek"

        Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@previousWeek", previousWeek)

            Dim weekDataTable As New DataTable
            dbDataAdapter.Fill(weekDataTable)

            If weekDataTable.Rows.Count > 0 Then

                ' Retrieve the week, fromDate, and toDate values from the DataTable
                Dim previousWeekStr As String = weekDataTable.Rows(0)("Week").ToString()
                Dim fromDate As Date = CDate(weekDataTable.Rows(0)("FromDate"))
                Dim toDate As Date = CDate(weekDataTable.Rows(0)("ToDate"))

                ' Format the fromDate and toDate as strings
                Dim fromDateStr As String = fromDate.ToString("MMMM d, yyyy")
                Dim toDateStr As String = toDate.ToString("MMMM d, yyyy")

                ' Update the weekLabel and Label1 with the previous week information
                weekLabel.Text = $"Week: {previousWeekStr} ({fromDateStr} - {toDateStr})"
                Label1.Text = previousWeekStr
            Else
                ' Handle the case when no corresponding previous week is found
                MessageBox.Show("No previous week found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        If Not String.IsNullOrEmpty(empID) AndAlso Not String.IsNullOrEmpty(currentWeek) Then

            ' Get the values from the DataGridView
            Dim sundayValue As Object = DataGridView1.CurrentRow.Cells("Sunday").Value
            Dim mondayValue As Object = DataGridView1.CurrentRow.Cells("Monday").Value
            Dim tuesdayValue As Object = DataGridView1.CurrentRow.Cells("Tuesday").Value
            Dim wednesdayValue As Object = DataGridView1.CurrentRow.Cells("Wednesday").Value
            Dim thursdayValue As Object = DataGridView1.CurrentRow.Cells("Thursday").Value
            Dim fridayValue As Object = DataGridView1.CurrentRow.Cells("Friday").Value
            Dim saturdayValue As Object = DataGridView1.CurrentRow.Cells("Saturday").Value

            ' Update the entry in the database
            Dim query As String = "UPDATE EmployeeTimeCard SET Sunday = @Sunday, Monday = @Monday, Tuesday = @Tuesday, Wednesday = @Wednesday, Thursday = @Thursday, Friday = @Friday, Saturday = @Saturday WHERE empID = @EmpID AND WeekID = @WeekID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@Sunday", sundayValue)
                    command.Parameters.AddWithValue("@Monday", mondayValue)
                    command.Parameters.AddWithValue("@Tuesday", tuesdayValue)
                    command.Parameters.AddWithValue("@Wednesday", wednesdayValue)
                    command.Parameters.AddWithValue("@Thursday", thursdayValue)
                    command.Parameters.AddWithValue("@Friday", fridayValue)
                    command.Parameters.AddWithValue("@Saturday", saturdayValue)
                    command.Parameters.AddWithValue("@EmpID", empID)
                    command.Parameters.AddWithValue("@WeekID", currentWeek)

                    ' Open the connection and execute the command
                    connection.Open()
                    command.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Entry updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
            DisplayExistingEntries(empID, currentWeek)
        Else
            MessageBox.Show("Please provide employee ID and week values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' Check if empID and weekID have values
        If Not String.IsNullOrEmpty(empID) AndAlso Not String.IsNullOrEmpty(currentWeek) Then
            ' Display a confirmation message box
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to sumbit your timecard?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                DataGridView1.Enabled = False

                ' Update the entry in the database
                Dim query As String = "UPDATE EmployeeTimeCard SET timecard = @timecard WHERE empID = @EmpID AND WeekID = @WeekID"

                Using connection As New OleDbConnection(connectionString)
                    Using command As New OleDbCommand(query, connection)
                        ' Add parameters
                        command.Parameters.AddWithValue("@timecard", True)

                        ' Add empID and WeekID parameters
                        command.Parameters.AddWithValue("@EmpID", empID)
                        command.Parameters.AddWithValue("@WeekID", currentWeek)

                        ' Open the connection and execute the command
                        connection.Open()
                        command.ExecuteNonQuery()

                        ' Display a success message
                        MessageBox.Show("Entry updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
                DisplayExistingEntries(empID, currentWeek)
            End If
        Else
            MessageBox.Show("Please provide employee ID and week values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub DisplayExistingEntries(empID As String, currentWeek As String)
        ' Display the existing entries in the DataGridView
        SQLStatement = "SELECT Employee.firstName, Employee.lastName, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday " &
                       "FROM employeetimecard " &
                       "INNER JOIN Employee ON Employee.empID = EmployeeTimeCard.empID " &
                       "WHERE EmployeeTimeCard.empID = @empID AND EmployeeTimeCard.WeekID = @currentWeek"

        Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@empID", empID)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@currentWeek", currentWeek)

            Dim timeCardDataTable As New DataTable
            dbDataAdapter.Fill(timeCardDataTable)

            If timeCardDataTable.Rows.Count > 0 Then

                DataGridView1.DataSource = timeCardDataTable

                Dim firstName As String = timeCardDataTable.Rows(0)("firstName").ToString()
                Dim lastName As String = timeCardDataTable.Rows(0)("lastName").ToString()
                Dim fullName As String = firstName & " " & lastName

                nameLabel.Text = fullName
                idLabel.Text = empID
                DataGridView1.Columns("firstName").Visible = False
                DataGridView1.Columns("lastName").Visible = False

                'calculate the toal from sunday through saturday
                Dim sum As Integer = 0
                For Each dayOfWeek As DayOfWeek In [Enum].GetValues(GetType(DayOfWeek))
                    Dim columnName As String = dayOfWeek.ToString()
                    If timeCardDataTable.Columns.Contains(columnName) Then
                        For Each row As DataRow In timeCardDataTable.Rows
                            Dim value As Integer
                            If Integer.TryParse(row(columnName).ToString(), value) Then
                                sum += value
                            End If
                        Next
                    End If
                Next

                totalLabel.Text = sum.ToString()

                Dim timeCardStatus As Boolean = GetTimeCardStatus(empID, currentWeek)
                If timeCardStatus Then
                    DataGridView1.Enabled = False
                    DataGridView1.DefaultCellStyle.BackColor = Color.DarkGray
                Else
                    DataGridView1.Enabled = True
                    DataGridView1.DefaultCellStyle.BackColor = Color.White
                End If
            Else
                'no entries are found
                totalLabel.Text = 0
            End If
        End Using
    End Sub

    Private Sub CreateNewEntry(empID As String, currentWeek As String)
        ' Check if the empID exists in the Employee table
        Dim employeeExists As Boolean = False
        SQLStatement = "SELECT COUNT(*) FROM Employee WHERE empID = @empID"

        Using dbCommand As New OleDbCommand(SQLStatement, dbConnection)
            dbCommand.Parameters.AddWithValue("@empID", empID)
            dbConnection.Open()
            Dim result As Integer = CInt(dbCommand.ExecuteScalar())
            If result > 0 Then
                employeeExists = True
            End If
            dbConnection.Close()
        End Using

        If employeeExists Then
            ' Create a new entry in the EmployeeTimeCard table
            SQLStatement = "INSERT INTO EmployeeTimeCard (empID, weekID, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?);"

            Try
                Using dbConnection As New OleDbConnection(connectionString)
                    Using dbCommand As New OleDbCommand(SQLStatement, dbConnection)
                        dbCommand.Parameters.AddWithValue("@empID", empID)
                        dbCommand.Parameters.AddWithValue("@weekId", currentWeek)
                        dbCommand.Parameters.AddWithValue("@Sunday", 0)
                        dbCommand.Parameters.AddWithValue("@Monday", 0)
                        dbCommand.Parameters.AddWithValue("@Tuesday", 0)
                        dbCommand.Parameters.AddWithValue("@Wednesday", 0)
                        dbCommand.Parameters.AddWithValue("@Thursday", 0)
                        dbCommand.Parameters.AddWithValue("@Friday", 0)
                        dbCommand.Parameters.AddWithValue("@Saturday", 0)

                        dbConnection.Open()
                        dbCommand.ExecuteNonQuery()
                    End Using
                End Using

                DisplayExistingEntries(empID, currentWeek)

            Catch ex As Exception
                MessageBox.Show("Error adding new entry: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No employee found with the provided empID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CheckExistingEntries(empID As String, currentWeek As String) As Boolean
        ' Check if there are entries for the specified empID and current week
        SQLStatement = "SELECT * FROM employeetimecard WHERE empID = @empID AND WeekID = @currentWeek"

        Using dbDataAdapter As New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@empID", empID)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@currentWeek", currentWeek)

            Dim timeCardDataTable As New DataTable
            dbDataAdapter.Fill(timeCardDataTable)

            Return timeCardDataTable.Rows.Count > 0
        End Using
    End Function

    Private Function GetTimeCardStatus(empID As String, currentWeek As String) As Boolean
        ' Query to retrieve the timecard status for the specified empID and currentWeek
        Dim query As String = "SELECT timecard FROM EmployeeTimeCard WHERE empID = @EmpID AND WeekID = @WeekID"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@EmpID", empID)
                command.Parameters.AddWithValue("@WeekID", currentWeek)

                ' Open the connection
                connection.Open()

                ' Execute the query and retrieve the timecard status
                Dim timeCardValue As Boolean = CBool(command.ExecuteScalar())

                ' Return the timecard status
                Return timeCardValue
            End Using
        End Using
    End Function
    Private Sub EmployeeScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeScreenToolStripMenuItem.Click
        EmployeeScreen.Show()
    End Sub

    Private Sub PhoneDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhoneDirectoryToolStripMenuItem.Click
        PhoneDirectory.Show()
    End Sub
End Class