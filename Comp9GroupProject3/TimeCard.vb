Imports System.Data.OleDb
Imports System.Reflection

Public Class TimeCard
    Dim SQLStatement As String = ""
    Dim connectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;" & "Data Source =C:\Users\Rod\Desktop\EmployeeDB.accdb"
    Dim dbConnection As New OleDbConnection(connectionString)
    Dim currentWeek As Integer = 1
    Dim validID As Boolean = False

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim empID As String = searchTextBox.Text.Trim()

        ' Check if the empID is valid
        If IsEmpIDValid(empID) Then
            SQLStatement = "SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday " &
            "FROM Employee " &
            "INNER JOIN Week1 ON Week1.empID = Employee.empID " &
            "WHERE Employee.empID = @empID"

            Dim dtHours As New DataTable
            Dim dbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@empID", empID)
            dbDataAdapter.Fill(dtHours)

            DataGridView1.DataSource = dtHours

            SQLStatement = "SELECT empID, Employee.firstName, Employee.lastName " &
            "FROM Employee " &
            "WHERE empID = @empID"

            Dim dtProperties As New DataTable
            Dim dbDataAdapter2 As OleDbDataAdapter = New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter2.SelectCommand.Parameters.AddWithValue("@empID", empID)
            dbDataAdapter2.Fill(dtProperties)

            Dim empFirstName As String = dtProperties.Rows(0)("FirstName").ToString()
            Dim empLastName As String = dtProperties.Rows(0)("LastName").ToString()
            Dim supervisorName As String = empFirstName & " " & empLastName

            nameLabel.Text = supervisorName
            idLabel.Text = dtProperties.Rows(0)("empID").ToString()

            validID = True
        Else
            ' Display a message that the empID is not found
            MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If validID = True Then

            ' Construct the table name for the next week based on the current week number
            Dim tableName As String = "Week" & (currentWeek + 1)

            ' Check if the next week's table exists
            If TableExists(tableName) Then

                ' Increment the current week number
                currentWeek += 1
                weekLabel.Text = currentWeek

                ' Update the SQL query to retrieve data from the next week's table
                SQLStatement = "SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday " &
                "FROM " & tableName & " " &
                "WHERE empID = @empID"

                Dim dtHours As New DataTable
                Dim dbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(SQLStatement, connectionString)
                dbDataAdapter.SelectCommand.Parameters.AddWithValue("@empID", idLabel.Text.Trim())
                dbDataAdapter.Fill(dtHours)

                DataGridView1.DataSource = dtHours
                previousButton.Enabled = True

                'check if there is a next table, if not set nextbutton to false.
                Dim nextTableName As String = "Week" & (currentWeek + 1)
                If Not TableExists(nextTableName) Then
                    ' Disable the "Next" button
                    nextButton.Enabled = False
                End If
            Else
                ' Disable the "Next" button
                nextButton.Enabled = False
            End If
        Else
            MessageBox.Show("enter a valid ID")

        End If

    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        If validID = True Then
            ' Decrement the current week number
            currentWeek -= 1
            weekLabel.Text = currentWeek

            ' Check if there is a previous week
            If currentWeek >= 1 Then
                ' Construct the table name for the previous week based on the current week number
                Dim tableName As String = "Week" & currentWeek

                ' Update the SQL query to retrieve data from the previous week's table
                SQLStatement = "SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday " &
                "FROM " & tableName & " " &
                "WHERE empID = @empID"

                Dim dtHours As New DataTable
                Dim dbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(SQLStatement, connectionString)
                dbDataAdapter.SelectCommand.Parameters.AddWithValue("@empID", idLabel.Text.Trim())
                dbDataAdapter.Fill(dtHours)

                DataGridView1.DataSource = dtHours

                ' Enable the "Next" button
                nextButton.Enabled = True

                Dim previousTableName As String = "Week" & (currentWeek - 1)
                If Not TableExists(previousTableName) Then
                    ' Disable the "Previous" button
                    previousButton.Enabled = False
                End If
            Else
                ' No previous week exists, disable the "Previous" button
                previousButton.Enabled = False
            End If
        Else
            MessageBox.Show("enter a valid ID")
        End If

    End Sub

    Private Function TableExists(tableName As String) As Boolean
        ' Check if the specified table exists in the database
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim schema As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim rows As DataRow() = schema.Select("TABLE_NAME = '" & tableName & "'")
            Return rows.Length > 0
        End Using
    End Function
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
    Private Sub CalculateAndDisplayDifference(inPicker As DateTimePicker, outPicker As DateTimePicker, totalLabel As Label)
        ' Get the selected "In" and "Out" dates
        Dim inTime As DateTime = inPicker.Value
        Dim outTime As DateTime = outPicker.Value

        ' Calculate the difference between the dates
        Dim difference As TimeSpan = outTime.Subtract(inTime)

        ' Convert the difference to decimal format
        Dim decimalHours As Double = difference.Hours + (difference.Minutes / 60) + (difference.Seconds / 3600)

        ' Display the difference in the respective total label
        totalLabel.Text = decimalHours.ToString("0.00")
    End Sub

    Private Function CalculateAndDisplayDifference2(inPicker As DateTimePicker, outPicker As DateTimePicker, totalLabel As Label) As Double
        ' Get the selected "In" and "Out" dates
        Dim inTime As DateTime = inPicker.Value
        Dim outTime As DateTime = outPicker.Value

        ' Calculate the difference between the dates
        Dim difference As TimeSpan = outTime.Subtract(inTime)

        ' Convert the difference to decimal format
        Dim decimalHours As Double = difference.Hours + (difference.Minutes / 60) + (difference.Seconds / 3600)

        ' Display the difference in the respective total label
        totalLabel.Text = decimalHours.ToString("0.00")

        ' Return
        Return decimalHours
    End Function
    Private Sub TimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previousButton.Enabled = False
        nextButton.Enabled = True
    End Sub

    Private Sub testButton_Click(sender As Object, e As EventArgs) Handles testButton.Click
        ' Get the selected dates from the DateTimePicker controls
        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value

        ' Calculate the difference between the dates
        Dim difference As TimeSpan = endDate.Subtract(startDate)

        ' Convert the difference to decimal format
        Dim decimalHours As Double = difference.Hours + (difference.Minutes / 60) + (difference.Seconds / 3600)

        ' Display the difference in decimal format
        testLabel.Text = decimalHours.ToString("0.00") & " hours"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        ' Calculate and display the difference for each day of the week

        ' Monday
        Dim totalMonday As Double = CalculateAndDisplayDifference2(monINTime, monOutTime, monTotalLabel)

        ' Tuesday
        Dim totalTuesday As Double = CalculateAndDisplayDifference2(tueINTime, tueOutTime, tueTotalLabel)

        ' Wednesday
        Dim totalWednesday As Double = CalculateAndDisplayDifference2(wedINTime, wedOutTime, wedTotalLabel)

        ' Thursday
        Dim totalThursday As Double = CalculateAndDisplayDifference2(thuInTime, thuOutTime, thuTotalLabel)

        ' Friday
        Dim totalFriday As Double = CalculateAndDisplayDifference2(friInTime, friOutTime, friTotalLabel)

        ' Saturday
        Dim totalSaturday As Double = CalculateAndDisplayDifference2(satInTime, satOutTime, satTotalLabel)

        ' Sunday
        Dim totalSunday As Double = CalculateAndDisplayDifference2(sunInTime, sunOutTime, sunTotalLabel)

        'calculate total hours
        Dim totalHours As Double = totalMonday + totalTuesday + totalWednesday + totalThursday + totalFriday + totalSaturday + totalSunday

        'diplay total hours
        totalLabel.Text = totalHours.ToString("0.00")
    End Sub
End Class