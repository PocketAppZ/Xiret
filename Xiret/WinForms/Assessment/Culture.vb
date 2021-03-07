Imports System.Globalization
Imports System.IO
Imports System.Text

NotInheritable Class Culture

    Private Shared ReadOnly IniFile As String = Path.Combine(Directories.AppPath, "Compatibility.ini")

    Friend Shared MediaFoundationStr As String = ""
    Friend Shared ExtendedMediaStr As String = ""
    Friend Shared MediaEncodeStr As String = ""
    Friend Shared MemoryStr As String = ""
    Friend Shared StorageStr As String = ""

#Region "Lang"

    Friend Shared Function SetCultureStrings() As Boolean
        If File.Exists(IniFile) Then
            SetIniStrings()
            Return True
        Else
            SetDefaultStrings()
            Return False
        End If
    End Function

    Private Shared Sub SetDefaultStrings()
        MediaFoundationStr = "Media Foundation Playback"
        ExtendedMediaStr = "Extended Media Assessment"
        MediaEncodeStr = "Media Decode/Encode"
        MemoryStr = "System memory performance"
        StorageStr = "Storage Assessment"
    End Sub

    Private Shared Sub SetIniStrings()

        MediaFoundationStr = GetIniValue(GetCultureName, "MediaFound", IniFile, "Media Foundation Playback")
        ExtendedMediaStr = GetIniValue(GetCultureName, "MediaExtend", IniFile, "Extended Media Assessment")
        MediaEncodeStr = GetIniValue(GetCultureName, "MediaEncode", IniFile, "Media Decode/Encode")
        MemoryStr = GetIniValue(GetCultureName, "Memory", IniFile, "System memory performance")
        StorageStr = GetIniValue(GetCultureName, "Storage", IniFile, "Storage Assessment")

    End Sub

#End Region
#Region "Functions"
    Private Shared Function GetIniValue(Section As String, Key As String, Path As String, Optional DefaultStr As String = "") As String
        Dim Builder As New StringBuilder(500)
        If NativeMethods.GetPrivateProfileString(Section, Key, DefaultStr, Builder, Builder.Capacity, Path) > 0 Then
            Return Builder.ToString()
        End If
        Return DefaultStr
    End Function
    Friend Shared Function GetCultureName() As String
        Return CultureInfo.CurrentCulture.Name
    End Function
#End Region

End Class
