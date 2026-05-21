public class Solution {
    public int MaxArea(int[] heights) {
        int current;
        int max = 0;

        int j = heights.Length - 1;
        int i = 0;

        while (i < j)
        {
            var min = Math.Min(heights[i], heights[j]);
            current = (j - i) * min;
            if (heights[i] > heights[j])
            {
                j--;
            }
            else
            {
                i++;
            }

            if (current > max)
            {
                max = current;
            }
        }

        return max;
    }
}
