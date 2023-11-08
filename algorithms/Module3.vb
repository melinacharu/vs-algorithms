Module Module3
    'LINKED LIST
    'creating a linked list
    Structure ListNode
        Dim Data As String
        Dim Pointer As Integer
    End Structure

    Dim NullPointer = -1
    Dim StartPointer As Integer
    Dim FreeLstPtr As Integer
    Dim List(6) As ListNode

    Sub InitialiseList(ByVal NullPointer As Integer, ByVal StartPointer As Integer, ByVal FreeLstPtr As Integer, ByVal Index As Integer, ByRef List() As ListNode)
        StartPointer = NullPointer
        FreeLstPtr = 1
        For Index = 1 To 6
            List(Index).Pointer = Index + 1
        Next
        List(6).Pointer = NullPointer
    End Sub

    'adding items to a linked list
    Sub InsertNode(ByVal NewItem As String, ByVal ThisNodePtr As Integer, ByVal NewNodePtr As Integer, ByVal PreviousNodePtr As Integer, ByRef List() As ListNode)
        If FreeLstPtr <> NullPointer Then
            NewNodePtr = FreeLstPtr
            List(NewNodePtr).Data = NewItem
            FreeLstPtr = List(FreeLstPtr).Pointer

            ThisNodePtr = StartPointer
            While (ThisNodePtr <> NullPointer) And (List(ThisNodePtr).Data < NewItem)
                PreviousNodePtr = ThisNodePtr
                ThisNodePtr = List(ThisNodePtr).Pointer
            End While

            If PreviousNodePtr = StartPointer Then
                List(NewNodePtr).Pointer = StartPointer
                StartPointer = NewNodePtr
            Else
                List(NewNodePtr).Pointer = List(PreviousNodePtr).Pointer
                List(PreviousNodePtr).Pointer = NewNodePtr
            End If
        End If
    End Sub

    'find an element in a linked list
    Function FindNode() As Integer

    End Function

    'delete an item from a linked list 
    Sub DeleteNode()

    End Sub

End Module