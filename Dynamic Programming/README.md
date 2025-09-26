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

[0070. Climbing Stairs](/Dynamic%20Programming%2F0070.%20Climbing%20Stairs): Find the number of ways to climb n stairs

[0118. Pascal's Triangle](/Dynamic%20Programming%2F0118.%20Pascal%27s%20Triangle): Generate Pascal's Triangle up to `numRows`

[0119. Pascal's Triangle II](/Dynamic%20Programming%2F0119.%20Pascal%27s%20Triangle%20II): Return the rowIndex-th row of Pascal's Triangle

[0509. Fibonacci Number](/Dynamic%20Programming%2F0509.%20Fibonacci%20Number): Find the n-th number in the Fibonacci sequence

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0053. Maximum Subarray](/Dynamic%20Programming%2F0053.%20Maximum%20Subarray): Find the contiguous subarray with the largest sum

[0062. Unique Paths](/Dynamic%20Programming%2F0062.%20Unique%20Paths): Find the number of unique paths from the top-left corner to the bottom-right corner of a grid.

[0063. Unique Paths II](/Dynamic%20Programming%2F0063.%20Unique%20Paths%20II): Count unique paths to reach bottom-right with obstacles

[0064. Minimum Path Sum](/Dynamic%20Programming%2F0064.%20Minimum%20Path%20Sum): Find minimum sum path from top-left to bottom-right

[0072. Edit Distance](/Dynamic%20Programming%2F0072.%20Edit%20Distance): Find the minimum number of operations required to convert one word to another.

[0097. Interleaving String](/Dynamic%20Programming%2F0097.%20Interleaving%20String): Check if string s3 is interleaving of s1 and s2

[0120. Triangle](/Dynamic%20Programming%2F0120.%20Triangle): Find minimum path sum from top to bottom

[0122. Best Time to Buy and Sell Stock II](/Dynamic%20Programming%2F0122.%20Best%20Time%20to%20Buy%20and%20Sell%20Stock%20II): Find the maximum profit that can be obtained by buying and selling a stock multiple times.

[0139. Word Break](/Dynamic%20Programming%2F0139.%20Word%20Break): Determine if a string can be segmented into dictionary words

[0198. House Robber](/Dynamic%20Programming%2F0198.%20House%20Robber): Maximize loot robbing non-adjacent houses

[0322. Coin Change](/Dynamic%20Programming%2F0322.%20Coin%20Change): Find fewest coins to reach target sum

[0368. Largest Divisible Subset](/Dynamic%20Programming%2F0368.%20Largest%20Divisible%20Subset): Find the largest subset where each element divides the next

[0416. Partition Equal Subset Sum](/Dynamic%20Programming%2F0416.%20Partition%20Equal%20Subset%20Sum): Determine if array can be split into two equal sums

[0714. Best Time to Buy and Sell Stock with Transaction Fee](/Dynamic%20Programming%2F0714.%20Best%20Time%20to%20Buy%20and%20Sell%20Stock%20with%20Transaction%20Fee): Find the maximum profit that can be obtained by buying and selling a stock with a transaction fee.

[0790. Domino and Tromino Tiling](/Dynamic%20Programming%2F0790.%20Domino%20and%20Tromino%20Tiling): Find the number of ways to tile a 2 x N board with dominoes and trominoes.

[0808. Soup Servings](/Dynamic%20Programming%2F0808.%20Soup%20Servings): Calculate probability of A emptying first in soup servings

[0837. New 21 Game](/Dynamic%20Programming%2F0837.%20New%2021%20Game): Calculate probability of score <= K before exceeding N

[0873. Length of Longest Fibonacci Subsequence](/Dynamic%20Programming%2F0873.%20Length%20of%20Longest%20Fibonacci%20Subsequence): Find the longest Fibonacci subsequence length in array

[0918. Maximum Sum Circular Subarray](/Dynamic%20Programming%2F0918.%20Maximum%20Sum%20Circular%20Subarray): Find max subarray sum, considering circular wrap-around

[1039. Minimum Score Triangulation of Polygon](/Dynamic%20Programming%2F1039.%20Minimum%20Score%20Triangulation%20of%20Polygon): Minimize triangulation score by summing triangle products

[1143. Longest Common Subsequence](/Dynamic%20Programming%2F1143.%20Longest%20Common%20Subsequence): Find the length of the longest common subsequence between two strings.

[1277. Count Square Submatrices with All Ones](/Dynamic%20Programming%2F1277.%20Count%20Square%20Submatrices%20with%20All%20Ones): Count all square submatrices filled entirely with ones

[1504. Count Submatrices With All Ones](/Dynamic%20Programming%2F1504.%20Count%20Submatrices%20With%20All%20Ones): Count submatrices in a binary matrix that contain only ones

[1749. Maximum Absolute Sum of Any Subarray](/Dynamic%20Programming%2F1749.%20Maximum%20Absolute%20Sum%20of%20Any%20Subarray): Find the maximum absolute sum of any subarray

[2140. Solving Questions With Brainpower](/Dynamic%20Programming%2F2140.%20Solving%20Questions%20With%20Brainpower): Maximize points solving questions, skipping some based on brainpower

[2787. Ways to Express an Integer as Sum of Powers](/Dynamic%20Programming%2F2787.%20Ways%20to%20Express%20an%20Integer%20as%20Sum%20of%20Powers): Find the number of ways to sum powers to n

[2901. Longest Unequal Adjacent Groups Subsequence II](/Dynamic%20Programming%2F2901.%20Longest%20Unequal%20Adjacent%20Groups%20Subsequence%20II): Find longest subsequence where adjacent groups differ

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[1092. Shortest Common Supersequence ](/Dynamic%20Programming%2F1092.%20Shortest%20Common%20Supersequence%20): Find shortest string containing two given strings as subsequences

[1751. Maximum Number of Events That Can Be Attended II](/Dynamic%20Programming%2F1751.%20Maximum%20Number%20of%20Events%20That%20Can%20Be%20Attended%20II): Maximize attended events within k limits, earning total value

[1857. Largest Color Value in a Directed Graph](/Dynamic%20Programming%2F1857.%20Largest%20Color%20Value%20in%20a%20Directed%20Graph): Find max color value in directed graph, avoiding cycles

[1900. The Earliest and Latest Rounds Where Players Compete](/Dynamic%20Programming%2F1900.%20The%20Earliest%20and%20Latest%20Rounds%20Where%20Players%20Compete): Find min/max rounds until one player wins competition

[1931. Painting a Grid With Three Different Colors](/Dynamic%20Programming%2F1931.%20Painting%20a%20Grid%20With%20Three%20Different%20Colors): Count valid grid colorings with three colors

[2338. Count the Number of Ideal Arrays](/Dynamic%20Programming%2F2338.%20Count%20the%20Number%20of%20Ideal%20Arrays): Count arrays where each element divides the next

[2999. Count the Number of Powerful Integers](/Dynamic%20Programming%2F2999.%20Count%20the%20Number%20of%20Powerful%20Integers): Count integers within range ending with `suffix` pattern

[3343. Count Number of Balanced Permutations](/Dynamic%20Programming%2F3343.%20Count%20Number%20of%20Balanced%20Permutations): Count permutations with balanced adjacent sum parity

[3363. Find the Maximum Number of Fruits Collected](/Dynamic%20Programming%2F3363.%20Find%20the%20Maximum%20Number%20of%20Fruits%20Collected): Maximize collected fruits within a limited sliding window
