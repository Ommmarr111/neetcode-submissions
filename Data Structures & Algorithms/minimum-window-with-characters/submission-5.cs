public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (t.Length > s.Length)
            return "";

        var dict = new Dictionary<char, int>();

        foreach (char c in t)
        {
            if (!dict.ContainsKey(c))
                dict[c] = 0;

            dict[c]++;
        }

        var curr = new Dictionary<char, int>();

        int left = 0;
        int matched = 0;

        int minStart = 0;
        int minLen = int.MaxValue;

        for (int right = 0; right < s.Length; right++)
        {
            if (!curr.ContainsKey(s[right]))
                curr[s[right]] = 0;

            curr[s[right]]++;

            if (dict.ContainsKey(s[right]) &&
                curr[s[right]] == dict[s[right]])
            {
                matched++;
            }

            while (matched == dict.Count)
            {
                int windowLength = right - left + 1;

                if (windowLength < minLen)
                {
                    minStart = left;
                    minLen = windowLength;
                }

                char leftChar = s[left];

                curr[leftChar]--;

                if (dict.ContainsKey(leftChar) &&
                    curr[leftChar] < dict[leftChar])
                {
                    matched--;
                }

                left++;
            }
        }

        return minLen == int.MaxValue
            ? ""
            : s.Substring(minStart, minLen);
    }
}