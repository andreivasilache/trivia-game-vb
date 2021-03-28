Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class QuestionsService

    Dim webClient As New System.Net.WebClient

    Private currentQuestions As String
    Private wrongAnswers(3) As String
    Private currentAnswer As String
    Private currentCategory As String

    Public Function fetchNewData()
        Dim rawRes As String = webClient.DownloadString("https://opentdb.com/api.php?amount=1&difficulty=easy&type=multiple")
        Dim JSONresponse = JObject.Parse(rawRes)
        Dim data As List(Of JToken) = JSONresponse.Children().ToList

        For Each item As JProperty In data
            item.CreateReader()
            Select Case item.Name
                Case "results"

                    For Each result As JObject In item.Values
                        Dim cat As String = result("category")
                        Dim quest As String = result("question")
                        Dim correctAns As String = result("correct_answer")
                        Console.WriteLine(cat)
                        Console.WriteLine(quest)
                        Console.WriteLine(correctAns)

                        ' Todo: cast to array of strings
                        Dim incorrectAns As String() = result("incorrect_answers")
                        Console.WriteLine(incorrectAns)
                    Next

            End Select
        Next
    End Function

End Class
