public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        long sum = 0;

        if(costs.Length == k){
            foreach(int i in costs) sum += i;
            return sum;
        }

        int left = -1; //pointer to the left
        int right = costs.Length; //pointer to the right

        var leftPriority = new PriorityQueue<int, int>();
        var rightPriority = new PriorityQueue<int, int>();

        for(int i = 0; i < candidates; i++){
            if(left >= right - 2) break;
            left++;
            leftPriority.Enqueue(costs[left], costs[left]);
            right--;
            rightPriority.Enqueue(costs[right], costs[right]);
        }

        for(int i = 0; i < k; i++){

            if(rightPriority.Count <= 0 && leftPriority.Count > 0){
                sum += leftPriority.Dequeue();
                continue;
            }
            if(leftPriority.Count <= 0 && rightPriority.Count > 0){
                sum += rightPriority.Dequeue();
                continue;
            }

            if(leftPriority.Peek() <= rightPriority.Peek()){
                sum += leftPriority.Dequeue();
                if(left < right - 1){
                    left++;
                    leftPriority.Enqueue(costs[left], costs[left]);
                }
            }
            else{
                sum += rightPriority.Dequeue();
                if(right > left + 1){
                    right--;
                    rightPriority.Enqueue(costs[right], costs[right]);
                }
            }
        }
        return sum;
    }
}

public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        long sum = 0;

        if(costs.Length == k){
            foreach(int i in costs) sum += i;
            return sum;
        }

        int left = -1;
        int right = costs.Length;

        var minHeap = new PriorityQueue<(int, int), (int, int)>();

        for(int i = 0; i < candidates; i++){
            if(left >= right - 2) break;
            left++;
            right--;
            minHeap.Enqueue((costs[left], left), (costs[left], left));
            if (left < right) minHeap.Enqueue((costs[right], right), (costs[right], right));
        }

        for(int i = 0; i < k; i++){
            var item = minHeap.Dequeue();
            sum += item.Item1;

            if(left < right - 1){
                if(item.Item2 <= left){
                    left++;
                    minHeap.Enqueue((costs[left], left), (costs[left], left));
                }
                else{
                    right--;
                    minHeap.Enqueue((costs[right], right), (costs[right], right));
                }
            }
        }

        return sum;
    }
}