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
## Use Cases

- **Two Sum:** Find two numbers in an array that sum up to a specific target.
- **Reverse Array:** Reverse the elements of an array in-place using two pointers.
- **Remove Duplicates:** Remove duplicates from a sorted array in-place using two pointers.
- **Partitioning Arrays:** Partition an array into two parts based on a specific condition.
- **Sliding Window Problems:** Use two pointers to maintain a sliding window over an array.
- **Linked List Cycle Detection:** Detect cycles in a linked list using two pointers.
- **Container With Most Water:** Find the container with the most water given a list of heights.
- **3Sum:** Find all unique triplets in the array that sum up to zero.
- **Trapping Rain Water:** Calculate the amount of water that can be trapped between bars.
- **Remove Element:** Remove all instances of a specific value from an array in-place.
- **Sort Colors:** Sort an array containing only 0, 1, and 2 in-place.
- **Move Zeroes:** Move all zeros to the end of an array while maintaining the order of non-zero elements.
- **Maximum Score After Splitting a String:** Split a string into two substrings to maximize the score.
- **Minimum Size Subarray Sum:** Find the minimum size subarray that sums up to a target value.
- **Longest Substring Without Repeating Characters:** Find the length of the longest substring without repeating characters.
- **Remove Nth Node From End of List:** Remove the `n-th` node from the end of a linked list.
- **Merge Sorted Array:** Merge two sorted arrays into a single sorted array in-place.
- **Valid Palindrome:** Check if a string is a valid palindrome using two pointers.
- **Valid Palindrome II:** Check if a string can become a palindrome by removing at most one character.
- **Longest Palindromic Substring:** Find the longest palindromic substring in a string.
- **Valid Parentheses:** Check if a string containing parentheses is valid.
- **Longest Mountain in Array:** Find the length of the longest mountain in an array.
- **Sort Array By Parity:** Sort an array such that even numbers appear first followed by odd numbers.
- **Sort Array By Parity II:** Sort an array such that even numbers appear at even indices and odd numbers at odd indices.
- **Squares of a Sorted Array:** Return an array of the squares of each number sorted in non-decreasing order.
- **Remove Duplicates from Sorted Array II:** Remove duplicates in-place such that each element appears at most twice.
- **Remove Duplicates from Sorted List:** Remove duplicates from a sorted linked list.
- **Remove Duplicates from Sorted List II:** Remove duplicates from a sorted linked list, keeping only distinct elements.
- **Remove Nth Node From End of List:** Remove the `n-th` node from the end of a linked list.
- **Remove Zero Sum Consecutive Nodes from Linked List:** Remove all consecutive nodes that sum up to zero from a linked list.
- **Remove Linked List Elements:** Remove all elements from a linked list that have a specific value.
- **Remove Duplicates from Sorted Array:** Remove duplicates from a sorted array in-place.
- **Remove Element:** Remove all instances of a specific value from an array in-place.
