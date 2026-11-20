<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        cmbReportType = New ComboBox()
        lblReporttype = New Label()
        lblStartDate = New Label()
        dtpStartDate = New DateTimePicker()
        lblEndDate = New Label()
        dtpEndDate = New DateTimePicker()
        btnGenerate = New Button()
        btnExportPDF = New Button()
        btnBack = New Button()
        dgvReports = New DataGridView()
        lblRecordCount = New Label()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        'lblHeading
        ' 
        lblHeading.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(30, 25)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(500, 50)
        lblHeading.TabIndex = 0
        lblHeading.Text = "HOSPITAL REPORTS"
        lblHeading.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbReportType
        ' 
        cmbReportType.AllowDrop = True
        cmbReportType.AutoCompleteCustomSource.AddRange(New String() {"Patient Report", "Doctor Report", "Appointment Report", "Payment Report"})
        cmbReportType.FormattingEnabled = True
        cmbReportType.Location = New Point(30, 140)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(280, 33)
        cmbReportType.TabIndex = 1
        ' 
        ' lblReporttype
        ' 
        lblReporttype.AutoSize = True
        lblReporttype.Location = New Point(30, 110)
        lblReporttype.Name = "lblReporttype"
        lblReporttype.Size = New Size(107, 25)
        lblReporttype.TabIndex = 2
        lblReporttype.Text = "Report Type"
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Location = New Point(350, 110)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(90, 25)
        lblStartDate.TabIndex = 3
        lblStartDate.Text = "Start Date"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(350, 140)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(180, 31)
        dtpStartDate.TabIndex = 4
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Location = New Point(600, 110)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(84, 25)
        lblEndDate.TabIndex = 5
        lblEndDate.Text = "End Date"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(600, 140)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(180, 31)
        dtpEndDate.TabIndex = 6
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(850, 130)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(160, 45)
        btnGenerate.TabIndex = 7
        btnGenerate.Text = "Generate Report"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Location = New Point(1020, 130)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(130, 45)
        btnExportPDF.TabIndex = 8
        btnExportPDF.Text = "Export PDF"
        btnExportPDF.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(30, 720)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 45)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvReports
        ' 
        dgvReports.AllowUserToAddRows = False
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Location = New Point(30, 220)
        dgvReports.MultiSelect = False
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.RowHeadersWidth = 62
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReports.Size = New Size(1170, 470)
        dgvReports.TabIndex = 10
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.Location = New Point(350, 720)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(224, 25)
        lblRecordCount.TabIndex = 11
        lblRecordCount.Text = "Ready To Generate Reports"
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(1461, 794)
        Controls.Add(lblRecordCount)
        Controls.Add(dgvReports)
        Controls.Add(btnBack)
        Controls.Add(btnExportPDF)
        Controls.Add(btnGenerate)
        Controls.Add(dtpEndDate)
        Controls.Add(lblEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(lblStartDate)
        Controls.Add(lblReporttype)
        Controls.Add(cmbReportType)
        Controls.Add(lblHeading)
        Name = "frmReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hospital Reports"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents lblReporttype As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents lblRecordCount As Label
End Class
