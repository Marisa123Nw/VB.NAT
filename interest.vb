Imports System
Module inteerest
    Public deposit, rate As Double
    Sub Main()
        Dim Year1, year2 As Double

        rate = 0.02
        deposit = 10000

        Year1 = deposit * (1 + rate)
        REM Console.WriteLine("First year = {0}", Year1)
        year2 = Year1 * (1 + rate)
        Console.WriteLine("Second year = {0:c}", year2)
        Console.ReadLine()
    End Sub

End Module
