Imports System

Module Program
    Sub Main(args As String())
        Dim thisDateTime As Date = DateTime.Now
        Dim inValue As Integer
        inValue = CInt(Console.ReadLine())
        thisDateTime = thisDateTime.AddDays(inValue)
        Console.WriteLine(String.Format("{0:dddd, MMMM dd, yyyy}", thisDateTime))
    End Sub
End Module
