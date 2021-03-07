'  Updated on 10.01.2020 - DS (Gain Base64ToImage)
'  Updated on 23.01.2020 - DS (Remove SHA512 and reuse SHA256)

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace Core.Helpers

    NotInheritable Class CryptoHelper

        Public Shared Function GetSha256FromFile(FilePath As String, Optional UpperCase As Boolean = False) As String

            Dim Builder As New StringBuilder()
            Dim HashType As SHA256 = SHA256.Create()

            Using Stream As FileStream = File.OpenRead(FilePath)
                For Each HByte As Byte In HashType.ComputeHash(Stream)
                    If Not UpperCase Then
                        Builder.Append(HByte.ToString("x2").ToLower())
                    Else
                        Builder.Append(HByte.ToString("x2").ToUpper())
                    End If
                Next
            End Using

            HashType.Dispose()
            Return Builder.ToString()

        End Function

        Friend Shared Function Base64ToImage(Base64Data As String) As Image

            Dim Img As Image
            Dim Stream As MemoryStream
            If Base64Data.Length = 0 Then
                Throw New ArgumentException("No base64 image data was detected.")
            End If
            Dim Dat As String = Base64Data.Replace(" ", "+")
            Dim Byt() As Byte

            Byt = Convert.FromBase64String(Dat)
            Stream = New MemoryStream(Byt)
            Img = Image.FromStream(Stream)

            Return Img

        End Function

    End Class

End Namespace


