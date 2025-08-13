/**
 * @param {number[]} queries
 * @param {number} m
 * @return {number[]}
 */
const processQueries = function(queries, m) {
    const dict = {};

    for (let i = 1; i <= m; i++) {
        dict[i] = i - 1;
    }

    let res = [];

    for (let i = 0; i < queries.length; i++) {
        let target = dict[queries[i]];
        res.push(target);

        for (let key in dict) {
            if (queries[i] == key) {
                dict[key] = 0;
            } else {
                if (dict[key] < target) {
                    dict[key]++;
                }
            }
        }
    }

    return res;
};