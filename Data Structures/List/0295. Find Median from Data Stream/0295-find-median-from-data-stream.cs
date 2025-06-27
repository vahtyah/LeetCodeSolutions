namespace LeetCodeSolutions.DataStructures/List;

/*
 * 0295. Find Median from Data Stream
 * Difficulty: Hard
 * Submission Time: 2025-06-27 11:43:39
 * Created by vahtyah on 2025-06-27 11:45:07
*/
 
public class MedianFinder {
    SortedList<int, int> sortedList;

    public MedianFinder() {
        sortedList = new(Comparer<int>.Create((a, b) => { return a == b ? 1 : b - a; }));
    }
    
    public void AddNum(int num) {
        sortedList.Add(num, num);
    }
    
    public double FindMedian() {
        int size = sortedList.Count;
        int mid = size / 2;
        if (size % 2 != 0) return sortedList.GetKeyAtIndex(mid);
        return (sortedList.GetKeyAtIndex(mid) + sortedList.GetKeyAtIndex(mid - 1)) / (double)2;
    }
}