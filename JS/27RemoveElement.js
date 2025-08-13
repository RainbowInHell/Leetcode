/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
const removeElement = function(nums, val) {
    let write = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] !== val) {
            nums[write] = nums[i];
            write++;
        }
    }  

    nums.length = write;
    return write;
}

const nums = [3,2,2,3];
console.log(removeElement(nums, 3));