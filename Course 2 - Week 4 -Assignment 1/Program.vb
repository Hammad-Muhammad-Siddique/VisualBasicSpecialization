Imports System

Module Program
    Sub Main(args As String())
        Dim number As Integer = Console.ReadLine()
        Dim sum As Integer
        For i = 1 To number
            sum = sum + i
        Next

        Console.WriteLine(sum)

    End Sub
End Module