Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class frmAppointments
    '
    ' LOAD PATIENTS
    '
    Private Sub LoadPatients()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
            "SELECT PatientID, FirstName + ' ' + LastName AS FullName " &
            "FROM Patients ORDER BY FirstName"

            Using cmd As New SqlCommand(query, con)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                cmbPatient.DataSource = dt
                cmbPatient.DisplayMember = "FullName"
                cmbPatient.ValueMember = "PatientID"
                cmbPatient.SelectedIndex = -1

            End Using
        End Using

    End Sub
    '
    ' LOAD DOCTORS
    '
    Private Sub LoadDoctors()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
            "SELECT DoctorID, FirstName + ' ' + LastName AS FullName " &
            "FROM Doctors ORDER BY FirstName"

            Using cmd As New SqlCommand(query, con)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                cmbDoctor.DataSource = dt
                cmbDoctor.DisplayMember = "FullName"
                cmbDoctor.ValueMember = "DoctorID"
                cmbDoctor.SelectedIndex = -1

            End Using
        End Using

    End Sub
    '
    ' LOAD APPOINTMENTS
    '
    Private Sub LoadAppointments()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
            "SELECT a.AppointmentID, " &
            "a.PatientID, " &
            "p.FirstName + ' ' + p.LastName AS PatientName, " &
            "a.DoctorID, " &
            "d.FirstName + ' ' + d.LastName AS DoctorName, " &
            "a.AppointmentDate, " &
            "a.AppointmentTime, " &
            "a.Reason, " &
            "a.Status " &
            "FROM Appointments a " &
            "INNER JOIN Patients p ON a.PatientID = p.PatientID " &
            "INNER JOIN Doctors d ON a.DoctorID = d.DoctorID " &
            "ORDER BY a.AppointmentDate DESC"

            Using cmd As New SqlCommand(query, con)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvAppointments.DataSource = Nothing
                dgvAppointments.AutoGenerateColumns = True
                dgvAppointments.Columns.Clear()
                dgvAppointments.DataSource = dt

            End Using
        End Using

    End Sub
    '
    'LOAD APPINTMENT WINOW FORM
    '
    Private Sub frmAppointments_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' FORM STYLING
        Me.BackColor = Color.FromArgb(230, 238, 247)
        Me.Font = New Font("Segoe UI", 10)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' APPOINTMENT ID
        txtAppointmentID.ReadOnly = True
        txtAppointmentID.BackColor = Color.FromArgb(240, 244, 248)
        txtAppointmentID.ForeColor = Color.FromArgb(45, 55, 72)

        ' INPUT CONTROLS
        Dim inputControls As Control() = {
            cmbPatient,
            cmbDoctor,
            cmbStatus,
            txtReason
        }

        For Each ctrl As Control In inputControls
            ctrl.Font = New Font("Segoe UI", 10)
            ctrl.BackColor = Color.White
            ctrl.ForeColor = Color.FromArgb(45, 55, 72)
        Next

        dtpAppointmentDate.Font = New Font("Segoe UI", 10)
        dtpAppointmentTime.Font = New Font("Segoe UI", 10)

        ' DATE PICKER
        dtpAppointmentDate.Format = DateTimePickerFormat.Short
        dtpAppointmentDate.MinDate = Date.Today

        ' TIME PICKER
        dtpAppointmentTime.Format = DateTimePickerFormat.Time
        dtpAppointmentTime.ShowUpDown = True

        ' STATUS OPTIONS
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({
            "Pending",
            "Approved",
            "Completed",
            "Cancelled"
        })

        cmbStatus.SelectedIndex = 0

        ' BUTTON COLOURS
        btnAdd.BackColor = Color.FromArgb(8, 126, 139)
        btnUpdate.BackColor = Color.FromArgb(20, 45, 78)
        btnDelete.BackColor = Color.FromArgb(201, 76, 76)
        btnClear.BackColor = Color.FromArgb(100, 116, 139)
        btnRefresh.BackColor = Color.FromArgb(52, 105, 160)
        btnBack.BackColor = Color.FromArgb(20, 45, 78)

        ' BUTTON STYLING
        Dim buttons As Button() = {
            btnAdd,
            btnUpdate,
            btnDelete,
            btnClear,
            btnRefresh,
            btnBack
        }

        For Each btn As Button In buttons
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand
        Next

        ' DATAGRIDVIEW STYLING
        dgvAppointments.BackgroundColor = Color.White
        dgvAppointments.BorderStyle = BorderStyle.None
        dgvAppointments.EnableHeadersVisualStyles = False

        dgvAppointments.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(20, 45, 78)

        dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White

        dgvAppointments.ColumnHeadersDefaultCellStyle.Font =
            New Font("Segoe UI", 10, FontStyle.Bold)

        dgvAppointments.DefaultCellStyle.Font =
            New Font("Segoe UI", 9)

        dgvAppointments.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(8, 126, 139)

        dgvAppointments.DefaultCellStyle.SelectionForeColor =
            Color.White

        dgvAppointments.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(240, 244, 248)

        dgvAppointments.RowTemplate.Height = 35
        dgvAppointments.ColumnHeadersHeight = 40

        dgvAppointments.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvAppointments.MultiSelect = False
        dgvAppointments.ReadOnly = True
        dgvAppointments.AllowUserToAddRows = False

        ' LOAD DATABASE RECORDS
        LoadPatients()
        LoadDoctors()
        LoadAppointments()

    End Sub

    '
    'ADD BUTTON
    '
    Private Sub btnAdd_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAdd.Click

        ' Validate required fields
        If cmbPatient.SelectedIndex = -1 OrElse
       cmbDoctor.SelectedIndex = -1 OrElse
       cmbStatus.SelectedIndex = -1 Then

            MessageBox.Show(
            "Please select a patient, doctor and appointment status.",
            "Missing Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Return
        End If

        If String.IsNullOrWhiteSpace(txtReason.Text) Then
            MessageBox.Show("Please enter the appointment reason.")
            Return
        End If

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String =
                "INSERT INTO Appointments " &
                "(PatientID, DoctorID, AppointmentDate, AppointmentTime, Reason, Status) " &
                "VALUES (@PatientID, @DoctorID, @Date, @Time, @Reason, @Status)"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@PatientID", CInt(cmbPatient.SelectedValue))
                    cmd.Parameters.AddWithValue("@DoctorID", CInt(cmbDoctor.SelectedValue))
                    cmd.Parameters.AddWithValue("@Date", dtpAppointmentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@Time", dtpAppointmentTime.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@Reason", txtReason.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show(
            "Appointment registered successfully!",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            LoadAppointments()

        Catch ex As Exception

            MessageBox.Show("Error registering appointment: " & ex.Message)

        End Try

    End Sub
    '
    'CLEAR
    '
    Private Sub btnClear_Click(
    sender As Object,
    e As EventArgs
) Handles btnClear.Click

        txtAppointmentID.Clear()

        cmbPatient.SelectedIndex = -1
        cmbDoctor.SelectedIndex = -1

        dtpAppointmentDate.Value = Date.Today
        dtpAppointmentTime.Value = Date.Now

        txtReason.Clear()

        cmbStatus.SelectedIndex = 0

        cmbPatient.Focus()

    End Sub
    '
    'UPDATE
    '
    Private Sub btnUpdate_Click(
    sender As Object,
    e As EventArgs
) Handles btnUpdate.Click

        If String.IsNullOrWhiteSpace(txtAppointmentID.Text) Then
            MessageBox.Show("Please select an appointment to update.")
            Return
        End If

        If cmbPatient.SelectedIndex = -1 OrElse
       cmbDoctor.SelectedIndex = -1 OrElse
       cmbStatus.SelectedIndex = -1 Then

            MessageBox.Show("Please complete all required fields.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtReason.Text) Then
            MessageBox.Show("Please enter the appointment reason.")
            Return
        End If

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String =
                "UPDATE Appointments SET " &
                "PatientID = @PatientID, " &
                "DoctorID = @DoctorID, " &
                "AppointmentDate = @Date, " &
                "AppointmentTime = @Time, " &
                "Reason = @Reason, " &
                "Status = @Status " &
                "WHERE AppointmentID = @AppointmentID"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@PatientID", CInt(cmbPatient.SelectedValue))
                    cmd.Parameters.AddWithValue("@DoctorID", CInt(cmbDoctor.SelectedValue))
                    cmd.Parameters.AddWithValue("@Date", dtpAppointmentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@Time", dtpAppointmentTime.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@Reason", txtReason.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@AppointmentID", CInt(txtAppointmentID.Text))

                    con.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Appointment updated successfully!")
                        LoadAppointments()
                    Else
                        MessageBox.Show("Appointment not found.")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating appointment: " & ex.Message)
        End Try

    End Sub
    '
    'DATAGRIDVIEW ROW SELECTION
    '
    Private Sub dgvAppointments_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvAppointments.CellClick

        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow =
            dgvAppointments.Rows(e.RowIndex)

        txtAppointmentID.Text =
            row.Cells("AppointmentID").Value.ToString()

        cmbPatient.SelectedValue =
            CInt(row.Cells("PatientID").Value)

        cmbDoctor.SelectedValue =
            CInt(row.Cells("DoctorID").Value)

        dtpAppointmentDate.Value =
            CDate(row.Cells("AppointmentDate").Value)

        dtpAppointmentTime.Value =
            Date.Today.Add(CType(row.Cells("AppointmentTime").Value, TimeSpan))

        txtReason.Text =
            row.Cells("Reason").Value.ToString()

        cmbStatus.Text =
            row.Cells("Status").Value.ToString()

    End Sub
    '
    'DELETE
    '
    Private Sub btnDelete_Click(
    sender As Object,
    e As EventArgs
) Handles btnDelete.Click

        If String.IsNullOrWhiteSpace(txtAppointmentID.Text) Then
            MessageBox.Show("Please select an appointment to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this appointment?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then Return

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String =
                    "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue(
                        "@AppointmentID",
                        CInt(txtAppointmentID.Text))

                    con.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Appointment deleted successfully!")
                        LoadAppointments()
                        btnClear.PerformClick()
                    Else
                        MessageBox.Show("Appointment not found.")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error deleting appointment: " & ex.Message)
        End Try

    End Sub
    '
    'REFRESH
    '
    Private Sub btnRefresh_Click(
    sender As Object,
    e As EventArgs
) Handles btnRefresh.Click

        LoadPatients()
        LoadDoctors()
        LoadAppointments()

        MessageBox.Show(
            "Appointment records refreshed successfully!",
            "Refresh",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub
    '
    '
    '
    Private Sub btnBack_Click(
    sender As Object,
    e As EventArgs
) Handles btnBack.Click

        Dim dashboard As frmDashboard =
            Application.OpenForms.OfType(Of frmDashboard)().FirstOrDefault()

        If dashboard IsNot Nothing Then
            dashboard.Show()
            dashboard.BringToFront()
        End If

        Me.Close()

    End Sub
End Class