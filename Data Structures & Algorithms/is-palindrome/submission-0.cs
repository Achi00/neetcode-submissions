public class Solution {
    public bool IsPalindrome(string s) {
        string strip = new string(s.Where(x => char.IsLetterOrDigit(x)).ToArray()).ToLower();
        int j = strip.Length - 1;
        int i = 0;
        
        while (i <= j)
        {
            if (strip[i] == strip[j])
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}
