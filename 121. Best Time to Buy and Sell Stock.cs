public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int i = 0, j = 1;

        while(j < prices.Length)
        {
            if (prices[j] < prices[i])
                i = j;
            if (prices[j] - prices[i] > maxProfit) 
                maxProfit = prices[j] - prices[i]; 
            j++;
        }
        return maxProfit;
    }
}