namespace LeetCodeSolutions.PrefixSum;

/*
 * 1352. Product of the Last K Numbers
 * Difficulty: Medium
 * Submission Time: 2025-02-14 03:18:02
 * Created by vahtyah on 2025-02-14 03:57:47
*/
 
 using System.Runtime.CompilerServices;
 public class ProductOfNumbers
 {
    private List<int> _stream = new List<int>();

    public ProductOfNumbers()
    {

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(int num)
    {
        int n = _stream.Count;
        if (num == 0)
        {
            _stream.Clear();
            return;
        }
        if (n == 0)
        {
            _stream.Add(num);
        }
        else
        {
            _stream.Add(num * _stream[n - 1]);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int GetProduct(int k)
    {
        if(_stream.Count < k )
        {
            return 0;
        }
        if(_stream.Count == k)
        {
            return _stream[k - 1];
        }
        return _stream[_stream.Count - 1] / _stream[_stream.Count - k - 1];
    }
 }