# Binary Search Algorithm

The **Binary Search** algorithm is an efficient technique used to search for a target element in a sorted array. It works by repeatedly dividing the search interval in half until the target element is found or the interval is empty.

## Key Concepts

1. **Input:** A sorted array of numbers (e.g., `int[] nums`) and a target element (e.g., `int target`).
2. **Output:** Output: The index of the target element in the array if it exists; otherwise, return `-1`.
3. **Logic:**
   - Initialize two pointers, `left` and `right`, to the start and end of the array, respectively.
   - While `left <= right`, calculate the `mid` index as `(left + right) / 2`.
   - If the target element is equal to the element at the `mid` index, return `mid`.
   - If the target element is less than the element at the `mid` index, set `right = mid - 1` to search the left half.
   - If the target element is greater than the element at the `mid` index, set `left = mid + 1` to search the right half.
4. **Time complexity:** `O(log n)`

## C# Implementation

```csharp
public static int BinarySearch(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1;
}
```
## Solutions

### ![Difficulty: Medium](https://img.shields.io/badge/Medium-fac31d)
- [0162. Find Peak Element](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Binary%20Search/0162.%20Find%20Peak%20Element): Find a peak element in an array.
- [2300. Successful Pairs of Spells and Potions](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Binary%20Search/2300.%20Successful%20Pairs%20of%20Spells%20and%20Potions): Find the number of successful pairs of spells and potions whose product is at least a given value.


