<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHotfix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHotfix))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.LabInfo2 = New System.Windows.Forms.Label()
        Me.TlpLink = New System.Windows.Forms.TableLayoutPanel()
        Me.LabLink = New System.Windows.Forms.Label()
        Me.LnkHotfix = New System.Windows.Forms.LinkLabel()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.LabDownload = New System.Windows.Forms.Label()
        Me.PbxLoad = New System.Windows.Forms.PictureBox()
        Me.TlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdInstall = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpLink.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        CType(Me.PbxLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpButtons.SuspendLayout()
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
        Me.PanHead.Size = New System.Drawing.Size(563, 40)
        Me.PanHead.TabIndex = 126
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
        Me.LabHead.Size = New System.Drawing.Size(483, 40)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "Application Support"
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
        Me.TlpHeadImage.TabIndex = 73
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
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(523, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(563, 2)
        Me.PanSplit.TabIndex = 127
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.LabInfo2)
        Me.PanMain.Controls.Add(Me.TlpLink)
        Me.PanMain.Controls.Add(Me.TlpBottom)
        Me.PanMain.Controls.Add(Me.LabInfo)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(563, 296)
        Me.PanMain.TabIndex = 128
        '
        'LabInfo2
        '
        Me.LabInfo2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo2.ForeColor = System.Drawing.Color.White
        Me.LabInfo2.Location = New System.Drawing.Point(0, 108)
        Me.LabInfo2.Name = "LabInfo2"
        Me.LabInfo2.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.LabInfo2.Size = New System.Drawing.Size(563, 88)
        Me.LabInfo2.TabIndex = 132
        Me.LabInfo2.Text = resources.GetString("LabInfo2.Text")
        Me.LabInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TlpLink
        '
        Me.TlpLink.ColumnCount = 2
        Me.TlpLink.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.749556!))
        Me.TlpLink.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.25044!))
        Me.TlpLink.Controls.Add(Me.LabLink, 0, 0)
        Me.TlpLink.Controls.Add(Me.LnkHotfix, 1, 0)
        Me.TlpLink.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TlpLink.Location = New System.Drawing.Point(0, 207)
        Me.TlpLink.Name = "TlpLink"
        Me.TlpLink.RowCount = 1
        Me.TlpLink.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLink.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpLink.Size = New System.Drawing.Size(563, 30)
        Me.TlpLink.TabIndex = 138
        '
        'LabLink
        '
        Me.LabLink.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabLink.AutoSize = True
        Me.LabLink.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabLink.Location = New System.Drawing.Point(3, 5)
        Me.LabLink.Name = "LabLink"
        Me.LabLink.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.LabLink.Size = New System.Drawing.Size(32, 19)
        Me.LabLink.TabIndex = 137
        Me.LabLink.Text = ""
        '
        'LnkHotfix
        '
        Me.LnkHotfix.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkHotfix.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LnkHotfix.AutoSize = True
        Me.LnkHotfix.BackColor = System.Drawing.Color.Transparent
        Me.LnkHotfix.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkHotfix.ForeColor = System.Drawing.Color.White
        Me.LnkHotfix.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkHotfix.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkHotfix.Location = New System.Drawing.Point(41, 3)
        Me.LnkHotfix.Name = "LnkHotfix"
        Me.LnkHotfix.Size = New System.Drawing.Size(150, 23)
        Me.LnkHotfix.TabIndex = 0
        Me.LnkHotfix.TabStop = True
        Me.LnkHotfix.Text = "Hotfix Information"
        '
        'TlpBottom
        '
        Me.TlpBottom.ColumnCount = 3
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpBottom.Controls.Add(Me.LabDownload, 0, 0)
        Me.TlpBottom.Controls.Add(Me.PbxLoad, 1, 0)
        Me.TlpBottom.Controls.Add(Me.TlpButtons, 2, 0)
        Me.TlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TlpBottom.Location = New System.Drawing.Point(0, 237)
        Me.TlpBottom.Margin = New System.Windows.Forms.Padding(3, 3, 3, 67)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 1
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(563, 59)
        Me.TlpBottom.TabIndex = 136
        '
        'LabDownload
        '
        Me.LabDownload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabDownload.AutoSize = True
        Me.LabDownload.BackColor = System.Drawing.Color.Transparent
        Me.LabDownload.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDownload.ForeColor = System.Drawing.Color.White
        Me.LabDownload.Location = New System.Drawing.Point(3, 18)
        Me.LabDownload.Name = "LabDownload"
        Me.LabDownload.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabDownload.Size = New System.Drawing.Size(5, 23)
        Me.LabDownload.TabIndex = 1
        '
        'PbxLoad
        '
        Me.PbxLoad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PbxLoad.Location = New System.Drawing.Point(345, 17)
        Me.PbxLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLoad.Name = "PbxLoad"
        Me.PbxLoad.Size = New System.Drawing.Size(24, 24)
        Me.PbxLoad.TabIndex = 3
        Me.PbxLoad.TabStop = False
        '
        'TlpButtons
        '
        Me.TlpButtons.ColumnCount = 2
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TlpButtons.Controls.Add(Me.CmdInstall, 1, 0)
        Me.TlpButtons.Controls.Add(Me.CmdCancel, 0, 0)
        Me.TlpButtons.Location = New System.Drawing.Point(378, 3)
        Me.TlpButtons.Name = "TlpButtons"
        Me.TlpButtons.RowCount = 1
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpButtons.Size = New System.Drawing.Size(180, 53)
        Me.TlpButtons.TabIndex = 4
        '
        'CmdInstall
        '
        Me.CmdInstall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdInstall.FlatAppearance.BorderSize = 0
        Me.CmdInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdInstall.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdInstall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInstall.Location = New System.Drawing.Point(94, 8)
        Me.CmdInstall.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdInstall.Name = "CmdInstall"
        Me.CmdInstall.Size = New System.Drawing.Size(82, 37)
        Me.CmdInstall.TabIndex = 2
        Me.CmdInstall.Text = "Install"
        Me.CmdInstall.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(4, 8)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(82, 37)
        Me.CmdCancel.TabIndex = 1
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'LabInfo
        '
        Me.LabInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LabInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.White
        Me.LabInfo.Location = New System.Drawing.Point(0, 0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Padding = New System.Windows.Forms.Padding(7, 7, 0, 0)
        Me.LabInfo.Size = New System.Drawing.Size(563, 108)
        Me.LabInfo.TabIndex = 0
        Me.LabInfo.Text = resources.GetString("LabInfo.Text")
        '
        'FormHotfix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(565, 340)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(565, 340)
        Me.MinimumSize = New System.Drawing.Size(565, 340)
        Me.Name = "FormHotfix"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Application Support"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpLink.ResumeLayout(False)
        Me.TlpLink.PerformLayout()
        Me.TlpBottom.ResumeLayout(False)
        Me.TlpBottom.PerformLayout()
        CType(Me.PbxLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents LabHead As Label
    Friend WithEvents PanSplit As Panel
    Friend WithEvents PanMain As Panel
    Friend WithEvents LabInfo As Label
    Friend WithEvents LnkHotfix As LinkLabel
    Friend WithEvents LabInfo2 As Label
    Friend WithEvents TlpBottom As TableLayoutPanel
    Friend WithEvents CmdInstall As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents LabDownload As Label
    Friend WithEvents PbxLoad As PictureBox
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents TlpButtons As TableLayoutPanel
    Friend WithEvents LabLink As Label
    Friend WithEvents TlpLink As TableLayoutPanel
End Class
