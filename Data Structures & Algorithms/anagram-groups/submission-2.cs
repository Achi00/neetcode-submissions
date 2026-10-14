public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var item in strs)
        {
            int[] counts = new int[26];
        
            // fill with characters
            foreach (var c in item)
            {
                counts[c - 'a']++;
            }
        
            string key = string.Join(",", counts);
        
            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }
            dict[key].Add(item);
        }
        
        return dict.Values.ToList();
    }
}
