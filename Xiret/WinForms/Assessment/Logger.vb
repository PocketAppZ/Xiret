NotInheritable Class Logger

    Friend Shared Sub Log(ByVal StringReceived As String, TypeReceived As LogType, Control As RichTextBox)

        Dim LogTypeText As String = ""
        Dim LogTypeColor As Color

        Select Case TypeReceived
            Case LogType.XiretLog
                LogTypeText = "[XIR]: "
                LogTypeColor = LogColor.Xiret
            Case LogType.WinsatLog
                LogTypeText = "[WEI]: "
                LogTypeColor = LogColor.Winsat
            Case LogType.InfoLog
                LogTypeText = "[INF]: "
                LogTypeColor = LogColor.Information
            Case LogType.OkayLog
                LogTypeText = "[OKY]: "
                LogTypeColor = LogColor.Okay
            Case LogType.WarningLog
                LogTypeText = "[WRN]: "
                LogTypeColor = LogColor.Warning
            Case LogType.ErrorLog
                LogTypeText = "[ERR]: "
                LogTypeColor = LogColor.ErrorRed
        End Select

        With Control
            .AppendText(LogTypeText)
            .Select(Control.TextLength - LogTypeText.Length, LogTypeText.Length - 1)
            .SelectionColor = LogTypeColor
            .AppendText(StringReceived)
            .AppendText(vbCrLf)
            .ScrollToCaret() 'ScrollToCarrot
        End With

        My.Computer.FileSystem.WriteAllText(Settings.AssessmentLogPath, StringReceived & vbCrLf, True)

    End Sub

End Class
