class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let duplicates = [];
        if (nums && nums.length > 0) {
          for (let i = 0; i < nums.length; i++) {
            for (let j = i + 1; j < nums.length; j++) {
              if (nums[i] == nums[j] && !duplicates.includes(nums[i])) {
                return true;
              }
            }
          }
        }
        return false;
    }
}
