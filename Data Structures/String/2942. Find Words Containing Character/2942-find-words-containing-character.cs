namespace LeetCodeSolutions.DataStructures/String;

/*
 * 2942. Find Words Containing Character
 * Difficulty: Easy
 * Submission Time: 2025-05-24 05:59:39
 * Created by vahtyah on 2025-05-24 06:00:45
*/
 
public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        var indices = new int[words.Length];
        int count = 0;
        
        for (int i = 0; i < words.Length; i++) {
            if (words[i].Contains(x)) {
                indices[count++] = i;
            }
        }
        
        return new ArraySegment<int>(indices, 0, count);
    }
}