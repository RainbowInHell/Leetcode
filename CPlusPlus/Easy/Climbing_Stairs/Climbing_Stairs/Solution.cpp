#include <iostream>

class Solution {
public:
    int climbStairs(int n) {
        if (n == 1 || n == 2 || n == 3) return n;

        int prev = 2;
        int start = 3;
        int res = 0;

        for (int i = start; i < n; i++)
        {
            res = start + prev;
            prev = start;
            start = res;
        }

        return res;
    }
};

int main()
{
    Solution sol;
    std::cout << sol.climbStairs(23);
}