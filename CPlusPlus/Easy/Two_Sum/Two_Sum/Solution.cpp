#include <iostream>
#include <vector>
#include <ranges>
#include <algorithm>

using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> result;

        int i = 0;
        while (i < nums.size())
        {
            int tmp = nums[i];

            for (int j = i + 1; j < nums.size(); j++)
            {
                if (tmp + nums[j] == target)
                {
                    result.push_back(i);
                    result.push_back(j);
                    goto Exit;
                }
            }

            i++;
        }

    Exit:
        return result;
    }
};

int main()
{
    vector<int> vector{ 3,2,4 };

    Solution sol;
    for (auto& elem : sol.twoSum(vector, 6))
    {
        cout << elem << " ";
    }
}