namespace LeetCodeSolutions.DataStructures/Tree/SegmentTree;

/*
 * 3479. Fruits Into Baskets III
 * Difficulty: Medium
 * Submission Time: 2025-08-06 15:31:02
 * Created by vahtyah on 2025-08-06 15:34:04
*/
 
public class Solution {
    private int[] segTree;
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        if(fruits == null || baskets == null || fruits.Length != baskets.Length)
            return -1; 

        segTree = new int[4*fruits.Length];
        Build(baskets, 0, 0, fruits.Length-1);
        int upplaced = 0;
        foreach(int fruit in fruits){
            if(!FindBasket(0, 0, fruits.Length -1, fruit))
                ++upplaced;
        }

        return upplaced;
    }

    private void Build(int[] baskets, int idx, int low, int high) {
        if (low == high) {
            segTree[idx] = baskets[low];
            return;
        }

        int mid = (low + high) >> 1;

        Build(baskets, 2 * idx + 1, low, mid);
        Build(baskets, 2 * idx + 2, mid + 1, high);

        segTree[idx] = Math.Max(segTree[2 * idx + 1], segTree[2 * idx + 2]);
    }

    private bool FindBasket(int idx, int low, int high, int k) {
        if (segTree[idx] < k)
            return false;
        if (low == high) {
            segTree[idx] = 0;
            return true;
        }

        int mid = (low + high) >> 1;
        bool found;

        if (segTree[2 * idx + 1] >= k)
            found = FindBasket(2 * idx + 1, low, mid, k);
        else
            found = FindBasket(2 * idx + 2, mid + 1, high, k);

        segTree[idx] = Math.Max(segTree[2 * idx + 1], segTree[2 * idx + 2]);

        return found;
    }
}