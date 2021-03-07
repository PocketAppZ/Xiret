'  Updated on 20.01.2020 - DS (Merged, move log code, reincorporated winsat exit code, improved delegates, new logging methods, enhanced progress reporting, add -v command)

Imports System.Text
Imports System.IO

Imports Xiret.Core.Helpers
Imports Xiret.Winsat

Friend Class FormAssess

    'Strings
    Private SStatusMessage As String
    'Integers
    Private IntExitCode As Integer = 0
    Private IntProgress As Integer = 0
    Private IntErrors As Integer = 0
    Private IntWarnings As Integer = 0
    'Bool
    Private BComplete As Boolean = False
    Private BClosing As Boolean = False
    Private BRanWithError As Boolean = False
    Private BRanWithWarning As Boolean = False
    'Procceses
    Private WinsatProcSI As ProcessStartInfo
    Private WinsatProc As Process
    'Timers
    Private WithEvents Watcher As Timers.Timer
    'Labels
    Private ReadOnly LabMinMode As Label

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetAssessThemeAccent()

        If Not Booleans.AssessmentVerbose Then

            'Switch to standard assessment layout
            Size = New Size(520, 275)
            MinimumSize = New Size(520, 275)
            MaximumSize = New Size(520, 275)

            LabMinMode = New Label With {
                .Font = New Font("Segoe UI", 10.0F),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Text = "Your screen may flash or go black during the assessment.",
                .ForeColor = Color.White,
                .Dock = DockStyle.Fill
            }

            LabHead.Text = "Assessment"
            RtbLog.Hide()
            TlpData.Controls.Add(LabMinMode)

        End If

        PanHead.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)
        PbxLoad.Image = CryptoHelper.Base64ToImage(Images.ImgGifLoad24)

    End Sub

#End Region

#Region "WndProc"
    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, LabHead.MouseMove, PbxLoad.MouseMove, TlpHeadImage.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub
#End Region
#Region "Frame Buttons"
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        CmdCancel.PerformClick()
    End Sub
#End Region
#Region "KeyDown Events"
    Private Sub FormAssessVerbose_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            CmdCancel.PerformClick()
        End If
    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormAssessVerbose_Load(sender As Object, e As EventArgs) Handles Me.Load

        GetInitData()

        Watcher = New Timers.Timer(10000)
        AddHandler Watcher.Elapsed, AddressOf WaitForUnexpectedExit
        Watcher.Start()

        Dim Enc As Encoding = CType(IIf(OSHelper.IsWinVista, Encoding.Unicode, Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)), Encoding)

        WinsatProcSI = New ProcessStartInfo("winsat", "formal -v") With {
            .UseShellExecute = False,
            .RedirectStandardError = True,
            .RedirectStandardOutput = True,
            .RedirectStandardInput = True,
            .CreateNoWindow = True,
            .StandardErrorEncoding = Enc,
            .StandardOutputEncoding = Enc}

        WinsatProc = New Process With {.StartInfo = WinsatProcSI, .EnableRaisingEvents = True}

        AddHandler WinsatProc.ErrorDataReceived, AddressOf ASyncronousDataReceived
        AddHandler WinsatProc.OutputDataReceived, AddressOf ASyncronousDataReceived

        WinsatProc.Start()
        WinsatProc.BeginOutputReadLine()
        WinsatProc.BeginErrorReadLine()

    End Sub

#End Region

#Region "Theme"
    Private Sub SetAssessThemeAccent()

        LabProgress.ForeColor = Settings.ThemeColor
        PbrProgress.ProgressColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpButtons.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"
    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles CmdExport.Click

        Dim StringDate As String = Now.ToString("yyyyMMddHHmm")

        Dim Sfd As SaveFileDialog = New SaveFileDialog With {
            .FileName = "SessionLog_" & StringDate,
            .Filter = "Text File (*.txt)|*.txt",
            .InitialDirectory = Directories.DesktopPath,
            .OverwritePrompt = True
        }

        If Sfd.ShowDialog = Windows.Forms.DialogResult.OK And Sfd.FileName.Length > 0 Then
            File.WriteAllLines(Sfd.FileName, RtbLog.Lines)
        End If

        Sfd.Dispose()

    End Sub
    Private Sub CmdViewLog_Click(sender As Object, e As EventArgs) Handles CmdViewLog.Click

        Try
            Process.Start(Settings.AssessmentLogPath)
        Catch ex As Exception
            ToastAlert.Show("The log file is missing or has not been created.", ToastType.Warning)
        End Try

    End Sub
    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click

        If Not BComplete Then
            My.Computer.FileSystem.WriteAllText(Settings.AssessmentLogPath, "Test interruped by user" & vbCrLf, True)
        End If

        BClosing = True

        KillWatcher()
        KillWinsat()

        Close()

    End Sub
