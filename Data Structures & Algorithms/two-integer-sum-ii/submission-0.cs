public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0 , right = numbers.Length - 1 ;
        int[] res = new int[2];
        while(left<right){
            int num = numbers[left]+numbers[right];
            if(num<target)
            left++;
            else if(num>target)
            right--;
            else {
                res[0]=left+1;
                res[1]=right+1;
                return res;
            }
        }
    return new int[2];
    }
}