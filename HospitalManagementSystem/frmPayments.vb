Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class frmPayments
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
    ' LOAD APPOINTMENTS
    '
    Private Sub LoadAppointments()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
            "SELECT AppointmentID, " &
            "CAST(AppointmentID AS NVARCHAR(20)) + ' - ' + " &
            "CONVERT(NVARCHAR(10), AppointmentDate, 103) AS AppointmentInfo " &
            "FROM Appointments " &
            "ORDER BY AppointmentDate DESC"

            Using cmd As New SqlCommand(query, con)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                cmbAppointment.DataSource = dt
                cmbAppointment.DisplayMember = "AppointmentInfo"
                cmbAppointment.ValueMember = "AppointmentID"
                cmbAppointment.SelectedIndex = -1

            End Using
        End Using

    End Sub

    '
    ' LOAD PAYMENTS
    '
    Private Sub LoadPayments()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
            "SELECT p.PaymentID, " &
            "p.PatientID, " &
            "pt.FirstName + ' ' + pt.LastName AS PatientName, " &
            "p.AppointmentID, " &
            "p.Amount, " &
            "p.PaymentDate, " &
            "p.PaymentMethod, " &
            "p.PaymentStatus " &
            "FROM Payments p " &
            "INNER JOIN Patients pt ON p.PatientID = pt.PatientID " &
            "ORDER BY p.PaymentDate DESC"

            Using cmd As New SqlCommand(query, con)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                dgvPayments.DataSource = Nothing
                dgvPayments.AutoGenerateColumns = True
                dgvPayments.Columns.Clear()
                dgvPayments.DataSource = dt

            End Using
        End Using

    End Sub

    '
    ' FORM LOAD EVENT
    '
    Private Sub frmPayments_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        ' FORM STYLING
        Me.BackColor = Color.FromArgb(230, 238, 247)
        Me.Font = New Font("Segoe UI", 10)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' PAYMENT ID
        txtPaymentID.ReadOnly = True
        txtPaymentID.BackColor = Color.FromArgb(240, 244, 248)
        txtPaymentID.ForeColor = Color.FromArgb(45, 55, 72)

        ' INPUT CONTROLS
        Dim inputControls As Control() = {
        cmbPatient,
        cmbAppointment,
        cmbPaymentMethod,
        cmbPaymentStatus,
        txtAmount
    }

        For Each ctrl As Control In inputControls
            ctrl.Font = New Font("Segoe UI", 10)
            ctrl.BackColor = Color.White
            ctrl.ForeColor = Color.FromArgb(45, 55, 72)
        Next

        dtpPaymentDate.Font = New Font("Segoe UI", 10)

        ' PAYMENT DATE
        dtpPaymentDate.Format = DateTimePickerFormat.Short
        dtpPaymentDate.Value = Date.Today

        ' PAYMENT METHODS
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.AddRange({
        "Cash",
        "Card",
        "Mobile Money",
        "Bank Transfer"
    })

        cmbPaymentMethod.SelectedIndex = -1

        ' PAYMENT STATUS
        cmbPaymentStatus.Items.Clear()
        cmbPaymentStatus.Items.AddRange({
        "Pending",
        "Paid",
        "Failed",
        "Refunded"
    })

        cmbPaymentStatus.SelectedIndex = 0

        ' LOAD DATABASE RECORDS
        LoadPatients()
        LoadAppointments()
        LoadPayments()

        ' BUTTON STYLING

        btnAdd.BackColor = Color.FromArgb(8, 126, 139)
        btnUpdate.BackColor = Color.FromArgb(52, 105, 160)
        btnDelete.BackColor = Color.FromArgb(201, 76, 76)
        btnClear.BackColor = Color.FromArgb(100, 116, 139)
        btnRefresh.BackColor = Color.FromArgb(20, 45, 78)
        btnBack.BackColor = Color.FromArgb(100, 116, 139)

        Dim actionButtons As Button() = {
            btnAdd,
            btnUpdate,
            btnDelete,
            btnClear,
            btnRefresh,
            btnBack
        }

        For Each btn As Button In actionButtons
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand
        Next

        '
        ' DATAGRIDVIEW STYLING
        '

        With dgvPayments
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .GridColor = Color.FromArgb(220, 228, 238)

            .EnableHeadersVisualStyles = False

            ' COLUMN HEADERS
            .ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(20, 45, 78)

            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 10, FontStyle.Bold)

            .ColumnHeadersHeight = 40

            ' ROWS
            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .DefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 72)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(8, 126, 139)

            .DefaultCellStyle.SelectionForeColor = Color.White

            .AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 244, 248)

            .RowTemplate.Height = 35
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    ' ADD PAYMENT
    Private Sub btnAdd_Click(
    sender As Object,
    e As EventArgs
) Handles btnAdd.Click

        ' VALIDATE REQUIRED FIELDS
        If cmbPatient.SelectedIndex = -1 OrElse
       cmbPaymentMethod.SelectedIndex = -1 OrElse
       cmbPaymentStatus.SelectedIndex = -1 Then

            MessageBox.Show(
            "Please select a patient, payment method and payment status.",
            "Missing Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Return
        End If

        '
        ' VALIDATE AMOUNT
        '
        Dim amount As Decimal

        If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid payment amount greater than zero.")
            Return
        End If

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String =
                "INSERT INTO Payments " &
                "(PatientID, AppointmentID, Amount, PaymentDate, PaymentMethod, PaymentStatus) " &
                "VALUES (@PatientID, @AppointmentID, @Amount, @PaymentDate, @PaymentMethod, @PaymentStatus)"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@PatientID", CInt(cmbPatient.SelectedValue))

                    If cmbAppointment.SelectedIndex = -1 Then
                        cmd.Parameters.AddWithValue("@AppointmentID", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@AppointmentID", CInt(cmbAppointment.SelectedValue))
                    End If

                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text)
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show(
            "Payment registered successfully!",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            LoadPayments()

        Catch ex As Exception

            MessageBox.Show("Error registering payment: " & ex.Message)

        End Try

    End Sub

    '
    ' CLEAR FIELDS
    '
    Private Sub btnClear_Click(
    sender As Object,
    e As EventArgs
) Handles btnClear.Click

        txtPaymentID.Clear()

        cmbPatient.SelectedIndex = -1
        cmbAppointment.SelectedIndex = -1

        txtAmount.Clear()

        dtpPaymentDate.Value = Date.Today

        cmbPaymentMethod.SelectedIndex = -1
        cmbPaymentStatus.SelectedIndex = 0

        cmbPatient.Focus()

    End Sub

    '
    ' UPDATE PAYMENT
    '
    Private Sub btnUpdate_Click(
    sender As Object,
    e As EventArgs
) Handles btnUpdate.Click

        If String.IsNullOrWhiteSpace(txtPaymentID.Text) Then
            MessageBox.Show("Please select a payment to update.")
            Return
        End If

        If cmbPatient.SelectedIndex = -1 OrElse
       cmbPaymentMethod.SelectedIndex = -1 OrElse
       cmbPaymentStatus.SelectedIndex = -1 Then

            MessageBox.Show("Please complete all required fields.")
            Return
        End If

        Dim amount As Decimal

        If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid payment amount greater than zero.")
            Return
        End If

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String =
                "UPDATE Payments SET " &
                "PatientID = @PatientID, " &
                "AppointmentID = @AppointmentID, " &
                "Amount = @Amount, " &
                "PaymentDate = @PaymentDate, " &
                "PaymentMethod = @PaymentMethod, " &
                "PaymentStatus = @PaymentStatus " &
                "WHERE PaymentID = @PaymentID"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@PatientID", CInt(cmbPatient.SelectedValue))

                    If cmbAppointment.SelectedIndex = -1 Then
                        cmd.Parameters.AddWithValue("@AppointmentID", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@AppointmentID", CInt(cmbAppointment.SelectedValue))
                    End If

                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text)
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text)
                    cmd.Parameters.AddWithValue("@PaymentID", CInt(txtPaymentID.Text))

                    con.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Payment updated successfully!")
                        LoadPayments()
                    Else
                        MessageBox.Show("Payment not found.")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating payment: " & ex.Message)
        End Try

    End Sub

    '
    ' DATAGRIDVIEW ROW SELECTION
    '
    Private Sub dgvPayments_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvPayments.CellClick

        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow =
        dgvPayments.Rows(e.RowIndex)

        txtPaymentID.Text =
        row.Cells("PaymentID").Value.ToString()

        cmbPatient.SelectedValue =
        CInt(row.Cells("PatientID").Value)

        If IsDBNull(row.Cells("AppointmentID").Value) Then
            cmbAppointment.SelectedIndex = -1
        Else
            cmbAppointment.SelectedValue =
            CInt(row.Cells("AppointmentID").Value)
        End If

        txtAmount.Text =
        Convert.ToDecimal(row.Cells("Amount").Value).ToString("0.00")

        dtpPaymentDate.Value =
        CDate(row.Cells("PaymentDate").Value)

        cmbPaymentMethod.Text =
        row.Cells("PaymentMethod").Value.ToString()

        cmbPaymentStatus.Text =
        row.Cells("PaymentStatus").Value.ToString()

    End Sub

    '
    ' DELETE PAYMENT
    '
    Private Sub btnDelete_Click(
    sender As Object,
    e As EventArgs
) Handles btnDelete.Click

        If String.IsNullOrWhiteSpace(txtPaymentID.Text) Then
            MessageBox.Show("Please select a payment to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this payment?",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then Return

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String =
                "DELETE FROM Payments WHERE PaymentID = @PaymentID"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue(
                    "@PaymentID",
                    CInt(txtPaymentID.Text))

                    con.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then

                        MessageBox.Show("Payment deleted successfully!")

                        LoadPayments()
                        btnClear.PerformClick()

                    Else
                        MessageBox.Show("Payment not found.")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error deleting payment: " & ex.Message)
        End Try

    End Sub

    '
    ' REFRESH PAYMENTS
    '
    Private Sub btnRefresh_Click(
    sender As Object,
    e As EventArgs
) Handles btnRefresh.Click

        LoadPatients()
        LoadAppointments()
        LoadPayments()

        MessageBox.Show(
        "Payment records refreshed successfully!",
        "Refresh",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub

    '
    ' BACK TO DASHBOARD
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
