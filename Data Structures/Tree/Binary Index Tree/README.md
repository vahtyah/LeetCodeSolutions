# Data Structures/Tree/Binary Index Tree
**Binary Index Tree** is a data structure that provides efficient methods for querying and updating prefix sums in an array. It is particularly useful for problems involving cumulative frequency tables or range queries.

# C# Implementation
```csharp
public class BinaryIndexTree {
    private int[] tree;
    private int size;

    public BinaryIndexTree(int n) {
        size = n;
        tree = new int[n + 1];
    }

    public void Update(int index, int value) {
        while (index <= size) {
            tree[index] += value;
            index += index & -index; // Move to the next index
        }
    }

    public int Query(int index) {
        int sum = 0;
        while (index > 0) {
            sum += tree[index];
            index -= index & -index; // Move to the parent index
        }
        return sum;
    }
}
```

## Solutions

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[2179. Count Good Triplets in an Array](/Data%20Structures%2FTree%2FBinary%20Index%20Tree%2F2179.%20Count%20Good%20Triplets%20in%20an%20Array): Count triplets satisfying absolute difference constraints
