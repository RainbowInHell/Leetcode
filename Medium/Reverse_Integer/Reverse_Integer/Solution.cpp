#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class Solution {
public:
    int reverse(int x) {
        string tmp{ to_string(x) };
        string resVal{ tmp.rbegin(),tmp.rend() };
        long res = 0;

        if (x < 0)
        {
            resVal.pop_back();
            res = -stol(resVal);
        }
        else if (x == 0)
        {
            return 0;
        }
        else
        {
            if (resVal.back() == '0')
                resVal.pop_back();

            res = stol(resVal);
        }

        return (res > INT_MAX || res < INT_MIN) ? 0 : res;
    }
};

int main()
{
    cout << stol("0");
}