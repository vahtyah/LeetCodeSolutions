namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0068. Text Justification
 * Difficulty: Hard
 * Submission Time: 2025-02-04 09:50:58
 * Created by vahtyah on 2025-02-04 09:51:28
 */
 
public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var result = new List<string>(words.Length / 3); // Preallocate with estimated capacity
        int i = 0;
        char[] lineBuffer = new char[maxWidth]; // Reusable buffer for building lines
        
        while (i < words.Length) {
            int wordsWidth = words[i].Length;
            int j = i + 1;
            int wordsInLine = 1;
            
            while (j < words.Length && wordsWidth + 1 + words[j].Length <= maxWidth) {
                wordsWidth += words[j].Length + 1;
                wordsInLine++;
                j++;
            }
            
            int currentPosition = 0;
            if (j == words.Length || wordsInLine == 1) {
                currentPosition = LeftJustifyInBuffer(words, i, j, lineBuffer, maxWidth);
            } else {
                currentPosition = FullyJustifyInBuffer(words, i, j, lineBuffer, maxWidth, wordsWidth - (wordsInLine - 1));
            }
            
            result.Add(new string(lineBuffer, 0, currentPosition));
            i = j;
        }
        
        return result;
    }
    
    private int LeftJustifyInBuffer(string[] words, int start, int end, char[] buffer, int maxWidth) {
        int pos = 0;
        
        for (int i = 0; i < words[start].Length; i++) {
            buffer[pos++] = words[start][i];
        }
        
        for (int i = start + 1; i < end; i++) {
            buffer[pos++] = ' ';
            for (int j = 0; j < words[i].Length; j++) {
                buffer[pos++] = words[i][j];
            }
        }
        
        while (pos < maxWidth) {
            buffer[pos++] = ' ';
        }
        
        return pos;
    }
    
    private int FullyJustifyInBuffer(string[] words, int start, int end, char[] buffer, int maxWidth, int wordsWidth) {
        int pos = 0;
        int gaps = end - start - 1;
        int totalSpaces = maxWidth - wordsWidth;
        int spacesPerGap = gaps > 0 ? totalSpaces / gaps : 0;
        int extraSpaces = gaps > 0 ? totalSpaces % gaps : 0;
        
        for (int i = 0; i < words[start].Length; i++) {
            buffer[pos++] = words[start][i];
        }
        
        for (int i = start + 1; i < end; i++) {
            int spaces = spacesPerGap + (extraSpaces-- > 0 ? 1 : 0);
            for (int s = 0; s < spaces; s++) {
                buffer[pos++] = ' ';
            }
            
            for (int j = 0; j < words[i].Length; j++) {
                buffer[pos++] = words[i][j];
            }
        }
        
        return pos;
    }
}