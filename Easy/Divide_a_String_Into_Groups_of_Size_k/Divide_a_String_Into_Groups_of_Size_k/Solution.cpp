#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    vector<string> divideString(string s, int k, char fill) {
        vector<string> result;

        if (s.length() % k != 0)
        {
            while (s.length() % k != 0)
            {
                s.push_back(fill);
            }
        }

        for (int i = 0; i != s.length(); i += k)
        {
            result.push_back(s.substr(i, k));
        }

        return result;
    }
};

int main()
{
    string s = "abcdefghi";

    Solution sol;
    sol.divideString(s, 3, 'x');
}