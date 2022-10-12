#include <iostream>
#include <vector>
#include <map>
#include <algorithm>

using namespace std;

class Solution {
public:
    static bool sortByVal(const pair<int, int>& a, const pair<int, int>& b)
    {
        if (a.second == b.second) {
            return a.second < b.second;
        }
        return a.second < b.second;
    }

    vector<int> kWeakestRows(vector<vector<int>>& mat, int k) {

        vector<int> result(k);
        vector<pair<int, int>> vectorOfPairs{ mat.size() };
        int soldiersCount = 0;

        for (int i = 0; i != mat.size(); i++)
        {
            soldiersCount = count_if(mat[i].begin(), mat[i].end(), [](int i) {return i == 1; });
            vectorOfPairs[i] = make_pair(i, soldiersCount);
        }

        sort(vectorOfPairs.begin(), vectorOfPairs.end(), sortByVal);

        for (int i = 0; i < k; i++)
            result[i] = vectorOfPairs[i].first;

        return result;
    }
};

int main()
{
    vector<vector<int>> mat =
    {
        {1, 1, 0, 0, 0} ,
        {1, 1, 1, 1, 0 },
        {1, 0, 0, 0, 0},
        {1, 1, 0, 0, 0},
        {1, 1, 1, 1, 1}
    };
    int k = 3;

    Solution sol;

    for (auto& elem : sol.kWeakestRows(mat, k))
        cout << elem << " ";
}