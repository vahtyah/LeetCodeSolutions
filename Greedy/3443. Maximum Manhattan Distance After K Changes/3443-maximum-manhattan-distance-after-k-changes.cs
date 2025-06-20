namespace LeetCodeSolutions.Greedy;

/*
 * 3443. Maximum Manhattan Distance After K Changes
 * Difficulty: Medium
 * Submission Time: 2025-06-20 18:35:22
 * Created by vahtyah on 2025-06-20 18:36:53
*/
 
public unsafe class Solution 
{
    public int MaxDistance(string s, int k) 
    {
        int lat = 0, lon = 0, maxDist = 0;
        int k2 = k << 1;
        
        fixed (char* ptr = s)
        {
            for (int i = 0; i < s.Length; i++) 
            {
                char c = ptr[i];
                
                lat += ((c == 'N') ? 1 : 0) - ((c == 'S') ? 1 : 0);
                lon += ((c == 'E') ? 1 : 0) - ((c == 'W') ? 1 : 0);
                
                int absLat = lat < 0 ? -lat : lat;
                int absLon = lon < 0 ? -lon : lon;
                int possible = absLat + absLon + k2;
                int current = possible < i + 1 ? possible : i + 1;
                
                if (current > maxDist) maxDist = current;
            }
        }
        
        return maxDist;
    }
}