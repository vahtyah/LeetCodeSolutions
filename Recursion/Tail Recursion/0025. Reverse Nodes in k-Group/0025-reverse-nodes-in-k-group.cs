namespace LeetCodeSolutions.Recursion/TailRecursion;

/*
 * 0025. Reverse Nodes in k-Group
 * Difficulty: Hard
 * Submission Time: 2025-02-22 19:37:27
 * Created by vahtyah on 2025-03-01 07:50:03
*/
 
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(k == 1) return head;
        var prev = new ListNode(0, head);
        Recursion(prev, k);
        return prev.next;
    }

    public void Recursion(ListNode prev, int k, bool isLast = false){
        var current = prev?.next ?? null;
        var next = current?.next ?? null;
        
        for(int i = 1; i < k; i++){
            if(current == null || current.next == null) {
                if(isLast) return;
                Recursion(prev, k, true);
                return;
            }
            next = current.next;
            current.next = next.next;
            next.next = prev.next;
            prev.next = next;
        }

        Recursion(current, k);
    }
}