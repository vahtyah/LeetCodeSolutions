namespace LeetCodeSolutions.Greedy;

/*
 * 2434. Using a Robot to Print the Lexicographically Smallest String
 * Difficulty: Medium
 * Submission Time: 2025-06-06 07:34:25
 * Created by vahtyah on 2025-06-06 07:43:33
*/
 
public class Solution 
{
    public string RobotWithString(string s) 
    {
        int n = s.Length;
        if (n == 0) return string.Empty;
        
        ReadOnlySpan<char> input = s.AsSpan();
        
        Span<byte> minFromRight = stackalloc byte[n];
        minFromRight[n - 1] = (byte)input[n - 1];
        
        for (int i = n - 2; i >= 0; i--) 
        {
            minFromRight[i] = (byte)Math.Min(input[i], minFromRight[i + 1]);
        }
        
        Span<char> stack = stackalloc char[n];
        int stackTop = -1;
        
        char[] result = new char[n];
        int resultIndex = 0;
        int index = 0;
        
        while (index < n || stackTop >= 0) 
        {
            while (stackTop >= 0 && 
                   (index >= n || stack[stackTop] <= minFromRight[index])) 
            {
                result[resultIndex++] = stack[stackTop--];
            }
            
            if (index < n) 
            {
                stack[++stackTop] = input[index++];
            }
        }
        
        return new string(result, 0, resultIndex);
    }
}