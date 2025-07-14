/**
 * @param {number[]} nums
 * @return {number}
 */
const countAlternatingSubarrayss = function(nums) {
  let retVal = 1;
  let currentStreak = 1;

  for (let i = 1; i < nums.length; i++) {
    if (nums[i] !== nums[i - 1]) {
      currentStreak++;
    } else {
      currentStreak = 1;
    }

    retVal += cur;
  }

  return retVal;
};

console.log(countAlternatingSubarrays([0,1,1,1]));