'  Updated on 23.09.2019 - DS (Move checksum generation from SHA256 to SHA512)

'  -------------------------------------------------------------------------

'  ExecTask and InstallMsu are original content by DavidXanatos and are
'  licensed under the GNU General Public License v3.0. See the license
'  terms here:
'  https://github.com/DavidXanatos/wumgr/blob/master/LICENSE

'  Code converted to VB.NET by Muerto which is being disclosed per the
'  license terms. Apart from the conversion no code was changed in these
'  routines apart from some simplifications.

Imports System.IO
Imports System.Text

Namespace Core.Helpers

    NotInheritable Class FileHelper

        Public Shared MoveSafelyError As String = ""

        Public Shared Function GetApplicationImage() As String

            Dim Builder As New StringBuilder(255)
            NativeMethods.GetModuleFileName(IntPtr.Zero, Builder, Builder.Capacity)
            Return Builder.ToString

        End Function

#Region "Stringbuilder"

        Public Shared Function GenerateRandomString(LengthOfString As Integer, Optional UpperCase As Boolean = False) As String

            Dim Chars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            Dim Ran As New Random
            Dim Builder As New StringBuilder
            For Int As Integer = 1 To LengthOfString
                Dim IntNext As Integer = Ran.Next(0, 35)
                Builder.Append(Chars.Substring(IntNext, 1))
            Next

            Return CType(IIf(UpperCase, Builder.ToString.ToUpper(), Builder.ToString()), String)

        End Function

#End Region
#Region "Move File"

        Public Shared Function MoveSafely(ByVal FileToCopy As String, ByVal CopyFileTo As String, Optional Overwrite As Boolean = False) As Integer

            'MoveSafely returns integers, e.g. Dim Int As Integer = FileHelper.MoveSafely(SomeFile, SomeDestinationFile)
            '0 - Error
            '1 - Successful
            '2 - Copy fail on checksum is most likely corrupt destination file
            '3 - Destination file missing
            '4 - Source file missing

            Try
                If File.Exists(FileToCopy) Then

                    My.Computer.FileSystem.CopyFile(FileToCopy, CopyFileTo, Overwrite)

                    If File.Exists(CopyFileTo) Then

                        Dim SourceChecksum As String = CryptoHelper.GetSha256FromFile(FileToCopy)
                        Dim DestinationChecksum As String = CryptoHelper.GetSha256FromFile(CopyFileTo)

                        If SourceChecksum = DestinationChecksum Then
                            My.Computer.FileSystem.DeleteFile(FileToCopy)
                            Return 1
                        Else
                            My.Computer.FileSystem.DeleteFile(CopyFileTo)
                            Return 2
                            MessageBox.Show("Checksum fail:" & vbCrLf & SourceChecksum & vbCrLf & DestinationChecksum & vbCrLf & vbCrLf & "The source file was left untouched.", "Xiret.Helpers.FHMove")
                        End If
                    Else
                        Return 3
                    End If
                Else
                    Return 4
                End If
            Catch ex As Exception
                MoveSafelyError = ex.ToString
                Return 0
            End Try

        End Function

#End Region
#Region "Install MSU file"
        Public Shared Function InstallMsu(ByVal FileName As String) As Integer
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {
                .FileName = "%SystemRoot%\System32\wusa.exe",
                .Arguments = """" & FileName & """ /quiet /norestart"
            }
            Return ExecTask(startInfo)
        End Function

        Public Shared Function ExecTask(ByVal StartInfo As ProcessStartInfo, ByVal Optional SilentInstall As Boolean = True) As Integer

            StartInfo.FileName = Environment.ExpandEnvironmentVariables(StartInfo.FileName)

            If SilentInstall Then
                With StartInfo
                    .RedirectStandardOutput = True
                    .RedirectStandardError = True
                    .UseShellExecute = False
                    .CreateNoWindow = True
                End With
            End If

            Dim Proc As Process = New Process With {
                .StartInfo = StartInfo,
                .EnableRaisingEvents = True
            }

            Proc.Start()
            Proc.WaitForExit()

            Return Proc.ExitCode

        End Function

    End Class

#End Region

End Namespace


