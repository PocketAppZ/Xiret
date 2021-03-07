'  Updated on 27.03.2020 - DS (Update to new code)

Imports System.Windows.Forms.Design

Namespace Gambol.Controls.Design
    Public Class GambolRadioButtonDesigner
        Inherits ControlDesigner

        Protected Overrides Sub PreFilterProperties(ByVal Properties As IDictionary)

            Dim PropList As List(Of String) = New List(Of String) From {
                "Appearance",
                "BackgroundImage",
                "BackgroundImageLayout",
                "CheckAlign",
                "FlatAppearance",
                "FlatStyle",
                "Image",
                "ImageAlign",
                "ImageIndex",
                "ImageKey",
                "ImageList",
                "RightToLeft",
                "TextAlign",
                "TextImageRelation",
                "UseVisualStyleBackColor",
                "Padding",
                "AutoEllipsis"
            }

            If Properties IsNot Nothing Then
                For Each Item As String In PropList
                    Properties.Remove(Item)
                Next
            End If

            MyBase.PreFilterProperties(Properties)

        End Sub

    End Class

End Namespace



