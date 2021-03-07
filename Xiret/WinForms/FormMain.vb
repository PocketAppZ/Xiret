'  Some ContextMenu settings are overriden by Gambol\UI\MHRenderer like background color, etc
'  Updated on 16.10.2019 - DS (Update CheckNotify() to finish tasks before updating menu items)
'  Updated on 21.10.2019 - DS (Switch thread to task, task handling)
'  Updated on 15.04.2020 - DS (Add assessment overrides based on selection)
'  Updated on 29.05.2020 - DS (Fixed Win32Excptions)

' Thanks to:
' https://www.transparenttextures.com/

Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers
Imports Xiret.Core.WMI
Imports Xiret.Gambol.Controls
Imports Xiret.Gambol.UI
Imports Xiret.Winsat

Public Class FormMain

    Public Sub New()

        InitializeComponent()

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetMainThemeAccent()

        CmsExport.Renderer = New GambolToolstripRenderer
        CmsOptions.Renderer = New GambolToolstripRenderer
        CmsTools.Renderer = New GambolToolstripRenderer
        CmsHelp.Renderer = New GambolToolstripRenderer
        CmsExplorer.Renderer = New GambolToolstripRenderer

        PanHead.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)
        TlpMenu.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)

        Settings.SetWindowIcon(PbxHead)

    End Sub

#Region "Overriden Properties"
    Const WS_MINIMIZEBOX As Integer = &H20000
    Const CS_DBLCLKS As Integer = &H8
    Const CS_DROP As Integer = &H20000
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Params As CreateParams = MyBase.CreateParams
            Params.Style = Params.Style Or WS_MINIMIZEBOX
            Params.ClassStyle = Params.ClassStyle Or CS_DBLCLKS Or CS_DROP
            Return Params
        End Get
    End Property
#End Region
#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove, PanHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Application.Exit()
    End Sub

    Private Sub CmdMinimize_Click(sender As Object, e As EventArgs) Handles CmdMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CmdSettings_Click(sender As Object, e As EventArgs) Handles CmdSettings.Click
        Fade.FadeBehindChild(Me)
        Dim F As New FormSettings
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()
    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'EXPORT MENU

        'Save as JPG
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.J Then
            JPGToolStripMenuItem.PerformClick()
        End If

        'Save as PNG
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.P Then
            PNGToolStripMenuItem.PerformClick()
        End If

        'Save as BMP
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.B Then
            BMPToolStripMenuItem.PerformClick()
        End If

        'Save as text
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.T Then
            TXTToolStripMenuItem.PerformClick()
        End If

        'Upload Imgur
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.I Then
            ImgurToolStripMenuItem.PerformClick()
        End If
        '------------------------

        'OPTIONS MENU

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.L Then
            ViewImgurLinksToolStripMenuItem.PerformClick()
        End If

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.X Then
            ViewLogToolStripMenuItem.PerformClick()
        End If

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.W Then
            ViewWinSATLogToolStripMenuItem.PerformClick()
        End If

        'Refresh scores
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.ShiftKeyDown And e.KeyCode = Keys.R Then
            RefreshScoresToolStripMenuItem.PerformClick()
        End If

        'Save res
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.R Then
            SaveResourcesToDiskToolStripMenuItem.PerformClick()
        End If

        'View app data
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.G Then
            ProgramDataToolStripMenuItem.PerformClick()
        End If

        'Settings
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.S Then
            SettingsToolstripMenuItem.PerformClick()
        End If
        '------------------------

        'TOOLS MENU

        'Cleanup
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.C Then
            ResetToolStripMenuItem.PerformClick()
        End If

        'View System Details
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.D Then
            ViewSystemDetailsToolStripMenuItem.PerformClick()
        End If

        'Rate Normal
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.N Then
            RunToolStripMenuItem.PerformClick()
        End If

        'Rate Verbose
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.V Then
            RunVerboseToolStripMenuItem.PerformClick()
        End If
        '------------------------

        'HELP MENU

        'Media Feature Pack
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.M Then
            MediaFeaturePackToolStripMenuItem.PerformClick()
        End If

        'Troubleshooting
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.T Then
            TroubleshootingToolStripMenuItem.PerformClick()
        End If

        'Hotfix available
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.H Then
            HotfixAvailableToolStripMenuItem.PerformClick()
        End If

        'Update available
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.U Then
            UpdateAvailableToolStripMenuItem.PerformClick()
        End If

        'Changelog
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.L Then
            ChangelogToolStripMenuItem.PerformClick()
        End If

        'About
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.A Then
            AboutToolStripMenuItem.PerformClick()
        End If

        'Acknowledgements
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.K Then
            AcknowledgementsToolStripMenuItem.PerformClick()
        End If

        'Donate
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.Z Then
            DonateToolstripMenuItem.PerformClick()
        End If

    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Hide items that are only shown when needed
        HotfixAvailableToolStripMenuItem.Visible = False
        UpdateAvailableToolStripMenuItem.Visible = False

        'Load data to labels
        LabHeadVersion.Text = Program.X_Version

