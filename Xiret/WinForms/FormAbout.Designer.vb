<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.LnkBitmight = New System.Windows.Forms.LinkLabel()
        Me.LnkLinks = New System.Windows.Forms.LinkLabel()
        Me.LabCopyright = New System.Windows.Forms.Label()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.TlpLabels = New System.Windows.Forms.TableLayoutPanel()
        Me.LabBuild = New System.Windows.Forms.Label()
        Me.LabAppName = New System.Windows.Forms.Label()
        Me.PbxEfa = New System.Windows.Forms.PictureBox()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpLabels.SuspendLayout()
        CType(Me.PbxEfa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanHead.TabIndex = 69
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
        Me.LabHead.Size = New System.Drawing.Size(350, 32)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "About"
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
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(414, 2)
        Me.PanSplit.TabIndex = 72
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanMain.Controls.Add(Me.LnkBitmight)
        Me.PanMain.Controls.Add(Me.LnkLinks)
        Me.PanMain.Controls.Add(Me.LabCopyright)
        Me.PanMain.Controls.Add(Me.TlpTop)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 35)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(414, 212)
        Me.PanMain.TabIndex = 0
        '
        'LnkBitmight
        '
        Me.LnkBitmight.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkBitmight.BackColor = System.Drawing.Color.Transparent
        Me.LnkBitmight.Dock = System.Windows.Forms.DockStyle.Top
        Me.LnkBitmight.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkBitmight.ForeColor = System.Drawing.Color.White
        Me.LnkBitmight.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkBitmight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkBitmight.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkBitmight.Location = New System.Drawing.Point(0, 114)
        Me.LnkBitmight.Margin = New System.Windows.Forms.Padding(0)
        Me.LnkBitmight.Name = "LnkBitmight"
        Me.LnkBitmight.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.LnkBitmight.Size = New System.Drawing.Size(414, 46)
        Me.LnkBitmight.TabIndex = 7
        Me.LnkBitmight.Text = "This software was developed by, and is the intellectual property of David S at Bi" &
    "tmight Software. So don't eat it."
        Me.LnkBitmight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkLinks
        '
        Me.LnkLinks.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkLinks.BackColor = System.Drawing.Color.Transparent
        Me.LnkLinks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LnkLinks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLinks.ForeColor = System.Drawing.Color.White
        Me.LnkLinks.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LnkLinks.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkLinks.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkLinks.Location = New System.Drawing.Point(0, 166)
        Me.LnkLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.LnkLinks.Name = "LnkLinks"
        Me.LnkLinks.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.LnkLinks.Size = New System.Drawing.Size(414, 46)
        Me.LnkLinks.TabIndex = 6
        Me.LnkLinks.Text = "Support Forum · Contact Me · Source Code"
        Me.LnkLinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabCopyright
        '
        Me.LabCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LabCopyright.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabCopyright.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LabCopyright.Location = New System.Drawing.Point(0, 72)
        Me.LabCopyright.Margin = New System.Windows.Forms.Padding(0)
        Me.LabCopyright.Name = "LabCopyright"
        Me.LabCopyright.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.LabCopyright.Size = New System.Drawing.Size(414, 42)
        Me.LabCopyright.TabIndex = 0
        Me.LabCopyright.Text = "© Bitmight Software 2016-2021."
        Me.LabCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TlpTop
        '
        Me.TlpTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TlpTop.ColumnCount = 3
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TlpTop.Controls.Add(Me.PbxLogo, 0, 0)
        Me.TlpTop.Controls.Add(Me.TlpLabels, 1, 0)
        Me.TlpTop.Controls.Add(Me.PbxEfa, 2, 0)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpTop.Location = New System.Drawing.Point(0, 0)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.Size = New System.Drawing.Size(414, 72)
        Me.TlpTop.TabIndex = 0
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxLogo.Location = New System.Drawing.Point(10, 10)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(51, 51)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLogo.TabIndex = 85
        Me.PbxLogo.TabStop = False
        '
        'TlpLabels
        '
        Me.TlpLabels.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TlpLabels.BackColor = System.Drawing.Color.Transparent
        Me.TlpLabels.ColumnCount = 1
        Me.TlpLabels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLabels.Controls.Add(Me.LabBuild, 0, 1)
        Me.TlpLabels.Controls.Add(Me.LabAppName, 0, 0)
        Me.TlpLabels.Location = New System.Drawing.Point(77, 15)
        Me.TlpLabels.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.TlpLabels.Name = "TlpLabels"
        Me.TlpLabels.RowCount = 2
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TlpLabels.Size = New System.Drawing.Size(249, 42)
        Me.TlpLabels.TabIndex = 86
        '
        'LabBuild
        '
        Me.LabBuild.AutoSize = True
        Me.LabBuild.BackColor = System.Drawing.Color.Transparent
        Me.LabBuild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabBuild.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBuild.ForeColor = System.Drawing.Color.White
        Me.LabBuild.Location = New System.Drawing.Point(0, 21)
        Me.LabBuild.Margin = New System.Windows.Forms.Padding(0)
        Me.LabBuild.Name = "LabBuild"
        Me.LabBuild.Size = New System.Drawing.Size(249, 21)
        Me.LabBuild.TabIndex = 78
        Me.LabBuild.Text = "..."
        Me.LabBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabAppName
        '
        Me.LabAppName.AutoSize = True
        Me.LabAppName.BackColor = System.Drawing.Color.Transparent
        Me.LabAppName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabAppName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAppName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LabAppName.Location = New System.Drawing.Point(0, 0)
        Me.LabAppName.Margin = New System.Windows.Forms.Padding(0)
        Me.LabAppName.Name = "LabAppName"
        Me.LabAppName.Size = New System.Drawing.Size(249, 21)
        Me.LabAppName.TabIndex = 75
        Me.LabAppName.Text = "Xiret❷"
        Me.LabAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PbxEfa
        '
        Me.PbxEfa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxEfa.BackColor = System.Drawing.Color.Transparent
        Me.PbxEfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxEfa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxEfa.Location = New System.Drawing.Point(352, 10)
        Me.PbxEfa.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxEfa.Name = "PbxEfa"
        Me.PbxEfa.Size = New System.Drawing.Size(51, 51)
        Me.PbxEfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxEfa.TabIndex = 87
        Me.PbxEfa.TabStop = False
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(416, 248)
        Me.MinimumSize = New System.Drawing.Size(416, 248)
        Me.Name = "FormAbout"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpLabels.ResumeLayout(False)
        Me.TlpLabels.PerformLayout()
        CType(Me.PbxEfa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents TlpLabels As TableLayoutPanel
    Friend WithEvents LabAppName As Label
    Friend WithEvents LabCopyright As Label
    Friend WithEvents PbxEfa As PictureBox
    Friend WithEvents LabBuild As Label
    Friend WithEvents TlpTop As TableLayoutPanel
    Friend WithEvents LabHead As Label
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents LnkLinks As LinkLabel
    Friend WithEvents LnkBitmight As LinkLabel
End Class
