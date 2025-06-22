namespace LeetCodeSolutions.DataStructures/String;

/*
 * 2138. Divide a String Into Groups of Size k
 * Difficulty: Easy
 * Submission Time: 2025-06-22 07:00:04
 * Created by vahtyah on 2025-06-22 07:02:28
*/
 
public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        int totalGroups = (s.Length + k - 1) / k;
        string[] result = new string[totalGroups];

        char[] buffer = new char[k];
        int bufferIndex = 0;
        int groupIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            buffer[bufferIndex++] = s[i];

            if (bufferIndex == k)
            {
                result[groupIndex++] = new string(buffer);
                bufferIndex = 0;
            }
        }

        if (bufferIndex > 0)
        {
            for (int i = bufferIndex; i < k; i++)
            {
                buffer[i] = fill;
            }
            result[groupIndex] = new string(buffer);
        }

        return result;
    }
}
