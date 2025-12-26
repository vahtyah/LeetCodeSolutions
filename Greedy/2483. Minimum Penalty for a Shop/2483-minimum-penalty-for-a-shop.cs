namespace LeetCodeSolutions.Greedy;

/*
 * 2483. Minimum Penalty for a Shop
 * Difficulty: Medium
 * Submission Time: 2025-12-26 16:01:29
 * Created by vahtyah on 2025-12-26 16:01:58
*/
 
public class Solution {
    public int BestClosingTime(string customers) 
    {
        int bestTime = 0;
        int bestScore = 0;
        int score = 0;

        for (int t = 0; t < customers.Length; t++)
        {
            if (customers[t] == 'Y')
                score += 1;     // opening this hour avoids a missed customer
            else
                score -= 1;     // opening this hour incurs idle cost

            if (score > bestScore)
            {
                bestScore = score;
                bestTime = t + 1;
            }
        }

        return bestTime;
    }
}