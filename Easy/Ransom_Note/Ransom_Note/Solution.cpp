#include <algorithm>
#include <vector>
#include <iostream>

using namespace std;

class Solution {
private:
    struct iSInSequence
    {
        const int d;
        iSInSequence(int n) : d(n) {}
        bool operator()(int n) const { return n == d; }
    };

public:
    bool canConstruct(string ransomNote, string magazine) {

        auto it = ransomNote.begin();
        int cnt = 0;

        while (it != ransomNote.end())
        {
            if (any_of(magazine.begin(), magazine.end(), iSInSequence(*it)))
            {
                *find_if(magazine.begin(), magazine.end(), iSInSequence(*it)) = '~';
                cnt++;
                if (cnt == ransomNote.length())
                    return true;
            }
            it++;
        }

        return false;
    }
};

int main()
{
    Solution sol;
    sol.canConstruct("aa", "cbaa");
}