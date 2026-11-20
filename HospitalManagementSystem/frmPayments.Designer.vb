<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        lblHeading = New Label()
        txtPaymentID = New TextBox()
        cmbPatient = New ComboBox()
        dtpPaymentDate = New DateTimePicker()
        dgvPayments = New DataGridView()
        lblPaymentID = New Label()
        lblPatient = New Label()
        lblAppointment = New Label()
        lblAmount = New Label()
        lblPaymentDate = New Label()
        lblPaymentMethod = New Label()
        lblPaymentStatus = New Label()
        cmbAppointment = New ComboBox()
        txtAmount = New TextBox()
        cmbPaymentMethod = New ComboBox()
        cmbPaymentStatus = New ComboBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        btnBack = New Button()
        CType(dgvPayments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Location = New Point(459, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(215, 25)
        lblHeading.TabIndex = 0
        lblHeading.Text = "PAYMENT MANAGEMENT"
        ' 
        ' txtPaymentID
        ' 
        txtPaymentID.Location = New Point(175, 60)
        txtPaymentID.Name = "txtPaymentID"
        txtPaymentID.Size = New Size(150, 31)
        txtPaymentID.TabIndex = 1
        ' 
        ' cmbPatient
        ' 
        cmbPatient.FormattingEnabled = True
        cmbPatient.Location = New Point(727, 63)
        cmbPatient.Name = "cmbPatient"
        cmbPatient.Size = New Size(182, 33)
        cmbPatient.TabIndex = 2
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Location = New Point(175, 145)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(300, 31)
        dtpPaymentDate.TabIndex = 3
        dtpPaymentDate.Value = New Date(2026, 11, 19, 0, 0, 0, 0)
        ' 
        ' dgvPayments
        ' 
        dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayments.Location = New Point(12, 271)
        dgvPayments.Name = "dgvPayments"
        dgvPayments.RowHeadersWidth = 62
        dgvPayments.Size = New Size(1204, 481)
        dgvPayments.TabIndex = 4
        ' 
        ' lblPaymentID
        ' 
        lblPaymentID.AutoSize = True
        lblPaymentID.Location = New Point(26, 63)
        lblPaymentID.Name = "lblPaymentID"
        lblPaymentID.Size = New Size(103, 25)
        lblPaymentID.TabIndex = 5
        lblPaymentID.Text = "Payment ID"
        ' 
        ' lblPatient
        ' 
        lblPatient.AutoSize = True
        lblPatient.Location = New Point(591, 66)
        lblPatient.Name = "lblPatient"
        lblPatient.Size = New Size(65, 25)
        lblPatient.TabIndex = 6
        lblPatient.Text = "Patient"
        ' 
        ' lblAppointment
        ' 
        lblAppointment.AutoSize = True
        lblAppointment.Location = New Point(26, 105)
        lblAppointment.Name = "lblAppointment"
        lblAppointment.Size = New Size(118, 25)
        lblAppointment.TabIndex = 7
        lblAppointment.Text = "Appointment"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(591, 111)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(77, 25)
        lblAmount.TabIndex = 8
        lblAmount.Text = "Amount"
        ' 
        ' lblPaymentDate
        ' 
        lblPaymentDate.AutoSize = True
        lblPaymentDate.Location = New Point(22, 151)
        lblPaymentDate.Name = "lblPaymentDate"
        lblPaymentDate.Size = New Size(122, 25)
        lblPaymentDate.TabIndex = 9
        lblPaymentDate.Text = "Payment Date"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Location = New Point(526, 151)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(148, 25)
        lblPaymentMethod.TabIndex = 10
        lblPaymentMethod.Text = "Payment Method"
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Location = New Point(26, 190)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(133, 25)
        lblPaymentStatus.TabIndex = 11
        lblPaymentStatus.Text = "Payment Status"
        ' 
        ' cmbAppointment
        ' 
        cmbAppointment.FormattingEnabled = True
        cmbAppointment.Location = New Point(175, 97)
        cmbAppointment.Name = "cmbAppointment"
        cmbAppointment.Size = New Size(182, 33)
        cmbAppointment.TabIndex = 12
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(727, 105)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(150, 31)
        txtAmount.TabIndex = 13
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(727, 143)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(182, 33)
        cmbPaymentMethod.TabIndex = 14
        ' 
        ' cmbPaymentStatus
        ' 
        cmbPaymentStatus.FormattingEnabled = True
        cmbPaymentStatus.Location = New Point(175, 182)
        cmbPaymentStatus.Name = "cmbPaymentStatus"
        cmbPaymentStatus.Size = New Size(182, 33)
        cmbPaymentStatus.TabIndex = 15
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(32, 221)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 16
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(201, 221)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(427, 221)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 18
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(611, 221)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 19
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(828, 221)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 20
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(996, 221)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 21
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmPayments
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1228, 754)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(cmbPaymentStatus)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(txtAmount)
        Controls.Add(cmbAppointment)
        Controls.Add(lblPaymentStatus)
        Controls.Add(lblPaymentMethod)
        Controls.Add(lblPaymentDate)
        Controls.Add(lblAmount)
        Controls.Add(lblAppointment)
        Controls.Add(lblPatient)
        Controls.Add(lblPaymentID)
        Controls.Add(dgvPayments)
        Controls.Add(dtpPaymentDate)
        Controls.Add(cmbPatient)
        Controls.Add(txtPaymentID)
        Controls.Add(lblHeading)
        Name = "frmPayments"
        Text = "frmPayments"
        CType(dgvPayments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents cmbPatient As ComboBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents lblPatient As Label
    Friend WithEvents lblAppointment As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents cmbAppointment As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents cmbPaymentStatus As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
End Class
