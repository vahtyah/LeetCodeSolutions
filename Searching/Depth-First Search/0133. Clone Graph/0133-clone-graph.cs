namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0133. Clone Graph
 * Difficulty: Medium
 * Submission Time: 2025-03-02 20:41:33
 * Created by vahtyah on 2025-03-02 20:41:56
*/
 
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        var visited = new Dictionary<Node, Node>();
        return CloneNode(node, visited);
    }
    
    private Node CloneNode(Node node, Dictionary<Node, Node> visited) {
        if (visited.TryGetValue(node, out Node clone)) return clone;
            
        clone = new Node(node.val);
        visited[node] = clone;
        
        foreach (var neighbor in node.neighbors) {
            clone.neighbors.Add(CloneNode(neighbor, visited));
        }
        
        return clone;
    }
}