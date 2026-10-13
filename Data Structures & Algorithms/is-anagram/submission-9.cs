public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

       Span<int> counts = stackalloc int[26];

        for (int i = 0; i < s.Length; i++)
        {
            // increment single value count
            counts[s[i] - 'a']++; 
            // decrement same value should be 0 for valid anagram
            counts[t[i] - 'a']--;
        }

        foreach (var item in counts)
        {
            if (item != 0)
            {
                return false;
            }
        }

        return true;
    }
}
