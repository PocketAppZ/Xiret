<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSystem))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.PanUsername = New System.Windows.Forms.Panel()
        Me.sUsername = New System.Windows.Forms.Label()
        Me.PanOne = New System.Windows.Forms.Panel()
        Me.LabUsername = New System.Windows.Forms.Label()
        Me.PanOpSys = New System.Windows.Forms.Panel()
        Me.sOpSystem = New System.Windows.Forms.Label()
        Me.PanBitness = New System.Windows.Forms.Panel()
        Me.sBitness = New System.Windows.Forms.Label()
        Me.PanServPack = New System.Windows.Forms.Panel()
        Me.sServPack = New System.Windows.Forms.Label()
        Me.PanFour = New System.Windows.Forms.Panel()
        Me.LabServPack = New System.Windows.Forms.Label()
        Me.PanTwo = New System.Windows.Forms.Panel()
        Me.LabOpSystem = New System.Windows.Forms.Label()
        Me.PanThree = New System.Windows.Forms.Panel()
        Me.LabBitness = New System.Windows.Forms.Label()
        Me.PanKernel = New System.Windows.Forms.Panel()
        Me.sKernel = New System.Windows.Forms.Label()
        Me.PanFive = New System.Windows.Forms.Panel()
        Me.LabKernel = New System.Windows.Forms.Label()
        Me.PanWinsat = New System.Windows.Forms.Panel()
        Me.sWinsat = New System.Windows.Forms.Label()
        Me.PanSix = New System.Windows.Forms.Panel()
        Me.LabWinsat = New System.Windows.Forms.Label()
        Me.PanApi = New System.Windows.Forms.Panel()
        Me.sApi = New System.Windows.Forms.Label()
        Me.PanSeven = New System.Windows.Forms.Panel()
        Me.LabApi = New System.Windows.Forms.Label()
        Me.PanUptime = New System.Windows.Forms.Panel()
        Me.sUptime = New System.Windows.Forms.Label()
        Me.PanNine = New System.Windows.Forms.Panel()
        Me.LabUptime = New System.Windows.Forms.Label()
        Me.PanInstDat = New System.Windows.Forms.Panel()
        Me.sInstDat = New System.Windows.Forms.Label()
        Me.PanEight = New System.Windows.Forms.Panel()
        Me.LabInstDat = New System.Windows.Forms.Label()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpGrid.SuspendLayout()
        Me.PanUsername.SuspendLayout()
        Me.PanOne.SuspendLayout()
        Me.PanOpSys.SuspendLayout()
        Me.PanBitness.SuspendLayout()
        Me.PanServPack.SuspendLayout()
        Me.PanFour.SuspendLayout()
        Me.PanTwo.SuspendLayout()
        Me.PanThree.SuspendLayout()
        Me.PanKernel.SuspendLayout()
        Me.PanFive.SuspendLayout()
        Me.PanWinsat.SuspendLayout()
        Me.PanSix.SuspendLayout()
        Me.PanApi.SuspendLayout()
        Me.PanSeven.SuspendLayout()
        Me.PanUptime.SuspendLayout()
        Me.PanNine.SuspendLayout()
        Me.PanInstDat.SuspendLayout()
        Me.PanEight.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(2)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(498, 32)
        Me.PanHead.TabIndex = 0
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(32, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(434, 32)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "System Details"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TlpHeadImage.TabIndex = 73
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
        Me.CmdClose.Location = New System.Drawing.Point(466, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(32, 32)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpGrid)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 33)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Padding = New System.Windows.Forms.Padding(7)
        Me.PanMain.Size = New System.Drawing.Size(498, 260)
        Me.PanMain.TabIndex = 124
        '
        'TlpGrid
        '
        Me.TlpGrid.ColumnCount = 2
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 974.0!))
        Me.TlpGrid.Controls.Add(Me.PanUsername, 0, 0)
        Me.TlpGrid.Controls.Add(Me.PanOne, 1, 0)
        Me.TlpGrid.Controls.Add(Me.PanOpSys, 0, 1)
        Me.TlpGrid.Controls.Add(Me.PanBitness, 0, 2)
        Me.TlpGrid.Controls.Add(Me.PanServPack, 0, 3)
        Me.TlpGrid.Controls.Add(Me.PanFour, 1, 3)
        Me.TlpGrid.Controls.Add(Me.PanTwo, 1, 1)
        Me.TlpGrid.Controls.Add(Me.PanThree, 1, 2)
        Me.TlpGrid.Controls.Add(Me.PanKernel, 0, 5)
        Me.TlpGrid.Controls.Add(Me.PanFive, 1, 5)
        Me.TlpGrid.Controls.Add(Me.PanWinsat, 0, 6)
        Me.TlpGrid.Controls.Add(Me.PanSix, 1, 6)
        Me.TlpGrid.Controls.Add(Me.PanApi, 0, 7)
        Me.TlpGrid.Controls.Add(Me.PanSeven, 1, 7)
        Me.TlpGrid.Controls.Add(Me.PanUptime, 0, 10)
        Me.TlpGrid.Controls.Add(Me.PanNine, 1, 10)
        Me.TlpGrid.Controls.Add(Me.PanInstDat, 0, 9)
        Me.TlpGrid.Controls.Add(Me.PanEight, 1, 9)
        Me.TlpGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpGrid.Location = New System.Drawing.Point(7, 7)
        Me.TlpGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpGrid.Name = "TlpGrid"
        Me.TlpGrid.RowCount = 12
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TlpGrid.Size = New System.Drawing.Size(484, 246)
        Me.TlpGrid.TabIndex = 126
        '
        'PanUsername
        '
        Me.PanUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanUsername.Controls.Add(Me.sUsername)
        Me.PanUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanUsername.Location = New System.Drawing.Point(0, 0)
        Me.PanUsername.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanUsername.Name = "PanUsername"
        Me.PanUsername.Size = New System.Drawing.Size(137, 25)
        Me.PanUsername.TabIndex = 127
        '
        'sUsername
        '
        Me.sUsername.BackColor = System.Drawing.Color.Transparent
        Me.sUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sUsername.Location = New System.Drawing.Point(0, 0)
        Me.sUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sUsername.Name = "sUsername"
        Me.sUsername.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sUsername.Size = New System.Drawing.Size(137, 25)
        Me.sUsername.TabIndex = 48
        Me.sUsername.Text = "Username"
        Me.sUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanOne
        '
        Me.PanOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanOne.Controls.Add(Me.LabUsername)
        Me.PanOne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanOne.Location = New System.Drawing.Point(138, 0)
        Me.PanOne.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanOne.Name = "PanOne"
        Me.PanOne.Size = New System.Drawing.Size(974, 25)
        Me.PanOne.TabIndex = 128
        '
        'LabUsername
        '
        Me.LabUsername.AutoEllipsis = True
        Me.LabUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabUsername.Location = New System.Drawing.Point(0, 0)
        Me.LabUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabUsername.Name = "LabUsername"
        Me.LabUsername.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabUsername.Size = New System.Drawing.Size(974, 25)
        Me.LabUsername.TabIndex = 77
        Me.LabUsername.Text = "..."
        Me.LabUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanOpSys
        '
        Me.PanOpSys.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanOpSys.Controls.Add(Me.sOpSystem)
        Me.PanOpSys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanOpSys.Location = New System.Drawing.Point(0, 26)
        Me.PanOpSys.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanOpSys.Name = "PanOpSys"
        Me.PanOpSys.Size = New System.Drawing.Size(137, 25)
        Me.PanOpSys.TabIndex = 79
        '
        'sOpSystem
        '
        Me.sOpSystem.BackColor = System.Drawing.Color.Transparent
        Me.sOpSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sOpSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOpSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sOpSystem.Location = New System.Drawing.Point(0, 0)
        Me.sOpSystem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sOpSystem.Name = "sOpSystem"
        Me.sOpSystem.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sOpSystem.Size = New System.Drawing.Size(137, 25)
        Me.sOpSystem.TabIndex = 48
        Me.sOpSystem.Text = "Operating System"
        Me.sOpSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanBitness
        '
        Me.PanBitness.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanBitness.Controls.Add(Me.sBitness)
        Me.PanBitness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanBitness.Location = New System.Drawing.Point(0, 52)
        Me.PanBitness.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanBitness.Name = "PanBitness"
        Me.PanBitness.Size = New System.Drawing.Size(137, 25)
        Me.PanBitness.TabIndex = 80
        '
        'sBitness
        '
        Me.sBitness.BackColor = System.Drawing.Color.Transparent
        Me.sBitness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sBitness.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sBitness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sBitness.Location = New System.Drawing.Point(0, 0)
        Me.sBitness.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sBitness.Name = "sBitness"
        Me.sBitness.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sBitness.Size = New System.Drawing.Size(137, 25)
        Me.sBitness.TabIndex = 49
        Me.sBitness.Text = "Bitness"
        Me.sBitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanServPack
        '
        Me.PanServPack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanServPack.Controls.Add(Me.sServPack)
        Me.PanServPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanServPack.Location = New System.Drawing.Point(0, 78)
        Me.PanServPack.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.PanServPack.Name = "PanServPack"
        Me.PanServPack.Size = New System.Drawing.Size(137, 26)
        Me.PanServPack.TabIndex = 83
        '
        'sServPack
        '
        Me.sServPack.BackColor = System.Drawing.Color.Transparent
        Me.sServPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sServPack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sServPack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sServPack.Location = New System.Drawing.Point(0, 0)
        Me.sServPack.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sServPack.Name = "sServPack"
        Me.sServPack.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sServPack.Size = New System.Drawing.Size(137, 26)
        Me.sServPack.TabIndex = 49
        Me.sServPack.Text = "Service Pack"
        Me.sServPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanFour
        '
        Me.PanFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanFour.Controls.Add(Me.LabServPack)
        Me.PanFour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanFour.Location = New System.Drawing.Point(138, 78)
        Me.PanFour.Margin = New System.Windows.Forms.Padding(0)
        Me.PanFour.Name = "PanFour"
        Me.PanFour.Size = New System.Drawing.Size(974, 26)
        Me.PanFour.TabIndex = 84
        '
        'LabServPack
        '
        Me.LabServPack.AutoEllipsis = True
        Me.LabServPack.BackColor = System.Drawing.Color.Transparent
        Me.LabServPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabServPack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabServPack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabServPack.Location = New System.Drawing.Point(0, 0)
        Me.LabServPack.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabServPack.Name = "LabServPack"
        Me.LabServPack.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabServPack.Size = New System.Drawing.Size(974, 26)
        Me.LabServPack.TabIndex = 78
        Me.LabServPack.Text = "..."
        Me.LabServPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanTwo
        '
        Me.PanTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanTwo.Controls.Add(Me.LabOpSystem)
        Me.PanTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanTwo.Location = New System.Drawing.Point(138, 26)
        Me.PanTwo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanTwo.Name = "PanTwo"
        Me.PanTwo.Size = New System.Drawing.Size(974, 25)
        Me.PanTwo.TabIndex = 81
        '
        'LabOpSystem
        '
        Me.LabOpSystem.AutoEllipsis = True
        Me.LabOpSystem.BackColor = System.Drawing.Color.Transparent
        Me.LabOpSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabOpSystem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabOpSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabOpSystem.Location = New System.Drawing.Point(0, 0)
        Me.LabOpSystem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabOpSystem.Name = "LabOpSystem"
        Me.LabOpSystem.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabOpSystem.Size = New System.Drawing.Size(974, 25)
        Me.LabOpSystem.TabIndex = 77
        Me.LabOpSystem.Text = "..."
        Me.LabOpSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanThree
        '
        Me.PanThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanThree.Controls.Add(Me.LabBitness)
        Me.PanThree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanThree.Location = New System.Drawing.Point(138, 52)
        Me.PanThree.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanThree.Name = "PanThree"
        Me.PanThree.Size = New System.Drawing.Size(974, 25)
        Me.PanThree.TabIndex = 82
        '
        'LabBitness
        '
        Me.LabBitness.AutoEllipsis = True
        Me.LabBitness.BackColor = System.Drawing.Color.Transparent
        Me.LabBitness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabBitness.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBitness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabBitness.Location = New System.Drawing.Point(0, 0)
        Me.LabBitness.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabBitness.Name = "LabBitness"
        Me.LabBitness.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabBitness.Size = New System.Drawing.Size(974, 25)
        Me.LabBitness.TabIndex = 78
        Me.LabBitness.Text = "..."
        Me.LabBitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanKernel
        '
        Me.PanKernel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanKernel.Controls.Add(Me.sKernel)
        Me.PanKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanKernel.Location = New System.Drawing.Point(0, 110)
        Me.PanKernel.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanKernel.Name = "PanKernel"
        Me.PanKernel.Size = New System.Drawing.Size(137, 25)
        Me.PanKernel.TabIndex = 85
        '
        'sKernel
        '
        Me.sKernel.BackColor = System.Drawing.Color.Transparent
        Me.sKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sKernel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sKernel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sKernel.Location = New System.Drawing.Point(0, 0)
        Me.sKernel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sKernel.Name = "sKernel"
        Me.sKernel.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sKernel.Size = New System.Drawing.Size(137, 25)
        Me.sKernel.TabIndex = 50
        Me.sKernel.Text = "Kernel Version"
        Me.sKernel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanFive
        '
        Me.PanFive.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanFive.Controls.Add(Me.LabKernel)
        Me.PanFive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanFive.Location = New System.Drawing.Point(138, 110)
        Me.PanFive.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanFive.Name = "PanFive"
        Me.PanFive.Size = New System.Drawing.Size(974, 25)
        Me.PanFive.TabIndex = 86
        '
        'LabKernel
        '
        Me.LabKernel.AutoEllipsis = True
        Me.LabKernel.BackColor = System.Drawing.Color.Transparent
        Me.LabKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabKernel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabKernel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabKernel.Location = New System.Drawing.Point(0, 0)
        Me.LabKernel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabKernel.Name = "LabKernel"
        Me.LabKernel.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabKernel.Size = New System.Drawing.Size(974, 25)
        Me.LabKernel.TabIndex = 78
        Me.LabKernel.Text = "..."
        Me.LabKernel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanWinsat
        '
        Me.PanWinsat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanWinsat.Controls.Add(Me.sWinsat)
        Me.PanWinsat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanWinsat.Location = New System.Drawing.Point(0, 136)
        Me.PanWinsat.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanWinsat.Name = "PanWinsat"
        Me.PanWinsat.Size = New System.Drawing.Size(137, 25)
        Me.PanWinsat.TabIndex = 87
        '
        'sWinsat
        '
        Me.sWinsat.BackColor = System.Drawing.Color.Transparent
        Me.sWinsat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sWinsat.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sWinsat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sWinsat.Location = New System.Drawing.Point(0, 0)
        Me.sWinsat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sWinsat.Name = "sWinsat"
        Me.sWinsat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sWinsat.Size = New System.Drawing.Size(137, 25)
        Me.sWinsat.TabIndex = 51
        Me.sWinsat.Text = "WinSAT Version"
        Me.sWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanSix
        '
        Me.PanSix.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanSix.Controls.Add(Me.LabWinsat)
        Me.PanSix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanSix.Location = New System.Drawing.Point(138, 136)
        Me.PanSix.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanSix.Name = "PanSix"
        Me.PanSix.Size = New System.Drawing.Size(974, 25)
        Me.PanSix.TabIndex = 88
        '
        'LabWinsat
        '
        Me.LabWinsat.AutoEllipsis = True
        Me.LabWinsat.BackColor = System.Drawing.Color.Transparent
        Me.LabWinsat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabWinsat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabWinsat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabWinsat.Location = New System.Drawing.Point(0, 0)
        Me.LabWinsat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabWinsat.Name = "LabWinsat"
        Me.LabWinsat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabWinsat.Size = New System.Drawing.Size(974, 25)
        Me.LabWinsat.TabIndex = 78
        Me.LabWinsat.Text = "..."
        Me.LabWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanApi
        '
        Me.PanApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanApi.Controls.Add(Me.sApi)
        Me.PanApi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanApi.Location = New System.Drawing.Point(0, 162)
        Me.PanApi.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.PanApi.Name = "PanApi"
        Me.PanApi.Size = New System.Drawing.Size(137, 26)
        Me.PanApi.TabIndex = 89
        '
        'sApi
        '
        Me.sApi.BackColor = System.Drawing.Color.Transparent
        Me.sApi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sApi.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sApi.Location = New System.Drawing.Point(0, 0)
        Me.sApi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sApi.Name = "sApi"
        Me.sApi.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sApi.Size = New System.Drawing.Size(137, 26)
        Me.sApi.TabIndex = 52
        Me.sApi.Text = "WinSAT API Version"
        Me.sApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanSeven
        '
        Me.PanSeven.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanSeven.Controls.Add(Me.LabApi)
        Me.PanSeven.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanSeven.Location = New System.Drawing.Point(138, 162)
        Me.PanSeven.Margin = New System.Windows.Forms.Padding(0)
        Me.PanSeven.Name = "PanSeven"
        Me.PanSeven.Size = New System.Drawing.Size(974, 26)
        Me.PanSeven.TabIndex = 90
        '
        'LabApi
        '
        Me.LabApi.AutoEllipsis = True
        Me.LabApi.BackColor = System.Drawing.Color.Transparent
        Me.LabApi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabApi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabApi.Location = New System.Drawing.Point(0, 0)
        Me.LabApi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabApi.Name = "LabApi"
        Me.LabApi.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabApi.Size = New System.Drawing.Size(974, 26)
        Me.LabApi.TabIndex = 78
        Me.LabApi.Text = "..."
        Me.LabApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanUptime
        '
        Me.PanUptime.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanUptime.Controls.Add(Me.sUptime)
        Me.PanUptime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanUptime.Location = New System.Drawing.Point(0, 220)
        Me.PanUptime.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.PanUptime.Name = "PanUptime"
        Me.PanUptime.Size = New System.Drawing.Size(137, 26)
        Me.PanUptime.TabIndex = 91
        '
        'sUptime
        '
        Me.sUptime.BackColor = System.Drawing.Color.Transparent
        Me.sUptime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sUptime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sUptime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sUptime.Location = New System.Drawing.Point(0, 0)
        Me.sUptime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sUptime.Name = "sUptime"
        Me.sUptime.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sUptime.Size = New System.Drawing.Size(137, 26)
        Me.sUptime.TabIndex = 49
        Me.sUptime.Text = "System Uptime"
        Me.sUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanNine
        '
        Me.PanNine.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanNine.Controls.Add(Me.LabUptime)
        Me.PanNine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanNine.Location = New System.Drawing.Point(138, 220)
        Me.PanNine.Margin = New System.Windows.Forms.Padding(0)
        Me.PanNine.Name = "PanNine"
        Me.PanNine.Size = New System.Drawing.Size(974, 26)
        Me.PanNine.TabIndex = 92
        '
        'LabUptime
        '
        Me.LabUptime.AutoEllipsis = True
        Me.LabUptime.BackColor = System.Drawing.Color.Transparent
        Me.LabUptime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabUptime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabUptime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabUptime.Location = New System.Drawing.Point(0, 0)
        Me.LabUptime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabUptime.Name = "LabUptime"
        Me.LabUptime.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabUptime.Size = New System.Drawing.Size(974, 26)
        Me.LabUptime.TabIndex = 79
        Me.LabUptime.Text = "..."
        Me.LabUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanInstDat
        '
        Me.PanInstDat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanInstDat.Controls.Add(Me.sInstDat)
        Me.PanInstDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanInstDat.Location = New System.Drawing.Point(0, 194)
        Me.PanInstDat.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanInstDat.Name = "PanInstDat"
        Me.PanInstDat.Size = New System.Drawing.Size(137, 25)
        Me.PanInstDat.TabIndex = 129
        '
        'sInstDat
        '
        Me.sInstDat.BackColor = System.Drawing.Color.Transparent
        Me.sInstDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sInstDat.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sInstDat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sInstDat.Location = New System.Drawing.Point(0, 0)
        Me.sInstDat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sInstDat.Name = "sInstDat"
        Me.sInstDat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sInstDat.Size = New System.Drawing.Size(137, 25)
        Me.sInstDat.TabIndex = 48
        Me.sInstDat.Text = "Install Date"
        Me.sInstDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanEight
        '
        Me.PanEight.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanEight.Controls.Add(Me.LabInstDat)
        Me.PanEight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanEight.Location = New System.Drawing.Point(138, 194)
        Me.PanEight.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanEight.Name = "PanEight"
        Me.PanEight.Size = New System.Drawing.Size(974, 25)
        Me.PanEight.TabIndex = 130
        '
        'LabInstDat
        '
        Me.LabInstDat.AutoEllipsis = True
        Me.LabInstDat.BackColor = System.Drawing.Color.Transparent
        Me.LabInstDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabInstDat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInstDat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabInstDat.Location = New System.Drawing.Point(0, 0)
        Me.LabInstDat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabInstDat.Name = "LabInstDat"
        Me.LabInstDat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabInstDat.Size = New System.Drawing.Size(974, 25)
        Me.LabInstDat.TabIndex = 77
        Me.LabInstDat.Text = "..."
        Me.LabInstDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(1, 33)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(498, 2)
        Me.PanSplit.TabIndex = 126
        '
        'FormSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 294)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(500, 294)
        Me.MinimumSize = New System.Drawing.Size(500, 294)
        Me.Name = "FormSystem"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Details"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpGrid.ResumeLayout(False)
        Me.PanUsername.ResumeLayout(False)
        Me.PanOne.ResumeLayout(False)
        Me.PanOpSys.ResumeLayout(False)
        Me.PanBitness.ResumeLayout(False)
        Me.PanServPack.ResumeLayout(False)
        Me.PanFour.ResumeLayout(False)
        Me.PanTwo.ResumeLayout(False)
        Me.PanThree.ResumeLayout(False)
        Me.PanKernel.ResumeLayout(False)
        Me.PanFive.ResumeLayout(False)
        Me.PanWinsat.ResumeLayout(False)
        Me.PanSix.ResumeLayout(False)
        Me.PanApi.ResumeLayout(False)
        Me.PanSeven.ResumeLayout(False)
        Me.PanUptime.ResumeLayout(False)
        Me.PanNine.ResumeLayout(False)
        Me.PanInstDat.ResumeLayout(False)
        Me.PanEight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents TlpGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanOpSys As System.Windows.Forms.Panel
    Friend WithEvents sOpSystem As System.Windows.Forms.Label
    Friend WithEvents PanBitness As System.Windows.Forms.Panel
    Friend WithEvents sBitness As System.Windows.Forms.Label
    Friend WithEvents PanServPack As System.Windows.Forms.Panel
    Friend WithEvents sServPack As System.Windows.Forms.Label
    Friend WithEvents PanFour As System.Windows.Forms.Panel
    Friend WithEvents LabServPack As System.Windows.Forms.Label
    Friend WithEvents PanTwo As System.Windows.Forms.Panel
    Friend WithEvents LabOpSystem As System.Windows.Forms.Label
    Friend WithEvents PanThree As System.Windows.Forms.Panel
    Friend WithEvents LabBitness As System.Windows.Forms.Label
    Friend WithEvents PanKernel As System.Windows.Forms.Panel
    Friend WithEvents sKernel As System.Windows.Forms.Label
    Friend WithEvents PanFive As System.Windows.Forms.Panel
    Friend WithEvents PanWinsat As System.Windows.Forms.Panel
    Friend WithEvents PanSix As System.Windows.Forms.Panel
    Friend WithEvents PanApi As System.Windows.Forms.Panel
    Friend WithEvents PanSeven As System.Windows.Forms.Panel
    Friend WithEvents LabKernel As System.Windows.Forms.Label
    Friend WithEvents sWinsat As System.Windows.Forms.Label
    Friend WithEvents LabWinsat As System.Windows.Forms.Label
    Friend WithEvents sApi As System.Windows.Forms.Label
    Friend WithEvents LabApi As System.Windows.Forms.Label
    Friend WithEvents PanUptime As System.Windows.Forms.Panel
    Friend WithEvents PanNine As System.Windows.Forms.Panel
    Friend WithEvents LabUptime As System.Windows.Forms.Label
    Friend WithEvents PanUsername As Panel
    Friend WithEvents sUsername As Label
    Friend WithEvents PanOne As Panel
    Friend WithEvents LabUsername As Label
    Friend WithEvents PanInstDat As Panel
    Friend WithEvents sInstDat As Label
    Friend WithEvents PanEight As Panel
    Friend WithEvents LabInstDat As Label
    Friend WithEvents PanSplit As Panel
    Friend WithEvents sUptime As Label
End Class
