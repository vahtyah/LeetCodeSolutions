namespace LeetCodeSolutions.DataStructures/Heap(PriorityQueue);

/*
 * 3066. Minimum Operations to Exceed Threshold Value II
 * Difficulty: Medium
 * Submission Time: 2025-02-13 05:25:22
 * Created by vahtyah on 2025-02-13 05:28:21
*/
 
public class Solution {
    public int MinOperations(int[] nums, int k) {
        var heap = new PriorityQueue<long, long>();
        foreach(var num in nums) if(num < k) heap.Enqueue(num, num);

        var operations = 0;
        while(heap.Count > 1){
            operations++;
            var first = heap.Dequeue();
            var second = heap.Dequeue();
            var newNum = Math.Max(first, second) + Math.Min(first, second) * 2;
            if(newNum < k) heap.Enqueue(newNum, newNum);
        }
        
        return operations + heap.Count;
    }
}

public class Solution {
    public int MinOperations(int[] nums, int k) {
        var heap = new List<long>();
        
        foreach (var num in nums) {
            if (num < k) {
                heap.Add(num);
            }
        }
        
        if (heap.Count == 0) return 0;
        
        for (int i = heap.Count / 2 - 1; i >= 0; i--) {
            Heapify(heap, i, heap.Count);
        }
        
        int operations = 0;
        while (heap.Count > 1) {
            var first = ExtractMin(heap);
            var second = ExtractMin(heap);
            
            var newNum = Math.Min(first, second) * 2 + Math.Max(first, second);
            
            if (newNum < k) {
                heap.Add(newNum);
                int current = heap.Count - 1;
                while (current > 0) {
                    int parent = (current - 1) / 2;
                    if (heap[current] < heap[parent]) {
                        (heap[current], heap[parent]) = (heap[parent], heap[current]);
                        current = parent;
                    } else {
                        break;
                    }
                }
            }
            operations++;
        }
        
        return operations + heap.Count;
    }
    
    private void Heapify(List<long> heap, int root, int size) {
        int smallest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;
        
        if (left < size && heap[left] < heap[smallest])
            smallest = left;
            
        if (right < size && heap[right] < heap[smallest])
            smallest = right;
            
        if (smallest != root) {
            (heap[root], heap[smallest]) = (heap[smallest], heap[root]);
            Heapify(heap, smallest, size);
        }
    }
    
    private long ExtractMin(List<long> heap) {
        var min = heap[0];
        heap[0] = heap[^1];
        heap.RemoveAt(heap.Count - 1);
        
        if (heap.Count > 0) {
            Heapify(heap, 0, heap.Count);
        }
        
        return min;
    }
}