namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3169. Count Days Without Meetings
 * Difficulty: Medium
 * Submission Time: 2025-03-24 06:13:36
 * Created by vahtyah on 2025-03-24 06:14:07
*/
 
public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings, (x, y) => x[0].CompareTo(y[0]));
        var newMeetings = new int[meetings.Length][];
        var index = 0;
        newMeetings[index] = meetings[0];
        for(int i = 1; i < meetings.Length; i++){
            if(meetings[i][1] < newMeetings[index][1]) continue;
            if(meetings[i][0] <= newMeetings[index][1]){
                newMeetings[index][1] = meetings[i][1];
            }
            else{
                newMeetings[++index] = meetings[i];
            }
        }

        var availDays = newMeetings[0][0] - 1;

        for(int i = 1; i <= index; i++){
            availDays += newMeetings[i][0] - newMeetings[i - 1][1] - 1;
        }
        availDays += days - newMeetings[index][1];

        return availDays;
    }
}