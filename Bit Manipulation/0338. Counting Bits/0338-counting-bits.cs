public class Solution {
    public int[] CountBits(int n) {
        var answer = new int[n + 1];

        for(int i = 1; i <= n; i++){
            answer[i] = answer[i >> 1] + (i & 1); // i & 1 is equivalent to i % 2
        }
        
        // for(int i = 1; i <= n; i++){
        //     answer[i] = answer[i & (i - 1)] + 1; // i & (i - 1) is equivalent to i & (i - 1)
        // }
        
        // for(int i = 0; i <= n; i++){
        //     answer[i] = Int32.PopCount(i);
        // }

        return answer;
    }
}