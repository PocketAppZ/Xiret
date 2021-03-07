'  Updated on 07.03.2021 - DS (Cleanup)

Imports System.ComponentModel

Namespace Gambol.Controls

    <ToolboxBitmap(GetType(ProgressBar))>
    Public Class GambolProgressBar
        Inherits Control

        Sub New()
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
        End Sub

#Region "Properties"

        Private BoolTransparent As Boolean = False
        <Description("Gets or sets the 'real' transparency of the control.")>
        Public Property IsTransparent() As Boolean
            Get
                Return BoolTransparent
            End Get
            Set(Clr As Boolean)
                BoolTransparent = Clr
                If Clr = True Then
                    BackColor = Color.Transparent
                End If
                Invalidate()
            End Set
        End Property

        Private PBorderColor As Color = Color.FromArgb(180, 180, 180)
        <Description("Set the progressbar border color. Ignored when ShowBorder value is 'False'."),
        Category("Gambol Appearance")>
        Property BorderColor As Color
            Get
                Return PBorderColor
            End Get
            Set(Clr As Color)
                PBorderColor = Clr
                Invalidate()
            End Set
        End Property

        Private PProgressColor As Color = Color.FromArgb(120, 180, 0)
        <Description("Set the progressbar progress color"),
        Category("Gambol Appearance")>
        Property ProgressColor As Color
            Get
                Return PProgressColor
            End Get
            Set(Clr As Color)
                PProgressColor = Clr
                Invalidate()
            End Set
        End Property

        Private PShowBorder As Boolean = True
        <Description("Determine if the control has an outer border."),
        Category("Gambol Appearance")>
        Property ShowBorder As Boolean
            Get
                Return PShowBorder
            End Get
            Set(Clr As Boolean)
                PShowBorder = Clr
                Invalidate()
            End Set
        End Property

        Dim PValue As Integer = 0
        <Description("Set the current value for the progressbar."),
        Category("Gambol Behavior")>
        Property Value As Integer
            Get
                Return PValue
            End Get
            Set(Int As Integer)
                If Int <= PMaximum Then PValue = Int Else Throw New Exception("Invalid value entered")
                Invalidate()
            End Set
        End Property

        Dim PMaximum As Integer = 100
        <Description("Set the upper bound maximum range for the progressbar."),
        Category("Gambol Behavior")>
        Property Maximum As Integer
            Get
                Return PMaximum
            End Get
            Set(Int As Integer)
                If Int >= PValue Then PMaximum = Int Else Throw New Exception("Invalid value entered")
                Invalidate()
            End Set
        End Property

#End Region

#Region "Paint methods"

        Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)

            If e IsNot Nothing Then

                Dim G As Graphics = e.Graphics

                If BackColor.A = 255 Then
                    G.Clear(BackColor)
                    Return
                End If
            End If

            MyBase.OnPaintBackground(e)

        End Sub

        Protected Overridable Sub OnPaintForeground(e As PaintEventArgs)

            Dim G As Graphics = e.Graphics
            Dim IntDouble As Double

            If ShowBorder Then
                IntDouble = PValue / PMaximum * (Width - 2)
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, BackColor)), New Rectangle(0, 0, Width - 1, Height - 1))
                If IntDouble > 0 Then G.FillRectangle(New SolidBrush(ProgressColor), New Rectangle(1, 1, CInt(IntDouble), Height - 2))
                G.DrawRectangle(New Pen(BorderColor), New Rectangle(0, 0, Width - 1, Height - 1))
            Else
                IntDouble = PValue / PMaximum * (Width)
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, BackColor)), New Rectangle(0, 0, Width, Height))
                If IntDouble > 0 Then G.FillRectangle(New SolidBrush(ProgressColor), New Rectangle(0, 0, CInt(IntDouble), Height))
            End If

        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            OnPaintBackground(e)
            OnPaintForeground(e)
        End Sub

#End Region

    End Class

End Namespace



