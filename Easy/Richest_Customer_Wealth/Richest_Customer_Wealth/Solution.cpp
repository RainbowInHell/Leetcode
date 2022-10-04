#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>

using namespace std;

class Solution {
public:
	int maximumWealth(vector<vector<int>>& accounts) {
		vector<int> tmpVec{};

		for (auto& vec : accounts)
		{
			int initial_sum = 0;
			tmpVec.push_back(accumulate(vec.begin(), vec.end(), initial_sum));
		}

		return *max_element(tmpVec.begin(), tmpVec.end());
	}
};

int main()
{
	Solution sol;

	vector<int> vec1{ 1,5 };
	vector<int> vec2{ 7,3 };
	vector<int> vec3{ 3,5 };

	vector<vector<int>> toPass{ vec1,vec2,vec3 };

	sol.maximumWealth(toPass);
}