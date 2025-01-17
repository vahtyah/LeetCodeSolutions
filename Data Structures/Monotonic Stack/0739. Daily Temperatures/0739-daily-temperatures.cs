public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        var result = new int[n];
        var stack = new Stack<int>();

        for(int i = 0; i < n; i++){
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]){
                int idx = stack.Pop();
                result[idx] = i - idx;
            }
            stack.Push(i);
        }

        return result;
    }
}