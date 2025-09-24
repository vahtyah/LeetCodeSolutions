namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0166. Fraction to Recurring Decimal
 * Difficulty: Medium
 * Submission Time: 2025-09-24 13:20:24
 * Created by vahtyah on 2025-09-24 13:22:26
*/
 
public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if (numerator == 0) return "0";
        
        var result = new StringBuilder();
        
        if ((numerator > 0) ^ (denominator > 0)) {
            result.Append('-');
        }
        
        long num = Math.Abs((long)numerator);
        long den = Math.Abs((long)denominator);
        
        result.Append(num / den);
        num %= den;
        
        if (num == 0) return result.ToString();
        
        result.Append('.');
        var remainderMap = new Dictionary<long, int>();
        
        while (num != 0) {
            if (remainderMap.ContainsKey(num)) {
                int index = remainderMap[num];
                result.Insert(index, '(');
                result.Append(')');
                break;
            }
            
            remainderMap[num] = result.Length;
            num *= 10;
            result.Append(num / den);
            num %= den;
        }
        
        return result.ToString();
    }
}