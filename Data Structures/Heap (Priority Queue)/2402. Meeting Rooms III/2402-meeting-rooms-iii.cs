namespace LeetCodeSolutions.DataStructures/Heap(PriorityQueue);

/*
 * 2402. Meeting Rooms III
 * Difficulty: Hard
 * Submission Time: 2025-07-11 11:24:14
 * Created by vahtyah on 2025-07-11 11:24:41
*/
 
public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
        
        var availableRooms = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++) {
            availableRooms.Enqueue(i, i);
        }
        
        var busyRooms = new PriorityQueue<(long endTime, int room), (long endTime, int room)>();
        
        Span<int> roomCount = stackalloc int[n];
        
        foreach (var meeting in meetings) {
            long startTime = meeting[0];
            long duration = meeting[1] - meeting[0];
            
            while (busyRooms.Count > 0 && busyRooms.Peek().endTime <= startTime) {
                var (_, room) = busyRooms.Dequeue();
                availableRooms.Enqueue(room, room);
            }
            
            int assignedRoom;
            long meetingEndTime;
            
            if (availableRooms.Count > 0) {
                assignedRoom = availableRooms.Dequeue();
                meetingEndTime = startTime + duration;
            } else {
                var (earliestEndTime, room) = busyRooms.Dequeue();
                assignedRoom = room;
                meetingEndTime = earliestEndTime + duration;
            }
            
            busyRooms.Enqueue((meetingEndTime, assignedRoom), (meetingEndTime, assignedRoom));
            roomCount[assignedRoom]++;
        }
        
        int result = 0;
        for (int i = 1; i < n; i++) {
            if (roomCount[i] > roomCount[result]) {
                result = i;
            }
        }
        
        return result;
    }
}

public unsafe class PriorityQueue<TElement, TPriority> : IDisposable 
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
    
    public PriorityQueue(int capacity = 16)
    {
        _capacity = capacity;
        _heap = (Node*)System.Runtime.InteropServices.Marshal.AllocHGlobal(capacity * sizeof(Node));
        _count = 0;
    }

    public int Count => _count;
    public TPriority Priority => _heap[0].Priority;
    
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
    
    ~PriorityQueue() => Dispose();
}