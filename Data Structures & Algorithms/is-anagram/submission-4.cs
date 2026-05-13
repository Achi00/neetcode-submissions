public class Solution {
    public bool IsAnagram(string s, string t) {
            if (s.Length != t.Length)
{
    return false;
}
else
{
    var dict1 = new Dictionary<char, int>();
    var dict2 = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        if (dict1.ContainsKey(s[i]))
        {
            dict1[s[i]] += 1;
        }
        else
        {
            dict1[s[i]] = 1;
        }
        if (dict2.ContainsKey(t[i]))
        {
            dict2[t[i]] += 1;
        }
        else
        {
            dict2[t[i]] = 1;
        }
    }

    if (dict1.Count == dict2.Count)
    {
        foreach (var item in dict1)
        {
            if (!dict2.ContainsKey(item.Key))
            { 
                return false;
            }
            else if (dict2[item.Key] != item.Value)
            {
                return false;
            }
        }
    }
    else
    {
        return false;
    }
}

return true;
    }
}