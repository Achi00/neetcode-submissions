public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);

        int count = 0;
        
        foreach (var item in set)
        {
            if (!set.Contains(item - 1))
            {
                int current = item;
                int length = 1;
                while (set.Contains(current + 1))
                {
                    current++;
                    length++;
                }
                count = Math.Max(count, length);
            }
        
        }
        
        return count;
    }
}
