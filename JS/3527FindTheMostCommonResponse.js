// /**
//  * @param {string[][]} responses
//  * @return {string}
//  */
// const findCommonResponse = (responses) => {
    
//     let map = new Map();
//     let maxCount = 1;

//     for (let i = 0; i < responses.length; i++) {
//         for (let j = 0; j < responses[i].length; j++) {
//             let str = responses[i][j];
//             let mapEntry = map.get(str);

//             if (mapEntry) {
//                 if (mapEntry.iteration === i) {
//                     continue;
//                 }

//                 let entryCount = ++mapEntry.count;

//                 map.set(str, {count: entryCount, iteration: i});
//                 maxCount = Math.max(maxCount, entryCount);

//             } else {
//                 map.set(str, {count: 1, iteration: i});
//             }
//         }
//     }

//     let result = null;
//     for (let [str, {count}] of map) {
//         if (count === maxCount) {
//             if (result === null || str < result) {
//                 result = str;
//             }
//         }
//     }

//     return result;
// };

/**
 * @param {string[][]} responses
 * @return {string}
 */
const findCommonResponse = (responses) => {
    const uniqueResponsesPerDay = responses.map(day => [...new Set(day)]);

    const frequencyMap = new Map();
    let maxCount = 0;
    let result = null;

    for (const dayResponses of uniqueResponsesPerDay) {
        for (const response of dayResponses) {
            const newCount = (frequencyMap.get(response) || 0) + 1;
            frequencyMap.set(response, newCount);

            if (newCount > maxCount || (newCount === maxCount && response < result)) {
                maxCount = newCount;
                result = response;
            }
        }
    }

    return result;
};

findCommonResponse([["good", "ok"], ["ok", "bad"], ["bad", "notsure"], ["great", "good"]]);