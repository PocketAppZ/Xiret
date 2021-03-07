Imports System.ComponentModel
Imports System.Linq

Namespace Gambol.Controls

    'USAGE:
    ' Notifier1.Controls.Add(Control, Int) eg. Notifier1.Controls.Add(Button1, 4)
    ' Notifier1.Activate()

    Partial Public Class Notifier
        Inherits Component
        Public ReadOnly Property Controls As Dictionary(Of Control, Integer)
        Public Sub New(ICont As IContainer)
            ICont.Add(Me)
            Controls = New Dictionary(Of Control, Integer)()
        End Sub
        Public Sub Activate()
            For Each Ctrl As Control In Controls.Keys
                AddHandler Ctrl.Paint, AddressOf DrawNotification
                Ctrl.Invalidate()
            Next
        End Sub
        Public Sub DeactivateControl(Control As Control)
            Controls.Remove(Control)
            Control.Invalidate()
        End Sub
        Public Sub DeactivateAll()
            For Each Ctrl As Control In Controls.Keys.ToList()
                Controls.Remove(Ctrl)
                Ctrl.Invalidate()
            Next
        End Sub

        Private Sub DrawNotification(ByVal sender As Object, ByVal e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            Dim NotificationCount As Integer = 0
            Dim Ctrl As Control = CType(sender, Control)

            If Ctrl IsNot Nothing AndAlso Controls.TryGetValue(Ctrl, NotificationCount) Then

                Using p As Pen = New Pen(Color.Transparent)
                    Using F As New Font("Segoe UI", 7, FontStyle.Bold, GraphicsUnit.Point)
                        Dim SF As New StringFormat With {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center}
                        Dim CtrlRect As Rectangle = New Rectangle(Ctrl.Width - 20, Ctrl.Height - Ctrl.Height + 6, 14, 14)
                        g.DrawRectangle(Pens.Transparent, CtrlRect)
                        Dim MS As String = If(NotificationCount = 1, Convert.ToChar(&H2776), Convert.ToChar(&H2777))
                        g.DrawString(MS, F, Brushes.White, CtrlRect, SF)
                    End Using
                End Using
            End If
        End Sub

    End Class

End Namespace


