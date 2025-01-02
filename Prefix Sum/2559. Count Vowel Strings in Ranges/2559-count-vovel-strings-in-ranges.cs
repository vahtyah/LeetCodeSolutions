public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        var isVowel = new bool[128];
        isVowel['a'] = isVowel['e'] = isVowel['i'] = isVowel['o'] = isVowel['u'] = true;
        
        var prefix = new int[words.Length + 1];
        for (int i = 0; i < words.Length; i++) {
            prefix[i + 1] = prefix[i] + 
                            (isVowel[words[i][0]] && isVowel[words[i][^1]] ? 1 : 0);
        }
        
        var answer = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++) {
            answer[i] = prefix[queries[i][1] + 1] - prefix[queries[i][0]];
        }
        
        return answer;
    }
}