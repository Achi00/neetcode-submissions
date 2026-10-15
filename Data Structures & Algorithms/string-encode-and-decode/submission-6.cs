public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (var item in strs)
        {
            sb.Append(item.Length);
            sb.Append("#");
            sb.Append(item);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        var i = 0;

        while (i < s.Length)
        {
            int length = 0;

            // count non # characters
            while (s[i] != '#')
            {
                // char to int
                length = length * 10 + (s[i] - '0');
                i++;
            }

            // skip #
            i++;

            list.Add(s.Substring(i, length));

            i += length;
        }

        return list;
   }
}
