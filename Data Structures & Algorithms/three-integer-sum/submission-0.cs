public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var list = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;

            if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
            while (k > j)
            {
                // calculated 0
                if (nums[i] == -(nums[j] + nums[k]))
                {
                    list.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    j++;
                    k--;
                }
                else if (nums[i] > (nums[j] + nums[k]))
                {
                    j++;
                }
                else if (nums[i] < (nums[j] + nums[k]))
                {
                    k--;
                }
            }
        }

        return list;
    }
}
