Imports System.Runtime.InteropServices

Public Class Main
    Private localFontsInstance As FontsCore
    Private questionServiceInstance As QuestionsService


    Private Function LoadUIFonts()
        points_label.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 10, FontStyle.Regular)
        lifes_label.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 10, FontStyle.Regular)
    End Function

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        localFontsInstance = New FontsCore()
        Timer1.Interval = 1000
        LoadUIFonts()
        Timer1.Start()
        questionServiceInstance = New QuestionsService()
        LoadQuestions()
    End Sub

    Private Function LoadQuestions()
        questionServiceInstance.fetchNewData()
    End Function

    Private Sub Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawProgress(e.Graphics, New Rectangle(150, 40, 100, 100), StoreInstance.instance.getCurrentNumberOfSeconds(), 60)
        points_label.Text = "Points:" + Str(StoreInstance.instance.getPoints())
        lifes_label.Text = "Lifes:" + Str(StoreInstance.instance.getRemainingLifes())

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StoreInstance.instance.decreaseNumberOfSeconds()
        Invalidate()
    End Sub

    Private Sub DrawProgress(g As Graphics, rect As Rectangle, percentage As Single, maxPercentage As Single)
        'work out the angles for each arc
        Dim progressAngle = CSng(360 / maxPercentage * percentage)
        Dim remainderAngle = 360 - progressAngle

        'create pens to use for the arcs
        Dim progressCollor = Color.FromArgb(255, 72, 52)
        Using progressPen As New Pen(progressCollor, 2), remainderPen As New Pen(Color.LightGray, 2)
            'set the smoothing to high quality for better output
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            'draw the blue and white arcs
            g.DrawArc(progressPen, rect, -90, progressAngle)
            g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle)
        End Using

        'draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
        Using fnt As New Font(Me.Font.FontFamily, 14)
            Dim text As String = percentage.ToString + "s"
            Dim textSize = g.MeasureString(text, fnt)
            Dim textPoint As New Point(CInt(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), CInt(rect.Top + (rect.Height / 2) - (textSize.Height / 2)))
            'now we have all the values draw the text
            g.DrawString(text, fnt, Brushes.Black, textPoint)
        End Using
    End Sub


End Class
