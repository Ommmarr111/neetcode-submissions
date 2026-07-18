public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numbers = new Dictionary<int,int>();
        for(int i = 0 ; i<nums.Length ; i++){
            if(!numbers.ContainsKey(nums[i])){
                numbers[nums[i]] = 0;
            }
            numbers[nums[i]]++;
        }
        return numbers
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();    }
}
