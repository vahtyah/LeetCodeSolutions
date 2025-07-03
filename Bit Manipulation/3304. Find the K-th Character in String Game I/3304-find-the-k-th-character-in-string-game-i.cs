namespace LeetCodeSolutions.BitManipulation;

/*
 * 3304. Find the K-th Character in String Game I
 * Difficulty: Easy
 * Submission Time: 2025-07-03 11:58:49
 * Created by vahtyah on 2025-07-03 12:05:14
*/
 
public class Solution {
    public char KthCharacter(int k) {
        return (char) ((int) 'a' + BitOperations.PopCount((uint) k - 1) % 26);
    }
}