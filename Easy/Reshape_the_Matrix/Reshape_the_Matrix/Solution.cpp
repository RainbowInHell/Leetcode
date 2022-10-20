#include <iostream>
#include <iomanip>
#include <algorithm>
#include <functional>
#include <cmath>
#include <cstddef>
#include <vector>

using namespace std;

class Solution {
public:
    vector<vector<int>> matrixReshape(vector<vector<int>>& mat, int r, int c) {
        if (r * c != size(mat) * size(mat[0])) return mat;

        vector<int> tmp;
        for (vector<int>& row : mat)
            for (int& col : row)
                tmp.push_back(col);

        mat.resize(r);
        for (std::vector<std::vector<int> >::iterator it = mat.begin(); it != mat.end(); ++it)
            it->resize(c);

        int i = 0;
        for (vector<int>& row : mat)
            for (int& col : row)
            {
                col = tmp.at(i);
                i++;
            }

        return mat;
    }
};

int main()
{
    vector<vector<int>> matrix =
    {
        {1,2}
    };

    Solution sol;
    auto res = sol.matrixReshape(matrix, 1, 1);

}