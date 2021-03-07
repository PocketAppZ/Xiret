'  Updated on 02.01.2020 - DS (Fix decimal seperator)
'  Updated on 20.01.2020 - DS (Gan GetExitCode(), gain GetExitCodeString(), cleanup)

Imports System.IO
Imports System.Linq
Imports System.Xml

Imports Xiret.Core.Converters
Imports Xiret.Core.Helpers

Namespace Winsat

    Friend Class WSR5

        Friend Shared ReadOnly DecSeperator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

#Region "WinSPR"

        Friend Shared Sub GetWinsatSPR()

            Try
                If CDbl(WinsatApi.GetWinsatBaseScore()) = 0 Then
                    Strings.BaseScore = "0"
                    Strings.ProcessorScore = "Unrated"
                    Strings.MemoryScore = "Unrated"
                    Strings.GraphicsScore = "Unrated"
                    Strings.D3DScore = "Unrated"
                    Strings.DiskScore = "Unrated"
                    FormMain.UpdateControls()
                Else
                    Try
                        Strings.BaseScore = CType(WinsatApi.GetWinsatBaseScore(), String)
                        'Append if length is 1
                        If Strings.BaseScore.Length = 1 Then
                            Strings.BaseScore &= DecSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.BaseScore.Length > 3 Then
                                Strings.BaseScore = Strings.BaseScore.Substring(0, Strings.BaseScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.BaseScore = "..."
                    End Try

                    '// Processor Score
                    Try
                        Strings.ProcessorScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.ProcessorScore.Length = 1 Then
                            Strings.ProcessorScore &= DecSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.ProcessorScore.Length > 3 Then
                                Strings.ProcessorScore = Strings.ProcessorScore.Substring(0, Strings.ProcessorScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.ProcessorScore = "..."
                    End Try

                    '// Memory Score
                    Try
                        Strings.MemoryScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.MemoryScore.Length = 1 Then
                            Strings.MemoryScore &= DecSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.MemoryScore.Length > 3 Then
                                Strings.MemoryScore = Strings.MemoryScore.Substring(0, Strings.MemoryScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.MemoryScore = "..."
                    End Try

                    '// Graphics Score
                    Try
                        Strings.GraphicsScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.GraphicsScore.Length = 1 Then
                            Strings.GraphicsScore &= DecSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.GraphicsScore.Length > 3 Then
                                Strings.GraphicsScore = Strings.GraphicsScore.Substring(0, Strings.GraphicsScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.GraphicsScore = "..."
                    End Try

                    '// Gaming Graphics Score
                    Try
                        Strings.D3DScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.D3DScore.Length = 1 Then
                            Strings.D3DScore &= DecSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.D3DScore.Length > 3 Then
                                Strings.D3DScore = Strings.D3DScore.Substring(0, Strings.D3DScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.D3DScore = "..."
                    End Try

                    '// Disk Score
                    Try
                        Strings.DiskScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, INFO_TYPE.Score)
                        'Append is length is 1
                        If Strings.DiskScore.Length = 1 Then
                            Strings.DiskScore &= DecSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.DiskScore.Length > 3 Then
                                Strings.DiskScore = Strings.DiskScore.Substring(0, Strings.DiskScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.DiskScore = "..."
                    End Try

                    If Settings.UseApiHardware = 1 Then
                        ReadAPIHardware()
                    Else
                        ReadXMLHardware()
                    End If

                End If

            Catch ex As Exception
                Strings.BaseScore = "0"
                Strings.ProcessorScore = "Unrated"
                Strings.MemoryScore = "Unrated"
                Strings.GraphicsScore = "Unrated"
                Strings.D3DScore = "Unrated"
                Strings.DiskScore = "Unrated"
                FormMain.UpdateControls()
                MessageBox.Show(ex.ToString, "WSR.GetWinsatSPR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

#End Region
#Region "Hardware (XML)"

        Friend Shared Sub ReadXMLHardware()

            If Not WinsatApi.GetAssessmentValidityInt() = 3 Then 'Block attempts to load hardware on unrated systems
                Strings.ProcessorHW = XMLGetProcessor()
                Strings.MemoryHW = XMLGetMemoryType() & " " & XMLGetMemorySize()
                Strings.GraphicsHW = XMLGetGraphicsName()
                Strings.D3DHW = XMLGetGraphicsSize()
                Strings.DiskHW = XMLGetDisk()
            End If

        End Sub

        Private Shared Function XMLGetProcessor() As String

            Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Processor/Instance", "ProcessorName")
            If Str.Length = 0 Then
                Return "Unknown Processor"
            Else
                Return Str.Replace("@", "·")
            End If

        End Function

        Private Shared Function XMLGetMemoryType() As String

            Dim Str As String = MemoryConverter.ConvertMemoryInt(GetWinsatXMLInfo("WinSAT/SystemConfig/Memory/DIMM", "MemoryType"))
            If Str.Length = 0 Then
                Return "Unknown Memory"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetMemorySize() As String

            Dim Str As String = SizeConverter.ConvertBigSize(CDbl(GetWinsatXMLInfo("WinSAT/SystemConfig/Memory/TotalPhysical", "Bytes")))
            If Str.Length = 0 Then
                Return "Unknown Size"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetGraphicsName() As String

            Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Graphics", "AdapterDescription")
            If Str.Length = 0 Then
                Return "Unknown Adapter"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetGraphicsSize() As String

            Dim Str As String = SizeConverter.BytesToMBSquared(CDbl(GetWinsatXMLInfo("WinSAT/SystemConfig/Graphics", "DedicatedVideoMemory"))) & " MB total VRAM"
            If Str.Length = 0 Then
                Return "Unknown Adapter Size"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetDisk() As String

            Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Disk/SystemDisk", "Model")
            If Str.Length = 0 Then
                Return "Unknown Disk"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Hardware (API)"

        Friend Shared Sub ReadAPIHardware()

            If Not WinsatApi.GetAssessmentValidityInt() = 3 Then 'Block attempts to load hardware on unrated systems
                Strings.ProcessorHW = APIGetProcessor()
                Strings.MemoryHW = APIGetMemorySize()
                Strings.GraphicsHW = APIGetGraphicsName()
                Strings.D3DHW = APIGetGraphicsSize()
                Strings.DiskHW = APIGetDisk()
            End If

        End Sub

        Private Shared Function APIGetProcessor() As String

            Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Processor"
            Else
                Return Str.Replace("@", "·")
            End If

        End Function

        Private Shared Function APIGetMemorySize() As String

            Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Memory"
            Else
                Return Str
            End If

        End Function

        Private Shared Function APIGetGraphicsName() As String

            Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Adapter"
            Else
                Return Str
            End If

        End Function

        Private Shared Function APIGetGraphicsSize() As String

            Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Shared Memory"
            Else
                Return Str
            End If

        End Function

        Private Shared Function APIGetDisk() As String

            Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Disk"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Read XML"

        Friend Shared Function GetWinsatXMLInfo(ByVal Node As String, ByVal Inner As String) As String

            Try
                Dim XMLDoc As New XmlDocument
                Dim XMLDocNode As XmlNode
                If Not GetLatestFormalXML() = Files.LatestFormalXML Then
                    XMLDoc.Load(GetLatestFormalXML())
                Else
                    XMLDoc.Load(Files.LatestFormalXML)
                End If

                XMLDocNode = XMLDoc.SelectSingleNode(Node)

                Return XMLDocNode(Inner).InnerText

            Catch
                Return ""
            End Try

        End Function

#End Region
#Region "Get Formal"

        Friend Shared Function GetLatestFormalXML() As String

            Dim Watch As New Stopwatch()
            Dim NewestFile As FileInfo = Nothing
            Dim Datastore As New DirectoryInfo(Directories.WinsatDatastorePath)

            Watch.Start()

            For Each Item As FileInfo In Datastore.EnumerateFiles("*Formal*.xml", SearchOption.TopDirectoryOnly)
                If NewestFile Is Nothing OrElse Item.LastWriteTime >= NewestFile.LastWriteTime Then
                    NewestFile = Item
                End If
            Next

            Watch.Stop()

            If (NewestFile Is Nothing) And OSHelper.IsWinVista() Then 'Vista is a little different, check for one Initial file

                For Each Item As FileInfo In Datastore.EnumerateFiles("*Initial*.xml", SearchOption.TopDirectoryOnly)
                    If NewestFile Is Nothing OrElse Item.LastWriteTime >= NewestFile.LastWriteTime Then
                        NewestFile = Item
                    End If
                Next

                If NewestFile Is Nothing Then
                    Files.LatestFormalXML = ""
                    Return ""
                Else
                    Files.LatestFormalXML = NewestFile.FullName
                    Return NewestFile.FullName
                End If

            Else
                Files.LatestFormalXML = NewestFile.FullName
                Return NewestFile.FullName
            End If

        End Function

#End Region
#Region "Exit Code"

        Friend Shared Function GetExitCode() As Integer

            Try
                Dim SList As String() = File.ReadAllLines(Directories.WinsatPath & "\winsat.log")
                Dim Code As String = SList.Last
                If Code.Contains("exit value = ") Then
                    Return CInt(Code.Substring(Code.Length - 2, 1))
                End If

                Return -1

            Catch ex As Exception
                Return -1
            End Try

        End Function

        Friend Shared Function GetExitCodeString(ExitCode As Integer) As String

            Select Case ExitCode
                Case 0
                    Return "The assessment completed successfully."
                Case 1
                    Return "The assessment did not complete due to an error. Please click 'Export Session' and save the log for more details."
                Case 2
                    Return "The assessment did not complete due to interference. Please click 'Export Session' and save the log for more details."
                Case 3
                    Return "The assessment was cancelled by the user."
                Case 4
                    Return "The command given to WinSAT was invalid."
                Case 5
                    Return "WinSAT was not run with administrator privilages."
                Case 6
                    Return "Another instance of WinSAT is already running."
                Case 7
                    Return "WinSAT cannot run individual assessments on Remote Desktop server."
                Case 8
                    Return "WinSAT cannot run on battery power."
                Case 9
                    Return "WinSAT cannot run a formal assessment on Remote Desktop server."
                Case 10
                    Return "No multimedia support was detected, so the assessment cannot run."
                Case 11
                    Return "WinSAT cannot run on Windows XP."
                Case 12
                    Return "The WinSAT watchdog timer timed out, indicating something is causing the tests to run unusually slowly."
                Case 13
                    Return "Cannot run the formal assessment on a Virtual Machine."
                Case Else
                    Return "An unknown WinSAT exit code was returned. Please click 'Export Session' and save the log for more details."
            End Select

        End Function

#End Region

    End Class

End Namespace

