'  Updated on 15.07.2019 - DS (Move DHGetApplicationImage())

Imports System.IO
Imports System.Text

Namespace Core.Helpers

    NotInheritable Class DirectoryHelper
        Public Shared Function GetApplicationPath() As String
            Dim Builder As New StringBuilder(255)
            NativeMethods.GetModuleFileName(IntPtr.Zero, Builder, Builder.Capacity)
            Dim Info As New FileInfo(Builder.ToString())
            Return Info.Directory.FullName
        End Function

    End Class

End Namespace





