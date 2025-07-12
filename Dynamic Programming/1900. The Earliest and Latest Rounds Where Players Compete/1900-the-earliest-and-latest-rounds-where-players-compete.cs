namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1900. The Earliest and Latest Rounds Where Players Compete
 * Difficulty: Hard
 * Submission Time: 2025-07-12 08:14:20
 * Created by vahtyah on 2025-07-12 08:16:06
*/
 
public class Solution
{
    private int[,,] earliestMatchMemo = new int[30, 30, 30];
    private int[,,] latestMatchMemo = new int[30, 30, 30];

    private int[] GetEarliestAndLatest(int n, int first, int second)
    {
        if (earliestMatchMemo[n, first, second] != 0)
        {
            return new int[] { earliestMatchMemo[n, first, second], latestMatchMemo[n, first, second] };
        }

        if (first + second == n + 1)
        {
            return new int[] { 1, 1 };
        }

        // Use symmetry: (n, f, s) == (n, n+1-s, n+1-f) for mirrored positions
        if (first + second > n + 1)
        {
            int[] result = GetEarliestAndLatest(n, n + 1 - second, n + 1 - first);
            earliestMatchMemo[n, first, second] = result[0];
            latestMatchMemo[n, first, second] = result[1];
            return result;
        }

        int minRound = int.MaxValue, maxRound = int.MinValue;
        int halfN = (n + 1) / 2;

        if (second <= halfN)
        {
            // Both players on the left (or in the middle)
            for (int i = 0; i < first; ++i)
            {
                for (int j = 0; j < second - first; ++j)
                {
                    int[] result = GetEarliestAndLatest(halfN, i + 1, i + j + 2);
                    minRound = Math.Min(minRound, result[0]);
                    maxRound = Math.Max(maxRound, result[1]);
                }
            }
        }
        else
        {
            // Second player is on the right half
            int mirroredSecond = n + 1 - second;
            int midOffset = (n - 2 * mirroredSecond + 1) / 2;
            for (int i = 0; i < first; ++i)
            {
                for (int j = 0; j < mirroredSecond - first; ++j)
                {
                    int[] result = GetEarliestAndLatest(halfN, i + 1, i + j + midOffset + 2);
                    minRound = Math.Min(minRound, result[0]);
                    maxRound = Math.Max(maxRound, result[1]);
                }
            }
        }

        earliestMatchMemo[n, first, second] = minRound + 1;
        latestMatchMemo[n, first, second] = maxRound + 1;
        return new int[] { minRound + 1, maxRound + 1 };
    }

    public int[] EarliestAndLatest(int n, int firstPlayer, int secondPlayer)
    {
        if (firstPlayer > secondPlayer) (firstPlayer, secondPlayer) = (secondPlayer, firstPlayer);

        return GetEarliestAndLatest(n, firstPlayer, secondPlayer);
    }
}