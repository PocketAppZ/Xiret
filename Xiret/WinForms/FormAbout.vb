'  Updated on 04.11.2019 - DS (Better link formatting)

Imports Xiret.Core.Helpers

Friend Class FormAbout

    Private BReturns As Boolean = False
    Private ReadOnly SVersion As String = "Build " & Program.X_Build & " · v" & Application.ProductVersion & " · " & Program.X_Channel
    Dim i As Integer = 0

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetAboutThemeAccent()

        PanHead.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)
        Settings.SetWindowIcon(PbxHead)

    End Sub

#End Region

#Region "WndProc"
    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove
        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If
    End Sub
#End Region
#Region "KeyDown Events"
    Private Sub FormAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

#Region "Theme"
    Private Sub SetAboutThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        For Each Ctrl As Control In PanMain.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Load Event Handler"
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        PbxEfa.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgEfa)
        PbxEfa.Hide()
        LabBuild.Text = SVersion
        PbxLogo.Image = CryptoHelper.Base64ToImage(Images.ImgIcon64)

        FormatLnkLink()
        FormatBitmightLink()

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
#Region "Linklabel Event Handlers"

    Private Sub LnkBitmight_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkBitmight.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub
    Private Sub LnkLinks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkLinks.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

#End Region

#Region "Format Links"
    Private Sub FormatBitmightLink()
        LnkBitmight.Links.Clear()
        LnkBitmight.Links.Add(79, 17, "https://www.bitmight.uk")
    End Sub

    Private Sub FormatLnkLink()

        Dim str As String = "Xiret build: " & Program.X_Build
        LnkLinks.Links.Clear()
        LnkLinks.Links.Add(0, 13, "https://forums.mydigitallife.net/threads/xiret-experience-index-returns.68890/")
        LnkLinks.Links.Add(16, 10, "mailto:support@bitmight.uk?subject=" & "Software enquiry or bug report&body=" & vbCrLf & str)
        LnkLinks.Links.Add(29, 11, "https://github.com/0x43616c")

    End Sub

#End Region

#Region "Neko no Ongaeshi"

    Private Sub PbxLogo_Click(sender As Object, e As EventArgs) Handles PbxLogo.Click
        If BReturns Then
            BReturns = False
            CType(sender, PictureBox).Image = CryptoHelper.Base64ToImage(Images.ImgIcon64)
            LabAppName.Text = "Scratch, scratch!"
            PbxEfa.Hide()
        Else
            BReturns = True
            CType(sender, PictureBox).Image = CryptoHelper.Base64ToImage(Images.ImgGifCat)
            LabAppName.Text = "Purrrrrrrrrrr!"
            PbxEfa.Show()
        End If
    End Sub

    Private Sub PbxLogo_MouseEnter(sender As Object, e As EventArgs) Handles PbxLogo.MouseEnter
        If BReturns Then
            LabAppName.Text = "Purrrrrrrrrrr!"
        Else
            LabAppName.Text = "Scratch, scratch!"
        End If
    End Sub

    Private Sub PbxLogo_MouseLeave(sender As Object, e As EventArgs) Handles PbxLogo.MouseLeave
        LabAppName.Text = "Xiret❷"
    End Sub

    Private Sub PbxEfa_Click(sender As Object, e As EventArgs) Handles PbxEfa.Click
        Process.Start("https://forums.mydigitallife.net/threads/a-beloved-member-efa11-has-unexpectedly-And-suddenly-passed-away.71726/")
    End Sub

    Private Sub LabHead_Click(sender As Object, e As EventArgs) Handles LabHead.Click, LabHead.DoubleClick

        If Not i = 50 Then
            i += 1
            Select Case i
                Case = 5
                    MessageBox.Show("You must be bored.", "Xiret", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 10
                    MessageBox.Show("Like really bored.", "Xiret", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 20
                    MessageBox.Show("Your poking is really hurting my head.", "Xiret", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 30
                    MessageBox.Show("There is a whole world out there...", "Xiret", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 40
                    MessageBox.Show("Are my messages not getting through, anyone there?", "Xiret", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Select
        Else
            If i >= 50 Then
                MessageBox.Show("I got nothing else. Go outside.", "Xiret", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Environment.Exit(666)
            End If
        End If
    End Sub

#End Region

End Class