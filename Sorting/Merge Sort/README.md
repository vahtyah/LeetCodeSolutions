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

private static void Merge(int[] nums, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
        {
            nums[k++] = left[i++];
        }
        else
        {
            nums[k++] = right[j++];
        }
    }

    while (i < left.Length)
    {
        nums[k++] = left[i++];
    }

    while (j < right.Length)
    {
        nums[k++] = right[j++];
    }
}
```

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0148. Sort List](/Sorting%2FMerge%20Sort%2F0148.%20Sort%20List): Sort a linked list in ascending order
