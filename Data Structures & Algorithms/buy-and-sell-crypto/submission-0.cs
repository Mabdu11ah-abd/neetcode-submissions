public class Solution {
    public int MaxProfit(int[] prices) {
        // this is a problem with a sliding window of dynamic size
        int l = 0, r = 1;

int max = 0;

while (r != l && r < prices.Length )
{
    int amount = prices[r] - prices[l];
    max = Math.Max(max, amount);


    if (prices[r] < prices[l])
    {
        l = r;
    }
    r++;
}
return max;
    }
}
