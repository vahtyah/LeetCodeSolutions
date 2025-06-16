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

[2016. Maximum Difference Between Increasing Elements](/Greedy%2F2016.%20Maximum%20Difference%20Between%20Increasing%20Elements): Find maximum nums[j] - nums[i] where i < j and nums[i] < nums[j]

[2566. Maximum Difference by Remapping a Digit](/Greedy%2F2566.%20Maximum%20Difference%20by%20Remapping%20a%20Digit): Find maximum difference by remapping a digit

[2873. Maximum Value of an Ordered Triplet I](/Greedy%2F2873.%20Maximum%20Value%20of%20an%20Ordered%20Triplet%20I): Find max (nums[i] - nums[j]) * nums[k] where i<j<k

[2900. Longest Unequal Adjacent Groups Subsequence I](/Greedy%2F2900.%20Longest%20Unequal%20Adjacent%20Groups%20Subsequence%20I): Find the longest subsequence with adjacent elements from different groups

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0045. Jump Game II](/Greedy%2F0045.%20Jump%20Game%20II): Find the minimum number of jumps to reach the last index in an array.

[0055. Jump Game](/Greedy%2F0055.%20Jump%20Game): Determine if you can reach the last index in an array of non-negative integers.

[0134. Gas Station](/Greedy%2F0134.%20Gas%20Station): Find the starting gas station to complete a circular route.

[0334. Increasing Triplet Subsequence](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/334.%20Increasing%20Triplet%20Subsequence): Find if there exists an increasing triplet subsequence in an array.

[0435. Non-overlapping Intervals](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/0435.%20Non-overlapping%20Intervals): Find the minimum number of intervals to remove to make the rest non-overlapping.

[0452. Minimum Number of Arrows to Burst Balloons](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/0452.%20Minimum%20Number%20of%20Arrows%20to%20Burst%20Balloons): Find the minimum number of arrows to burst balloons.

[0763. Partition Labels](/Greedy%2F0763.%20Partition%20Labels): Divide a string into maximal partitions with unique characters

[0781. Rabbits in Forest](/Greedy%2F0781.%20Rabbits%20in%20Forest): Find the minimum rabbits needed based on reported counts

[1007. Minimum Domino Rotations For Equal Row](/Greedy%2F1007.%20Minimum%20Domino%20Rotations%20For%20Equal%20Row): Minimize domino rotations to make a row equal

[1400. Construct K Palindrome Strings](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/1400.%20Construct%20K%20Palindrome%20Strings): Determine if it is possible to construct `k` palindrome strings from a given string.

[1432. Max Difference You Can Get From Changing an Integer](/Greedy%2F1432.%20Max%20Difference%20You%20Can%20Get%20From%20Changing%20an%20Integer): Maximize difference by replacing digits to create min/max numbers

[2116. Check if a Parentheses String Can Be Valid](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Greedy/2116.%20Check%20if%20a%20Parentheses%20String%20Can%20Be%20Valid): Check if a parentheses string can be made valid by adding parentheses.

[2131. Longest Palindrome by Concatenating Two Letter Words](/Greedy%2F2131.%20Longest%20Palindrome%20by%20Concatenating%20Two%20Letter%20Words): Find the longest palindrome from concatenated two-letter words

[2342. Max Sum of a Pair With Equal Sum of Digits](/Greedy%2F2342.%20Max%20Sum%20of%20a%20Pair%20With%20Equal%20Sum%20of%20Digits): Find the pair with equal digit sums and maximum sum

[2375. Construct Smallest Number From DI String](/Greedy%2F2375.%20Construct%20Smallest%20Number%20From%20DI%20String): Construct smallest number from string of 'I' and 'D'

[2434. Using a Robot to Print the Lexicographically Smallest String](/Greedy%2F2434.%20Using%20a%20Robot%20to%20Print%20the%20Lexicographically%20Smallest%20String): Lexicographically smallest string after robot operations on given string

[2874. Maximum Value of an Ordered Triplet II](/Greedy%2F2874.%20Maximum%20Value%20of%20an%20Ordered%20Triplet%20II): Find the maximum (nums[i] - nums[j]) * nums[k] for i<j<k

[3191. Minimum Operations to Make Binary Array Elements Equal to One I](/Greedy%2F3191.%20Minimum%20Operations%20to%20Make%20Binary%20Array%20Elements%20Equal%20to%20One%20I): Minimize flips to make all binary array elements one

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0135. Candy](/Greedy%2F0135.%20Candy): Distribute candies to children such that each child has at least one and adjacent children get different candies

[2071. Maximum Number of Tasks You Can Assign](/Greedy%2F2071.%20Maximum%20Number%20of%20Tasks%20You%20Can%20Assign): Maximize assigned tasks given worker strength and task difficulty

[2551. Put Marbles in Bags](/Greedy%2F2551.%20Put%20Marbles%20in%20Bags): Minimize/maximize marble bag scores by optimally splitting them

[2818. Apply Operations to Maximize Score](/Greedy%2F2818.%20Apply%20Operations%20to%20Maximize%20Score): Maximize score: apply operations, prime factor boosts allowed

[3068. Find the Maximum Sum of Node Values](/Greedy%2F3068.%20Find%20the%20Maximum%20Sum%20of%20Node%20Values): Maximize sum of node values, selecting independent sets
