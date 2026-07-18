public class Solution {

    public string Encode(IList<string> strs) {
            StringBuilder sb = new StringBuilder();

    foreach (string word in strs)
    {
        sb.Append(word.Length);
        sb.Append('#');
        sb.Append(word);
    }

    return sb.ToString();
    }

    public List<string> Decode(string s) {

    List<string> result = new List<string>();
    int i = 0;

    while (i < s.Length)
    {
        int j = i;
        while (s[j] != '#')
        {
            j++;
        }
        int length = int.Parse(s.Substring(i, j - i));
        j++;
        string word = s.Substring(j, length);
        result.Add(word);
        i = j + length;
    }

    return result;
   }
}
