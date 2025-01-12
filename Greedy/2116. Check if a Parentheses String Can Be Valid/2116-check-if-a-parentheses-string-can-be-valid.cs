public class Solution {
    public bool CanBeValid(string s, string locked) {
        if(s.Length % 2 != 0) return false;
        
        int max = 0, min = 0;
        for (int i = 0; i < s.Length; i++) {
            if (locked[i] == '1') {
                if (s[i] == '(') {
                    max++;
                    min++;
                } else {
                    if (max == 0) return false;
                    max--;
                    min--;
                }
            } else {
                max++;
                min--;
            }
            if (min < 0) min += 2;
        }
        return min == 0;
    }
}