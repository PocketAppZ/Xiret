'// Move all pinvokes to NativeMethods class

Imports System.Runtime.InteropServices
Imports System.Text

NotInheritable Class NativeMethods

    '// http://pinvoke.net/default.aspx/gdi32.AddFontResource
    <DllImport("gdi32", CharSet:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    Friend Shared Function AddFontResource(lpFileName As String) As Integer
    End Function

    '// http://pinvoke.net/default.aspx/kernel32.GetModuleFileName
    <DllImport("kernel32", CharSet:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    <PreserveSig()>
    Friend Shared Function GetModuleFileName(<[In]()> hModule As IntPtr, <Out()> lpFilename As StringBuilder, <[In]()> <MarshalAs(UnmanagedType.U4)> nSize As Integer) As UInteger
    End Function

    '// http://www.pinvoke.net/default.aspx/kernel32.GetPrivateProfileString
    <DllImport("kernel32", CharSet:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    <PreserveSig()>
    Friend Shared Function GetPrivateProfileString(<MarshalAs(UnmanagedType.LPWStr)> lpAppName As String, lpKeyName As String, lpDefault As String,
                                                lpReturnedString As StringBuilder, nSize As Integer, lpFileName As String) As Integer

    End Function

    '// http://pinvoke.net/default.aspx/kernel32.GetTickCount
    <DllImport("kernel32", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    <PreserveSig()>
    Friend Shared Function GetTickCount() As Integer
    End Function

    '// http://pinvoke.net/default.aspx/user32.SendMessage
    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    <PreserveSig()>
    Friend Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As UInteger, lParam As IntPtr) As Integer
    End Function

    '// Variant for SetCueText
    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    <PreserveSig()>
    Friend Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As UInteger, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Integer
    End Function

    '// http://pinvoke.net/default.aspx/user32.SetProcessDPIAware
    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    <PreserveSig()>
    Friend Shared Function SetProcessDPIAware() As Boolean
    End Function

    '// http://pinvoke.net/default.aspx/kernel32/SetProcessWorkingSetSize.html
    <DllImport("kernel32", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    Friend Shared Function SetProcessWorkingSetSize(hProcess As IntPtr, dwMinimumWorkingSetSize As IntPtr, dwMaximumWorkingSetSize As IntPtr) As Integer
    End Function

    '// http://pinvoke.net/default.aspx/mscorsn/StrongNameSignatureVerificationEx.html
    <DllImport("mscorwks.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    <PreserveSig()>
    Friend Shared Function StrongNameSignatureVerificationEx(<MarshalAs(UnmanagedType.LPWStr)> wszFilePath As String, <MarshalAs(UnmanagedType.Bool)> fForceVerification As Boolean,
                                                             <Out(), MarshalAs(UnmanagedType.Bool)> ByRef pfWasVerified As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    '// http://pinvoke.net/default.aspx/kernel32.WriteProfileString
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)>
    Friend Shared Function WriteProfileString(lpszSection As String, lpszKeyName As String, lpszString As String) As Integer
    End Function

End Class
