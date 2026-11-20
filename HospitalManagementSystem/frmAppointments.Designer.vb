<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointments
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
        txtAppointmentID = New TextBox()
        cmbPatient = New ComboBox()
        cmbDoctor = New ComboBox()
        dtpAppointmentDate = New DateTimePicker()
        dtpAppointmentTime = New DateTimePicker()
        txtReason = New TextBox()
        cmbStatus = New ComboBox()
        dgvAppointments = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        btnBack = New Button()
        lblApppointmentID = New Label()
        lblPatient = New Label()
        lblDoctor = New Label()
        lblAppointmentDate = New Label()
        lblAppointmentTime = New Label()
        lblReason = New Label()
        lblStatus = New Label()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtAppointmentID
        ' 
        txtAppointmentID.Location = New Point(202, 69)
        txtAppointmentID.Name = "txtAppointmentID"
        txtAppointmentID.Size = New Size(150, 31)
        txtAppointmentID.TabIndex = 0
        ' 
        ' cmbPatient
        ' 
        cmbPatient.FormattingEnabled = True
        cmbPatient.Location = New Point(482, 69)
        cmbPatient.Name = "cmbPatient"
        cmbPatient.Size = New Size(150, 33)
        cmbPatient.TabIndex = 1
        ' 
        ' cmbDoctor
        ' 
        cmbDoctor.FormattingEnabled = True
        cmbDoctor.Location = New Point(803, 72)
        cmbDoctor.Name = "cmbDoctor"
        cmbDoctor.Size = New Size(150, 33)
        cmbDoctor.TabIndex = 2
        ' 
        ' dtpAppointmentDate
        ' 
        dtpAppointmentDate.Location = New Point(202, 111)
        dtpAppointmentDate.Name = "dtpAppointmentDate"
        dtpAppointmentDate.Size = New Size(150, 31)
        dtpAppointmentDate.TabIndex = 3
        ' 
        ' dtpAppointmentTime
        ' 
        dtpAppointmentTime.Format = DateTimePickerFormat.Time
        dtpAppointmentTime.Location = New Point(558, 115)
        dtpAppointmentTime.Name = "dtpAppointmentTime"
        dtpAppointmentTime.Size = New Size(150, 31)
        dtpAppointmentTime.TabIndex = 4
        ' 
        ' txtReason
        ' 
        txtReason.Location = New Point(171, 157)
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(150, 31)
        txtReason.TabIndex = 5
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(482, 155)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(150, 33)
        cmbStatus.TabIndex = 6
        ' 
        ' dgvAppointments
        ' 
        dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAppointments.Location = New Point(24, 210)
        dgvAppointments.Name = "dgvAppointments"
        dgvAppointments.RowHeadersWidth = 62
        dgvAppointments.Size = New Size(1144, 471)
        dgvAppointments.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(126, 697)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(281, 700)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(441, 700)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(803, 700)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 11
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(606, 703)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 31)
        btnRefresh.TabIndex = 12
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(973, 697)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 13
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblApppointmentID
        ' 
        lblApppointmentID.AutoSize = True
        lblApppointmentID.Location = New Point(24, 72)
        lblApppointmentID.Name = "lblApppointmentID"
        lblApppointmentID.Size = New Size(141, 25)
        lblApppointmentID.TabIndex = 14
        lblApppointmentID.Text = "Appointment ID"
        ' 
        ' lblPatient
        ' 
        lblPatient.AutoSize = True
        lblPatient.Location = New Point(384, 72)
        lblPatient.Name = "lblPatient"
        lblPatient.Size = New Size(65, 25)
        lblPatient.TabIndex = 15
        lblPatient.Text = "Patient"
        ' 
        ' lblDoctor
        ' 
        lblDoctor.AutoSize = True
        lblDoctor.Location = New Point(716, 75)
        lblDoctor.Name = "lblDoctor"
        lblDoctor.Size = New Size(67, 25)
        lblDoctor.TabIndex = 16
        lblDoctor.Text = "Doctor"
        ' 
        ' lblAppointmentDate
        ' 
        lblAppointmentDate.AutoSize = True
        lblAppointmentDate.Location = New Point(24, 115)
        lblAppointmentDate.Name = "lblAppointmentDate"
        lblAppointmentDate.Size = New Size(154, 25)
        lblAppointmentDate.TabIndex = 17
        lblAppointmentDate.Text = "Appoinment Date"
        ' 
        ' lblAppointmentTime
        ' 
        lblAppointmentTime.AutoSize = True
        lblAppointmentTime.Location = New Point(384, 116)
        lblAppointmentTime.Name = "lblAppointmentTime"
        lblAppointmentTime.Size = New Size(161, 25)
        lblAppointmentTime.TabIndex = 18
        lblAppointmentTime.Text = "Appointment Time"
        ' 
        ' lblReason
        ' 
        lblReason.AutoSize = True
        lblReason.Location = New Point(96, 163)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(69, 25)
        lblReason.TabIndex = 19
        lblReason.Text = "Reason"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(416, 158)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 25)
        lblStatus.TabIndex = 20
        lblStatus.Text = "Status"
        ' 
        ' frmAppointments
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1228, 754)
        Controls.Add(lblStatus)
        Controls.Add(lblReason)
        Controls.Add(lblAppointmentTime)
        Controls.Add(lblAppointmentDate)
        Controls.Add(lblDoctor)
        Controls.Add(lblPatient)
        Controls.Add(lblApppointmentID)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dgvAppointments)
        Controls.Add(cmbStatus)
        Controls.Add(txtReason)
        Controls.Add(dtpAppointmentTime)
        Controls.Add(dtpAppointmentDate)
        Controls.Add(cmbDoctor)
        Controls.Add(cmbPatient)
        Controls.Add(txtAppointmentID)
        Name = "frmAppointments"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Appointment Management"
        CType(dgvAppointments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAppointmentID As TextBox
    Friend WithEvents cmbPatient As ComboBox
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents dtpAppointmentTime As DateTimePicker
    Friend WithEvents txtReason As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblApppointmentID As Label
    Friend WithEvents lblPatient As Label
    Friend WithEvents lblDoctor As Label
    Friend WithEvents lblAppointmentDate As Label
    Friend WithEvents lblAppointmentTime As Label
    Friend WithEvents lblReason As Label
    Friend WithEvents lblStatus As Label
End Class
