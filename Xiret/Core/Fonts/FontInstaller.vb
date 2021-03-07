'  Updated on 27.07.2019 - DS (Combined to one routine, added args to InstallFont())
'  Updated on 07.12.2019 - DS (Add SystemFontSegoeAssets)

Imports System.IO

Namespace Core.Fonts

    NotInheritable Class FontInstaller

        Public Shared ReadOnly SystemFontSegoeUI As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\segoeui.ttf"
        Public Shared ReadOnly SystemFontSegoeUIBold As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\segoeuib.ttf"
        Public Shared ReadOnly SystemFontSegoeUISemibold As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\seguisb.ttf"
        Public Shared ReadOnly SystemFontSegoeAssets As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\segmdl2.ttf"

        'Const
        Private Const WM_FONTCHANGE As Integer = &H1D
        Private Const HWND_BROADCAST As Integer = &HFFFF

        Public Shared Function InstallFont(FileName As String, FontToInstall As Byte(), ProfileName As String) As Integer

            Try
                File.WriteAllBytes(FileName, FontToInstall)

                If File.Exists(FileName) Then
                    Dim IntRet As Integer = NativeMethods.AddFontResource(FileName)
                    Dim IntRes As Integer = NativeMethods.SendMessage(CType(HWND_BROADCAST, IntPtr), WM_FONTCHANGE, 0, CType(0, IntPtr))
                    IntRet = NativeMethods.WriteProfileString("fonts", ProfileName, FileName)
                    Return 1 'Install success
                Else
                    Return 2 'File did not copy
                End If
            Catch ex As Exception
                Return 0 'Error
            End Try

        End Function

    End Class

End Namespace


