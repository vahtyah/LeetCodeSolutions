namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0117. Populating Next Right Pointers in Each Node II
 * Difficulty: Medium
 * Submission Time: 2025-02-27 18:16:39
 * Created by vahtyah on 2025-02-27 18:21:17
*/
 
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if (root == null)
            return null;
            
        Node cur = root;
        
        while (cur != null) {
            Node dummy = new Node(0); 
            Node prev = dummy;
            
            while (cur != null) {
                if (cur.left != null) {
                    prev.next = cur.left;
                    prev = prev.next;
                }
                if (cur.right != null) {
                    prev.next = cur.right;
                    prev = prev.next;
                }
                cur = cur.next;
            }
            
            cur = dummy.next;
        }
        
        return root;
    }
}