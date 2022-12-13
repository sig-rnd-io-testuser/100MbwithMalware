﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTrailerSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTrailerSelect))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gbSelectTrailer = New System.Windows.Forms.GroupBox()
        Me.btnTrailerScrape = New System.Windows.Forms.Button()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.lvTrailers = New System.Windows.Forms.ListView()
        Me.colNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWebURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVideoQuality = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVideoType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colScraper = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbYouTubeSearch = New System.Windows.Forms.GroupBox()
        Me.btnYouTubeSearch = New System.Windows.Forms.Button()
        Me.txtYouTubeSearch = New System.Windows.Forms.TextBox()
        Me.gbManualTrailer = New System.Windows.Forms.GroupBox()
        Me.btnClearManualTrailerLink = New System.Windows.Forms.Button()
        Me.btnBrowseLocalTrailer = New System.Windows.Forms.Button()
        Me.txtLocalTrailer = New System.Windows.Forms.TextBox()
        Me.lblLocalTrailer = New System.Windows.Forms.Label()
        Me.btnPlayLocalTrailer = New System.Windows.Forms.Button()
        Me.txtManualTrailerLink = New System.Windows.Forms.TextBox()
        Me.lblManualTrailerLink = New System.Windows.Forms.Label()
        Me.ofdTrailer = New System.Windows.Forms.OpenFileDialog()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.gbPreview = New System.Windows.Forms.GroupBox()
        Me.pnlTrailerPreview = New System.Windows.Forms.Panel()
        Me.pnlTrailerPreviewNoPlayer = New System.Windows.Forms.Panel()
        Me.tblTrailerPreviewNoPlayer = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTrailerPreviewNoPlayer = New System.Windows.Forms.Label()
        Me.btnPlayInBrowser = New System.Windows.Forms.Button()
        Me.pblBottom = New System.Windows.Forms.Panel()
        Me.tblBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.gbSelectTrailer.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.gbYouTubeSearch.SuspendLayout()
        Me.gbManualTrailer.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.gbPreview.SuspendLayout()
        Me.pnlTrailerPreview.SuspendLayout()
        Me.pnlTrailerPreviewNoPlayer.SuspendLayout()
        Me.tblTrailerPreviewNoPlayer.SuspendLayout()
        Me.pblBottom.SuspendLayout()
        Me.tblBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(752, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(120, 23)
        Me.OK_Button.TabIndex = 6
        Me.OK_Button.Text = "Download"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(878, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(120, 23)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Cancel"
        '
        'gbSelectTrailer
        '
        Me.gbSelectTrailer.Controls.Add(Me.btnTrailerScrape)
        Me.gbSelectTrailer.Controls.Add(Me.pnlStatus)
        Me.gbSelectTrailer.Controls.Add(Me.lvTrailers)
        Me.gbSelectTrailer.Controls.Add(Me.gbYouTubeSearch)
        Me.gbSelectTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSelectTrailer.Location = New System.Drawing.Point(9, 9)
        Me.gbSelectTrailer.Name = "gbSelectTrailer"
        Me.gbSelectTrailer.Size = New System.Drawing.Size(582, 440)
        Me.gbSelectTrailer.TabIndex = 0
        Me.gbSelectTrailer.TabStop = False
        Me.gbSelectTrailer.Text = "Select Trailer to Scrape"
        '
        'btnTrailerScrape
        '
        Me.btnTrailerScrape.Location = New System.Drawing.Point(6, 319)
        Me.btnTrailerScrape.Name = "btnTrailerScrape"
        Me.btnTrailerScrape.Size = New System.Drawing.Size(152, 23)
        Me.btnTrailerScrape.TabIndex = 5
        Me.btnTrailerScrape.Text = "Scrape Trailers"
        Me.btnTrailerScrape.UseVisualStyleBackColor = True
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.White
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Controls.Add(Me.pbStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(191, 141)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(200, 54)
        Me.pnlStatus.TabIndex = 1
        Me.pnlStatus.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 10)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(121, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Compiling trailer list..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(3, 32)
        Me.pbStatus.MarqueeAnimationSpeed = 25
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(192, 17)
        Me.pbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbStatus.TabIndex = 1
        '
        'lvTrailers
        '
        Me.lvTrailers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNumber, Me.colURL, Me.colWebURL, Me.colDescription, Me.colDuration, Me.colVideoQuality, Me.colVideoType, Me.colSource, Me.colScraper})
        Me.lvTrailers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTrailers.Location = New System.Drawing.Point(6, 19)
        Me.lvTrailers.Name = "lvTrailers"
        Me.lvTrailers.Size = New System.Drawing.Size(570, 298)
        Me.lvTrailers.TabIndex = 4
        Me.lvTrailers.UseCompatibleStateImageBehavior = False
        Me.lvTrailers.View = System.Windows.Forms.View.Details
        '
        'colNumber
        '
        Me.colNumber.Text = "#"
        Me.colNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colNumber.Width = 20
        '
        'colURL
        '
        Me.colURL.Text = "URL"
        Me.colURL.Width = 0
        '
        'colWebURL
        '
        Me.colWebURL.Text = "WebURL"
        Me.colWebURL.Width = 0
        '
        'colDescription
        '
        Me.colDescription.Text = "Description"
        Me.colDescription.Width = 180
        '
        'colDuration
        '
        Me.colDuration.Text = "Duration"
        '
        'colVideoQuality
        '
        Me.colVideoQuality.Text = "Quality"
        '
        'colVideoType
        '
        Me.colVideoType.Text = "Type"
        '
        'colSource
        '
        Me.colSource.Text = "Source"
        Me.colSource.Width = 80
        '
        'colScraper
        '
        Me.colScraper.Text = "Scraper"
        Me.colScraper.Width = 80
        '
        'gbYouTubeSearch
        '
        Me.gbYouTubeSearch.Controls.Add(Me.btnYouTubeSearch)
        Me.gbYouTubeSearch.Controls.Add(Me.txtYouTubeSearch)
        Me.gbYouTubeSearch.Location = New System.Drawing.Point(6, 364)
        Me.gbYouTubeSearch.Name = "gbYouTubeSearch"
        Me.gbYouTubeSearch.Size = New System.Drawing.Size(445, 70)
        Me.gbYouTubeSearch.TabIndex = 9
        Me.gbYouTubeSearch.TabStop = False
        Me.gbYouTubeSearch.Text = "Search On YouTube"
        '
        'btnYouTubeSearch
        '
        Me.btnYouTubeSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYouTubeSearch.Location = New System.Drawing.Point(364, 27)
        Me.btnYouTubeSearch.Name = "btnYouTubeSearch"
        Me.btnYouTubeSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnYouTubeSearch.TabIndex = 1
        Me.btnYouTubeSearch.Text = "Search"
        Me.btnYouTubeSearch.UseVisualStyleBackColor = True
        '
        'txtYouTubeSearch
        '
        Me.txtYouTubeSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYouTubeSearch.Location = New System.Drawing.Point(6, 27)
        Me.txtYouTubeSearch.Name = "txtYouTubeSearch"
        Me.txtYouTubeSearch.Size = New System.Drawing.Size(352, 22)
        Me.txtYouTubeSearch.TabIndex = 0
        '
        'gbManualTrailer
        '
        Me.gbManualTrailer.Controls.Add(Me.btnClearManualTrailerLink)
        Me.gbManualTrailer.Controls.Add(Me.btnBrowseLocalTrailer)
        Me.gbManualTrailer.Controls.Add(Me.txtLocalTrailer)
        Me.gbManualTrailer.Controls.Add(Me.lblLocalTrailer)
        Me.gbManualTrailer.Controls.Add(Me.btnPlayLocalTrailer)
        Me.gbManualTrailer.Controls.Add(Me.txtManualTrailerLink)
        Me.gbManualTrailer.Controls.Add(Me.lblManualTrailerLink)
        Me.gbManualTrailer.Location = New System.Drawing.Point(597, 309)
        Me.gbManualTrailer.Name = "gbManualTrailer"
        Me.gbManualTrailer.Size = New System.Drawing.Size(396, 140)
        Me.gbManualTrailer.TabIndex = 3
        Me.gbManualTrailer.TabStop = False
        Me.gbManualTrailer.Text = "Manual Trailer Entry"
        '
        'btnClearManualTrailerLink
        '
        Me.btnClearManualTrailerLink.Location = New System.Drawing.Point(365, 27)
        Me.btnClearManualTrailerLink.Name = "btnClearManualTrailerLink"
        Me.btnClearManualTrailerLink.Size = New System.Drawing.Size(25, 23)
        Me.btnClearManualTrailerLink.TabIndex = 5
        Me.btnClearManualTrailerLink.Text = "X"
        Me.btnClearManualTrailerLink.UseVisualStyleBackColor = True
        '
        'btnBrowseLocalTrailer
        '
        Me.btnBrowseLocalTrailer.Location = New System.Drawing.Point(365, 81)
        Me.btnBrowseLocalTrailer.Name = "btnBrowseLocalTrailer"
        Me.btnBrowseLocalTrailer.Size = New System.Drawing.Size(25, 23)
        Me.btnBrowseLocalTrailer.TabIndex = 4
        Me.btnBrowseLocalTrailer.Text = "..."
        Me.btnBrowseLocalTrailer.UseVisualStyleBackColor = True
        '
        'txtLocalTrailer
        '
        Me.txtLocalTrailer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalTrailer.Location = New System.Drawing.Point(9, 82)
        Me.txtLocalTrailer.Name = "txtLocalTrailer"
        Me.txtLocalTrailer.Size = New System.Drawing.Size(350, 22)
        Me.txtLocalTrailer.TabIndex = 3
        '
        'lblLocalTrailer
        '
        Me.lblLocalTrailer.AutoSize = True
        Me.lblLocalTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalTrailer.Location = New System.Drawing.Point(6, 68)
        Me.lblLocalTrailer.Name = "lblLocalTrailer"
        Me.lblLocalTrailer.Size = New System.Drawing.Size(71, 13)
        Me.lblLocalTrailer.TabIndex = 2
        Me.lblLocalTrailer.Text = "Local Trailer:"
        '
        'btnPlayLocalTrailer
        '
        Me.btnPlayLocalTrailer.Enabled = False
        Me.btnPlayLocalTrailer.Image = CType(resources.GetObject("btnPlayLocalTrailer.Image"), System.Drawing.Image)
        Me.btnPlayLocalTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayLocalTrailer.Location = New System.Drawing.Point(121, 110)
        Me.btnPlayLocalTrailer.Name = "btnPlayLocalTrailer"
        Me.btnPlayLocalTrailer.Size = New System.Drawing.Size(120, 23)
        Me.btnPlayLocalTrailer.TabIndex = 3
        Me.btnPlayLocalTrailer.Text = "Preview Trailer"
        Me.btnPlayLocalTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayLocalTrailer.UseVisualStyleBackColor = True
        '
        'txtManualTrailerLink
        '
        Me.txtManualTrailerLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtManualTrailerLink.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManualTrailerLink.Location = New System.Drawing.Point(9, 28)
        Me.txtManualTrailerLink.Name = "txtManualTrailerLink"
        Me.txtManualTrailerLink.Size = New System.Drawing.Size(350, 22)
        Me.txtManualTrailerLink.TabIndex = 1
        '
        'lblManualTrailerLink
        '
        Me.lblManualTrailerLink.AutoSize = True
        Me.lblManualTrailerLink.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManualTrailerLink.Location = New System.Drawing.Point(6, 14)
        Me.lblManualTrailerLink.Name = "lblManualTrailerLink"
        Me.lblManualTrailerLink.Size = New System.Drawing.Size(257, 13)
        Me.lblManualTrailerLink.TabIndex = 0
        Me.lblManualTrailerLink.Text = "Direct Link, YouTube, IMDB or Apple Trailer URL:"
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.gbPreview)
        Me.pnlMain.Controls.Add(Me.gbManualTrailer)
        Me.pnlMain.Controls.Add(Me.gbSelectTrailer)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1001, 484)
        Me.pnlMain.TabIndex = 2
        '
        'gbPreview
        '
        Me.gbPreview.Controls.Add(Me.pnlTrailerPreview)
        Me.gbPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPreview.Location = New System.Drawing.Point(597, 9)
        Me.gbPreview.Name = "gbPreview"
        Me.gbPreview.Size = New System.Drawing.Size(396, 250)
        Me.gbPreview.TabIndex = 9
        Me.gbPreview.TabStop = False
        Me.gbPreview.Text = "Preview"
        '
        'pnlTrailerPreview
        '
        Me.pnlTrailerPreview.BackColor = System.Drawing.Color.DimGray
        Me.pnlTrailerPreview.Controls.Add(Me.pnlTrailerPreviewNoPlayer)
        Me.pnlTrailerPreview.Location = New System.Drawing.Point(7, 22)
        Me.pnlTrailerPreview.Name = "pnlTrailerPreview"
        Me.pnlTrailerPreview.Size = New System.Drawing.Size(384, 216)
        Me.pnlTrailerPreview.TabIndex = 16
        '
        'pnlTrailerPreviewNoPlayer
        '
        Me.pnlTrailerPreviewNoPlayer.BackColor = System.Drawing.Color.White
        Me.pnlTrailerPreviewNoPlayer.Controls.Add(Me.tblTrailerPreviewNoPlayer)
        Me.pnlTrailerPreviewNoPlayer.Location = New System.Drawing.Point(78, 77)
        Me.pnlTrailerPreviewNoPlayer.Name = "pnlTrailerPreviewNoPlayer"
        Me.pnlTrailerPreviewNoPlayer.Size = New System.Drawing.Size(242, 56)
        Me.pnlTrailerPreviewNoPlayer.TabIndex = 0
        '
        'tblTrailerPreviewNoPlayer
        '
        Me.tblTrailerPreviewNoPlayer.AutoSize = True
        Me.tblTrailerPreviewNoPlayer.ColumnCount = 1
        Me.tblTrailerPreviewNoPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTrailerPreviewNoPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblTrailerPreviewNoPlayer.Controls.Add(Me.lblTrailerPreviewNoPlayer, 0, 0)
        Me.tblTrailerPreviewNoPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTrailerPreviewNoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.tblTrailerPreviewNoPlayer.Name = "tblTrailerPreviewNoPlayer"
        Me.tblTrailerPreviewNoPlayer.RowCount = 1
        Me.tblTrailerPreviewNoPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTrailerPreviewNoPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tblTrailerPreviewNoPlayer.Size = New System.Drawing.Size(242, 56)
        Me.tblTrailerPreviewNoPlayer.TabIndex = 0
        '
        'lblTrailerPreviewNoPlayer
        '
        Me.lblTrailerPreviewNoPlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTrailerPreviewNoPlayer.AutoSize = True
        Me.lblTrailerPreviewNoPlayer.Location = New System.Drawing.Point(52, 21)
        Me.lblTrailerPreviewNoPlayer.Name = "lblTrailerPreviewNoPlayer"
        Me.lblTrailerPreviewNoPlayer.Size = New System.Drawing.Size(137, 13)
        Me.lblTrailerPreviewNoPlayer.TabIndex = 0
        Me.lblTrailerPreviewNoPlayer.Text = "no Media Player enabled"
        '
        'btnPlayInBrowser
        '
        Me.btnPlayInBrowser.Enabled = False
        Me.btnPlayInBrowser.Location = New System.Drawing.Point(3, 3)
        Me.btnPlayInBrowser.Name = "btnPlayInBrowser"
        Me.btnPlayInBrowser.Size = New System.Drawing.Size(120, 23)
        Me.btnPlayInBrowser.TabIndex = 4
        Me.btnPlayInBrowser.Text = "Open In Browser"
        Me.btnPlayInBrowser.UseVisualStyleBackColor = True
        '
        'pblBottom
        '
        Me.pblBottom.AutoSize = True
        Me.pblBottom.Controls.Add(Me.tblBottom)
        Me.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pblBottom.Location = New System.Drawing.Point(0, 455)
        Me.pblBottom.Name = "pblBottom"
        Me.pblBottom.Size = New System.Drawing.Size(1001, 29)
        Me.pblBottom.TabIndex = 8
        '
        'tblBottom
        '
        Me.tblBottom.AutoSize = True
        Me.tblBottom.ColumnCount = 4
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblBottom.Controls.Add(Me.btnPlayInBrowser, 0, 0)
        Me.tblBottom.Controls.Add(Me.OK_Button, 2, 0)
        Me.tblBottom.Controls.Add(Me.Cancel_Button, 3, 0)
        Me.tblBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBottom.Location = New System.Drawing.Point(0, 0)
        Me.tblBottom.Name = "tblBottom"
        Me.tblBottom.RowCount = 1
        Me.tblBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblBottom.Size = New System.Drawing.Size(1001, 29)
        Me.tblBottom.TabIndex = 0
        '
        'dlgTrailerSelect
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1001, 484)
        Me.Controls.Add(Me.pblBottom)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTrailerSelect"
        Me.Text = "Select Trailer"
        Me.gbSelectTrailer.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.gbYouTubeSearch.ResumeLayout(False)
        Me.gbYouTubeSearch.PerformLayout()
        Me.gbManualTrailer.ResumeLayout(False)
        Me.gbManualTrailer.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.gbPreview.ResumeLayout(False)
        Me.pnlTrailerPreview.ResumeLayout(False)
        Me.pnlTrailerPreviewNoPlayer.ResumeLayout(False)
        Me.pnlTrailerPreviewNoPlayer.PerformLayout()
        Me.tblTrailerPreviewNoPlayer.ResumeLayout(False)
        Me.tblTrailerPreviewNoPlayer.PerformLayout()
        Me.pblBottom.ResumeLayout(False)
        Me.pblBottom.PerformLayout()
        Me.tblBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbSelectTrailer As System.Windows.Forms.GroupBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents btnPlayLocalTrailer As System.Windows.Forms.Button
    Friend WithEvents gbManualTrailer As System.Windows.Forms.GroupBox
    Friend WithEvents lblManualTrailerLink As System.Windows.Forms.Label
    Friend WithEvents txtManualTrailerLink As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseLocalTrailer As System.Windows.Forms.Button
    Friend WithEvents txtLocalTrailer As System.Windows.Forms.TextBox
    Friend WithEvents lblLocalTrailer As System.Windows.Forms.Label
    Friend WithEvents ofdTrailer As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnPlayInBrowser As System.Windows.Forms.Button
    Friend WithEvents lvTrailers As System.Windows.Forms.ListView
    Friend WithEvents gbPreview As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearManualTrailerLink As System.Windows.Forms.Button
    Friend WithEvents gbYouTubeSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnYouTubeSearch As System.Windows.Forms.Button
    Friend WithEvents txtYouTubeSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnTrailerScrape As System.Windows.Forms.Button
    Friend WithEvents colURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents colWebURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDuration As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVideoQuality As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSource As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlTrailerPreview As System.Windows.Forms.Panel
    Friend WithEvents pnlTrailerPreviewNoPlayer As System.Windows.Forms.Panel
    Friend WithEvents tblTrailerPreviewNoPlayer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTrailerPreviewNoPlayer As System.Windows.Forms.Label
    Friend WithEvents pblBottom As System.Windows.Forms.Panel
    Friend WithEvents tblBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents colScraper As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVideoType As System.Windows.Forms.ColumnHeader

End Class
