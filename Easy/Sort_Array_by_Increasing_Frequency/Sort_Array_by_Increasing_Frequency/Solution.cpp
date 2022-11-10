#include <vector>
#include <iostream>
#include <algorithm>
#include <unordered_map>

using namespace std;

class Solution {
public:
    vector<int> frequencySort(vector<int>& nums) {
        unordered_map<int, int> freq;
        for (auto& num : nums) {
            freq[num]++;
        }

        sort(begin(nums), end(nums), [&freq](int a, int b) {
            if (freq[a] == freq[b]) {
                return a > b;
            }

        return freq[a] < freq[b]; });

        return nums;
    }
};

int main()
{
    vector<int> vec = { 1,1,2,2,3 };

    Solution sol;
    sol.frequencySort(vec);
}