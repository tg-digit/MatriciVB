Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("*** Elenco età viaggiatori ***")

        Dim names() As String = {"Bruno", "Diego", "Damiano", "Abreham"}
        Dim ages() As Integer = {40, 36, 23, 38}

        For i As Integer = 0 To ages.Length - 1
            Console.WriteLine(names(i))
            Console.WriteLine(ages(i))

        Next i

    End Sub
End Module

'
