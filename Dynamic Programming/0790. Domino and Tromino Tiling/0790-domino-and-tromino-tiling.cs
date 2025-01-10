public class Solution {
    private const int MOD = 1_000_000_007;
    
    public int NumTilings(int n) {
        if (n < 3) return n;
        
        long a = 1; 
        long b = 1; 
        long c = 2;
        
        for (int i = 3; i <= n; i++) {
            long next = (c * 2 + a) % MOD;
            a = b;
            b = c;
            c = next;
        }
        
        return (int)c;
    }
}