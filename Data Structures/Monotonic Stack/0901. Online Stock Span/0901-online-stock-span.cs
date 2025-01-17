public class StockSpanner {
    private Stack<(int price, int span)> prices;

    public StockSpanner() {
        prices = new();
    }
    
    public int Next(int price) {
        var count = 1;
        while (prices.Count > 0 && prices.Peek().price <= price) {
            var item = prices.Pop();
            count += item.span;
        }

        prices.Push((price, count));
        return count;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */