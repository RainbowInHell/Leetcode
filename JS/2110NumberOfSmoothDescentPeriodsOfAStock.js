/**
 * @param {number[]} prices
 * @return {number}
 */
const getDescentPeriods = function(prices) {
    let retVal = 0;
    let contiguousDaysLength = 0;

    for (let i = 1; i < prices.length; i++) {
        if (prices[i - 1] - prices[i] === 1) {
            contiguousDaysLength += 1;
        } else {
            contiguousDaysLength = 1;
        }

        retVal += contiguousDaysLength;
    }

    return retVal
};


console.log(getDescentPeriods([8,6,5,4]));