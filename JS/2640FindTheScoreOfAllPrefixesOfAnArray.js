/**
 * @param {number[]} nums
 * @return {number[]}
 */
let findPrefixScore = function(nums) {
    let prefixSum = 0;
    let lastMax= Number.MIN_SAFE_INTEGER;

    return nums.map(currentNum => {
        lastMax = Math.max(lastMax, currentNum);

        return prefixSum += currentNum + lastMax;
    })
};

findPrefixScore = nums => {
    let currentMax = Number.MIN_SAFE_INTEGER;
    let prefixSum = 0;

    return nums.reduce((result, currentNum) => {
        currentMax = Math.max(currentMax, currentNum);
        prefixSum += currentNum + currentMax;

        result.push(prefixSum);
        return result;
    }, []);
};

console.log(findPrefixScore([2,3,7,5,10]));