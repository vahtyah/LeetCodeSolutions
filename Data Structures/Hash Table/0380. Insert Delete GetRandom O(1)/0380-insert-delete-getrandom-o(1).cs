namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0380. Insert Delete GetRandom O(1)
 * Difficulty: Medium
 * Submission Time: 2025-01-30 15:44:32
 * Created by vahtyah on 2025-01-30 15:46:41
 */
 
public class RandomizedSet {
    private const int InitialCapacity = 16;
    private int[] values;
    private int count;
    
    private Dictionary<int, int> valueToIndex;
    private Random random;

    public RandomizedSet() {
        values = new int[InitialCapacity];
        valueToIndex = new Dictionary<int, int>(InitialCapacity);
        random = new Random();
        count = 0;
    }
    
    public bool Insert(int val) {
        if (valueToIndex.ContainsKey(val))
            return false;
            
        if (count == values.Length)
            Array.Resize(ref values, values.Length * 2);
            
        values[count] = val;
        valueToIndex[val] = count;
        count++;
        return true;
    }
    
    public bool Remove(int val) {
        if (!valueToIndex.TryGetValue(val, out int indexToRemove))
            return false;
            
        count--;
        if (indexToRemove < count)
        {
            int lastValue = values[count];
            values[indexToRemove] = lastValue;
            valueToIndex[lastValue] = indexToRemove;
        }
        
        valueToIndex.Remove(val);
        
        if (count > 0 && count < values.Length / 4)
            Array.Resize(ref values, values.Length / 2);
            
        return true;
    }
    
    public int GetRandom() {
        if (count == 0)
            throw new InvalidOperationException("Set is empty");
            
        return values[random.Next(count)];
    }
    
    public int Capacity => values.Length;
    public int Count => count;
}