'  Updated on 31.07.2019 - DS (Moved API to Core\WinApi\SendMessageA)
'  Updated on 23.09.2019 - DS (Remove unnecessary cast)

Namespace Core.Helpers

    NotInheritable Class ControlHelper

        Public Shared Sub SetCueText(Textbox As Control, Text As String)
            NativeMethods.SendMessage(Textbox.Handle, &H1501, 0, Text)
        End Sub

    End Class

End Namespace


