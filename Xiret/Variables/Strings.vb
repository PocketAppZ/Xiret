Friend Class Strings

    Friend Const BitmightUrl As String = "https://bitmight.uk"
    Friend Const XiretZipUrl As String = "https://bitmight.uk/software/xiret/download/xiret.zip"
    Friend Const ImgurUrl As String = "http://www.imgur.com"
    Friend Const ServerVersionUrl As String = "https://www.bitmight.uk/software/xiret/ver.xml"
    Friend Const MediaFeatureUrl As String = "http://windows.microsoft.com/en-gb/windows/download-windows-media-player"

    Friend Const ProcessorRO As String = "Calculation per second"
    Friend Const MemoryRO As String = "Memory operations per second"
    Friend Const GraphicsRO As String = "Desktop graphics performance"
    Friend Const D3DRO As String = "3D business and gaming graphics performance"
    Friend Const DiskRO As String = "Disk data transfer rate"

    Friend Const ImgurClientID As String = "35e23362c1eb67c" 'API key needed from imgur.com

    Friend Shared BaseScore As String = Nothing
    Friend Shared ProcessorScore As String = Nothing
    Friend Shared MemoryScore As String = Nothing
    Friend Shared GraphicsScore As String = Nothing
    Friend Shared D3DScore As String = Nothing
    Friend Shared DiskScore As String = Nothing
    Friend Shared AssessDate As String = Nothing

    Friend Shared ProcessorHW As String = ""
    Friend Shared MemoryHW As String = ""
    Friend Shared GraphicsHW As String = ""
    Friend Shared D3DHW As String = ""
    Friend Shared DiskHW As String = ""

End Class
