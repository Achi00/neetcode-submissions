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
var strs = new List<string>();

int i = 0;

while (i < s.Length)
{
    // read length
    int length = 0;

    while (s[i] != '#')
    {
        length = length * 10 + (s[i] - '0');
        i++;
    }

    i++;

    // read word with specified length
    string word = s.Substring(i, length);

    strs.Add(word);

    // move index past the word
    i += length;
}

return strs;
   }
}
