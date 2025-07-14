# Data Structures/Linked List

A **linked list** is a linear data structure where elements are stored in nodes. Each node contains a value and a reference to the next node in the sequence. The last node points to `null`, indicating the end of the list.

## Key Concepts

1. **Singly Linked List:** Each node points to the next node in the sequence.
2. **Doubly Linked List:** Each node points to the next and previous nodes in the sequence.
3. **Circular Linked List:** The last node points back to the first node, forming a circular structure.
4. **Head and Tail:** The head points to the first node, and the tail points to the last node in the list.
5. **Traversal:** Iterating through the list to access or modify elements.

## C# Key features and characteristics of LinkedList<T> Built-in Class

1. Doubly-Linked: Each node has references to both the next and previous nodes.
2. Generic Type: Can store elements of any data type using generics.
3. Main Properties:
    - `First`: Gets the first node in the list.
    - `Last`: Gets the last node in the list.
    - `Count`: Gets the number of elements in the list.
4. Main Methods:
    - `AddFirst(T value)`: Adds a node with the specified value at the beginning of the list.
    - `AddLast(T value)`: Adds a node with the specified value at the end of the list.
    - `AddAfter(LinkedListNode<T> node, T value)`: Adds a node with the specified value after the specified node.
    - `AddBefore(LinkedListNode<T> node, T value)`: Adds a node with the specified value before the specified node.
    - `RemoveFirst()`: Removes the first node from the list.
    - `RemoveLast()`: Removes the last node from the list.
    - `Remove(LinkedListNode<T> node)`: Removes the specified node from the list.
    - `Find(T value)`: Finds the first node that contains the specified value.
    - `Clear()`: Removes all nodes from the list.
    - `Contains(T value)`: Determines whether the list contains a specific value.
5. Performance:
    - **Insertion/Deletion**: O(1) for adding/removing elements at the beginning/end of the list.
    - **Search**: O(n) for finding elements by value.
    - **Memory**: Extra memory is required for storing references to the next and previous nodes.

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[1290. Convert Binary Number in a Linked List to Integer](/Data%20Structures%2FLinked%20List%2F1290.%20Convert%20Binary%20Number%20in%20a%20Linked%20List%20to%20Integer): Convert a binary linked list to its integer value

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0061. Rotate List](/Data%20Structures%2FLinked%20List%2F0061.%20Rotate%20List): Rotate a linked list by a given number of steps

[0092. Reverse Linked List II](/Data%20Structures%2FLinked%20List%2F0092.%20Reverse%20Linked%20List%20II): Reverse a sublist of a linked list in place

[0138. Copy List with Random Pointer](/Data%20Structures%2FLinked%20List%2F0138.%20Copy%20List%20with%20Random%20Pointer): Clone a linked list with random pointers

[0146. LRU Cache](/Data%20Structures%2FLinked%20List%2F0146.%20LRU%20Cache): Design a cache system that evicts least recently used items
