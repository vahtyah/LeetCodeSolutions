namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0071. Simplify Path
 * Difficulty: Medium
 * Submission Time: 2025-02-21 12:30:36
 * Created by vahtyah on 2025-02-21 12:31:18
*/
 
public class Solution {
    public string SimplifyPath(string path) {
        var stack = new string[path.Length];
        var top = -1;
        var split = path.Split("/");

        foreach(string s in split)
        {
            if(string.IsNullOrEmpty(s) || s == ".") continue;
            else if(s == "..") { if(top > -1) top--; }
            else stack[++top] = s;
        }

        return "/" + string.Join("/", stack[..(top + 1)]);
    }
}