namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0217. Contains Duplicate
 * Difficulty: Easy
 * Submission Time: 2025-02-16 19:52:00
 * Created by vahtyah on 2025-02-16 19:55:53
*/
 
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var seen = new HashSet<long>();

        for(int i = 0; i < nums.Length; i++){
            if(!seen.Add(nums[i])) return true;
        }

        return false;
    }
}

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        for(int i = 1; i < nums.Length; i++)
        {
            int curNum = nums[i];
            int j = i - 1;
            while(j >= 0 && nums[j+1] < nums[j]) //Insertion sort
            {
                nums[j + 1] = nums[j];
                nums[j] = curNum;
                j--;
            }

            if(j >= 0 && nums[j] == curNum)
            {
                return true;
            }
        }
        return false;
    }
}