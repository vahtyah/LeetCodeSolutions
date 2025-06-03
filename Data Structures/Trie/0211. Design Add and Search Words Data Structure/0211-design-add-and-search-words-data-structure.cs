namespace LeetCodeSolutions.DataStructures/Trie;

/*
 * 0211. Design Add and Search Words Data Structure
 * Difficulty: Medium
 * Submission Time: 2025-06-03 06:50:11
 * Created by vahtyah on 2025-06-03 06:50:40
*/
 
public class TrieNode
{
    public bool IsEndOfWord { get; set; }
    public TrieNode[] Children;

    public TrieNode()
    {
        Children = new TrieNode[26];
        IsEndOfWord = false;
    }
}

public class WordDictionary 
{
    private readonly TrieNode root;

    public WordDictionary() 
    {
        root = new TrieNode();
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void AddWord(string word) 
    {
        var current = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (current.Children[index] == null) 
            {
                current.Children[index] = new TrieNode();
            }
            current = current.Children[index];
        }
        
        current.IsEndOfWord = true;
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public bool Search(string word) 
    {
        return SearchRecursive(word, 0, root);
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private bool SearchRecursive(string word, int index, TrieNode node) 
    {
        if (index == word.Length) 
        {
            return node.IsEndOfWord;
        }
        
        char c = word[index];
        
        if (c == '.') 
        {
            for (int i = 0; i < 26; i++) 
            {
                if (node.Children[i] != null && 
                    SearchRecursive(word, index + 1, node.Children[i])) 
                {
                    return true;
                }
            }
            return false;
        } 
        else 
        {
            int charIndex = c - 'a';
            if (node.Children[charIndex] == null) 
            {
                return false;
            }
            return SearchRecursive(word, index + 1, node.Children[charIndex]);
        }
    }
}