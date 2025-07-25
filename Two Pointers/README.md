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

## Algorithms

<details>
<summary><strong>Floyd's Tortoise and Hare (Cycle Detection)</strong>: Detecting cycles in linked lists or arrays.</summary>

```csharp
public static bool HasCycle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
        {
            return true;
        }
    }

    return false;
}
```
</details>

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0026. Remove Duplicates from Sorted Array](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0026.%20Remove%20Duplicates%20from%20Sorted%20Array): Remove duplicates from a sorted array in-place.

[0027. Remove Element](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0027.%20Remove%20Element): Remove all instances of a value from an array in-place.

[0088. Merge Sorted Array](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0088.%20Merge%20Sorted%20Array): Merge two sorted arrays in-place.

[0125. Valid Palindrome](/Two%20Pointers%2F0125.%20Valid%20Palindrome): Determine if a given string is a palindrome

[0141. Linked List Cycle](/Two%20Pointers%2F0141.%20Linked%20List%20Cycle): Determine if a linked list contains a cycle

[0202. Happy Number](/Two%20Pointers%2F0202.%20Happy%20Number): Determine if a number is happy after repeatedly squaring its digits and summing them until a fixed point is reached

[0283. Move Zeroes](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0283.%20Move%20Zeroes): Move all zeroes to the end of an array while maintaining the relative order of non-zero elements.

[0392. Is Subsequence](/Two%20Pointers%2F0392.%20Is%20Subsequence): Given two strings, determine if the second is a subsequence of the first

[2200. Find All K-Distant Indices in an Array](/Two%20Pointers%2F2200.%20Find%20All%20K-Distant%20Indices%20in%20an%20Array): Find indices within distance `k` of target element indices

[2570. Merge Two 2D Arrays by Summing Values](/Two%20Pointers%2F2570.%20Merge%20Two%202D%20Arrays%20by%20Summing%20Values): Merge arrays; sum values for identical keys

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0011. Container With Most Water](/Two%20Pointers%2F0011.%20Container%20With%20Most%20Water): Maximize the area of water contained between vertical lines

[0015. 3Sum](/Two%20Pointers%2F0015.%203Sum): Find three numbers in an array that sum to zero

[0019. Remove Nth Node From End of List](/Two%20Pointers%2F0019.%20Remove%20Nth%20Node%20From%20End%20of%20List): Remove the nth node from the end of a linked list

[0080. Remove Duplicates from Sorted Array II](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0080.%20Remove%20Duplicates%20from%20Sorted%20Array%20II): Remove duplicates from a sorted array in-place, allowing at most two duplicates.

[0082. Remove Duplicates from Sorted List II](/Two%20Pointers%2F0082.%20Remove%20Duplicates%20from%20Sorted%20List%20II): Remove duplicate adjacent elements from sorted linked list

[0086. Partition List](/Two%20Pointers%2F0086.%20Partition%20List): Partition linked list based on a given value

[0167. Two Sum II - Input Array Is Sorted](/Two%20Pointers%2F0167.%20Two%20Sum%20II%20-%20Input%20Array%20Is%20Sorted): Find two numbers in sorted array that add up to a target

[0443. String Compression](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/0443.%20String%20Compression): Compress a string by replacing consecutive duplicate characters with the character followed by the number of occurrences.

[0838. Push Dominoes](/Two%20Pointers%2F0838.%20Push%20Dominoes): Simulate domino falls; determine final state of dominoes

[1498. Number of Subsequences That Satisfy the Given Sum Condition](/Two%20Pointers%2F1498.%20Number%20of%20Subsequences%20That%20Satisfy%20the%20Given%20Sum%20Condition): Count subsequences where min + max <= target

[2161. Partition Array According to Given Pivot](/Two%20Pointers%2F2161.%20Partition%20Array%20According%20to%20Given%20Pivot): Reorder array so elements less/equal/greater pivot are grouped

[2410. Maximum Matching of Players With Trainers](/Two%20Pointers%2F2410.%20Maximum%20Matching%20of%20Players%20With%20Trainers): Maximize player-trainer matches given player and trainer skill levels

[2462. Total Cost to Hire K Workers](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Two%20Pointers/2462.%20Total%20Cost%20to%20Hire%20K%20Workers): Calculate the minimum total cost to hire `k` workers based on their quality and wage requirements.

[3403. Find the Lexicographically Largest String From the Box I](/Two%20Pointers%2F3403.%20Find%20the%20Lexicographically%20Largest%20String%20From%20the%20Box%20I): Find the lexicographically largest string from the given strings

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0042. Trapping Rain Water](/Two%20Pointers%2F0042.%20Trapping%20Rain%20Water): Calculate the maximum amount of rainwater trapped between buildings
