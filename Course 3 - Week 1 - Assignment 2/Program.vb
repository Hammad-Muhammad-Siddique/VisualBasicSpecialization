Imports System

Module Program
    Sub Main(args As String())
        Dim mySum As Decimal
        Dim inValue As Integer
        Dim count As Integer
        Do
            inValue = CInt(Console.ReadLine())
            mySum += inValue
            count += 1
        Loop Until inValue = -1

        Console.WriteLine(((mySum + 1) / (count - 1)).ToString("N"))
    End Sub
End Module