#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxLoad_Click(sender As Object, e As EventArgs) Handles PbxLoad.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "AsyncOut"
    Private Sub ASyncronousDataReceived(sender As Object, e As DataReceivedEventArgs)

        If BClosing OrElse (e.Data Is Nothing) Then
            Exit Sub
        Else
            Try
                Invoke(New AsyncDelegate(AddressOf AsyncOut), e.Data)
            Catch
            End Try
        End If

    End Sub
    Private Sub AsyncOut(StringAsync As String)

        If Not StringAsync.Contains("Composition restarted") Then 'Running

            'Write to window
            Logger.Log(StringAsync, LogType.WinsatLog, RtbLog)

            'Flag warning
            If StringAsync.Contains("Warning:") Then
                BRanWithWarning = True
                IntWarnings += 1
            End If

            'Flag error
            If StringAsync.Contains("Error:") Then
                BRanWithError = True
                IntErrors += 1
            End If

            'Update status and window
            If OSHelper.IsWinVista() Then 'Vista
                Invoke(New InvokeLonghorn(AddressOf ProtoLonghorn), StringAsync)
            Else
                Invoke(New InvokeOther(AddressOf ProtoOtherOS), StringAsync)
            End If

            'Update progress values
            Invoke(New ProgressDelegate(AddressOf OnUpdateProgress), IntProgress)

        Else
            If StringAsync.Contains("Composition restarted") Then 'Complete

                'Write to window
                Logger.Log(StringAsync, LogType.WinsatLog, RtbLog)

                'Set progress and completion
                IntProgress = 100
                BComplete = True

                'Stop process water
                KillWatcher()

                'Check warning and error flags
                If Not BRanWithError And Not BRanWithWarning Then
                    Logger.Log("The assessment ran with no warnings or errors", LogType.OkayLog, RtbLog)
                    IntExitCode = 0
                Else
                    If BRanWithError Then
                        Logger.Log("The assessment ran with " & IntErrors & " error(s)", LogType.ErrorLog, RtbLog)
                        IntExitCode = 1
                    End If
                    If BRanWithWarning Then
                        Logger.Log("The assessment ran with " & IntWarnings & " warning(s)", LogType.WarningLog, RtbLog)
                        IntExitCode = 1
                    End If
                End If

                'Exit
                Invoke(New ExitCodeDelegate(AddressOf OnExitCode), IntExitCode)
                Invoke(New ProgressDelegate(AddressOf OnUpdateProgress), IntProgress)

            End If
        End If

    End Sub

#End Region

#Region "Delegate"

    Private Delegate Sub StatusDelegate(StringStatus As String)
    Private Delegate Sub ExitCodeDelegate(IntExitCode As Integer)
    Private Delegate Sub LogDelegate(StringData As String)
    Private Delegate Sub ProgressDelegate(IntValue As Integer)
    Private Delegate Sub AsyncDelegate(StringAsync As String)
    Private Delegate Sub InvokeLonghorn(StringAsync As String)
    Private Delegate Sub InvokeOther(StringAsync As String)

    Private Sub OnExitCode(IntExitCode As Integer)

        If Not BClosing Then

            Select Case IntExitCode
                Case 0
                    SStatusMessage = "Assessment complete."
                Case 1
                    SStatusMessage = "Error: WinSAT did not complete successfully."
                Case 2
                    SStatusMessage = "Error: WinSAT quit unexpecedly."
            End Select

            LabStatus.Text = SStatusMessage
            CmdCancel.Text = "Close"
            CmdExport.Enabled = True
            PbxLoad.Image = CryptoHelper.Base64ToImage(Images.ImgComplete32)
            LabProgress.Text = "" : LabProgress.BackColor = Color.Transparent

            Dim Int As Integer = WSR5.GetExitCode
            If Not WSR5.GetExitCode = -1 Then
                Logger.Log("Exit Code W: " & Int, LogType.XiretLog, RtbLog)
            End If

            Logger.Log("Exit Code X: " & IntExitCode, LogType.XiretLog, RtbLog)
            Logger.Log("Validity Int: " & WinsatApi.GetAssessmentValidityInt(), LogType.XiretLog, RtbLog)
            Logger.Log("Process finished", LogType.InfoLog, RtbLog)
            Logger.Log("(ヘ･_･)ヘ┳━┳", LogType.InfoLog, RtbLog)

            If Not Booleans.AssessmentVerbose Then
                LabMinMode.Text = WSR5.GetExitCodeString(WSR5.GetExitCode)
            End If

        End If

    End Sub

    Private Sub OnUpdateProgress(ByVal IntValue As Integer)

        If Not BClosing Then
            LabProgress.Text = IntValue & "%"
            PbrProgress.Value = IntValue
        End If

    End Sub

