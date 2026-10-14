public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count <= 0)
        {
            return null;
        }
        return string.Join("!", strs);
    }

    public List<string> Decode(string s) {
        return s.Split('!').ToList();
   }
}
