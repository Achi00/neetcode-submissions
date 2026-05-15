public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        var heap = new PriorityQueue<int, int>();
        
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
        
        foreach (var item in dict)
        {
            heap.Enqueue(item.Key, item.Value);
        
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }
        
        
        var arr = new int[k];
        
        for (int i = 0; i < k; i++)
        {
            arr[i] = heap.Dequeue();
        }

        return arr;
    }
}
