public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var pref = new List<int>(nums);
        var suff = new List<int>(nums);

        // calculate prefix
        for (int i = 1; i < nums.Length; i++)
        {
            pref[i] = pref[i - 1] * nums[i];
        }

        // calculate suffix
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suff[i] = suff[i + 1] * nums[i];
        }

        var product = new int[suff.Count];

        for (int i = 0; i < product.Length; i++)
        {
            int left  = (i == 0) ? 1 : pref[i - 1];
            int right = (i == product.Length - 1) ? 1 : suff[i + 1];

            product[i] = left * right;
        }

        return product;
    }
}
