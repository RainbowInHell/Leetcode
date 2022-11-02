#include <iostream>
#include <string>

using namespace std;

class Solution {
public:
    bool isSameAfterReversals(int num) {
        return num % 10 != 0 || num == 0 ? true : false;
    }
};

int main()
{
    Solution sol;
    cout << sol.isSameAfterReversals(10000);
}