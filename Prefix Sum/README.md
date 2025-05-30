# Prefix Sum Algorithm

The **Prefix Sum** algorithm is an efficient technique used to calculate the sum of elements in a subarray of a larger array. Instead of recalculating the sum each time, the algorithm precomputes a `prefix sum` array that allows fast querying of the sum over any subarray.

## Key Concepts

1. **Input:** An array of numbers (e.g., `int[] input`). 
2. **Output:** Output: A new array (often called `prefixSum` or `cumulativeSum`) of the same size as the input, where each element at index `i` in the `prefixSum` array stores the sum of all elements in the `input` array from index `0` to `i`.
3. **Logic:**  
  - `prefixSum[0]` is initialized with `input[0]`.
  - For each subsequent element `i` (from `1` to the end of the array),` prefixSum[i]` is calculated as `prefixSum[i-1] + input[i]`. In other words, it's the sum of the previous prefix sum and the current element in the input array.
4. **Time complexity:** `O(n)`

## Technicals

<details>
  <summary>1D Prefix Sum: Quick range sum queries O(1)</summary>

````csharp
// Mảng gốc:    [1, 2, 3, 4, 5]
// Prefix Sum:   [1, 3, 6, 10, 15]

public int[] Build1DPrefixSum(int[] arr) {
    int n = arr.Length;
    int[] prefix = new int[n];
    prefix[0] = arr[0];
    
    for(int i = 1; i < n; i++) {
        prefix[i] = prefix[i-1] + arr[i];
    }
    return prefix;
}

// Get sum of range [1,3]: prefix[3] - prefix[0] = 10 - 1 = 9 (2+3+4)

````

</details>

<details>
  <summary>2D Prefix Sum: Rectangle/submatrix sum queries</summary>

````csharp
// Ma trận gốc:
// 1 2 3
// 4 5 6
// 7 8 9

// Prefix Sum Matrix:
// [1,  3,  6 ]
// [5,  12, 21]
// [12, 27, 45]

public int[,] Build2DPrefixSum(int[,] matrix) {
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int[,] prefix = new int[n,m];
    
    // Copy phần tử đầu tiên
    prefix[0,0] = matrix[0,0];
    
    // Điền hàng đầu tiên
    for(int j = 1; j < m; j++)
        prefix[0,j] = prefix[0,j-1] + matrix[0,j];
        
    // Điền cột đầu tiên
    for(int i = 1; i < n; i++)
        prefix[i,0] = prefix[i-1,0] + matrix[i,0];
        
    // Điền phần còn lại
    for(int i = 1; i < n; i++) {
        for(int j = 1; j < m; j++) {
            prefix[i,j] = prefix[i-1,j] + prefix[i,j-1] 
                         - prefix[i-1,j-1] + matrix[i,j];
        }
    }
    return prefix;
}
````

</details>

<details>
  <summary>Difference Array: Efficient range updates</summary>

````csharp
public int[] BuildDifferenceArray(int[] arr) {
    // Original Array: [1, 2, 3, 4, 5]
    // Difference:     [1, 1, 1, 1, 1, 0]
    // Each element shows the difference between consecutive elements
    int n = arr.Length;
    int[] diff = new int[n + 1];
    
    diff[0] = arr[0];
    for(int i = 1; i < n; i++) {
        diff[i] = arr[i] - arr[i-1];
    }
    return diff;
}
````

</details>


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

[0238. Product of Array Except Self](/Prefix%20Sum%2F0238.%20Product%20of%20Array%20Except%20Self): Calculate the product of all elements in an array except the current element.

[1352. Product of the Last K Numbers](/Prefix%20Sum%2F1352.%20Product%20of%20the%20Last%20K%20Numbers): Design a data structure to efficiently compute the product of the last k elements

[1524. Number of Sub-arrays With Odd Sum](/Prefix%20Sum%2F1524.%20Number%20of%20Sub-arrays%20With%20Odd%20Sum): Count sub-arrays having odd sum given an array

[1769. Minimum Number of Operations to Move All Balls to Each Box](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/1769.%20Minimum%20Number%20of%20Operations%20to%20Move%20All%20Balls%20to%20Each%20Box): Calculate the minimum number of operations needed to move all balls to each box.

[1930. Unique Length-3 Palindromic Subsequences](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum%2F1930.%20Unique%20Length-3%20Palindromic%20Subsequences): Find the number of unique length-3 palindromic subsequences in a string.

[2017. Grid Game](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2017.%20Grid%20Game): Find the minimum sum of the maximum values of two paths in a grid.

[2145. Count the Hidden Sequences](/Prefix%20Sum%2F2145.%20Count%20the%20Hidden%20Sequences): Determine how many valid hidden sequences exist

[2270. Number of Ways to Split Array](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2270.%20Number%20of%20Ways%20to%20Split%20Array): Find the number of ways to split an array into three non-empty subarrays such that the sum of elements in each subarray is the same.

[2300. Successful Pairs of Spells and Potions](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2300.%20Successful%20Pairs%20of%20Spells%20and%20Potions): Find the number of successful pairs of spells and potions that can be created.

[2381. Shifting Letters II](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2381.%20Shifting%20Letters%20II): Shift the letters of a string by a given number of positions.

[2559. Count Vowel Strings in Ranges](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/2559.%20Count%20Vowel%20Strings%20in%20Ranges): Count the number of strings that consist of vowels only in a given range.

[2845. Count of Interesting Subarrays](/Prefix%20Sum%2F2845.%20Count%20of%20Interesting%20Subarrays): Count subarrays with a specified count of "interesting" elements

[3356. Zero Array Transformation II](/Prefix%20Sum%2F3356.%20Zero%20Array%20Transformation%20II): Transform array `a` to zero array using given operations
