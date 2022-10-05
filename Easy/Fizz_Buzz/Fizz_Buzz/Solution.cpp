#include <vector>
#include <string>
#include <iostream>
#include <algorithm>

using namespace std;

class Solution {
public:
    vector<string>  fizzBuzz(int n) {
        vector<string> result;

        while (n > 0)
        {
            if (n % 3 == 0 && n % 5 == 0)
                result.push_back("FizzBuzz");
            else if (n % 3 == 0)
                result.push_back("Fizz");
            else if (n % 5 == 0)
                result.push_back("Buzz");
            else
                result.push_back(to_string(n));

            n--;
        }

        reverse(result.begin(), result.end());

        return result;
    }
};

int main()
{
    Solution sol;

    vector<string> res = sol.fizzBuzz(5);
    for_each(res.begin(), res.end(), [](auto& n) { cout << n << " "; });
}