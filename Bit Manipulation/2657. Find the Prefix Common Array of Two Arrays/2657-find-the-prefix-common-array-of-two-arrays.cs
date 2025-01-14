public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int n = A.Length, common = 0;
        int[] C = new int[n], commonArray = new int[n + 1];

        for (int i = 0; i < n; i++) {
            commonArray[A[i]] ^= A[i];
            if (commonArray[A[i]] == 0) common++;

            commonArray[B[i]] ^= B[i];
            if (commonArray[B[i]] == 0) common++;

            C[i] = common;
        }

        return C;
    }
}

public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        var numFreq = new int[51];
        var commonCount = 0;
        for(int i = 0; i <  A.Length; i++){
            numFreq[A[i]]++;
            numFreq[B[i]]++;
            if(numFreq[A[i]] > 1) commonCount++;
            if(numFreq[B[i]] > 1 && A[i] != B[i]) commonCount++;
            A[i] = commonCount;
        }

        return A;
    }
}