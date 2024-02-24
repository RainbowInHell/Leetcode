#include <vector>
#include <iostream>
#include <unordered_map>

using namespace std;

class Solution {
public:
	int singleNumber(vector<int>& nums) {
		int result;

		unordered_map<int, int> map;
		for (auto x : nums)
			map[x]++;

		for (auto& pair : map) {
			if (pair.second == 1)
				return pair.first;
		}

		return -1;
	}
};

int main()
{
	vector<int> vec = { 4, 1, 2, 1, 2 };

	Solution sol;
	cout << sol.singleNumber(vec);
}