#End Region
#Region "Routines"

    Private Sub GetInitData()

        'LOGS FOR DAYS!

        Logger.Log("New Test Started on " & Format(Now, "dddd, MMM d yyyy hh:mm tt"), LogType.InfoLog, RtbLog)
        Logger.Log("(╯°□°）╯︵ ┻━┻", LogType.InfoLog, RtbLog)
        Logger.Log("Xiret v" & Application.ProductVersion & " " & Program.X_Channel & " (" & Program.X_Build & ")", LogType.InfoLog, RtbLog)
        Logger.Log("SystemOS: " & OSHelper.GetWindowsName() & " (Kernel: " & OSHelper.KernelVerInfo.ProductVersion & ")", LogType.InfoLog, RtbLog)
        Logger.Log("Bitness: " & OSHelper.GetWindowsBitness(True), LogType.InfoLog, RtbLog)
        Logger.Log("Culture: " & Culture.GetCultureName, LogType.InfoLog, RtbLog)
        Logger.Log(CType(IIf(Culture.SetCultureStrings(), "INI: Present", "INI: Missing"), String), LogType.InfoLog, RtbLog)

        Logger.Log("Winsat EXE v" & OSHelper.WinsatVerInfo.ProductVersion, LogType.InfoLog, RtbLog)
        Logger.Log("Winsat API v" & OSHelper.WinsatapiVerInfo.ProductVersion, LogType.InfoLog, RtbLog)

        If OSHelper.IsWinVista OrElse OSHelper.IsWin7 OrElse OSHelper.IsWin8 Then
            Logger.Log("Tests: D3D9, D3D10, Processor, Memory, Disk", LogType.InfoLog, RtbLog)
        End If
        If OSHelper.IsWin81 Then
            Logger.Log("Tests: D3D9, Processor, Memory, Disk", LogType.InfoLog, RtbLog)
        End If

        If OSHelper.IsWin10 Then
            Logger.Log("Tests: DWM (DX9), Processor, Memory, Disk", LogType.InfoLog, RtbLog)
        End If

        If Booleans.AssessmentVerbose Then
            Logger.Log("Mode: Verbose", LogType.XiretLog, RtbLog)
        Else
            Logger.Log("Mode: Normal", LogType.XiretLog, RtbLog)
        End If

        Logger.Log("Validity Int: " & WinsatApi.GetAssessmentValidityInt(), LogType.XiretLog, RtbLog)

    End Sub

    Private Sub KillWinsat()
        If WinsatProc IsNot Nothing Then
            If Not WinsatProc.HasExited Then
                Logger.Log("WinSAT wait...", LogType.XiretLog, RtbLog)
                Do Until WinsatProc.HasExited
                    Try
                        WinsatProc.Kill()
                    Catch
                        Logger.Log("An error occured attempting to stop WinSAT...", LogType.ErrorLog, RtbLog)
                    End Try
                Loop
                Logger.Log("WinSAT shutdown complete", LogType.XiretLog, RtbLog)
                Logger.Log("Process finished", LogType.InfoLog, RtbLog)
                Logger.Log("'(ヘ･_･)ヘ┳━┳", LogType.InfoLog, RtbLog)
            End If
        End If
    End Sub

    Private Sub KillWatcher()
        If Watcher.Enabled Then
            Logger.Log("Stopping ProcessWatcher...", LogType.XiretLog, RtbLog)
            Do Until Not Watcher.Enabled
                Try
                    Watcher.Stop()
                Catch
                    Logger.Log("An error occured attempting to stop ProcessWatcher...", LogType.ErrorLog, RtbLog)
                    Exit Sub
                End Try
            Loop
            Logger.Log("ProcessWatcher stopped", LogType.OkayLog, RtbLog)
        End If
    End Sub

    Private Sub WaitForUnexpectedExit(sender As Object, e As EventArgs)
        If BComplete Then
            Exit Sub
        Else
            If Not BComplete And (WinsatProc.HasExited = True) Then
                If Not BClosing Then
                    KillWatcher()
                    IntExitCode = 2
                    Invoke(Sub() Logger.Log("ProcessWatcher: WinSAT was closed or unexpectedly quit", LogType.ErrorLog, RtbLog))
                    Invoke(New ExitCodeDelegate(AddressOf OnExitCode), IntExitCode)
                End If
            End If
        End If
    End Sub

