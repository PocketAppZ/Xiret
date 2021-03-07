'Updated on 07.12.2019 - DS (Removed font variables)

Imports System.IO

Imports Xiret.Core.Helpers

Friend Class Files

    Friend Shared ReadOnly TemporaryImgurFile As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Temp\imgur_" + FileHelper.GenerateRandomString(8, False) + ".png"
    Friend Shared ReadOnly WinsatLog As String = Path.Combine(Directories.WinsatPath, "winsat.log")
    Friend Shared ReadOnly AppLoader As String = New Uri(Reflection.Assembly.GetExecutingAssembly().ManifestModule.Assembly.EscapedCodeBase).LocalPath
    Friend Shared LatestFormalXML As String = ""

    Friend Shared ReadOnly WinsatExe As String = Path.Combine(Directories.System32Path, "winsat.exe")
    Friend Shared ReadOnly WinsatApi As String = Path.Combine(Directories.System32Path, "winsatapi.dll")

End Class
