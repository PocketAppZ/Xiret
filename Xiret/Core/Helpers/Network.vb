'  Updated on 07.08.2019 - DS (Cleanup)

Imports System.Net

Namespace Core.Helpers

    NotInheritable Class NetHelper
        Friend Shared Function IsWebsiteAvailable(WebAddress As String) As Boolean

            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            Try

                Dim Request As WebRequest
                Dim Response As WebResponse
                Request = WebRequest.Create(WebAddress)
                Request.Timeout = 10000
                Response = Request.GetResponse()
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

End Namespace


