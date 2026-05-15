class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        const duplicateMap = new Map();
        for (let i = 0; i < nums.length; i++) {
          duplicateMap.set(i, nums[i]);
          if (duplicateMap.has(nums[i])) {
            return true;
          }
        }
        return false;
    }
}
