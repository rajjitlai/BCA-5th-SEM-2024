Imports System

Module Program
    Sub Main()
        Dim list As ArrayList = New ArrayList()
        list.Add("Hello")
        list.Add("This")
        list.Add("is")
        list.Add("BCA")
        list.Add(5)
        list.Add("th")
        list.Add("Sem")
        list.Add("Assignment,")
        list.Add(2024)

        Console.Write("Notice (in ArrayList): ")
        For Each item In list
            Console.WriteLine(item)
        Next
        Console.ReadKey()
    End Sub
End Module
