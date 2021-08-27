Imports System

Module Program
    Sub Main(args As String())
        Dim inValue As String = Console.ReadLine()
        Dim inValueInt = CInt(inValue)
        Console.WriteLine(FormatNumber(Math.Round(inValueInt / 3, 3), 3))
    End Sub
End Module
