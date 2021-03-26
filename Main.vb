Imports System.Runtime.InteropServices

Public Class Main
    Private localFontsInstance As FontsCore
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        localFontsInstance = New FontsCore()

        Label1.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 15, FontStyle.Regular)
    End Sub

End Class
