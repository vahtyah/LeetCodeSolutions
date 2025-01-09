# String Matching

**String matching** algorithms are used to find the occurrence of a pattern within a text string. These algorithms are often used to solve problems that involve searching, sorting, or manipulating strings.

## Algorithms

### Suffix Tree/Array
- Preprocessing: O(n) to build the tree
- Search: O(m) to search for a pattern of length m
- Space Complexity: O(n)

When to use:
- Large text with multiple pattern searches
- Memory is not a constraint
- Pattern search is frequent
```csharp
public class SuffixTrieNode {
    private SuffixTrieNode[] children = new SuffixTrieNode[256];
    private bool isEndOfWord;
    
    public void Insert(string s, int start) {
        if (start == s.Length) {
            isEndOfWord = true;
            return;
        }
        int index = s[start];
        if (children[index] == null)
            children[index] = new SuffixTrieNode();
        children[index].Insert(s, start + 1);
    }
    
    public bool Search(string s, int start) {
        if (start == s.Length) return isEndOfWord;
        int index = s[start];
        if (children[index] == null) return false;
        return children[index].Search(s, start + 1);
    }
}
```

### KMP (Knuth-Morris-Pratt) Algorithm
- Time Complexity: O(m + n)
- Space Complexity: O(m)

When to use:
- When stable performance is needed
- Pattern has repeated substrings
- Memory is a constraint
- Large text with multiple pattern searches
```csharp
public static List<int> KMPSearch(string text, string pattern)
{
    List<int> positions = new List<int>();
    if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
        return positions;

    int[] lps = ComputeLPSArray(pattern);
    int i = 0, j = 0;

    while (i < text.Length)
    {
        if (pattern[j] == text[i])
        {
            j++;
            i++;
        }

        if (j == pattern.Length)
        {
            positions.Add(i - j);
            j = lps[j - 1];
        }
        else if (i < text.Length && pattern[j] != text[i])
        {
            if (j != 0)
                j = lps[j - 1];
            else
                i++;
        }
    }
    return positions;
}

private static int[] ComputeLPSArray(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int len = 0; // độ dài của previous longest prefix suffix
        
        // lps[0] luôn bằng 0
        lps[0] = 0;
        
        // Tính toán lps[i] cho i = 1 đến M-1
        int i = 1;
        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
        return lps;
    }

```

### Rabin-Karp Algorithm
- Time Complexity: O(m + n)
- Worst Case: O(m * n)
- Space Complexity: O(1)

When to use:
* Multiple pattern search
* Pattern and text are similar in length
* Hash function is well-designed
```csharp
// Độ phức tạp: O(m + n) average, O(mn) worst case
public bool RabinKarpSearch(string pattern, string text) {
    int d = 256; // số ký tự có thể có
    int q = 101; // số nguyên tố
    int m = pattern.Length;
    int n = text.Length;
    int i, j;
    int p = 0; // hash value cho pattern
    int t = 0; // hash value cho text
    int h = 1;
    
    // Tính h = pow(d, m-1) % q
    for (i = 0; i < m - 1; i++)
        h = (h * d) % q;
        
    // Tính hash value ban đầu
    for (i = 0; i < m; i++) {
        p = (d * p + pattern[i]) % q;
        t = (d * t + text[i]) % q;
    }
    
    // Duyệt qua text
    for (i = 0; i <= n - m; i++) {
        if (p == t) {
            // Kiểm tra từng ký tự
            for (j = 0; j < m; j++) {
                if (text[i + j] != pattern[j])
                    break;
            }
            if (j == m) return true;
        }
        
        if (i < n - m) {
            t = (d * (t - text[i] * h) + text[i + m]) % q;
            if (t < 0) t += q;
        }
    }
    return false;
}
```

### Boyer-Moore Algorithm
- Best Case: O(n/m)
- Average Case: O(n)
- Worst Case: O(n * m)
- Space Complexity: O(k) where k is the size of the alphabet

When to use:
* Large alphabet size
* Pattern is relatively long
* Text is clean (few matches)
```csharp
// Độ phức tạp: O(m * n) worst case, nhưng thực tế thường tốt hơn
public bool BoyerMooreSearch(string pattern, string text) {
    int[] badChar = new int[256];
    for (int i = 0; i < 256; i++) 
        badChar[i] = -1;
    
    for (int i = 0; i < pattern.Length; i++)
        badChar[pattern[i]] = i;
        
    int s = 0;
    while (s <= text.Length - pattern.Length) {
        int j = pattern.Length - 1;
        while (j >= 0 && pattern[j] == text[s + j])
            j--;
            
        if (j < 0) return true;
        else
            s += Math.Max(1, j - badChar[text[s + j]]);
    }
    return false;
}
```

### Naive/Brute Force Algorithm (Built-in Contains Method)
- Time Complexity: O(m * n)
- Space Complexity: O(1)

When to use:
* Short texts and patterns
* Simple implementation needed
* Built-in functions available
```csharp
// Độ phức tạp: O(m * n)
public bool NaiveSearch(string pattern, string text) {
    int n = text.Length;
    int m = pattern.Length;
    
    for (int i = 0; i <= n - m; i++) {
        int j;
        for (j = 0; j < m; j++) {
            if (text[i + j] != pattern[j]) break;
        }
        if (j == m) return true;
    }
    return false;
}
```



## Solutions

![Easy](https://img.shields.io/badge/Easy-46c6c2)

[1408. String Matching in an Array](https://github.com/vahtyah/LeetCodeSolutions/tree/main/String%20Matching/1408.%20String%20Matching%20in%20an%20Array): Find all strings in an array that are substrings of another string.

[2185. Counting Words With a Given Prefix](https://github.com/vahtyah/LeetCodeSolutions/tree/main/String%20Matching/2185.%20Counting%20Words%20With%20a%20Given%20Prefix): Count the number of words in a sentence that start with a given prefix.

[3042. Count Prefix and Suffix Pairs I](https://github.com/vahtyah/LeetCodeSolutions/tree/main/String%20Matching/3042.%20Count%20Prefix%20and%20Suffix%20Pairs%20I): Count the number of prefix and suffix pairs in a string array.

[//]: # (![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)

