namespace LeetCodeSolutions.Sorting/CountingSort;

/*
 * 0274. H-Index
 * Difficulty: Medium
 * Submission Time: 2025-01-30 14:42:47
 * Created by vahtyah on 2025-01-30 14:53:04
 */
 
public class Solution {
    public int HIndex(int[] citations) {
        int n = citations.Length;
        int[] buckets = new int[n + 1];
        
        foreach(int citation in citations) {
            if(citation >= n) {
                buckets[n]++;
            } else {
                buckets[citation]++;
            }
        }
        
        int count = 0;
        for(int i = n; i >= 0; i--) {
            count += buckets[i];
            if(count >= i) return i;
        }
        
        return 0;
    }
}

public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations, (a, b) => b.CompareTo(a));
        
        var hIndex = 0;
        for(int i = 0; i < citations.Length; i++){
            if(citations[i] >= i + 1) hIndex = i + 1;
            else break;
        }

        return hIndex;
    }
}