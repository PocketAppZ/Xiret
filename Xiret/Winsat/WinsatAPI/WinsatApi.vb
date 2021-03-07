'  Updated on 31.07.2019 - DS (Better error handling)

Imports WINSATLib
Imports WINSATLib.WINSAT_BITMAP_SIZE
Imports System.Runtime.InteropServices

Friend Class WinsatApi

#Region "Functions"

    Friend Shared Function GetAssessmentValidityInt() As Integer

        Dim WinSAT As New CQueryWinSAT()

        Try
            Return WinSAT.Info.AssessmentState
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetAssessmentValidityInt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function

    Friend Shared Function GetWinsatHardwareAPIInfo(WinType As WINSAT_ASSESSMENT_TYPE, InfType As INFO_TYPE) As String

        Dim WinSAT As New CQueryWinSAT()
        Dim QueryInf As IProvideWinSATAssessmentInfo = WinSAT.Info.GetAssessmentInfo(WinType)

        Try
            Select Case InfType
                Case INFO_TYPE.Description
                    Return QueryInf.Description
                Case INFO_TYPE.Score
                    Return CStr(QueryInf.Score)
                Case INFO_TYPE.Title
                    Return QueryInf.Title
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatHardwareAPIInfo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Unknown"
        End Try

    End Function

    Friend Shared Function GetWinsatBaseScore() As Single

        Dim WinSAT As New CQueryWinSAT()

        Try
            Return Winsat.Info.SystemRating
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatBaseScore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0.0
        End Try

    End Function

    Friend Shared Function GetWinsatLastUpdateDate() As Date

        Dim WinSAT As New CQueryWinSAT()

        Try
            Return CDate(WinSAT.Info.AssessmentDateTime)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatLastUpdateDate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

    Friend Shared Function GetWinsatVisual(Optional SizeMode As VISUAL_SIZE = VISUAL_SIZE.Small) As Bitmap

        'This function is used to retrieve the winsat visual bitmap
        'Usage ExamplePicturebox.Image = GetWinsatVisual(VisualSize.Normal)
        'VisualSize.Small returns the small image seen in Control Panel > All > System (Up to Windows 8)
        'VisualSize.Large returns the large image seen in the graph in Control Panel > All > Performance Information and Tools (Up to Windows 8)

        Dim WinSAT As New CQueryWinSAT()
        Dim Buffer(3) As Byte
        Dim GHC As GCHandle = GCHandle.Alloc(Buffer, GCHandleType.Pinned)
        Dim Pointer As IntPtr = GHC.AddrOfPinnedObject()
        Dim queryVisual As New CProvideWinSATVisuals()

        Try
            If SizeMode = VISUAL_SIZE.Small Then
                queryVisual.get_Bitmap(WINSAT_BITMAP_SIZE_SMALL, WinSAT.Info.AssessmentState, WinSAT.Info.SystemRating, Pointer)
            Else
                queryVisual.get_Bitmap(WINSAT_BITMAP_SIZE_NORMAL, WinSAT.Info.AssessmentState, WinSAT.Info.SystemRating, Pointer)
            End If

            GHC.Free()

            If BitConverter.ToInt32(Buffer, 0) <> 0 Then
                Dim Bmp As Bitmap = Image.FromHbitmap(New IntPtr(BitConverter.ToInt32(Buffer, 0)))
                Return Bmp
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatVisual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

#End Region

End Class





