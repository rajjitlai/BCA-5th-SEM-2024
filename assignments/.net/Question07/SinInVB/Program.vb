Imports System

Namespace SinInVB
    Interface ICourse
        Sub PrintCourseName(course As String)
        Sub DisplayCourseDuration(duration As Integer)
    End Interface

    Class Document
        Implements ICourse

        Public Sub PrintCourseName(course As String) Implements ICourse.PrintCourseName
            Console.WriteLine("The name of the course is: {0}", course)
        End Sub

        Public Sub DisplayCourseDuration(duration As Integer) Implements ICourse.DisplayCourseDuration
            Console.WriteLine("The duration of the course is: {0} years", duration)
        End Sub
    End Class

    Module Program
        Sub Main()
            Dim doc As New Document()
            doc.PrintCourseName("BCA")
            doc.DisplayCourseDuration(4)

            Console.ReadKey()
        End Sub
    End Module
End Namespace
