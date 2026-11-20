
Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class Departments

    ' Runs when the Departments form opens
    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' =================================
        ' FORM SETTINGS
        ' =================================
        Me.BackColor = Color.FromArgb(230, 238, 247)
        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' =================================
        ' INPUT CONTROLS
        ' =================================
        txtDepartmentId.ReadOnly = True

        Dim inputControls As Control() = {
        txtDepartmentId,
        txtDepartmentName,
        txtDescription,
        txtSearch,
        cmbHeadOfDepartment
    }

        For Each ctrl As Control In inputControls
            ctrl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            ctrl.BackColor = Color.White
            ctrl.ForeColor = Color.FromArgb(40, 50, 65)
        Next

        ' =================================
        ' BUTTON COLORS
        ' =================================
        btnAdd.BackColor = Color.FromArgb(8, 126, 139)
        btnUpdate.BackColor = Color.FromArgb(20, 45, 78)
        btnDelete.BackColor = Color.FromArgb(201, 76, 76)
        btnClear.BackColor = Color.FromArgb(100, 116, 139)
        btnRefresh.BackColor = Color.FromArgb(52, 105, 160)
        btnBack.BackColor = Color.FromArgb(20, 45, 78)

        ' =================================
        ' BUTTON FORMATTING
        ' =================================
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

        ' =================================
        ' DATA GRID VIEW
        ' =================================
        dgvDepartments.BackgroundColor = Color.White
        dgvDepartments.BorderStyle = BorderStyle.None
        dgvDepartments.GridColor = Color.FromArgb(220, 228, 238)

        dgvDepartments.EnableHeadersVisualStyles = False

        dgvDepartments.ColumnHeadersDefaultCellStyle.BackColor =
        Color.FromArgb(20, 45, 78)

        dgvDepartments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgvDepartments.ColumnHeadersDefaultCellStyle.Font =
        New Font("Segoe UI", 10, FontStyle.Bold)

        dgvDepartments.DefaultCellStyle.Font =
        New Font("Segoe UI", 9, FontStyle.Regular)

        dgvDepartments.DefaultCellStyle.ForeColor =
        Color.FromArgb(40, 50, 65)

        dgvDepartments.DefaultCellStyle.SelectionBackColor =
        Color.FromArgb(8, 126, 139)

        dgvDepartments.DefaultCellStyle.SelectionForeColor = Color.White

        dgvDepartments.AlternatingRowsDefaultCellStyle.BackColor =
        Color.FromArgb(240, 245, 250)

        dgvDepartments.RowTemplate.Height = 35
        dgvDepartments.ColumnHeadersHeight = 40

        dgvDepartments.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect

        dgvDepartments.MultiSelect = False
        dgvDepartments.ReadOnly = True
        dgvDepartments.AllowUserToAddRows = False

        ' =================================
        ' LOAD DATA
        ' =================================
        LoadDoctors()
        LoadDepartments()

    End Sub

    ' Load doctors into the Head of Department ComboBox
    Private Sub LoadDoctors()
        Try
            Using conn As SqlConnection = DbConnection.GetConnection()

                Dim query As String =
                    "SELECT DoctorID, FirstName + ' ' + LastName AS DoctorName " &
                    "FROM Doctors ORDER BY FirstName, LastName"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()

                adapter.Fill(dt)

                cmbHeadOfDepartment.DataSource = dt
                cmbHeadOfDepartment.DisplayMember = "DoctorName"
                cmbHeadOfDepartment.ValueMember = "DoctorID"
                cmbHeadOfDepartment.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error loading doctors: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' Load departments into the DataGridView
    Private Sub LoadDepartments(Optional searchTerm As String = "")
        Try
            Using conn As SqlConnection = DbConnection.GetConnection()

                Dim query As String =
                    "SELECT d.DepartmentID, d.DepartmentName, " &
                    "d.Description, d.HeadOfDepartmentID, " &
                    "doc.FirstName + ' ' + doc.LastName AS HeadOfDepartment " &
                    "FROM Departments d " &
                    "LEFT JOIN Doctors doc " &
                    "ON d.HeadOfDepartmentID = doc.DoctorID"

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " WHERE d.DepartmentName LIKE @Search " &
                             "OR d.Description LIKE @Search " &
                             "OR doc.FirstName LIKE @Search " &
                             "OR doc.LastName LIKE @Search"
                End If

                Using cmd As New SqlCommand(query, conn)

                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue(
                            "@Search",
                            "%" & searchTerm.Trim() & "%"
                        )
                    End If

                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()

                    adapter.Fill(dt)

                    dgvDepartments.DataSource = Nothing
                    dgvDepartments.AutoGenerateColumns = True
                    dgvDepartments.Columns.Clear()
                    dgvDepartments.DataSource = dt
                    For Each col As DataGridViewColumn In dgvDepartments.Columns
                        Debug.WriteLine("Column Name: " & col.Name &
                    " | Header: " & col.HeaderText)
                    Next

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error loading departments: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Validate department name
        If String.IsNullOrWhiteSpace(txtDepartmentName.Text) Then
            MessageBox.Show("Please enter the department name.")
            txtDepartmentName.Focus()
            Exit Sub
        End If

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                "INSERT INTO Departments " &
                "(DepartmentName, Description, HeadOfDepartmentID) " &
                "VALUES (@DepartmentName, @Description, @HeadOfDepartmentID)"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                    "@DepartmentName",
                    txtDepartmentName.Text.Trim()
                )

                    cmd.Parameters.AddWithValue(
                    "@Description",
                    If(String.IsNullOrWhiteSpace(txtDescription.Text),
                       CType(DBNull.Value, Object),
                       txtDescription.Text.Trim())
                )

                    cmd.Parameters.AddWithValue(
                    "@HeadOfDepartmentID",
                    If(cmbHeadOfDepartment.SelectedIndex = -1,
                       CType(DBNull.Value, Object),
                       cmbHeadOfDepartment.SelectedValue)
                )

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show(
            "Department added successfully!",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            ClearFields()
            LoadDepartments()

        Catch ex As Exception
            MessageBox.Show(
            "Error adding department: " & ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub
    Private Sub ClearFields()

        txtDepartmentId.Clear()
        txtDepartmentName.Clear()
        txtDescription.Clear()
        cmbHeadOfDepartment.SelectedIndex = -1

        txtDepartmentName.Focus()

    End Sub
    '
    'UPDATE BUTTON
    '
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If String.IsNullOrWhiteSpace(txtDepartmentId.Text) Then
            MessageBox.Show("Please select a department from the table first.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtDepartmentName.Text) Then
            MessageBox.Show("Please enter the department name.")
            txtDepartmentName.Focus()
            Exit Sub
        End If

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                "UPDATE Departments SET " &
                "DepartmentName = @DepartmentName, " &
                "Description = @Description, " &
                "HeadOfDepartmentID = @HeadOfDepartmentID " &
                "WHERE DepartmentID = @DepartmentID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                    "@DepartmentID",
                    Convert.ToInt32(txtDepartmentId.Text)
                )

                    cmd.Parameters.AddWithValue(
                    "@DepartmentName",
                    txtDepartmentName.Text.Trim()
                )

                    cmd.Parameters.AddWithValue(
                    "@Description",
                    If(String.IsNullOrWhiteSpace(txtDescription.Text),
                       CType(DBNull.Value, Object),
                       txtDescription.Text.Trim())
                )

                    cmd.Parameters.AddWithValue(
                    "@HeadOfDepartmentID",
                    If(cmbHeadOfDepartment.SelectedIndex = -1,
                       CType(DBNull.Value, Object),
                       cmbHeadOfDepartment.SelectedValue)
                )

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Department updated successfully!")

            ClearFields()
            LoadDepartments()

        Catch ex As Exception
            MessageBox.Show(
            "Error updating department: " & ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub
    '
    'DEPARTMENT CLICKING
    '
    Private Sub dgvDepartments_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvDepartments.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow =
            dgvDepartments.Rows(e.RowIndex)

            txtDepartmentId.Text =
            row.Cells("DepartmentID").Value.ToString()

            txtDepartmentName.Text =
            row.Cells("DepartmentName").Value.ToString()

            If row.Cells("Description").Value IsNot DBNull.Value Then
                txtDescription.Text =
                row.Cells("Description").Value.ToString()
            Else
                txtDescription.Clear()
            End If

            If row.Cells("HeadOfDepartmentID").Value IsNot DBNull.Value Then
                cmbHeadOfDepartment.SelectedValue =
                Convert.ToInt32(row.Cells("HeadOfDepartmentID").Value)
            Else
                cmbHeadOfDepartment.SelectedIndex = -1
            End If

        End If

    End Sub
    '
    'BACK BUTTON
    '
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim dashboardForm As Form =
            Application.OpenForms("frmDashboard")

        If dashboardForm IsNot Nothing Then
            dashboardForm.Show()
            dashboardForm.BringToFront()
        End If

        Me.Close()

    End Sub

    '
    'DELETE BUTTON
    '
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If String.IsNullOrWhiteSpace(txtDepartmentId.Text) Then
            MessageBox.Show("Please select a department from the table first.")
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this department?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If confirm = DialogResult.No Then Exit Sub

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' Check whether doctors are assigned to this department
                Dim checkQuery As String =
                "SELECT COUNT(*) FROM Doctors WHERE DepartmentID = @DepartmentID"

                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue(
                    "@DepartmentID",
                    Convert.ToInt32(txtDepartmentId.Text)
                )

                    Dim doctorCount As Integer =
                    Convert.ToInt32(checkCmd.ExecuteScalar())

                    If doctorCount > 0 Then
                        MessageBox.Show(
                        "This department has doctors assigned to it. " &
                        "Reassign those doctors before deleting the department.",
                        "Cannot Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )
                        Exit Sub
                    End If
                End Using

                Dim deleteQuery As String =
                "DELETE FROM Departments WHERE DepartmentID = @DepartmentID"

                Using cmd As New SqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue(
                    "@DepartmentID",
                    Convert.ToInt32(txtDepartmentId.Text)
                )

                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MessageBox.Show("Department deleted successfully!")

            ClearFields()
            LoadDepartments()

        Catch ex As Exception
            MessageBox.Show(
            "Error deleting department: " & ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub
    '
    'CLEAR BUTTON
    '
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearFields()

    End Sub
    '
    'REFRESHBUTTON
    '
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        txtSearch.Clear()

        LoadDoctors()
        LoadDepartments()
        ClearFields()

        MessageBox.Show("Department records refreshed successfully!")

    End Sub

End Class
