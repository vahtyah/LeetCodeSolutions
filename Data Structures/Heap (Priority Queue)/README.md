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

## PriorityQueue Customization
```csharp
public unsafe class UnsafePriorityQueue<TElement, TPriority> : IDisposable 
    where TElement : unmanaged 
    where TPriority : unmanaged, IComparable<TPriority>
{
    private struct Node
    {
        public TElement Element;
        public TPriority Priority;
    }
    
    private Node* _heap;
    private int _count;
    private int _capacity;
    
    public UnsafePriorityQueue(int capacity = 16)
    {
        _capacity = capacity;
        _heap = (Node*)System.Runtime.InteropServices.Marshal.AllocHGlobal(capacity * sizeof(Node));
        _count = 0;
    }
    
    public int Count => _count;
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void Enqueue(TElement element, TPriority priority)
    {
        if (_count == _capacity)
            Resize();
            
        _heap[_count] = new Node { Element = element, Priority = priority };
        SiftUp(_count);
        _count++;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public TElement Dequeue()
    {
        TElement result = _heap[0].Element;
        _count--;
        
        if (_count > 0)
        {
            _heap[0] = _heap[_count];
            SiftDown(0);
        }
        
        return result;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public TElement Peek() => _heap[0].Element;
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private void SiftUp(int index)
    {
        Node item = _heap[index];
        
        while (index > 0)
        {
            int parentIndex = (index - 1) >> 1;
            Node parent = _heap[parentIndex];
            
            if (item.Priority.CompareTo(parent.Priority) >= 0)
                break;
                
            _heap[index] = parent;
            index = parentIndex;
        }
        
        _heap[index] = item;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private void SiftDown(int index)
    {
        Node item = _heap[index];
        int halfCount = _count >> 1;
        
        while (index < halfCount)
        {
            int childIndex = (index << 1) + 1;
            Node child = _heap[childIndex];
            int rightChildIndex = childIndex + 1;
            
            if (rightChildIndex < _count && _heap[rightChildIndex].Priority.CompareTo(child.Priority) < 0)
            {
                childIndex = rightChildIndex;
                child = _heap[childIndex];
            }
            
            if (item.Priority.CompareTo(child.Priority) <= 0)
                break;
                
            _heap[index] = child;
            index = childIndex;
        }
        
        _heap[index] = item;
    }
    
    private void Resize()
    {
        _capacity *= 2;
        _heap = (Node*)System.Runtime.InteropServices.Marshal.ReAllocHGlobal((IntPtr)_heap, (IntPtr)(_capacity * sizeof(Node)));
    }
    
    public void Dispose()
    {
        if (_heap != null)
        {
            System.Runtime.InteropServices.Marshal.FreeHGlobal((IntPtr)_heap);
            _heap = null;
        }
    }
    
    ~UnsafePriorityQueue() => Dispose();
}
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0215. Kth Largest Element in an Array](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F0215.%20Kth%20Largest%20Element%20in%20an%20Array): Find the kth largest element in an array

[1353. Maximum Number of Events That Can Be Attended](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F1353.%20Maximum%20Number%20of%20Events%20That%20Can%20Be%20Attended): Maximize attending events with deadlines, one event per day

[3066. Minimum Operations to Exceed Threshold Value II](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F3066.%20Minimum%20Operations%20to%20Exceed%20Threshold%20Value%20II): Minimize operations needed to reach threshold by adding numbers

[3362. Zero Array Transformation III](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F3362.%20Zero%20Array%20Transformation%20III): Make target array all zeros by element transfers

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0502. IPO](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F0502.%20IPO): Maximize capital by strategically investing in projects

[2163. Minimum Difference in Sums After Removal of Elements](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F2163.%20Minimum%20Difference%20in%20Sums%20After%20Removal%20of%20Elements): Minimize difference between two sub-arrays after removing n elements

[2402. Meeting Rooms III](/Data%20Structures%2FHeap%20%28Priority%20Queue%29%2F2402.%20Meeting%20Rooms%20III): Maximize meeting attendance across multiple rooms
