namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3484. Design Spreadsheet
 * Difficulty: Medium
 * Submission Time: 2025-09-19 16:10:15
 * Created by vahtyah on 2025-09-19 16:10:42
*/
 
using System.Runtime.CompilerServices;

public class Spreadsheet {
    private readonly Dictionary<string, int> cellToValue;

    public Spreadsheet(int row) {
        cellToValue = new Dictionary<string, int>(row);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void SetCell(string cell, int value) {
        cellToValue[cell] = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void ResetCell(string cell) {
        cellToValue.Remove(cell);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int GetValue(string formula) {
        int i = formula.IndexOf('+');
        string cell1 = formula.Substring(1, i - 1);
        string cell2 = formula.Substring(i + 1);
        int val1 = char.IsLetter(cell1[0]) ? cellToValue.GetValueOrDefault(cell1)
                                           : int.Parse(cell1);
        int val2 = char.IsLetter(cell2[0]) ? cellToValue.GetValueOrDefault(cell2)
                                           : int.Parse(cell2);
        return val1 + val2;
    }
}