#If DEBUG Then
        LabHead.Text &= " (Dbg)"
#End If

        If OSHelper.IsWin10 Then
            LabOpSys.Text = OSHelper.GetWindowsName & " " & OSHelper.GetWindowsReleaseId & " " & OSHelper.GetWindowsBitness
        Else
            LabOpSys.Text = OSHelper.GetWindowsName & " " & OSHelper.GetWindowsCurrentBuild & " " & OSHelper.GetWindowsBitness
        End If

        LabScale.Text = DetermineScaleOf()

        'Load scores
        WSR5.GetWinsatSPR()

        'Show hardware
        If Settings.ShowHardwareOnStartup = 1 Then
            GswHardware.Checked = True
        End If

        'UI Update
        UpdateControls()

        'Check notifications
        Task.Factory.StartNew(Sub() CheckNotifications())

    End Sub

    Private Sub CheckNotifications()

        'Updated 07.10.2019
        'All hotfixes are loaded from WMI into a data array which can be referenced 3x faster with less overhead.
        'This means we're not iterating through every hotfix in WMI multiple times. Good news for slower processors.
        Dim ListOfUpdates As HashSet(Of String) = Knowledgebase.EnumerateHotfixes

        'Moved from Program.vb. Holds back spawn time on Win7.
        If OSHelper.IsWin7() Then
            'Check convenience rollup KB3125574
            If Not ListOfUpdates.Contains("KB3125574") Then 'Rollup missing, so...
                'Check for older patch KB2687862
                If Not ListOfUpdates.Contains("KB2687862") Then
                    Booleans.MissingHotfix = True 'Still missing
                Else
                    Booleans.MissingHotfix = False 'Installed
                End If
            Else
                Booleans.MissingHotfix = False 'Installed
            End If
        End If

        If Updater.IsNewVersionAvailable() Then
            Booleans.MissingUpdate = True
        End If

        Invoke(DirectCast(Sub() OnFinishedCheckNotifications(), MethodInvoker))

    End Sub

    Private Sub OnFinishedCheckNotifications()

        If Booleans.MissingHotfix Then
            Integers.NotificationCount += 1
            UpdateToolstripHotfixItem()
        End If

        If Booleans.MissingUpdate Then
            LabHeadVersion.BackColor = Color.FromArgb(100, 255, 185, 0)
            Integers.NotificationCount += 1
            UpdateToolstripUpdateItem()
        End If

        If Not Integers.NotificationCount = 0 Then
            NotifierMain.Controls.Add(CmdHelp, Integers.NotificationCount)
            NotifierMain.Activate()
        End If

    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Friend Sub SetMainThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        LabBasescore.ForeColor = Settings.ThemeColor
        GswHardware.CheckedColor = Settings.ThemeColor

        'Change buttons
        For Each Ctrl As Control In TlpTop.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In TlpBottom.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        'Export Menu
        For Each Item As ToolStripItem In CmsExport.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Options Menu
        For Each Item As ToolStripItem In CmsOptions.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Tools Menu
        For Each Item As ToolStripItem In CmsTools.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Help Menu
        For Each Item As ToolStripItem In CmsHelp.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Reverse changes to cmsHelp.items if notifications are available
        If Booleans.MissingHotfix Then
            UpdateToolstripHotfixItem()
        End If
        If Booleans.MissingUpdate Then
            UpdateToolstripUpdateItem()
        End If

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles CmdAssess.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If PowerHelper.IsAdapterPluggedIn() Then

                'Load default assessment mode from settings
                If Settings.UseVerboseMode = 0 Then
                    Booleans.AssessmentVerbose = False
                Else
                    Booleans.AssessmentVerbose = True
                End If

                Fade.FadeBehindChild(Me)
                Dim FAssess As New FormAssess
                AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
                FAssess.ShowDialog()

            End If
        End If

    End Sub
    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles cmdMetrics.Click

        If WinsatApi.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this feature.", ToastType.Warning)
        Else
            Fade.FadeBehindChild(Me)
            Dim FMetrics As New FormMetrics
            AddHandler FMetrics.FormClosed, AddressOf ChildFormClosedNoRefresh
            FMetrics.ShowDialog()
        End If

    End Sub
    Private Sub CmdRunInDepth_Click(sender As Object, e As EventArgs) Handles CmdRunInDepth.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else

            'Override settings
            Booleans.AssessmentVerbose = True

            Fade.FadeBehindChild(Me)
            Dim FAssess As New FormAssess
            AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
            FAssess.ShowDialog()

        End If
    End Sub
