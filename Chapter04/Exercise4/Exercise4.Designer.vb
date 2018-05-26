<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise4
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 12
        Me.lstData.Items.AddRange(New Object() {"Libo", "Chengyi", "Zhaoyan", "Zhangxiaoxu", "WXD", "miaomiao", "laoliu"})
        Me.lstData.Location = New System.Drawing.Point(13, 13)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(92, 196)
        Me.lstData.TabIndex = 0
        '
        'Exercise4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Exercise4"
        Me.Text = "Exercise Four"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstData As ListBox
End Class
