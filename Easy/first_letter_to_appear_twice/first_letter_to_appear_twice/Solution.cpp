#include <set>
#include <iostream>

using namespace std;

class Solution {
public:
    char repeatedCharacter(string s) {
        set<char> set;
        int currentSize;

        for (int i = 0; i != s.length(); i++)
        {
            currentSize = set.size();
            set.insert(s.at(i));
            if (set.size() == currentSize)
            {
                return s.at(i);
            }
        }

        return ' ';
    }
};

int main()
{
    Solution sol;
    cout << sol.repeatedCharacter("kajsdkjas");
}