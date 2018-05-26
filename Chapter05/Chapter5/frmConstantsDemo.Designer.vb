<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConstantsDemo
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(12, 12)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(221, 23)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "One"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(12, 41)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(221, 23)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "Two"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(12, 71)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(221, 23)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "Three"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'ConstantsDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 143)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Name = "ConstantsDemo"
        Me.Text = "ConstantsDemo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
End Class
