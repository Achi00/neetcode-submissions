public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var list = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            int l = i + 1;
            int r = nums.Length - 1;
            
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            
            while (r > l)
            {

                int sum = nums[i] + nums[l] + nums[r];
                // calculated 0
                if (nums[i] == -(nums[l] + nums[r]))
                {
                    list.Add(new List<int>() { nums[i], nums[l], nums[r] });
                    l++;
                    r--;
                }
                else if (sum > 0)
                {
                    r--;
                }
                else if (sum < 0)
                {
                    l++;
                }
            }
        }

        return list;
    }
}
