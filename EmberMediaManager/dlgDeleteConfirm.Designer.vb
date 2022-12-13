﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteConfirm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDeleteConfirm))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.tvFiles = New System.Windows.Forms.TreeView()
        Me.ilFiles = New System.Windows.Forms.ImageList(Me.components)
        Me.lblNodeSelected = New System.Windows.Forms.Label()
        Me.btnToggleAllFiles = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'OK_Button
        '
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.OK_Button.Location = New System.Drawing.Point(366, 294)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(439, 294)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'tvFiles
        '
        Me.tvFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tvFiles.CheckBoxes = true
        Me.tvFiles.ImageIndex = 0
        Me.tvFiles.ImageList = Me.ilFiles
        Me.tvFiles.Location = New System.Drawing.Point(2, 2)
        Me.tvFiles.Name = "tvFiles"
        Me.tvFiles.SelectedImageIndex = 0
        Me.tvFiles.Size = New System.Drawing.Size(504, 265)
        Me.tvFiles.TabIndex = 2
        '
        'ilFiles
        '
        Me.ilFiles.ImageStream = CType(resources.GetObject("ilFiles.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ilFiles.TransparentColor = System.Drawing.Color.Transparent
        Me.ilFiles.Images.SetKeyName(0, "FILE")
        Me.ilFiles.Images.SetKeyName(1, "RECORD")
        Me.ilFiles.Images.SetKeyName(2, "MOVIE")
        Me.ilFiles.Images.SetKeyName(3, "FOLDER")
        '
        'lblNodeSelected
        '
        Me.lblNodeSelected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNodeSelected.AutoEllipsis = true
        Me.lblNodeSelected.AutoSize = true
        Me.lblNodeSelected.Location = New System.Drawing.Point(3, 270)
        Me.lblNodeSelected.Name = "lblNodeSelected"
        Me.lblNodeSelected.Size = New System.Drawing.Size(0, 13)
        Me.lblNodeSelected.TabIndex = 3
        '
        'btnToggleAllFiles
        '
        Me.btnToggleAllFiles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnToggleAllFiles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnToggleAllFiles.Location = New System.Drawing.Point(2, 294)
        Me.btnToggleAllFiles.Name = "btnToggleAllFiles"
        Me.btnToggleAllFiles.Size = New System.Drawing.Size(115, 23)
        Me.btnToggleAllFiles.TabIndex = 4
        Me.btnToggleAllFiles.Text = "Toggle All Files"
        '
        'dlgDeleteConfirm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(508, 326)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.btnToggleAllFiles)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.lblNodeSelected)
        Me.Controls.Add(Me.tvFiles)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "dlgDeleteConfirm"
        Me.ShowInTaskbar = false
        Me.Text = "Confirm Items To Be Deleted"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents tvFiles As System.Windows.Forms.TreeView
    Friend WithEvents ilFiles As System.Windows.Forms.ImageList
    Friend WithEvents lblNodeSelected As System.Windows.Forms.Label
    Friend WithEvents btnToggleAllFiles As System.Windows.Forms.Button

End Class
