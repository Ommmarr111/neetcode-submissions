public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var dict = new Dictionary<char, int>();

        int left = 0;
        int maxFreq = 0;
        int maxLen = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (!dict.ContainsKey(s[right]))
            {
                dict[s[right]] = 0;
            }

            dict[s[right]]++;

            maxFreq = Math.Max(maxFreq, dict[s[right]]);

            while ((right - left + 1) - maxFreq > k)
            {
                dict[s[left]]--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}