Imports System

Module Program
    Public Class Shape
        Protected length As Single
        Protected breadth As Single
        Protected height As Single

        Public Sub SetDim(l As Single, b As Single, h As Single)
            length = l
            breadth = b
            height = h
        End Sub
    End Class

    Public Class Cuboid
        Inherits Shape

        Public Function GetVolume() As Single
            Return length * breadth * height
        End Function
    End Class

        Sub Main()
            Dim data As New Cuboid()
            data.SetDim(24, 15, 30)
            Console.WriteLine("The Volume of the Cuboid is {0}", data.GetVolume())
            Console.ReadKey()
        End Sub
End Module