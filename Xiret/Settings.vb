'  Updated on 07.08.2019 - DS (Gain SetBorderColor(), update variables)
'  Updated on 23.01.2020 - DS (Remove Alpha from SetBorderColor())

Imports System.IO
Imports System.Xml

Imports Xiret.Core.Helpers


Friend Class Settings

#Region "Var"

    Friend Shared ReadOnly AppdataDir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Xiret")

    Friend Shared ReadOnly AppdataSettingsPath As String = Path.Combine(AppdataDir, "settings.xir")
    Friend Shared ReadOnly AssessmentLogPath As String = Path.Combine(AppdataDir, "xiret.log")
    Friend Shared ReadOnly ImgurUrlsPath As String = Path.Combine(AppdataDir, "imgurlinks.log")
    Friend Shared ReadOnly LocalSettingsPath As String = Path.Combine(Directories.AppPath, "settings.xir")
    Friend Shared ReadOnly LangPath As String = Path.Combine(Directories.AppPath, "Lang.ini")

    Friend Shared ShowHardwareOnStartup As Integer = 0
    Friend Shared UseApiHardware As Integer = 0
    Friend Shared UseVerboseMode As Integer = 0
    Friend Shared ThemeInt As Integer = 0
    Friend Shared ApplyThemeColorToBorder As Integer = 0
    Friend Shared UseCustomImgurApiKey As Integer = 0

    Friend Shared BoolWorkingDirectory As Boolean = False

    Friend Shared StringUserImgurClientId As String = ""

    Friend Shared ThemeColor As Color = Color.FromArgb(120, 180, 0)

#End Region

#Region "Check Settings"

    Friend Shared Sub CheckSettings()

        If File.Exists(LocalSettingsPath) Then
            BoolWorkingDirectory = True
            LoadSettings()
            Exit Sub
        End If

        If File.Exists(AppdataSettingsPath) Then
            BoolWorkingDirectory = False
            LoadSettings()
            Exit Sub
        End If

        BoolWorkingDirectory = False
        CreateSettings()

    End Sub

