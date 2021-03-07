'  Updated on 07.08.2019 - DS (Increment PxFromEdge 6 > 10, cleanup)
'  Updated on 13.08.2019 - DS (Disabled BlurWinForm whilst some issues are corrected)

Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers

Public Class FormToast
    Implements IMessageFilter

    Private ReadOnly ColorInfo As Color = Colors.NotifyInfo
    Private ReadOnly ColorWarning As Color = Colors.NotifyWarn
    Private ReadOnly ColorError As Color = Colors.NotifyError

    Private MouseInForm As Boolean = False
    Private Int As Integer = 0

    Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        PanMain.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgTile)

    End Sub

#Region "Overriden Properties"

    Protected Overloads Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property

#End Region

#Region "PreMessageFilter"

    Private Function PreFilterMessage(ByRef ID As Message) As Boolean _
        Implements IMessageFilter.PreFilterMessage

        If ID.Msg = Integers.WM_MOUSELEAVE OrElse ID.Msg = Integers.WM_MOUSEMOVE Then
            Dim OnClient As Boolean = ClientRectangle.Contains(PointToClient(MousePosition))
            If OnClient Then
                If Not MouseInForm Then
                    OnMouseEnter(Nothing)
                End If
                MouseInForm = True
            Else
                If MouseInForm Then
                    OnMouseLeave(Nothing)
                End If
                MouseInForm = False
            End If
        End If

        Return Nothing

    End Function

#End Region

#Region "Button Event Handlers"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub Toast_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Load Handle"

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load

        CmdClose.Location = New Point(PanMain.Right - CmdClose.Width, 0)

        'Set opactity
        Opacity = 0

        'Hide the close button
        CmdClose.Hide()

        'Add mouseover message override
        Application.AddMessageFilter(Me)

        'Set toast type passed
        Select Case ToastAlert.AlertType
            Case ToastType.Critical
                PbxTypeImage.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgError32)
                LabTitle.Text = "Error"
                GProgressBar.ProgressColor = ColorError
                BackColor = ColorError
            Case ToastType.Information
                PbxTypeImage.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgInfo32)
                LabTitle.Text = "Information"
                GProgressBar.ProgressColor = ColorInfo
                BackColor = ColorInfo
            Case ToastType.Warning
                PbxTypeImage.BackgroundImage = CryptoHelper.Base64ToImage(Images.ImgWarn32)
                LabTitle.Text = "Warning"
                GProgressBar.ProgressColor = ColorWarning
                BackColor = ColorWarning
        End Select

        LabMessage.Text = ToastAlert.AlertMessage
        TopMost = True

        RespectTaskbar()

        TopMost = True
        BringToFront()

    End Sub

#End Region
#Region "Closed Handle"

    Private Sub Toast_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'Remove PreMessageFilter
        Application.RemoveMessageFilter(Me)

        If Not ToastAlert.BoolCancelCurrentToast Then
            Fade.FadeOut(Me)
        End If


    End Sub

#End Region

#Region "RespectTaskbar"

    Private Sub RespectTaskbar()

        Dim PxFromEdge As Integer = 10
        Dim Width As Integer = MyBase.Width
        Dim Height As Integer = MyBase.Height
        Dim Monitor As Screen = Screen.PrimaryScreen

        Select Case Taskbar.GetLocation()
            Case TaskBarLocation.Bottom
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.WorkingArea.Height - Height - PxFromEdge)
            Case TaskBarLocation.Left
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.Bounds.Height - Height - PxFromEdge)
            Case TaskBarLocation.Top
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.Bounds.Height - Height - PxFromEdge)
            Case TaskBarLocation.Right
                Location = New Point(Monitor.WorkingArea.Width - Width - PxFromEdge, Monitor.Bounds.Height - Height - PxFromEdge)
            Case Else
                'Assume standard position?
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.WorkingArea.Height - Height - PxFromEdge)
        End Select

    End Sub

#End Region

#Region "Timer"

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles TimerTick.Tick

        If Int = 20000 Then
            Close()
            Exit Sub
        Else
            Int += 40
            GProgressBar.Value = CInt(Int / 100)
        End If

    End Sub

    Private Sub Toast_MouseDetect(sender As Object, e As EventArgs) Handles Me.MouseEnter, Me.MouseLeave

        If TimerTick.Enabled = True Then
            TimerTick.Stop()
            GProgressBar.Hide()
            CmdClose.Show()
        Else
            TimerTick.Start()
            GProgressBar.Show()
            CmdClose.Hide()
        End If

    End Sub

#End Region

End Class