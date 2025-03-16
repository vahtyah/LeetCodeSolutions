namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2594. Minimum Time to Repair Cars
 * Difficulty: Medium
 * Submission Time: 2025-03-16 04:58:16
 * Created by vahtyah on 2025-03-16 04:58:40
*/
 
public class Solution {
    public long RepairCars(int[] ranks, int cars)
    {
        var rankFreq = new int[101];
        var minRank = long.MaxValue;
        foreach(var rank in ranks){
            rankFreq[rank]++;
            minRank = Math.Min(minRank, rank);
        }

        var left = 1L;
        var right = minRank * cars * cars;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            
            if (CanRepairAllCars(rankFreq, cars, mid)) right = mid;
            else left = mid + 1;
        }
        
        return left;
    }

    private bool CanRepairAllCars(int[] rankFreq, int cars, long time)
    {
        var totalCarsRepaired = 0L;
        
        for(int i = 0; i < rankFreq.Length; i++){
            if(rankFreq[i] < 1) continue;
            totalCarsRepaired += (long)Math.Sqrt(time / i) * rankFreq[i];
            if (totalCarsRepaired >= cars) return true;
        }
        
        return false;
    }
}