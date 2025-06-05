namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0077. Combinations
 * Difficulty: Medium
 * Submission Time: 2025-06-05 09:28:59
 * Created by vahtyah on 2025-06-05 09:29:29
*/
 
public class Solution 
{
    public IList<IList<int>> Combine(int n, int k) 
    {
        int expectedCount = CalculateCombinations(n, k);
        var result = new List<IList<int>>(expectedCount);
        
        Span<int> currentCombination = stackalloc int[k];
        
        Backtrack(1, n, k, 0, currentCombination, result);
        
        return result;
    }
    
    private void Backtrack(int start, int n, int k, int index, Span<int> currentCombination, IList<IList<int>> result)
    {
        if (index == k)
        {
            result.Add(currentCombination.ToArray());
            return;
        }
        
        int remainingSlots = k - index;
        int maxStart = n - remainingSlots + 1;
        
        for (int i = start; i <= maxStart; i++)
        {
            currentCombination[index] = i;
            Backtrack(i + 1, n, k, index + 1, currentCombination, result);
        }
    }
    
    private int CalculateCombinations(int n, int k)
    {
        if (k > n - k) k = n - k;
        
        long result = 1;
        for (int i = 0; i < k; i++)
        {
            result = result * (n - i) / (i + 1);
        }
        
        return (int)result;
    }
}