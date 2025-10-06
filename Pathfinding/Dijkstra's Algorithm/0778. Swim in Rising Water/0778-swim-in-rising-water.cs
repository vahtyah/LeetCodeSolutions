namespace LeetCodeSolutions.Pathfinding/Dijkstra'sAlgorithm;

/*
 * 0778. Swim in Rising Water
 * Difficulty: Hard
 * Submission Time: 2025-10-06 13:33:18
 * Created by vahtyah on 2025-10-06 13:34:10
*/
 
public class Solution {
    private readonly static int[][] Dirs = new int[4][]{
        new int[] {-1, 0},
        new int[] {0, -1},
        new int[] {0, 1},
        new int[] {1, 0}
    };

    public int SwimInWater(int[][] grid) {
        var n = grid.Length;
        var maxHeight = 0;

        var visited = new bool[n, n];
        visited[0, 0] = true;

        var pq = new UnsafePriorityQueue<(int, int), int>();
        pq.Enqueue((0, 0), grid[0][0]);

        while(pq.Count > 0){
            var (x, y) = pq.Dequeue();
            maxHeight = Math.Max(maxHeight, grid[x][y]);

            if(x == n - 1 && y == n - 1) return maxHeight;

            foreach(var dir in Dirs){
                var (newX, newY) = (dir[0] + x, dir[1] + y);
                
                if(newX < 0 || newX >= n || newY < 0 || newY >= n || visited[newX, newY]) continue;
                
                pq.Enqueue((newX, newY), grid[newX][newY]);
                visited[newX, newY] = true;
            }
        }

        return maxHeight;
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