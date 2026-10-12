public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dict1.TryGetValue(s[i], out var value))
            {
                dict1[s[i]] = ++value;
            }
            else
            {
                dict1[s[i]] = 1;
            }

            if (dict2.TryGetValue(t[i], out var value2))
            {
                dict2[t[i]] = ++value2;
            }
            else
            {
                dict2[t[i]] = 1;
            }
        }

        // compare 2 dictionary
        foreach (var (key, value) in dict1)
        {
            if (!dict2.TryGetValue(key, out int otherValue) ||
                value != otherValue)
            {
                return false;
            }
        }

        return true;
    }
}
