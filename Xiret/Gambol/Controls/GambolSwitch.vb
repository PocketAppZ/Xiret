'  Updated on 07.03.2021 - DS (Cleanup)

Imports Xiret.Gambol.Controls.Design
Imports System.ComponentModel

Namespace Gambol.Controls
    <Designer(GetType(GambolSwitchDesigner))>
    Public Class GambolSwitch
        Inherits CheckBox

#Region "Fields"
        Private MouseHovered As Boolean = False
        Private MousePressed As Boolean = False
#End Region

#Region "Constructor"
        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            AddHandler MouseEnter, New EventHandler(AddressOf ProcessMouse)
            AddHandler MouseLeave, New EventHandler(AddressOf ProcessMouse)
            BackColor = Color.Black
        End Sub
#End Region

#Region "Properties"
        Private BorderInactive_ As Color = Colors.BorderInactive

        <Description("Set the control border color.")>
        <Category("Appearance (Gambol)")>
        Public Property BorderColor As Color
            Get
                Return BorderInactive_
            End Get
            Set(Clr As Color)
                BorderInactive_ = Clr
                Invalidate()
            End Set
        End Property

        Private BorderActive_ As Color = Colors.BorderActive

        <Description("Set the control mouseover border color.")>
        <Category("Appearance (Gambol)")>
        Public Property BorderColorActive As Color
            Get
                Return BorderActive_
            End Get
            Set(Clr As Color)
                BorderActive_ = Clr
                Invalidate()
            End Set
        End Property

        Private HeadColor_ As Color = Colors.SwitchHead

        <Description("Set the switch head color")>
        <Category("Appearance (Gambol)")>
        Public Property SwitchHeadColor As Color
            Get
                Return HeadColor_
            End Get
            Set(Clr As Color)
                HeadColor_ = Clr
                Invalidate()
            End Set
        End Property

        Private CheckedColor_ As Color = Colors.Checked

        <Description("Set the control toggle on color.")>
        <Category("Appearance (Gambol)")>
        Public Property CheckedColor As Color
            Get
                Return CheckedColor_
            End Get
            Set(Clr As Color)
                CheckedColor_ = Clr
                Invalidate()
            End Set
        End Property

        Private ClientActive_ As Color = Colors.ClientActive

        <Description("Sets the mouseover background color when the switch is set to off.")>
        <Category("Appearance (Gambol)")>
        Public Property ClientColorActive As Color
            Get
                Return ClientActive_
            End Get
            Set(Clr As Color)
                ClientActive_ = Clr
                Invalidate()
            End Set
        End Property
#End Region

#Region "Paint Methods"
        Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)

            If e IsNot Nothing Then
                Dim g As Graphics = e.Graphics
                If BackColor.A = 255 Then
                    g.Clear(BackColor)
                    Return
                End If
            End If

            MyBase.OnPaintBackground(e)

        End Sub

        Protected Overridable Sub OnPaintForeground(ByVal e As PaintEventArgs)

            Dim SwitchBorder, SwitchClient As Color

            If e IsNot Nothing Then

                Dim g As Graphics = e.Graphics

                If Enabled Then
                    If MouseHovered AndAlso MousePressed Then
                        SwitchBorder = Color.FromArgb(Colors.A, CheckedColor.R, CheckedColor.G, CheckedColor.B)
                    ElseIf MouseHovered Then
                        SwitchBorder = BorderColorActive
                    Else
                        SwitchBorder = BorderColor
                    End If
                Else
                    SwitchBorder = Colors.DisabledControl
                End If

                Using P As Pen = New Pen(SwitchBorder) With {
                    .Width = 2.0F
                }
                    Dim Int As Integer = Width - 2
                    Dim Rect As Rectangle = New Rectangle(1, 1, Int, ClientRectangle.Height - 2)
                    g.DrawRectangle(P, Rect)
                End Using

                If MouseHovered Then
                    SwitchClient = If(Checked, CheckedColor, ClientColorActive)
                Else
                    SwitchClient = If(Checked, CheckedColor, BackColor)
                End If

                Using SB As SolidBrush = New SolidBrush(SwitchClient)
                    Dim InnerRect As Rectangle = New Rectangle(2, 2, Width - 4, Height - 4)
                    InnerRect.Inflate(-3, -3)
                    g.FillRectangle(SB, InnerRect)
                End Using

                Using P As Pen = New Pen(BackColor)
                    Dim Int As Integer = CInt(If(Checked, Width - Width / 3 - 1, 0))
                    Dim Rect As Rectangle = New Rectangle(Int, 0, CInt(Width / 3), Height)
                    g.DrawRectangle(P, Rect)
                End Using

                Using SB As SolidBrush = New SolidBrush(If(Enabled, SwitchHeadColor, Colors.SwitchHeadDisabled))
                    Dim Int As Integer = CInt(If(Checked, Width - (Width / 3), 0))
                    Dim Rect As Rectangle = New Rectangle(Int, 0, CInt(Width / 3), Height)
                    g.FillRectangle(SB, Rect)
                End Using

            End If

        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            OnPaintBackground(e)
            OnPaintForeground(e)
        End Sub
#End Region

#Region "Overriden Methods"
        Protected Overrides Sub OnCheckedChanged(ByVal e As EventArgs)
            MyBase.OnCheckedChanged(e)
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            MouseHovered = False
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            MouseHovered = True
        End Sub

        Public Overrides Function GetPreferredSize(ByVal proposedSize As Size) As Size
            proposedSize.Width = 36
            proposedSize.Height = 20
            Return proposedSize
        End Function

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)

            If e IsNot Nothing Then
                If e.Button = MouseButtons.Left Then
                    MousePressed = True
                    Invalidate()
                End If
            End If

            MyBase.OnMouseDown(e)

        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MousePressed = False
            Invalidate()
            MyBase.OnMouseUp(e)
        End Sub
#End Region

#Region "Custom"
        Private Sub ProcessMouse(ByVal sender As Object, ByVal e As EventArgs)

            If ClientRectangle.Contains(PointToClient(MousePosition)) Then
                If Not MouseHovered Then
                    MouseHovered = True
                    Invalidate()
                Else
                    MouseHovered = False
                    Invalidate()
                End If
            End If

        End Sub
#End Region

    End Class
End Namespace
