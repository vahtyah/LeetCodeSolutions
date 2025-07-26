namespace LeetCodeSolutions.Greedy;

/*
 * 3480. Maximize Subarrays After Removing One Conflicting Pair
 * Difficulty: Hard
 * Submission Time: 2025-07-26 00:55:56
 * Created by vahtyah on 2025-07-26 00:56:22
*/
 
class Solution
{
    public long MaxSubarrays(int n, int[][] conflictingPairs)
    {
        var right = new List<int>[n + 1];
        for (int i = 0; i <= n; i++)
            right[i] = new List<int>();

        for (int i = 0; i < conflictingPairs.Length; i++)
        {
            var pair = conflictingPairs[i];
            int max = pair[0] > pair[1] ? pair[0] : pair[1];
            int min = pair[0] < pair[1] ? pair[0] : pair[1];
            right[max].Add(min);
        }

        long ans = 0, add = 0;
        int maxLeft = 0, secondMaxLeft = 0;
        var imp = new long[n + 1];

        for (int r = 1; r <= n; r++)
        {
            var rightList = right[r];
            for (int i = 0; i < rightList.Count; i++)
            {
                int l = rightList[i];
                if (l > maxLeft)
                {
                    secondMaxLeft = maxLeft;
                    maxLeft = l;
                }
                else if (l > secondMaxLeft)
                {
                    secondMaxLeft = l;
                }
            }

            ans += r - maxLeft;
            imp[maxLeft] += maxLeft - secondMaxLeft;
            
            if (imp[maxLeft] > add)
                add = imp[maxLeft];
        }
        
        return ans + add;
    }
}