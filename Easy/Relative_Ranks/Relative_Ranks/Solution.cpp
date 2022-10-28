#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <malloc.h>
#include <cstdlib>

using namespace std;

class Solution {
public:
    vector<string> findRelativeRanks(vector<int>& score) {

        vector<string> result(score.size());
        int temp = 0;
        int* arrayOfIndexes = (int*)malloc(sizeof(int) * score.size());

        while (temp != score.size())
        {
            *(arrayOfIndexes + temp) = temp;
            temp++;
        }
        temp = 0;

        sort(arrayOfIndexes, arrayOfIndexes + score.size(), [score](int index_left, int index_right) { return score[index_left] > score[index_right]; });

        while (temp != score.size())
        {
            if (temp == 0)
                result.at(*(arrayOfIndexes + temp)) = "Gold Medal";
            else if (temp == 1)
                result.at(*(arrayOfIndexes + temp)) = "Silver Medal";
            else if (temp == 2)
                result.at(*(arrayOfIndexes + temp)) = "Bronze Medal";
            else
                result.at(*(arrayOfIndexes + temp)) = to_string(temp + 1);

            temp++;
        }

        free(arrayOfIndexes);
        return result;
    }
};

int main()
{
    Solution sol;
    sol.findRelativeRanks();
}