Public Class LandingPage
    Private localFontsInstance As FontsCore

    Private Function loadFonts()
        title.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_medium, 30, FontStyle.Bold)
        subtitle.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 20, FontStyle.Bold)
        subtitle1.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 20, FontStyle.Bold)

        button_easy.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_bold, 12, FontStyle.Regular)
        button_medium.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_bold, 12, FontStyle.Regular)
        button_hard.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_bold, 12, FontStyle.Regular)
    End Function

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        localFontsInstance = New FontsCore()
        loadFonts()

        For Each b As Button In Me.Controls.OfType(Of Button)
            AddHandler b.Click, AddressOf HandleButtonClick
        Next
    End Sub

    Function HandleButtonClick(sender As Object, e As EventArgs)
        Select Case sender.name
            Case "button_easy"
                StoreInstance.instance.updateDifficulty(DifficultiesENUM.easy)
            Case "button_medium"
                StoreInstance.instance.updateDifficulty(DifficultiesENUM.medium)
            Case "button_hard"
                StoreInstance.instance.updateDifficulty(DifficultiesENUM.hard)
        End Select

        Me.Hide()
        ' create new instance in order to 'load' method be called
        Using mainForm As New Main
            mainForm.ShowDialog()
        End Using

    End Function

End Class