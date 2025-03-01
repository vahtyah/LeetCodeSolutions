# Recursion

**Recursion** is a technique in which a function calls itself in order to solve a problem. It is a powerful tool that can be used to solve a wide variety of problems. In this section, we will explore some problems that can be solved using recursion.

## Key Concepts

1. **Base Case:** A condition that stops the recursive calls and provides a result.
2. **Recursive Case:** The part of the function that calls itself with modified arguments.
3. **Time Complexity:** O(2<sup>N</sup>) for exponential time complexity, O(N!) for factorial time complexity, and O(2<sup>N</sup>) for problems with branching factor 2.
4. **Space Complexity:** O(N) for the recursive call stack.

## Stack Overflow

The recursive calls in a function are stored in the call stack of the program, each stack frame containing the local variables and return address of the function . If the depth of recursion is too large, it can lead to a **stack overflow** error, which occurs when the call stack exceeds its memory limit. To avoid this, it is important to have a base case that stops the recursion or to use techniques like tail recursion optimization.

## Recursion Types

<details>
<summary><strong>1. Direct Recursion</strong>: A function calls itself directly.</summary>

```csharp
public void DirectRecursion(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.WriteLine(n);
    DirectRecursion(n - 1);
}
```
</details>

<details>
<summary><strong>2. Indirect Recursion</strong>Two or more functions call each other in a cycle.</summary>

```csharp
public void FunctionA(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.WriteLine(n);
    FunctionB(n - 1);
}

public void FunctionB(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.WriteLine(n);
    FunctionA(n - 1);
}
```
</details>

<details>
<summary><strong>3. Tail Recursion</strong>:The recursive call is the last operation in the function.</summary>

```csharp
public void TailRecursion(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.WriteLine(n);
    TailRecursion(n - 1);
}
```
</details>

<details>
<summary><strong>4. Non-Tail Recursion</strong>: The recursive call is not the last operation in the function.</summary>

```csharp
public void NonTailRecursion(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.WriteLine(n);
    NonTailRecursion(n - 1);
    Console.WriteLine(n);
}
```
</details>

<details>
<summary><strong>5. Divide and Conquer</strong>: A problem is divided into smaller subproblems that are solved recursively.</summary>

```csharp
public int[README.md](README.md) DivideAndConquer(int[] arr, int left, int right)
{
    if (left == right)
    {
        return arr[left];
    }
    int mid = left + (right - left) / 2;
    int leftSum = DivideAndConquer(arr, left, mid);
    int rightSum = DivideAndConquer(arr, mid + 1, right);
    return leftSum + rightSum;
}
```
</details>