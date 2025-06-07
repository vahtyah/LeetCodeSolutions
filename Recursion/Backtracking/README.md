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

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0017. Letter Combinations of a Phone Number](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Backtracking/0017.%20Letter%20Combinations%20of%20a%20Phone%20Number): Find all possible letter combinations that the number could represent.

[0022. Generate Parentheses](/Recursion%2FBacktracking%2F0022.%20Generate%20Parentheses): Generate all valid combinations of n pairs of parentheses

[0039. Combination Sum](/Recursion%2FBacktracking%2F0039.%20Combination%20Sum): Find all combinations summing to target from given candidates

[0046. Permutations](/Backtracking%2F0046.%20Permutations): Find all unique permutations of a given array

[0077. Combinations](/Recursion%2FBacktracking%2F0077.%20Combinations): Return all combinations of k elements from a set of n

[0079. Word Search](/Recursion%2FBacktracking%2F0079.%20Word%20Search): Find if a word exists in a grid of letters

[0216. Combination Sum III](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Backtracking/0216.%20Combination%20Sum%20III): Find all valid combinations of `k` numbers that sum up to `n`.

[1079. Letter Tile Possibilities](/Backtracking%2F1079.%20Letter%20Tile%20Possibilities): Given a letter tile set, find the number of distinct letter combinations

[1415. The k-th Lexicographical String of All Happy Strings of Length n](/Backtracking%2F1415.%20The%20k-th%20Lexicographical%20String%20of%20All%20Happy%20Strings%20of%20Length%20n): Find the k-th lexicographically smallest happy string of length n

[1718. Construct the Lexicographically Largest Valid Sequence](/Backtracking%2F1718.%20Construct%20the%20Lexicographically%20Largest%20Valid%20Sequence): Construct the largest sequence by concatenating 1 to N numbers in a valid order

[1980. Find Unique Binary String](/Backtracking%2F1980.%20Find%20Unique%20Binary%20String): Find a unique binary string of length n with no repeated substrings of length m

[2375. Construct Smallest Number From DI String](/Backtracking%2F2375.%20Construct%20Smallest%20Number%20From%20DI%20String): Construct smallest number from digit string with "I" and "D" operations

[2698. Find the Punishment Number of an Integer](/Backtracking%2F2698.%20Find%20the%20Punishment%20Number%20of%20an%20Integer): Find the count of distinct prime factors of an integer

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0051. N-Queens](/Backtracking%2F0051.%20N-Queens): Place N queens on an NxN chessboard, ensuring no 2 queens attack each other

[0052. N-Queens II](/Recursion%2FBacktracking%2F0052.%20N-Queens%20II): Count all distinct N-Queens solutions on an N x N board
