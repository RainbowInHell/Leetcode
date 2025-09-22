/**
 * @param {number[]} piles
 * @return {number}
 */
const maxCoins = (piles) => {
    let retVal = 0;
    piles.sort((a, b) => a - b);

    for (let i = piles.length / 3; i < piles.length; i+= 2) {
        retVal += piles[i];
    }

    return retVal;
};

console.log(maxCoins([2,4,1,2,7,8]));