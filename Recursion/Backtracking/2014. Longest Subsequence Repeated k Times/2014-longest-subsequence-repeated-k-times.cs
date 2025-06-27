namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 2014. Longest Subsequence Repeated k Times
 * Difficulty: Hard
 * Submission Time: 2025-06-27 08:10:25
 * Created by vahtyah on 2025-06-27 08:12:34
*/
 
public class Solution
{
    public string LongestSubsequenceRepeatedK(string s, int k)
    {
        int stringLength = s.Length;
        int maxPossibleLength = stringLength / k;
        
        int[] charFrequency = new int[26];
        foreach (char c in s)
            charFrequency[c - 'a']++;
        
        char[] candidates = new char[26];
        int candidateCount = 0;
        for (int i = 25; i >= 0; i--)
            if (charFrequency[i] >= k)
                candidates[candidateCount++] = (char)(i + 'a');

        if (candidateCount == 0) return "";
        
        char[] longestSequence = new char[] { candidates[0] };
        char[] currentSequence = new char[maxPossibleLength];
        int currentLength = 0;
        
        FindLongestSequence();
        return new string(longestSequence);

        void FindLongestSequence()
        {
            for (int candidateIndex = 0; candidateIndex < candidateCount; candidateIndex++)
            {
                char nextChar = candidates[candidateIndex];
                currentSequence[currentLength++] = nextChar;
                
                if (currentLength == 1 || CanRepeatKTimes())
                {
                    if (longestSequence.Length == maxPossibleLength) 
                    {
                        currentLength--;
                        break;
                    }
                    FindLongestSequence();
                }
                currentLength--;
            }
        }

        bool CanRepeatKTimes()
        {
            int repetitionsLeft = k;
            int stringIndex = 0;
            int sequenceIndex = 0;
            int totalCharsNeeded = repetitionsLeft * currentLength;
            
            while (stringLength - stringIndex >= totalCharsNeeded - sequenceIndex)
            {
                if (s[stringIndex] == currentSequence[sequenceIndex])
                {
                    sequenceIndex++;
                    if (sequenceIndex == currentLength)
                    {
                        sequenceIndex = 0;
                        repetitionsLeft--;
                        if (repetitionsLeft == 0)
                        {
                            UpdateLongestSequenceIfBetter();
                            return true;
                        }
                        totalCharsNeeded = repetitionsLeft * currentLength;
                    }
                }
                stringIndex++;
            }
            return false;
        }
        
        void UpdateLongestSequenceIfBetter()
        {
            if (currentLength > longestSequence.Length)
            {
                longestSequence = new char[currentLength];
                Array.Copy(currentSequence, longestSequence, currentLength);
            }
        }
    }
}