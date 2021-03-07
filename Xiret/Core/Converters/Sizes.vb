'  Updated on 16.10.2019 - DS (Cleanup, removed region)

Namespace Core.Converters

    NotInheritable Class SizeConverter

        Public Shared Function ConvertBigSize(ByVal Data As Double) As String

            Dim dbl As Double

            Try
                Select Case Data
                    Case Is >= 1099511627776
                        dbl = Data / 1099511627776 'TB
                        Return FormatNumber(dbl, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        dbl = Data / 1073741824 'GB
                        Return FormatNumber(dbl, 2) & " GB"
                        'Return Format(dbl, "########0") & " GB"
                    Case 1048576 To 1073741823
                        dbl = Data / 1048576 'MB
                        Return FormatNumber(dbl, 2) & " MB"
                    Case 1024 To 1048575
                        dbl = Data / 1024 'KB
                        Return FormatNumber(dbl, 2) & " KB"
                    Case 0 To 1023
                        dbl = Data
                        Return FormatNumber(dbl, 2) & " bytes"
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try

        End Function

        Public Shared Function BytesToMBSquared(SizeIn As Double) As String

            Dim SizeOut As Double = SizeIn / Math.Pow(1024, 2)
            Return Format(SizeOut, "########0.00")

        End Function

    End Class

End Namespace


