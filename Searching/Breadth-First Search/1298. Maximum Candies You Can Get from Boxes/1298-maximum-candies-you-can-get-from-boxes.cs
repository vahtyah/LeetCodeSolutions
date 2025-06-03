namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 1298. Maximum Candies You Can Get from Boxes
 * Difficulty: Hard
 * Submission Time: 2025-06-03 06:04:55
 * Created by vahtyah on 2025-06-03 06:05:47
*/
 
public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        if (initialBoxes.Length == 0) return 0;
        
        int totalCandies = 0;
        int n = status.Length;
        
        var hasBox = new bool[n];
        var hasKey = new bool[n];
        var processed = new bool[n];
        var queue = new Queue<int>();
        
        foreach (int box in initialBoxes) {
            hasBox[box] = true;
            if (status[box] == 1) {
                queue.Enqueue(box);
            }
        }
        
        while (queue.Count > 0) {
            int currentBox = queue.Dequeue();
            
            if (processed[currentBox]) continue;
            processed[currentBox] = true;
            
            totalCandies += candies[currentBox];
            
            foreach (int key in keys[currentBox]) {
                if (!hasKey[key]) {
                    hasKey[key] = true;
                    if (hasBox[key] && !processed[key]) {
                        queue.Enqueue(key);
                    }
                }
            }
            
            foreach (int newBox in containedBoxes[currentBox]) {
                if (!hasBox[newBox]) {
                    hasBox[newBox] = true;
                    if (status[newBox] == 1 || hasKey[newBox]) {
                        if (!processed[newBox]) {
                            queue.Enqueue(newBox);
                        }
                    }
                }
            }
        }
        
        return totalCandies;
    }
}