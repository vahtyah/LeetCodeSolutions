namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 1865. Finding Pairs With a Certain Sum
 * Difficulty: Medium
 * Submission Time: 2025-07-06 08:26:28
 * Created by vahtyah on 2025-07-06 08:26:53
*/
 
public class FindSumPairs {
    private readonly Dictionary<int, int> freq1;
    private readonly Dictionary<int, int> freq2;
    private readonly int[] nums2;
    
    public FindSumPairs(int[] nums1, int[] nums2) {
        this.nums2 = nums2;
        
        this.freq1 = new Dictionary<int, int>(nums1.Length);
        this.freq2 = new Dictionary<int, int>(nums2.Length);
        
        foreach (int num in nums2) freq2[num] = freq2.GetValueOrDefault(num, 0) + 1;
        foreach (int num in nums1) freq1[num] = freq1.GetValueOrDefault(num, 0) + 1;
    }
    
    public void Add(int index, int val) {
        int oldValue = nums2[index];
        
        if (--freq2[oldValue] == 0) {
            freq2.Remove(oldValue);
        }
        
        nums2[index] += val;
        int newValue = nums2[index];
        
        freq2.TryGetValue(newValue, out int count);
        freq2[newValue] = count + 1;
    }
    
    public int Count(int tot) {
        int count = 0;
        
        foreach (var kvp in freq1) {
            int complement = tot - kvp.Key;
            if (freq2.TryGetValue(complement, out int freq2Count)) {
                count += kvp.Value * freq2Count;
            }
        }
        
        return count;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */