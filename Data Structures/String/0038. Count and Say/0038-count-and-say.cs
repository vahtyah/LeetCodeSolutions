namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0038. Count and Say
 * Difficulty: Medium
 * Submission Time: 2025-04-18 06:37:14
 * Created by vahtyah on 2025-04-18 06:37:51
*/
 
using System.Text;

public class Solution {
    private static string[] RLEs;
    private static object lockObject = new object();

    public Solution() {
        if (RLEs == null) {
            lock (lockObject) {
                if (RLEs == null) {
                    InitializeRLEs();
                }
            }
        }
    }

    private static void InitializeRLEs() {
        RLEs = new string[31];
        RLEs[1] = "1";
        for (int i = 2; i <= 30; i++) {
            RLEs[i] = RLE(RLEs[i - 1]);
        }
    }

    public string CountAndSay(int n) {
        return RLEs[n];
    }

    private static string RLE(string input) {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
            
        var result = new StringBuilder(input.Length * 2);
        
        int count = 1;
        char currentChar = input[0];
        
        for (int i = 1; i < input.Length; i++) {
            if (input[i] == currentChar) {
                count++;
            } else {
                result.Append(count).Append(currentChar);
                currentChar = input[i];
                count = 1;
            }
        }
        
        result.Append(count).Append(currentChar);
        
        return result.ToString();
    }
}