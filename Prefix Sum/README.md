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
## Use Cases
- **Range Sum Queries:** Quickly find the sum of elements between two indices `[L,R]` in an array with `O(1)` time complexity.
```csharp
static int GetRangeSum(int[] prefixSum, int start, int end)
{
    return (start > 0) ? prefixSum[end] - prefixSum[start - 1] : prefixSum[end];
}
```
- **Subarray Sum Equals K:** Find the total number of continuous subarrays whose sum equals a target value `k`.
- **Maximum Subarray Sum:** Find the maximum sum of a contiguous subarray within an array of numbers.
- **Count Vowel Strings in Ranges:** Count the number of strings in a range that start and end with a vowel.
- **Count Submatrices With All Ones:** Count the number of submatrices that consist of only ones.
- **Count Substrings That Differ by One Character:** Count the number of substrings that differ by exactly one character.
- **Count Substrings with Only One Distinct Letter:** Count the number of substrings with only one distinct letter.
- **Count Substrings That Have the Same Number of Zeros and Ones:** Count the number of substrings with an equal number of zeros and ones.
- **Count Substrings with All Characters the Same:** Count the number of substrings with all characters being the same.
- **Count Substrings That Have All Characters the Same:** Count the number of substrings with all characters being the same.
- **Count Substrings That Have Only One Distinct Letter:** Count the number of substrings with only one distinct letter.
- **Count Substrings That Have Only One Distinct Character:** Count the number of substrings with only one distinct character.
- **Count Substrings That Have Only One Distinct Digit:** Count the number of substrings with only one distinct digit.
- **Count Substrings That Have Only One Distinct Number:** Count the number of substrings with only one distinct number.
- **Count Substrings That Have Only One Distinct Symbol:** Count the number of substrings with only one distinct symbol.
- **Count Substrings That Have Only One Distinct Special Character:** Count the number of substrings with only one distinct special character.
