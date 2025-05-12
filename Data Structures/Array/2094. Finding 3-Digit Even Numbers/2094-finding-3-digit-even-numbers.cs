namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2094. Finding 3-Digit Even Numbers
 * Difficulty: Easy
 * Submission Time: 2025-05-12 07:39:29
 * Created by vahtyah on 2025-05-12 07:40:20
*/
 
public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        var res = new List<int>();
        var freq = new int[10];

        foreach(var num in digits)
            freq[num]++;

        var currFreq = new int[10];

        for(int num = 100; num < 1000; num += 2)
        {
            var ones = num % 10;
            var tens = (num / 10) % 10;
            var hund = num / 100;

            currFreq[ones]++;
            currFreq[tens]++;
            currFreq[hund]++;

            if(currFreq[ones] <= freq[ones] && currFreq[tens] <= freq[tens] && currFreq[hund] <= freq[hund])
            {
                res.Add(num);
            }

            currFreq[ones] = 0;
            currFreq[tens] = 0;
            currFreq[hund] = 0;
        }

        return res.ToArray();
    }
}