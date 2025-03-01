# Array

The **array** data structure is a collection of elements stored in contiguous memory locations. It is one of the most commonly used data structures in programming and provides fast access to elements based on their index. Arrays can store elements of the same type and have a fixed size that is determined when the array is created.

## Key Concepts

1. **Declaration:** Arrays can be declared in various programming languages using different syntax. For example, in C#, an array of integers can be declared as `int[] arr = new int[5];` to create an array of size 5.
2. **Initialization:** Arrays can be initialized with values at the time of declaration or later by assigning values to individual elements. For example, `int[] arr = {1, 2, 3, 4, 5};` initializes an array with values 1, 2, 3, 4, and 5.
3. **Accessing Elements:** Elements in an array can be accessed using their index. The index of the first element is typically 0, and the index of the last element is `length - 1`.
4. **Operations:** Arrays support common operations like inserting, deleting, and updating elements. These operations may require shifting elements to maintain the order.
5. **Memory Allocation:** Arrays allocate contiguous memory locations to store elements, which allows for fast access based on index. The memory allocated for an array is determined by the size of the elements it stores.
6. **Multidimensional Arrays:** Arrays can have multiple dimensions, such as 2D arrays, which are useful for representing matrices or grids. Elements in multidimensional arrays are accessed using multiple indices.
7. **Dynamic Arrays:** Some languages provide dynamic arrays, like `List` in C#, which can grow or shrink in size dynamically. Dynamic arrays handle memory allocation and resizing automatically.

## C# Implementation

```csharp
public class ArrayExamples
{
    public void BasicArrayOperations()
    {
        // Declaration and initialization
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        // Accessing elements
        int firstElement = arr[0];
        int lastElement = arr[arr.Length - 1];

        // Updating elements
        arr[2] = 10;

        // Iterating over elements
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }

    public void MultidimensionalArray()
    {
        // Declaration and initialization of a 2D array
        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        // Accessing elements in a 2D array
        int element = matrix[1, 2]; // Accesses the element at row 1, column 2
    }

    public void DynamicArray()
    {
        // Declaration and initialization of a dynamic array
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };

        // Adding elements to a dynamic array
        list.Add(6);

        // Removing elements from a dynamic array
        list.Remove(3);
    }
}
```

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0013. Roman to Integer](/Data%20Structures%2FArray%2F0013.%20Roman%20to%20Integer): Convert Roman numeral to integer representation

[0121. Best Time to Buy and Sell Stock](/Data%20Structures%2FArray%2F0121.%20Best%20Time%20to%20Buy%20and%20Sell%20Stock): Find the maximum profit that can be obtained by buying and selling a stock.

[0169. Majority Element](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures/Array/0169.%20Majority%20Element): Find the majority element in an array, which appears more than `n / 2` times.

[0228. Summary Ranges](/Data%20Structures%2FArray%2F0228.%20Summary%20Ranges): Merge overlapping intervals and summarize them as ranges

[1752. Check if Array Is Sorted and Rotated](/Data%20Structures%2FArray%2F1752.%20Check%20if%20Array%20Is%20Sorted%20and%20Rotated): Determine if a rotated sorted array is still sorted

[1800. Maximum Ascending Subarray Sum](/Data%20Structures%2FArray%2F1800.%20Maximum%20Ascending%20Subarray%20Sum): Find the maximum sum of a contiguous ascending subarray

[2460. Apply Operations to an Array](/Data%20Structures%2FArray%2F2460.%20Apply%20Operations%20to%20an%20Array): Modify array: double equal adjacent, zero others, shift zeros

[3105. Longest Strictly Increasing or Strictly Decreasing Subarray](/Data%20Structures%2FArray%2F3105.%20Longest%20Strictly%20Increasing%20or%20Strictly%20Decreasing%20Subarray): Find longest contiguous strictly increasing or strictly decreasing subarray

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0048. Rotate Image](/Data%20Structures%2FArray%2F0048.%20Rotate%20Image): Rotate a square matrix 90 degrees clockwise

[0054. Spiral Matrix](/Data%20Structures%2FArray%2F0054.%20Spiral%20Matrix): Traverse a matrix in a spiral pattern

[0056. Merge Intervals](/Data%20Structures%2FArray%2F0056.%20Merge%20Intervals): Merge overlapping intervals in an interval list

[0073. Set Matrix Zeroes](/Data%20Structures%2FArray%2F0073.%20Set%20Matrix%20Zeroes): Set zero if row or column has a zero

[0289. Game of Life](/Data%20Structures%2FArray%2F0289.%20Game%20of%20Life): Determine the next state of a game board with living and dead cells

[1267. Count Servers that Communicate](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures%2FArray%2F1267.%20Count%20Servers%20that%20Communicate): Count the number of servers that can communicate with at least one other server in a grid.

[2364. Count Number of Bad Pairs](/Data%20Structures%2FArray%2F2364.%20Count%20Number%20of%20Bad%20Pairs): Count pairs of elements with bigger elements on right

[2661. First Completely Painted Row or Column](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures/Array/2661.%20First%20Completely%20Painted%20Row%20or%20Column): Determine the first row or column that is completely painted in a 2D grid.

[2948. Make Lexicographically Smallest Array by Swapping Elements](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures%2FArray%2F2948.%20Make%20Lexicographically%20Smallest%20Array%20by%20Swapping%20Elements): Make an array lexicographically smallest by swapping elements at most `k` times.
