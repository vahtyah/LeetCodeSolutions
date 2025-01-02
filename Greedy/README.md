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
## Use Cases

- **Jump Game:** Determine if you can reach the last index in an array of non-negative integers.
- **Jump Game II:** Find the minimum number of jumps to reach the last index in an array.
- **Gas Station:** Find the starting gas station to complete a circular route.
- **Candy:** Distribute candy to children based on their ratings.
- **Best Time to Buy and Sell Stock:** Find the maximum profit by buying and selling stocks.
- **Best Time to Buy and Sell Stock II:** Find the maximum profit by buying and selling stocks multiple times.
- **Best Time to Buy and Sell Stock III:** Find the maximum profit by buying and selling stocks at most twice.
- **Best Time to Buy and Sell Stock IV:** Find the maximum profit by buying and selling stocks at most `k` times.
- **Best Time to Buy and Sell Stock with Cooldown:** Find the maximum profit by buying and selling stocks with a cooldown period.
- **Assign Cookies:** Assign cookies to children based on their greed factor.
- **Non-overlapping Intervals:** Find the minimum number of intervals to remove to make the rest non-overlapping.
- **Minimum Number of Arrows to Burst Balloons:** Find the minimum number of arrows to burst all balloons.
- **Partition Labels:** Partition a string into as many parts as possible so that each letter appears in at most one part.
- **Minimum Number of K Consecutive Bit Flips:** Find the minimum number of flips to convert a binary array to all ones.
- **Maximum Score After Splitting a String:** Split a string into two substrings to maximize the score.
- **Minimum Deletions to Make Character Frequencies Unique:** Find the minimum number of deletions to make the frequency of each character unique.
- **Minimum Operations to Make Array Equal:** Find the minimum number of operations to make all elements of an array equal.
- **Minimum Cost to Move Chips to The Same Position:** Find the minimum cost to move chips to the same position.
- **Minimum Absolute Sum Difference:** Find the minimum absolute sum difference of two arrays.
- **Maximum Ice Cream Bars:** Find the maximum number of ice cream bars you can buy with a budget.
- **Maximum Units on a Truck:** Find the maximum number of units that can be put on a truck.
- **Maximum Performance of a Team:** Find the maximum performance of a team with a limited number of engineers.
- **Maximum Number of Eaten Apples:** Find the maximum number of apples you can eat in a day.
- **Maximum Number of Achievable Transfer Requests:** Find the maximum number of transfer requests that can be achieved.
- **Maximum Number of Balloons:** Find the maximum number of instances that can be formed from the word "balloon".
- **Maximum Number of Words You Can Type:** Find the maximum number of words you can type using a keyboard.
- **Maximum Number of Consecutive Values You Can Make:** Find the maximum number of consecutive values you can make.
- **Maximum Number of Events That Can Be Attended:** Find the maximum number of events that can be attended.
- **Maximum Number of Coins You Can Get:** Find the maximum number of coins you can get in a grid.
- **Maximum Number of Darts Inside of a Circular Dartboard:** Find the maximum number of darts inside a circular dartboard.
- **Maximum Number of Vowels in a Substring of Given Length:** Find the maximum number of vowels in a substring of a given length.
- **Maximum Number of Non-Overlapping Subarrays With Sum Equals Target:** Find the maximum number of non-overlapping subarrays with a sum equal to the target.
- **Maximum Number of Visible Points:** Find the maximum number of visible points in a 2D plane.
- **Maximum Number of Words You Can Type:** Find the maximum number of words you can type using a keyboard.
- **Maximum Number of Achievable Transfer Requests:** Find the maximum number of transfer requests that can be achieved.