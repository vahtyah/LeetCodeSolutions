public class Solution {
    public IList<string> StringMatching(string[] words) {
        return words.Where(x => words.Where(w => w != x).Any(w => w.Contains(x))).ToList();
    }
}

// Use Brute Force algorithm to solve the problem becase the input size is small (n <= 100 && 1 <= words[i].Length <= 30)