/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
const minOperations = (nums, k) => {
    let seen = new Set();
    for (let i = nums.length - 1, ops = 0; i >= 0; i--, ops++) {
        if (nums[i] <= k) {
            seen.add(nums[i]);

            if (seen.size === k) {
                return ops + 1;
            }
        }
    }
};

console.log(minOperations([3,2,5,3,1], 3));