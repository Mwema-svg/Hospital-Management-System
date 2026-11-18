Option Explicit On
Option Strict On

Public Class frmDashboard

    <System.ComponentModel.DesignerSerializationVisibility(
        System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property LoggedInUser As User

    Private Sub frmDashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        If LoggedInUser IsNot Nothing Then
            lblWelcome.Text =
                "Welcome, " & LoggedInUser.FullName &
                " | Role: " & LoggedInUser.Role
        Else
            lblWelcome.Text =
                "Welcome to the Hospital Management System"
        End If

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
End Class