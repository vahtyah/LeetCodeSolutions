namespace LeetCodeSolutions.DataStructures/String;

/*
 * 2264. Largest 3-Same-Digit Number in String
 * Difficulty: Easy
 * Submission Time: 2025-08-14 13:43:44
 * Created by vahtyah on 2025-08-14 13:44:19
*/
 
public class Solution {
    private static string[] goodStrings = {"999", "888", "777", "666", "555", "444", "333", "222", "111", "000"};

    public string LargestGoodInteger(string num) {
        foreach(var str in goodStrings){
            if(num.Contains(str)) return str;
        }

        return "";
    }
}