Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class frmPatients

    ' Runs automatically when the form opens
    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Gender options if not already added in the Designer
        If cmbGender.Items.Count = 0 Then
            cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        End If

        txtPatientID.ReadOnly = True
        LoadPatients()
    End Sub

    ' 1. Load all Patients into the DataGridView
    Private Sub LoadPatients()
        Try
            Using conn As SqlConnection = DbConnection.GetConnection()

                Dim query As String =
                "SELECT PatientID, " &
                "FirstName + ' ' + LastName AS FullName, " &
                "Gender, DateOfBirth, " &
                "Phone AS PhoneNumber, " &
                "Address, EmergencyContact " &
                "FROM dbo.Patients"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()

                adapter.Fill(dt)
                dgvPatients.AutoGenerateColumns = True
                dgvPatients.Columns.Clear()
                dgvPatients.DataSource = Nothing
                dgvPatients.DataSource = dt

            End Using

        Catch ex As Exception
            MessageBox.Show(
            "Error loading patients: " & ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try
    End Sub
    ' 2. ADD PATIENT button
    Private Sub btnAdd_Click(
    sender As Object,
    e As EventArgs
) Handles btnAdd.Click

        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
       String.IsNullOrWhiteSpace(cmbGender.Text) OrElse
       String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
       String.IsNullOrWhiteSpace(txtAddress.Text) Then

            MessageBox.Show("Please fill in all required fields.")
            Exit Sub
        End If

        Dim nameParts As String() =
        txtFullName.Text.Trim().Split(
            " "c,
            StringSplitOptions.RemoveEmptyEntries
        )

        If nameParts.Length < 2 Then
            MessageBox.Show("Please enter both first name and last name.")
            Exit Sub
        End If

        If dtpDateOfBirth.Value.Date > Date.Today Then
            MessageBox.Show("Date of birth cannot be in the future.")
            Exit Sub
        End If

        Dim firstName As String = nameParts(0)
        Dim lastName As String = String.Join(
        " ",
        nameParts,
        1,
        nameParts.Length - 1
    )

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "INSERT INTO dbo.Patients " &
                "(FirstName, LastName, Gender, DateOfBirth, " &
                "Phone, Address, EmergencyContact) " &
                "VALUES " &
                "(@FirstName, @LastName, @Gender, @DateOfBirth, " &
                "@Phone, @Address, @EmergencyContact)"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())

                    Dim emergency As Object =
                    If(String.IsNullOrWhiteSpace(txtEmergencyContact.Text),
                       CType(DBNull.Value, Object),
                       txtEmergencyContact.Text.Trim())

                    cmd.Parameters.AddWithValue("@EmergencyContact", emergency)

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show(
            "Patient registered successfully!",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            ClearFields()
            LoadPatients()

        Catch ex As Exception

            MessageBox.Show(
            "Error registering patient: " & ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub
    ' 3. UPDATE button
    Private Sub btnUpdate_Click(
    sender As Object,
    e As EventArgs
) Handles btnUpdate.Click

        If String.IsNullOrWhiteSpace(txtPatientID.Text) Then
            MessageBox.Show("Please select a patient first.")
            Exit Sub
        End If

        If Not ValidateInputs() Then Exit Sub

        Dim nameParts As String() =
        txtFullName.Text.Trim().Split(
            " "c,
            StringSplitOptions.RemoveEmptyEntries
        )

        If nameParts.Length < 2 Then
            MessageBox.Show("Please enter both first and last name.")
            Exit Sub
        End If

        Dim firstName As String = nameParts(0)
        Dim lastName As String = String.Join(
        " ",
        nameParts,
        1,
        nameParts.Length - 1
    )

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "UPDATE dbo.Patients SET " &
                "FirstName=@FirstName, LastName=@LastName, " &
                "Gender=@Gender, DateOfBirth=@DateOfBirth, " &
                "Phone=@Phone, Address=@Address, " &
                "EmergencyContact=@EmergencyContact " &
                "WHERE PatientID=@PatientID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                    "@PatientID",
                    Convert.ToInt32(txtPatientID.Text)
                )

                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())

                    Dim emergency As Object =
                    If(String.IsNullOrWhiteSpace(txtEmergencyContact.Text),
                       CType(DBNull.Value, Object),
                       txtEmergencyContact.Text.Trim())

                    cmd.Parameters.AddWithValue("@EmergencyContact", emergency)

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Patient updated successfully!")

            ClearFields()
            LoadPatients()

        Catch ex As Exception
            MessageBox.Show(
            "Error updating patient: " & ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub

    ' 4. DELETE button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtPatientID.Text) Then
            MessageBox.Show("Please select a patient from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM Patients WHERE PatientID=@PatientID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PatientID", Convert.ToInt32(txtPatientID.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadPatients()
        Catch ex As Exception
            MessageBox.Show("Error deleting patient: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 5. REFRESH button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPatients()
    End Sub

    ' 6. CLEAR FIELDS button
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()

        txtPatientID.Clear()
        txtFullName.Clear()
        cmbGender.SelectedIndex = -1
        dtpDateOfBirth.Value = DateTime.Now
        txtPhone.Clear()
        txtAddress.Clear()
        txtEmergencyContact.Clear()

        txtFullName.Focus()

    End Sub

    ' 7. BACK TO button (Returns to your Dashboard / Main Menu)
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim dashboardForm As Form =
        Application.OpenForms("frmDashboard")

        If dashboardForm IsNot Nothing Then
            dashboardForm.Show()
            dashboardForm.BringToFront()
        End If

        Me.Close()

    End Sub

    ' 8. Populate fields when a row is clicked in the DataGridView
    Private Sub dgvPatients_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvPatients.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow =
            dgvPatients.Rows(e.RowIndex)

            txtPatientID.Text =
            row.Cells("PatientID").Value.ToString()

            txtFullName.Text =
            row.Cells("FullName").Value.ToString()

            cmbGender.Text =
            row.Cells("Gender").Value.ToString()

            dtpDateOfBirth.Value =
            Convert.ToDateTime(row.Cells("DateOfBirth").Value)

            txtPhone.Text =
            row.Cells("PhoneNumber").Value.ToString()

            txtAddress.Text =
            row.Cells("Address").Value.ToString()

            txtEmergencyContact.Text =
            If(row.Cells("EmergencyContact").Value Is DBNull.Value,
               "",
               row.Cells("EmergencyContact").Value.ToString())

        End If

    End Sub
    ' 9. Input Validation
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           cmbGender.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) Then

            MessageBox.Show("Please fill in Full Name, Gender, and Phone Number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

End Class