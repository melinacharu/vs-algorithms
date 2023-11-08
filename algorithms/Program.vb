Imports System

Module Program
    'linear list
    Sub Main()
        Dim StudentName() As String = {"Alex", "Bob", "Charles", "David", "Eliza"}
        Dim counter As Integer

        For counter = 0 To 4
            Console.WriteLine(StudentName(counter))
        Next
    End Sub
End Module
