'  Updated on 27.03.2020 - DS (Update to new code)
'  Updated on 07.03.2021 - DS (Cleanup)

Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Imports Xiret.Gambol.Controls.Design

Namespace Gambol.Controls
    <Designer(GetType(GambolRadioButtonDesigner))>
    Public Class GambolRadioButton
        Inherits RadioButton

#Region "Fields"
        Private MouseHovered As Boolean = False
        Private MousePressed As Boolean = False
#End Region

#Region "Constructor"
        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
            AddHandler MouseEnter, New EventHandler(AddressOf ProcessMouse)
            AddHandler MouseLeave, New EventHandler(AddressOf ProcessMouse)
            BackColor = Color.Transparent
            ForeColor = Colors.EnabledText
        End Sub
#End Region

#Region "Properties"
        Private BorderInactive_ As Color = Colors.BorderInactive

        <Description("Check area border color")>
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

        <Description("Check area mouseover border color")>
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

        Private ClientInactive_ As Color = Colors.ClientInactive

        <Description("Check area backcolor")>
        <Category("Appearance (Gambol)")>
        Public Property ClientColor As Color
            Get
                Return ClientInactive_
            End Get
            Set(Clr As Color)
                ClientInactive_ = Clr
                Invalidate()
            End Set
        End Property

        Private ClientActive_ As Color = Colors.ClientActive

        <Description("Check area mouseover color")>
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

        Private Checked_ As Color = Colors.Checked

        <Description("Control checked color")>
        <Category("Appearance (Gambol)")>
        Public Property CheckedColor As Color
            Get
                Return Checked_
            End Get
            Set(Clr As Color)
                Checked_ = Clr
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

                MyBase.OnPaintBackground(e)

            End If

        End Sub

        Protected Overridable Sub OnPaintForegound(ByVal e As PaintEventArgs)

            Dim Diameter As Integer = ClientRectangle.Height - 1
            Dim OuterRectangle As RectangleF = New RectangleF(0, 0, Diameter, Diameter)
            Dim InnerRectangle As RectangleF = New RectangleF(1, 1, Diameter - 2, Diameter - 2)
            Dim SwitchBorder, SwitchBack As Color

            If e IsNot Nothing Then

                Dim g As Graphics = e.Graphics

                g.InterpolationMode = InterpolationMode.HighQualityBicubic
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.CompositingQuality = CompositingQuality.HighQuality
                OuterRectangle.Inflate(-1, -1)

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

                Using P As Pen = New Pen(SwitchBorder, width:=2)
                    g.DrawArc(P, OuterRectangle, 135, 180)
                    g.DrawArc(P, OuterRectangle, -45, 180)
                End Using

                InnerRectangle.Inflate(-1, -1)

                If MouseHovered Then
                    SwitchBack = ClientColorActive
                Else
                    SwitchBack = ClientColor
                End If

                Using SB As SolidBrush = New SolidBrush(SwitchBack)
                    g.FillEllipse(SB, InnerRectangle)
                End Using

                If Checked Then
                    InnerRectangle = New RectangleF(1, 1, Diameter - 2, Diameter - 2)
                    InnerRectangle.Inflate(-5, -5)
                    Using SB As SolidBrush = New SolidBrush(CheckedColor)
                        g.FillEllipse(SB, InnerRectangle)
                    End Using
                End If

                g.InterpolationMode = InterpolationMode.Default
                g.SmoothingMode = SmoothingMode.None
                g.CompositingQuality = CompositingQuality.Default

                Dim TextArea As Rectangle = New Rectangle(CInt(OuterRectangle.Width) + 5, 0, Width - CInt(OuterRectangle.Width) - 6, Height)
                Dim BC As Color = If(Enabled, ForeColor, Colors.DisabledText)

                Using SF As StringFormat = New StringFormat() With {
                    .LineAlignment = StringAlignment.Center
                }
                    Using SB As SolidBrush = New SolidBrush(BC)
                        g.DrawRectangle(Pens.Transparent, TextArea)
                        g.DrawString(Text, Font, SB, TextArea, SF)
                    End Using
                End Using

            End If

        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            OnPaintBackground(e)
            OnPaintForegound(e)
        End Sub

#End Region

#Region "Overriden Methods"
        Protected Overrides Sub OnCheckedChanged(ByVal e As EventArgs)
            MyBase.OnCheckedChanged(e)
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal eventargs As EventArgs)
            MyBase.OnMouseLeave(eventargs)
            MouseHovered = False
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal eventargs As EventArgs)
            MyBase.OnMouseEnter(eventargs)
            MouseHovered = True
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            GetPreferredSizeN()
            Invalidate()
        End Sub

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

        Private Function GetPreferredSizeN() As Size
            Return GetPreferredSize(New Size(0, 0))
        End Function
#End Region

    End Class

End Namespace
