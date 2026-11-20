Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmReports

    Private WithEvents reportPrinter As New PrintDocument()

    Private printRowIndex As Integer = 0


    '
    'LOAD WINDOW FORM
    '
    Private Sub frmReports_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        ' FORM STYLING
        Me.BackColor = Color.FromArgb(230, 238, 247)
        Me.Font = New Font("Segoe UI", 10)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' HEADING
        lblHeading.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblHeading.ForeColor = Color.FromArgb(20, 45, 78)
        lblHeading.BackColor = Color.Transparent

        ' LABEL STYLING
        Dim reportLabels As Label() = {
            lblReporttype,
            lblStartDate,
            lblEndDate,
            lblRecordCount
        }

        For Each lbl As Label In reportLabels
            lbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            lbl.ForeColor = Color.FromArgb(45, 60, 80)
        Next

        ' DROPDOWN STYLING
        With cmbReportType
            .Font = New Font("Segoe UI", 10)
            .BackColor = Color.White
            .ForeColor = Color.FromArgb(45, 60, 80)
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With

        ' DATE PICKER STYLING
        Dim datePickers As DateTimePicker() = {
            dtpStartDate,
            dtpEndDate
        }

        For Each picker As DateTimePicker In datePickers
            picker.Font = New Font("Segoe UI", 10)
            picker.CalendarForeColor = Color.FromArgb(20, 45, 78)
            picker.CalendarMonthBackground = Color.White
        Next


        ' REPORT TYPES
        cmbReportType.Items.Clear()

        cmbReportType.Items.AddRange({
        "Patient Report",
        "Doctor Report",
        "Appointment Report",
        "Payment Report"
    })

        cmbReportType.SelectedIndex = 0

        ' DATE FILTERS
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Format = DateTimePickerFormat.Short

        dtpStartDate.Value = Date.Today.AddMonths(-1)
        dtpEndDate.Value = Date.Today

        ' BUTTON STYLING
        ' BUTTON STYLING
        btnGenerate.BackColor = Color.FromArgb(8, 126, 139)
        btnExportPDF.BackColor = Color.FromArgb(52, 105, 160)
        btnBack.BackColor = Color.FromArgb(100, 116, 139)

        Dim reportButtons As Button() = {
            btnGenerate,
            btnExportPDF,
            btnBack
        }

        For Each btn As Button In reportButtons
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand
        Next

        ' REPORT TABLE
        ' REPORT TABLE STYLING
        With dgvReports
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False

            .ColumnHeadersDefaultCellStyle.BackColor =
        Color.FromArgb(20, 45, 78)

            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font =
        New Font("Segoe UI", 10, FontStyle.Bold)

            .DefaultCellStyle.Font =
        New Font("Segoe UI", 9)

            .DefaultCellStyle.ForeColor =
        Color.FromArgb(45, 60, 80)

            .DefaultCellStyle.SelectionBackColor =
        Color.FromArgb(8, 126, 139)

            .DefaultCellStyle.SelectionForeColor = Color.White

            .AlternatingRowsDefaultCellStyle.BackColor =
        Color.FromArgb(240, 244, 248)

            .RowTemplate.Height = 32
            .ColumnHeadersHeight = 40

            .AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill

            .SelectionMode =
        DataGridViewSelectionMode.FullRowSelect

            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
        lblRecordCount.Text = "Ready to generate reports"

    End Sub

    '
    ' GENERATE REPORT
    '
    Private Sub btnGenerate_Click(
    sender As Object,
    e As EventArgs
) Handles btnGenerate.Click

        If dtpStartDate.Value.Date > dtpEndDate.Value.Date Then
            MessageBox.Show(
            "Start date cannot be later than end date.",
            "Invalid Date Range",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
            Return
        End If

        Try

            Using con As SqlConnection = GetConnection()

                Dim query As String = ""

                Select Case cmbReportType.Text

                    Case "Patient Report"

                        query =
                        "SELECT PatientID, FirstName, LastName, " &
                        "Gender, DateOfBirth, Phone, Address, EmergencyContact " &
                        "FROM Patients " &
                        "WHERE DateOfBirth >= @StartDate " &
                        "AND DateOfBirth < DATEADD(DAY, 1, @EndDate) " &
                        "ORDER BY PatientID DESC"

                    Case "Doctor Report"

                        query =
                        "SELECT d.DoctorID, d.FirstName, d.LastName, " &
                        "d.Gender, d.Phone, d.Email, d.Specialization, " &
                        "dep.DepartmentName " &
                        "FROM Doctors d " &
                        "INNER JOIN Departments dep " &
                        "ON d.DepartmentID = dep.DepartmentID " &
                        "ORDER BY d.DoctorID DESC"

                    Case "Appointment Report"

                        query =
                        "SELECT a.AppointmentID, " &
                        "p.FirstName + ' ' + p.LastName AS PatientName, " &
                        "d.FirstName + ' ' + d.LastName AS DoctorName, " &
                        "a.AppointmentDate, a.AppointmentTime, " &
                        "a.Reason, a.Status " &
                        "FROM Appointments a " &
                        "INNER JOIN Patients p ON a.PatientID = p.PatientID " &
                        "INNER JOIN Doctors d ON a.DoctorID = d.DoctorID " &
                        "WHERE a.AppointmentDate >= @StartDate " &
                        "AND a.AppointmentDate <= @EndDate " &
                        "ORDER BY a.AppointmentDate DESC"

                    Case "Payment Report"

                        query =
                        "SELECT py.PaymentID, " &
                        "p.FirstName + ' ' + p.LastName AS PatientName, " &
                        "py.Amount, py.PaymentDate, " &
                        "py.PaymentMethod, py.PaymentStatus " &
                        "FROM Payments py " &
                        "INNER JOIN Patients p ON py.PatientID = p.PatientID " &
                        "WHERE py.PaymentDate >= @StartDate " &
                        "AND py.PaymentDate <= @EndDate " &
                        "ORDER BY py.PaymentDate DESC"

                    Case Else
                        MessageBox.Show("Please select a report type.")
                        Return

                End Select

                Using cmd As New SqlCommand(query, con)

                    If cmbReportType.Text <> "Doctor Report" Then
                        cmd.Parameters.AddWithValue(
                        "@StartDate",
                        dtpStartDate.Value.Date)

                        cmd.Parameters.AddWithValue(
                        "@EndDate",
                        dtpEndDate.Value.Date)
                    End If

                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvReports.DataSource = dt

                    lblRecordCount.Text =
                    "Total Records: " & dt.Rows.Count.ToString()

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
            "Error generating report: " & ex.Message,
            "Report Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub
    '
    'BACK BUTTON
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

    '
    'EXPORT TO PDF BUTTON
    '
    Private Sub btnExportPDF_Click(
    sender As Object,
    e As EventArgs
) Handles btnExportPDF.Click

        If dgvReports.Rows.Count = 0 Then
            MessageBox.Show(
            "Please generate a report before exporting.",
            "No Report Data",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
            Return
        End If

        Using printDialog As New PrintDialog()

            printDialog.Document = reportPrinter
            printDialog.AllowSomePages = False
            printDialog.UseEXDialog = True

            If printDialog.ShowDialog() = DialogResult.OK Then
                printRowIndex = 0
                reportPrinter.Print()
            End If

        End Using

    End Sub
    '
    'REPORT PRINTING LAYOUT
    '
    Private Sub reportPrinter_PrintPage(
    sender As Object,
    e As PrintPageEventArgs
) Handles reportPrinter.PrintPage

        Dim graphics As Graphics = e.Graphics

        Using titleFont As New Font("Segoe UI", 16, FontStyle.Bold),
              headerFont As New Font("Segoe UI", 9, FontStyle.Bold),
              bodyFont As New Font("Segoe UI", 8)

            Dim leftMargin As Integer = 40
            Dim topMargin As Integer = 40
            Dim rowHeight As Integer = 30
            Dim columnWidth As Integer =
                CInt((e.MarginBounds.Width) /
                Math.Max(1, dgvReports.Columns.GetColumnCount(
                    DataGridViewElementStates.Visible)))

            Dim y As Integer = topMargin

            graphics.DrawString(
                "HOSPITAL MANAGEMENT SYSTEM",
                titleFont,
                Brushes.Navy,
                leftMargin,
                y)

            y += 40

            graphics.DrawString(
                cmbReportType.Text,
                headerFont,
                Brushes.Black,
                leftMargin,
                y)

            y += 30

            ' PRINT COLUMN HEADERS
            Dim x As Integer = leftMargin

            For Each column As DataGridViewColumn In dgvReports.Columns

                If column.Visible Then
                    graphics.DrawString(
                        column.HeaderText,
                        headerFont,
                        Brushes.Black,
                        New RectangleF(x, y, columnWidth, rowHeight))

                    x += columnWidth
                End If

            Next

            y += rowHeight

            ' PRINT REPORT ROWS
            While printRowIndex < dgvReports.Rows.Count

                If y + rowHeight > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Return
                End If

                x = leftMargin

                For Each column As DataGridViewColumn In dgvReports.Columns

                    If column.Visible Then

                        Dim cellValue As String =
                            Convert.ToString(
                                dgvReports.Rows(printRowIndex).Cells(column.Index).Value)

                        graphics.DrawString(
                            cellValue,
                            bodyFont,
                            Brushes.Black,
                            New RectangleF(x, y, columnWidth, rowHeight))

                        x += columnWidth

                    End If

                Next

                y += rowHeight
                printRowIndex += 1

            End While

        End Using

        e.HasMorePages = False

    End Sub

End Class