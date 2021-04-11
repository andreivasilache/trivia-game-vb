Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class QuestionsHTTPService

    Dim webClient As New System.Net.WebClient

    Private currentQuestion As String
    Private answers As New List(Of String)
    Private correctAnswer As String
    Private currentCategory As String
    Private r As Object

    Public Function fetchNewData()
        answers.Clear()

        Dim endpoint = "https://opentdb.com/api.php?amount=1&difficulty=easy&type=multiple"
        Dim rawRes As String = webClient.DownloadString(endpoint)
        Dim JSONresponse = JObject.Parse(rawRes)
        Dim data As List(Of JToken) = JSONresponse.Children().ToList

        For Each item As JProperty In data
            item.CreateReader()
            Select Case item.Name
                Case "results"
                    For Each result As JObject In item.Values
                        currentCategory = result("category")
                        currentQuestion = result("question")
                        Dim correctAns As String = result("correct_answer")
                        correctAnswer = correctAns
                        answers.Add(correctAnswer)


                        For Each wrongAnswer As String In result("incorrect_answers")
                            answers.Add(wrongAnswer)
                            '  Console.WriteLine(wrongAnswer.ToString())

                        Next
                        ShuffleAnswers()
                    Next
            End Select
        Next
        '  Console.WriteLine(correctAnswer.ToString())

    End Function

    Private Function Shuffle(ByVal item As List(Of String)) As List(Of String)
        Dim exclusive() As Integer = Enumerable.Range(0, item.Count).OrderBy(Function(n) r.Next(item.Count + 1)).ToArray()
        Dim shuffled As List(Of String) = New List(Of String)

        Array.ForEach(exclusive, Sub(e) shuffled.Add(item(e)))

        Return shuffled
    End Function

    Public Function ShuffleAnswers()
        Dim rnd As New System.Random
        Dim MyRandomArray = answers.ToArray().OrderBy(Function() rnd.Next()).ToArray()
        answers = MyRandomArray.ToList()
    End Function

    Public Function getCategory()
        Return currentCategory
    End Function

    Public Function getQuestion()
        Return currentQuestion
    End Function

    Public Function getAnswer(index As Integer) As String
        Return answers.ElementAt(index)
    End Function

    Public Function isCurrectAnswer(toBeChecked As String) As Boolean
        Return toBeChecked = correctAnswer
    End Function

    Public Function indexOfCurrentAnswer() As Integer
        Return answers.IndexOf(correctAnswer)
    End Function

End Class
