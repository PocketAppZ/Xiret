'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'  Updated on 20.01.2020 - DS (Add StringReader, clean imports)

Imports System.IO

Imports Xiret.Core.Helpers

Public Class FormChangelog

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetChangelogThemeAccent()

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
    Private Sub FormChangelog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormChangelog_Load(sender As Object, e As EventArgs) Handles Me.Load

        Using Reader As New StringReader(My.Resources.changelog)
            RtbChanges.Rtf = Reader.ReadToEnd
        End Using

        RtbChanges.Select()

    End Sub

#End Region

#Region "Theme"
    Private Sub SetChangelogThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor
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

End Class