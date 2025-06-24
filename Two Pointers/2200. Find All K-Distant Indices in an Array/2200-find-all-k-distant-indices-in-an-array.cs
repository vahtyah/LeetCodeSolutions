namespace LeetCodeSolutions.TwoPointers;

/*
 * 2200. Find All K-Distant Indices in an Array
 * Difficulty: Easy
 * Submission Time: 2025-06-24 06:57:43
 * Created by vahtyah on 2025-06-24 06:58:06
*/
 
public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        List<int> result = new List<int>(); 
        int length = nums.Length;

        for (int i = 0; i < length; i++){
            if (nums[i] != key) continue;

            int start = Math.Max(i - k, 0),
                range = Math.Min(length, i + k * 2 + 2),
                end = Math.Min(i + k, length - 1);
            
            while (++i < range){
                if (nums[i] == key)
                {
                    range = Math.Min(length, i + k * 2 + 2);
                    end = Math.Min(i + k, length - 1);
                }
            }

            for (int j = start; j <= end; j++) result.Add(j);

            i--;
        }
        
        return result;
    }
}