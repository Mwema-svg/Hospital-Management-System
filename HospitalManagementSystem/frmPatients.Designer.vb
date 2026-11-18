<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        grpPatientDetails = New GroupBox()
        lblEmergencyContact = New Label()
        txtEmergencyContact = New TextBox()
        txtAddress = New TextBox()
        txtPhone = New TextBox()
        dtpDateOfBirth = New DateTimePicker()
        cmbGender = New ComboBox()
        txtFullName = New TextBox()
        txtPatientID = New TextBox()
        lblAddress = New Label()
        lblPhoneNumber = New Label()
        lblDateOfBirth = New Label()
        lblGender = New Label()
        lblFullName = New Label()
        lblPatientID = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        btnBack = New Button()
        txtSearch = New Label()
        dgvPatients = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        UserIDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        UsernameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        PasswordHashDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        FullNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        RoleDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        IsActiveDataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        UserBindingSource = New BindingSource(components)
        grpPatientDetails.SuspendLayout()
        CType(dgvPatients, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpPatientDetails
        ' 
        grpPatientDetails.Controls.Add(lblEmergencyContact)
        grpPatientDetails.Controls.Add(txtEmergencyContact)
        grpPatientDetails.Controls.Add(txtAddress)
        grpPatientDetails.Controls.Add(txtPhone)
        grpPatientDetails.Controls.Add(dtpDateOfBirth)
        grpPatientDetails.Controls.Add(cmbGender)
        grpPatientDetails.Controls.Add(txtFullName)
        grpPatientDetails.Controls.Add(txtPatientID)
        grpPatientDetails.Controls.Add(lblAddress)
        grpPatientDetails.Controls.Add(lblPhoneNumber)
        grpPatientDetails.Controls.Add(lblDateOfBirth)
        grpPatientDetails.Controls.Add(lblGender)
        grpPatientDetails.Controls.Add(lblFullName)
        grpPatientDetails.Controls.Add(lblPatientID)
        grpPatientDetails.Location = New Point(25, 100)
        grpPatientDetails.Margin = New Padding(4)
        grpPatientDetails.Name = "grpPatientDetails"
        grpPatientDetails.Padding = New Padding(4)
        grpPatientDetails.Size = New Size(1300, 288)
        grpPatientDetails.TabIndex = 0
        grpPatientDetails.TabStop = False
        grpPatientDetails.Text = "Patient Details"
        ' 
        ' lblEmergencyContact
        ' 
        lblEmergencyContact.AutoSize = True
        lblEmergencyContact.Location = New Point(8, 252)
        lblEmergencyContact.Margin = New Padding(4, 0, 4, 0)
        lblEmergencyContact.Name = "lblEmergencyContact"
        lblEmergencyContact.Size = New Size(165, 25)
        lblEmergencyContact.TabIndex = 13
        lblEmergencyContact.Text = "Emergency Conatct"
        ' 
        ' txtEmergencyContact
        ' 
        txtEmergencyContact.Location = New Point(181, 246)
        txtEmergencyContact.Margin = New Padding(4)
        txtEmergencyContact.Name = "txtEmergencyContact"
        txtEmergencyContact.Size = New Size(365, 31)
        txtEmergencyContact.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(806, 200)
        txtAddress.Margin = New Padding(4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(423, 31)
        txtAddress.TabIndex = 11
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(151, 191)
        txtPhone.Margin = New Padding(4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(365, 31)
        txtPhone.TabIndex = 10
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Format = DateTimePickerFormat.Short
        dtpDateOfBirth.Location = New Point(806, 121)
        dtpDateOfBirth.Margin = New Padding(4)
        dtpDateOfBirth.MaximumSize = New Size(124, 100)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(124, 31)
        dtpDateOfBirth.TabIndex = 9
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(151, 110)
        cmbGender.Margin = New Padding(4)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(365, 33)
        cmbGender.TabIndex = 8
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(806, 38)
        txtFullName.Margin = New Padding(4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(423, 31)
        txtFullName.TabIndex = 7
        ' 
        ' txtPatientID
        ' 
        txtPatientID.Location = New Point(151, 32)
        txtPatientID.Margin = New Padding(4)
        txtPatientID.Name = "txtPatientID"
        txtPatientID.ReadOnly = True
        txtPatientID.Size = New Size(365, 31)
        txtPatientID.TabIndex = 6
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(675, 200)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(77, 25)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Address"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(8, 200)
        lblPhoneNumber.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(132, 25)
        lblPhoneNumber.TabIndex = 4
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Location = New Point(675, 121)
        lblDateOfBirth.Margin = New Padding(4, 0, 4, 0)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(115, 25)
        lblDateOfBirth.TabIndex = 3
        lblDateOfBirth.Text = "Date Of Birth"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(8, 121)
        lblGender.Margin = New Padding(4, 0, 4, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(675, 41)
        lblFullName.Margin = New Padding(4, 0, 4, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(91, 25)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full Name"
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Location = New Point(8, 41)
        lblPatientID.Margin = New Padding(4, 0, 4, 0)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(88, 25)
        lblPatientID.TabIndex = 0
        lblPatientID.Text = "Patient ID"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(32, 400)
        btnAdd.Margin = New Padding(4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(118, 36)
        btnAdd.TabIndex = 1
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(831, 400)
        btnUpdate.Margin = New Padding(4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(118, 36)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(35, 488)
        btnDelete.Margin = New Padding(4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(118, 36)
        btnDelete.TabIndex = 3
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(839, 488)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(118, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(440, 400)
        btnRefresh.Margin = New Padding(4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(118, 36)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(440, 488)
        btnBack.Margin = New Padding(4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(118, 36)
        btnBack.TabIndex = 6
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.AutoSize = True
        txtSearch.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(25, 552)
        txtSearch.Margin = New Padding(4, 0, 4, 0)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(217, 38)
        txtSearch.TabIndex = 7
        txtSearch.Text = "Search Patients"
        ' 
        ' dgvPatients
        ' 
        dgvPatients.AllowUserToAddRows = False
        dgvPatients.AutoGenerateColumns = False
        dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPatients.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, UserIDDataGridViewTextBoxColumn, UsernameDataGridViewTextBoxColumn, PasswordHashDataGridViewTextBoxColumn, FullNameDataGridViewTextBoxColumn, RoleDataGridViewTextBoxColumn, IsActiveDataGridViewCheckBoxColumn})
        dgvPatients.DataSource = UserBindingSource
        dgvPatients.Location = New Point(35, 622)
        dgvPatients.Margin = New Padding(4)
        dgvPatients.MultiSelect = False
        dgvPatients.Name = "dgvPatients"
        dgvPatients.ReadOnly = True
        dgvPatients.RowHeadersWidth = 51
        dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPatients.Size = New Size(1400, 185)
        dgvPatients.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "UserID"
        Column1.HeaderText = "PatientID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "UserID"
        Column2.HeaderText = "Full Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "UserID"
        Column3.HeaderText = "Gender"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "UserID"
        Column4.HeaderText = "Date Of Birth"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "UserID"
        Column5.HeaderText = "Phone Number"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "UserID"
        Column6.HeaderText = "Address"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Emergency Contact"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' UserIDDataGridViewTextBoxColumn
        ' 
        UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        UserIDDataGridViewTextBoxColumn.MinimumWidth = 8
        UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        UserIDDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' UsernameDataGridViewTextBoxColumn
        ' 
        UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        UsernameDataGridViewTextBoxColumn.MinimumWidth = 8
        UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        UsernameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' PasswordHashDataGridViewTextBoxColumn
        ' 
        PasswordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash"
        PasswordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash"
        PasswordHashDataGridViewTextBoxColumn.MinimumWidth = 8
        PasswordHashDataGridViewTextBoxColumn.Name = "PasswordHashDataGridViewTextBoxColumn"
        PasswordHashDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' FullNameDataGridViewTextBoxColumn
        ' 
        FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        FullNameDataGridViewTextBoxColumn.MinimumWidth = 8
        FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        FullNameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' RoleDataGridViewTextBoxColumn
        ' 
        RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
        RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        RoleDataGridViewTextBoxColumn.MinimumWidth = 8
        RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        RoleDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' IsActiveDataGridViewCheckBoxColumn
        ' 
        IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive"
        IsActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive"
        IsActiveDataGridViewCheckBoxColumn.MinimumWidth = 8
        IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        ' 
        ' UserBindingSource
        ' 
        UserBindingSource.DataSource = GetType(User)
        ' 
        ' frmPatients
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1529, 1040)
        Controls.Add(dgvPatients)
        Controls.Add(txtSearch)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(grpPatientDetails)
        Margin = New Padding(4)
        Name = "frmPatients"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Patient Management"
        grpPatientDetails.ResumeLayout(False)
        grpPatientDetails.PerformLayout()
        CType(dgvPatients, ComponentModel.ISupportInitialize).EndInit()
        CType(UserBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpPatientDetails As GroupBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearch As Label
    Friend WithEvents dgvPatients As DataGridView
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents lblEmergencyContact As Label
    Friend WithEvents txtEmergencyContact As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordHashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
