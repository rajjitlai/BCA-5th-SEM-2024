Imports System

Module Program
    Public Class FirstData
        Protected length As Single
        Protected breadth As Single

        Public Sub SetDim1(l As Single)
            length = l
        End Sub
    End Class

    Public Class SecondData
        Inherits FirstData

        Public Sub SetDim2(b As Single)
            breadth = b
        End Sub
    End Class

    Public Class Rectangle
        Inherits SecondData

        Public Function GetArea() As Single
            Return length * breadth
        End Function
    End Class

    Sub Main()
        Dim data As New Rectangle()
        data.SetDim1(22)
        data.SetDim2(10)
        Console.WriteLine("The area of the rectangle is: {0}", data.GetArea())
        Console.ReadKey()
    End Sub
End Module
