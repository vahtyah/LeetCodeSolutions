namespace LeetCodeSolutions.DataStructures/Heap(PriorityQueue);

/*
 * 1353. Maximum Number of Events That Can Be Attended
 * Difficulty: Medium
 * Submission Time: 2025-07-07 09:20:21
 * Created by vahtyah on 2025-07-07 09:21:20
*/
 
public class Solution {
    public int MaxEvents(int[][] events) {
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

        var minHeap = new UnsafePriorityQueue<int, int>();

        var day = 0;
        var currentEvent = 0;
        var attendedEvents = 0;
        var totalEvents = events.Length;

        while(currentEvent < totalEvents || minHeap.Count > 0){
            if(minHeap.Count == 0) day = events[currentEvent][0];

            while(currentEvent < totalEvents && events[currentEvent][0] <= day) 
                minHeap.Enqueue(events[currentEvent][1], events[currentEvent++][1]);

            minHeap.Dequeue();
            day++;
            attendedEvents++;

            while(minHeap.Count > 0 && minHeap.Peek() < day) minHeap.Dequeue();
        }

        return attendedEvents;
    }
}

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