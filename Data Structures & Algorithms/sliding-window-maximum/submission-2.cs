public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
     var deque = new LinkedList<int>();
     var res = new List<int>();
     int left = 0;
     for (int right = 0; right < nums.Length; right++) {
        while (deque.Count > 0 && nums[deque.Last.Value] < nums[right])
        {
            deque.RemoveLast();
        }
        deque.AddLast(right);
        if (deque.First.Value < left)
            deque.RemoveFirst();
        if (right - left + 1 >= k)
        {
            res.Add(nums[deque.First.Value]);
            left++;
        }
     }

    return res.ToArray();
    }
}