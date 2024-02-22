Public Class Form1
    Dim Messages() As String = {"Remember to keep all employee data updated. 
The system relies on accurate information to function optimally.", "Check the Payroll screen regularly for any discrepancies.
Early detection of errors helps ensure smooth operations.", "Don't forget to log out of the system 
after each session to maintain data security."}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        messageTimer.Start()
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(Button1, "Employee Database")
        toolTip.SetToolTip(Button2, "Phone Directory")
        toolTip.SetToolTip(Button3, "Time Card")
    End Sub

    Private Sub EmployeeScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeScreenToolStripMenuItem.Click
        EmployeeScreen.Show()
    End Sub

    Private Sub TimeCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeCardToolStripMenuItem.Click
        TimeCard.Show()
    End Sub

    Private Sub PhoneDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhoneDirectoryToolStripMenuItem.Click
        PhoneDirectory.Show()
    End Sub

    Private Sub EZTimeCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EZTimeCardToolStripMenuItem.Click
        EZTimeCard.Show()
    End Sub

    Private Sub messageTimer_Tick(sender As Object, e As EventArgs) Handles messageTimer.Tick
        Static currentIndex As Integer = 1

        messageLabel.Text = Messages(currentIndex)
        currentIndex += 1
        If currentIndex >= Messages.Length Then
            currentIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeScreen.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PhoneDirectory.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EZTimeCard.Show()
    End Sub
End Class
