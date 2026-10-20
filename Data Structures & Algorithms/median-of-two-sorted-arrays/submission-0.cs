
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);
        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0;
        int right = m;
        int half = (m+n+1)/2;

        while (left <= right)
        {
            int i = left + (right - left) / 2;
            int j = half - i;

            int leftA  = (i == 0) ? int.MinValue : nums1[i - 1];
            int rightA = (i == m) ? int.MaxValue : nums1[i];
            int leftB  = (j == 0) ? int.MinValue : nums2[j - 1];
            int rightB = (j == n) ? int.MaxValue : nums2[j];

            if (leftA <= rightB && leftB <= rightA)
            {
                if ((m + n) % 2 == 1)
                    return Math.Max(leftA, leftB);
                return ((double)Math.Max(leftA, leftB) + Math.Min(rightA, rightB)) / 2.0;
            }
            else if (leftA > rightB)
                right = i - 1;
            else
                left = i + 1;
        }

        return 0; 
    }
}