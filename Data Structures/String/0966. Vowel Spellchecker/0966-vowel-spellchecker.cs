namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0966. Vowel Spellchecker
 * Difficulty: Medium
 * Submission Time: 2025-09-14 02:36:09
 * Created by vahtyah on 2025-09-14 02:37:02
*/
 
public class Solution {
    public string[] Spellchecker(string[] wordlist, string[] queries) {
        var wordHashSet = new HashSet<string>(wordlist);
        var wordVowelList = new Dictionary<string, int>(wordlist.Length);
        var lowcaseWordList = new Dictionary<string, int>(wordlist.Length);

        for(int i = 0; i < wordlist.Length; i++){
            var chars = wordlist[i].ToCharArray();

            for(int j = 0; j < chars.Length; j++){
                if(chars[j] < 91) chars[j] = (char)(chars[j] + 32);
            }

            var newStr = new string(chars);
            if(!lowcaseWordList.ContainsKey(newStr)){
                lowcaseWordList[newStr] = i;
            }

            for(var j = 0; j < chars.Length; j++){
                if("aeiouAEIOU".Contains(chars[j])){
                    chars[j] = '*';
                }
            }

            newStr = new string(chars);
            if(!wordVowelList.ContainsKey(newStr)){
                wordVowelList[newStr] = i;
            }
        }

        Console.WriteLine(string.Join(" ", wordVowelList));

        for(int i = 0; i < queries.Length; i++){
            if(wordHashSet.Contains(queries[i])) continue;

            var chars = queries[i].ToCharArray();
            for(int j = 0; j < chars.Length; j++){
                if(chars[j] < 91) chars[j] = (char)(chars[j] + 32);
            }

            var query = new string(chars);
            if(lowcaseWordList.TryGetValue(query, out var index)){
                queries[i] = wordlist[index];
                continue;
            }

            for(var j = 0; j < chars.Length; j++){
                if("aeiouAEIOU".Contains(chars[j])){
                    chars[j] = '*';
                }
            }

            query = new string(chars);
            if(wordVowelList.TryGetValue(query, out index)){
                queries[i] = wordlist[index];
                continue;
            }

            queries[i] = "";
        }

        return queries;
    }
}