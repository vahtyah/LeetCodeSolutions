public class Solution {
    public int MinimizeXor(int num1, int num2) {
        int targetBits = Int32.PopCount(num2);
        int num1Bits = Int32.PopCount(num1);
        
        if (num1Bits == targetBits) return num1;
        
        int result = num1;
        if (targetBits > num1Bits) {
            for (int i = 0; i < 32 && targetBits > num1Bits; i++) {
                if ((num1 & (1 << i)) == 0) {
                    result |= (1 << i); // set bit
                    num1Bits++;
                }
            }
        }
        else {
            for (int i = 0; i < 32 && num1Bits > targetBits; i++) {
                if ((num1 & (1 << i)) != 0) {
                    result &= ~(1 << i); // unset bit
                    num1Bits--;
                }
            }
        }
        return result;
    }
}