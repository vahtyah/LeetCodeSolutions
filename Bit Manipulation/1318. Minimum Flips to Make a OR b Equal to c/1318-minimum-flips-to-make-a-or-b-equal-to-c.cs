public class Solution {
    public int MinFlips(int a, int b, int c) {
        int flips = 0;
        
        // Process all bits
        while (a > 0 || b > 0 || c > 0) {
            // Get the least significant bit of each number
            int bitA = a & 1;
            int bitB = b & 1;
            int bitC = c & 1;
            
            // Case 1: If target bit is 0
            if (bitC == 0) {
                flips += bitA + bitB; // Need to flip all 1s to 0s
            }
            // Case 2: If target bit is 1
            else {
                if (bitA == 0 && bitB == 0) {
                    flips += 1; // Need at least one 1
                }
            }
            
            // Right shift all numbers
            a >>= 1;
            b >>= 1;
            c >>= 1;
        }
        
        return flips;
    }
}