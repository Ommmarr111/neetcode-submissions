public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        return false;
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        for (int i = 0 ; i <s.Length ; i++){
            if (!dict1.ContainsKey(s[i]))
             {
                dict1[s[i]] = 0;
             }
             dict1[s[i]]++;
        }
        for (int i = 0 ; i <t.Length ; i++){
            if (!dict2.ContainsKey(t[i]))
             { 
                dict2[t[i]] = 0;
             }
             dict2[t[i]]++;
        }
        if (dict1.Count != dict2.Count)
            return false;
        foreach (var item in dict1)
            {
                if(!dict2.ContainsKey(item.Key) || dict2[item.Key]!=item.Value){
                    return false;
            }
            }
            return true;
            

    }
}
