public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;
        
        while (l <= r)
        {
            if (numbers[l] + numbers[r] == target)
            {
                return new int[] { numbers[l], numbers[r] };
            }
            else if (numbers[l] + numbers[r] < target)
            {
                l++;
            }
            else if (numbers[l] + numbers[r] > target)
            {
                r--;
            }
        }
        
        return Array.Empty<int>();
    }
}
