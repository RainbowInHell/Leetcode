#include <iostream>
#include <vector>
#include <string>

using namespace std;

class Solution {
public:
    string digitSum(string s, int k) {
        if (k >= s.length()) return s;

        string result;
        bool flag = false;
        int tempSumm = 0;

        for (int i = 0; i != s.length(); i++)
        {
            tempSumm += s[i] - '0';

            if ((i + 1) % k == 0)
            {
                result.append(to_string(tempSumm));
                tempSumm = 0;
            }
        }

        if (s.length() % k != 0)
            result.append(to_string(tempSumm));

        return result.length() <= k ? result : digitSum(result, k);
    }
};

int main()
{
    string s = "233";

    Solution sol;
    cout << sol.digitSum(s, 8);
}