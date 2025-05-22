# Data Structures/Heap (Priority Queue)

The heap data structure, often referred to as a priority queue, is a binary tree-based data structure that satisfies the heap property. The heap property states that the key of a node is either greater than or equal to (max heap) or less than or equal to (min heap) the keys of its children. This property ensures that the root node of the heap is either the maximum or minimum element, depending on the type of heap.

## C# Key Points

### Priority Queue Initialization

```csharp
PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
```

### Adding Elements

```csharp
heap.Enqueue(5, 10); // Add an element with priority 5 and value 10
```

### Removing Elements

```csharp
int value = heap.Dequeue(); // Remove and return the element with the highest priority
```

### Checking if the Priority Queue is Empty

```csharp
if (heap.Count == 0)
{
    // Priority queue is empty
}
```

### Accessing the Element with the Highest Priority

```csharp
int value = heap.Peek(); // Get the element with the highest priority
```

### Priority Queue Methods

- `Enqueue`: Adds an element with a specified priority to the priority queue.
- `Dequeue`: Removes and returns the element with the highest priority from the priority queue.
- `Peek`: Returns the element with the highest priority from the priority queue without removing it.
- `Count`: Returns the number of elements in the priority queue.
- `Clear`: Removes all elements from the priority queue.
- `Contains`: Checks if the priority queue contains a specific element.
- `UpdatePriority`: Updates the priority of an element in the priority queue.
- `TryDequeue`: Tries to remove and return the element with the highest priority.
- `TryPeek`: Tries to return the element with the highest priority without removing it.
- `TryUpdatePriority`: Tries to update the priority of an element in the priority queue.
- `ToArray`: Converts the priority queue to an array of elements.
- `ToList`: Converts the priority queue to a list of elements.
- `CopyTo`: Copies the elements of the priority queue to an array.
- `GetEnumerator`: Returns an enumerator that iterates through the priority queue.
- `ToString`: Returns a string that represents the priority queue.
- `TrimExcess`: Sets the capacity of the priority queue to the actual number of elements it contains.
- `UpdatePriority`: Updates the priority of an element in the priority queue.
- `UpdateValue`: Updates the value of an element in the priority queue.
- `Update`: Updates the priority and value of an element in the priority queue.
- `TryUpdate`: Tries to update the priority and value of an element in the priority queue.
- `TryUpdateValue`: Tries to update the value of an element in the priority queue.
- `TryUpdatePriority`: Tries to update the priority of an element in the priority queue.
- `TryAdd`: Tries to add an element with a specified priority and value to the priority queue.
- `TryGetValue`: Tries to get the value associated with the specified priority.
- `TryRemove`: Tries to remove and return the element with the highest priority.


## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[3066. Minimum Operations to Exceed Threshold Value II](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F3066.%20Minimum%20Operations%20to%20Exceed%20Threshold%20Value%20II): Minimize operations needed to reach threshold by adding numbers

[3362. Zero Array Transformation III](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F3362.%20Zero%20Array%20Transformation%20III): Make target array all zeros by element transfers
