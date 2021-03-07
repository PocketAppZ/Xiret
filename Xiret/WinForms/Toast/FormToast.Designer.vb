Imports Xiret.Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormToast
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerTick = New System.Windows.Forms.Timer(Me.components)
        Me.LabTitle = New System.Windows.Forms.Label()
        Me.LabMessage = New System.Windows.Forms.Label()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.PbxTypeImage = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.GProgressBar = New GambolProgressBar()
        Me.PanMain.SuspendLayout()
        CType(Me.PbxTypeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerTick
        '
        Me.TimerTick.Enabled = True
        Me.TimerTick.Interval = 10
        '
        'LabTitle
        '
        Me.LabTitle.AutoSize = True
        Me.LabTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTitle.ForeColor = System.Drawing.Color.White
        Me.LabTitle.Location = New System.Drawing.Point(50, 17)
        Me.LabTitle.Name = "LabTitle"
        Me.LabTitle.Size = New System.Drawing.Size(22, 23)
        Me.LabTitle.TabIndex = 0
        Me.LabTitle.Text = "..."
        Me.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabMessage
        '
        Me.LabMessage.BackColor = System.Drawing.Color.Transparent
        Me.LabMessage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LabMessage.Location = New System.Drawing.Point(52, 47)
        Me.LabMessage.Name = "LabMessage"
        Me.LabMessage.Size = New System.Drawing.Size(435, 75)
        Me.LabMessage.TabIndex = 1
        Me.LabMessage.Text = "..."
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanMain.Controls.Add(Me.PbxTypeImage)
        Me.PanMain.Controls.Add(Me.CmdClose)
        Me.PanMain.Controls.Add(Me.GProgressBar)
        Me.PanMain.Controls.Add(Me.LabTitle)
        Me.PanMain.Controls.Add(Me.LabMessage)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 1)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(498, 143)
        Me.PanMain.TabIndex = 0
        '
        'PbxTypeImage
        '
        Me.PbxTypeImage.BackColor = System.Drawing.Color.Transparent
        Me.PbxTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxTypeImage.Location = New System.Drawing.Point(12, 12)
        Me.PbxTypeImage.Name = "PbxTypeImage"
        Me.PbxTypeImage.Size = New System.Drawing.Size(32, 32)
        Me.PbxTypeImage.TabIndex = 9
        Me.PbxTypeImage.TabStop = False
        '
        'CmdClose
        '
        Me.CmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(458, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'GProgressBar
        '
        Me.GProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.GProgressBar.BorderColor = System.Drawing.Color.Transparent
        Me.GProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GProgressBar.ForeColor = System.Drawing.Color.Transparent
        Me.GProgressBar.IsTransparent = False
        Me.GProgressBar.Location = New System.Drawing.Point(0, 137)
        Me.GProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.GProgressBar.Maximum = 200
        Me.GProgressBar.Name = "GProgressBar"
        Me.GProgressBar.ProgressColor = System.Drawing.Color.White
        Me.GProgressBar.ShowBorder = False
        Me.GProgressBar.Size = New System.Drawing.Size(498, 6)
        Me.GProgressBar.TabIndex = 0
        Me.GProgressBar.TabStop = False
        Me.GProgressBar.Text = "GProgressBar"
        Me.GProgressBar.Value = 0
        '
        'FormToast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 145)
        Me.Controls.Add(Me.PanMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(500, 145)
        Me.MinimumSize = New System.Drawing.Size(500, 145)
        Me.Name = "FormToast"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notification"
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        CType(Me.PbxTypeImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerTick As System.Windows.Forms.Timer
    Friend WithEvents LabMessage As System.Windows.Forms.Label
    Friend WithEvents LabTitle As System.Windows.Forms.Label
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents GProgressBar As GambolProgressBar
    Friend WithEvents CmdClose As Button
    Friend WithEvents PbxTypeImage As PictureBox
End Class
