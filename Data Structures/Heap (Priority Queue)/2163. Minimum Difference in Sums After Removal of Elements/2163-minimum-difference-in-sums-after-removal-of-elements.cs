namespace LeetCodeSolutions.DataStructures/Heap(PriorityQueue);

/*
 * 2163. Minimum Difference in Sums After Removal of Elements
 * Difficulty: Hard
 * Submission Time: 2025-07-18 13:47:36
 * Created by vahtyah on 2025-07-18 13:52:11
*/
 
public class Solution {
    public long MinimumDifference(int[] nums) {
        int n = nums.Length / 3;
        
        long[] minLeftSum = new long[n + 1];
        long currentSum = 0;
        
        using var maxHeap = new UnsafePriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a)));
        
        for (int i = 0; i < n; i++) {
            currentSum += nums[i];
            maxHeap.Enqueue(nums[i], nums[i]);
        }
        minLeftSum[0] = currentSum;
        
        for (int i = n; i < 2 * n; i++) {
            currentSum += nums[i];
            maxHeap.Enqueue(nums[i], nums[i]);
            currentSum -= maxHeap.Dequeue();
            minLeftSum[i - n + 1] = currentSum;
        }
        
        long maxRightSum = 0;
        using var minHeap = new UnsafePriorityQueue<int, int>();
        
        for (int i = 3 * n - 1; i >= 2 * n; i--) {
            maxRightSum += nums[i];
            minHeap.Enqueue(nums[i], nums[i]);
        }
        
        long result = minLeftSum[n] - maxRightSum;
        
        for (int i = 2 * n - 1; i >= n; i--) {
            maxRightSum += nums[i];
            minHeap.Enqueue(nums[i], nums[i]);
            maxRightSum -= minHeap.Dequeue();
            result = Math.Min(result, minLeftSum[i - n] - maxRightSum);
        }
        
        return result;
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
    private readonly IComparer<TPriority> _comparer;
    
    public UnsafePriorityQueue(int capacity = 16) : this(null, capacity) { }
    
    public UnsafePriorityQueue(IComparer<TPriority> comparer, int capacity = 16)
    {
        _capacity = capacity;
        _heap = (Node*)System.Runtime.InteropServices.Marshal.AllocHGlobal(capacity * sizeof(Node));
        _count = 0;
        _comparer = comparer ?? Comparer<TPriority>.Default;
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
        if (_count == 0)
            throw new InvalidOperationException("Queue is empty");
            
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
    public TElement Peek() 
    {
        if (_count == 0)
            throw new InvalidOperationException("Queue is empty");
        return _heap[0].Element;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private void SiftUp(int index)
    {
        Node item = _heap[index];
        
        while (index > 0)
        {
            int parentIndex = (index - 1) >> 1;
            Node parent = _heap[parentIndex];
            
            if (_comparer.Compare(item.Priority, parent.Priority) >= 0)
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
            
            if (rightChildIndex < _count && _comparer.Compare(_heap[rightChildIndex].Priority, child.Priority) < 0)
            {
                childIndex = rightChildIndex;
                child = _heap[childIndex];
            }
            
            if (_comparer.Compare(item.Priority, child.Priority) <= 0)
                break;
                
            _heap[index] = child;
            index = childIndex;
        }
        
        _heap[index] = item;
    }
    
    private void Resize()
    {
        int newCapacity = _capacity * 2;
        Node* newHeap = (Node*)System.Runtime.InteropServices.Marshal.AllocHGlobal(newCapacity * sizeof(Node));
        
        for (int i = 0; i < _count; i++)
        {
            newHeap[i] = _heap[i];
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal((IntPtr)_heap);
        _heap = newHeap;
        _capacity = newCapacity;
    }
    
    public void Dispose()
    {
        if (_heap != null)
        {
            System.Runtime.InteropServices.Marshal.FreeHGlobal((IntPtr)_heap);
            _heap = null;
        }
        GC.SuppressFinalize(this);
    }
    
    ~UnsafePriorityQueue() => Dispose();
}