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