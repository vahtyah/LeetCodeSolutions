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
## Solutions

### ![Difficulty: Medium](https://img.shields.io/badge/Medium-fac31d)

[0790. Domino and Tromino Tiling](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Dynamic%20Programming/0790.%20Domino%20and%20Tromino%20Tiling): Find the number of ways to tile a 2 x n board with dominoes and trominoes.