Imports System.Runtime.InteropServices

Public Class Main
    Private localFontsInstance As FontsCore
    Private questionServiceInstance As QuestionsHTTPService
    '  Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Function LoadUIFonts()
        points_label.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 10, FontStyle.Regular)
        lifes_label.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_thin, 10, FontStyle.Regular)
        category.Font = localFontsInstance.getFont(FontsCore.local_fonts_ENUM.roboto_medium, 11, FontStyle.Regular)

    End Function

    Private Function InjectOnClickButtonHandler()
        For Each b As Button In Me.Controls.OfType(Of Button)
            AddHandler b.Click, AddressOf HandleButtonClick
        Next
    End Function


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        localFontsInstance = New FontsCore()
        Timer1.Interval = 1000
        LoadUIFonts()
        InjectOnClickButtonHandler()
        Timer1.Start()
        questionServiceInstance = New QuestionsHTTPService()
        LoadQuestions()
    End Sub


    Private Function updateCoreView()
        question.Text = questionServiceInstance.getQuestion()
        category.Text = "Category: " + questionServiceInstance.getCategory()
        option_1.Text = questionServiceInstance.getAnswer(0)
        option_2.Text = questionServiceInstance.getAnswer(1)
        option_3.Text = questionServiceInstance.getAnswer(2)
        option_4.Text = questionServiceInstance.getAnswer(3)
    End Function

    Private Function LoadQuestions()
        questionServiceInstance.fetchNewData()
        updateCoreView()
    End Function

    Private Function DelayWithTimer(delay As Integer, action As Action)
        Dim localTimer = New System.Windows.Forms.Timer()
        localTimer.Interval = delay
        AddHandler localTimer.Tick,
        Sub()
            action.Invoke()
            localTimer.Enabled = False
            localTimer.Dispose()
        End Sub
        localTimer.Enabled = True
    End Function



    Private toBeDisplayedMessage = ""
    Private Sub Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawProgress(e.Graphics, New Rectangle(150, 40, 100, 100), StoreInstance.instance.getCurrentNumberOfSeconds(), 60, toBeDisplayedMessage)
        points_label.Text = "Points:" + Str(StoreInstance.instance.getPoints())
        lifes_label.Text = "Lifes:" + Str(StoreInstance.instance.getRemainingLifes())
    End Sub


    Private Function onUIReload()
        ' Sleep(1000)
        LoadQuestions()
        toBeDisplayedMessage = ""
    End Function


    Private Function HandleButtonClick(sender As Object, e As EventArgs)
        If (questionServiceInstance.isCurrectAnswer(sender.text)) Then
            StoreInstance.instance.increaseNumberOfPoints()
            toBeDisplayedMessage = "Correct!"
            onUIReload()
        Else
            If (StoreInstance.instance.decreaseNumberOfLifes()) Then
                toBeDisplayedMessage = "Wrong!"
                onUIReload()
            Else
                onGameOver()
            End If

        End If
    End Function

    Private Function onGameOver()
        toBeDisplayedMessage = "Game over!"
        Timer1.Stop()
        Invalidate()
    End Function

    Private Function onTimeExpire()
        If (Not StoreInstance.instance.decreaseNumberOfLifes()) Then
            onGameOver()
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (StoreInstance.instance.decreaseNumberOfSeconds()) Then
            'Invalidate is used to refresh de UI
            Invalidate()
        Else
            onTimeExpire()
        End If

    End Sub

    Private Sub DrawProgress(g As Graphics, rect As Rectangle, percentage As Single, maxPercentage As Single, Optional insideText As String = "")
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
            Dim text As String
            If insideText = "" Then
                text = percentage.ToString + "s"
            Else
                text = insideText
            End If


            Dim textSize = g.MeasureString(text, fnt)
            Dim textPoint As New Point(CInt(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), CInt(rect.Top + (rect.Height / 2) - (textSize.Height / 2)))
            'now we have all the values draw the text
            g.DrawString(text, fnt, Brushes.Black, textPoint)
        End Using
    End Sub

End Class
