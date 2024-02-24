#include <algorithm>
#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
	string firstPalindrome(vector<string>& words) {
		for (string& str : words) {
			if (equal(begin(str), end(str), rbegin(str), rend(str)))
				return str;
		}

		return "";
		//return *find_if(begin(words), end(words) - 1, [](string str) { return equal(begin(str), end(str), rbegin(str), rend(str)); });
	}
};

int main()
{
	vector<string> words = { "chel", "example","pnp" };

	Solution sol;
	sol.firstPalindrome(words);
}