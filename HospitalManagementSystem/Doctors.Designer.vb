<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctors
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
        lblDoctorId = New Label()
        lblFirstName = New Label()
        lbllastName = New Label()
        lblGender = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        lblSpecialization = New Label()
        lblDepartment = New Label()
        txtDoctorId = New TextBox()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtSpecialization = New TextBox()
        cmbDepartment = New ComboBox()
        cmbGender = New ComboBox()
        lblDoctorInformation = New LinkLabel()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        txtSearch = New TextBox()
        lblSearch = New LinkLabel()
        dgvDoctors = New DataGridView()
        btnBack = New Button()
        CType(dgvDoctors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDoctorId
        ' 
        lblDoctorId.AutoSize = True
        lblDoctorId.Location = New Point(34, 160)
        lblDoctorId.Name = "lblDoctorId"
        lblDoctorId.Size = New Size(95, 25)
        lblDoctorId.TabIndex = 0
        lblDoctorId.Text = "Doctor  ID"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(32, 226)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(97, 25)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name"
        ' 
        ' lbllastName
        ' 
        lbllastName.AutoSize = True
        lbllastName.Location = New Point(34, 298)
        lbllastName.Name = "lbllastName"
        lbllastName.Size = New Size(95, 25)
        lbllastName.TabIndex = 17
        lbllastName.Text = "Last Name"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(60, 372)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 3
        lblGender.Text = "Gender"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(67, 450)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(62, 25)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(75, 504)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email"
        ' 
        ' lblSpecialization
        ' 
        lblSpecialization.AutoSize = True
        lblSpecialization.Location = New Point(10, 594)
        lblSpecialization.Name = "lblSpecialization"
        lblSpecialization.Size = New Size(119, 25)
        lblSpecialization.TabIndex = 6
        lblSpecialization.Text = "Specialization"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Location = New Point(14, 659)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(112, 25)
        lblDepartment.TabIndex = 7
        lblDepartment.Text = "Department "
        ' 
        ' txtDoctorId
        ' 
        txtDoctorId.Location = New Point(158, 145)
        txtDoctorId.Name = "txtDoctorId"
        txtDoctorId.Size = New Size(150, 31)
        txtDoctorId.TabIndex = 8
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(158, 220)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(150, 31)
        txtFirstName.TabIndex = 9
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(158, 292)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(150, 31)
        txtLastName.TabIndex = 10
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(158, 435)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(158, 501)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(177, 31)
        txtEmail.TabIndex = 13
        ' 
        ' txtSpecialization
        ' 
        txtSpecialization.Location = New Point(158, 591)
        txtSpecialization.Name = "txtSpecialization"
        txtSpecialization.Size = New Size(150, 31)
        txtSpecialization.TabIndex = 14
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.Location = New Point(158, 651)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(150, 33)
        cmbDepartment.TabIndex = 15
        ' 
        ' cmbGender
        ' 
        cmbGender.AllowDrop = True
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(158, 364)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(182, 33)
        cmbGender.TabIndex = 16
        ' 
        ' lblDoctorInformation
        ' 
        lblDoctorInformation.AutoSize = True
        lblDoctorInformation.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDoctorInformation.Location = New Point(401, 21)
        lblDoctorInformation.Name = "lblDoctorInformation"
        lblDoctorInformation.Size = New Size(337, 38)
        lblDoctorInformation.TabIndex = 18
        lblDoctorInformation.TabStop = True
        lblDoctorInformation.Text = "DOCTOR INFORMATION"
        lblDoctorInformation.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(131, 716)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 19
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(318, 716)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(511, 716)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 21
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(716, 716)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 22
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(738, 71)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(150, 31)
        txtSearch.TabIndex = 23
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(434, 71)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(278, 25)
        lblSearch.TabIndex = 24
        lblSearch.TabStop = True
        lblSearch.Text = "Search By Name or Specialization:"
        ' 
        ' dgvDoctors
        ' 
        dgvDoctors.AllowDrop = True
        dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDoctors.Location = New Point(401, 123)
        dgvDoctors.Name = "dgvDoctors"
        dgvDoctors.ReadOnly = True
        dgvDoctors.RowHeadersWidth = 62
        dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDoctors.Size = New Size(1303, 561)
        dgvDoctors.TabIndex = 25
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(885, 716)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 26
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Doctors
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1716, 762)
        Controls.Add(btnBack)
        Controls.Add(dgvDoctors)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(lblDoctorInformation)
        Controls.Add(cmbGender)
        Controls.Add(cmbDepartment)
        Controls.Add(txtSpecialization)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(txtDoctorId)
        Controls.Add(lblDepartment)
        Controls.Add(lblSpecialization)
        Controls.Add(lblEmail)
        Controls.Add(lblPhone)
        Controls.Add(lblGender)
        Controls.Add(lbllastName)
        Controls.Add(lblFirstName)
        Controls.Add(lblDoctorId)
        Name = "Doctors"
        Text = "Doctors"
        CType(dgvDoctors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDoctorId As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbllastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSpecialization As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtDoctorId As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSpecialization As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblDoctorInformation As LinkLabel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As LinkLabel
    Friend WithEvents dgvDoctors As DataGridView
    Friend WithEvents btnBack As Button
End Class
