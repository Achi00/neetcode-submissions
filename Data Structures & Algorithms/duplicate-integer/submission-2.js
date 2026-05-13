class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        const duplicateMap = new Map();
  for (let i = 0; i < nums.length; i++) {
    if (duplicateMap.has(nums[i])) {
      return true;
    }
    duplicateMap.set(nums[i], nums[i]);
  }
        return false;
    }
}
