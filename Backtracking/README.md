# Backtracking Algorithms

**Backtracking** is a technique used to solve problems by recursively trying to build a solution incrementally. The algorithm explores all possible paths to find the correct solution. If the current path does not lead to the correct solution, the algorithm backtracks and tries a different path.

## Key Concepts

1. **Input:** A problem that can be broken down into smaller subproblems.
2. **Output:** A valid solution to the problem.
3. **Logic:**
   - Start with an empty solution and recursively build the solution by trying all possible choices.
   - If a choice leads to an invalid solution, backtrack and try a different choice.
   - Continue exploring all possible paths until a valid solution is found.
   - Backtrack to the previous state and try a different choice if the current path does not lead to a solution.
   - Return the solution once it is found.

## C# Example

```csharp
public static void BacktrackingAlgorithm(int[] nums)
{
    List<int> path = new List<int>();
    List<List<int>> result = new List<List<int>>();
    Backtrack(nums, path, result);
}

public static void Backtrack(int[] nums, List<int> path, List<List<int>> result)
{
    if (path.Count == nums.Length)
    {
        result.Add(new List<int>(path));
        return;
    }

    for (int i = 0; i < nums.Length; i++)
    {
        if (path.Contains(nums[i]))
        {
            continue;
        }

        path.Add(nums[i]);
        Backtrack(nums, path, result);
        path.RemoveAt(path.Count - 1);
    }
}
```
## Solutions

### ![Difficulty: Medium](https://img.shields.io/badge/Medium-fac31d)

[0017. Letter Combinations of a Phone Number](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Backtracking/0017.%20Letter%20Combinations%20of%20a%20Phone%20Number): Find all possible letter combinations that the number could represent.

[0216. Combination Sum III](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Backtracking/0216.%20Combination%20Sum%20III): Find all valid combinations of `k` numbers that sum up to `n`.

