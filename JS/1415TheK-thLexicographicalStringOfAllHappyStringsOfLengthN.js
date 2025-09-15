var getHappyString = function(n, k) {
    const chars = ['a', 'b', 'c'];
    const strings = [];

    const recursion = (currentString) => {
        if (currentString.length === n) {
            strings.push(currentString);
            return;
        }

        for (let char of chars) {
            if (currentString[currentString.length - 1] === char) {
                continue;
            }

            recursion(currentString + char);
        }
    }

    for (let char of chars) {
        recursion(char);
    }

    if (strings.length < k) {
        return "";
    }

    return strings[k - 1];
};