#include <algorithm>
#include <iterator>
#include <iostream>
#include <string>

using namespace std;

bool isPalindrome(int x) {
	string tmp = to_string(x);

	return std::equal(tmp.begin(), tmp.end(), tmp.rbegin(), tmp.rend());
}

int main()
{
	cout << isPalindrome(121);

	return 0;
}