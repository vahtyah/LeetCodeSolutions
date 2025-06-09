# Trie

A trie is a tree-like data structure that stores a dynamic set of strings. It is used to store strings that can be searched efficiently. A trie is also known as a prefix tree because it stores strings by their prefixes.

## Key Concepts

1. **Node Structure:** A trie is composed of nodes that store the following components:
   - A value (e.g., `char val`).
   - A boolean flag to indicate the end of a word (e.g., `bool isEnd`).
   - An array or dictionary to store child nodes (e.g., `Dictionary<char, TrieNode> children`).
2. **Root Node:** The root node of a trie is typically an empty node with no value.
3. **Insertion:** To insert a string into a trie, you iterate through each character of the string and create a new node if the character does not exist in the current node's children.
4. **Search:** To search for a string in a trie, you traverse the trie by following the characters of the string. If you reach the end of the string and the current node is marked as the end of a word, the string exists in the trie.
5. **Time Complexity:** 
   - Insertion: `O(n)`, where `n` is the length of the string.
   - Search: `O(n)`, where `n` is the length of the string.

## C# Example
```csharp
public class TrieNode
{
    public char Val { get; set; }
    public bool IsEnd { get; set; }
    public Dictionary<char, TrieNode> Children { get; set; }

    public TrieNode(char val)
    {
        Val = val;
        IsEnd = false;
        Children = new Dictionary<char, TrieNode>();
    }
}

public class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode(' ');
    }

    public void Insert(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
            {
                node.Children[c] = new TrieNode(c);
            }
            node = node.Children[c];
        }
        node.IsEnd = true;
    }

    public bool Search(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return node.IsEnd;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode node = root;
        foreach (char c in prefix)
        {
            if (!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return true;
    }
}

public class MainClass
{
    public static void Main()
    {
        Trie trie = new Trie();
        trie.Insert("apple");
        Console.WriteLine(trie.Search("apple"));  // Output: True
        Console.WriteLine(trie.Search("app"));    // Output: False
        Console.WriteLine(trie.StartsWith("app")); // Output: True
        trie.Insert("app");
        Console.WriteLine(trie.Search("app"));    // Output: True
    }
}

//Faster
public class Trie{
    private bool isEnd;
    Trie[] children = new Trie[26];
    
    public Trie(){}
    
    public void Insert(string word){
        Trie node = this;
        foreach(char c in word){
            if(node.children[c - 'a'] == null){
                node.children[c - 'a'] = new Trie();
            }
            node = node.children[c - 'a'];
        }
        node.isEnd = true;
    }
    
    public bool Search(string word){
        Trie node = SearchPrefix(word);
        return node != null && node.isEnd;
    }
    
    public bool StartsWith(string prefix){
        return SearchPrefix(prefix) != null;
    }
    
    private Trie SearchPrefix(string prefix){
        Trie node = this;
        foreach(char c in prefix){
            if(node.children[c - 'a'] == null){
                return null;
            }
            node = node.children[c - 'a'];
        }
        return node;
    }
    
}
```


## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0211. Design Add and Search Words Data Structure](/Data%20Structures%2FTrie%2F0211.%20Design%20Add%20and%20Search%20Words%20Data%20Structure): Implement add and search for words, supporting '.' wildcard

[1268. Search Suggestions System](/Data%20Structures%2FTrie%2F1268.%20Search%20Suggestions%20System): Suggest products based on a search word with prefix matching

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0212. Word Search II](/Data%20Structures%2FTrie%2F0212.%20Word%20Search%20II): Find all words from a list present in a board

[0440. K-th Smallest in Lexicographical Order](/Data%20Structures%2FTrie%2F0440.%20K-th%20Smallest%20in%20Lexicographical%20Order): Find the k-th smallest number lexicographically in [1, n]
