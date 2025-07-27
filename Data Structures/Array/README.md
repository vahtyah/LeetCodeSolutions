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

[1534. Count Good Triplets](/Data%20Structures%2FArray%2F1534.%20Count%20Good%20Triplets): Count triplets in array meeting absolute difference constraints

[1752. Check if Array Is Sorted and Rotated](/Data%20Structures%2FArray%2F1752.%20Check%20if%20Array%20Is%20Sorted%20and%20Rotated): Determine if a rotated sorted array is still sorted

[1800. Maximum Ascending Subarray Sum](/Data%20Structures%2FArray%2F1800.%20Maximum%20Ascending%20Subarray%20Sum): Find the maximum sum of a contiguous ascending subarray

[1920. Build Array from Permutation](/Data%20Structures%2FArray%2F1920.%20Build%20Array%20from%20Permutation): Reorder array elements based on given index mapping

[2094. Finding 3-Digit Even Numbers](/Data%20Structures%2FArray%2F2094.%20Finding%203-Digit%20Even%20Numbers): Find all distinct 3-digit even numbers from given digits

[2099. Find Subsequence of Length K With the Largest Sum](/Data%20Structures%2FArray%2F2099.%20Find%20Subsequence%20of%20Length%20K%20With%20the%20Largest%20Sum): Find k elements from array with maximum sum

[2176. Count Equal and Divisible Pairs in an Array](/Data%20Structures%2FArray%2F2176.%20Count%20Equal%20and%20Divisible%20Pairs%20in%20an%20Array): Count pairs where nums[i] == nums[j] and (i*j) % k == 0

[2210. Count Hills and Valleys in an Array](/Data%20Structures%2FArray%2F2210.%20Count%20Hills%20and%20Valleys%20in%20an%20Array): Count local peaks/troughs in an integer array

[2460. Apply Operations to an Array](/Data%20Structures%2FArray%2F2460.%20Apply%20Operations%20to%20an%20Array): Modify array: double equal adjacent, zero others, shift zeros

[3105. Longest Strictly Increasing or Strictly Decreasing Subarray](/Data%20Structures%2FArray%2F3105.%20Longest%20Strictly%20Increasing%20or%20Strictly%20Decreasing%20Subarray): Find longest contiguous strictly increasing or strictly decreasing subarray

[3392. Count Subarrays of Length Three With a Condition](/Data%20Structures%2FArray%2F3392.%20Count%20Subarrays%20of%20Length%20Three%20With%20a%20Condition): Count length-three subarrays meeting absolute difference criteria

[3423. Maximum Difference Between Adjacent Elements in a Circular Array](/Data%20Structures%2FArray%2F3423.%20Maximum%20Difference%20Between%20Adjacent%20Elements%20in%20a%20Circular%20Array): Find max difference between circular array neighbors

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0048. Rotate Image](/Data%20Structures%2FArray%2F0048.%20Rotate%20Image): Rotate a square matrix 90 degrees clockwise

[0054. Spiral Matrix](/Data%20Structures%2FArray%2F0054.%20Spiral%20Matrix): Traverse a matrix in a spiral pattern

[0056. Merge Intervals](/Data%20Structures%2FArray%2F0056.%20Merge%20Intervals): Merge overlapping intervals in an interval list

[0073. Set Matrix Zeroes](/Data%20Structures%2FArray%2F0073.%20Set%20Matrix%20Zeroes): Set zero if row or column has a zero

[0289. Game of Life](/Data%20Structures%2FArray%2F0289.%20Game%20of%20Life): Determine the next state of a game board with living and dead cells

[1267. Count Servers that Communicate](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures%2FArray%2F1267.%20Count%20Servers%20that%20Communicate): Count the number of servers that can communicate with at least one other server in a grid.

[2033. Minimum Operations to Make a Uni-Value Grid](/Data%20Structures%2FArray%2F2033.%20Minimum%20Operations%20to%20Make%20a%20Uni-Value%20Grid): Minimize operations to make all grid values equal

[2364. Count Number of Bad Pairs](/Data%20Structures%2FArray%2F2364.%20Count%20Number%20of%20Bad%20Pairs): Count pairs of elements with bigger elements on right

[2563. Count the Number of Fair Pairs](/Data%20Structures%2FArray%2F2563.%20Count%20the%20Number%20of%20Fair%20Pairs): Count pairs within range [lower, upper] in an array

[2661. First Completely Painted Row or Column](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures/Array/2661.%20First%20Completely%20Painted%20Row%20or%20Column): Determine the first row or column that is completely painted in a 2D grid.

[2780. Minimum Index of a Valid Split](/Data%20Structures%2FArray%2F2780.%20Minimum%20Index%20of%20a%20Valid%20Split): Find earliest split index where halves have equal dominant element

[2918. Minimum Equal Sum of Two Arrays After Replacing Zeros](/Data%20Structures%2FArray%2F2918.%20Minimum%20Equal%20Sum%20of%20Two%20Arrays%20After%20Replacing%20Zeros): Minimize equal array sums by replacing zeros with positive integers

[2948. Make Lexicographically Smallest Array by Swapping Elements](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures%2FArray%2F2948.%20Make%20Lexicographically%20Smallest%20Array%20by%20Swapping%20Elements): Make an array lexicographically smallest by swapping elements at most `k` times.

[3169. Count Days Without Meetings](/Data%20Structures%2FArray%2F3169.%20Count%20Days%20Without%20Meetings): Calculate days without meetings given meeting intervals

[3394. Check if Grid can be Cut into Sections](/Data%20Structures%2FArray%2F3394.%20Check%20if%20Grid%20can%20be%20Cut%20into%20Sections): Determine if a grid can be fully divided into 2 sections