#End Region
#Region "Menu Button Event Handlers"
    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles CmdExport.Click

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("The system must be rated to use these features.", ToastType.Warning)
        Else
            Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
            ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
            CmsExport.Show(ptLowerLeft)
        End If

    End Sub
    Private Sub CmdOptions_Click(sender As Object, e As EventArgs) Handles CmdOptions.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsOptions.Show(ptLowerLeft)

    End Sub
    Private Sub CmdTools_Click(sender As Object, e As EventArgs) Handles CmdTools.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsTools.Show(ptLowerLeft)

    End Sub
    Private Sub CmdHelp_Click(sender As Object, e As EventArgs) Handles CmdHelp.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsHelp.Show(ptLowerLeft)

    End Sub
#End Region
#Region "Gambol Switch Event Handlers"

    Private Sub GswHardware_CheckedChanged(sender As Object, e As EventArgs) Handles GswHardware.CheckedChanged
        If CType(sender, GambolSwitch).Checked Then
            LabShowHardware.Text = "On"
            LabWhatIsRated.Text = "What is Rated? · System Hardware"
        Else
            LabShowHardware.Text = "Off"
            LabWhatIsRated.Text = "What is Rated?"
        End If
        SetHW()
    End Sub

#End Region
#Region "Picturebox Event Handlers"
    Private Sub PbxMain_DoubleClick(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToScreen()
    End Sub
#End Region
#Region "Label Event Handlers"

    Private Sub LabHeadVersion_Click(sender As Object, e As EventArgs) Handles LabHeadVersion.Click

        If Booleans.MissingUpdate Then
            Fade.FadeBehindChild(Me)

            Dim FUpdate As New FormUpdate
            AddHandler FUpdate.FormClosed, AddressOf ChildFormClosedNoRefresh
            FUpdate.ShowDialog()
        Else
            Fade.FadeBehindChild(Me)

            Dim FChangelog As New FormChangelog
            AddHandler FChangelog.FormClosed, AddressOf ChildFormClosedNoRefresh
            FChangelog.ShowDialog()
        End If

    End Sub

#End Region

#Region "Context Menu (Export)"

    Private Sub JPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JPGToolStripMenuItem.Click

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()
            Dim Sfd As New SaveFileDialog With {
                .FileName = "Xiret-JPG",
                .Filter = "JPEG (*.jpg)|*.jpg",
                .InitialDirectory = Directories.DesktopPath,
                .OverwritePrompt = True
            }
            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Jpeg)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved To " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could Not be saved To disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub PNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNGToolStripMenuItem.Click

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                   .FileName = "Xiret-PNG",
                   .Filter = "Portable Network Graphics (*.png)|*.png",
                   .InitialDirectory = Directories.DesktopPath,
                   .OverwritePrompt = True
                }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Png)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved To " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could Not be saved To disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub BMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMPToolStripMenuItem.Click

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                .FileName = "Xiret-BMP",
                .Filter = "Bitmap Image File (*.bmp)|*.bmp",
                .InitialDirectory = Directories.DesktopPath,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Bmp)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved To " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could Not be saved To disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub TXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem.Click

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            Dim SBuilder As New StringBuilder
            SBuilder.Append("Windows Experience Index scores generated by Xiret On " & Date.Today & "." & vbNewLine & vbNewLine)
            SBuilder.Append("Base Score: " & LabBasescore.Text & vbNewLine & vbNewLine)

            If Strings.ProcessorScore = Strings.BaseScore Then
                SBuilder.Append("Processor Score:  " & LabProcessorScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Processor Score:  " & LabProcessorScore.Text & vbNewLine)
            End If

            If Strings.MemoryScore = Strings.BaseScore Then
                SBuilder.Append("Memory Score:     " & LabMemoryScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Memory Score:     " & LabMemoryScore.Text & vbNewLine)
            End If

            If Strings.GraphicsScore = Strings.BaseScore Then
                SBuilder.Append("Graphics Score:   " & LabGraphicsScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Graphics Score:   " & LabGraphicsScore.Text & vbNewLine)
            End If

            If Strings.D3DScore = Strings.BaseScore Then
                SBuilder.Append("Gaming Score:     " & LabGamingScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Gaming Score:     " & LabGamingScore.Text & vbNewLine)
            End If

            If Strings.DiskScore = Strings.BaseScore Then
                SBuilder.Append("Disk Score:       " & LabDiskScore.Text & " (*)" & vbCrLf & vbCrLf)
            Else
                SBuilder.Append("Disk Score:       " & LabDiskScore.Text & vbCrLf & vbCrLf)
            End If

            SBuilder.Append("(*) - Lowest subscore")

            Dim Sfd As New SaveFileDialog With {
                .FileName = "Xiret-Scores",
                .Filter = "Text File (*.txt)|*.txt",
                .InitialDirectory = Directories.DesktopPath,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(Sfd.FileName, SBuilder.ToString, False)
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("File saved to " & Sfd.FileName.ToString, ToastType.Information)
                    End If
                End If
            Catch Ex As Exception
                ToastAlert.Show("Could not save scores to a text file.", ToastType.Warning)
                Throw
            Finally
                Sfd.Dispose()
            End Try

        End If

    End Sub
    Private Sub ImgurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImgurToolStripMenuItem.Click

        CType(sender, ToolStripMenuItem).Enabled = False

        If Strings.ImgurClientID.Length = 0 Then
            ToastAlert.Show("Imgur API client key needed.", ToastType.Warning)
        Else
            If CDbl(Strings.BaseScore) = 0 Then 'Unrated system
                ToastAlert.Show("You must rate your system first.", ToastType.Warning)
            Else 'Check imgur is online
                If NetHelper.IsWebsiteAvailable(Strings.ImgurUrl) Then

                    'Enter printscreen mode
                    EnterPrintMode()

                    'Capture image to upload
                    ImageHelper.CaptureControl(Files.TemporaryImgurFile, PanCapture)

                    ' // Imgur Api moved to Core\Helpers\ImageHelper > PostToImgur
                    If Settings.UseCustomImgurApiKey = 1 Then
                        UploadCustomClient()
                    Else
                        UploadNormalClient()
                    End If

                Else 'No connection to Imgur
                    ToastAlert.Show("Could not connect to Imgur. The service may be unavailable.", ToastType.Warning)
                End If
            End If
        End If

        'Finish up
        ExitPrintMode()

        CType(sender, ToolStripMenuItem).Enabled = True

    End Sub

    Private Sub UploadCustomClient()

        Dim exitCode As Integer = ImageHelper.PostToImgur(Files.TemporaryImgurFile, Settings.ImgurUrlsPath, Settings.StringUserImgurClientId, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

    Private Sub UploadNormalClient()

        Dim exitCode As Integer = ImageHelper.PostToImgur(Files.TemporaryImgurFile, Settings.ImgurUrlsPath, Strings.ImgurClientID, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

#End Region
#Region "Context Menu (Options)"

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click

        Try
            If File.Exists(Settings.AssessmentLogPath) Then
                Process.Start(Settings.AssessmentLogPath)
            Else
                ToastAlert.Show("The assessment log file has not been created. It will be available after rating your system at least once.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub ViewImgurLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImgurLinksToolStripMenuItem.Click

        Try
            If File.Exists(Settings.ImgurUrlsPath) Then
                Process.Start(Settings.ImgurUrlsPath)
            Else
                ToastAlert.Show("The Imgur link file has not been created. It will be available after you upload a valid system rating.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ViewWinSATLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWinSATLogToolStripMenuItem.Click

        Try
            If File.Exists(Files.WinsatLog) Then
                Process.Start(Files.WinsatLog)
            Else
                ToastAlert.Show("The winsat.log file does not exist.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub RefreshScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshScoresToolStripMenuItem.Click

        If WinsatApi.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this option.", ToastType.Warning)
        Else
            WSR5.GetWinsatSPR()
            UpdateControls()
            ToastAlert.Show("System scores reloaded.", ToastType.Information)
        End If

    End Sub

    Private Sub SaveResourcesToDIskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveResourcesToDiskToolStripMenuItem.Click

        Dim FBD As New FolderBrowserDialog With {
        .RootFolder = Environment.SpecialFolder.Desktop,
        .ShowNewFolderButton = True,
        .Description = "Choose a folder to save the items..."
        }

        If FBD.ShowDialog = DialogResult.OK Then
            File.WriteAllBytes(FBD.SelectedPath & "\Windows6_1_KB2687862_x86.msu", My.Resources.Windows6_1_KB2687862_x86)
            File.WriteAllBytes(FBD.SelectedPath & "\Windows6_1_KB2687862_x64.msu", My.Resources.Windows6_1_KB2687862_x64)
            File.WriteAllBytes(FBD.SelectedPath & "\segoeui.ttf", My.Resources.segoeui)
            File.WriteAllBytes(FBD.SelectedPath & "\segoeuib.ttf", My.Resources.segoeuib)
            File.WriteAllBytes(FBD.SelectedPath & "\seguisb.ttf", My.Resources.seguisb)
            File.WriteAllBytes(FBD.SelectedPath & "\segmdl2.ttf", My.Resources.segmdl2)
            ToastAlert.Show("Resources saved to " & FBD.SelectedPath & ".", ToastType.Information)
        End If

    End Sub

    Private Sub ProgramDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramDataToolStripMenuItem.Click

        Try
            If Directory.Exists(Settings.AppdataDir) Then
                Process.Start(Settings.AppdataDir)
            Else
                ToastAlert.Show("The appdata directory does not exist.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub SettingsToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolstripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormSettings
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub

#End Region
#Region "Context Menu (Tools)"
    Private Sub CleanupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormReset
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub
    Private Sub ViewSystemDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSystemDetailsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormSystem
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else

            'Override settings
            Booleans.AssessmentVerbose = False

            Fade.FadeBehindChild(Me)
            Dim F As New FormAssess
            AddHandler F.FormClosed, AddressOf ChildFormClosedRefreshUI
            F.ShowDialog()
        End If

    End Sub
    Private Sub RunVerboseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunVerboseToolStripMenuItem.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else

            'Override settings
            Booleans.AssessmentVerbose = True

            Fade.FadeBehindChild(Me)
            Dim F As New FormAssess
            AddHandler F.FormClosed, AddressOf ChildFormClosedRefreshUI
            F.ShowDialog()
        End If

    End Sub

#End Region
#Region "Context Menu (Help)"
    Private Sub MediaFeaturePackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MediaFeaturePackToolStripMenuItem.Click
        Process.Start(Strings.MediaFeatureUrl)
    End Sub
    Private Sub TroubleshootingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TroubleshootingToolStripMenuItem.Click

        Try
            Dim TroubProc As New Process
            Dim TempFile As String = Directories.TempFilesPath & "\Troubleshooting.rtf"

            Dim buff As Byte() = Encoding.UTF8.GetBytes(My.Resources.troubleshooting)

            File.WriteAllBytes(TempFile, buff)

            If File.Exists(TempFile) = True Then
                With TroubProc.StartInfo
                    .FileName = TempFile
                    .UseShellExecute = True
                    .WindowStyle = ProcessWindowStyle.Maximized
                End With
                TroubProc.Start()
            End If
        Catch ex As IOException
            ToastAlert.Show("Troubleshooting is already open.", ToastType.Information)
        End Try

    End Sub
    Private Sub HotfixAvaiableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotfixAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FHotfix As New FormHotfix
        AddHandler FHotfix.FormClosed, AddressOf ChildFormClosedNoRefresh
        FHotfix.ShowDialog()

    End Sub
    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FUpdate As New FormUpdate
        AddHandler FUpdate.FormClosed, AddressOf ChildFormClosedNoRefresh
        FUpdate.ShowDialog()

    End Sub
    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FChangelog As New FormChangelog
        AddHandler FChangelog.FormClosed, AddressOf ChildFormClosedNoRefresh
        FChangelog.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FAbout As New FormAbout
        AddHandler FAbout.FormClosed, AddressOf ChildFormClosedNoRefresh
        FAbout.ShowDialog()

    End Sub

    Private Sub AcknowledgementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcknowledgementsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAckn
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub DonatoToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolstripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormDonate
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

#End Region
#Region "Context Menu (Application)"

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ResetPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPositionToolStripMenuItem.Click
        CenterToScreen()
    End Sub

    Private Sub ResetApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartApplicationToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItemExplorer_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click

        Fade.FadeBehindChild(Me)

        Dim FAbout As New FormAbout
        AddHandler FAbout.FormClosed, AddressOf ChildFormClosedNoRefresh
        FAbout.ShowDialog()

    End Sub

#End Region

#Region "Routines"
    Friend Shared Function DetermineScaleOf() As String

        Select Case OSHelper.KernelVerInfo.ProductMajorPart
            Case 6
                If OSHelper.KernelVerInfo.ProductMinorPart = 0 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 5.9." : End If 'Vista
                If OSHelper.KernelVerInfo.ProductMinorPart = 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 7.9." : End If '7
                If OSHelper.KernelVerInfo.ProductMinorPart > 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." : End If '8, 8.1
            Case 10
                Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." '10
            Case Else
                Return "The Experience Index assesses key system components."
        End Select

        Return "The Experience Index assesses key system components."

    End Function
    Private Sub EnterPrintMode()
        CmdAssess.Hide()
        If OSHelper.IsWin10 Then
            LabScale.Text = "Xiret v" & Application.ProductVersion & " on " & OSHelper.GetWindowsName() & " v" & OSHelper.GetWindowsReleaseId() & " " _
                & OSHelper.GetWindowsBitness() & " (Branch: " & OSHelper.GetWindowsBuildBranch & ")"
        Else
            LabScale.Text = "Xiret v" & Application.ProductVersion & " on " & OSHelper.GetWindowsName() & " " _
                & OSHelper.GetWindowsBitness() & " (" & OSHelper.GetWindowsBuildLab & ")"
        End If
    End Sub
    Private Sub ExitPrintMode()
        CmdAssess.Show()
        LabScale.Text = DetermineScaleOf()
    End Sub
    Private Sub ChildFormClosedRefreshUI(ByVal sender As Object, ByVal e As EventArgs)
        Fade.RefadeIn(Me)
        WSR5.GetWinsatSPR()
        UpdateControls()
    End Sub
    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)
        Fade.RefadeIn(Me)
    End Sub
    Friend Sub UpdateControls()

        'Check assessment validity
        LabEIState.Text = State.ConvertAssessmentState(WinsatApi.GetAssessmentValidityInt())
        CmdAssess.Text = State.GenerateRunStateText

        If WinsatApi.GetAssessmentValidityInt() = 1 Then : LabBasescore.ForeColor = Settings.ThemeColor : PanValidityState.BackColor = Colors.Valid
        Else : LabBasescore.ForeColor = Colors.BaseScoreUnrated : PanValidityState.BackColor = Colors.Invalid
        End If

        'Check CPU score against Base score
        If Strings.ProcessorScore = Strings.BaseScore Then : LabProcessorScore.BackColor = Colors.PanelActive : LabProcessorScore.ForeColor = Settings.ThemeColor
        Else : LabProcessorScore.BackColor = Colors.PanelNormal : LabProcessorScore.ForeColor = Color.White
        End If

        'Check Memory score against Base score
        If Strings.MemoryScore = Strings.BaseScore Then : LabMemoryScore.BackColor = Colors.PanelActive : LabMemoryScore.ForeColor = Settings.ThemeColor
        Else : LabMemoryScore.BackColor = Colors.PanelNormal : LabMemoryScore.ForeColor = Color.White
        End If

        'Check Graphics Score against Base score
        If Strings.GraphicsScore = Strings.BaseScore Then : LabGraphicsScore.BackColor = Colors.PanelActive : LabGraphicsScore.ForeColor = Settings.ThemeColor
        Else : LabGraphicsScore.BackColor = Colors.PanelNormal : LabGraphicsScore.ForeColor = Color.White
        End If

        'Check Gaming score against Base score
        If Strings.D3DScore = Strings.BaseScore Then : LabGamingScore.BackColor = Colors.PanelActive : LabGamingScore.ForeColor = Settings.ThemeColor
        Else : LabGamingScore.BackColor = Colors.PanelNormal : LabGamingScore.ForeColor = Color.White
        End If

        'Check Disk score against Base score
        If Strings.DiskScore = Strings.BaseScore Then : LabDiskScore.BackColor = Colors.PanelActive : LabDiskScore.ForeColor = Settings.ThemeColor
        Else : LabDiskScore.BackColor = Colors.PanelNormal : LabDiskScore.ForeColor = Color.White
        End If

        'Determine last assessment date
        Strings.AssessDate = Format(WinsatApi.GetWinsatLastUpdateDate(), "dddd, MMM d yyyy hh:mm tt")
        If (Strings.AssessDate.Length = 0) Or Strings.AssessDate.Contains("1999") Then
            LabLastUpdate.Text = "Never"
        Else
            LabLastUpdate.Text = Strings.AssessDate
        End If

        'Hardware switch
        If GswHardware.Checked Then
            LabShowHardware.Text = "On"
        Else
            LabShowHardware.Text = "Off"
        End If

        'Pass score strings to UI
        LabBasescore.Text = Strings.BaseScore
        LabProcessorScore.Text = Strings.ProcessorScore
        LabMemoryScore.Text = Strings.MemoryScore
        LabGraphicsScore.Text = Strings.GraphicsScore
        LabGamingScore.Text = Strings.D3DScore
        LabDiskScore.Text = Strings.DiskScore

        If Strings.BaseScore = "0" Or Strings.BaseScore = Nothing Then
            LabBasescore.Text = "0.0"
        End If

        SetSwitchState()
        LoadHardwareStrings()

    End Sub
    Private Sub SetSwitchState()
        If Not WinsatApi.GetAssessmentValidityInt() = 3 Then
            GswHardware.Enabled = True
        Else
            GswHardware.Checked = False : GswHardware.Enabled = False
        End If
    End Sub

    Public Shared Sub LoadHardwareStrings()
        If Settings.UseApiHardware = 1 Then
            WSR5.ReadAPIHardware()
        Else
            WSR5.ReadXMLHardware()
        End If
    End Sub
    Public Sub SetHW()

        LoadHardwareStrings()

        If GswHardware.Checked Then
            LabWirProcessor.Text = Strings.ProcessorHW.Replace("(R)", "®").Replace("(TM)", "™")
            LabWirMemory.Text = Strings.MemoryHW
            LabWirGraphics.Text = Strings.GraphicsHW.Replace("(R)", "®").Replace("(TM)", "™")
            LabWirGaming.Text = Strings.D3DHW
            LabWirDisk.Text = Strings.DiskHW
        Else
            LabWirProcessor.Text = Strings.ProcessorRO
            LabWirMemory.Text = Strings.MemoryRO
            LabWirGraphics.Text = Strings.GraphicsRO
            LabWirGaming.Text = Strings.D3DRO
            LabWirDisk.Text = Strings.DiskRO
        End If

    End Sub
    Private Sub UpdateToolstripHotfixItem()
        HotfixAvailableToolStripMenuItem.Visible = True
        HotfixAvailableToolStripMenuItem.ForeColor = Color.White
        HotfixAvailableToolStripMenuItem.Text = "Hotfix Available"
        HotfixAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub
    Private Sub UpdateToolstripUpdateItem()
        UpdateAvailableToolStripMenuItem.Visible = True
        UpdateAvailableToolStripMenuItem.ForeColor = Color.White
        UpdateAvailableToolStripMenuItem.Text = "Download Update"
        UpdateAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub

    Friend Sub HotfixWasInstalled()

        HotfixAvailableToolStripMenuItem.Visible = False
        Integers.NotificationCount -= 1
        NotifierMain.DeactivateAll()

        If Not Integers.NotificationCount = 0 Then
            NotifierMain.Controls.Add(CmdHelp, Integers.NotificationCount)
            NotifierMain.Activate()
        End If

    End Sub

#End Region
#Region "Misc design"
    Private Sub GSwitchHardware_MouseEnter(sender As Object, e As EventArgs) 
        LabShowHardware.BackColor = Color.FromArgb(10, 10, 10)
    End Sub
    Private Sub GSwitchHardware_MouseLeave(sender As Object, e As EventArgs) 
        LabShowHardware.BackColor = Color.FromArgb(35, 35, 35)
    End Sub
    Private Sub FormMain_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        LabHead.ForeColor = Color.FromArgb(180, 180, 180)
        CmdSettings.ForeColor = Color.FromArgb(180, 180, 180)
        CmdMinimize.ForeColor = Color.FromArgb(180, 180, 180)
        CmdClose.ForeColor = Color.FromArgb(180, 180, 180)
    End Sub
    Private Sub FormActivate_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
        LabHead.ForeColor = Color.White
        CmdSettings.ForeColor = Color.White
        CmdMinimize.ForeColor = Color.White
        CmdClose.ForeColor = Color.White
    End Sub

    Private Sub PbxHead_Click(sender As Object, e As EventArgs) Handles PbxHead.Click

    End Sub
#End Region

End Class
