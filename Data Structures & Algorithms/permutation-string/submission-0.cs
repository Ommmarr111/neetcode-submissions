public class Solution
{
    bool AreEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        if (dict1.Count != dict2.Count)
            return false;

        foreach (var pair in dict1)
        {
            if (!dict2.ContainsKey(pair.Key))
                return false;

            if (dict2[pair.Key] != pair.Value)
                return false;
        }

        return true;
    }

    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach (char c in s1)
        {
            if (!dict1.ContainsKey(c))
                dict1[c] = 0;

            dict1[c]++;
        }

        int left = 0;

        for (int right = 0; right < s2.Length; right++)
        {
            if (!dict2.ContainsKey(s2[right]))
                dict2[s2[right]] = 0;

            dict2[s2[right]]++;

            if (right - left + 1 > s1.Length)
            {
                dict2[s2[left]]--;

                if (dict2[s2[left]] == 0)
                    dict2.Remove(s2[left]);

                left++;
            }

            if (right - left + 1 == s1.Length)
            {
                if (AreEqual(dict1, dict2))
                    return true;
            }
        }

        return false;
    }
}