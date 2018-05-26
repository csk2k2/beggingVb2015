<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChapter4
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
        Me.btnIf = New System.Windows.Forms.Button()
        Me.btnIf2 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnCheckNumbers = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnOrCheck = New System.Windows.Forms.Button()
        Me.btnAndCheck = New System.Windows.Forms.Button()
        Me.btnStringCompare = New System.Windows.Forms.Button()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.btnForNextLoopWithStep = New System.Windows.Forms.Button()
        Me.btnBackwardsForNextLoop = New System.Windows.Forms.Button()
        Me.btnForEachLoop = New System.Windows.Forms.Button()
        Me.btnDoUntilLoop = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnNestedLoops = New System.Windows.Forms.Button()
        Me.btnQuittingAForLoop = New System.Windows.Forms.Button()
        Me.btnQuittingADoLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIf
        '
        Me.btnIf.Location = New System.Drawing.Point(13, 13)
        Me.btnIf.Name = "btnIf"
        Me.btnIf.Size = New System.Drawing.Size(75, 23)
        Me.btnIf.TabIndex = 0
        Me.btnIf.Text = "If"
        Me.btnIf.UseVisualStyleBackColor = True
        '
        'btnIf2
        '
        Me.btnIf2.Location = New System.Drawing.Point(95, 13)
        Me.btnIf2.Name = "btnIf2"
        Me.btnIf2.Size = New System.Drawing.Size(100, 23)
        Me.btnIf2.TabIndex = 1
        Me.btnIf2.Text = "If2"
        Me.btnIf2.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(13, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 21)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Stephanie"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(120, 43)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnCheckNumbers
        '
        Me.btnCheckNumbers.Location = New System.Drawing.Point(120, 71)
        Me.btnCheckNumbers.Name = "btnCheckNumbers"
        Me.btnCheckNumbers.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckNumbers.TabIndex = 5
        Me.btnCheckNumbers.Text = "Check"
        Me.btnCheckNumbers.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(13, 71)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 21)
        Me.txtValue.TabIndex = 4
        '
        'btnOrCheck
        '
        Me.btnOrCheck.Location = New System.Drawing.Point(13, 99)
        Me.btnOrCheck.Name = "btnOrCheck"
        Me.btnOrCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnOrCheck.TabIndex = 6
        Me.btnOrCheck.Text = "Or Check"
        Me.btnOrCheck.UseVisualStyleBackColor = True
        '
        'btnAndCheck
        '
        Me.btnAndCheck.Location = New System.Drawing.Point(95, 99)
        Me.btnAndCheck.Name = "btnAndCheck"
        Me.btnAndCheck.Size = New System.Drawing.Size(100, 23)
        Me.btnAndCheck.TabIndex = 7
        Me.btnAndCheck.Text = "And Check"
        Me.btnAndCheck.UseVisualStyleBackColor = True
        '
        'btnStringCompare
        '
        Me.btnStringCompare.Location = New System.Drawing.Point(13, 129)
        Me.btnStringCompare.Name = "btnStringCompare"
        Me.btnStringCompare.Size = New System.Drawing.Size(182, 23)
        Me.btnStringCompare.TabIndex = 8
        Me.btnStringCompare.Text = "String Compare"
        Me.btnStringCompare.UseVisualStyleBackColor = True
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 12
        Me.lstData.Items.AddRange(New Object() {"Bryan", "Ashley", "Jennifer", "Ediie", "Katelyn", "WXD"})
        Me.lstData.Location = New System.Drawing.Point(12, 158)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(183, 80)
        Me.lstData.TabIndex = 9
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(13, 245)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(182, 20)
        Me.btnForNextLoop.TabIndex = 10
        Me.btnForNextLoop.Text = "For Next Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForNextLoopWithStep
        '
        Me.btnForNextLoopWithStep.Location = New System.Drawing.Point(13, 272)
        Me.btnForNextLoopWithStep.Name = "btnForNextLoopWithStep"
        Me.btnForNextLoopWithStep.Size = New System.Drawing.Size(182, 23)
        Me.btnForNextLoopWithStep.TabIndex = 11
        Me.btnForNextLoopWithStep.Text = "For Next Loop w/Step"
        Me.btnForNextLoopWithStep.UseVisualStyleBackColor = True
        '
        'btnBackwardsForNextLoop
        '
        Me.btnBackwardsForNextLoop.Location = New System.Drawing.Point(13, 302)
        Me.btnBackwardsForNextLoop.Name = "btnBackwardsForNextLoop"
        Me.btnBackwardsForNextLoop.Size = New System.Drawing.Size(182, 23)
        Me.btnBackwardsForNextLoop.TabIndex = 12
        Me.btnBackwardsForNextLoop.Text = "Backwards For Next"
        Me.btnBackwardsForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForEachLoop
        '
        Me.btnForEachLoop.Location = New System.Drawing.Point(13, 332)
        Me.btnForEachLoop.Name = "btnForEachLoop"
        Me.btnForEachLoop.Size = New System.Drawing.Size(182, 23)
        Me.btnForEachLoop.TabIndex = 13
        Me.btnForEachLoop.Text = "For Each Loop"
        Me.btnForEachLoop.UseVisualStyleBackColor = True
        '
        'btnDoUntilLoop
        '
        Me.btnDoUntilLoop.Location = New System.Drawing.Point(13, 362)
        Me.btnDoUntilLoop.Name = "btnDoUntilLoop"
        Me.btnDoUntilLoop.Size = New System.Drawing.Size(182, 23)
        Me.btnDoUntilLoop.TabIndex = 14
        Me.btnDoUntilLoop.Text = "Do Until Loop"
        Me.btnDoUntilLoop.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(13, 392)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(182, 23)
        Me.btnDoWhileLoop.TabIndex = 15
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnNestedLoops
        '
        Me.btnNestedLoops.Location = New System.Drawing.Point(202, 13)
        Me.btnNestedLoops.Name = "btnNestedLoops"
        Me.btnNestedLoops.Size = New System.Drawing.Size(228, 23)
        Me.btnNestedLoops.TabIndex = 16
        Me.btnNestedLoops.Text = "Nested Loops"
        Me.btnNestedLoops.UseVisualStyleBackColor = True
        '
        'btnQuittingAForLoop
        '
        Me.btnQuittingAForLoop.Location = New System.Drawing.Point(202, 43)
        Me.btnQuittingAForLoop.Name = "btnQuittingAForLoop"
        Me.btnQuittingAForLoop.Size = New System.Drawing.Size(228, 23)
        Me.btnQuittingAForLoop.TabIndex = 17
        Me.btnQuittingAForLoop.Text = "Quitting A For Loop"
        Me.btnQuittingAForLoop.UseVisualStyleBackColor = True
        '
        'btnQuittingADoLoop
        '
        Me.btnQuittingADoLoop.Location = New System.Drawing.Point(202, 73)
        Me.btnQuittingADoLoop.Name = "btnQuittingADoLoop"
        Me.btnQuittingADoLoop.Size = New System.Drawing.Size(228, 23)
        Me.btnQuittingADoLoop.TabIndex = 18
        Me.btnQuittingADoLoop.Text = "Quitting A Do Loop"
        Me.btnQuittingADoLoop.UseVisualStyleBackColor = True
        '
        'FrmExercise4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 425)
        Me.Controls.Add(Me.btnQuittingADoLoop)
        Me.Controls.Add(Me.btnQuittingAForLoop)
        Me.Controls.Add(Me.btnNestedLoops)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoUntilLoop)
        Me.Controls.Add(Me.btnForEachLoop)
        Me.Controls.Add(Me.btnBackwardsForNextLoop)
        Me.Controls.Add(Me.btnForNextLoopWithStep)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.btnStringCompare)
        Me.Controls.Add(Me.btnAndCheck)
        Me.Controls.Add(Me.btnOrCheck)
        Me.Controls.Add(Me.btnCheckNumbers)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnIf2)
        Me.Controls.Add(Me.btnIf)
        Me.Name = "FrmExercise4"
        Me.Text = "Exercise Four"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIf As Button
    Friend WithEvents btnIf2 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnCheckNumbers As Button
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnOrCheck As Button
    Friend WithEvents btnAndCheck As Button
    Friend WithEvents btnStringCompare As Button
    Friend WithEvents lstData As ListBox
    Friend WithEvents btnForNextLoop As Button
    Friend WithEvents btnForNextLoopWithStep As Button
    Friend WithEvents btnBackwardsForNextLoop As Button
    Friend WithEvents btnForEachLoop As Button
    Friend WithEvents btnDoUntilLoop As Button
    Friend WithEvents btnDoWhileLoop As Button
    Friend WithEvents btnNestedLoops As Button
    Friend WithEvents btnQuittingAForLoop As Button
    Friend WithEvents btnQuittingADoLoop As Button
End Class
