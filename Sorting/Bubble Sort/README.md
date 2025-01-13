# Bubble Sort

The **bubble sort** algorithm repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted.

## Key Concepts

1. **Input:** An unsorted list of elements.
2. **Output:** A sorted list of elements.
3. **Logic:**
   - Start at the beginning of the list and compare each pair of adjacent elements.
   - If the elements are in the wrong order, swap them.
   - Repeat this process until no swaps are needed.
4. **Time complexity:** `O(n^2)` where `n` is the number of elements in the list.

## C# Implementation

```csharp
public static void BubbleSort(int[] nums)
{
    int n = nums.Length;
    bool swapped;

    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;

        for (int j = 0; j < n - i - 1; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                int temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = temp;
                swapped = true;
            }
        }

        if (!swapped)
        {
            break;
        }
    }
}
```

[//]: # (## Solutions)

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

[//]: # (### ![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)
