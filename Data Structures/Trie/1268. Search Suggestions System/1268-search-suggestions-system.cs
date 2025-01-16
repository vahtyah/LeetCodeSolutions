public class Solution {
    class TrieNode {
        public TrieNode[] children;
        public List<string> suggestions;
        
        public TrieNode() {
            children = new TrieNode[26];
            suggestions = new List<string>();
        }
    }
    
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products); // Sort products lexicographically
        var root = new TrieNode();
        
        // Build Trie
        foreach (string product in products) {
            TrieNode node = root;
            for (int i = 0; i < product.Length; i++) {
                int index = product[i] - 'a';
                if (node.children[index] == null) {
                    node.children[index] = new TrieNode();
                }
                node = node.children[index];
                if (node.suggestions.Count < 3) {
                    node.suggestions.Add(product);
                }
            }
        }
        
        var result = new List<IList<string>>();
        TrieNode current = root;
        
        // Search Trie
        for (int i = 0; i < searchWord.Length; i++) {
            int index = searchWord[i] - 'a';
            if (current != null) {
                current = current.children[index];
            }
            result.Add(current?.suggestions ?? new List<string>());
        }
        
        return result;
    }
}

public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        var ans = new List<IList<string>>();
        Array.Sort(products);
        int l = 0;
        int r = products.Length - 1;
        for (int i = 0;i < searchWord.Length;i++)
        {
            var words = new List<string>();
            while (l <= r && (products[l].Length <= i || products[l][i] != searchWord[i]))
                l++;
            while (l <= r && (products[r].Length <= i || products[r][i] != searchWord[i]))
                r--;
            int j = l;
            while (j <= r && words.Count() < 3)
            {
                words.Add(products[j]);
                j++;
            }
            ans.Add(words);
        }
        return ans;
    }
}