# [1422. Maximum Score After Splitting a String](https://leetcode.com/problems/maximum-score-after-splitting-a-string/description/?envType=daily-question&envId=2025-01-01)

![Difficulty: Easy](https://img.shields.io/badge/Difficulty-Easy-46c6c2?style=for-the-badge&logo=)
---

Given a string `s` of zeros and ones, return the **maximum score** after splitting the string into two **non-empty** substrings (i.e., left substring and right substring).

The **score** after splitting a string is the number of `zeros` in the **left substring** plus the number of `ones` in the **right substring**.

#### Example 1:
```text
Input: s = "011101"
Output: 5 
Explanation: 
All possible ways of splitting s into two non-empty substrings are:
left = "0" and right = "11101", score = 1 + 4 = 5 
left = "01" and right = "1101", score = 1 + 3 = 4 
left = "011" and right = "101", score = 1 + 2 = 3 
left = "0111" and right = "01", score = 1 + 1 = 2 
left = "01110" and right = "1", score = 2 + 1 = 3
```
#### Example 2:
```text
Input: s = "00111"
Output: 5
Explanation: When left = "00" and right = "111", we get the maximum score = 2 + 3 = 5
```


#### Example 3:
```text
Input: s = "1111"
Output: 3
```


### Constraints

- `2 <= s.length <= 500`
- The string `s` consists of characters `'0'` and `'1'` only.

### Another solututions
[Prefix Sum](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Prefix%20Sum/1422.%20Maximum%20Score%20After%20Splitting%20a%20String)

   

