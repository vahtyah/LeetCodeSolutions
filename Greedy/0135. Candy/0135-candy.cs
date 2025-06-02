namespace LeetCodeSolutions.Greedy;

/*
 * 0135. Candy
 * Difficulty: Hard
 * Submission Time: 2025-06-02 06:37:31
 * Created by vahtyah on 2025-06-02 06:38:09
*/
 
public class Solution {
    public int Candy(int[] ratings) {
        int peak = 0, down = 0, up = 0, result = 1;
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                peak = ++up;
                down = 0;
                result += up + 1;
            }
            else if (ratings[i] < ratings[i - 1])
            {
                up = 0;
                result += ++down;
                if (down > peak)
                {
                    result += 1;
                }
            }
            else
            {
                peak = up = down = 0;
                result++;
            }
        }
        
        return result;
    }
}

public class Solution
{
    public int Candy(int[] ratings)
    {
        var n = ratings.Length;
        var candies = new int[n];
        Array.Fill(candies, 1);

        // Forward pass
        for (var i = 1; i < n; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        // Backward pass
        for (var i = n - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }

        var result = 0;
        for (var i = 0; i < n; i++)
        {
            result += candies[i];
        }

        return result;
    }
}