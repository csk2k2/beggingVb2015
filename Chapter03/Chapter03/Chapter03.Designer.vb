<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMain
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
        Me.btnFloatMath = New System.Windows.Forms.Button()
        Me.btnStrings = New System.Windows.Forms.Button()
        Me.btnConcatenation = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnSubStrings = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnDateProperties = New System.Windows.Forms.Button()
        Me.btnDateNames = New System.Windows.Forms.Button()
        Me.btnDateLiterals = New System.Windows.Forms.Button()
        Me.btnDateManipulation = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnScope = New System.Windows.Forms.Button()
        Me.btnMathTest = New System.Windows.Forms.Button()
        Me.btnStringTest = New System.Windows.Forms.Button()
        Me.txtString37 = New System.Windows.Forms.TextBox()
        Me.btnSubStr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFloatMath
        '
        Me.btnFloatMath.Location = New System.Drawing.Point(12, 12)
        Me.btnFloatMath.Name = "btnFloatMath"
        Me.btnFloatMath.Size = New System.Drawing.Size(236, 20)
        Me.btnFloatMath.TabIndex = 0
        Me.btnFloatMath.Text = "Float Test With Formatting"
        Me.btnFloatMath.UseVisualStyleBackColor = True
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(12, 38)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(236, 20)
        Me.btnStrings.TabIndex = 1
        Me.btnStrings.Text = "Using Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(13, 65)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(235, 21)
        Me.btnConcatenation.TabIndex = 2
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(12, 120)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(75, 23)
        Me.btnLength.TabIndex = 3
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(13, 93)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(235, 21)
        Me.txtString.TabIndex = 4
        '
        'btnSubStrings
        '
        Me.btnSubStrings.Location = New System.Drawing.Point(94, 120)
        Me.btnSubStrings.Name = "btnSubStrings"
        Me.btnSubStrings.Size = New System.Drawing.Size(75, 23)
        Me.btnSubStrings.TabIndex = 5
        Me.btnSubStrings.Text = "SubStrings"
        Me.btnSubStrings.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(175, 120)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(73, 23)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(13, 150)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(235, 27)
        Me.btnShowDate.TabIndex = 7
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnDateProperties
        '
        Me.btnDateProperties.Location = New System.Drawing.Point(13, 183)
        Me.btnDateProperties.Name = "btnDateProperties"
        Me.btnDateProperties.Size = New System.Drawing.Size(235, 26)
        Me.btnDateProperties.TabIndex = 8
        Me.btnDateProperties.Text = "Date Properties"
        Me.btnDateProperties.UseVisualStyleBackColor = True
        '
        'btnDateNames
        '
        Me.btnDateNames.Location = New System.Drawing.Point(12, 215)
        Me.btnDateNames.Name = "btnDateNames"
        Me.btnDateNames.Size = New System.Drawing.Size(236, 26)
        Me.btnDateNames.TabIndex = 8
        Me.btnDateNames.Text = "Date Names"
        Me.btnDateNames.UseVisualStyleBackColor = True
        '
        'btnDateLiterals
        '
        Me.btnDateLiterals.Location = New System.Drawing.Point(13, 248)
        Me.btnDateLiterals.Name = "btnDateLiterals"
        Me.btnDateLiterals.Size = New System.Drawing.Size(235, 23)
        Me.btnDateLiterals.TabIndex = 9
        Me.btnDateLiterals.Text = "Date Literals"
        Me.btnDateLiterals.UseVisualStyleBackColor = True
        '
        'btnDateManipulation
        '
        Me.btnDateManipulation.Location = New System.Drawing.Point(13, 278)
        Me.btnDateManipulation.Name = "btnDateManipulation"
        Me.btnDateManipulation.Size = New System.Drawing.Size(235, 23)
        Me.btnDateManipulation.TabIndex = 10
        Me.btnDateManipulation.Text = "Date Manipulation"
        Me.btnDateManipulation.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(255, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(239, 20)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(337, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(419, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnScope
        '
        Me.btnScope.Location = New System.Drawing.Point(255, 65)
        Me.btnScope.Name = "btnScope"
        Me.btnScope.Size = New System.Drawing.Size(239, 21)
        Me.btnScope.TabIndex = 15
        Me.btnScope.Text = "btnScope"
        Me.btnScope.UseVisualStyleBackColor = True
        '
        'btnMathTest
        '
        Me.btnMathTest.Location = New System.Drawing.Point(255, 93)
        Me.btnMathTest.Name = "btnMathTest"
        Me.btnMathTest.Size = New System.Drawing.Size(121, 21)
        Me.btnMathTest.TabIndex = 16
        Me.btnMathTest.Text = "Math Test"
        Me.btnMathTest.UseVisualStyleBackColor = True
        '
        'btnStringTest
        '
        Me.btnStringTest.Location = New System.Drawing.Point(383, 93)
        Me.btnStringTest.Name = "btnStringTest"
        Me.btnStringTest.Size = New System.Drawing.Size(111, 21)
        Me.btnStringTest.TabIndex = 17
        Me.btnStringTest.Text = "String Test"
        Me.btnStringTest.UseVisualStyleBackColor = True
        '
        'txtString37
        '
        Me.txtString37.Location = New System.Drawing.Point(255, 120)
        Me.txtString37.Name = "txtString37"
        Me.txtString37.Size = New System.Drawing.Size(157, 21)
        Me.txtString37.TabIndex = 18
        '
        'btnSubStr
        '
        Me.btnSubStr.Location = New System.Drawing.Point(419, 120)
        Me.btnSubStr.Name = "btnSubStr"
        Me.btnSubStr.Size = New System.Drawing.Size(75, 22)
        Me.btnSubStr.TabIndex = 19
        Me.btnSubStr.Text = "Sub Strings"
        Me.btnSubStr.UseVisualStyleBackColor = True
        '
        'FmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 311)
        Me.Controls.Add(Me.btnSubStr)
        Me.Controls.Add(Me.txtString37)
        Me.Controls.Add(Me.btnStringTest)
        Me.Controls.Add(Me.btnMathTest)
        Me.Controls.Add(Me.btnScope)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDateManipulation)
        Me.Controls.Add(Me.btnDateLiterals)
        Me.Controls.Add(Me.btnDateNames)
        Me.Controls.Add(Me.btnDateProperties)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnSubStrings)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Controls.Add(Me.btnFloatMath)
        Me.Name = "FmMain"
        Me.Text = "EXERCISE 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFloatMath As Button
    Friend WithEvents btnStrings As Button
    Friend WithEvents btnConcatenation As Button
    Friend WithEvents btnLength As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents btnSubStrings As Button
    Friend WithEvents btnReplace As Button
    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnDateProperties As Button
    Friend WithEvents btnDateNames As Button
    Friend WithEvents btnDateLiterals As Button
    Friend WithEvents btnDateManipulation As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnScope As Button
    Friend WithEvents btnMathTest As Button
    Friend WithEvents btnStringTest As Button
    Friend WithEvents txtString37 As TextBox
    Friend WithEvents btnSubStr As Button
End Class
