namespace LeetCodeSolutions.SlidingWindow;

/*
 * 0030. Substring with Concatenation of All Words
 * Difficulty: Hard
 * Submission Time: 2025-02-10 17:07:31
 * Created by vahtyah on 2025-02-10 17:08:01
*/
 
public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0)
            return new List<int>();

        var result = new List<int>();
        int wordLength = words[0].Length;
        int totalLength = wordLength * words.Length;
        
        if (s.Length < totalLength)
            return result;

        // Create frequency map of words
        var wordFreq = new Dictionary<string, int>();
        foreach (var word in words) {
            if (!wordFreq.ContainsKey(word))
                wordFreq[word] = 0;
            wordFreq[word]++;
        }

        // For each possible starting position
        for (int i = 0; i < wordLength; i++) {
            // Use sliding window approach
            var currentFreq = new Dictionary<string, int>();
            int left = i;
            int count = 0;

            for (int j = i; j <= s.Length - wordLength; j += wordLength) {
                string currentWord = s.Substring(j, wordLength);

                // If this is a valid word in our dictionary
                if (wordFreq.ContainsKey(currentWord)) {
                    // Add to current window
                    if (!currentFreq.ContainsKey(currentWord))
                        currentFreq[currentWord] = 0;
                    currentFreq[currentWord]++;
                    count++;

                    // Remove words from the left if we have too many
                    while (currentFreq[currentWord] > wordFreq[currentWord] || 
                           (j + wordLength - left) / wordLength > words.Length) {
                        string leftWord = s.Substring(left, wordLength);
                        currentFreq[leftWord]--;
                        if (currentFreq[leftWord] == 0)
                            currentFreq.Remove(leftWord);
                        left += wordLength;
                        count--;
                    }

                    // If we have found all words
                    if (count == words.Length) {
                        result.Add(left);
                        // Move the left pointer and update counts
                        string leftWord = s.Substring(left, wordLength);
                        currentFreq[leftWord]--;
                        if (currentFreq[leftWord] == 0)
                            currentFreq.Remove(leftWord);
                        left += wordLength;
                        count--;
                    }
                } else {
                    // Reset the window
                    currentFreq.Clear();
                    count = 0;
                    left = j + wordLength;
                }
            }
        }

        return result;
    }
}