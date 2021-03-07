'  Updated on 22.10.2019 - DS (Update imports)

Namespace Gambol.UI

    Public Class GambolToolstripRenderer
        Inherits ToolStripProfessionalRenderer

        Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)

            Dim r As New Rectangle(Point.Empty, e.Item.Size)
            Dim c As Color = CType(IIf(e.Item.Selected, Color.FromArgb(45, 50, 55), Color.FromArgb(20, 20, 20)), Color)
            Using b As New SolidBrush(c)
                If e.Item.Selected Then
                    e.Graphics.FillRectangle(b, r)
                End If
            End Using

        End Sub
        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)

            If e.Vertical OrElse TryCast(e.Item, ToolStripSeparator) Is Nothing Then
                MyBase.OnRenderSeparator(e)
            Else
                Dim sep As Rectangle = New Rectangle(Point.Empty, e.Item.Size)
                Using b As New SolidBrush(Color.FromArgb(20, 20, 20))
                    e.Graphics.FillRectangle(b, sep)
                End Using
                Dim y As Integer = CInt(sep.Bottom - (sep.Height / 2) - 1)
                Dim l As Integer = sep.Left + 5
                Dim r As Integer = sep.Right - 5
                Using b As New SolidBrush(Color.FromArgb(140, 45, 50, 55))
                    e.Graphics.DrawLine(New Pen(b), l, y, r, y)
                End Using
            End If
        End Sub

    End Class

End Namespace


