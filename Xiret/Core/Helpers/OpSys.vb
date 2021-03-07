'  Updated on 01.10.2019 - DS (Update bools, remove NET Framework code, remove admin code, cleanup)

Imports System.IO
Imports System.Management
Imports Microsoft.Win32

Namespace Core.Helpers

    NotInheritable Class OSHelper

        Private Shared ReadOnly SysDirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
        Private Shared ReadOnly CompName As String = My.Computer.Name

        Public Shared ReadOnly KernelVerInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SysDirPath, "kernel32.dll"))
        Public Shared ReadOnly WinsatVerInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SysDirPath, "winsat.exe"))
        Public Shared ReadOnly WinsatApiVerInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SysDirPath, "winsatapi.dll"))

#Region "Bools"

        Public Shared Function IsWinVista() As Boolean
            If (KernelVerInfo.ProductMajorPart = 6) And (KernelVerInfo.ProductMinorPart = 0) Then
                Return True 'Vista, ret true.
            End If
            Return False
        End Function

        Public Shared Function IsWin7() As Boolean
            If (KernelVerInfo.ProductMajorPart = 6) And (KernelVerInfo.ProductMinorPart = 1) Then
                Return True 'W7, ret true.
            End If
            Return False
        End Function

        Public Shared Function IsWin8() As Boolean
            If (KernelVerInfo.ProductMajorPart = 6) And (KernelVerInfo.ProductMinorPart = 2) Then
                Return True 'W8 ret true.
            End If
            Return False
        End Function

        Public Shared Function IsWin81() As Boolean

            If (KernelVerInfo.ProductMajorPart = 6) And (KernelVerInfo.ProductMinorPart = 3) Then
                Return True 'W8.1 ret true
            End If
            Return False
        End Function

        Public Shared Function IsWin10() As Boolean
            If (KernelVerInfo.ProductMajorPart = 10) And (KernelVerInfo.ProductMinorPart = 0) Then
                Return True 'W10, ret true.
            End If
            Return False
        End Function

        Public Shared Function IsWinServer() As Boolean

            'Explicitly defining ProductType knocks speed off the query. SELECT * becomes SELECT ProductType.
            Using Searcher As New ManagementObjectSearcher("SELECT ProductType FROM Win32_OperatingSystem")
                For Each MObj As ManagementObject In Searcher.Get()
                    Dim Int As UInteger = CUInt(MObj.GetPropertyValue("ProductType"))
                    Return Int <> 1 'Server build, ret true.
                Next
            End Using

            Return False 'Ret false, not server.

        End Function
#End Region
#Region "Name"

        Public Shared Function GetWindowsName() As String

            Dim RegGet As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, My.Computer.Name)

            Try
                RegGet = RegGet.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return RegGet.GetValue("ProductName").ToString().Replace(" (TM)", "™")
            Catch ex As Exception
                Return ""
            End Try

            Return ""

        End Function

#End Region
#Region "Architecture"
        Public Shared Function GetWindowsBitness(Optional ShortArc As Boolean = False) As String

            If Environment.Is64BitOperatingSystem Then
                If ShortArc Then
                    Return "x64"
                Else
                    Return "64-Bit"
                End If
            Else
                If ShortArc Then
                    Return "x86"
                Else
                    Return "32-Bit"
                End If
            End If

        End Function
        Public Shared Function IsWindows64Bit() As Boolean

            If Environment.Is64BitOperatingSystem Then
                Return True
            Else
                Return False 'x86
            End If

        End Function

#End Region
#Region "Service Pack"

        Public Shared Function GetWindowsServicePack() As String

            Dim Str As String = Environment.OSVersion.ServicePack

            If Str.Length = 0 Then
                Return "Not applicable"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Uptime"

        Public Shared Function GetWindowsUptime() As String

            Try
                Dim Int As Integer = CInt(NativeMethods.GetTickCount() / 1000)
                Return Format$(Int \ 3600 \ 24, "0") & "d, " & Format$((Int \ 3600) Mod 24, "00") & "h, " _
                     & Format$((Int Mod 3600) \ 60, "00") & "m, " & Format$(Int Mod 60, "00") & "s"
            Catch
                Return "Unknown"
            End Try

        End Function

#End Region
#Region "Install Date"

        'Public Shared Function GetWindowsInstallDate(ComputerName As String) As String
        Public Shared Function GetWindowsInstallDate() As String

            'Dim key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, ComputerName)
            Dim RegGet As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                RegGet = RegGet.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                If RegGet IsNot Nothing Then
                    Dim startDate As Date
                    Dim regVal As Long
                    startDate = New DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime
                    regVal = Convert.ToInt64(RegGet.GetValue("InstallDate").ToString())
                    Return CStr(startDate.AddSeconds(regVal))
                End If
            Catch
                Return CStr(Date.MinValue)
            Finally
                RegGet.Dispose()
            End Try

            Return CStr(Date.MinValue)

        End Function

#End Region
#Region "Release Id"

        Public Shared Function GetWindowsReleaseId() As String

            Dim RegGet As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                RegGet = RegGet.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return RegGet.GetValue("ReleaseId").ToString()
            Catch ex As Exception
                Return ""
            Finally
                RegGet.Dispose()
            End Try

        End Function

#End Region
#Region "Build Branch"

        Public Shared Function GetWindowsBuildBranch() As String

            Dim RegGet As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                RegGet = RegGet.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return RegGet.GetValue("BuildBranch").ToString().Replace("_release", "").ToUpper
            Catch ex As Exception
                Return ""
            Finally
                RegGet.Dispose()
            End Try

        End Function

#End Region
#Region "Current Build"

        Public Shared Function GetWindowsCurrentBuild() As String

            Dim RegGet As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                RegGet = RegGet.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return RegGet.GetValue("CurrentBuild").ToString()
            Catch ex As Exception
                Return ""
            Finally
                RegGet.Dispose()
            End Try

        End Function

#End Region
#Region "Build Lab"

        Public Shared Function GetWindowsBuildLab() As String

            Dim RegGet As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                RegGet = RegGet.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return RegGet.GetValue("BuildLab").ToString()
            Catch ex As Exception
                Return ""
            Finally
                RegGet.Dispose()
            End Try

        End Function

#End Region
#Region "Username"
        Public Shared Function GetUsername() As String
            Return Environment.UserName
        End Function
#End Region

    End Class
End Namespace


