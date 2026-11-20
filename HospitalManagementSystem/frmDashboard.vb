Option Explicit On
Option Strict On

Public Class frmDashboard

    <System.ComponentModel.DesignerSerializationVisibility(
        System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property LoggedInUser As User

    '
    ' FORM LOAD EVENT
    '

    Private Sub frmDashboard_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        ' FORM SETTINGS
        Me.BackColor = Color.FromArgb(230, 238, 247)
        Me.Size = New Size(1250, 810)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.WindowState = FormWindowState.Maximized

        ' SIDEBAR
        Dim sidebar As New Panel()
        sidebar.Name = "pnlSidebar"
        sidebar.Size = New Size(250, Me.ClientSize.Height)
        sidebar.Location = New Point(0, 0)
        sidebar.BackColor = Color.FromArgb(20, 45, 78)

        Me.Controls.Add(sidebar)
        sidebar.SendToBack()
        sidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left

        ' DASHBOARD HEADING
        lblHeading.Text = "HOSPITAL MANAGEMENT"
        lblHeading.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblHeading.ForeColor = Color.White
        lblHeading.BackColor = Color.FromArgb(20, 45, 78)
        lblHeading.Location = New Point(15, 35)
        lblHeading.Size = New Size(220, 65)
        lblHeading.TextAlign = ContentAlignment.MiddleCenter

        sidebar.Controls.Add(lblHeading)
        lblHeading.BringToFront()

        ' WELCOME MESSAGE
        If LoggedInUser IsNot Nothing Then
            lblWelcome.Text = "Welcome, " & LoggedInUser.FullName &
                          " | Role: " & LoggedInUser.Role
        Else
            lblWelcome.Text = "Welcome to the Hospital Management System"
        End If

        lblWelcome.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(20, 45, 78)
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Location = New Point(290, 60)
        lblWelcome.Size = New Size(900, 50)
        lblWelcome.TextAlign = ContentAlignment.MiddleLeft

        ' NAVIGATION BUTTONS
        btnPatients.Location = New Point(15, 160)
        btnDoctors.Location = New Point(15, 240)
        btnDepartments.Location = New Point(15, 320)
        btnAppointments.Location = New Point(15, 400)
        btnPayments.Location = New Point(15, 480)
        btnReports.Location = New Point(15, 560)

        Dim navigationButtons As Button() = {
        btnPatients,
        btnDoctors,
        btnDepartments,
        btnAppointments,
        btnPayments,
        btnReports
    }

        For Each btn As Button In navigationButtons
            sidebar.Controls.Add(btn)
            btn.Size = New Size(220, 60)
            btn.BackColor = Color.FromArgb(8, 126, 139)
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand
            btn.BringToFront()
        Next

        ' LOGOUT BUTTON
        sidebar.Controls.Add(btnLogout)

        btnLogout.Size = New Size(220, 50)
        btnLogout.Location = New Point(
        15,
        sidebar.ClientSize.Height - btnLogout.Height - 30
    )
        btnLogout.BackColor = Color.FromArgb(201, 76, 76)
        btnLogout.ForeColor = Color.White
        btnLogout.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.Cursor = Cursors.Hand
        btnLogout.BringToFront()

        AddHandler Me.Resize,
        Sub(resizeSender, resizeEvent)
            sidebar.Height = Me.ClientSize.Height
            btnLogout.Top = sidebar.ClientSize.Height - btnLogout.Height - 30
        End Sub

    End Sub




    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub


    Private Sub btnPatients_Click(
    sender As Object,
    e As EventArgs
) Handles btnPatients.Click

        Dim patientsForm As New frmPatients()
        patientsForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnDoctors_Click(
    sender As Object,
    e As EventArgs
) Handles btnDoctors.Click

        Dim doctorsForm As New Doctors()
        doctorsForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnDepartments_Click(
    sender As Object,
    e As EventArgs
) Handles btnDepartments.Click

        Dim departmentsForm As New Departments()
        departmentsForm.Show()
        Me.Hide()

    End Sub
    '
    'APPOINTMENTS BUTTON
    '
    Private Sub btnAppointments_Click(
    sender As Object,
    e As EventArgs
) Handles btnAppointments.Click

        Dim appointmentsForm As New frmAppointments()
        appointmentsForm.Show()
        Me.Hide()

    End Sub

    '
    ' BUTTON TO OPEN PAYMENTS FORM
    '
    Private Sub btnPayments_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPayments.Click

        Dim paymentsForm As New frmPayments()

        paymentsForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnReports_Click(
    sender As Object,
    e As EventArgs
) Handles btnReports.Click

        Dim reportsForm As New frmReports()
        reportsForm.Show()
        Me.Hide()

    End Sub
End Class