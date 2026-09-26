public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0 , right = heights.Length - 1;
        int maxArea = 0;

        while(left<right){
            int width = right - left ;
            int h = Math.Min(heights[left],heights[right]);
            int Area = width * h ;
            if(Area>maxArea){
                maxArea=Area;
            }
            if (heights[left] < heights[right])
            left++;
            else
            right--;
        }

        return maxArea;

        
    }
}