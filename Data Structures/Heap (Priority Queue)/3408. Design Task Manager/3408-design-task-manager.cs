namespace LeetCodeSolutions.DataStructures/Heap(PriorityQueue);

/*
 * 3408. Design Task Manager
 * Difficulty: Medium
 * Submission Time: 2025-09-18 13:31:32
 * Created by vahtyah on 2025-09-18 13:32:25
*/
 
public class TaskManager
{
    private Dictionary<int, int> taskToPriority = new();
    private Dictionary<int, int> taskToUser = new();

    private UnsafePriorityQueue<(int taskId, int priority), (int negPriority, int negTaskId)>
        taskToPriorityQueue = new();

    public TaskManager(IList<IList<int>> tasks)
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            int userId   = tasks[i][0];
            int taskId   = tasks[i][1];
            int priority = tasks[i][2];

            taskToPriority[taskId] = priority;
            taskToUser[taskId] = userId;

            taskToPriorityQueue.Enqueue((taskId, priority), (-priority, -taskId));
        }
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void Add(int userId, int taskId, int priority)
    {
        taskToPriority[taskId] = priority;
        taskToUser[taskId] = userId;
        taskToPriorityQueue.Enqueue((taskId, priority), (-priority, -taskId));
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void Edit(int taskId, int newPriority)
    {
        taskToPriority[taskId] = newPriority;

        taskToPriorityQueue.Enqueue((taskId, newPriority), (-newPriority, -taskId));
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void Rmv(int taskId)
    {
        taskToPriority.Remove(taskId);
        taskToUser.Remove(taskId);
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public int ExecTop()
    {
        while (taskToPriorityQueue.Count > 0)
        {
            var (taskId, priority) = taskToPriorityQueue.Dequeue();

            if (!taskToPriority.ContainsKey(taskId))
                continue;

            int correctPriority = taskToPriority[taskId];
            if (priority != correctPriority)
                continue;

            int userId = taskToUser[taskId];
            Rmv(taskId);
            return userId;
        }

        return -1;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */

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