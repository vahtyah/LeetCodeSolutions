namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 1298. Maximum Candies You Can Get from Boxes
 * Difficulty: Hard
 * Submission Time: 2025-06-03 06:14:38
 * Created by vahtyah on 2025-06-03 06:15:06
*/
 
public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        if (initialBoxes.Length == 0) return 0;
        
        var totalCandies = 0;
        
        var boxState = new int[status.Length]; // 0: unknown, 1: have box, 2: have key, 3: have both, 4: processed
        var queue = new Queue<int>();
        
        foreach (int box in initialBoxes) {
            boxState[box] |= 1; 
            if (status[box] == 1 || (boxState[box] & 2) != 0) {
                queue.Enqueue(box);
            }
        }
        
        while (queue.Count > 0) {
            int currentBox = queue.Dequeue();
            
            if ((boxState[currentBox] & 4) != 0) continue; 
            boxState[currentBox] |= 4;
            
            totalCandies += candies[currentBox];
            
            foreach (int key in keys[currentBox]) {
                bool hadKey = (boxState[key] & 2) != 0;
                boxState[key] |= 2; 
                
                if (!hadKey && (boxState[key] & 1) != 0 && (boxState[key] & 4) == 0) {
                    queue.Enqueue(key);
                }
            }
            
            foreach (int newBox in containedBoxes[currentBox]) {
                bool hadBox = (boxState[newBox] & 1) != 0;
                boxState[newBox] |= 1; 
                
                if (!hadBox && (boxState[newBox] & 4) == 0) {
                    if (status[newBox] == 1 || (boxState[newBox] & 2) != 0) {
                        queue.Enqueue(newBox);
                    }
                }
            }
        }
        
        return totalCandies;
    }
}