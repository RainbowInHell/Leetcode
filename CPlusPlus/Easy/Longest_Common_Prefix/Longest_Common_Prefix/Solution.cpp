#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {

        char charToCheck;
        string result;
        string shortestWord = *min_element(strs.begin(), strs.end(),
            [](const auto& a, const auto& b) {
                return a.size() < b.size();
            });

        for (int i = 0; i < shortestWord.length(); i++)
        {
            charToCheck = shortestWord[i];

            if (all_of(begin(strs), end(strs), [&charToCheck, &i](string elem) {return elem[i] == charToCheck; }))
                result += charToCheck;
            else
                break;
        }

        return result;
    }
};

int main()
{
    vector<string> vec{ "" };
    Solution sol;
    cout << sol.longestCommonPrefix(vec);

}