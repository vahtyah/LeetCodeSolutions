# Prefix Sum Algorithm

The **Prefix Sum** algorithm is an efficient technique used to calculate the sum of elements in a subarray of a larger array. Instead of recalculating the sum each time, the algorithm precomputes a `prefix sum` array that allows fast querying of the sum over any subarray.

## Key Concepts

1. **Input:** An array of numbers (e.g., `int[] input`). 
2. **Output:** Output: A new array (often called `prefixSum` or `cumulativeSum`) of the same size as the input, where each element at index `i` in the `prefixSum` array stores the sum of all elements in the `input` array from index `0` to `i`.
3. **Logic:**  
  - `prefixSum[0]` is initialized with `input[0]`.
  - For each subsequent element `i` (from `1` to the end of the array),` prefixSum[i]` is calculated as `prefixSum[i-1] + input[i]`. In other words, it's the sum of the previous prefix sum and the current element in the input array.
4. **Time complexity:** `O(n)`

## C# Implementation

```csharp
public static int[] CalculatePrefixSum(int[] input)
{
    if (input == null || input.Length == 0)
    {
        return new int[0]; // Handle empty or null input
    }

    int[] prefixSum = new int[input.Length];
    prefixSum[0] = input[0]; // Initialize the first element

    for (int i = 1; i < input.Length; i++)
    {
        prefixSum[i] = prefixSum[i - 1] + input[i]; // Calculate the running sum
    }

    return prefixSum;
}
```
## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[1422. Maximum Score After Splitting a String](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/1422.%20Maximum%20Score%20After%20Splitting%20a%20String): Find the maximum score after splitting a string into two non-empty substrings.

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[2270. Number of Ways to Split Array](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2270.%20Number%20of%20Ways%20to%20Split%20Array): Find the number of ways to split an array into three non-empty subarrays such that the sum of elements in each subarray is the same.

[2300. Successful Pairs of Spells and Potions](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2300.%20Successful%20Pairs%20of%20Spells%20and%20Potions): Find the number of successful pairs of spells and potions that can be created.

[2559. Count Vowel Strings in Ranges](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2559.%20Count%20Vowel%20Strings%20in%20Ranges): Count the number of strings that consist of vowels only in a given range.

