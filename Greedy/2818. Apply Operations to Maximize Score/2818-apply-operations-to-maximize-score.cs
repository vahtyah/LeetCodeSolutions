namespace LeetCodeSolutions.Greedy;

/*
 * 2818. Apply Operations to Maximize Score
 * Difficulty: Hard
 * Submission Time: 2025-03-29 04:42:41
 * Created by vahtyah on 2025-03-29 04:49:32
*/

public class Solution {
    private const int Mod = 1_000_000_007;

    public int MaximumScore(IList<int> nums, int k)
    {
        var n = nums.Count;
        var primeScores = CalculatePrimeScores(nums, n);
        var nextDominant = Enumerable.Repeat(n, n).ToArray();
        var prevDominant = Enumerable.Repeat(-1, n).ToArray();
        var decreasingPrimeScoreStack = new Stack<int>();
        
        //Monotonic Stack to find the next and previous dominant elements
        for (var index = 0; index < n; index++)
        {
            while (decreasingPrimeScoreStack.Count > 0 &&
                   primeScores[decreasingPrimeScoreStack.Peek()] < primeScores[index])
            {
                var topIndex = decreasingPrimeScoreStack.Pop();
                nextDominant[topIndex] = index;
            }

            if (decreasingPrimeScoreStack.Count > 0)
            {
                prevDominant[index] = decreasingPrimeScoreStack.Peek();
            }

            decreasingPrimeScoreStack.Push(index);
        }

        var numOfSubArrays = new long[n];
        for (var index = 0; index < n; index++)
        {
            numOfSubArrays[index] = (long)(nextDominant[index] - index) * (index - prevDominant[index]);
        }

        var processingQueue = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        for (var index = 0; index < n; index++)
        {
            processingQueue.Enqueue([nums[index], index], nums[index]);
        }

        long score = 1;
        
        //Greedy approach to maximize the score
        while (k > 0 && processingQueue.Count > 0)
        {
            var top = processingQueue.Dequeue();
            var num = top[0];
            var index = top[1];

            var operations = Math.Min(k, numOfSubArrays[index]);

            score = (score * CalculatePower(num, operations)) % Mod;

            k -= (int)operations;
        }

        return (int)score;
    }

    private static List<int> CalculatePrimeScores(IList<int> nums, int n)
    {
        var primeScores = new List<int>(new int[n]);

        for (var index = 0; index < n; index++)
        {
            var num = nums[index];

            for (var factor = 2; factor * factor <= num; factor++)
            {
                if (num % factor == 0)
                {
                    primeScores[index]++;

                    while (num % factor == 0)
                    {
                        num /= factor;
                    }
                }
            }

            if (num >= 2)
            {
                primeScores[index]++;
            }
        }

        return primeScores;
    }

    private static long CalculatePower(long baseNum, long exponent)
    {
        var result = 1L;

        while (exponent > 0)
        {
            if (exponent % 2 == 1)
            {
                result = (result * baseNum) % Mod;
            }

            baseNum = (baseNum * baseNum) % Mod;
            exponent /= 2;
        }

        return result;
    }
}