Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class Doctors

    ' Runs automatically when the Doctors form opens
    Private Sub Doctors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
        LoadDoctors()
    End Sub

    ' 1. Load Departments into the ComboBox (Assumes a Departments table with DepartmentID and DepartmentName)
    Private Sub LoadDepartments()
        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                Dim query As String = "SELECT DepartmentID, DepartmentName FROM Departments"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cmbDepartment.DataSource = dt
                cmbDepartment.DisplayMember = "DepartmentName"
                cmbDepartment.ValueMember = "DepartmentID"
                cmbDepartment.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading departments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 2. Load all Doctors into the DataGridView
    Private Sub LoadDoctors(Optional searchTerm As String = "")
        Try
            Using conn As SqlConnection = DbConnection.GetConnection()

                Dim query As String =
                "SELECT d.DoctorID, d.FirstName, d.LastName, " &
                "d.Gender, d.Phone, d.Email, d.Specialization, " &
                "d.DepartmentID, dep.DepartmentName " &
                "FROM Doctors d " &
                "INNER JOIN Departments dep " &
                "ON d.DepartmentID = dep.DepartmentID"

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " WHERE d.FirstName LIKE @Search " &
                         "OR d.LastName LIKE @Search " &
                         "OR d.Specialization LIKE @Search " &
                         "OR d.Phone LIKE @Search " &
                         "OR dep.DepartmentName LIKE @Search"
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
                    dgvDoctors.DataSource = Nothing
                    dgvDoctors.AutoGenerateColumns = True
                    dgvDoctors.Columns.Clear()
                    dgvDoctors.DataSource = dt

                End Using
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

    ' 3. ADD a new Doctor
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then Exit Sub

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO Doctors (FirstName, LastName, Gender, Phone, Email, Specialization, DepartmentID) " &
                                      "VALUES (@FirstName, @LastName, @Gender, @Phone, @Email, @Specialization, @DepartmentID)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text.Trim())
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(cmbDepartment.SelectedValue))

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadDoctors()
        Catch ex As Exception
            MessageBox.Show("Error adding doctor: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 4. UPDATE an existing Doctor
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtDoctorId.Text) Then
            MessageBox.Show("Please select a doctor from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidateInputs() Then Exit Sub

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE Doctors SET FirstName=@FirstName, LastName=@LastName, Gender=@Gender, " &
                                      "Phone=@Phone, Email=@Email, Specialization=@Specialization, DepartmentID=@DepartmentID " &
                                      "WHERE DoctorID=@DoctorID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DoctorID", Convert.ToInt32(txtDoctorId.Text))
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text.Trim())
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(cmbDepartment.SelectedValue))

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Doctor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadDoctors()
        Catch ex As Exception
            MessageBox.Show("Error updating doctor: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 5. DELETE a Doctor
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtDoctorId.Text) Then
            MessageBox.Show("Please select a doctor from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM Doctors WHERE DoctorID=@DoctorID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DoctorID", Convert.ToInt32(txtDoctorId.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadDoctors()
        Catch ex As Exception
            MessageBox.Show("Error deleting doctor: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' VALIDATE doctor input fields
    Private Function ValidateInputs() As Boolean

        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("Please enter the doctor's first name.")
            txtFirstName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Please enter the doctor's last name.")
            txtLastName.Focus()
            Return False
        End If

        If cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select the doctor's gender.")
            cmbGender.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Please enter the doctor's phone number.")
            txtPhone.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter the doctor's email.")
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtSpecialization.Text) Then
            MessageBox.Show("Please enter the doctor's specialization.")
            txtSpecialization.Focus()
            Return False
        End If

        If cmbDepartment.SelectedIndex = -1 OrElse cmbDepartment.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a department.")
            cmbDepartment.Focus()
            Return False
        End If

        Return True

    End Function

    ' 6. CLEAR all inputs
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtDoctorId.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        cmbGender.SelectedIndex = -1
        txtPhone.Clear()
        txtEmail.Clear()
        txtSpecialization.Clear()
        cmbDepartment.SelectedIndex = -1
        txtFirstName.Focus()
    End Sub

    ' 7. Populate textboxes when clicking a row in the DataGridView
    Private Sub dgvDoctors_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoctors.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDoctors.Rows(e.RowIndex)

            txtDoctorId.Text = row.Cells("DoctorID").Value.ToString()
            txtFirstName.Text = row.Cells("FirstName").Value.ToString()
            txtLastName.Text = row.Cells("LastName").Value.ToString()
            cmbGender.Text = row.Cells("Gender").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtSpecialization.Text = row.Cells("Specialization").Value.ToString()

            If row.Cells("DepartmentID").Value IsNot DBNull.Value Then
                cmbDepartment.SelectedValue = Convert.ToInt32(row.Cells("DepartmentID").Value)
            End If
        End If
    End Sub


    ' 8. Live search filter
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDoctors(txtSearch.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim dashboardForm As Form =
            Application.OpenForms("frmDashboard")

        If dashboardForm IsNot Nothing Then
            dashboardForm.Show()
        End If

        Me.Close()

    End Sub
End Class