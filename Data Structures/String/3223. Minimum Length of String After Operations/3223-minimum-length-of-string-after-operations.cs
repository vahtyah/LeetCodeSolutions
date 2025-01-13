public class Solution {
    public int MinimumLength(string s) {
        var n = s.Length;
        var chars = new int[26];
        foreach(var c in s){
            var cc = c - 'a';
            if(chars[cc] + 1 > 2){
                n -= 2;
                chars[cc]--;
                continue;
            } 
            chars[cc]++;
        }
        return n;
    }
}