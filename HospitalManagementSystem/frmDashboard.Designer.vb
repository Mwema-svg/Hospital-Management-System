<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        lblWelcome = New Label()
        btnPatients = New Button()
        btnDoctors = New Button()
        btnDepartments = New Button()
        btnLogout = New Button()
        btnAppointments = New Button()
        btnPayments = New Button()
        btnReports = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(90, 38)
        lblHeading.Margin = New Padding(4, 0, 4, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(954, 75)
        lblHeading.TabIndex = 0
        lblHeading.Text = "HOSPITAL PATIENT MANAGEMENT SYSTEM"
        lblHeading.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Location = New Point(338, 125)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(550, 44)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome to the Hospital Management System"
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPatients
        ' 
        btnPatients.Cursor = Cursors.Hand
        btnPatients.FlatAppearance.BorderSize = 0
        btnPatients.FlatStyle = FlatStyle.Flat
        btnPatients.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPatients.Location = New Point(461, 229)
        btnPatients.Name = "btnPatients"
        btnPatients.Size = New Size(180, 45)
        btnPatients.TabIndex = 2
        btnPatients.Text = "Patients Management"
        btnPatients.UseVisualStyleBackColor = True
        ' 
        ' btnDoctors
        ' 
        btnDoctors.Cursor = Cursors.Hand
        btnDoctors.FlatAppearance.BorderSize = 0
        btnDoctors.FlatStyle = FlatStyle.Flat
        btnDoctors.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoctors.Location = New Point(461, 283)
        btnDoctors.Name = "btnDoctors"
        btnDoctors.Size = New Size(180, 45)
        btnDoctors.TabIndex = 3
        btnDoctors.Text = "Doctors Manaagement"
        btnDoctors.UseVisualStyleBackColor = True
        ' 
        ' btnDepartments
        ' 
        btnDepartments.Cursor = Cursors.Hand
        btnDepartments.FlatAppearance.BorderSize = 0
        btnDepartments.FlatStyle = FlatStyle.Flat
        btnDepartments.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDepartments.Location = New Point(461, 334)
        btnDepartments.Name = "btnDepartments"
        btnDepartments.Size = New Size(180, 45)
        btnDepartments.TabIndex = 4
        btnDepartments.Text = "Departments Management"
        btnDepartments.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(481, 552)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(140, 40)
        btnLogout.TabIndex = 5
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnAppointments
        ' 
        btnAppointments.Cursor = Cursors.Hand
        btnAppointments.FlatAppearance.BorderSize = 0
        btnAppointments.FlatStyle = FlatStyle.Flat
        btnAppointments.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAppointments.Location = New Point(461, 385)
        btnAppointments.Name = "btnAppointments"
        btnAppointments.Size = New Size(180, 45)
        btnAppointments.TabIndex = 6
        btnAppointments.Text = "Appointments"
        btnAppointments.UseVisualStyleBackColor = True
        ' 
        ' btnPayments
        ' 
        btnPayments.Cursor = Cursors.Hand
        btnPayments.FlatAppearance.BorderSize = 0
        btnPayments.FlatStyle = FlatStyle.Flat
        btnPayments.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayments.Location = New Point(461, 436)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(180, 45)
        btnPayments.TabIndex = 7
        btnPayments.Text = "Payments"
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Cursor = Cursors.Hand
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReports.Location = New Point(461, 487)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(180, 45)
        btnReports.TabIndex = 8
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1228, 754)
        Controls.Add(btnReports)
        Controls.Add(btnPayments)
        Controls.Add(btnAppointments)
        Controls.Add(btnLogout)
        Controls.Add(btnDepartments)
        Controls.Add(btnDoctors)
        Controls.Add(btnPatients)
        Controls.Add(lblWelcome)
        Controls.Add(lblHeading)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hospital Patient Management System - Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnPatients As Button
    Friend WithEvents btnDoctors As Button
    Friend WithEvents btnDepartments As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnReports As Button
End Class
