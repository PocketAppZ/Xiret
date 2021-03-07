<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdate))
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdDownload = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.LabDownload = New System.Windows.Forms.Label()
        Me.TlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.LabServer = New System.Windows.Forms.Label()
        Me.LabCurrent = New System.Windows.Forms.Label()
        Me.LabText2 = New System.Windows.Forms.Label()
        Me.LabText1 = New System.Windows.Forms.Label()
        Me.TlpLink = New System.Windows.Forms.TableLayoutPanel()
        Me.LabLink = New System.Windows.Forms.Label()
        Me.LnkChangelog = New System.Windows.Forms.LinkLabel()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        Me.TlpMiddle.SuspendLayout()
        Me.TlpGrid.SuspendLayout()
        Me.TlpLink.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(408, 2)
        Me.PanSplit.TabIndex = 74
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(408, 40)
        Me.PanHead.TabIndex = 73
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(40, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(328, 40)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "Update"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TlpHeadImage.Controls.Add(Me.PbxHead, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(40, 40)
        Me.TlpHeadImage.TabIndex = 71
        '
        'PbxHead
        '
        Me.PbxHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxHead.BackColor = System.Drawing.Color.Transparent
        Me.PbxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxHead.Location = New System.Drawing.Point(9, 8)
        Me.PbxHead.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PbxHead.Name = "PbxHead"
        Me.PbxHead.Size = New System.Drawing.Size(24, 24)
        Me.PbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHead.TabIndex = 1
        Me.PbxHead.TabStop = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(368, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 7
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpBottom)
        Me.PanMain.Controls.Add(Me.TlpMiddle)
        Me.PanMain.Controls.Add(Me.TlpLink)
        Me.PanMain.Controls.Add(Me.LabInfo)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(408, 271)
        Me.PanMain.TabIndex = 75
        '
        'TlpBottom
        '
        Me.TlpBottom.ColumnCount = 3
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98039!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.85294!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.92157!))
        Me.TlpBottom.Controls.Add(Me.CmdDownload, 2, 0)
        Me.TlpBottom.Controls.Add(Me.CmdCancel, 1, 0)
        Me.TlpBottom.Controls.Add(Me.LabDownload, 0, 0)
        Me.TlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TlpBottom.Location = New System.Drawing.Point(0, 217)
        Me.TlpBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 1
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(408, 54)
        Me.TlpBottom.TabIndex = 141
        '
        'CmdDownload
        '
        Me.CmdDownload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDownload.Enabled = False
        Me.CmdDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDownload.FlatAppearance.BorderSize = 0
        Me.CmdDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDownload.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDownload.Location = New System.Drawing.Point(296, 7)
        Me.CmdDownload.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdDownload.Name = "CmdDownload"
        Me.CmdDownload.Size = New System.Drawing.Size(104, 39)
        Me.CmdDownload.TabIndex = 3
        Me.CmdDownload.Text = "Download"
        Me.CmdDownload.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(210, 7)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(76, 39)
        Me.CmdCancel.TabIndex = 1
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'LabDownload
        '
        Me.LabDownload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabDownload.AutoSize = True
        Me.LabDownload.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDownload.ForeColor = System.Drawing.Color.White
        Me.LabDownload.Location = New System.Drawing.Point(3, 17)
        Me.LabDownload.Name = "LabDownload"
        Me.LabDownload.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabDownload.Size = New System.Drawing.Size(10, 20)
        Me.LabDownload.TabIndex = 4
        Me.LabDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TlpMiddle
        '
        Me.TlpMiddle.ColumnCount = 1
        Me.TlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpMiddle.Controls.Add(Me.TlpGrid, 0, 0)
        Me.TlpMiddle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpMiddle.Location = New System.Drawing.Point(0, 68)
        Me.TlpMiddle.Name = "TlpMiddle"
        Me.TlpMiddle.RowCount = 1
        Me.TlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpMiddle.Size = New System.Drawing.Size(408, 121)
        Me.TlpMiddle.TabIndex = 140
        '
        'TlpGrid
        '
        Me.TlpGrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TlpGrid.ColumnCount = 2
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.19629!))
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.80371!))
        Me.TlpGrid.Controls.Add(Me.LabServer, 1, 1)
        Me.TlpGrid.Controls.Add(Me.LabCurrent, 1, 0)
        Me.TlpGrid.Controls.Add(Me.LabText2, 0, 1)
        Me.TlpGrid.Controls.Add(Me.LabText1, 0, 0)
        Me.TlpGrid.Location = New System.Drawing.Point(9, 20)
        Me.TlpGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpGrid.Name = "TlpGrid"
        Me.TlpGrid.RowCount = 2
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpGrid.Size = New System.Drawing.Size(390, 80)
        Me.TlpGrid.TabIndex = 87
        '
        'LabServer
        '
        Me.LabServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LabServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabServer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabServer.ForeColor = System.Drawing.Color.White
        Me.LabServer.Location = New System.Drawing.Point(148, 40)
        Me.LabServer.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.LabServer.Name = "LabServer"
        Me.LabServer.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.LabServer.Size = New System.Drawing.Size(242, 39)
        Me.LabServer.TabIndex = 86
        Me.LabServer.Text = "..."
        Me.LabServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabCurrent
        '
        Me.LabCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LabCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabCurrent.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCurrent.ForeColor = System.Drawing.Color.White
        Me.LabCurrent.Location = New System.Drawing.Point(148, 0)
        Me.LabCurrent.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.LabCurrent.Name = "LabCurrent"
        Me.LabCurrent.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.LabCurrent.Size = New System.Drawing.Size(242, 39)
        Me.LabCurrent.TabIndex = 85
        Me.LabCurrent.Text = "..."
        Me.LabCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabText2
        '
        Me.LabText2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LabText2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabText2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabText2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabText2.Location = New System.Drawing.Point(0, 40)
        Me.LabText2.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.LabText2.Name = "LabText2"
        Me.LabText2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.LabText2.Size = New System.Drawing.Size(147, 39)
        Me.LabText2.TabIndex = 84
        Me.LabText2.Text = "Server Version"
        Me.LabText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabText1
        '
        Me.LabText1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LabText1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabText1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabText1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabText1.Location = New System.Drawing.Point(0, 0)
        Me.LabText1.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.LabText1.Name = "LabText1"
        Me.LabText1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.LabText1.Size = New System.Drawing.Size(147, 39)
        Me.LabText1.TabIndex = 83
        Me.LabText1.Text = "Current Version"
        Me.LabText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TlpLink
        '
        Me.TlpLink.ColumnCount = 2
        Me.TlpLink.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TlpLink.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLink.Controls.Add(Me.LabLink, 0, 0)
        Me.TlpLink.Controls.Add(Me.LnkChangelog, 1, 0)
        Me.TlpLink.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpLink.Location = New System.Drawing.Point(0, 38)
        Me.TlpLink.Name = "TlpLink"
        Me.TlpLink.RowCount = 1
        Me.TlpLink.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLink.Size = New System.Drawing.Size(408, 30)
        Me.TlpLink.TabIndex = 139
        '
        'LabLink
        '
        Me.LabLink.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabLink.AutoSize = True
        Me.LabLink.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabLink.Location = New System.Drawing.Point(3, 5)
        Me.LabLink.Name = "LabLink"
        Me.LabLink.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabLink.Size = New System.Drawing.Size(34, 19)
        Me.LabLink.TabIndex = 137
        Me.LabLink.Text = ""
        '
        'LnkChangelog
        '
        Me.LnkChangelog.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkChangelog.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LnkChangelog.AutoSize = True
        Me.LnkChangelog.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkChangelog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkChangelog.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkChangelog.Location = New System.Drawing.Point(40, 3)
        Me.LnkChangelog.Margin = New System.Windows.Forms.Padding(0)
        Me.LnkChangelog.Name = "LnkChangelog"
        Me.LnkChangelog.Size = New System.Drawing.Size(135, 23)
        Me.LnkChangelog.TabIndex = 0
        Me.LnkChangelog.TabStop = True
        Me.LnkChangelog.Text = "View Changelog"
        '
        'LabInfo
        '
        Me.LabInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.White
        Me.LabInfo.Location = New System.Drawing.Point(0, 0)
        Me.LabInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Padding = New System.Windows.Forms.Padding(10, 8, 0, 0)
        Me.LabInfo.Size = New System.Drawing.Size(408, 38)
        Me.LabInfo.TabIndex = 85
        Me.LabInfo.Text = "..."
        Me.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 315)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(410, 315)
        Me.MinimumSize = New System.Drawing.Size(410, 315)
        Me.Name = "FormUpdate"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpBottom.ResumeLayout(False)
        Me.TlpBottom.PerformLayout()
        Me.TlpMiddle.ResumeLayout(False)
        Me.TlpGrid.ResumeLayout(False)
        Me.TlpLink.ResumeLayout(False)
        Me.TlpLink.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents LnkChangelog As System.Windows.Forms.LinkLabel
    Friend WithEvents LabInfo As System.Windows.Forms.Label
    Friend WithEvents TlpGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents LabServer As Label
    Friend WithEvents LabCurrent As Label
    Friend WithEvents LabText2 As Label
    Friend WithEvents LabText1 As Label
    Friend WithEvents LabDownload As Label
    Friend WithEvents CmdDownload As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents TlpLink As TableLayoutPanel
    Friend WithEvents LabLink As Label
    Friend WithEvents TlpBottom As TableLayoutPanel
    Friend WithEvents TlpMiddle As TableLayoutPanel
End Class
