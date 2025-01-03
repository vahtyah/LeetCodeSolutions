//Prefix Sum with Time Complexity O(n)
public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        var limitPotions = 100001;
        var prefix = new int[limitPotions]; //prefix number of potions needed to reach success

        foreach(int potion in potions){ //find number of potions needed to reach success
            var neededSpellCost = (int)((success + potion - 1) / potion);
            if(neededSpellCost < limitPotions && neededSpellCost >= 0) prefix[neededSpellCost]++;
        } 

        for(int i = 1; i < limitPotions; i++){ //prefix sum
            prefix[i] += prefix[i - 1];
        }

        var pairs = new int[spells.Length];
        for(int i = 0; i < spells.Length; i++){ //find number of successful pairs
            pairs[i] = prefix[spells[i]];
        }

        return pairs;
    }
}