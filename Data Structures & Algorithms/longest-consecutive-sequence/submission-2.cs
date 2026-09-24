public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Length <= 1)
        return nums.Length;
        int maxLen = int.MinValue;
        var seen = new HashSet <int>(nums);
        foreach (int num in seen)
        {
            if (!seen.Contains(num-1))
            {
            int curLen = 1;

            while (seen.Contains(num + curLen))
            {
                curLen++;
            }
            if (maxLen < curLen)
                maxLen = curLen;
            }
        }
        return maxLen;
    }
}