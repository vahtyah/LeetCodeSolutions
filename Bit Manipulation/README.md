# Bit Manipulation

The *Bit Manipulation* is a programming technique that involves manipulating bits to perform operations like setting,
clearing, toggling, and checking the status of bits in an integer. It is commonly used in various programming problems
to optimize solutions and perform bitwise operations efficiently.

## Key Concepts

1. **Bitwise Operators:** Bitwise operators are used to perform operations at the bit level. Common bitwise operators
   include `&` (AND), `|` (OR), `^` (XOR), `~` (NOT), `<<` (left shift), and `>>` (right shift).
2. **Bitwise Operations:** Bitwise operations are used to manipulate individual bits in an integer. Common bitwise
   operations include setting a bit, clearing a bit, toggling a bit, and checking the status of a bit.
3. **Key Techniques:**
    - **Set a Bit:** Use the OR operator `|` to set a bit at a specific position.
    - **Clear a Bit:** Use the AND operator `&` with the complement `~` to clear a bit at a specific position.
    - **Toggle a Bit:** Use the XOR operator `^` to toggle a bit at a specific position.
    - **Check a Bit:** Use the AND operator `&` to check if a bit is set at a specific position.
    - **Rightmost Set Bit:** Use the AND operator `&` with the two's complement `-num` to get the rightmost set bit.
    - **Count Set Bits:** Use a loop to count the number of set bits in an integer.
    - **Get the Average:** Use bitwise operations to calculate the average of two numbers.
    - **Get the Minimum:** Use XOR and AND operators to get the minimum of two numbers.
    - **Check Same Sign:** Use XOR to check if two numbers have the same sign.
    - **Get Sign of a Number:** Use right shift and OR operators to get the sign of a number.
    - **Swap Sign of a Number:** Use bitwise NOT and addition to swap the sign of a number.
    - **GCD & LCM:** Implement functions to calculate the Greatest Common Divisor (GCD) and Least Common Multiple (LCM)
      of two numbers.

## Solutions

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)
### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[2429. Minimize XOR](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/2429.%20Minimize%20XOR): Minimize the XOR of two numbers by setting a bit.

[2657. Find the Prefix Common Array of Two Arrays](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Bit%20Manipulation/2657.%20Find%20the%20Prefix%20Common%20Array%20of%20Two%20Arrays): Find the prefix common array of two arrays.