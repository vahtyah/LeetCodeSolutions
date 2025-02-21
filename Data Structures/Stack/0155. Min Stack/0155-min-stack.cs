namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0155. Min Stack
 * Difficulty: Medium
 * Submission Time: 2025-02-21 13:11:33
 * Created by vahtyah on 2025-02-21 13:12:39
*/
 
public class MinStack {
    int[][] stack = new int[16][];
    int top = 0;
    public MinStack() {
        stack[0] = new int[]{0, int.MaxValue};
    }
    
    public void Push(int val) {
        if(stack.Length == top + 1) Array.Resize(ref stack, stack.Length * 2);
        stack[++top] = new int[] {val, Math.Min(val, stack[top - 1][1])};
    }
    
    public void Pop() {
        top--;
    }
    
    public int Top() {
        return stack[top][0];
    }
    
    public int GetMin() {
        return stack[top][1];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */