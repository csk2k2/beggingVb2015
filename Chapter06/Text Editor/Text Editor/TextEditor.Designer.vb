﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbrClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrRed = New System.Windows.Forms.ToolStripButton()
        Me.tbrBlue = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrUpperCase = New System.Windows.Forms.ToolStripButton()
        Me.tbrLowerCase = New System.Windows.Forms.ToolStripButton()
        Me.tbrHelpAbout = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrClear, Me.ToolStripSeparator1, Me.tbrRed, Me.tbrBlue, Me.ToolStripSeparator2, Me.tbrUpperCase, Me.tbrLowerCase, Me.tbrHelpAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbrClear
        '
        Me.tbrClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClear.Image = CType(resources.GetObject("tbrClear.Image"), System.Drawing.Image)
        Me.tbrClear.ImageTransparentColor = System.Drawing.Color.DarkGray
        Me.tbrClear.Name = "tbrClear"
        Me.tbrClear.Size = New System.Drawing.Size(23, 22)
        Me.tbrClear.ToolTipText = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbrRed
        '
        Me.tbrRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRed.Image = CType(resources.GetObject("tbrRed.Image"), System.Drawing.Image)
        Me.tbrRed.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Size = New System.Drawing.Size(23, 22)
        Me.tbrRed.ToolTipText = "Red"
        '
        'tbrBlue
        '
        Me.tbrBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBlue.Image = CType(resources.GetObject("tbrBlue.Image"), System.Drawing.Image)
        Me.tbrBlue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Size = New System.Drawing.Size(23, 22)
        Me.tbrBlue.ToolTipText = "Blue"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbrUpperCase
        '
        Me.tbrUpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrUpperCase.Image = CType(resources.GetObject("tbrUpperCase.Image"), System.Drawing.Image)
        Me.tbrUpperCase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrUpperCase.Name = "tbrUpperCase"
        Me.tbrUpperCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrUpperCase.ToolTipText = "Upper Case"
        '
        'tbrLowerCase
        '
        Me.tbrLowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLowerCase.Image = CType(resources.GetObject("tbrLowerCase.Image"), System.Drawing.Image)
        Me.tbrLowerCase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrLowerCase.Name = "tbrLowerCase"
        Me.tbrLowerCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrLowerCase.ToolTipText = "Lower Case"
        '
        'tbrHelpAbout
        '
        Me.tbrHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrHelpAbout.Image = CType(resources.GetObject("tbrHelpAbout.Image"), System.Drawing.Image)
        Me.tbrHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrHelpAbout.Name = "tbrHelpAbout"
        Me.tbrHelpAbout.Size = New System.Drawing.Size(23, 22)
        Me.tbrHelpAbout.ToolTipText = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 399)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(44, 17)
        Me.sslStatus.Text = "Ready"
        '
        'txtEdit
        '
        Me.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEdit.Location = New System.Drawing.Point(0, 25)
        Me.txtEdit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEdit.Size = New System.Drawing.Size(584, 374)
        Me.txtEdit.TabIndex = 2
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 421)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "TextEditor"
        Me.Text = "Text Editor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tbrClear As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbrRed As ToolStripButton
    Friend WithEvents tbrBlue As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tbrUpperCase As ToolStripButton
    Friend WithEvents tbrLowerCase As ToolStripButton
    Friend WithEvents tbrHelpAbout As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents txtEdit As TextBox
End Class
