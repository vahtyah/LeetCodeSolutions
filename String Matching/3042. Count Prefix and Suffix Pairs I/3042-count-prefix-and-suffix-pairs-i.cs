public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int res = 0;
        for(int i = 0; i< words.Length - 1; i++){
            for(int j = i + 1 ; j < words.Length; j++){
                if(isPrefixAndSuffix(words[j], words[i])){
                    res++;
                }
            }
        }
        return res;
    }
    public bool isPrefixAndSuffix(string str1,string str2){
        if(str1.Length < str2.Length){
            return false;
        }
        for(int i=0 ; i < str2.Length; i++){
            if(str2[i] != str1[i]){
                return false;
            }
            if(str2[i] != str1[str1.Length - str2.Length + i]){
                return false;
            }
        }
        return true;
    }
}