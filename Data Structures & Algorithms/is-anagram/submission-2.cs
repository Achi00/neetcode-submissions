public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
{
    return false;
}
Dictionary<char, int> sHash = new Dictionary<char, int>();
Dictionary<char, int> tHash = new Dictionary<char, int>();

for (int i = 0; i < s.Length; i++)
{
    sHash[s[i]] = sHash.GetValueOrDefault(s[i], 0) + 1;
    tHash[t[i]] = tHash.GetValueOrDefault(t[i], 0) + 1;
}

return sHash.Count == tHash.Count && !sHash.Except(tHash).Any();
    }
}
