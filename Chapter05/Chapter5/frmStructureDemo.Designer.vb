<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStructureDemo
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnListCustomer = New System.Windows.Forms.Button()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 336)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(29, 12)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(23, 370)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(65, 12)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(23, 404)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(59, 12)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(23, 438)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 12)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(104, 324)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(290, 21)
        Me.txtName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(104, 361)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(290, 21)
        Me.txtFirstName.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(104, 395)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(290, 21)
        Me.txtLastName.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(104, 429)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(208, 21)
        Me.txtEmail.TabIndex = 7
        '
        'btnListCustomer
        '
        Me.btnListCustomer.Location = New System.Drawing.Point(161, 457)
        Me.btnListCustomer.Name = "btnListCustomer"
        Me.btnListCustomer.Size = New System.Drawing.Size(151, 23)
        Me.btnListCustomer.TabIndex = 8
        Me.btnListCustomer.Text = "List Customer"
        Me.btnListCustomer.UseVisualStyleBackColor = True
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.IntegralHeight = False
        Me.lstCustomers.ItemHeight = 12
        Me.lstCustomers.Location = New System.Drawing.Point(25, 13)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(369, 305)
        Me.lstCustomers.TabIndex = 9
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(319, 457)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCustomer.TabIndex = 10
        Me.btnDeleteCustomer.Text = "Delete Customer"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(319, 426)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(75, 24)
        Me.btnLookup.TabIndex = 11
        Me.btnLookup.Text = "Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'frmStructureDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 491)
        Me.Controls.Add(Me.btnLookup)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.btnListCustomer)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmStructureDemo"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnListCustomer As Button
    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnLookup As Button
End Class
