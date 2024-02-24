#include <iostream>
#include <cmath>

using namespace std;

class Solution {
public:
    int mySqrt(int x) {

        int oddCounter = 1;
        int count = 0;

        while (x > 0)
        {
            x -= oddCounter;
            oddCounter += 2;
            count++;
        }

        return x == 0 ? count : --count;
    }
};
int main()
{
    Solution sol;
    cout << sol.mySqrt(2);

    return 0;
}