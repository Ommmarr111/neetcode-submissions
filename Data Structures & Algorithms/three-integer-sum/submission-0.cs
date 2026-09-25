public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
         List<List<int>> list = new List<List<int>>();
        Array.Sort(nums);
        for(int i = 0 ; i < nums.Length ; i++) {
            if (i > 0 && nums[i] == nums[i - 1])
            continue;
            int fixedNum = nums[i];
            int left = i + 1 , right = nums.Length - 1 ;
            while(left<right) {
            if(fixedNum + nums[left] + nums[right] < 0)
                left++;
            else if(fixedNum + nums[left] + nums[right] > 0)
                right--;
            else {
                list.Add(new List<int>{fixedNum , nums[left] , nums[right]});
                left++;
                right--;
                while (left < right && nums[left] == nums[left - 1])
                {
                    left++;
                }

                while (left < right && nums[right] == nums[right + 1])
                {
                    right--;
                }
            }
            }
        }
        return list;
    }
}
