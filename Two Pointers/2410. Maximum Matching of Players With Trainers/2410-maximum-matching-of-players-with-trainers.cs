namespace LeetCodeSolutions.TwoPointers;

/*
 * 2410. Maximum Matching of Players With Trainers
 * Difficulty: Medium
 * Submission Time: 2025-07-13 07:37:14
 * Created by vahtyah on 2025-07-13 07:37:54
*/
 
public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        Array.Sort(players);
        Array.Sort(trainers);

        if (players[0] > trainers[^1]) return 0;
        if (players[^1] <= trainers[0]) return Math.Min(players.Length, trainers.Length);

        int playerIndex = players.Length - 1, trainerIndex = trainers.Length - 1;
        
        int matches = 0;

        while(playerIndex >= 0 && trainerIndex >=0){
            if(players[playerIndex] <= trainers[trainerIndex]){
                matches++;
                trainerIndex--;
            }
            playerIndex--;
        }

        return matches;
    }
}