'  Created by David S On 30.01.2020

Imports System.Reflection

Friend Class Signing

    Shared Sub New()
        VerifySignature(Assembly.GetCallingAssembly())
    End Sub

    Private Shared Sub VerifySignature(App As Assembly)
        Dim IsSigVerified As Boolean
        If Not NativeMethods.StrongNameSignatureVerificationEx(App.Location, True, IsSigVerified) AndAlso Not IsSigVerified Then
            Environment.Exit(0)
        End If
    End Sub

End Class
