Module Module1
    'STACK
    'push - add element to stack
    Sub Push(ByVal Stack_Pointer As Integer, ByVal Max As Integer, ByVal Data As Integer)
        If Stack_Pointer = Max Then
            Console.ReadLine("No Room on Stack")
        Else
            Stack_Pointer = Stack_Pointer + 1
            Stack(Stack_Pointer) = Data
        End If
    End Sub

    'pop - removes most recently added element
    Sub Pop(ByRef Stack_Pointer As Integer, ByRef Min As Integer, ByVal Data As Integer)
        If Stack_Pointer = Min Then
            Console.WriteLine("No data in stack")
        Else
            Data = Stack(Stack_Pointer)
            Stack_Pointer = Stack_Pointer - 1
        End If
    End Sub


End Module
