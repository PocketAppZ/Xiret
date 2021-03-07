<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAckn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAckn))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpImgLinks = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.PbxError = New System.Windows.Forms.PictureBox()
        Me.LnkError = New System.Windows.Forms.LinkLabel()
        Me.PbxInfo = New System.Windows.Forms.PictureBox()
        Me.PbxWarn = New System.Windows.Forms.PictureBox()
        Me.LnkGraph = New System.Windows.Forms.LinkLabel()
        Me.LnkWarn = New System.Windows.Forms.LinkLabel()
        Me.LnkIcon = New System.Windows.Forms.LinkLabel()
        Me.LabImages = New System.Windows.Forms.Label()
        Me.LabCopyrights = New System.Windows.Forms.Label()
        Me.LnkMicrosoft = New System.Windows.Forms.LinkLabel()
        Me.LabThanks = New System.Windows.Forms.Label()
        Me.LnkCredits = New System.Windows.Forms.LinkLabel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        Me.TlpImgLinks.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxWarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(414, 32)
        Me.PanHead.TabIndex = 70
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(32, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(350, 32)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "Acknowledgements"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(382, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(32, 32)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TlpHeadImage.Controls.Add(Me.PbxHead, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(32, 32)
        Me.TlpHeadImage.TabIndex = 74
        '
        'PbxHead
        '
        Me.PbxHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxHead.BackColor = System.Drawing.Color.Transparent
        Me.PbxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxHead.Location = New System.Drawing.Point(7, 6)
        Me.PbxHead.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.PbxHead.Name = "PbxHead"
        Me.PbxHead.Size = New System.Drawing.Size(19, 19)
        Me.PbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHead.TabIndex = 1
        Me.PbxHead.TabStop = False
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 33)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(414, 2)
        Me.PanSplit.TabIndex = 73
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpTop)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 35)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.PanMain.Size = New System.Drawing.Size(414, 364)
        Me.PanMain.TabIndex = 74
        '
        'TlpTop
        '
        Me.TlpTop.ColumnCount = 1
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.Controls.Add(Me.TlpBottom, 0, 6)
        Me.TlpTop.Controls.Add(Me.LabCopyrights, 0, 0)
        Me.TlpTop.Controls.Add(Me.LnkMicrosoft, 0, 1)
        Me.TlpTop.Controls.Add(Me.LabThanks, 0, 3)
        Me.TlpTop.Controls.Add(Me.LnkCredits, 0, 4)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpTop.Location = New System.Drawing.Point(7, 7)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 7
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TlpTop.Size = New System.Drawing.Size(400, 350)
        Me.TlpTop.TabIndex = 1
        '
        'TlpBottom
        '
        Me.TlpBottom.ColumnCount = 1
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TlpBottom.Controls.Add(Me.TlpImgLinks, 0, 1)
        Me.TlpBottom.Controls.Add(Me.LabImages, 0, 0)
        Me.TlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpBottom.Location = New System.Drawing.Point(0, 210)
        Me.TlpBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 2
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(400, 140)
        Me.TlpBottom.TabIndex = 0
        '
        'TlpImgLinks
        '
        Me.TlpImgLinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TlpImgLinks.ColumnCount = 2
        Me.TlpImgLinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849558!))
        Me.TlpImgLinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.15044!))
        Me.TlpImgLinks.Controls.Add(Me.PbxLogo, 0, 1)
        Me.TlpImgLinks.Controls.Add(Me.PbxError, 0, 4)
        Me.TlpImgLinks.Controls.Add(Me.LnkError, 1, 4)
        Me.TlpImgLinks.Controls.Add(Me.PbxInfo, 0, 2)
        Me.TlpImgLinks.Controls.Add(Me.PbxWarn, 0, 3)
        Me.TlpImgLinks.Controls.Add(Me.LnkGraph, 1, 1)
        Me.TlpImgLinks.Controls.Add(Me.LnkWarn, 1, 3)
        Me.TlpImgLinks.Controls.Add(Me.LnkIcon, 1, 2)
        Me.TlpImgLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpImgLinks.Location = New System.Drawing.Point(0, 24)
        Me.TlpImgLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpImgLinks.Name = "TlpImgLinks"
        Me.TlpImgLinks.RowCount = 6
        Me.TlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TlpImgLinks.Size = New System.Drawing.Size(400, 116)
        Me.TlpImgLinks.TabIndex = 129
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(8, 7)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(19, 19)
        Me.PbxLogo.TabIndex = 0
        Me.PbxLogo.TabStop = False
        '
        'PbxError
        '
        Me.PbxError.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxError.Location = New System.Drawing.Point(8, 91)
        Me.PbxError.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxError.Name = "PbxError"
        Me.PbxError.Size = New System.Drawing.Size(19, 19)
        Me.PbxError.TabIndex = 2
        Me.PbxError.TabStop = False
        '
        'LnkError
        '
        Me.LnkError.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkError.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LnkError.AutoSize = True
        Me.LnkError.BackColor = System.Drawing.Color.Transparent
        Me.LnkError.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkError.ForeColor = System.Drawing.Color.White
        Me.LnkError.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkError.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkError.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkError.Location = New System.Drawing.Point(37, 91)
        Me.LnkError.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LnkError.Name = "LnkError"
        Me.LnkError.Size = New System.Drawing.Size(249, 19)
        Me.LnkError.TabIndex = 14
        Me.LnkError.Text = "Error icon by Smashicons from Flaticon."
        Me.LnkError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PbxInfo
        '
        Me.PbxInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxInfo.Location = New System.Drawing.Point(8, 35)
        Me.PbxInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxInfo.Name = "PbxInfo"
        Me.PbxInfo.Size = New System.Drawing.Size(19, 19)
        Me.PbxInfo.TabIndex = 1
        Me.PbxInfo.TabStop = False
        '
        'PbxWarn
        '
        Me.PbxWarn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxWarn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxWarn.Location = New System.Drawing.Point(8, 63)
        Me.PbxWarn.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxWarn.Name = "PbxWarn"
        Me.PbxWarn.Size = New System.Drawing.Size(19, 19)
        Me.PbxWarn.TabIndex = 3
        Me.PbxWarn.TabStop = False
        '
        'LnkGraph
        '
        Me.LnkGraph.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkGraph.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LnkGraph.AutoSize = True
        Me.LnkGraph.BackColor = System.Drawing.Color.Transparent
        Me.LnkGraph.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkGraph.ForeColor = System.Drawing.Color.White
        Me.LnkGraph.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkGraph.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkGraph.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkGraph.Location = New System.Drawing.Point(37, 7)
        Me.LnkGraph.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LnkGraph.Name = "LnkGraph"
        Me.LnkGraph.Size = New System.Drawing.Size(279, 19)
        Me.LnkGraph.TabIndex = 1
        Me.LnkGraph.Text = "Graph icon by Vectors Market from Flaticon."
        Me.LnkGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkWarn
        '
        Me.LnkWarn.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkWarn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LnkWarn.AutoSize = True
        Me.LnkWarn.BackColor = System.Drawing.Color.Transparent
        Me.LnkWarn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkWarn.ForeColor = System.Drawing.Color.White
        Me.LnkWarn.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkWarn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkWarn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkWarn.Location = New System.Drawing.Point(37, 63)
        Me.LnkWarn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LnkWarn.Name = "LnkWarn"
        Me.LnkWarn.Size = New System.Drawing.Size(243, 19)
        Me.LnkWarn.TabIndex = 132
        Me.LnkWarn.Text = "Warning icon by Freepik from Flaticon."
        Me.LnkWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkIcon
        '
        Me.LnkIcon.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkIcon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LnkIcon.AutoSize = True
        Me.LnkIcon.BackColor = System.Drawing.Color.Transparent
        Me.LnkIcon.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkIcon.ForeColor = System.Drawing.Color.White
        Me.LnkIcon.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkIcon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkIcon.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkIcon.Location = New System.Drawing.Point(37, 35)
        Me.LnkIcon.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LnkIcon.Name = "LnkIcon"
        Me.LnkIcon.Size = New System.Drawing.Size(264, 19)
        Me.LnkIcon.TabIndex = 11
        Me.LnkIcon.Text = "Information icon by Freepik from Flaticon."
        Me.LnkIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabImages
        '
        Me.LabImages.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LabImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabImages.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabImages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabImages.Location = New System.Drawing.Point(0, 0)
        Me.LabImages.Margin = New System.Windows.Forms.Padding(0)
        Me.LabImages.Name = "LabImages"
        Me.LabImages.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabImages.Size = New System.Drawing.Size(400, 24)
        Me.LabImages.TabIndex = 127
        Me.LabImages.Text = "Image Resources"
        Me.LabImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabCopyrights
        '
        Me.LabCopyrights.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LabCopyrights.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabCopyrights.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCopyrights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabCopyrights.Location = New System.Drawing.Point(0, 0)
        Me.LabCopyrights.Margin = New System.Windows.Forms.Padding(0)
        Me.LabCopyrights.Name = "LabCopyrights"
        Me.LabCopyrights.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabCopyrights.Size = New System.Drawing.Size(400, 24)
        Me.LabCopyrights.TabIndex = 125
        Me.LabCopyrights.Text = "Copyrights"
        Me.LabCopyrights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkMicrosoft
        '
        Me.LnkMicrosoft.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkMicrosoft.AutoSize = True
        Me.LnkMicrosoft.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LnkMicrosoft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LnkMicrosoft.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkMicrosoft.ForeColor = System.Drawing.Color.White
        Me.LnkMicrosoft.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkMicrosoft.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkMicrosoft.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkMicrosoft.Location = New System.Drawing.Point(0, 24)
        Me.LnkMicrosoft.Margin = New System.Windows.Forms.Padding(0)
        Me.LnkMicrosoft.Name = "LnkMicrosoft"
        Me.LnkMicrosoft.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LnkMicrosoft.Size = New System.Drawing.Size(400, 80)
        Me.LnkMicrosoft.TabIndex = 129
        Me.LnkMicrosoft.Text = "Microsoft®, Windows®, and the Windows® Experience Index are either registered tra" &
    "demarks or trademarks of Microsoft Corporation in the United States and/or other" &
    " countries."
        Me.LnkMicrosoft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabThanks
        '
        Me.LabThanks.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LabThanks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabThanks.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabThanks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabThanks.Location = New System.Drawing.Point(0, 105)
        Me.LabThanks.Margin = New System.Windows.Forms.Padding(0)
        Me.LabThanks.Name = "LabThanks"
        Me.LabThanks.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabThanks.Size = New System.Drawing.Size(400, 24)
        Me.LabThanks.TabIndex = 126
        Me.LabThanks.Text = "Thank you"
        Me.LabThanks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkCredits
        '
        Me.LnkCredits.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkCredits.AutoSize = True
        Me.LnkCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LnkCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LnkCredits.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkCredits.ForeColor = System.Drawing.Color.White
        Me.LnkCredits.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkCredits.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkCredits.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkCredits.Location = New System.Drawing.Point(0, 129)
        Me.LnkCredits.Margin = New System.Windows.Forms.Padding(0)
        Me.LnkCredits.Name = "LnkCredits"
        Me.LnkCredits.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LnkCredits.Size = New System.Drawing.Size(400, 80)
        Me.LnkCredits.TabIndex = 130
        Me.LnkCredits.Text = "ItielMaN, Carlos Detweiller, Michaela Joy, Tiger-1, BJ0RN, apologized and GezoeSl" &
    "oog at MyDigitalLife for development help and testing. Majorgeeks and Softpedia " &
    "for hosting my software."
        Me.LnkCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormAckn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 400)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(416, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(416, 400)
        Me.Name = "FormAckn"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acknowledgements"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        Me.TlpTop.PerformLayout()
        Me.TlpBottom.ResumeLayout(False)
        Me.TlpImgLinks.ResumeLayout(False)
        Me.TlpImgLinks.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxWarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanHead As Panel
    Friend WithEvents LabHead As Label
    Friend WithEvents CmdClose As Button
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents PanSplit As Panel
    Friend WithEvents PanMain As Panel
    Friend WithEvents TlpBottom As TableLayoutPanel
    Friend WithEvents TlpTop As TableLayoutPanel
    Friend WithEvents LabCopyrights As Label
    Friend WithEvents LabThanks As Label
    Friend WithEvents LnkMicrosoft As LinkLabel
    Friend WithEvents LnkCredits As LinkLabel
    Friend WithEvents LabImages As Label
    Friend WithEvents TlpImgLinks As TableLayoutPanel
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents PbxError As PictureBox
    Friend WithEvents LnkError As LinkLabel
    Friend WithEvents PbxInfo As PictureBox
    Friend WithEvents PbxWarn As PictureBox
    Friend WithEvents LnkGraph As LinkLabel
    Friend WithEvents LnkWarn As LinkLabel
    Friend WithEvents LnkIcon As LinkLabel
End Class
