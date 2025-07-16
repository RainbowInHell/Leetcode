/**
 * @param {number[]} pushed
 * @param {number[]} popped
 * @return {boolean}
 */
const validateStackSequences = (pushed, popped) => {
    let stack = new Array(pushed.length);

    for (let i = 0, j = 0; i < pushed.length; i++) {
        stack.push(pushed[i]);

        if (pushed[i] === popped[j]) {
            let stackHeadIndex = stack.length - 1;
            while (stackHeadIndex >= 0 && stack[stackHeadIndex] === popped[j]) {
                stack.pop();
                j++;
                stackHeadIndex--;

            }
        }
    }

    return stack.length === 0;
};

console.log(validateStackSequences([4,0,1,2,3], [4,2,3,0,1]));