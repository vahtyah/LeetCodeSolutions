# Selection Sort

The **selection sort** algorithm sorts an array by repeatedly finding the minimum element from the unsorted part of the array and swapping it with the first element of the unsorted part.

## Key Concepts

1. **Input:** An unsorted array of numbers.
2. **Output:** A sorted array in ascending order.
3. **Logic:**
   - Divide the array into two parts: the sorted part and the unsorted part.
   - Find the minimum element from the unsorted part.
   - Swap the minimum element with the first element of the unsorted part.
   - Move the boundary between the sorted and unsorted parts.
   - Repeat the process until the entire array is sorted.
4. **Time complexity:** `O(n^2)`

## C# Implementation

```csharp
public static void SelectionSort(int[] nums)
{
    int n = nums.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < n; j++)
        {
            if (nums[j] < nums[minIndex])
            {
                minIndex = j;
            }
        }

        if (minIndex != i)
        {
            int temp = nums[i];
            nums[i] = nums[minIndex];
            nums[minIndex] = temp;
        }
    }
}
```

[//]: # (## Solutions)

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

[//]: # (### ![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)
