Imports System.Data.Common
Imports System.Data.OleDb

Public Class EmployeeScreen
    Dim SQLStatement As String = ""
    Dim connectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;" & "Data Source =C:\Users\Rod\Desktop\EmployeeDB.accdb"
    Dim dbConnection As New OleDbConnection(connectionString)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim empID As String = searchBox.Text.Trim()
        If Not String.IsNullOrEmpty(empID) Then
            SQLStatement = "SELECT empID, Employee.firstName, Employee.lastName, Employee.Department, empStatus, startDate, position2, Supervisors.superFirstName, Supervisors.superLastName " &
            "FROM Employee " &
            "INNER JOIN Supervisors ON Employee.Department = Supervisors.Department " &
            "WHERE empID = @empID"

            Dim dtProperties As New DataTable
            Dim dbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(SQLStatement, connectionString)
            dbDataAdapter.SelectCommand.Parameters.AddWithValue("@empID", empID)
            dbDataAdapter.Fill(dtProperties)

            'Check if any rows were returned
            If dtProperties.Rows.Count > 0 Then
                idBox.Text = dtProperties.Rows(0)("empID").ToString()
                fNameBox.Text = dtProperties.Rows(0)("firstName").ToString()
                lNameBox.Text = dtProperties.Rows(0)("lastName").ToString()
                positionBox.Text = dtProperties.Rows(0)("position2").ToString()
                deptBox.Text = dtProperties.Rows(0)("Department").ToString()
                statusComboBox.SelectedItem = dtProperties.Rows(0)("empStatus").ToString()
                statusComboBox.SelectedItem = dtProperties.Rows(0)("empStatus").ToString()

                'Set the selected supervisor in the ComboBox
                Dim supervisorFirstName As String = dtProperties.Rows(0)("superFirstName").ToString()
                Dim supervisorLastName As String = dtProperties.Rows(0)("superLastName").ToString()
                Dim supervisorName As String = supervisorFirstName & " " & supervisorLastName
                supervisorComboBox.SelectedItem = supervisorName

                ' Convert the startDate value to a DateTime type
                Dim startDateValue As DateTime
                If DateTime.TryParse(dtProperties.Rows(0)("startDate").ToString(), startDateValue) Then
                    DateTimePicker1.Value = startDateValue
                Else
                    ' Handle invalid or null startDate values
                    DateTimePicker1.Value = DateTime.Today ' Set a default value, such as today's date
                End If
            Else
                '"No employee found with the provided empID."
                MessageBox.Show(empID & " was not found in the database.")
            End If
        Else
            MessageBox.Show("Please enter an employee ID.")
        End If
    End Sub

    Private Sub addNewButton_Click(sender As Object, e As EventArgs) Handles addNewButton.Click
        Dim empID As String = idBox.Text.Trim()
        Dim firstName As String = fNameBox.Text.Trim()
        Dim lastName As String = lNameBox.Text.Trim()
        Dim position As String = positionBox.Text.Trim()
        Dim startDate As String = DateTimePicker1.Text
        Dim status As String = statusComboBox.SelectedIndex
        Dim department As String = deptBox.Text.Trim()
        Dim supervisor As String = supervisorComboBox.SelectedItem

        ' Check if the required fields are filled
        If String.IsNullOrEmpty(empID) Or String.IsNullOrEmpty(firstName) Or String.IsNullOrEmpty(lastName) Or
            String.IsNullOrEmpty(position) Or String.IsNullOrEmpty(startDate) Or String.IsNullOrEmpty(status) Or
            String.IsNullOrEmpty(supervisor) Then
            MessageBox.Show("Please enter all the required information.")
            Return
        End If

        ' Construct the SQL INSERT statement
        SQLStatement = "INSERT INTO Employee (empID, firstName, lastName, position2, Department, startDate, empStatus) VALUES (@empID, @firstName, @lastName, @position, @Department, @startDate, @status)"

        ' Create a new command and assign the SQL statement and connection
        Dim dbCommand As New OleDbCommand(SQLStatement, dbConnection)

        ' Add parameters to the command
        dbCommand.Parameters.AddWithValue("@empID", empID)
        dbCommand.Parameters.AddWithValue("@firstName", firstName)
        dbCommand.Parameters.AddWithValue("@lastName", lastName)
        dbCommand.Parameters.AddWithValue("@position", position)
        dbCommand.Parameters.AddWithValue("@Department", department)
        dbCommand.Parameters.AddWithValue("@startDate", startDate)
        dbCommand.Parameters.AddWithValue("@status", status)
        'dbCommand.Parameters.AddWithValue("@supervisorId", supervisor)

        ' Open the database connection
        dbConnection.Open()

        Try
            ' Execute the command to insert the new employee
            dbCommand.ExecuteNonQuery()

            ' Display a success message
            MessageBox.Show("New employee added successfully.")

            ' Clear the input fields
            idBox.Text = ""
            fNameBox.Text = ""
            lNameBox.Text = ""
            positionBox.Text = ""
            DateTimePicker1.Value = DateTime.Today
            statusComboBox.SelectedIndex = 0
            supervisorComboBox.SelectedIndex = -1 ' Deselect the ComboBox

        Catch ex As Exception
            ' Display an error message if the insertion fails
            MessageBox.Show("Error adding new employee: " & ex.Message)
        Finally
            ' Close the database connection
            dbConnection.Close()
        End Try
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim empID As String = idBox.Text.Trim()
        Dim firstName As String = fNameBox.Text.Trim()
        Dim lastName As String = lNameBox.Text.Trim()
        Dim position As String = positionBox.Text.Trim()
        Dim startDate As String = DateTimePicker1.Text
        Dim status As String = statusComboBox.SelectedItem()
        Dim department As String = deptBox.Text.Trim()
        Dim supervisor As String = supervisorComboBox.SelectedItem

        ' Check if the required fields are filled
        If String.IsNullOrEmpty(empID) Or String.IsNullOrEmpty(firstName) Or String.IsNullOrEmpty(lastName) Or
            String.IsNullOrEmpty(position) Or String.IsNullOrEmpty(startDate) Or String.IsNullOrEmpty(status) Or
            String.IsNullOrEmpty(supervisor) Then
            MessageBox.Show("Please enter all the required information.")
            Return
        End If

        ' Construct the SQL UPDATE statement
        SQLStatement = "UPDATE Employee SET firstName = @firstName, lastName = @lastName, position2 = @position, " &
                       "Department = @Department, startDate = @startDate, empStatus = @status " &
                       "WHERE empID = @empID"

        ' Create a new command and assign the SQL statement and connection
        Dim dbCommand As New OleDbCommand(SQLStatement, dbConnection)

        ' Add parameters to the command
        dbCommand.Parameters.AddWithValue("@firstName", firstName)
        dbCommand.Parameters.AddWithValue("@lastName", lastName)
        dbCommand.Parameters.AddWithValue("@position", position)
        dbCommand.Parameters.AddWithValue("@Department", department)
        dbCommand.Parameters.AddWithValue("@startDate", startDate)
        dbCommand.Parameters.AddWithValue("@status", status)
        dbCommand.Parameters.AddWithValue("@empID", empID)

        ' Open the database connection
        dbConnection.Open()

        Try
            ' Execute the command to update the employee
            dbCommand.ExecuteNonQuery()

            ' Display a success message
            MessageBox.Show("Employee updated successfully.")

            ' Clear the input fields
            idBox.Text = ""
            fNameBox.Text = ""
            lNameBox.Text = ""
            positionBox.Text = ""
            deptBox.Text = ""
            searchBox.Text = ""
            DateTimePicker1.Value = Date.Today
            statusComboBox.SelectedIndex = 0
            supervisorComboBox.SelectedIndex = -1
            statusComboBox.SelectedIndex = -1


        Catch ex As Exception
            ' Display an error message if the update fails
            MessageBox.Show("Error updating employee: " & ex.Message)
        Finally
            ' Close the database connection
            dbConnection.Close()
        End Try
    End Sub

    Private Sub TimeCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeCardToolStripMenuItem.Click
        EZTimeCard.Show()
    End Sub

    Private Sub PhoneDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhoneDirectoryToolStripMenuItem.Click
        PhoneDirectory.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub EmployeeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class