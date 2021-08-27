Imports System

Module Program
    Sub Main(args As String())
        Dim number As Integer
        number = Console.ReadLine
        If number > 200 Then
            Console.WriteLine("Large")
        ElseIf number < 100 Then
            Console.WriteLine("Small")
        Else
            Console.WriteLine("Medium")
        End If
    End Sub
End Module
