# Sorting/DNF Sort

**DNF Sort** (Dutch National Flag Problem) is a sorting algorithm that sorts an array of three distinct values. It is often used to sort arrays containing 0s, 1s, and 2s.

## C# Implementation

```csharp
public class DNFSort
{
    public void Sort(int[] arr)
    {
        int low = 0, mid = 0, high = arr.Length - 1;

        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                Swap(arr, low, mid);
                low++;
                mid++;
            }
            else if (arr[mid] == 1)
            {
                mid++;
            }
            else
            {
                Swap(arr, mid, high);
                high--;
            }
        }
    }

    private void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0075. Sort Colors](/Sorting%2FDNF%20Sort%2F0075.%20Sort%20Colors): Sort an array of 0s, 1s, and 2s
