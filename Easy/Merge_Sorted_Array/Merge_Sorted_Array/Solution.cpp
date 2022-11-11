#include <algorithm>
#include <iostream> 
#include <vector>
using namespace std;

class Solution {
public:
    void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
        nums1.erase(begin(nums1) + m, end(nums1));
        move(nums2.begin(), nums2.end(), back_inserter(nums1));
        sort(begin(nums1), end(nums1));

        for (auto elem : nums1)
        {
            cout << elem << '\n';
        }
    }
};

int main()
{
    vector<int> vec = { 1 };
    vector<int> vec1 = { };
    Solution sol;
    sol.merge(vec, 1, vec1, 0);
}