#End Region
#Region "Load Settings"

    Friend Shared Sub LoadSettings()

        Try

            Dim XmlDoc As XmlDocument = New XmlDocument
            Dim XmlNod As XmlNode

            If BoolWorkingDirectory Then
                XmlDoc.Load(LocalSettingsPath)
            Else
                XmlDoc.Load(AppdataSettingsPath)
            End If

            XmlNod = XmlDoc.SelectSingleNode("root")

            Try
                ShowHardwareOnStartup = CInt(XmlNod("ShowHardwareOnStartup").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <ShowHardwareOnStartup>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                UseApiHardware = CInt(XmlNod("UseApiHardware").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <UseApiHardware>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                UseVerboseMode = CInt(XmlNod("UseVerboseMode").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <UseVerboseMode>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                ThemeInt = CInt(XmlNod("Theme").InnerText)
                Select Case ThemeInt
                    Case 0
                        ThemeColor = Color.FromArgb(120, 200, 40)
                    Case 1
                        ThemeColor = Color.FromArgb(0, 191, 255)
                    Case 2
                        ThemeColor = Color.FromArgb(0, 255, 181)
                    Case 3
                        ThemeColor = Color.FromArgb(46, 220, 110)
                    Case 4
                        ThemeColor = Color.FromArgb(245, 60, 245)
                    Case 5
                        ThemeColor = Color.FromArgb(255, 105, 180)
                    Case 6
                        ThemeColor = Color.FromArgb(255, 118, 0)
                    Case 7
                        ThemeColor = Color.FromArgb(205, 219, 18)
                    Case 8
                        ThemeColor = Color.FromArgb(255, 50, 50)
                    Case 9
                        ThemeColor = Color.FromArgb(255, 99, 71)
                    Case Else
                        ThemeColor = Color.FromArgb(120, 200, 40)
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <Theme>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                ApplyThemeColorToBorder = CInt(XmlNod("ApplyThemeColorToBorder").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <ApplyThemeColorToBorder>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                UseCustomImgurApiKey = CInt(XmlNod("UseCustomImgurApiKey").InnerText)
                If UseCustomImgurApiKey = 1 Then
                    If XmlNod("ImgurAPIClientIdString").InnerText IsNot Nothing Then
                        StringUserImgurClientId = XmlNod("ImgurAPIClientIdString").InnerText
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <UseCustomImgurApiKey>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            Dim dr As DialogResult = MessageBox.Show("The settings file is malformed or corrupt. Should the file be deleted?" & vbCrLf & vbCrLf & ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If dr = DialogResult.Yes Then
                If File.Exists(AppdataSettingsPath) Then
                    File.Delete(AppdataSettingsPath)
                End If
                Application.Restart()
            End If
        End Try

    End Sub

#End Region
#Region "Create Settings"
    Friend Shared Sub CreateSettings()

        Dim Writer As XmlTextWriter

        If Not Directory.Exists(AppdataDir) Then
            Directory.CreateDirectory(AppdataDir)
        End If

        If BoolWorkingDirectory Then
            Writer = New XmlTextWriter(LocalSettingsPath, Nothing)
        Else
            Writer = New XmlTextWriter(AppdataSettingsPath, Nothing)
        End If

        Writer.Formatting = Formatting.Indented
        Writer.Indentation = 4

        Writer.WriteStartDocument()
        Writer.WriteComment("Xiret Settings File")
        Writer.WriteStartElement("root")
        Writer.WriteComment("0:Off 1:On")
        Writer.WriteElementString("ShowHardwareOnStartup", CStr(ShowHardwareOnStartup))
        Writer.WriteComment("0:XML 1:API")
        Writer.WriteElementString("UseApiHardware", CStr(UseApiHardware))
        Writer.WriteComment("0:Normal 1:Verbose")
        Writer.WriteElementString("UseVerboseMode", CStr(UseVerboseMode))
        Writer.WriteComment("ThemeInteger 0-8")
        Writer.WriteElementString("Theme", CStr(ThemeInt))
        Writer.WriteComment("0:Disable 1:Enable")
        Writer.WriteElementString("ApplyThemeColorToBorder", CStr(ApplyThemeColorToBorder))
        Writer.WriteComment("0:Disable 1:Enable")
        Writer.WriteElementString("UseCustomImgurApiKey", CStr(UseCustomImgurApiKey))
        Writer.WriteComment("User defined Imgur API Client ID")
        Writer.WriteElementString("ImgurAPIClientIdString", StringUserImgurClientId)
        Writer.WriteEndElement()
        Writer.WriteEndDocument()
        Writer.Close()

        Exit Sub

    End Sub

#End Region

#Region "Functions"

    Friend Shared Sub SetBorderColor(ByVal Form As Form)

        If ApplyThemeColorToBorder = 1 Then
            Form.BackColor = ThemeColor
        Else
            Form.BackColor = Colors.BorderStandard
        End If

    End Sub

    Friend Shared Sub SetWindowIcon(Control As PictureBox)
        Control.Image = CryptoHelper.Base64ToImage(Images.ImgIcon24)
    End Sub

    Friend Shared Sub CheckDataPath()
        If Not Directory.Exists(Settings.AppdataDir) Then
            Directory.CreateDirectory(Settings.AppdataDir)
        End If
    End Sub

    Friend Shared Sub CheckDeprecated()

        Dim PreFile As String = Path.Combine(AppdataDir, "prelaunch.log")
        Dim UpdFile As String = Path.Combine(AppdataDir, "paths.xir")

        Dim HS As New List(Of String) From {
           DepPrelaunch,
           DepUpdatPaths
        }

        For Each Hit As String In HS
            If File.Exists(Hit) Then
                File.Delete(Hit)
            End If
        Next

    End Sub

#End Region

#Region "Deprecated"

    Friend Shared ReadOnly DepPrelaunch As String = Path.Combine(AppdataDir, "prelaunch.log")
    Friend Shared ReadOnly DepUpdatPaths As String = Path.Combine(AppdataDir, "paths.xir")

#End Region

End Class
