﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Figure6_1
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
        Me.btnSayHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSayHello
        '
        Me.btnSayHello.Location = New System.Drawing.Point(13, 13)
        Me.btnSayHello.Name = "btnSayHello"
        Me.btnSayHello.Size = New System.Drawing.Size(281, 23)
        Me.btnSayHello.TabIndex = 0
        Me.btnSayHello.Text = "Hello World"
        Me.btnSayHello.UseVisualStyleBackColor = True
        '
        'Figure6_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 385)
        Me.Controls.Add(Me.btnSayHello)
        Me.Name = "Figure6_1"
        Me.Text = "Windows Button Events"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSayHello As Button
End Class
