'Created by David S on 28.02.2021

Imports Xiret.Core.Helpers
Imports Xiret.Gambol.Controls

Public Class FormDonate

#Region "Fields"

    Const BTC As String = "bc1q9jlremwmd036df08hu9davclxqk43vwqk08ul7"
    Const ETH As String = "0x4fa1a5f22A3203a7f80f113b70C68ACdBa4f5Df3"
    Const XRP As String = "rNv4yLbEh9dWExa6VtwygnszA44fcUAh4f"
    Const PP As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CUZ2TP495UZZS"
    Friend Link As String = String.Empty

#End Region

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetDonateThemeAccent()

        PanHead.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)
        Settings.SetWindowIcon(PbxHead)

        PbxQr.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgBTC)
        LabAddress.Text = BTC
        Link = BTC

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
    Private Sub SetDonateThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpRads.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

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
#Region "Label Event Handler"

    Private Sub LabCopy_Click(sender As Object, e As EventArgs) Handles LabCopy.Click
        My.Computer.Clipboard.SetText(Link)
        ToastAlert.Show("Address copied to clipboard.", ToastType.Information)
    End Sub

#End Region

#Region "Radiobutton Event Handlers"

    Private Sub RadBtc_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtc.CheckedChanged
        PbxQr.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgBTC)
        LabPlatform.Text = "Bitcoin address:"
        LabAddress.Text = BTC
        Link = BTC
    End Sub

    Private Sub RadEth_CheckedChanged(sender As Object, e As EventArgs) Handles RadEth.CheckedChanged
        PbxQr.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgETH)
        LabPlatform.Text = "Ether address:"
        LabAddress.Text = ETH
        Link = ETH
    End Sub

    Private Sub RadXrp_CheckedChanged(sender As Object, e As EventArgs) Handles RadXrp.CheckedChanged
        PbxQr.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgXRP)
        LabPlatform.Text = "Ripple address:"
        LabAddress.Text = XRP
        Link = XRP
    End Sub

    Private Sub RadPaypal_CheckedChanged(sender As Object, e As EventArgs) Handles RadPaypal.CheckedChanged
        PbxQr.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgPay)
        LabPlatform.Text = "PayPal donation link:"
        LabAddress.Text = PP
        Link = PP
    End Sub

#End Region

End Class