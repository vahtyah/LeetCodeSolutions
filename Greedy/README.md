# Greedy Algorithms

**Greedy algorithms** are used to solve optimization problems by making the best choice at each step. The algorithm makes a series of choices that are locally optimal, leading to a globally optimal solution. Greedy algorithms are often used to solve problems that involve finding the minimum or maximum value of a particular function.

## C# Example

```csharp
public static int GreedyAlgorithm(int[] nums)
{
    int n = nums.Length;
    int count = 0;

    for (int i = 0; i < n; i++)
    {
        if (nums[i] == 0)
        {
            count++;
        }
    }

    return count;
}
```
## Solutions

![Easy](https://img.shields.io/badge/Easy-46c6c2)

[1422. Maximum Score After Splitting a String](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/1422.%20Maximum%20Score%20After%20Splitting%20a%20String): Find the maximum score after splitting a string into two non-empty substrings.

![Medium](https://img.shields.io/badge/Medium-fac31d)

[0334. Increasing Triplet Subsequence](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/334.%20Increasing%20Triplet%20Subsequence): Find if there exists an increasing triplet subsequence in an array.
