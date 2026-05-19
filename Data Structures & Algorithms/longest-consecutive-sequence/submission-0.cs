public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);

        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            // start tracking sequence
            if (!set.Contains(nums[i] - 1))
            {
                int length = 1;
                // continuation of number
                while (set.Contains(nums[i] + length))
                {
                    length++;
                }
                count = Math.Max(count, length);
            }
        }
        
        return count;
    }
}
