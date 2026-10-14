public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
foreach (var item in strs)
{
    sb.Append(item.Length);
    sb.Append("#");
    sb.Append(item);
}

Console.WriteLine(sb.ToString());
return sb.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
var i = 0;

while (i < s.Length)
{
    int length = 0;
    while (s[i] != '#')
    {
        length = s[i] - '0';
    }

    i++;

    string word = s.Substring(i, length);

    list.Add(word);
}

return list;
   }
}
