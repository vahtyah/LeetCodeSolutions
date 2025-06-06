# Bit Manipulation

The *Bit Manipulation* is a programming technique that involves manipulating bits to perform operations like setting,
clearing, toggling, and checking the status of bits in an integer. It is commonly used in various programming problems
to optimize solutions and perform bitwise operations efficiently.

### Bitwise Operators
- **AND (`&`):** The AND operator compares two bits and returns 1 if both bits are 1; otherwise, it returns 0.
  
    | A | B | A & B |
    |---|---|-------|
    | 0 | 0 |   0   |
    | 0 | 1 |   0   |
    | 1 | 0 |   0   |
    | 1 | 1 |   1   |

- **OR (`|`):** The OR operator compares two bits and returns 1 if at least one bit is 1; otherwise, it returns 0.
  
    | A | B | A \| B |
    |---|---|--------|
    | 0 | 0 |   0    |
    | 0 | 1 |   1    |
    | 1 | 0 |   1    |
    | 1 | 1 |   1    |

- **XOR (`^`):** The XOR operator compares two bits and returns 1 if the bits are different; otherwise, it returns 0.
  
    | A | B | A ^ B |
    |---|---|------|
    | 0 | 0 |   0  |
    | 0 | 1 |   1  |
    | 1 | 0 |   1  |
    | 1 | 1 |   0  |

- **NOT (`~`):** The NOT operator inverts each bit in a number, changing 1 to 0 and 0 to 1.
      
     | A | ~A |
     |---|----|
     | 0 |  1 |
     | 1 |  0 |

- **Left Shift (`<<`):** The left shift operator shifts the bits of a number to the left by a specified number of positions.
      
     `num << k` is equivalent to `num * 2^k`.

- **Right Shift (`>>`):** The right shift operator shifts the bits of a number to the right by a specified number of positions.
      
     `num >> k` is equivalent to `num / 2^k`.

### Formulas and Techniques
```csharp
// Get the rightmost set bit of x
x & -x // gives the rightmost set bit of x 
1100 & -1100 = 0100 (which is 4 in decimal)

// Set a bit at position i
int setBit = num | (1 << i);

// Clear a bit at position i
int clearBit = num & ~(1 << i);

// Toggle a bit at position i
int toggleBit = num ^ (1 << i);

// Check if a bit at position i is set
bool isSet = (num & (1 << i)) != 0;

// Get the rightmost set bit
int rightmostSetBit = num & -num;

// Count the number of set bits
int countBits = 0;
while(n > 0) {
    countBits += n & 1;
    n >>= 1;
}
```

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0067. Add Binary](/Bit%20Manipulation%2F0067.%20Add%20Binary): Sum two binary strings, return their binary sum

[0136. Single Number](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/0136.%20Single%20Number): Find the single number that appears only once in an array of integers.

[0338. Counting Bits](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/0338.%20Counting%20Bits): Count the number of 1 bits in the binary representation of each number from 0 to n.

[1550. Three Consecutive Odds](/Bit%20Manipulation%2F1550.%20Three%20Consecutive%20Odds): Check for three consecutive odd numbers in array

[1863. Sum of All Subset XOR Totals](/Bit%20Manipulation%2F1863.%20Sum%20of%20All%20Subset%20XOR%20Totals): Calculate XOR sum of all subsets' XOR totals

[2206. Divide Array Into Equal Pairs](/Bit%20Manipulation%2F2206.%20Divide%20Array%20Into%20Equal%20Pairs): Check if array elements can form equal pairs

[3151. Special Array I](/Bit%20Manipulation%2F3151.%20Special%20Array%20I): Find the minimum integer in an array such that the number of elements less than or equal to it is greater than or equal to the integer itself

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0036. Valid Sudoku](/Bit%20Manipulation%2F0036.%20Valid%20Sudoku): Determine if a Sudoku board is valid

[1261. Find Elements in a Contaminated Binary Tree](/Bit%20Manipulation%2F1261.%20Find%20Elements%20in%20a%20Contaminated%20Binary%20Tree): Find nodes matching a given set of values in a contaminated binary tree

[1318. Minimum Flips to Make a OR b Equal to c](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/1318.%20Minimum%20Flips%20to%20Make%20a%20OR%20b%20Equal%20to%20c): Find the minimum number of flips to make `a | b` equal to `c`.

[2401. Longest Nice Subarray](/Bit%20Manipulation%2F2401.%20Longest%20Nice%20Subarray): Find the longest subarray with pairwise bitwise AND zero

[2425. Bitwise XOR of All Pairings](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/2425.%20Bitwise%20XOR%20of%20All%20Pairings): Calculate the bitwise XOR of all possible pairings of an array.

[2429. Minimize XOR](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/2429.%20Minimize%20XOR): Minimize the XOR of two numbers by setting a bit.

[2657. Find the Prefix Common Array of Two Arrays](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/2657.%20Find%20the%20Prefix%20Common%20Array%20of%20Two%20Arrays): Find the prefix common array of two arrays.

[2683. Neighboring Bitwise XOR](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/2683.%20Neighboring%20Bitwise%20XOR): Calculate the bitwise XOR of neighboring elements in an array.

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0052. N-Queens II](/Bit%20Manipulation%2F0052.%20N-Queens%20II): Count the number of valid N-Queens placements
