'  Updated on 18.07.2019 - DS (Cleanup)

Namespace Core.Converters

    NotInheritable Class MemoryConverter

        Public Shared Function ConvertMemoryInt(ByVal Data As String) As String

            Select Case Data

                Case "0"
                    Return "Unknown"
                Case "1"
                    Return "Other"
                Case "2"
                    Return "DRAM"
                Case "3"
                    Return "Synchronous DRAM"
                Case "4"
                    Return "Cache DRAM"
                Case "5"
                    Return "EDO"
                Case "6"
                    Return "EDRAM"
                Case "7"
                    Return "VRAM"
                Case "8"
                    Return "SRAM"
                Case "9"
                    Return "RAM"
                Case "10"
                    Return "ROM"
                Case "11"
                    Return "Flash"
                Case "12"
                    Return "EEPROM"
                Case "13"
                    Return "FEPROM"
                Case "14"
                    Return "EPROM"
                Case "15"
                    Return "CDRAM"
                Case "16"
                    Return "3DRAM"
                Case "17"
                    Return "SDRAM"
                Case "18"
                    Return "SGRAM"
                Case "19"
                    Return "RDRAM"
                Case "20"
                    Return "DDR"
                Case "21"
                    Return "DDR2"
                Case "22"
                    Return "DDR2 FB-DIMM"
                Case "24"
                    Return "DDR3"
                Case "25"
                    Return "FBD2"
                Case "26"
                    Return "DDR4"
                Case Else
                    If Data Is Nothing Then
                        Return "Unknown"
                    Else
                        Return Data 'Return what was passed
                    End If
            End Select

        End Function

    End Class

End Namespace


