Module Module2
    'QUEUE
    'add data to a queue
    Sub Insert(ByVal Size As Integer, ByRef Start_Pointer As Integer, ByRef Stop_Pointer As Integer, ByVal Data As Integer))
    If (Start_Pointer = 1 And Stop_Pointer = Size) Or (Start_Pointer = Stop_Pointer + 1) Then
            Console.WriteLine("Queue is full")
        End If

        If Start_Pointer = 0 Then
            Start_Pointer = 1
            Stop_Pointer = 1
        ElseIf Stop_Pointer = Size Then
            Stop_Pointer = 1
        Else
            Stop_Pointer = Stop_Pointer + 1
        End If

        Queue(Stop_Pointer) = Data
    End Sub

    'remove data from a queue
    Sub Delete(ByVal Size As Integer, ByRef Start_Pointer As Integer, ByRef Stop_Pointer As Integer, ByVal Data As Integer))
    If Start_Pointer = 0 Then
            Console.WriteLine("Queue is empty")
        Else
            Data = Queue(Start_Pointer)
            If Start_Pointer = Stop_Pointer Then
                Start_Pointer = 0
                Stop_Pointer = 0
            End If

            If Start_Pointer = Size Then
                Start_Pointer = 1
            Else
                Start_Pointer = Start_Pointer + 1
            End If
    End Sub

End Module
