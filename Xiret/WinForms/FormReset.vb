'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'  Updated on 03.01.2020 - DS (Enable simultanious deletion of winsat and xiret data, cleanup)
'  Updated on 01.02.2020 - CA (Omit settings var CreateFilepath) - DS (Enhance deletion of config files)

Imports System.IO

Imports Xiret.Core.Helpers

Public Class FormReset

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetCleanupThemeAccent()

        PanHead.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)
        Settings.SetWindowIcon(PbxHead)

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormCleanup_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region
#Region "Frame Buttons"
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormCleanup_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabNotRecover.Visible = False
    End Sub

#End Region

#Region "Theme"
    Private Sub SetCleanupThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        CbxDeleteWinsatCfg.CheckedColor = Settings.ThemeColor
        CbxDeleteApplicationCfg.CheckedColor = Settings.ThemeColor

        CmdDelete.ForeColor = Settings.ThemeColor

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click

        Try
            If CbxDeleteWinsatCfg.Checked Then
                'Delete system scores
                BatchRemoveFiles("*.xml", Directories.WinsatDatastorePath)
                'Delete winsat log
                BatchRemoveFiles("*.log", Directories.WinsatPath)
            End If

            If CbxDeleteApplicationCfg.Checked Then

                'Enumerate configs + storage files
                Dim HS As New List(Of String) From {
                Settings.AppdataSettingsPath,   'Settings (Appdata)
                Settings.LocalSettingsPath,     'Settings (Local)
                Settings.LangPath,              'Lang.ini 
                Settings.AssessmentLogPath,     'Log file
                Settings.ImgurUrlsPath          'Imgur URL storage
                }

                'Delete files in list ^
                For Each Hit As String In HS
                    If File.Exists(Hit) Then
                        File.Delete(Hit)
                    End If
                Next

                'Delete application directory
                If Directory.Exists(Settings.AppdataDir) Then
                    Directory.Delete(Settings.AppdataDir)
                End If

                Application.Exit()

            Else
                Application.Restart()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during deletion:" & vbCrLf & ex.Message, "CmdDelete.Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region
#Region "Checkbox Event Handlers"

    Private Sub Checkboxes_CheckedChanged(sender As Object, e As EventArgs) Handles CbxDeleteApplicationCfg.CheckedChanged, CbxDeleteWinsatCfg.CheckedChanged

        If CbxDeleteWinsatCfg.Checked Or CbxDeleteApplicationCfg.Checked Then
            CmdDelete.Enabled = True
            LabNotRecover.Visible = True
        Else
            CmdDelete.Enabled = False
            LabNotRecover.Visible = False
        End If

    End Sub

#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxHead_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "Routines"

    Private Sub BatchRemoveFiles(Flags As String, ByVal DirPath As String)

        Dim Array() As String = Directory.GetFileSystemEntries(DirPath, Flags)
        For Each Hit As String In Array
            If Not Directory.Exists(Hit) Then
                File.Delete(Path.Combine(DirPath, Path.GetFileName(Hit)))
            End If
        Next

    End Sub

#End Region

End Class