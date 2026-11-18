<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departments
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
        lblDepartments = New LinkLabel()
        txtDepartmentId = New TextBox()
        txtDepartmentName = New TextBox()
        lblDepartmentName = New Label()
        cmbHeadOfDepartment = New ComboBox()
        lblHeadOfDepartment = New Label()
        lblDescription = New Label()
        txtDescription = New TextBox()
        txtSearch = New TextBox()
        lblSearch = New Label()
        dgvDepartments = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        lblDepartmentId = New Label()
        btnBack = New Button()
        btnRefresh = New Button()
        CType(dgvDepartments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDepartments
        ' 
        lblDepartments.AutoSize = True
        lblDepartments.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDepartments.Location = New Point(289, 9)
        lblDepartments.Name = "lblDepartments"
        lblDepartments.Size = New Size(144, 25)
        lblDepartments.TabIndex = 0
        lblDepartments.TabStop = True
        lblDepartments.Text = "DEPARTMENTS"
        ' 
        ' txtDepartmentId
        ' 
        txtDepartmentId.Location = New Point(220, 118)
        txtDepartmentId.Name = "txtDepartmentId"
        txtDepartmentId.Size = New Size(150, 31)
        txtDepartmentId.TabIndex = 1
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.Location = New Point(220, 175)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.Size = New Size(150, 31)
        txtDepartmentName.TabIndex = 2
        ' 
        ' lblDepartmentName
        ' 
        lblDepartmentName.AutoSize = True
        lblDepartmentName.Location = New Point(35, 175)
        lblDepartmentName.Name = "lblDepartmentName"
        lblDepartmentName.Size = New Size(159, 25)
        lblDepartmentName.TabIndex = 4
        lblDepartmentName.Text = "Department Name"
        ' 
        ' cmbHeadOfDepartment
        ' 
        cmbHeadOfDepartment.FormattingEnabled = True
        cmbHeadOfDepartment.Location = New Point(220, 224)
        cmbHeadOfDepartment.Name = "cmbHeadOfDepartment"
        cmbHeadOfDepartment.Size = New Size(150, 33)
        cmbHeadOfDepartment.TabIndex = 5
        ' 
        ' lblHeadOfDepartment
        ' 
        lblHeadOfDepartment.AutoSize = True
        lblHeadOfDepartment.Location = New Point(35, 232)
        lblHeadOfDepartment.Name = "lblHeadOfDepartment"
        lblHeadOfDepartment.Size = New Size(179, 25)
        lblHeadOfDepartment.TabIndex = 6
        lblHeadOfDepartment.Text = "Head Of Department"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(35, 349)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(102, 25)
        lblDescription.TabIndex = 7
        lblDescription.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(143, 343)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(245, 31)
        txtDescription.TabIndex = 8
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(670, 52)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(256, 31)
        txtSearch.TabIndex = 9
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(490, 58)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(172, 25)
        lblSearch.TabIndex = 10
        lblSearch.Text = "Search Departments"
        ' 
        ' dgvDepartments
        ' 
        dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDepartments.Location = New Point(425, 89)
        dgvDepartments.Name = "dgvDepartments"
        dgvDepartments.RowHeadersWidth = 62
        dgvDepartments.Size = New Size(886, 409)
        dgvDepartments.TabIndex = 11
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(207, 540)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(99, 34)
        btnAdd.TabIndex = 12
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(358, 540)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(99, 34)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(509, 540)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(99, 34)
        btnDelete.TabIndex = 14
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(654, 540)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(99, 34)
        btnClear.TabIndex = 15
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblDepartmentId
        ' 
        lblDepartmentId.AutoSize = True
        lblDepartmentId.Location = New Point(35, 118)
        lblDepartmentId.Name = "lblDepartmentId"
        lblDepartmentId.Size = New Size(128, 25)
        lblDepartmentId.TabIndex = 16
        lblDepartmentId.Text = "Department Id"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(948, 540)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(99, 34)
        btnBack.TabIndex = 17
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(793, 540)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(99, 34)
        btnRefresh.TabIndex = 18
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Departments
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1461, 690)
        Controls.Add(btnRefresh)
        Controls.Add(btnBack)
        Controls.Add(lblDepartmentId)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dgvDepartments)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(txtDescription)
        Controls.Add(lblDescription)
        Controls.Add(lblHeadOfDepartment)
        Controls.Add(cmbHeadOfDepartment)
        Controls.Add(lblDepartmentName)
        Controls.Add(txtDepartmentName)
        Controls.Add(txtDepartmentId)
        Controls.Add(lblDepartments)
        Name = "Departments"
        Text = "Departments"
        CType(dgvDepartments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDepartments As LinkLabel
    Friend WithEvents txtDepartmentId As TextBox
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents lblDepartmentName As Label
    Friend WithEvents cmbHeadOfDepartment As ComboBox
    Friend WithEvents lblHeadOfDepartment As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDepartmentId As Label
    Friend WithEvents btnRefresh As Button
End Class
