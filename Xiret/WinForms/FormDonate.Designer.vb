<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDonate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDonate))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxQr = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabAddress = New System.Windows.Forms.Label()
        Me.LabCopy = New System.Windows.Forms.Label()
        Me.LabPlatform = New System.Windows.Forms.Label()
        Me.TlpRads = New System.Windows.Forms.TableLayoutPanel()
        Me.RadBtc = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.RadXrp = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.RadEth = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.RadPaypal = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PbxQr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TlpRads.SuspendLayout()
        Me.TlpTop.SuspendLayout()
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
        Me.PanHead.Size = New System.Drawing.Size(418, 32)
        Me.PanHead.TabIndex = 74
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(32, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(354, 32)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "Donate"
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
        Me.CmdClose.Location = New System.Drawing.Point(386, 0)
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
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TableLayoutPanel1)
        Me.PanMain.Controls.Add(Me.TlpRads)
        Me.PanMain.Controls.Add(Me.TlpTop)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 35)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(418, 245)
        Me.PanMain.TabIndex = 73
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PbxQr, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 102)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(418, 143)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PbxQr
        '
        Me.PbxQr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxQr.BackColor = System.Drawing.Color.Transparent
        Me.PbxQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxQr.Location = New System.Drawing.Point(3, 3)
        Me.PbxQr.Name = "PbxQr"
        Me.PbxQr.Size = New System.Drawing.Size(137, 137)
        Me.PbxQr.TabIndex = 0
        Me.PbxQr.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabAddress, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabCopy, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabPlatform, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(146, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.25547!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(269, 137)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'LabAddress
        '
        Me.LabAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabAddress.AutoSize = True
        Me.LabAddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabAddress.Location = New System.Drawing.Point(3, 51)
        Me.LabAddress.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.LabAddress.Name = "LabAddress"
        Me.LabAddress.Size = New System.Drawing.Size(219, 40)
        Me.LabAddress.TabIndex = 0
        Me.LabAddress.Text = "bc1q9jlremwmd036df08hu9davclxqk43vwqk08ul7"
        Me.LabAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabCopy
        '
        Me.LabCopy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabCopy.AutoSize = True
        Me.LabCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabCopy.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LabCopy.Location = New System.Drawing.Point(235, 51)
        Me.LabCopy.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.LabCopy.Name = "LabCopy"
        Me.LabCopy.Size = New System.Drawing.Size(24, 16)
        Me.LabCopy.TabIndex = 1
        Me.LabCopy.Text = ""
        Me.LabCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabPlatform
        '
        Me.LabPlatform.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabPlatform.AutoSize = True
        Me.LabPlatform.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPlatform.ForeColor = System.Drawing.Color.White
        Me.LabPlatform.Location = New System.Drawing.Point(3, 11)
        Me.LabPlatform.Name = "LabPlatform"
        Me.LabPlatform.Size = New System.Drawing.Size(103, 17)
        Me.LabPlatform.TabIndex = 2
        Me.LabPlatform.Text = "Bitcoin address:"
        '
        'TlpRads
        '
        Me.TlpRads.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TlpRads.ColumnCount = 4
        Me.TlpRads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpRads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpRads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpRads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpRads.Controls.Add(Me.RadBtc, 0, 0)
        Me.TlpRads.Controls.Add(Me.RadXrp, 2, 0)
        Me.TlpRads.Controls.Add(Me.RadEth, 1, 0)
        Me.TlpRads.Controls.Add(Me.RadPaypal, 3, 0)
        Me.TlpRads.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpRads.Location = New System.Drawing.Point(0, 72)
        Me.TlpRads.Name = "TlpRads"
        Me.TlpRads.RowCount = 1
        Me.TlpRads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpRads.Size = New System.Drawing.Size(418, 30)
        Me.TlpRads.TabIndex = 1
        '
        'RadBtc
        '
        Me.RadBtc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadBtc.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadBtc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RadBtc.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadBtc.Checked = True
        Me.RadBtc.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadBtc.ClientColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadBtc.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RadBtc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtc.ForeColor = System.Drawing.Color.White
        Me.RadBtc.Location = New System.Drawing.Point(25, 6)
        Me.RadBtc.Margin = New System.Windows.Forms.Padding(2)
        Me.RadBtc.Name = "RadBtc"
        Me.RadBtc.Size = New System.Drawing.Size(54, 18)
        Me.RadBtc.TabIndex = 3
        Me.RadBtc.TabStop = True
        Me.RadBtc.Text = "BTC"
        '
        'RadXrp
        '
        Me.RadXrp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadXrp.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadXrp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RadXrp.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadXrp.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadXrp.ClientColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadXrp.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RadXrp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadXrp.ForeColor = System.Drawing.Color.White
        Me.RadXrp.Location = New System.Drawing.Point(233, 6)
        Me.RadXrp.Margin = New System.Windows.Forms.Padding(2)
        Me.RadXrp.Name = "RadXrp"
        Me.RadXrp.Size = New System.Drawing.Size(54, 18)
        Me.RadXrp.TabIndex = 6
        Me.RadXrp.Text = "XRP"
        '
        'RadEth
        '
        Me.RadEth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadEth.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadEth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RadEth.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadEth.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadEth.ClientColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadEth.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RadEth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadEth.ForeColor = System.Drawing.Color.White
        Me.RadEth.Location = New System.Drawing.Point(129, 6)
        Me.RadEth.Margin = New System.Windows.Forms.Padding(2)
        Me.RadEth.Name = "RadEth"
        Me.RadEth.Size = New System.Drawing.Size(54, 18)
        Me.RadEth.TabIndex = 4
        Me.RadEth.Text = "ETH"
        '
        'RadPaypal
        '
        Me.RadPaypal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadPaypal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadPaypal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RadPaypal.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadPaypal.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadPaypal.ClientColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadPaypal.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RadPaypal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPaypal.ForeColor = System.Drawing.Color.White
        Me.RadPaypal.Location = New System.Drawing.Point(330, 6)
        Me.RadPaypal.Margin = New System.Windows.Forms.Padding(2)
        Me.RadPaypal.Name = "RadPaypal"
        Me.RadPaypal.Size = New System.Drawing.Size(70, 18)
        Me.RadPaypal.TabIndex = 5
        Me.RadPaypal.Text = "PayPal"
        '
        'TlpTop
        '
        Me.TlpTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TlpTop.ColumnCount = 1
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpTop.Controls.Add(Me.LabInfo, 0, 0)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpTop.Location = New System.Drawing.Point(0, 0)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.Size = New System.Drawing.Size(418, 72)
        Me.TlpTop.TabIndex = 0
        '
        'LabInfo
        '
        Me.LabInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabInfo.AutoSize = True
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.White
        Me.LabInfo.Location = New System.Drawing.Point(16, 10)
        Me.LabInfo.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Size = New System.Drawing.Size(385, 51)
        Me.LabInfo.TabIndex = 0
        Me.LabInfo.Text = "Thank you for considering a donation. All profits are re-invested into the softwa" &
    "re I create and are not for my own pocket. They keep the website up, and allow m" &
    "e to invest in new technologies."
        Me.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 33)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(418, 2)
        Me.PanSplit.TabIndex = 75
        '
        'FormDonate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 281)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(420, 281)
        Me.MinimumSize = New System.Drawing.Size(420, 281)
        Me.Name = "FormDonate"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDonate"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PbxQr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TlpRads.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        Me.TlpTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanHead As Panel
    Friend WithEvents LabHead As Label
    Friend WithEvents CmdClose As Button
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents PanMain As Panel
    Friend WithEvents TlpTop As TableLayoutPanel
    Friend WithEvents LabInfo As Label
    Friend WithEvents PanSplit As Panel
    Friend WithEvents TlpRads As TableLayoutPanel
    Friend WithEvents RadXrp As Gambol.Controls.GambolRadioButton
    Friend WithEvents RadPaypal As Gambol.Controls.GambolRadioButton
    Friend WithEvents RadEth As Gambol.Controls.GambolRadioButton
    Friend WithEvents RadBtc As Gambol.Controls.GambolRadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PbxQr As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabAddress As Label
    Friend WithEvents LabCopy As Label
    Friend WithEvents LabPlatform As Label
End Class
