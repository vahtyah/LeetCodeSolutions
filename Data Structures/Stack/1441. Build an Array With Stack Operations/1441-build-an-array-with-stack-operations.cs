namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 1441. Build an Array With Stack Operations
 * Difficulty: Medium
 * Submission Time: 2026-06-14 14:37:58
 * Created by vahtyah on 2026-06-14 14:38:55
*/
 
public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var operations = new List<string>();
        int current = 1;

        foreach (int value in target)
        {
            while (current < value)
            {
                operations.Add("Push");
                operations.Add("Pop");
                current++;
            }

            operations.Add("Push");
            current++;
        }

        return operations;
    }
}