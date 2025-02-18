namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0228. Summary Ranges
 * Difficulty: Easy
 * Submission Time: 2025-02-18 08:37:08
 * Created by vahtyah on 2025-02-18 08:38:03
*/
 
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> result = new List<string>();
        
        if (nums.Length == 0)
            return result;
            
        for (int i = 0; i < nums.Length; i++) {
            int start = nums[i];
            
            while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1)
                i++;
                
            if (start != nums[i])
                result.Add(start.ToString() + "->" + nums[i].ToString());
            else
                result.Add(start.ToString());
        }
        
        return result;
    }
}