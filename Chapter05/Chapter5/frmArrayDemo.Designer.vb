<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayDemo
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
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnArrayElement = New System.Windows.Forms.Button()
        Me.btnEnumerateArray = New System.Windows.Forms.Button()
        Me.btnArraysAsParameters = New System.Windows.Forms.Button()
        Me.btnMoreArrayParameters = New System.Windows.Forms.Button()
        Me.btnSortArrays = New System.Windows.Forms.Button()
        Me.btnConcat = New System.Windows.Forms.Button()
        Me.btnConcat2 = New System.Windows.Forms.Button()
        Me.btnReversingAnArray = New System.Windows.Forms.Button()
        Me.btnInitializingArraysWithValues = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.IntegralHeight = False
        Me.lstFriends.ItemHeight = 12
        Me.lstFriends.Location = New System.Drawing.Point(13, 13)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(110, 424)
        Me.lstFriends.TabIndex = 0
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(130, 13)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(160, 23)
        Me.btnArrayElement.TabIndex = 1
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnEnumerateArray
        '
        Me.btnEnumerateArray.Location = New System.Drawing.Point(130, 43)
        Me.btnEnumerateArray.Name = "btnEnumerateArray"
        Me.btnEnumerateArray.Size = New System.Drawing.Size(160, 23)
        Me.btnEnumerateArray.TabIndex = 2
        Me.btnEnumerateArray.Text = "Enumerate Array"
        Me.btnEnumerateArray.UseVisualStyleBackColor = True
        '
        'btnArraysAsParameters
        '
        Me.btnArraysAsParameters.Location = New System.Drawing.Point(130, 73)
        Me.btnArraysAsParameters.Name = "btnArraysAsParameters"
        Me.btnArraysAsParameters.Size = New System.Drawing.Size(160, 23)
        Me.btnArraysAsParameters.TabIndex = 3
        Me.btnArraysAsParameters.Text = "Arrays as Parameters"
        Me.btnArraysAsParameters.UseVisualStyleBackColor = True
        '
        'btnMoreArrayParameters
        '
        Me.btnMoreArrayParameters.Location = New System.Drawing.Point(130, 103)
        Me.btnMoreArrayParameters.Name = "btnMoreArrayParameters"
        Me.btnMoreArrayParameters.Size = New System.Drawing.Size(160, 23)
        Me.btnMoreArrayParameters.TabIndex = 4
        Me.btnMoreArrayParameters.Text = "More Array Parameters"
        Me.btnMoreArrayParameters.UseVisualStyleBackColor = True
        '
        'btnSortArrays
        '
        Me.btnSortArrays.Location = New System.Drawing.Point(130, 133)
        Me.btnSortArrays.Name = "btnSortArrays"
        Me.btnSortArrays.Size = New System.Drawing.Size(39, 23)
        Me.btnSortArrays.TabIndex = 5
        Me.btnSortArrays.Text = "Sorting Arrays"
        Me.btnSortArrays.UseVisualStyleBackColor = True
        '
        'btnConcat
        '
        Me.btnConcat.Location = New System.Drawing.Point(175, 132)
        Me.btnConcat.Name = "btnConcat"
        Me.btnConcat.Size = New System.Drawing.Size(50, 23)
        Me.btnConcat.TabIndex = 6
        Me.btnConcat.Text = "Concat"
        Me.btnConcat.UseVisualStyleBackColor = True
        '
        'btnConcat2
        '
        Me.btnConcat2.Location = New System.Drawing.Point(231, 132)
        Me.btnConcat2.Name = "btnConcat2"
        Me.btnConcat2.Size = New System.Drawing.Size(56, 23)
        Me.btnConcat2.TabIndex = 7
        Me.btnConcat2.Text = "Concat2"
        Me.btnConcat2.UseVisualStyleBackColor = True
        '
        'btnReversingAnArray
        '
        Me.btnReversingAnArray.Location = New System.Drawing.Point(130, 163)
        Me.btnReversingAnArray.Name = "btnReversingAnArray"
        Me.btnReversingAnArray.Size = New System.Drawing.Size(75, 23)
        Me.btnReversingAnArray.TabIndex = 8
        Me.btnReversingAnArray.Text = "ReverseArray"
        Me.btnReversingAnArray.UseVisualStyleBackColor = True
        '
        'btnInitializingArraysWithValues
        '
        Me.btnInitializingArraysWithValues.Location = New System.Drawing.Point(211, 163)
        Me.btnInitializingArraysWithValues.Name = "btnInitializingArraysWithValues"
        Me.btnInitializingArraysWithValues.Size = New System.Drawing.Size(75, 23)
        Me.btnInitializingArraysWithValues.TabIndex = 9
        Me.btnInitializingArraysWithValues.Text = "Initializing Arrays With Values"
        Me.btnInitializingArraysWithValues.UseVisualStyleBackColor = True
        '
        'ArrayDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 441)
        Me.Controls.Add(Me.btnInitializingArraysWithValues)
        Me.Controls.Add(Me.btnReversingAnArray)
        Me.Controls.Add(Me.btnConcat2)
        Me.Controls.Add(Me.btnConcat)
        Me.Controls.Add(Me.btnSortArrays)
        Me.Controls.Add(Me.btnMoreArrayParameters)
        Me.Controls.Add(Me.btnArraysAsParameters)
        Me.Controls.Add(Me.btnEnumerateArray)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "ArrayDemo"
        Me.Text = "Array Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnArrayElement As Button
    Friend WithEvents btnEnumerateArray As Button
    Friend WithEvents btnArraysAsParameters As Button
    Friend WithEvents btnMoreArrayParameters As Button
    Friend WithEvents btnSortArrays As Button
    Friend WithEvents btnConcat As Button
    Friend WithEvents btnConcat2 As Button
    Friend WithEvents btnReversingAnArray As Button
    Friend WithEvents btnInitializingArraysWithValues As Button
End Class
