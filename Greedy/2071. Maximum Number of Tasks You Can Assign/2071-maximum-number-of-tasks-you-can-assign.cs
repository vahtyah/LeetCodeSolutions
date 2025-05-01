namespace LeetCodeSolutions.Greedy;

/*
 * 2071. Maximum Number of Tasks You Can Assign
 * Difficulty: Hard
 * Submission Time: 2025-05-01 05:17:23
 * Created by vahtyah on 2025-05-01 05:18:11
*/
 
public class Solution {
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength) {
        Array.Sort(tasks);
        Array.Sort(workers);
        
        int left = 0;
        int right = Math.Min(tasks.Length, workers.Length);
        
        while (left < right) {
            int mid = left + (right - left + 1) / 2;
            
            if (CanAssign(tasks, workers, pills, strength, mid)) {
                left = mid;
            } else {
                right = mid - 1;
            }
        }
        
        return left;
    }
    
    private bool CanAssign(int[] tasks, int[] workers, int pills, int strength, int count) {
        var deque = new LinkedList<int>();
        int pillsLeft = pills;
        int w = workers.Length - 1; 
        
        for (int i = count - 1; i >= 0; i--) {
            int task = tasks[i];
            
            while (w >= workers.Length - count && workers[w] + strength >= task) {
                deque.AddLast(workers[w--]);
            }
            
            if (deque.Count == 0) {
                return false;
            }
            
            if (deque.First.Value >= task) {
                deque.RemoveFirst();
            } else {
                if (pillsLeft > 0) {
                    pillsLeft--;
                    deque.RemoveLast();
                } else {
                    return false;
                }
            }
        }
        
        return true;
    }
}