#include <vector>
#include <iostream>

using namespace std;

class Solution {
public:
    vector<int> runningSum(vector<int>& nums) {
        int prevSumm = 0;
        vector<int> result;

        for (int i = 0; i != nums.size(); i++)
        {
            prevSumm += nums.at(i);
            result.push_back(prevSumm);
        }

        return result;
    }
};

int main()
{
    vector<int> vec = { 1 };
    Solution sol;
    sol.runningSum(vec);
}