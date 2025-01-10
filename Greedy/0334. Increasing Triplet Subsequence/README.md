# [334. Increasing Triplet Subsequence](https://leetcode.com/problems/increasing-triplet-subsequence/description/?envType=study-plan-v2&envId=leetcode-75)

![Difficulty: Medium](https://img.shields.io/badge/Difficulty-Medium-fac31d?style=for-the-badge&logo=)

---

Given an integer array `nums`, return `true` if there exists a triple of indices `(i, j, k)` such that `i < j < k` and `nums[i] < nums[j] < nums[k]`. If no such indices exists, return `false`.

#### Example 1:
```text
Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
```
#### Example 2:
```text
Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
```


#### Example 3:
```text
Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
```


### Constraints

- `1 <= nums.length <= 5 * 105`
- `-231 <= nums[i] <= 231 - 1`
   

