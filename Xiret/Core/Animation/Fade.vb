Imports System.Threading

Namespace Core.Animation

    NotInheritable Class Fade
        Public Shared Sub FadeIn(Form As Form)
            For FIn As Double = 0.0 To 1.0 Step 0.2
                Form.Opacity = FIn
                Form.Refresh()
                Thread.Sleep(10)
            Next
        End Sub
        Public Shared Sub FadeOut(Form As Form)
            For FOut As Double = 1.0 To 0.0 Step -0.2
                Form.Opacity = FOut
                Form.Refresh()
                Thread.Sleep(10)
            Next
        End Sub
        Public Shared Sub FadeBehindChild(Form As Form)
            For FOut As Double = 1.0 To 0.2 Step -0.2
                Form.Opacity = FOut
                Form.Refresh()
                Thread.Sleep(10)
            Next
        End Sub
        Public Shared Sub RefadeIn(Form As Form)
            If Form.Opacity <> 0.2 Then
                For FIn As Double = 0.2 To 1.0 Step 0.2
                    Form.Opacity = FIn
                    Form.Refresh()
                    Thread.Sleep(10)
                Next
            End If
        End Sub
    End Class

End Namespace


