public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var item in strs)
        {
            var charArr = item.ToCharArray();
            Array.Sort(charArr);
            string sortedText = new string(charArr);
            if (!dict.TryGetValue(sortedText, out var list))
            {
                list = new List<string>();
                dict[sortedText] = list;
            }

            list.Add(item);
        }
        
        return dict.Values.ToList();
    }
}
