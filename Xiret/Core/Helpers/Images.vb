'  Updated on 16.10.2019 - DS (Update imports)

Imports System.IO
Imports System.Net
Imports System.Text

Namespace Core.Helpers

    NotInheritable Class ImageHelper

#Region "Capture Control"

        Public Shared Sub CaptureControl(ByVal SaveAs As String, Control As Control)

            Using Bmap As New Bitmap(Control.Width, Control.Height)
                Control.DrawToBitmap(Bmap, New Rectangle(0, 0, Control.Width, Control.Height))
                Bmap.Save(SaveAs, Imaging.ImageFormat.Png)
            End Using

        End Sub

#End Region
#Region "Imgur API"

        Public Shared Function PostToImgur(ImageLocation As String, LogLocation As String, ClientID As String, ShowInBrowser As Boolean,
                            LogUpload As Boolean, DeleteTempFile As Boolean) As Integer

            Try
                Dim Client As New WebClient()
                Client.Headers.Add("Authorization", Convert.ToString("Client-ID ") & ClientID)
                Do Until File.Exists(ImageLocation)
                    'You're screwed if this fails. May as well go outside and play.
                Loop

                Dim Keys As New Specialized.NameValueCollection From
                    {{"image", Convert.ToBase64String(File.ReadAllBytes(ImageLocation))}}
                Dim CBytes As Byte() = Client.UploadValues("https://api.imgur.com/3/image", Keys)
                Dim Str As String = Encoding.ASCII.GetString(CBytes)
                Dim REx As New RegularExpressions.Regex("link"":""(.*?)""")
                Dim Match As RegularExpressions.Match = REx.Match(Str)
                Dim Address As String = Match.ToString().Replace("link"":""", "").Replace("""", "").Replace("\/", "/")
                If ShowInBrowser Then
                    Process.Start(Address)
                End If
                If LogUpload Then
                    My.Computer.FileSystem.WriteAllText(LogLocation, Date.Now & " - " & Address & vbCrLf, True)
                End If
                If DeleteTempFile Then
                    If File.Exists(ImageLocation) Then
                        File.Delete(ImageLocation)
                    End If
                End If
                Return 1
            Catch
                Return 0
            End Try

            'PostToImgur returns integers, e.g. Dim Int As Integer = ImageHelper.PostToImgur(Args)
            '0 - Error
            '1 - Successful

        End Function

#End Region

    End Class

End Namespace