#End Region
#Region "Proto"

    Private Sub ProtoLonghorn(ByVal StringAsync As String) 'WINDOWS VISTA

        'FEATURE
        If StringAsync.Contains("Feature Enumeration") Then
            LabStatus.Text = "Running Feature Enumeration..."
            IntProgress = 8
        End If

        'D3D9
        If StringAsync.Contains("Assessing desktop graphics") Then
            LabStatus.Text = "Running the Direct3D 9 Aero Assessment..."
            IntProgress = 16
        End If
        If StringAsync.Contains("Direct3D9 alpha blend") Then
            LabStatus.Text = "Running the Direct3D 9 Alpha Blend Assessment..."
            IntProgress = 24
        End If
        If StringAsync.Contains("Direct3D9 texture load") Then
            LabStatus.Text = "Running the Direct3D 9 Texture Load Assessment..."
            IntProgress = 32
        End If
        If StringAsync.Contains("Direct3D9 ALU performance") Then
            LabStatus.Text = "Running the Direct3D 9 ALU Assessment..."
            IntProgress = 40
        End If

        'MEDIA
        If StringAsync.Contains("Media Decode/Encode") Then
            LabStatus.Text = "Assessing Windows Media Encoding Performance..."
            IntProgress = 48
        End If
        If StringAsync.Contains("Media Foundation") Then
            LabStatus.Text = "Assessing Windows Media Decoding Performance..."
            IntProgress = 56
        End If

        'CPU
        If StringAsync.Contains("CPU Assessment v1.0.0.0 '-encryption'") Then
            LabStatus.Text = "Assessing CPU Performance [1/4]..."
            IntProgress = 64
        End If
        If StringAsync.Contains("CPU Assessment v1.0.0.0 '-compression'") Then
            LabStatus.Text = "Assessing CPU Performance [2/4]..."
            IntProgress = 72
        End If
        If StringAsync.Contains("CPU Assessment v1.0.0.0 '-encryption2'") Then
            LabStatus.Text = "Assessing CPU Performance [3/4]..."
            IntProgress = 80
        End If
        If StringAsync.Contains("CPU Assessment v1.0.0.0 '-compression2'") Then
            LabStatus.Text = "Assessing CPU Performance [4/4]..."
            IntProgress = 88
        End If

        'MEMORY
        If StringAsync.Contains("System memory performance") Then
            LabStatus.Text = "Assessing Memory Performance..."
            IntProgress = 92
        End If

        'DISK
        If StringAsync.Contains("Storage Assessment") Then
            If StringAsync.Contains("-ran") And StringAsync.Contains("-read") Then
                LabStatus.Text = "Assessing Disk Performance [Ran/Read]..."
            End If
            If StringAsync.Contains("-ran") And StringAsync.Contains("-write") Then
                LabStatus.Text = "Assessing Disk Performance [Ran/Write]..."
            End If
            If StringAsync.Contains("-seq") And StringAsync.Contains("-write") Then
                LabStatus.Text = "Assessing Disk Performance [Seq/Write]..."
            End If
            If StringAsync.Contains("-seq") And StringAsync.Contains("-read") Then
                LabStatus.Text = "Assessing Disk Performance [Seq/Read]..."
            End If
            IntProgress = 95
        End If

    End Sub
    Private Sub ProtoOtherOS(ByVal StringAsync As String) 'WINDOWS 7+

        'FEATURE
        If StringAsync.Contains("formal -v") Then
            LabStatus.Text = "Gathering System Information..."
            IntProgress = 3
        End If

        'D3D9
        If StringAsync.Contains("'-aname DWM") Then
            LabStatus.Text = "Running the Direct3D 9 Aero Assessment..."
            IntProgress = 6
        End If

        'D3D9
        If Not OSHelper.IsWin10 Then 'Not assessed on Windows 10
            If StringAsync.Contains("'-aname Batch") Then
                LabStatus.Text = "Running the Direct3D 9 Batch Assessment..."
                IntProgress = 9
            End If
            If StringAsync.Contains("'-aname Alpha") Then
                LabStatus.Text = "Running the Direct3D 9 Alpha Blend Assessment..."
                IntProgress = 12
            End If
            If StringAsync.Contains("'-aname Tex") Then
                LabStatus.Text = "Running the Direct3D 9 Texture Load Assessment..."
                IntProgress = 15
            End If
            If StringAsync.Contains("'-aname ALU") Then
                LabStatus.Text = "Running the Direct3D 9 ALU Assessment..."
                IntProgress = 18
            End If
        End If

        'D3D10
        If Not OSHelper.IsWin81 OrElse Not OSHelper.IsWin10 Then 'Not assessed on Windows 10
            If StringAsync.Contains("'-dx10  -aname Batch") Then
                LabStatus.Text = "Running the Direct3D 10 Batch Assessment..."
                IntProgress = 21
            End If
            If StringAsync.Contains("'-dx10  -aname Alpha") Then
                LabStatus.Text = "Running the Direct3D 10 Alpha Blend Assessment..."
                IntProgress = 24
            End If
            If StringAsync.Contains("'-dx10  -aname Tex") Then
                LabStatus.Text = "Running the Direct3D 10 Texture Load Assessment..."
                IntProgress = 27
            End If
            If StringAsync.Contains("'-dx10  -aname ALU") Then
                LabStatus.Text = "Running the Direct3D 10 ALU Assessment..."
                IntProgress = 30
            End If
            If StringAsync.Contains("'-dx10  -aname Geom") Then
                LabStatus.Text = "Running the Direct3D 10 Geometry Assessment..."
                IntProgress = 33
            End If
            If StringAsync.Contains("'-dx10  -aname CBuffer") Then
                LabStatus.Text = "Running the Direct3D 10 Constant Buffer Assessment..."
                IntProgress = 36
            End If
        End If

        'MEDIA
        If Not OSHelper.IsWin10 Then
            If StringAsync.Contains(Culture.MediaFoundationStr) Then
                LabStatus.Text = "Assessing Windows Media Decoding Performance..."
                IntProgress = 39
            End If
            If StringAsync.Contains(Culture.ExtendedMediaStr) Then
                LabStatus.Text = "Tuning Windows Media Decoding..."
                IntProgress = 42
            End If
            If StringAsync.Contains(Culture.MediaEncodeStr) Then
                LabStatus.Text = "Assessing Windows Media Encoding Performance..."
                IntProgress = 45
            End If
        End If

        'CPU
        If StringAsync.Contains("'-encryption -up'") Then
            LabStatus.Text = "Assessing CPU Performance [1/8]..."
            IntProgress = 50
        End If
        If StringAsync.Contains("'-compression -up'") Then
            LabStatus.Text = "Assessing CPU Performance [2/8]..."
            IntProgress = 55
        End If
        If StringAsync.Contains("'-encryption2 -up'") Then
            LabStatus.Text = "Assessing CPU Performance [3/8]..."
            IntProgress = 60
        End If
        If StringAsync.Contains("'-compression2 -up'") Then
            LabStatus.Text = "Assessing CPU Performance [4/8]..."
            IntProgress = 65
        End If
        If StringAsync.Contains("'-encryption'") Then
            LabStatus.Text = "Assessing CPU Performance [5/8]..."
            IntProgress = 70
        End If
        If StringAsync.Contains("'-compression'") Then
            LabStatus.Text = "Assessing CPU Performance [6/8]..."
            IntProgress = 75
        End If
        If StringAsync.Contains("'-encryption2'") Then
            LabStatus.Text = "Assessing CPU Performance [7/8]..."
            IntProgress = 80
        End If
        If StringAsync.Contains("'-compression2'") Then
            LabStatus.Text = "Assessing CPU Performance [8/8]..."
            IntProgress = 85
        End If

        'MEMORY
        If StringAsync.Contains(Culture.MemoryStr) Then
            LabStatus.Text = "Assessing Memory Performance [1/1]..."
            IntProgress = 90
        End If

        'DISK
        If StringAsync.Contains(Culture.StorageStr) Then
            If StringAsync.Contains("-ran") And StringAsync.Contains("-read") Then
                LabStatus.Text = "Assessing Disk Performance [Ran/Read]..."
            End If
            If StringAsync.Contains("-ran") And StringAsync.Contains("-write") Then
                LabStatus.Text = "Assessing Disk Performance [Ran/Write]..."
            End If
            If StringAsync.Contains("-seq") And StringAsync.Contains("-write") Then
                LabStatus.Text = "Assessing Disk Performance [Seq/Write]..."
            End If
            If StringAsync.Contains("-seq") And StringAsync.Contains("-read") Then
                LabStatus.Text = "Assessing Disk Performance [Seq/Read]..."
            End If
            If StringAsync.Contains("-scen") Then
                LabStatus.Text = "Assessing Disk Performance [Scen]..."
            End If
            IntProgress = 95
        End If

    End Sub

#End Region

#Region "Misc Designer"

    Private Sub FormAssess_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        'Force progressbar redraw on Win+Up
        PbrProgress.Invalidate()
    End Sub

#End Region

End Class