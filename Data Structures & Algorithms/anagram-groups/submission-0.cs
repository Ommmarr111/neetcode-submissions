public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if(!anagrams.ContainsKey(key)){
                anagrams[key] = new List<string>();
                
            }

            anagrams[key].Add(word);
        }
        return anagrams.Values.ToList<List<string>>();
    }
}
