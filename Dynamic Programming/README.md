# Dynamic Programming

**Dynamic programming** is a method for solving complex problems by breaking them down into simpler subproblems. It is used when a problem can be broken down into overlapping subproblems and the solution to the main problem can be constructed from the solutions to the subproblems.

## Key Concepts

1. **Input:** A problem that can be broken down into smaller subproblems.
2. **Output:** A valid solution to the problem.
3. **Logic:**
   - Break down the problem into smaller subproblems.
   - Solve the subproblems and store their solutions.
   - Combine the solutions of the subproblems to solve the main problem.
   - Use memoization or tabulation to avoid redundant calculations.
   - Return the final solution.

## C# Example

<details>
<summary><strong>1D</strong></summary>

```csharp
public static int DynamicProgrammingAlgorithm(int[] nums)
{
    int n = nums.Length;
    int[] dp = new int[n];

    dp[0] = nums[0];
    dp[1] = Math.Max(nums[0], nums[1]);

    for (int i = 2; i < n; i++)
    {
        dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
    }

    return dp[n - 1];
}
```
</details>

<details>
<summary><strong>Multi-Dimensional</strong></summary>

```csharp
public static int DynamicProgrammingAlgorithm(int[,] matrix)
{
    int n = matrix.GetLength(0); // Number of rows
    int m = matrix.GetLength(1); // Number of columns
    int[,] dp = new int[n, m];

    dp[0, 0] = matrix[0, 0]; // Initialize the first cell

    for (int i = 1; i < n; i++) // Initialize the first column
    {
        dp[i, 0] = dp[i - 1, 0] + matrix[i, 0];
    }

    for (int j = 1; j < m; j++) // Initialize the first row
    {
        dp[0, j] = dp[0, j - 1] + matrix[0, j];
    }

    for (int i = 1; i < n; i++) // Fill in the rest of the matrix
    {
        for (int j = 1; j < m; j++)
        {
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + matrix[i, j];
        }
    }

    return dp[n - 1, m - 1];
}
```
```csharp
public class Solution {
    public int MaxPathSum(int[,] matrix) {
        int n = matrix.GetLength(0); // rows
        int m = matrix.GetLength(1); // columns
        int[,] dp = new int[n, m];
        
        // Initialize first cell
        dp[0,0] = matrix[0,0];
        
        // Fill first row
        for (int j = 1; j < m; j++) {
            dp[0,j] = dp[0,j-1] + matrix[0,j];
        }
        
        // Fill first column
        for (int i = 1; i < n; i++) {
            dp[i,0] = dp[i-1,0] + matrix[i,0];
        }
        
        // Fill rest of the dp table
        for (int i = 1; i < n; i++) {
            for (int j = 1; j < m; j++) {
                dp[i,j] = Math.Max(dp[i-1,j], dp[i,j-1]) + matrix[i,j];
            }
        }
        
        return dp[n-1,m-1];
    }
}
```
</details>

## Algorithms

<details>
<summary><strong>Kadane's Algorithm</strong>: Find the maximum sum of a subarray within an array.</summary>

```csharp
 public static int FindMaxSubarraySum(int[] arr)
 {
     if (arr == null || arr.Length == 0)
         return 0;
     
     int maxSoFar = arr[0];
     int maxEndingHere = arr[0];
     
     for (int i = 1; i < arr.Length; i++)
     {
         // Either extend the previous subarray or start a new one
         maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
         // Update the maximum sum found so far
         maxSoFar = Math.Max(maxSoFar, maxEndingHere);
     }
     
     return maxSoFar;
 }
```
</details>

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0509. Fibonacci Number](/Dynamic%20Programming%2F0509.%20Fibonacci%20Number): Find the n-th number in the Fibonacci sequence

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0062. Unique Paths](/Dynamic%20Programming%2F0062.%20Unique%20Paths): Find the number of unique paths from the top-left corner to the bottom-right corner of a grid.

[0072. Edit Distance](/Dynamic%20Programming%2F0072.%20Edit%20Distance): Find the minimum number of operations required to convert one word to another.

[0122. Best Time to Buy and Sell Stock II](/Dynamic%20Programming%2F0122.%20Best%20Time%20to%20Buy%20and%20Sell%20Stock%20II): Find the maximum profit that can be obtained by buying and selling a stock multiple times.

[0368. Largest Divisible Subset](/Dynamic%20Programming%2F0368.%20Largest%20Divisible%20Subset): Find the largest subset where each element divides the next

[0714. Best Time to Buy and Sell Stock with Transaction Fee](/Dynamic%20Programming%2F0714.%20Best%20Time%20to%20Buy%20and%20Sell%20Stock%20with%20Transaction%20Fee): Find the maximum profit that can be obtained by buying and selling a stock with a transaction fee.

[0790. Domino and Tromino Tiling](/Dynamic%20Programming%2F0790.%20Domino%20and%20Tromino%20Tiling): Find the number of ways to tile a 2 x N board with dominoes and trominoes.

[0873. Length of Longest Fibonacci Subsequence](/Dynamic%20Programming%2F0873.%20Length%20of%20Longest%20Fibonacci%20Subsequence): Find the longest Fibonacci subsequence length in array

[1143. Longest Common Subsequence](/Dynamic%20Programming%2F1143.%20Longest%20Common%20Subsequence): Find the length of the longest common subsequence between two strings.

[1749. Maximum Absolute Sum of Any Subarray](/Dynamic%20Programming%2F1749.%20Maximum%20Absolute%20Sum%20of%20Any%20Subarray): Find the maximum absolute sum of any subarray

[2140. Solving Questions With Brainpower](/Dynamic%20Programming%2F2140.%20Solving%20Questions%20With%20Brainpower): Maximize points solving questions, skipping some based on brainpower

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[1092. Shortest Common Supersequence ](/Dynamic%20Programming%2F1092.%20Shortest%20Common%20Supersequence%20): Find shortest string containing two given strings as subsequences
