# Binary Search

The **Binary Search** algorithm is an efficient technique used to search for a target element in a sorted array. It works by repeatedly dividing the search interval in half until the target element is found or the interval is empty.

## Key Concepts

1. **Input:** A sorted array of numbers (e.g., `int[] nums`) and a target element (e.g., `int target`).
2. **Output:** The index of the target element in the array if it exists; otherwise, return `-1`.
3. **Logic:**
   - Initialize two pointers, `left` and `right`, to the start and end of the array, respectively.
   - While `left <= right`, calculate the `mid` index as `(left + right) / 2`.
   - If the target element is equal to the element at the `mid` index, return `mid`.
   - If the target element is less than the element at the `mid` index, set `right = mid - 1` to search the left half.
   - If the target element is greater than the element at the `mid` index, set `left = mid + 1` to search the right half.
   - Repeat the process until the target element is found or the interval is empty.
   - If the target element is not found, return `-1`.
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
        //int mid = left + (right - left) >> 1; // Alternative faster way to calculate mid

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

[//]: # (## Solutions)

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

[//]: # (### ![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)
