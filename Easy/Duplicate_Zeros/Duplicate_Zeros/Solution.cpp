#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
    void duplicateZeros(vector<int>& arr) {
        if (find_if(begin(arr), end(arr), [](int i) { return i == 0; }) == end(arr) && all_of(begin(arr), end(arr), [](int i) { return i == 0; }))
            return;

        bool wasInsertedFlag = false;

        for (int i = 0; i != arr.size(); i++)
        {
            if (wasInsertedFlag)
            {
                wasInsertedFlag = false;
                continue;
            }

            if (arr.at(i) == 0)
            {
                arr.insert(begin(arr) + i, 0);
                arr.erase(end(arr) - 1);
                wasInsertedFlag = true;
            }
        }
    }
};

int main()
{
    vector<int> source = { 8,4,5,0,0,0,0,7 };
    Solution sol;

    sol.duplicateZeros(source);

    for (auto elem : source)
    {
        cout << elem << '\n';
    }
}