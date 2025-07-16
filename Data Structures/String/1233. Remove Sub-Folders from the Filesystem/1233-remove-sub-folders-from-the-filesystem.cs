namespace LeetCodeSolutions.DataStructures/String;

/*
 * 1233. Remove Sub-Folders from the Filesystem
 * Difficulty: Medium
 * Submission Time: 2025-07-19 03:00:15
 * Created by vahtyah on 2025-07-19 03:00:53
*/
 
public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder, StringComparer.Ordinal);

        int writeIndex = 1;
        string currentPrefix = folder[0] + '/';

        for(int readIndex = 1; readIndex < folder.Length; readIndex++){
            if(!folder[readIndex].StartsWith(currentPrefix, StringComparison.Ordinal)){
                currentPrefix = folder[readIndex] + '/';
                folder[writeIndex++] = folder[readIndex];
            }
        }

        Array.Resize(ref folder, writeIndex);
        return folder;
    }
}