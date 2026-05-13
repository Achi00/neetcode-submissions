public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 1;
            }
            else
            {
                dict[item] += 1;
            }
        }

        var sortedDictionary = dict.OrderBy(x => x.Value);

        var arr = new int[k];

        int i = 0;
        foreach (var item in sortedDictionary.TakeLast(k))
        {
            arr[i] = item.Key;
            i++;
        }

        return arr;
    }
}
