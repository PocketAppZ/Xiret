'  Updated on 20.09.2019 - DS (Add username, add install date, add tick to uptime and remove refresh button)
'  Updated on 26.09.2019 - DS (Improve threading, edit keydown)

Imports System.Threading

Imports Xiret.Core.Helpers

Public Class FormSystem

    Private ReadOnly StringOther As String = OSHelper.GetWindowsName() & " v" & OSHelper.GetWindowsCurrentBuild()
    Private ReadOnly StringTen As String = OSHelper.GetWindowsName() & " v" & OSHelper.GetWindowsReleaseId() & " (Build: " & OSHelper.GetWindowsBuildBranch() & ")"

    Private Delegate Sub InvokeUptime(Data As String)
    Private ThrTick As Thread
    Private BContinue As Boolean = True

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
    Private Sub FormSystem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            StopLoop()
            Close()
        Else
            If e.Alt And e.KeyCode = Keys.F4 Then
                StopLoop()
            End If
        End If
    End Sub

#End Region
#Region "Frame Buttons"
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        StopLoop()
        Close()
    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormSystem_Load(sender As Object, e As EventArgs) Handles Me.Load

        LabUsername.Text = OSHelper.GetUsername
        LabOpSystem.Text = CType(IIf(OSHelper.IsWin10, StringTen, StringOther), String)
        LabBitness.Text = OSHelper.GetWindowsBitness()
        LabServPack.Text = OSHelper.GetWindowsServicePack()

        LabKernel.Text = OSHelper.KernelVerInfo.ProductVersion
        LabWinsat.Text = OSHelper.WinsatVerInfo.ProductVersion
        LabApi.Text = OSHelper.WinsatApiVerInfo.ProductVersion

        LabInstDat.Text = OSHelper.GetWindowsInstallDate
        ThrTick = New Thread(AddressOf TickUptime) With {
            .IsBackground = True
        }
        ThrTick.Start()

    End Sub

#End Region

#Region "Theme"
    Private Sub SetCleanupThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor
        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Picturebox Event Handler"

    Private Sub PbxMain_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "Thread"

    Private Sub TickUptime()

        Do While BContinue
            If InvokeRequired Then
                Invoke(New InvokeUptime(AddressOf InvokeTickUptime), OSHelper.GetWindowsUptime)
            Else
                LabUptime.Text = OSHelper.GetWindowsUptime
            End If
            Thread.Sleep(500)
        Loop

    End Sub
    Private Sub InvokeTickUptime(Data As String)
        LabUptime.Text = Data
    End Sub
    Private Sub StopLoop()
        BContinue = False
    End Sub
#End Region

End Class