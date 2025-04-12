namespace LeetCodeSolutions.Math;

/*
 * 3272. Find the Count of Good Integers
 * Difficulty: Hard
 * Submission Time: 2025-04-12 05:39:46
 * Created by vahtyah on 2025-04-12 05:40:19
*/
 
public class Solution {
    public long CountGoodIntegers(int n, int k) {
        var leftParts = Generate((n-1)/2);
        var pals = new List<int>();

        var result = 0L;

        var uniquePals = new HashSet<string>();

        foreach(var left in leftParts)
        {
            // 123 => 12321
            var num = left * (long)Math.Pow(10, n / 2);
            var m = (int)Math.Pow(10, n / 2 - 1);
            var copyLeft = left;
            if (n % 2 == 1)
            {
                copyLeft /= 10;
            }
            while (copyLeft > 0) 
            {
                num += m * (copyLeft % 10);
                copyLeft = copyLeft / 10;
                m /= 10;
            }

            if (num % k == 0)
            {
                var key = new string(num.ToString().ToCharArray().ToList().OrderBy(x => x).ToArray());
                  
                if (!uniquePals.Contains(key))
                {
                    uniquePals.Add(key);
                    var digits = new int[10];
                    var numCopy = num;
                    while (numCopy > 0)
                    {
                        var rem = (int)(numCopy % 10);
                        digits[rem]++;
                        numCopy = numCopy / 10;
                    }

                    long tot = (n - digits[0]) * fact(n - 1);
                    foreach (int x in digits) {
                        tot /= fact(x);
                    }
                    result += tot;
                }
            }
        }

        return result;
    }

    private static List<int> Generate(int index)
        {
            if (index == 0)
            {
                return new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
            }
            var result = new List<int>();
            for(var i = Math.Pow(10, index); i < Math.Pow(10, index + 1); i++)
            {
                result.Add((int)i);
            }
            return result;
        }

    private static long fact(int n)
    {
        if (n < 2)
        {
            return 1;
        }
        return n * fact(n-1);
    }    
}