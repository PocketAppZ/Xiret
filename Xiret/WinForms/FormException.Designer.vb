<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormException
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormException))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.TlpSep = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdContinue = New System.Windows.Forms.Button()
        Me.CmdForceQuit = New System.Windows.Forms.Button()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.LabError = New System.Windows.Forms.Label()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdSaveLog = New System.Windows.Forms.Button()
        Me.PanLinks = New System.Windows.Forms.Panel()
        Me.LnkForum = New System.Windows.Forms.LinkLabel()
        Me.LnkEmail = New System.Windows.Forms.LinkLabel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        Me.TlpButtons.SuspendLayout()
        Me.PanLinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.TlpSep)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(588, 40)
        Me.PanHead.TabIndex = 1
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(40, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(508, 40)
        Me.LabHead.TabIndex = 15
        Me.LabHead.Text = "Unhandled Exception Caught"
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
        Me.TlpHeadImage.TabIndex = 16
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
        'TlpSep
        '
        Me.TlpSep.BackColor = System.Drawing.Color.Transparent
        Me.TlpSep.ColumnCount = 1
        Me.TlpSep.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpSep.Dock = System.Windows.Forms.DockStyle.Right
        Me.TlpSep.Location = New System.Drawing.Point(548, 0)
        Me.TlpSep.Name = "TlpSep"
        Me.TlpSep.RowCount = 1
        Me.TlpSep.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpSep.Size = New System.Drawing.Size(40, 40)
        Me.TlpSep.TabIndex = 17
        '
        'CmdContinue
        '
        Me.CmdContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdContinue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdContinue.Enabled = False
        Me.CmdContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdContinue.FlatAppearance.BorderSize = 0
        Me.CmdContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdContinue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdContinue.Location = New System.Drawing.Point(117, 0)
        Me.CmdContinue.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdContinue.Name = "CmdContinue"
        Me.CmdContinue.Size = New System.Drawing.Size(110, 35)
        Me.CmdContinue.TabIndex = 3
        Me.CmdContinue.TabStop = False
        Me.CmdContinue.Text = "Continue"
        Me.CmdContinue.UseVisualStyleBackColor = False
        '
        'CmdForceQuit
        '
        Me.CmdForceQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdForceQuit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdForceQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdForceQuit.FlatAppearance.BorderSize = 0
        Me.CmdForceQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdForceQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdForceQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdForceQuit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdForceQuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdForceQuit.Location = New System.Drawing.Point(0, 0)
        Me.CmdForceQuit.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdForceQuit.Name = "CmdForceQuit"
        Me.CmdForceQuit.Size = New System.Drawing.Size(110, 35)
        Me.CmdForceQuit.TabIndex = 2
        Me.CmdForceQuit.TabStop = False
        Me.CmdForceQuit.Text = "Force Quit"
        Me.CmdForceQuit.UseVisualStyleBackColor = False
        '
        'LabInfo
        '
        Me.LabInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.LabInfo.Location = New System.Drawing.Point(0, 122)
        Me.LabInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Size = New System.Drawing.Size(588, 127)
        Me.LabInfo.TabIndex = 7
        Me.LabInfo.Text = resources.GetString("LabInfo.Text")
        Me.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabError
        '
        Me.LabError.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LabError.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabError.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabError.ForeColor = System.Drawing.Color.Tomato
        Me.LabError.Location = New System.Drawing.Point(0, 0)
        Me.LabError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabError.Name = "LabError"
        Me.LabError.Size = New System.Drawing.Size(588, 122)
        Me.LabError.TabIndex = 6
        Me.LabError.Text = "..."
        Me.LabError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(588, 2)
        Me.PanSplit.TabIndex = 73
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.LabInfo)
        Me.PanMain.Controls.Add(Me.TlpBottom)
        Me.PanMain.Controls.Add(Me.LabError)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(588, 301)
        Me.PanMain.TabIndex = 74
        '
        'TlpBottom
        '
        Me.TlpBottom.ColumnCount = 2
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.50085!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.49915!))
        Me.TlpBottom.Controls.Add(Me.TlpButtons, 1, 0)
        Me.TlpBottom.Controls.Add(Me.PanLinks, 0, 0)
        Me.TlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TlpBottom.Location = New System.Drawing.Point(0, 249)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 1
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(588, 52)
        Me.TlpBottom.TabIndex = 13
        '
        'TlpButtons
        '
        Me.TlpButtons.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TlpButtons.ColumnCount = 5
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TlpButtons.Controls.Add(Me.CmdForceQuit, 0, 0)
        Me.TlpButtons.Controls.Add(Me.CmdContinue, 2, 0)
        Me.TlpButtons.Controls.Add(Me.CmdSaveLog, 4, 0)
        Me.TlpButtons.Location = New System.Drawing.Point(236, 8)
        Me.TlpButtons.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.TlpButtons.Name = "TlpButtons"
        Me.TlpButtons.RowCount = 1
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpButtons.Size = New System.Drawing.Size(344, 35)
        Me.TlpButtons.TabIndex = 12
        '
        'CmdSaveLog
        '
        Me.CmdSaveLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSaveLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdSaveLog.Enabled = False
        Me.CmdSaveLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSaveLog.FlatAppearance.BorderSize = 0
        Me.CmdSaveLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdSaveLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSaveLog.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSaveLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdSaveLog.Location = New System.Drawing.Point(234, 0)
        Me.CmdSaveLog.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSaveLog.Name = "CmdSaveLog"
        Me.CmdSaveLog.Size = New System.Drawing.Size(110, 35)
        Me.CmdSaveLog.TabIndex = 4
        Me.CmdSaveLog.TabStop = False
        Me.CmdSaveLog.Text = "Save Log"
        Me.CmdSaveLog.UseVisualStyleBackColor = False
        '
        'PanLinks
        '
        Me.PanLinks.Controls.Add(Me.LnkForum)
        Me.PanLinks.Controls.Add(Me.LnkEmail)
        Me.PanLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanLinks.Location = New System.Drawing.Point(0, 0)
        Me.PanLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.PanLinks.Name = "PanLinks"
        Me.PanLinks.Size = New System.Drawing.Size(226, 52)
        Me.PanLinks.TabIndex = 13
        '
        'LnkForum
        '
        Me.LnkForum.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkForum.AutoSize = True
        Me.LnkForum.BackColor = System.Drawing.Color.Transparent
        Me.LnkForum.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkForum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkForum.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkForum.Location = New System.Drawing.Point(15, 14)
        Me.LnkForum.Name = "LnkForum"
        Me.LnkForum.Size = New System.Drawing.Size(125, 23)
        Me.LnkForum.TabIndex = 0
        Me.LnkForum.TabStop = True
        Me.LnkForum.Text = "Support Forum"
        '
        'LnkEmail
        '
        Me.LnkEmail.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkEmail.AutoSize = True
        Me.LnkEmail.BackColor = System.Drawing.Color.Transparent
        Me.LnkEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkEmail.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkEmail.Location = New System.Drawing.Point(155, 14)
        Me.LnkEmail.Name = "LnkEmail"
        Me.LnkEmail.Size = New System.Drawing.Size(51, 23)
        Me.LnkEmail.TabIndex = 1
        Me.LnkEmail.TabStop = True
        Me.LnkEmail.Text = "Email"
        '
        'FormException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 345)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(590, 345)
        Me.MinimumSize = New System.Drawing.Size(590, 345)
        Me.Name = "FormException"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unhandled Exception"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpBottom.ResumeLayout(False)
        Me.TlpButtons.ResumeLayout(False)
        Me.PanLinks.ResumeLayout(False)
        Me.PanLinks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabInfo As System.Windows.Forms.Label
    Friend WithEvents LabError As System.Windows.Forms.Label
    Friend WithEvents CmdContinue As System.Windows.Forms.Button
    Friend WithEvents CmdForceQuit As System.Windows.Forms.Button
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents TlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CmdSaveLog As System.Windows.Forms.Button
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents LnkEmail As LinkLabel
    Friend WithEvents LnkForum As LinkLabel
    Friend WithEvents TlpSep As TableLayoutPanel
    Friend WithEvents TlpBottom As TableLayoutPanel
    Friend WithEvents PanLinks As Panel
End Class
