Imports System

Module ConstrucVB
    Class Program
        Public Sub New()
            Dim id As Integer = 101
            Dim name As String = "John Doe"
            Console.WriteLine("The Default constructor is called")
            Console.WriteLine("ID is {0} and name is {1}", id, name)
        End Sub

        Public Sub New(i As Integer, n As String)
            Console.WriteLine(" ")
            Console.WriteLine("The Parameterized constructor is called")
            Console.WriteLine("ID is {0} and name is {1}", i, n)
        End Sub
    End Class

    Sub Main()
        Dim data As New Program()
        Dim data2 As New Program(202, "Jane Doe")
        Console.ReadKey()
    End Sub
End Module
