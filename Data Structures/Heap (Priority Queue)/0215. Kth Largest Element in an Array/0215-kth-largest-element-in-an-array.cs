namespace LeetCodeSolutions.DataStructures/Heap(PriorityQueue);

/*
 * 0215. Kth Largest Element in an Array
 * Difficulty: Medium
 * Submission Time: 2025-06-18 07:37:20
 * Created by vahtyah on 2025-06-18 07:38:02
*/
 
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue(nums.Length);

        foreach(var num in nums){
            pq.Enqueue(num);
            if(pq.Count > k) pq.Dequeue();
        }

        return pq.Peek();
    }
}

public unsafe class PriorityQueue : IDisposable 
{
    private int* _heap;
    private int _count;
    private int _capacity;
    
    public PriorityQueue(int capacity = 16)
    {
        _capacity = capacity;
        _heap = (int*)System.Runtime.InteropServices.Marshal.AllocHGlobal(capacity * sizeof(int));
        _count = 0;
    }
    
    public int Count => _count;
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void Enqueue(int element)
    {
        if (_count == _capacity)
            Resize();
            
        _heap[_count] = element;
        SiftUp(_count);
        _count++;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public int Dequeue()
    {
        int result = _heap[0];
        _count--;
        
        if (_count > 0)
        {
            _heap[0] = _heap[_count];
            SiftDown(0);
        }
        
        return result;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public int Peek() => _heap[0];
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private void SiftUp(int index)
    {
        int item = _heap[index];
        
        while (index > 0)
        {
            int parentIndex = (index - 1) >> 1;
            int parent = _heap[parentIndex];
            
            if (item >= parent) break;
                
            _heap[index] = parent;
            index = parentIndex;
        }
        
        _heap[index] = item;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private void SiftDown(int index)
    {
        int item = _heap[index];
        int halfCount = _count >> 1;
        
        while (index < halfCount)
        {
            int childIndex = (index << 1) + 1;
            int child = _heap[childIndex];
            int rightChildIndex = childIndex + 1;
            
            if (rightChildIndex < _count && _heap[rightChildIndex] < child)
            {
                childIndex = rightChildIndex;
                child = _heap[childIndex];
            }
            
            if (item.CompareTo(child) <= 0)
                break;
                
            _heap[index] = child;
            index = childIndex;
        }
        
        _heap[index] = item;
    }
    
    private void Resize()
    {
        _capacity *= 2;
        _heap = (int*)System.Runtime.InteropServices.Marshal.ReAllocHGlobal((IntPtr)_heap, (IntPtr)(_capacity * sizeof(int)));
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