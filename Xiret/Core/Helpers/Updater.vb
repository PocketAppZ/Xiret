'  Created by David S on 20.03.2016
'  Updated on 15.01.2020 - DS (Enhancements, cleanup)

Imports System.Net
Imports System.Xml

Imports Xiret.Core.Helpers

Friend Class Updater

    Private Shared ReadOnly XMLDoc As XmlDocument = New XmlDocument

    Friend Shared LocalVersion As String = ""
    Friend Shared ServerVersion As String = ""
    Friend Shared ReleaseDate As String = ""

#Region "Check"

    Friend Shared Function IsNewVersionAvailable() As Boolean

        Try
            If NetHelper.IsWebsiteAvailable(Strings.BitmightUrl) Then

                ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

                XMLDoc.Load(Strings.ServerVersionUrl)

                'Remote
                Dim XMLNode As XmlNode = XMLDoc.SelectSingleNode("data/Xiret")
                Dim MajBuildServer As Integer = CInt(XMLNode("Maj").InnerText)
                Dim MinBuidServer As Integer = CInt(XMLNode("Min").InnerText)
                Dim RevBuildServer As Integer = CInt(XMLNode("Rev").InnerText)
                ServerVersion = MajBuildServer & "." & MinBuidServer & "." & RevBuildServer

                'Local
                Dim VersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileHelper.GetApplicationImage)
                Dim MajBuildLocal As Integer = VersionInfo.FileMajorPart
                Dim MinBuildLocal As Integer = VersionInfo.FileMinorPart
                Dim RevBuildLocal As Integer = VersionInfo.FileBuildPart
                LocalVersion = MajBuildLocal & "." & MinBuildLocal & "." & RevBuildLocal

                ' Other
                ReleaseDate = XMLNode("ReleaseDate").InnerText

                XMLNode = Nothing

                If ServerVersion > LocalVersion Then
                    'Update available
                    Return True
                Else
                    If ServerVersion <= LocalVersion Then
                        'Current version installed
                        Return False
                    End If
                End If
            Else
                'Network unavailable
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

        Return False

    End Function

#End Region

End Class
