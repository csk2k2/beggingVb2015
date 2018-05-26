<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnumDemo
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtpHour = New System.Windows.Forms.DateTimePicker()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpHour
        '
        Me.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHour.Location = New System.Drawing.Point(13, 13)
        Me.dtpHour.Name = "dtpHour"
        Me.dtpHour.ShowUpDown = True
        Me.dtpHour.Size = New System.Drawing.Size(200, 21)
        Me.dtpHour.TabIndex = 0
        Me.dtpHour.Value = New Date(2018, 4, 24, 1, 0, 0, 0)
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(13, 41)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(131, 12)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "State Not Initialized"
        '
        'EnumDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 78)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.dtpHour)
        Me.Name = "EnumDemo"
        Me.Text = "What's WXD Doing?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpHour As DateTimePicker
    Friend WithEvents lblState As Label
End Class
