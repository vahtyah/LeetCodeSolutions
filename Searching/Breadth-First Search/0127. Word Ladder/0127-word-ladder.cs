namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0127. Word Ladder
 * Difficulty: Hard
 * Submission Time: 2025-05-31 07:39:59
 * Created by vahtyah on 2025-05-31 07:40:45
*/
 
public class Solution {
    private static readonly char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var wordSet = new HashSet<string>(wordList, StringComparer.Ordinal);
        if (!wordSet.Contains(endWord)) return 0;

        wordSet.Remove(beginWord);
        
        var beginSet = new HashSet<string>(StringComparer.Ordinal) { beginWord };
        var endSet = new HashSet<string>(StringComparer.Ordinal) { endWord };
        
        int level = 1;
        
        var wordArray = new char[beginWord.Length];
        
        while (beginSet.Count > 0 && endSet.Count > 0) {
            if (beginSet.Count > endSet.Count) {
                (beginSet, endSet) = (endSet, beginSet);
            }
            
            var nextSet = new HashSet<string>(StringComparer.Ordinal);
            
            foreach (var word in beginSet) {
                word.CopyTo(0, wordArray, 0, word.Length);
                
                for (int pos = 0; pos < wordArray.Length; pos++) {
                    char originalChar = wordArray[pos];
                    
                    foreach (char newChar in ALPHABET) {
                        if (newChar == originalChar) continue;
                        
                        wordArray[pos] = newChar;
                        
                        string candidate = new string(wordArray);
                        
                        if (endSet.Contains(candidate)) {
                            return level + 1;
                        }
                        
                        if (wordSet.Remove(candidate)) {
                            nextSet.Add(candidate);
                        }
                    }
                    
                    wordArray[pos] = originalChar;
                }
            }
            
            beginSet = nextSet;
            level++;
        }
        
        return 0;
    }
}