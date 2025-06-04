namespace LeetCodeSolutions.TwoPointers;

/*
 * 3403. Find the Lexicographically Largest String From the Box I
 * Difficulty: Medium
 * Submission Time: 2025-06-04 08:35:38
 * Created by vahtyah on 2025-06-04 10:34:03
*/
 
public class Solution {
    public unsafe string LastSubstring(string s) {
        if (s.Length <= 1) return s;
        
        fixed (char* ptr = s) {
            int i = 0, j = 1, n = s.Length;
            
            while (j < n) {
                int k = 0;
                
                while (j + k < n && ptr[i + k] == ptr[j + k]) {
                    k++;
                }
                
                if (j + k < n && ptr[i + k] < ptr[j + k]) {
                    int oldI = i;
                    i = j;
                    j = Math.Max(j + 1, oldI + k + 1);
                } else {
                    j += k + 1;
                }
            }
            return s.Substring(i);
        }
    }

    public string AnswerString(string word, int numFriends) {
        if (numFriends == 1) return word;
        
        string last = LastSubstring(word);
        int maxLength = word.Length - numFriends + 1;
        
        return last.Length <= maxLength ? last : last.Substring(0, maxLength);
    }
}