public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int minK = right;
        int hoursneeded = 0 ; 
        while(left<=right){
            int mid = left + (right-left)/2;
            for(int i = 0 ; i < piles.Length ; i++){
                hoursneeded += (int)Math.Ceiling((double)piles[i]/mid);
            }
            if(hoursneeded<=h){
                minK = mid;
                right = mid - 1;
            }
            else {
                left = mid + 1 ;
            }

            hoursneeded = 0 ;
        }
        return minK;
    }
}
