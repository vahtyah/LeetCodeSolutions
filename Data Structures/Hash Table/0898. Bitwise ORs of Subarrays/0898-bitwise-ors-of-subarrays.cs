namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0898. Bitwise ORs of Subarrays
 * Difficulty: Medium
 * Submission Time: 2025-07-31 10:03:14
 * Created by vahtyah on 2025-07-31 10:04:13
*/
 
public class Solution {
    public unsafe int SubarrayBitwiseORs(int[] arr) {
        var result = new HashSet<int>();
        
        const int MAX_UNIQUE = 32;
        int[] prev = new int[MAX_UNIQUE];
        int[] current = new int[MAX_UNIQUE];
        
        fixed (int* pPrev = prev, pCurrent = current) {
            int prevSize = 0;
            
            for (int i = 0; i < arr.Length; i++) {
                int num = arr[i];
                int currentSize = 0;
                
                pCurrent[currentSize++] = num;
                result.Add(num);
                
                for (int j = 0; j < prevSize; j++) {
                    int orValue = pPrev[j] | num;
                    
                    bool duplicate = false;
                    for (int k = 0; k < currentSize; k++) {
                        if (pCurrent[k] == orValue) {
                            duplicate = true;
                            break;
                        }
                    }
                    
                    if (!duplicate) {
                        pCurrent[currentSize++] = orValue;
                        result.Add(orValue);
                    }
                }
                
                for (int j = 0; j < currentSize; j++) {
                    pPrev[j] = pCurrent[j];
                }
                prevSize = currentSize;
            }
        }
        
        return result.Count;
    }
}