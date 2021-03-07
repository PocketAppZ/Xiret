Friend Class Taskbar

    Friend Shared Function GetLocation() As TaskBarLocation

        Dim Bounds As Rectangle = Screen.PrimaryScreen.Bounds
        Dim Area As Rectangle = Screen.PrimaryScreen.WorkingArea
        If Area.Height < Bounds.Height And Area.Y > 0 Then
            Return TaskBarLocation.Top
        ElseIf Area.Height < Bounds.Height And Area.Y = 0 Then
            Return TaskBarLocation.Bottom
        ElseIf Area.Width < Bounds.Width And Area.X > 0 Then
            Return TaskBarLocation.Left
        ElseIf Area.Width < Bounds.Width And Area.X = 0 Then
            Return TaskBarLocation.Right
        Else
            Return Nothing
        End If

    End Function

End Class


