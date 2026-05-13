class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        const splitS = s.split("").sort().join("");
        const splitT = t.split("").sort().join("");
        if (splitS == splitT) {
          return true;
        }
        return false;
    }
}
