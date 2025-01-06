public class Solution {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length;
        int[] answer = new int[n];
        // left part
        for (int i = 0, balls = 0, ops = 0; i < n; i++) {
            answer[i] = ops;
            balls += boxes[i] - '0';
            ops += balls;
        }
        // right part
        for (int i = n - 1, balls = 0, ops = 0; i >= 0; i--) {
            answer[i] += ops;
            balls += boxes[i] - '0';
            ops += balls;
        }
        
        return answer;
    }
}