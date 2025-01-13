# Merge Sort

The **merge sort** algorithm is a divide-and-conquer algorithm that divides the input array into two halves, recursively sorts the two halves, and then merges the sorted halves. It is a stable sorting algorithm with a time complexity of `O(n log n)`.

## Key Concepts

1. **Input:** An unsorted array of numbers.
2. **Output:** A sorted array in ascending order.
3. **Logic:**
   - Divide the input array into two halves.
   - Recursively sort the two halves.
   - Merge the sorted halves to produce a single sorted array.
   - Return the sorted array.
4. **Time Complexity:** `O(n log n)`

## C# Implementation

```csharp
public static void MergeSort(int[] nums)
{
    if (nums.Length <= 1)
    {
        return;
    }

    int mid = nums.Length / 2;
    int[] left = new int[mid];
    int[] right = new int[nums.Length - mid];

    for (int i = 0; i < mid; i++)
    {
        left[i] = nums[i];
    }

    for (int i = mid; i < nums.Length; i++)
    {
        right[i - mid] = nums[i];
    }

    MergeSort(left);
    MergeSort(right);
    Merge(nums, left, right);
}
```

[//]: # (## Solutions)

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

[//]: # (### ![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)
