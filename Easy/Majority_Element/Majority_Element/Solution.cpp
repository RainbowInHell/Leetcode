#include <set>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

class Solution {
public:
	int majorityElement(vector<int>& nums) {
		set<int> set(begin(nums), end(nums));

		int retVal = 0;
		int currentCount = 0;
		int tempCount = 0;

		for (const int& elem : set)
		{
			currentCount = count(begin(nums), end(nums), elem);

			if (currentCount > tempCount)
			{
				retVal = elem;
				tempCount = currentCount;
			}
		}

		return retVal;
	}
};

int main()
{
	vector<int> vec = { 2,2,1,1,1,2,2 };

	Solution sol;
	sol.majorityElement(vec);
}
