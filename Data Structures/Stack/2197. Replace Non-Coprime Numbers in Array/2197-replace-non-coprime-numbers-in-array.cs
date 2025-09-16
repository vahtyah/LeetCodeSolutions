namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 2197. Replace Non-Coprime Numbers in Array
 * Difficulty: Hard
 * Submission Time: 2025-09-16 12:53:45
 * Created by vahtyah on 2025-09-16 12:55:32
*/
 
public class Solution
{
    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        var stack = new List<int>();
        
        foreach (int num in nums)
        {
            stack.Add(num);
            
            while (stack.Count >= 2)
            {
                int last = stack[stack.Count - 1];
                int secondLast = stack[stack.Count - 2];
                int gcd = GCD(secondLast, last);
                
                if (gcd > 1)
                {
                    stack.RemoveAt(stack.Count - 1);
                    stack[stack.Count - 1] = LCM(secondLast, last, gcd);
                }
                else
                {
                    break;
                }
            }
        }
        
        return stack;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private int LCM(int a, int b, int gcd)
    {
        return (a / gcd) * b;
    }
}