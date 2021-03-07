'  Updated on 14.07.2019 - DS (Integrate ToastType enum, update variables)
'  Updated on 31.07.2019 - DS (General cleanup and improvements)

Imports System.Linq

Friend Class ToastAlert

    Friend Shared AlertMessage As String = ""
    Friend Shared AlertType As ToastType
    Friend Shared BoolCancelCurrentToast As Boolean = False

    Friend Shared Sub Show(AlertText As String, Type As ToastType)

        AlertMessage = AlertText
        AlertType = Type

        If Application.OpenForms().OfType(Of FormToast).Any Then
            BoolCancelCurrentToast = True
            FormToast.Close()
            FormToast.Show()
        Else
            BoolCancelCurrentToast = False
            FormToast.Show()
        End If

        BoolCancelCurrentToast = False

    End Sub

End Class


