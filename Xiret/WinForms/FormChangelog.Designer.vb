<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChangelog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangelog))
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.RtbChanges = New System.Windows.Forms.RichTextBox()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(778, 2)
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
        Me.PanHead.Size = New System.Drawing.Size(778, 40)
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
        Me.LabHead.Size = New System.Drawing.Size(698, 40)
        Me.LabHead.TabIndex = 75
        Me.LabHead.Text = "Changelog"
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
        Me.CmdClose.Location = New System.Drawing.Point(738, 0)
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
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(778, 656)
        Me.PanMain.TabIndex = 75
        '
        'TlpMain
        '
        Me.TlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpMain.Controls.Add(Me.RtbChanges, 0, 0)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMain.Location = New System.Drawing.Point(0, 0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.RowCount = 1
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpMain.Size = New System.Drawing.Size(778, 656)
        Me.TlpMain.TabIndex = 1
        '
        'RtbChanges
        '
        Me.RtbChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RtbChanges.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtbChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbChanges.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbChanges.ForeColor = System.Drawing.Color.White
        Me.RtbChanges.Location = New System.Drawing.Point(6, 6)
        Me.RtbChanges.Margin = New System.Windows.Forms.Padding(6)
        Me.RtbChanges.MaxLength = 999999
        Me.RtbChanges.Name = "RtbChanges"
        Me.RtbChanges.ReadOnly = True
        Me.RtbChanges.Size = New System.Drawing.Size(766, 644)
        Me.RtbChanges.TabIndex = 0
        Me.RtbChanges.TabStop = False
        Me.RtbChanges.Text = "" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormChangelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 700)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(780, 700)
        Me.Name = "FormChangelog"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Changelog"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSplit As Panel
    Friend WithEvents PanHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents PanMain As Panel
    Friend WithEvents TlpMain As TableLayoutPanel
    Friend WithEvents RtbChanges As RichTextBox
    Friend WithEvents LabHead As Label
End Class
