namespace LeetCodeSolutions.Greedy;

/*
 * 2561. Rearranging Fruits
 * Difficulty: Hard
 * Submission Time: 2025-08-02 01:58:57
 * Created by vahtyah on 2025-08-02 02:00:20
*/
 
public class Solution {
    public long MinCost(int[] basket1, int[] basket2) {
        var freq = new Dictionary<int, int>();
        var min = int.MaxValue;
        
        foreach (var fruit in basket1) {
            freq[fruit] = freq.GetValueOrDefault(fruit, 0) + 1;
            min = Math.Min(min, fruit);
        }
        
        foreach (var fruit in basket2) {
            freq[fruit] = freq.GetValueOrDefault(fruit, 0) - 1;
            min = Math.Min(min, fruit);
        }
        
        foreach (var count in freq.Values) {
            if (count % 2 != 0) {
                return -1;
            }
        }
        
        var toSwap = new List<int>();
        foreach (var entry in freq) {
            int fruit = entry.Key;
            int diff = Math.Abs(entry.Value) / 2;
            
            for (int i = 0; i < diff; i++) {
                toSwap.Add(fruit);
            }
        }
        
        toSwap.Sort();
        long cost = 0;
        for (int i = 0; i < toSwap.Count / 2; i++) {
            cost += Math.Min(toSwap[i], min * 2);
        }
        
        return cost;
    }
}