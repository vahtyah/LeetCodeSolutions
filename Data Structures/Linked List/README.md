# Data Structures/Linked List

A **linked list** is a linear data structure where elements are stored in nodes. Each node contains a value and a reference to the next node in the sequence. The last node points to `null`, indicating the end of the list.

## Key Concepts

1. **Singly Linked List:** Each node points to the next node in the sequence.
2. **Doubly Linked List:** Each node points to the next and previous nodes in the sequence.
3. **Circular Linked List:** The last node points back to the first node, forming a circular structure.
4. **Head and Tail:** The head points to the first node, and the tail points to the last node in the list.
5. **Traversal:** Iterating through the list to access or modify elements.


## C# Implementation

```csharp
public class ListNode
{
    public int Val;
    public ListNode Next;

    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0061. Rotate List](/Data%20Structures%2FLinked%20List%2F0061.%20Rotate%20List): Rotate a linked list by a given number of steps

[0092. Reverse Linked List II](/Data%20Structures%2FLinked%20List%2F0092.%20Reverse%20Linked%20List%20II): Reverse a sublist of a linked list in place

[0138. Copy List with Random Pointer](/Data%20Structures%2FLinked%20List%2F0138.%20Copy%20List%20with%20Random%20Pointer): Clone a linked list with random pointers
