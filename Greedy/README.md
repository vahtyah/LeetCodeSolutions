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

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[1422. Maximum Score After Splitting a String](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/1422.%20Maximum%20Score%20After%20Splitting%20a%20String): Find the maximum score after splitting a string into two non-empty substrings.

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0045. Jump Game II](/Greedy%2F0045.%20Jump%20Game%20II): Find the minimum number of jumps to reach the last index in an array.

[0055. Jump Game](/Greedy%2F0055.%20Jump%20Game): Determine if you can reach the last index in an array of non-negative integers.

[0134. Gas Station](/Greedy%2F0134.%20Gas%20Station): Find the starting gas station to complete a circular route.

[0334. Increasing Triplet Subsequence](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/334.%20Increasing%20Triplet%20Subsequence): Find if there exists an increasing triplet subsequence in an array.

[0435. Non-overlapping Intervals](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/0435.%20Non-overlapping%20Intervals): Find the minimum number of intervals to remove to make the rest non-overlapping.

[0452. Minimum Number of Arrows to Burst Balloons](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/0452.%20Minimum%20Number%20of%20Arrows%20to%20Burst%20Balloons): Find the minimum number of arrows to burst balloons.

[1400. Construct K Palindrome Strings](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/1400.%20Construct%20K%20Palindrome%20Strings): Determine if it is possible to construct `k` palindrome strings from a given string.

[2116. Check if a Parentheses String Can Be Valid](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/2116.%20Check%20if%20a%20Parentheses%20String%20Can%20Be%20Valid): Check if a parentheses string can be made valid by adding parentheses.
