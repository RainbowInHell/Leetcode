#include <iostream>
#include <string>

using namespace std;

class Solution {
public:
	int lengthOfLastWord(string s) {
		s.erase(s.find_last_not_of(' ') + 1);
		s.erase(0, s.find_first_not_of(' '));

		auto position = s.find_last_of(' ');

		return position == std::string::npos ? s.length() : s.substr(position + 1).length();
	}
};

int main()
{
	Solution sol;
	cout << sol.lengthOfLastWord("fdsf sdf sdf sdf f");
}