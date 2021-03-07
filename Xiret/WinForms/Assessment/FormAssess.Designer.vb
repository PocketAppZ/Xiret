Imports Xiret.Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAssess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAssess))
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.LabStatus = New System.Windows.Forms.Label()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxLoad = New System.Windows.Forms.PictureBox()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpData = New System.Windows.Forms.TableLayoutPanel()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        Me.TlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdViewLog = New System.Windows.Forms.Button()
        Me.CmdExport = New System.Windows.Forms.Button()
        Me.TlpStatus = New System.Windows.Forms.TableLayoutPanel()
        Me.LabProgress = New System.Windows.Forms.Label()
        Me.PbrProgress = New GambolProgressBar()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpData.SuspendLayout()
        Me.TlpButtons.SuspendLayout()
        Me.TlpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(0, 0)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(361, 40)
        Me.CmdCancel.TabIndex = 0
        Me.CmdCancel.Text = "Quit Process"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'LabStatus
        '
        Me.LabStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabStatus.ForeColor = System.Drawing.Color.White
        Me.LabStatus.Location = New System.Drawing.Point(0, 0)
        Me.LabStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.LabStatus.Name = "LabStatus"
        Me.LabStatus.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabStatus.Size = New System.Drawing.Size(955, 40)
        Me.LabStatus.TabIndex = 0
        Me.LabStatus.Text = "Starting..."
        Me.LabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.PanHead.Size = New System.Drawing.Size(1098, 40)
        Me.PanHead.TabIndex = 1
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
        Me.LabHead.Size = New System.Drawing.Size(1018, 40)
        Me.LabHead.TabIndex = 10
        Me.LabHead.Text = "In-Depth Assessment"
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
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(1058, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TlpHeadImage.Controls.Add(Me.PbxLoad, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(40, 40)
        Me.TlpHeadImage.TabIndex = 9
        '
        'PbxLoad
        '
        Me.PbxLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxLoad.BackColor = System.Drawing.Color.Transparent
        Me.PbxLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxLoad.Location = New System.Drawing.Point(8, 8)
        Me.PbxLoad.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.PbxLoad.Name = "PbxLoad"
        Me.PbxLoad.Size = New System.Drawing.Size(24, 24)
        Me.PbxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLoad.TabIndex = 5
        Me.PbxLoad.TabStop = False
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpData)
        Me.PanMain.Controls.Add(Me.TlpButtons)
        Me.PanMain.Controls.Add(Me.TlpStatus)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 46)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(1098, 653)
        Me.PanMain.TabIndex = 75
        '
        'TlpData
        '
        Me.TlpData.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TlpData.ColumnCount = 1
        Me.TlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpData.Controls.Add(Me.RtbLog, 0, 0)
        Me.TlpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpData.Location = New System.Drawing.Point(0, 40)
        Me.TlpData.Name = "TlpData"
        Me.TlpData.RowCount = 1
        Me.TlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 573.0!))
        Me.TlpData.Size = New System.Drawing.Size(1098, 573)
        Me.TlpData.TabIndex = 81
        '
        'RtbLog
        '
        Me.RtbLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtbLog.DetectUrls = False
        Me.RtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbLog.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.RtbLog.Location = New System.Drawing.Point(6, 6)
        Me.RtbLog.Margin = New System.Windows.Forms.Padding(6)
        Me.RtbLog.Name = "RtbLog"
        Me.RtbLog.ReadOnly = True
        Me.RtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RtbLog.Size = New System.Drawing.Size(1086, 561)
        Me.RtbLog.TabIndex = 0
        Me.RtbLog.TabStop = False
        Me.RtbLog.Text = ""
        '
        'TlpButtons
        '
        Me.TlpButtons.ColumnCount = 5
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TlpButtons.Controls.Add(Me.CmdViewLog, 2, 0)
        Me.TlpButtons.Controls.Add(Me.CmdExport, 4, 0)
        Me.TlpButtons.Controls.Add(Me.CmdCancel, 0, 0)
        Me.TlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TlpButtons.Location = New System.Drawing.Point(0, 613)
        Me.TlpButtons.Name = "TlpButtons"
        Me.TlpButtons.RowCount = 1
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpButtons.Size = New System.Drawing.Size(1098, 40)
        Me.TlpButtons.TabIndex = 77
        '
        'CmdViewLog
        '
        Me.CmdViewLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdViewLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdViewLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdViewLog.FlatAppearance.BorderSize = 0
        Me.CmdViewLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdViewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdViewLog.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdViewLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdViewLog.Location = New System.Drawing.Point(368, 0)
        Me.CmdViewLog.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdViewLog.Name = "CmdViewLog"
        Me.CmdViewLog.Size = New System.Drawing.Size(361, 40)
        Me.CmdViewLog.TabIndex = 1
        Me.CmdViewLog.Text = "View Xiret Log"
        Me.CmdViewLog.UseVisualStyleBackColor = False
        '
        'CmdExport
        '
        Me.CmdExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdExport.Enabled = False
        Me.CmdExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdExport.FlatAppearance.BorderSize = 0
        Me.CmdExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdExport.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdExport.Location = New System.Drawing.Point(736, 0)
        Me.CmdExport.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(362, 40)
        Me.CmdExport.TabIndex = 2
        Me.CmdExport.Text = "Export Session"
        Me.CmdExport.UseVisualStyleBackColor = False
        '
        'TlpStatus
        '
        Me.TlpStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TlpStatus.ColumnCount = 2
        Me.TlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.0!))
        Me.TlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TlpStatus.Controls.Add(Me.LabStatus, 0, 0)
        Me.TlpStatus.Controls.Add(Me.LabProgress, 1, 0)
        Me.TlpStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpStatus.Location = New System.Drawing.Point(0, 0)
        Me.TlpStatus.Name = "TlpStatus"
        Me.TlpStatus.RowCount = 1
        Me.TlpStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpStatus.Size = New System.Drawing.Size(1098, 40)
        Me.TlpStatus.TabIndex = 80
        '
        'LabProgress
        '
        Me.LabProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabProgress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabProgress.Location = New System.Drawing.Point(955, 0)
        Me.LabProgress.Margin = New System.Windows.Forms.Padding(0)
        Me.LabProgress.Name = "LabProgress"
        Me.LabProgress.Size = New System.Drawing.Size(143, 40)
        Me.LabProgress.TabIndex = 79
        Me.LabProgress.Text = "0"
        Me.LabProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PbrProgress
        '
        Me.PbrProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.PbrProgress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PbrProgress.Dock = System.Windows.Forms.DockStyle.Top
        Me.PbrProgress.IsTransparent = False
        Me.PbrProgress.Location = New System.Drawing.Point(1, 41)
        Me.PbrProgress.Maximum = 100
        Me.PbrProgress.Name = "PbrProgress"
        Me.PbrProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PbrProgress.ShowBorder = False
        Me.PbrProgress.Size = New System.Drawing.Size(1098, 5)
        Me.PbrProgress.TabIndex = 79
        Me.PbrProgress.Text = "GambolProgressBar1"
        Me.PbrProgress.Value = 0
        '
        'FormAssess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PbrProgress)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "FormAssess"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Xiret Assessment"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpData.ResumeLayout(False)
        Me.TlpButtons.ResumeLayout(False)
        Me.TlpStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabStatus As System.Windows.Forms.Label
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents TlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CmdViewLog As System.Windows.Forms.Button
    Friend WithEvents PbxLoad As System.Windows.Forms.PictureBox
    Friend WithEvents CmdExport As System.Windows.Forms.Button
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CmdClose As Button
    Friend WithEvents LabHead As Label
    Friend WithEvents TlpStatus As TableLayoutPanel
    Friend WithEvents LabProgress As Label
    Friend WithEvents TlpData As TableLayoutPanel
    Friend WithEvents RtbLog As RichTextBox
    Friend WithEvents PbrProgress As GambolProgressBar
End Class
