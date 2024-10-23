Module Module1
    Class InhMod
        Public Function facto(val As Integer) As Integer
            If val <= 1 Then
                Return 1
            Else
                Return val * facto(val - 1)
            End If
        End Function
    End Class

    Class DervMod
        Inherits InhMod
        Public Sub printFact(val As Integer)
            Dim res As Integer = facto(val)
            Console.WriteLine("Factorial of " & val & " is " & res)
        End Sub
    End Class

    Sub Main()
        Dim factObj As New DervMod()
        Dim number As Integer = 5

        factObj.printFact(number)
        Console.ReadLine()
    End Sub
End Module