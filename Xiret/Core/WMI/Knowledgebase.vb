'  Updated on 14.04.2020 - DS (Switch List<T> to HashSet<T>, lose CheckFor())

Imports System.Management

Namespace Core.WMI

    NotInheritable Class Knowledgebase

        Friend Shared Function EnumerateHotfixes() As HashSet(Of String)

            Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT HotFixID FROM Win32_QuickFixEngineering")
            Dim Updates As New HashSet(Of String)()

            Try
                For Each Obj As ManagementObject In Searcher.Get() 'Shuffle through items in QuickFixEngineering
                    Dim ObjString As String = Obj.GetPropertyValue("HotFixID").ToString
                    Updates.Add(ObjString)
                Next
                Searcher.Dispose()
                Return Updates
            Catch ex As Exception
                MessageBox.Show("Could not iterate objects." & vbCrLf & ex.Message, "Xiret.WMI.Knowldgebase.ListAllHotfixes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

    End Class

End Namespace

