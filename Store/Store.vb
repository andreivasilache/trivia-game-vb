﻿Public Enum DifficultiesENUM
    easy
    medium
    hard
End Enum

Public Class Store
    Private currentDifficulty = DifficultiesENUM.easy
    Private currentPoints As Integer = 0
    Private remainedLifes As Integer = 0
    Private numberOfSeconds As Integer = 0

    Private Function getLevelNumberOfSecondsByDifficulty(difficulty As DifficultiesENUM) As Integer
        Select Case difficulty
            Case DifficultiesENUM.easy
                Return 60
            Case DifficultiesENUM.medium
                Return 45
            Case DifficultiesENUM.hard
                Return 30
        End Select
    End Function

    Private Function getLevelNumberOfLifes(difficulty As DifficultiesENUM) As Integer
        Select Case difficulty
            Case DifficultiesENUM.easy
                Return 4
            Case DifficultiesENUM.medium
                Return 3
            Case DifficultiesENUM.hard
                Return 2
        End Select
    End Function


    Public Function updateDifficulty(newDifficulty As DifficultiesENUM)
        currentDifficulty = newDifficulty
        numberOfSeconds = getLevelNumberOfSecondsByDifficulty(newDifficulty)
        remainedLifes = getLevelNumberOfLifes(newDifficulty)
    End Function

    Public Function getCurrentNumberOfSeconds() As Integer
        Return numberOfSeconds
    End Function

    Public Function decreaseNumberOfSeconds() As Integer
        numberOfSeconds = numberOfSeconds - 1
    End Function

    Public Function resetPoints()
        currentPoints = 0
    End Function

    Public Function getPoints() As Integer
        Return currentPoints
    End Function

    Public Function getDifficulty() As DifficultiesENUM
        Return currentDifficulty
    End Function

    Public Function getRemainingLifes() As Integer
        Return remainedLifes
    End Function

End Class
