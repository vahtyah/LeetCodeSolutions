namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2043. Simple Bank System
 * Difficulty: Medium
 * Submission Time: 2025-10-26 02:09:24
 * Created by vahtyah on 2025-10-26 02:10:09
*/
 
public class Bank {
    private long[] _balance;
    private int n;

    public Bank(long[] balance) {
        _balance = balance;  
        n = balance.Length;  
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public bool Transfer(int account1, int account2, long money) {
        if(account1 > n || account2 > n || _balance[account1 - 1] < money) return false;
        _balance[account1 - 1] -= money;
        _balance[account2 - 1] += money;
        return true;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public bool Deposit(int account, long money) {
        if(account > n) return false;
        _balance[account - 1] += money;
        return true;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public bool Withdraw(int account, long money) {
        if(account > n || _balance[account - 1] < money) return false;
        _balance[account - 1] -= money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */