class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(arr) {
  const map = new Map();
  for (const srt of arr) {
    const sortedKey = srt.split("").sort().join("");
    if (!map.has(sortedKey)) {
      map.set(sortedKey, []);
    }
    map.get(sortedKey).push(srt);
  }

  return Array.from(map.values());
}
}
