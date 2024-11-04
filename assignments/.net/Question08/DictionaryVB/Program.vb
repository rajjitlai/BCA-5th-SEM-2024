Module Program
    Sub Main()
        Dim WordCollection As New Dictionary(Of String, String)
        WordCollection.Add("Function", "A block of code that performs a specific task")
        WordCollection.Add("Variable", "A named storage location used to store data")
        WordCollection.Add("Loop", "A control structure that repeats a block of code a certain number of times or until a certain condition is met")
        WordCollection.Add("Class", "A blueprint or template for creating objects")
        WordCollection.Add("Object", "An instance of a class")

        Console.WriteLine("Some meanings: ")
        For Each data As KeyValuePair(Of String, String) In WordCollection
            Console.WriteLine("Key: {0}, Value: {1}", data.Key, data.Value)
        Next

        Dim RollNo As New Dictionary(Of Integer, String) From {{1, "Ram"}, {2, "Raju"}, {3, "Akash"}}

        Console.WriteLine(" ")

        Console.WriteLine("Some Roll Nos.: ")
        For Each info As KeyValuePair(Of Integer, String) In RollNo
            Console.WriteLine("Key: {0}, Value: {1}", info.Key, info.Value)
        Next


        Console.ReadKey()
    End Sub
End Module