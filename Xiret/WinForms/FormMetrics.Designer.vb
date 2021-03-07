<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMetrics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMetrics))
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.RtbData = New System.Windows.Forms.RichTextBox()
        Me.TlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdProgramInfo = New System.Windows.Forms.Button()
        Me.CmdSysEnviron = New System.Windows.Forms.Button()
        Me.CmdWinSpr = New System.Windows.Forms.Button()
        Me.CmdMetrics = New System.Windows.Forms.Button()
        Me.CmdOS = New System.Windows.Forms.Button()
        Me.CmdGraphics = New System.Windows.Forms.Button()
        Me.CmdMemory = New System.Windows.Forms.Button()
        Me.CmdProcessor = New System.Windows.Forms.Button()
        Me.CmdSystem = New System.Windows.Forms.Button()
        Me.CmdDisk = New System.Windows.Forms.Button()
        Me.CmdDwm = New System.Windows.Forms.Button()
        Me.CmdD3D = New System.Windows.Forms.Button()
        Me.PbxProgramInfo = New System.Windows.Forms.PictureBox()
        Me.PbxSystemEnvironment = New System.Windows.Forms.PictureBox()
        Me.PbxWinSPR = New System.Windows.Forms.PictureBox()
        Me.PbxMetrics = New System.Windows.Forms.PictureBox()
        Me.PbxOSVersion = New System.Windows.Forms.PictureBox()
        Me.PbxSystem = New System.Windows.Forms.PictureBox()
        Me.PbxProcessor = New System.Windows.Forms.PictureBox()
        Me.PbxMemory = New System.Windows.Forms.PictureBox()
        Me.PbxGraphics = New System.Windows.Forms.PictureBox()
        Me.PbxDisk = New System.Windows.Forms.PictureBox()
        Me.PbxDwm = New System.Windows.Forms.PictureBox()
        Me.PbxD3d = New System.Windows.Forms.PictureBox()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.TlpMenu.SuspendLayout()
        CType(Me.PbxProgramInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSystemEnvironment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxWinSPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxOSVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxProcessor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMemory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGraphics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxDisk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxDwm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxD3d, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(998, 2)
        Me.PanSplit.TabIndex = 74
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(998, 40)
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
        Me.LabHead.Size = New System.Drawing.Size(918, 40)
        Me.LabHead.TabIndex = 96
        Me.LabHead.Text = "Metrics"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.CmdClose.Location = New System.Drawing.Point(958, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 95
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
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
        Me.TlpHeadImage.TabIndex = 74
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
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpMain)
        Me.PanMain.Controls.Add(Me.TlpMenu)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(998, 556)
        Me.PanMain.TabIndex = 75
        '
        'TlpMain
        '
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpMain.Controls.Add(Me.RtbData, 0, 0)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMain.Location = New System.Drawing.Point(197, 0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.Padding = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.TlpMain.RowCount = 1
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpMain.Size = New System.Drawing.Size(801, 556)
        Me.TlpMain.TabIndex = 2
        '
        'RtbData
        '
        Me.RtbData.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RtbData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtbData.DetectUrls = False
        Me.RtbData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbData.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbData.ForeColor = System.Drawing.Color.White
        Me.RtbData.Location = New System.Drawing.Point(7, 12)
        Me.RtbData.Name = "RtbData"
        Me.RtbData.ReadOnly = True
        Me.RtbData.Size = New System.Drawing.Size(787, 532)
        Me.RtbData.TabIndex = 0
        Me.RtbData.TabStop = False
        Me.RtbData.Text = ""
        '
        'TlpMenu
        '
        Me.TlpMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TlpMenu.ColumnCount = 2
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TlpMenu.Controls.Add(Me.CmdProgramInfo, 0, 1)
        Me.TlpMenu.Controls.Add(Me.CmdSysEnviron, 0, 2)
        Me.TlpMenu.Controls.Add(Me.CmdWinSpr, 0, 3)
        Me.TlpMenu.Controls.Add(Me.CmdMetrics, 0, 4)
        Me.TlpMenu.Controls.Add(Me.CmdOS, 0, 5)
        Me.TlpMenu.Controls.Add(Me.CmdGraphics, 0, 9)
        Me.TlpMenu.Controls.Add(Me.CmdMemory, 0, 8)
        Me.TlpMenu.Controls.Add(Me.CmdProcessor, 0, 7)
        Me.TlpMenu.Controls.Add(Me.CmdSystem, 0, 6)
        Me.TlpMenu.Controls.Add(Me.CmdDisk, 0, 10)
        Me.TlpMenu.Controls.Add(Me.CmdDwm, 0, 11)
        Me.TlpMenu.Controls.Add(Me.CmdD3D, 0, 12)
        Me.TlpMenu.Controls.Add(Me.PbxProgramInfo, 1, 1)
        Me.TlpMenu.Controls.Add(Me.PbxSystemEnvironment, 1, 2)
        Me.TlpMenu.Controls.Add(Me.PbxWinSPR, 1, 3)
        Me.TlpMenu.Controls.Add(Me.PbxMetrics, 1, 4)
        Me.TlpMenu.Controls.Add(Me.PbxOSVersion, 1, 5)
        Me.TlpMenu.Controls.Add(Me.PbxSystem, 1, 6)
        Me.TlpMenu.Controls.Add(Me.PbxProcessor, 1, 7)
        Me.TlpMenu.Controls.Add(Me.PbxMemory, 1, 8)
        Me.TlpMenu.Controls.Add(Me.PbxGraphics, 1, 9)
        Me.TlpMenu.Controls.Add(Me.PbxDisk, 1, 10)
        Me.TlpMenu.Controls.Add(Me.PbxDwm, 1, 11)
        Me.TlpMenu.Controls.Add(Me.PbxD3d, 1, 12)
        Me.TlpMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.TlpMenu.Name = "TlpMenu"
        Me.TlpMenu.RowCount = 14
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpMenu.Size = New System.Drawing.Size(197, 556)
        Me.TlpMenu.TabIndex = 0
        '
        'CmdProgramInfo
        '
        Me.CmdProgramInfo.BackColor = System.Drawing.Color.Transparent
        Me.CmdProgramInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdProgramInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdProgramInfo.FlatAppearance.BorderSize = 0
        Me.CmdProgramInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdProgramInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdProgramInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdProgramInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdProgramInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdProgramInfo.Location = New System.Drawing.Point(0, 10)
        Me.CmdProgramInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdProgramInfo.Name = "CmdProgramInfo"
        Me.CmdProgramInfo.Size = New System.Drawing.Size(195, 36)
        Me.CmdProgramInfo.TabIndex = 0
        Me.CmdProgramInfo.Text = "  ProgramInfo"
        Me.CmdProgramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProgramInfo.UseVisualStyleBackColor = False
        '
        'CmdSysEnviron
        '
        Me.CmdSysEnviron.BackColor = System.Drawing.Color.Transparent
        Me.CmdSysEnviron.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdSysEnviron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdSysEnviron.FlatAppearance.BorderSize = 0
        Me.CmdSysEnviron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdSysEnviron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdSysEnviron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSysEnviron.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSysEnviron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdSysEnviron.Location = New System.Drawing.Point(0, 46)
        Me.CmdSysEnviron.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSysEnviron.Name = "CmdSysEnviron"
        Me.CmdSysEnviron.Size = New System.Drawing.Size(195, 36)
        Me.CmdSysEnviron.TabIndex = 1
        Me.CmdSysEnviron.Text = "  SystemEnvironment"
        Me.CmdSysEnviron.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSysEnviron.UseVisualStyleBackColor = False
        '
        'CmdWinSpr
        '
        Me.CmdWinSpr.BackColor = System.Drawing.Color.Transparent
        Me.CmdWinSpr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdWinSpr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdWinSpr.FlatAppearance.BorderSize = 0
        Me.CmdWinSpr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdWinSpr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdWinSpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdWinSpr.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdWinSpr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdWinSpr.Location = New System.Drawing.Point(0, 82)
        Me.CmdWinSpr.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdWinSpr.Name = "CmdWinSpr"
        Me.CmdWinSpr.Size = New System.Drawing.Size(195, 36)
        Me.CmdWinSpr.TabIndex = 2
        Me.CmdWinSpr.Text = "  WinSPR"
        Me.CmdWinSpr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdWinSpr.UseVisualStyleBackColor = False
        '
        'CmdMetrics
        '
        Me.CmdMetrics.BackColor = System.Drawing.Color.Transparent
        Me.CmdMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdMetrics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdMetrics.FlatAppearance.BorderSize = 0
        Me.CmdMetrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdMetrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdMetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMetrics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMetrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdMetrics.Location = New System.Drawing.Point(0, 118)
        Me.CmdMetrics.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdMetrics.Name = "CmdMetrics"
        Me.CmdMetrics.Size = New System.Drawing.Size(195, 36)
        Me.CmdMetrics.TabIndex = 3
        Me.CmdMetrics.Text = "  Metrics"
        Me.CmdMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMetrics.UseVisualStyleBackColor = False
        '
        'CmdOS
        '
        Me.CmdOS.BackColor = System.Drawing.Color.Transparent
        Me.CmdOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdOS.FlatAppearance.BorderSize = 0
        Me.CmdOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOS.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdOS.Location = New System.Drawing.Point(0, 154)
        Me.CmdOS.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdOS.Name = "CmdOS"
        Me.CmdOS.Size = New System.Drawing.Size(195, 36)
        Me.CmdOS.TabIndex = 4
        Me.CmdOS.Text = "  OSVersion"
        Me.CmdOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOS.UseVisualStyleBackColor = False
        '
        'CmdGraphics
        '
        Me.CmdGraphics.BackColor = System.Drawing.Color.Transparent
        Me.CmdGraphics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdGraphics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdGraphics.FlatAppearance.BorderSize = 0
        Me.CmdGraphics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdGraphics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGraphics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGraphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdGraphics.Location = New System.Drawing.Point(0, 298)
        Me.CmdGraphics.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdGraphics.Name = "CmdGraphics"
        Me.CmdGraphics.Size = New System.Drawing.Size(195, 36)
        Me.CmdGraphics.TabIndex = 8
        Me.CmdGraphics.Text = "  Graphics"
        Me.CmdGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGraphics.UseVisualStyleBackColor = False
        '
        'CmdMemory
        '
        Me.CmdMemory.BackColor = System.Drawing.Color.Transparent
        Me.CmdMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdMemory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdMemory.FlatAppearance.BorderSize = 0
        Me.CmdMemory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMemory.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdMemory.Location = New System.Drawing.Point(0, 262)
        Me.CmdMemory.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdMemory.Name = "CmdMemory"
        Me.CmdMemory.Size = New System.Drawing.Size(195, 36)
        Me.CmdMemory.TabIndex = 7
        Me.CmdMemory.Text = "  Memory (RAM)"
        Me.CmdMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMemory.UseVisualStyleBackColor = False
        '
        'CmdProcessor
        '
        Me.CmdProcessor.BackColor = System.Drawing.Color.Transparent
        Me.CmdProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdProcessor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdProcessor.FlatAppearance.BorderSize = 0
        Me.CmdProcessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdProcessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdProcessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdProcessor.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdProcessor.Location = New System.Drawing.Point(0, 226)
        Me.CmdProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdProcessor.Name = "CmdProcessor"
        Me.CmdProcessor.Size = New System.Drawing.Size(195, 36)
        Me.CmdProcessor.TabIndex = 6
        Me.CmdProcessor.Text = "  Processor"
        Me.CmdProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProcessor.UseVisualStyleBackColor = False
        '
        'CmdSystem
        '
        Me.CmdSystem.BackColor = System.Drawing.Color.Transparent
        Me.CmdSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdSystem.FlatAppearance.BorderSize = 0
        Me.CmdSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdSystem.Location = New System.Drawing.Point(0, 190)
        Me.CmdSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSystem.Name = "CmdSystem"
        Me.CmdSystem.Size = New System.Drawing.Size(195, 36)
        Me.CmdSystem.TabIndex = 5
        Me.CmdSystem.Text = "  System"
        Me.CmdSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSystem.UseVisualStyleBackColor = False
        '
        'CmdDisk
        '
        Me.CmdDisk.BackColor = System.Drawing.Color.Transparent
        Me.CmdDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdDisk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdDisk.FlatAppearance.BorderSize = 0
        Me.CmdDisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdDisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDisk.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDisk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDisk.Location = New System.Drawing.Point(0, 334)
        Me.CmdDisk.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdDisk.Name = "CmdDisk"
        Me.CmdDisk.Size = New System.Drawing.Size(195, 36)
        Me.CmdDisk.TabIndex = 9
        Me.CmdDisk.Text = "  Disk"
        Me.CmdDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdDisk.UseVisualStyleBackColor = False
        '
        'CmdDwm
        '
        Me.CmdDwm.BackColor = System.Drawing.Color.Transparent
        Me.CmdDwm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdDwm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdDwm.FlatAppearance.BorderSize = 0
        Me.CmdDwm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdDwm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdDwm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDwm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDwm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDwm.Location = New System.Drawing.Point(0, 370)
        Me.CmdDwm.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdDwm.Name = "CmdDwm"
        Me.CmdDwm.Size = New System.Drawing.Size(195, 36)
        Me.CmdDwm.TabIndex = 10
        Me.CmdDwm.Text = "  DWMAssessment"
        Me.CmdDwm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdDwm.UseVisualStyleBackColor = False
        '
        'CmdD3D
        '
        Me.CmdD3D.BackColor = System.Drawing.Color.Transparent
        Me.CmdD3D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdD3D.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdD3D.FlatAppearance.BorderSize = 0
        Me.CmdD3D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmdD3D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdD3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdD3D.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdD3D.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdD3D.Location = New System.Drawing.Point(0, 406)
        Me.CmdD3D.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdD3D.Name = "CmdD3D"
        Me.CmdD3D.Size = New System.Drawing.Size(195, 36)
        Me.CmdD3D.TabIndex = 11
        Me.CmdD3D.Text = "  D3DAssessment"
        Me.CmdD3D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdD3D.UseVisualStyleBackColor = False
        '
        'PbxProgramInfo
        '
        Me.PbxProgramInfo.BackColor = System.Drawing.Color.Transparent
        Me.PbxProgramInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxProgramInfo.Location = New System.Drawing.Point(195, 10)
        Me.PbxProgramInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxProgramInfo.Name = "PbxProgramInfo"
        Me.PbxProgramInfo.Size = New System.Drawing.Size(2, 36)
        Me.PbxProgramInfo.TabIndex = 12
        Me.PbxProgramInfo.TabStop = False
        '
        'PbxSystemEnvironment
        '
        Me.PbxSystemEnvironment.BackColor = System.Drawing.Color.Transparent
        Me.PbxSystemEnvironment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxSystemEnvironment.Location = New System.Drawing.Point(195, 46)
        Me.PbxSystemEnvironment.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxSystemEnvironment.Name = "PbxSystemEnvironment"
        Me.PbxSystemEnvironment.Size = New System.Drawing.Size(2, 36)
        Me.PbxSystemEnvironment.TabIndex = 13
        Me.PbxSystemEnvironment.TabStop = False
        '
        'PbxWinSPR
        '
        Me.PbxWinSPR.BackColor = System.Drawing.Color.Transparent
        Me.PbxWinSPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxWinSPR.Location = New System.Drawing.Point(195, 82)
        Me.PbxWinSPR.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxWinSPR.Name = "PbxWinSPR"
        Me.PbxWinSPR.Size = New System.Drawing.Size(2, 36)
        Me.PbxWinSPR.TabIndex = 14
        Me.PbxWinSPR.TabStop = False
        '
        'PbxMetrics
        '
        Me.PbxMetrics.BackColor = System.Drawing.Color.Transparent
        Me.PbxMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxMetrics.Location = New System.Drawing.Point(195, 118)
        Me.PbxMetrics.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxMetrics.Name = "PbxMetrics"
        Me.PbxMetrics.Size = New System.Drawing.Size(2, 36)
        Me.PbxMetrics.TabIndex = 15
        Me.PbxMetrics.TabStop = False
        '
        'PbxOSVersion
        '
        Me.PbxOSVersion.BackColor = System.Drawing.Color.Transparent
        Me.PbxOSVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxOSVersion.Location = New System.Drawing.Point(195, 154)
        Me.PbxOSVersion.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxOSVersion.Name = "PbxOSVersion"
        Me.PbxOSVersion.Size = New System.Drawing.Size(2, 36)
        Me.PbxOSVersion.TabIndex = 16
        Me.PbxOSVersion.TabStop = False
        '
        'PbxSystem
        '
        Me.PbxSystem.BackColor = System.Drawing.Color.Transparent
        Me.PbxSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxSystem.Location = New System.Drawing.Point(195, 190)
        Me.PbxSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxSystem.Name = "PbxSystem"
        Me.PbxSystem.Size = New System.Drawing.Size(2, 36)
        Me.PbxSystem.TabIndex = 17
        Me.PbxSystem.TabStop = False
        '
        'PbxProcessor
        '
        Me.PbxProcessor.BackColor = System.Drawing.Color.Transparent
        Me.PbxProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxProcessor.Location = New System.Drawing.Point(195, 226)
        Me.PbxProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxProcessor.Name = "PbxProcessor"
        Me.PbxProcessor.Size = New System.Drawing.Size(2, 36)
        Me.PbxProcessor.TabIndex = 18
        Me.PbxProcessor.TabStop = False
        '
        'PbxMemory
        '
        Me.PbxMemory.BackColor = System.Drawing.Color.Transparent
        Me.PbxMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxMemory.Location = New System.Drawing.Point(195, 262)
        Me.PbxMemory.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxMemory.Name = "PbxMemory"
        Me.PbxMemory.Size = New System.Drawing.Size(2, 36)
        Me.PbxMemory.TabIndex = 19
        Me.PbxMemory.TabStop = False
        '
        'PbxGraphics
        '
        Me.PbxGraphics.BackColor = System.Drawing.Color.Transparent
        Me.PbxGraphics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxGraphics.Location = New System.Drawing.Point(195, 298)
        Me.PbxGraphics.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxGraphics.Name = "PbxGraphics"
        Me.PbxGraphics.Size = New System.Drawing.Size(2, 36)
        Me.PbxGraphics.TabIndex = 20
        Me.PbxGraphics.TabStop = False
        '
        'PbxDisk
        '
        Me.PbxDisk.BackColor = System.Drawing.Color.Transparent
        Me.PbxDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxDisk.Location = New System.Drawing.Point(195, 334)
        Me.PbxDisk.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxDisk.Name = "PbxDisk"
        Me.PbxDisk.Size = New System.Drawing.Size(2, 36)
        Me.PbxDisk.TabIndex = 21
        Me.PbxDisk.TabStop = False
        '
        'PbxDwm
        '
        Me.PbxDwm.BackColor = System.Drawing.Color.Transparent
        Me.PbxDwm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxDwm.Location = New System.Drawing.Point(195, 370)
        Me.PbxDwm.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxDwm.Name = "PbxDwm"
        Me.PbxDwm.Size = New System.Drawing.Size(2, 36)
        Me.PbxDwm.TabIndex = 22
        Me.PbxDwm.TabStop = False
        '
        'PbxD3d
        '
        Me.PbxD3d.BackColor = System.Drawing.Color.Transparent
        Me.PbxD3d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxD3d.Location = New System.Drawing.Point(195, 406)
        Me.PbxD3d.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxD3d.Name = "PbxD3d"
        Me.PbxD3d.Size = New System.Drawing.Size(2, 36)
        Me.PbxD3d.TabIndex = 23
        Me.PbxD3d.TabStop = False
        '
        'FormMetrics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "FormMetrics"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Metrics"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpMain.ResumeLayout(False)
        Me.TlpMenu.ResumeLayout(False)
        CType(Me.PbxProgramInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSystemEnvironment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxWinSPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMetrics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxOSVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxProcessor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMemory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGraphics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxDisk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxDwm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxD3d, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSplit As Panel
    Friend WithEvents PanHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents PanMain As Panel
    Friend WithEvents TlpMain As TableLayoutPanel
    Friend WithEvents RtbData As RichTextBox
    Friend WithEvents LabHead As Label
    Friend WithEvents TlpMenu As TableLayoutPanel
    Friend WithEvents CmdProgramInfo As Button
    Friend WithEvents CmdSysEnviron As Button
    Friend WithEvents CmdWinSpr As Button
    Friend WithEvents CmdMetrics As Button
    Friend WithEvents CmdOS As Button
    Friend WithEvents CmdGraphics As Button
    Friend WithEvents CmdMemory As Button
    Friend WithEvents CmdProcessor As Button
    Friend WithEvents CmdSystem As Button
    Friend WithEvents CmdDisk As Button
    Friend WithEvents CmdDwm As Button
    Friend WithEvents CmdD3D As Button
    Friend WithEvents PbxProgramInfo As PictureBox
    Friend WithEvents PbxSystemEnvironment As PictureBox
    Friend WithEvents PbxWinSPR As PictureBox
    Friend WithEvents PbxMetrics As PictureBox
    Friend WithEvents PbxOSVersion As PictureBox
    Friend WithEvents PbxSystem As PictureBox
    Friend WithEvents PbxProcessor As PictureBox
    Friend WithEvents PbxMemory As PictureBox
    Friend WithEvents PbxGraphics As PictureBox
    Friend WithEvents PbxDisk As PictureBox
    Friend WithEvents PbxDwm As PictureBox
    Friend WithEvents PbxD3d As PictureBox
End Class
