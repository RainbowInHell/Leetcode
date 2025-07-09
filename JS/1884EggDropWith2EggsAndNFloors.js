/**
 * @param {number} totalFloors
 * @return {number}
 */
function twoEggDrop(totalFloors) {
    let movesCount = 0;
    let coveredFloors = 0;

    while (coveredFloors < totalFloors) {
        movesCount += 1;
        coveredFloors += movesCount;
    }

    return movesCount;
}

console.log(twoEggDrop(100));