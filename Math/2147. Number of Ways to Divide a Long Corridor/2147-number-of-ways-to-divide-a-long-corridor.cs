namespace LeetCodeSolutions.Math;

/*
 * 2147. Number of Ways to Divide a Long Corridor
 * Difficulty: Hard
 * Submission Time: 2025-12-14 05:34:36
 * Created by vahtyah on 2025-12-14 12:31:29
*/
 
public class Solution
{
    public int NumberOfWays(string corridor)
    {
        const int MOD = 1000000007;
        
        ReadOnlySpan<char> span = corridor.AsSpan();
        int seatCount = 0;
        int prevSeatIndex = -1;
        long result = 1;
        
        for (int i = 0; i < span.Length; i++)
        {
            if (span[i] == 'S')
            {
                seatCount++;
                
                if (seatCount > 2 && (seatCount & 1) == 1)
                {
                    result = (result * (i - prevSeatIndex)) % MOD;
                }
                
                prevSeatIndex = i;
            }
        }
        
        return (seatCount == 0 || (seatCount & 1) == 1) ? 0 : (int)result;
    }
}