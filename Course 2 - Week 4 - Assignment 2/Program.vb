Imports System

Module Program
    Sub Main(args As String())
        Dim number As Integer
        Dim sum As Integer
        Do While number <> -1
            number = Console.ReadLine()
            sum = sum + number
        Loop

        If number = -1 Then
            sum = sum + 1
        End If

        Console.WriteLine(sum)

    End Sub
End Module
