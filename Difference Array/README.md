# Difference Array

The **Difference Array** is a data structure that allows efficient range updates and queries on an array. It is particularly useful for problems involving cumulative frequency tables or range queries.

## C# Implementation

```csharp
public class DifferenceArray {
    private int[] diff;
    private int size;

    public DifferenceArray(int n) {
        size = n;
        diff = new int[n + 1];
    }

    public void Update(int left, int right, int value) {
        diff[left] += value;
        if (right + 1 < size) {
            diff[right + 1] -= value;
        }
    }

    public int[] GetResult() {
        int[] result = new int[size];
        result[0] = diff[0];
        for (int i = 1; i < size; i++) {
            result[i] = result[i - 1] + diff[i];
        }
        return result;
    }
}

var diffArray = new DifferenceArray(5);
diffArray.Update(1, 3, 2); // diff = [0, 2, 2, 2, 0]
diffArray.Update(2, 4, 3); // diff = [0, 2, 5, 5, 0]
var result = diffArray.GetResult(); // result = [0, 2, 5, 5, 0]
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[3355. Zero Array Transformation I](/Difference%20Array%2F3355.%20Zero%20Array%20Transformation%20I): Make array zero using adjacent element flips
