public class Solution {
    public int MaxProfit(int[] prices) {
        int minDay = prices[0] ;
        int maxProfit = 0 ;
        int profit = 0 ;
        for(int right = 0 ; right<prices.Length ; right++){
            if( prices[right] < minDay ){
                minDay = prices[right];
            }
            profit = prices[right] - minDay;
            maxProfit = Math.Max(profit,maxProfit);
        }
        return maxProfit;
    }
}