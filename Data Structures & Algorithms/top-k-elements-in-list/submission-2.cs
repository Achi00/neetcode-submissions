public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                    var dict = new Dictionary<int, int>();
            var heap = new PriorityQueue<int, int>();

            foreach (var num in nums)
            {
                if (!dict.TryGetValue(num, out var val))
                {
                    dict[num] = 1;
                }
                else
                {
                    dict[num] = ++val;
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

            int lenght = nums.Length - k;

            var list = new List<int>(capacity: k);

            for (int i = 0; i < k; i++)
            {
                list.Add(heap.Dequeue());
            }

            return list.ToArray();
    }
}
