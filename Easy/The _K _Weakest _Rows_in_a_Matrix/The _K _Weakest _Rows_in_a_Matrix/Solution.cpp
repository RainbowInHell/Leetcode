#include <iostream>
#include <vector>
#include <map>
#include <algorithm>

using namespace std;

bool sortByVal(const pair<int, int>& a,
    const pair<int, int>& b)
{
    return (a.second < b.second);
}

class Solution {
public:
    vector<int> kWeakestRows(vector<vector<int>>& mat, int k) {

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

    const int rowsCount = mat.size();
    map<int, int> tempMap;

    for (int i = 0; i != rowsCount; i++)
    {
        tempMap[i] = count_if(mat[i].begin(), mat[i].end(), [](int i) {return i == 1; });
    }

    vector<pair<int, int>> vec;
    for (auto it2 = tempMap.begin(); it2 != tempMap.end(); it2++)
    {
        vec.push_back(make_pair(it2->first, it2->second));
    }

    sort(vec.begin(), vec.end(), sortByVal);

    vector<int> result;
    for (int i = 0; i < vec.size(); i++)
    {
        result.push_back(vec[i].first);
    }

    for (const auto& elem : result)
    {
        std::cout << elem << " ";
    }

    cout << '\n';
    result.erase(result.begin() + 3, result.end());

    for (const auto& elem : result)
    {
        std::cout << elem << " ";
    }

}