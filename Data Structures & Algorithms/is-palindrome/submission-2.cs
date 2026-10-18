public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length <= 0)
        {
            return false;
        }

        var trimmed = s.Trim();

        int i = 0;
        int j = trimmed.Length - 1;

        while (i <= j)
        {
            if (!char.IsLetterOrDigit(trimmed[i]))
            {
                i++;
            }
            if (!char.IsLetterOrDigit(trimmed[j]))
            {
                j--;
            }
            if (char.ToLower(trimmed[i]) != char.ToLower(trimmed[j]))
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
