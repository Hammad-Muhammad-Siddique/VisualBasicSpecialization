Imports System

Module Program
    Sub Main(args As String())
        Dim myBMI = New BMI()
        myBMI.Height = 1.5
        myBMI.Weight = 50
        Console.WriteLine(myBMI.BMI_Value())
    End Sub
End Module
