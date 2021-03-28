

Public Class FontsCore
    Public Enum local_fonts_ENUM
        roboto_medium = 0
        roboto_bold = 1
        roboto_thin = 2
        roboto_regular = 3
    End Enum

    Private Class LocalFont
        Public key As String
        Public name As local_fonts_ENUM
        Public bytes As Byte()
        Public font_style As System.Drawing.FontStyle
        Public Sub New(params_key As String, param_name As local_fonts_ENUM, param_location As Byte(), param_font_style As System.Drawing.FontStyle)
            key = params_key
            bytes = param_location
            name = param_name
            font_style = param_font_style
        End Sub

    End Class

    Private loadedFonts As New Dictionary(Of String, Drawing.Text.PrivateFontCollection)
    Public Sub New()
        LoadLocalFonts()
    End Sub

    Private Function LoadLocalFonts()
        Dim fonts = {
          New LocalFont("roboto_bold", local_fonts_ENUM.roboto_bold, My.Resources.Roboto_Bold, System.Drawing.FontStyle.Bold),
          New LocalFont("roboto_medium", local_fonts_ENUM.roboto_medium, My.Resources.Roboto_Medium, System.Drawing.FontStyle.Regular),
          New LocalFont("roboto_thin", local_fonts_ENUM.roboto_thin, My.Resources.Roboto_Thin, System.Drawing.FontStyle.Regular),
          New LocalFont("roboto_regular", local_fonts_ENUM.roboto_regular, My.Resources.Roboto_Regular, System.Drawing.FontStyle.Regular)
    }

        For index = 0 To UBound(fonts)
            Dim currentFont = fonts(index)
            Dim lstPrivateFontCollection As New System.Drawing.Text.PrivateFontCollection()

            Dim objPointer As IntPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(currentFont.bytes.Length)

            System.Runtime.InteropServices.Marshal.Copy(currentFont.bytes, 0, objPointer, currentFont.bytes.Length)

            lstPrivateFontCollection.AddMemoryFont(objPointer, currentFont.bytes.Length)
            loadedFonts.Add(currentFont.key, lstPrivateFontCollection)
        Next
    End Function

    Public Function getFont(fontEnum As local_fonts_ENUM, size As Single, style As FontStyle) As Font
        Dim choosedFont = loadedFonts.Values(fontEnum)
        Return New Font(choosedFont.Families(0), size, style)
    End Function

End Class

