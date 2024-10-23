Module Module1
    Class Rectangle
        Public Length As Integer
        Public Width As Integer

        Public Sub SetValues(len As Integer, wid As Integer)
            Length = len
            Width = wid
        End Sub

        Public Function CalculateArea() As Integer
            Return Length * Width
        End Function
    End Class

    Class Square
        Inherits Rectangle

        Public Function CalculateSquareArea() As Integer
            Return Length * Length
        End Function
    End Class

    Sub Main()
        Dim rect As New Rectangle()
        rect.SetValues(5, 10)
        Console.WriteLine("Area of Rectangle: " & rect.CalculateArea())

        Dim sqr As New Square()
        sqr.Length = rect.Length
        Console.WriteLine("Area of Square (using length from base): " & sqr.CalculateSquareArea())

        Console.ReadLine()
    End Sub
End Module
