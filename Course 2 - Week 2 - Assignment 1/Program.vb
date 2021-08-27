Imports System

Module Program
    Sub Main(args As String())
        Dim inValue As String
        inValue = Console.ReadLine()
        Dim inValueDec As Decimal
        inValueDec = CDec(inValue)
        Console.WriteLine(FormatNumber(inValueDec, 2))
    End Sub
End Module
