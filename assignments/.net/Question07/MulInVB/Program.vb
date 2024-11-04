Imports System

Namespace MulInVB
    Interface IPrintable
        Sub Print(course As String)
    End Interface

    Interface IDisplayable
        Sub Display(duration As Integer)
    End Interface

    Class Document
        Implements IPrintable, IDisplayable

        Public Sub Print(course As String) Implements IPrintable.Print
            Console.WriteLine("The name of the course is: {0}", course)
        End Sub

        Public Sub Display(duration As Integer) Implements IDisplayable.Display
            Console.WriteLine("The duration of the course is: {0} years", duration)
        End Sub
    End Class

    Module Program
        Sub Main()
            Dim doc As New Document()
            doc.Print("BCA")
            doc.Display(4)

            Console.ReadKey()
        End Sub
    End Module
End Namespace
