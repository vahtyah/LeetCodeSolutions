namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2948. Make Lexicographically Smallest Array by Swapping Elements
 * Difficulty: Medium
 * Created by vahtyah on 2025-01-25 14:39:19
 */
 
public class Solution
{
    public int[] LexicographicallySmallestArray(int[] nums, int limit) 
    {
        var cloned = nums.ToList().ToArray();
        Array.Sort(cloned);
        
        Dictionary<int, Queue<int>> dict = new Dictionary<int, Queue<int>>();

        dict[cloned[0]] = new Queue<int>();
        dict[cloned[0]].Enqueue(cloned[0]);

        for(int i = 1; i < cloned.Length; i++)
        {
            if(cloned[i] - cloned[i - 1] <= limit)
            {
               dict[cloned[i - 1]].Enqueue(cloned[i]);
               dict[cloned[i]] = dict[cloned[i - 1]];
            }
            else{
                dict[cloned[i]] = new Queue<int>();
                dict[cloned[i]].Enqueue(cloned[i]);
            }
        }

        for(int i = 0; i < nums.Length ; i++)
        {
            nums[i] = dict[nums[i]].Dequeue();
        }
        
        return nums;
    }
}