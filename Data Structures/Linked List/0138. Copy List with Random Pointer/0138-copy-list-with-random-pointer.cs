namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 0138. Copy List with Random Pointer
 * Difficulty: Medium
 * Submission Time: 2025-02-22 13:00:08
 * Created by vahtyah on 2025-02-22 13:03:23
*/
 
public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        
        Node curr, next, copy;
        
        // Step 1: Create interleaved list with optimized pointer handling
        curr = head;
        while (curr != null) {
            next = curr.next;
            curr.next = new Node(curr.val) { next = next };
            curr = next;
        }
        
        // Step 2: Optimize random pointer connections with direct addressing
        curr = head;
        while (curr != null) {
            copy = curr.next;
            copy.random = curr.random?.next;
            curr = copy.next;
        }
        
        // Step 3: Optimize list separation with minimal pointer operations
        Node newHead = head.next;
        curr = head;
        
        while (curr != null) {
            copy = curr.next;
            next = copy.next;
            
            curr.next = next;
            copy.next = next?.next;
            
            curr = next;
        }
        
        return newHead;
    }
}