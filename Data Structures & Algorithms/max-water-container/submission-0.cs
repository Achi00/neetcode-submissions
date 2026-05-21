public class Solution {
    public int MaxArea(int[] heights) {
        int current;
        int max = 0;
        
        int j = heights.Length - 1;
        
        for (int i = 0; i < heights.Length; i++)
        {
            var min = Math.Min(heights[i], heights[j]);
            current = (j - i) * min;
            if (heights[i] > heights[j])
            {
                j--;
            }
        
            if (current > max)
            {
                max = current;
            }
        }
        
        return max;
    }
}
