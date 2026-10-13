public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict1 = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            dict1[s[i]] = dict1.GetValueOrDefault(s[i]) + 1;
            dict1[t[i]] = dict1.GetValueOrDefault(t[i]) - 1;
        }
        
        // compare 2 dictionary
        foreach (var c in dict1.Values)
        {
            if (c != 0)
            {
                return false;
            }
        }

        return true;
    }
}
