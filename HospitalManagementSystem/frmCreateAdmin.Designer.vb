<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAdmin
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
        lblFullName = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtFullName = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnCreateAdmin = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(498, 18)
        lblHeading.Margin = New Padding(4, 0, 4, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(483, 45)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Create Administrator Account"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(401, 99)
        lblFullName.Margin = New Padding(4, 0, 4, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(115, 30)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full Name:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(408, 197)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(116, 30)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(408, 284)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(108, 30)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(548, 100)
        txtFullName.Margin = New Padding(4, 4, 4, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(530, 31)
        txtFullName.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(548, 198)
        txtUsername.Margin = New Padding(4, 4, 4, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(530, 31)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(548, 283)
        txtPassword.Margin = New Padding(4, 4, 4, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(530, 31)
        txtPassword.TabIndex = 6
        ' 
        ' btnCreateAdmin
        ' 
        btnCreateAdmin.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateAdmin.Location = New Point(635, 397)
        btnCreateAdmin.Margin = New Padding(4, 4, 4, 4)
        btnCreateAdmin.Name = "btnCreateAdmin"
        btnCreateAdmin.Size = New Size(280, 36)
        btnCreateAdmin.TabIndex = 7
        btnCreateAdmin.Text = "Create Administrator"
        btnCreateAdmin.UseVisualStyleBackColor = True
        ' 
        ' frmCreateAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1483, 697)
        Controls.Add(btnCreateAdmin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtFullName)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblFullName)
        Controls.Add(lblHeading)
        Margin = New Padding(4, 4, 4, 4)
        Name = "frmCreateAdmin"
        Text = "frmCreateAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCreateAdmin As Button
End Class
