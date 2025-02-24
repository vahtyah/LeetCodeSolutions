namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 0146. LRU Cache
 * Difficulty: Medium
 * Submission Time: 2025-02-24 19:49:14
 * Created by vahtyah on 2025-02-24 19:56:34
*/
 
public class ListNode
{
    public int value;
    public int key;
    public ListNode next;
    public ListNode prev;
    public ListNode(int _value = 0, int _key = 0, ListNode _next = null, ListNode _prev = null)
    {
        value = _value;
        key = _key;
        next = _next;
        prev = _prev;
    }

    public static void AddNode(ListNode node, ListNode head)
    {
        node.next = head.next; 
        head.next.prev = node; 
        head.next = node;      
        node.prev = head;      
    }

    public static void DeleteNode(ListNode node)
    {
         node.prev.next = node.next;
        node.next.prev = node.prev; 
        node.next = null;
        node.prev = null;
    }
}

public class LRUCache
{
    int size;
    int capacity;
    public ListNode head;
    ListNode last;
    ListNode[] map;
    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        head = new(-1, -1);  
        map = new ListNode[10001]; 
        last = new(-1, -1); 
        head.next = last;
        last.prev = head;
        size = 0;
    }

    public int Get(int key)
    {
         if (map[key] != null)  
        {
            ListNode node = map[key]; 
            ListNode.DeleteNode(node); 
            ListNode.AddNode(node, head); 
            return node.value; 
        }
        return -1; 
    }

    public void Put(int key, int value)
    {
        ListNode node;
        if (map[key] != null)  
        {
            node = map[key];
            node.value = value;
            ListNode.DeleteNode(node);
            ListNode.AddNode(node, head);
        }
        else 
        {
            node = new(value, key);
            ListNode.AddNode(node, head);
            size++;
            map[key] = node;
        }

        if (size > capacity)
        {
            map[last.prev.key] = null;
            ListNode.DeleteNode(last.prev);
            size--;
        }
    }
}