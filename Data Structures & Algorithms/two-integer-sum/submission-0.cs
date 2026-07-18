public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> stored = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (stored.ContainsKey(target - nums[i]))
            {
                return new int[] { stored[target - nums[i]] , i };
            }

            stored[nums[i]] = i;
        }

        return new int[0];
    }
}
