#include <iostream>
class Solution {
public:
    int numberOfSteps(int num) {
        int retVal = 0;

        while (num != 0)
        {
            if (num % 2 == 0)
                num /= 2;
            else
                num -= 1;

            ++retVal;
        }

        return retVal;
    }
};

int main()
{
    Solution sol;

    std::cout << sol.numberOfSteps(123);
}
