# Two Pointers Algorithms

Two pointers algorithms are used to solve problems that involve iterating through an array or list using two pointers. The two pointers can move in the same direction, in opposite directions, or even start from the middle of the array. These algorithms are often used to solve problems that involve searching, sorting, or manipulating arrays.

## C# Example

```csharp
public static void TwoPointersAlgorithm(int[] nums)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left < right)
    {
        // Perform some operations using the two pointers
        left++;
        right--;
    }
}
```
## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0283. Move Zeroes](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0283.%20Move%20Zeroes): Move all zeroes to the end of an array while maintaining the relative order of non-zero elements.

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0443. String Compression](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0443.%20String%20Compression): Compress a string by replacing consecutive duplicate characters with the character followed by the number of occurrences.

[2462. Total Cost to Hire K Workers](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/2462.%20Total%20Cost%20to%20Hire%20K%20Workers): Calculate the minimum total cost to hire `k` workers based on their quality and wage requirements.

