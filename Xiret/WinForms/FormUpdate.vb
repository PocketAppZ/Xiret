'  Updated on 29.07.2019 - DS (Migrating to new system)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports System.IO
Imports System.Net

Imports Xiret.Core.Helpers

Public Class FormUpdate

    Private Shared DLPath As String = ""

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetThemeAccent()

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

    Private Sub FormUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Booleans.MissingUpdate Then
            LabInfo.Text = "An application update is available to download."
            CmdDownload.Enabled = True
        Else
            LabInfo.Text = "No update available."
            CmdDownload.Enabled = False
        End If

        LabCurrent.Text = Updater.LocalVersion & " · " & Program.X_ReleaseDate
        LabServer.Text = Updater.ServerVersion & " · " & Updater.ReleaseDate

    End Sub

#End Region

#Region "Theme"

    Private Sub SetThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        LnkChangelog.LinkColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpBottom.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
    End Sub

#End Region
#Region "Linklabel Event Handlers"

    Private Sub LnkChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkChangelog.LinkClicked
        Process.Start("https://www.bitmight.uk/software/xiret/changelog.txt")
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

#Region "WebClient"
    Private Sub CmdDownload_Click(sender As Object, e As EventArgs) Handles CmdDownload.Click

        If NetHelper.IsWebsiteAvailable(Strings.BitmightUrl) = True Then

            Dim FBD As New FolderBrowserDialog With {
            .ShowNewFolderButton = True,
               .Description = "Select a path..."
            }

            If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then

                CType(sender, Button).Enabled = False

                Dim WClient As New WebClient
                AddHandler WClient.DownloadProgressChanged, AddressOf WClient_ProgressChanged
                AddHandler WClient.DownloadFileCompleted, AddressOf WClient_DownloadCompleted

                DLPath = Path.Combine(FBD.SelectedPath, "xiret.zip")

                WClient.DownloadFileAsync(New Uri(Strings.XiretZipUrl), DLPath)
                WClient.Dispose()

            End If
            FBD.Dispose()
        Else
            ToastAlert.Show("Could not reach server", ToastType.Warning)
        End If

    End Sub
    Private Sub WClient_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        LabDownload.Text = "Downloading: " & Integer.Parse(Math.Truncate(percentage).ToString()) & "%"

        'PbrUpdate.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        'PbrUpdate.Refresh()

    End Sub
    Private Sub WClient_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

        CmdDownload.Enabled = True
        LabDownload.Text = ""
        'PbrUpdate.Value = 0
        'PbrUpdate.Hide()

        If File.Exists(DLPath) = True Then
            Process.Start(DLPath)
        End If

        Application.Exit()

    End Sub

#End Region

End Class